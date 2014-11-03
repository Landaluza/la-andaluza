Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmPedidosClientesDetalles2
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private m_VerID As Boolean = True
    Public mercadona As Boolean
    Private frmEnt As frmEntPedidosClientesDetalles2

    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spPedidosClientesDetalles2, MaestroID)
        InitializeComponent()

        spSelectDgv = "PedidosClientesDetalles2SelectDgvByPedidoClienteDatalleID '" & MaestroID & "'"

        m_VerID = False
        mercadona = False
    End Sub

    Public Sub New()
        MyBase.New(New spPedidosClientesDetalles2, 0)
        InitializeComponent()
        spSelectDgv = "PedidosClientesDetalles2SelectDgv"
        mercadona = False
    End Sub


    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim dtb As New BasesParaCompatibilidad.DataBase
            If CType(sp, spPedidosClientesDetalles2).PedidosClientesDetalles2Delete(dgvGeneral.CurrentRow.Cells("PedidoClienteDatalleID").Value, dtb) Then
                dgvFill()
            End If
        End If
    End Sub

    Overrides Sub Action(ByVal TipoAction As String)
        Dim m_PedidosClientesDetalles2 As New DBO_PedidosClientesDetalles2
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then

            If m_MaestroID <> 0 Then m_PedidosClientesDetalles2.PedidoclienteMaestroID = m_MaestroID
        Else
            Dim dtb As New BasesParaCompatibilidad.DataBase
            m_PedidosClientesDetalles2 = CType(sp, spPedidosClientesDetalles2).Select_Record(GeneralBindingSource(m_Pos).Item("PedidoClienteDatalleID"), dtb)
        End If

        frmEnt = New frmEntPedidosClientesDetalles2(m_PedidosClientesDetalles2, m_Pos, m_VerID, mercadona)
        frmEnt.Text = String.Format("{0} {1}", TipoAction, Me.Text)

        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)

        dgvFill()
    End Sub

    Protected Overrides Sub cargar_datos()
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dataSource = dtb.Consultar(spSelectDgv, True)
    End Sub

    Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource


            butExcel.Visible = True

            With dgvGeneral
                .DataSource = GeneralBindingSource

                .Columns("PedidoClienteDatalleID").Visible = False
                .Columns("PedidoclienteMaestroID").Visible = False
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, 460, 2)
                .FormatoColumna("Cantidad", BasesParaCompatibilidad.TiposColumna.Miles, 66, 3)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, 226, 5)
                .FormatoGeneral()
            End With
        End If
    End Sub
End Class
