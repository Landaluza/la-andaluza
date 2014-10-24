Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmPedidosClientesDocumentos
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private m_VerID As Boolean = True
    Private frmEnt As frmEntPedidosClientesDocumentos
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spPedidosClientesDocumentos, MaestroID)
        InitializeComponent()
        spSelectDgv = "PedidosClientesDocumentosSelectDgvByPedidoClienteMaestroID '" & MaestroID & "'"

        m_VerID = False
    End Sub

    Public Sub New()
        MyBase.New(New spPedidosClientesDocumentos, 0)
        InitializeComponent()
        spSelectDgv = "PedidosClientesDocumentosSelectDgv"
    End Sub

    Private Sub frmPedidosClientesDocumentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        butExcel.Visible = False
        butWord.Visible = False

    End Sub

    Overrides Sub Ver()
        Dim f As New BasesParaCompatibilidad.File
        f.open(dgvGeneral.CurrentRow.Cells("Ruta").Value)
    End Sub

    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            CType(sp, spPedidosClientesDocumentos).PedidosClientesDocumentosDelete(dgvGeneral.CurrentRow.Cells("PedidoClienteDocumentoID").Value, dtb)
        End If
        dgvFill()
    End Sub

    Overrides Sub Action(ByVal TipoAction As String)
        Dim m_PedidoClienteDocumento As New DBO_PedidosClientesDocumentos
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then
            If m_MaestroID <> 0 Then m_PedidoClienteDocumento.PedidoClienteMaestroID = m_MaestroID
        Else
            m_PedidoClienteDocumento = CType(sp, spPedidosClientesDocumentos).Select_Record(GeneralBindingSource(m_Pos).Item("PedidoClienteDocumentoID"), dtb)
        End If

        frmEnt = New frmEntPedidosClientesDocumentos(m_PedidoClienteDocumento, m_Pos, m_VerID)
        frmEnt.Text = String.Format("{0} {1}", TipoAction, Me.Text)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)

        dgvFill()
    End Sub


    Protected Overrides Sub cargar_datos()
        dataSource = dtb.Consultar(spSelectDgv, True)
    End Sub

    Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource

            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("PedidoClienteDocumentoID").Visible = False
                .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 70)
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, 350)
                .FormatoColumna("Observaciones", "Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, 462)
                If m_MaestroID <> 0 Then
                    .Columns("PedidoClienteMaestroID").Visible = False
                    .Columns("Ruta").Visible = False
                End If
                .FormatoGeneral()
            End With
        End If
    End Sub


End Class
