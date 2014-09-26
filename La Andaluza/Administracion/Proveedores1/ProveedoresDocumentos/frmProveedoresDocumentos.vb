Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmProveedoresDocumentos
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private m_VerID As Boolean = True
    Private m_ruta As String

    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spProveedoresDocumentos, MaestroID)
        InitializeComponent()

        spSelectDgv = "ProveedoresDocumentosSelectDgvByProveedorID '" & MaestroID & "'"

        m_VerID = False
    End Sub

    Public Sub New()
        MyBase.New(New spProveedoresDocumentos, 0)
        InitializeComponent()
        spSelectDgv = "ProveedoresDocumentosSelectDgv"
    End Sub

    Public Sub New(ByVal MaestroID As Integer, ByVal ruta As String)
        Me.New(MaestroID)
        Me.m_ruta = ruta
    End Sub



    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then _
                   CType(sp, spProveedoresDocumentos).ProveedoresDocumentosDelete(dgvGeneral.CurrentRow.Cells("ProveedorDocumentoID").Value)
        dgvFill()
    End Sub


    Overrides Sub Action(ByVal TipoAction As String)
        Dim m_ProveedorDocumento As New DBO_ProveedoresDocumentos
        Dim m_Pos As Integer = GeneralBindingSource.Position

        Dim frmEnt As frmEntProveedoresDocumentos
        If TipoAction = ACCION_INSERTAR Then

            If m_MaestroID <> 0 Then m_ProveedorDocumento.ProveedorID = m_MaestroID
            frmEnt = New frmEntProveedoresDocumentos(m_ProveedorDocumento, m_Pos, m_VerID, Me.m_ruta)
        Else
            m_ProveedorDocumento = CType(sp, spProveedoresDocumentos).Select_Record(GeneralBindingSource(m_Pos).Item("ProveedorDocumentoID"))
            frmEnt = New frmEntProveedoresDocumentos(m_ProveedorDocumento, m_Pos, m_VerID)
        End If

        Using frmEnt
            frmEnt.Text = String.Format("{0} {1}", TipoAction, Me.Text)
            BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        End Using

        dgvFill()
    End Sub


    Protected Overrides Sub cargar_datos()
        dataSource = dtb.Consultar(spSelectDgv, True)
    End Sub

    Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource


            butExcel.Visible = True

            With dgvGeneral
                .DataSource = GeneralBindingSource

                .Columns("ProveedorDocumentoID").Visible = False
                .Columns("Ruta").Visible = False
                .Columns("Nombre").Visible = False
                .Columns("FechaModificacion").Visible = False
                .Columns("UsuarioModificacion").Visible = False

                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 0, 350)
                .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 95, 1)
                .FormatoColumna("Fuente", BasesParaCompatibilidad.TiposColumna.Izquierda, 200, 2)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 3, 250)
                .FormatoGeneral()
            End With
        End If
    End Sub
End Class
