Imports BasesParaCompatibilidad.ComboBoxExtension
Public Class frmWstepMateriasPrimas
    Implements BasesParaCompatibilidad.wizardable
    Dim m_DBO_MateriaPrima As DBO_ArticulosMateriasPrimas
    Private spArticulos_ArticulosCertificadosTipos As spArticulos_ArticulosCertificadosTipos
    Private spArticulosMateriasPrimas As spArticulosMateriasPrimas
    Private dtb As BasesParaCompatibilidad.DataBase
    Public Sub New()

        InitializeComponent()

        dtb = New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        Me.m_DBO_MateriaPrima = New DBO_ArticulosMateriasPrimas
        spArticulos_ArticulosCertificadosTipos = New spArticulos_ArticulosCertificadosTipos
        spArticulosMateriasPrimas = New spArticulosMateriasPrimas
    End Sub

    Public Sub New(ByVal articuloId As Integer)
        InitializeComponent()

        spArticulos_ArticulosCertificadosTipos = New spArticulos_ArticulosCertificadosTipos
        spArticulosMateriasPrimas = New spArticulosMateriasPrimas
        Me.m_DBO_MateriaPrima = spArticulosMateriasPrimas.Select_RecordByArticuloID(articuloId)
        EstablecerValores()
    End Sub

    Public Function comprobarCampos() As Boolean Implements BasesParaCompatibilidad.wizardable.comprobarCampos
        Dim errores As String = ""

        If Me.cboMateriaPrimaTipoID.SelectedValue Is Nothing Then
            cboMateriaPrimaTipoID.Focus()
            errores = "Debe seleccionar un valor par el tipo de materia prima." & Environment.NewLine
        Else
            m_DBO_MateriaPrima.MateriaPrimaTipoID = System.Convert.ToInt32(cboMateriaPrimaTipoID.SelectedValue)
        End If
        m_DBO_MateriaPrima.FechaModificacion = System.DateTime.Now.Date
        m_DBO_MateriaPrima.UsuarioModificacion = BasesParaCompatibilidad.Config.User

        If errores <> "" Then
            MessageBox.Show("Complete correctamente el formulario. Se han encontrado los siguientes errores: " & Environment.NewLine & errores, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub EstablecerValores() Implements BasesParaCompatibilidad.wizardable.EstablecerValores
        Me.cboMateriaPrimaTipoID.mam_DataSource("ArticulosMateriasPrimas_ArticulosMateriasPrimasTiposCbo", False)

        Dim spArticulos1 As New spArticulos1
        Dim cb As System.Windows.Forms.CheckBox
        Dim dt As DataTable = dtb.Consultar("ArticulosCertificadosTiposSelectDgv", True)

        For Each row As System.Data.DataRow In dt.Rows
            cb = New System.Windows.Forms.CheckBox

            cb.Checked = False
            cb.Text = row.Item(1)
            cb.Tag = row.Item(0)
            cb.Dock = DockStyle.Top
            gbCertificados.Controls.Add(cb)
        Next

        If Not Me.m_DBO_MateriaPrima.ArticuloID Is Nothing Then
            Me.cboMateriaPrimaTipoID.SelectedValue = Me.m_DBO_MateriaPrima.MateriaPrimaTipoID

            dt = spArticulos1.certificadosByArticuloId(Me.m_DBO_MateriaPrima.ArticuloID)

            For Each row As System.Data.DataRow In dt.Rows
                For Each cb In gbCertificados.Controls
                    If cb.Tag = row(0) Then
                        cb.Checked = True
                    End If
                Next
            Next
        End If
    End Sub

    Public Function grabarDatos() As Boolean Implements BasesParaCompatibilidad.wizardable.grabarDatos
        If Me.m_DBO_MateriaPrima.ArticuloID Is Nothing Then Me.m_DBO_MateriaPrima.ArticuloID = dtb.Consultar("select max(articuloID) from Articulos1", False).Rows(0).Item(0)

        If spArticulosMateriasPrimas.GrabarArticulosMateriasPrimasSinTransaccion(m_DBO_MateriaPrima, BasesParaCompatibilidad.BD.transaction) Then
            If spArticulos_ArticulosCertificadosTipos.Articulos_ArticulosCertificadosTiposDeleteByArticuloIDSinTransaccion(Me.m_DBO_MateriaPrima.ArticuloID, BasesParaCompatibilidad.BD.transaction) Then
                Dim cb As System.Windows.Forms.CheckBox
                Dim dbo_cert As DBO_Articulos_ArticulosCertificadosTipos

                For Each cb In gbCertificados.Controls
                    If cb.Checked Then
                        dbo_cert = New DBO_Articulos_ArticulosCertificadosTipos
                        dbo_cert.ArticuloCertificadoTipoID = cb.Tag
                        dbo_cert.ArticuloID = Me.m_DBO_MateriaPrima.ArticuloID
                        dbo_cert.Observaciones = String.Empty
                        If Not spArticulos_ArticulosCertificadosTipos.Articulos_ArticulosCertificadosTiposInsertSinTransaccion(dbo_cert, BasesParaCompatibilidad.BD.transaction) Then
                            Return False
                        End If
                    End If
                Next

                Return True

            Else : Return False
            End If
        Else : Return False
        End If
    End Function

    Public Function recuperarValor(nombre As String) As Object Implements BasesParaCompatibilidad.wizardable.recuperarValor
        Return Nothing
    End Function

    Private Sub frmWstepMateriasPrimas_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.Pantalla.centerIn(Me.PanContenidos, Me)
    End Sub
End Class