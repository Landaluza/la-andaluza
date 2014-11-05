Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmPedidosClientesMaestros2
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private m_VerID As Boolean = True
    Private frmEnt As frmEntPedidosClientesMaestros2
    Private m_PedidosClientesMaestros2 As DBO_PedidosClientesMaestros2
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spPedidosClientesMaestros2, MaestroID)
        InitializeComponent()

        spSelectDgv = "PedidosClientesMaestros2SelectDgvByPedidoClienteMaestroID '" & MaestroID & "'"

        m_VerID = False
    End Sub

    Public Sub New()
        MyBase.New(New spPedidosClientesMaestros2, 0)
        InitializeComponent()

        spSelectDgv = "PedidosClientesMaestros2SelectDgvByServido"
    End Sub

    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim dtb As New BasesParaCompatibilidad.DataBase
            If CType(sp, spPedidosClientesMaestros2).PedidosClientesMaestros2Delete(dgvGeneral.CurrentRow.Cells("PedidoClienteMaestroID").Value, dtb) Then
                dgvFill()
            End If
        End If
    End Sub

    Overrides Sub Action(ByVal TipoAction As String)
        m_PedidosClientesMaestros2 = New DBO_PedidosClientesMaestros2
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then
            If m_MaestroID <> 0 Then m_PedidosClientesMaestros2.PedidoClienteMaestroID = m_MaestroID
        Else
            Dim dtb As New BasesParaCompatibilidad.DataBase
            m_PedidosClientesMaestros2 = CType(sp, spPedidosClientesMaestros2).Select_Record(GeneralBindingSource(m_Pos).Item("PedidoClienteMaestroID"), dtb)
        End If

        frmEnt = New frmEntPedidosClientesMaestros2(m_PedidosClientesMaestros2, m_Pos, m_VerID)
        frmEnt.Text = String.Format("{0} {1}", TipoAction, Me.Text)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)

        dgvFill()
    End Sub

    Protected Overrides Sub cargar_datos()
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dtb.PrepararConsulta(spSelectDgv)
        dataSource = dtb.Consultar()
    End Sub

    Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then

            butExcel.Visible = True
            GeneralBindingSource.DataSource = dataSource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                '.DataSource = dataSource

                .Columns("PedidoClienteMaestroID").Visible = False
                .FormatoColumna("Numero", BasesParaCompatibilidad.TiposColumna.Miles, 70, 0)
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, 200, 1)
                .FormatoColumna("NumeroPedidoCliente", "Cliente", BasesParaCompatibilidad.TiposColumna.Miles, 70, 2)
                .FormatoColumna("FechaEmision", BasesParaCompatibilidad.TiposColumna.FechaCorta, 97, 3)
                .FormatoColumna("FechaServicio", BasesParaCompatibilidad.TiposColumna.FechaCorta, 97, 4)
                .FormatoColumna("Entrega", BasesParaCompatibilidad.TiposColumna.Izquierda, 97, 5)
                .FormatoColumna("Servido", BasesParaCompatibilidad.TiposColumna.Centro, 54, 6)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 7)
            End With
        End If
    End Sub



    Public Overrides Sub Refrescar()
        If spSelectDgv = "PedidosClientesMaestros2SelectDgvByServido" Then
            spSelectDgv = "PedidosClientesMaestros2SelectDgv"
        Else
            spSelectDgv = "PedidosClientesMaestros2SelectDgvByServido"
        End If

        dgvFill()
    End Sub

End Class
