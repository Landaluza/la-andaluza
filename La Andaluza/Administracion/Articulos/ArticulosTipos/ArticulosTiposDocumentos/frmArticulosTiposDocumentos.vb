Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmArticulosTiposDocumentos
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private m_VerID As Boolean = True

    Private m_ArticuloTipoDocumento As DBO_ArticulosTiposDocumentos
    Private frmEnt As frmEntArticulosTiposDocumentos
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spArticulosTiposDocumentos, MaestroID)
        InitializeComponent()
        spSelectDgv = "ArticulosTiposDocumentosSelectDgvByArticuloTipoID '" & MaestroID & "'"
        m_VerID = False

        butExcel.Visible = False
        butWord.Visible = False
        butVer.Visible = True
    End Sub

    Public Sub New()
        MyBase.New(New spArticulosTiposDocumentos, 0)
        InitializeComponent()
        spSelectDgv = "ArticulosTiposDocumentosSelectDgv"
    End Sub



    Public Overrides Sub Ver()
        Try
            Dim psi As New ProcessStartInfo()
            psi.UseShellExecute = True
            psi.FileName = dgvGeneral.CurrentRow.Cells("Ruta").Value
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", _
                          "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim dtb As New BasesParaCompatibilidad.DataBase
            If CType(sp, spArticulosTiposDocumentos).ArticulosTiposDocumentosDelete(dgvGeneral.CurrentRow.Cells("ArticuloTipoDocumentoID").Value, dtb) Then
                dgvFill()
            End If
        End If
    End Sub

    Overrides Sub Action(ByVal TipoAction As String)
        m_ArticuloTipoDocumento = New DBO_ArticulosTiposDocumentos

        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then
            If m_MaestroID <> 0 Then m_ArticuloTipoDocumento.ArticuloTipoID = m_MaestroID
        Else
            Dim dtb As New BasesParaCompatibilidad.DataBase
            m_ArticuloTipoDocumento = CType(sp, spArticulosTiposDocumentos).Select_Record(GeneralBindingSource(m_Pos).Item("ArticuloTipoDocumentoID"), dtb)
        End If

        frmEnt = New frmEntArticulosTiposDocumentos(m_ArticuloTipoDocumento, m_Pos, m_VerID)
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
            GeneralBindingSource.DataSource = dataSource
            With dgvGeneral
                .DataSource = GeneralBindingSource

                .Columns("ArticuloTipoDocumentoID").Visible = False
                .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 85)
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, 212)
                .FormatoColumna("Fuente", BasesParaCompatibilidad.TiposColumna.Descripcion)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Observaciones, True)
                .FormatoColumna("Ruta", BasesParaCompatibilidad.TiposColumna.Observaciones, True)

            End With
        End If
    End Sub


End Class
