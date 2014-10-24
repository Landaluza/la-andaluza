Public Class frmEntEpis
    inherits BasesParaCompatibilidad.FrmAHeredarEntOld


    Private m_Pos As Integer
    Private m_Epi As DBO_Epis
    Private spEpis As New spEpis

    Public Sub New(ByRef Epi As DBO_Epis, ByVal Pos As Integer)
        InitializeComponent()
        m_Epi = Epi
        m_Pos = Pos
    End Sub

    Private Sub frmEntEpis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ModificarBindingNavigator()
        Dim spEpisTipos As New spEpisTipos
        spEpisTipos.cargar_combo(cboEpisTipos, dtb)


        If Me.Text.Substring(0, 3) = "Ver" Then
            'GeneralBindingSource. dataSource = dtb.Consultar("EpisSelectAll")
            GeneralBindingSource.Position = m_Pos
        End If

        SetValores()
    End Sub

    Public Overrides Sub SetValores()
        txtEpiID.Text = m_Epi.EpiID
        txtDescripcion.Text = m_Epi.Descripcion
        txtMarca.Text = if(m_Epi.Marca_IsDBNull = True, Nothing, m_Epi.Marca)
        txtModelo.Text = if(m_Epi.Modelo_IsDBNull = True, Nothing, m_Epi.Modelo)
        'txtEpiTipoID.Text = if(m_Epi.EpiTipoID_IsDBNull = True, Nothing, m_Epi.EpiTipoID)
        cboEpisTipos.SelectedValue = m_Epi.EpiTipoID

        txtRiesgoQuimico.Checked = m_Epi.RiesgoQuimico
        txtRiesgoMecanico.Checked = m_Epi.RiesgoMecanico
        txtRiesgoMicrobiologico.Checked = m_Epi.RiesgoMicrobiologico
        txtRiesgoFrio.Checked = m_Epi.RiesgoFrio
        txtRiesgoTermico.Checked = m_Epi.RiesgoTermico
        txtUsos.Text = if(m_Epi.Usos_IsDBNull = True, Nothing, m_Epi.Usos)
        txtAdvertencias.Text = if(m_Epi.Advertencias_IsDBNull = True, Nothing, m_Epi.Advertencias)
        txtObservaciones.Text = if(m_Epi.Observaciones_IsDBNull = True, Nothing, m_Epi.Observaciones)
        txtaMecanico.Text = if(m_Epi.aMecanico_IsDBNull = True, Nothing, m_Epi.aMecanico)
        txtbMecanico.Text = if(m_Epi.bMecanico_IsDBNull = True, Nothing, m_Epi.bMecanico)
        txtcMecanico.Text = if(m_Epi.cMecanico_IsDBNull = True, Nothing, m_Epi.cMecanico)
        txtdMecanico.Text = if(m_Epi.dMecanico_IsDBNull = True, Nothing, m_Epi.dMecanico)
        txtaQuimico.Text = if(m_Epi.aQuimico_IsDBNull = True, Nothing, m_Epi.aQuimico)
        txtaMicrobiologico.Text = if(m_Epi.aMicrobiologico_IsDBNull = True, Nothing, m_Epi.aMicrobiologico)
        txtaFrio.Text = if(m_Epi.aFrio_IsDBNull = True, Nothing, m_Epi.aFrio)
        txtbFrio.Text = if(m_Epi.bFrio_IsDBNull = True, Nothing, m_Epi.bFrio)
        txtcFrio.Text = if(m_Epi.cFrio_IsDBNull = True, Nothing, m_Epi.cFrio)
    End Sub

    Private Sub GetValores(ByVal m_Epi As DBO_Epis)
        m_Epi.Descripcion = System.Convert.ToString(txtDescripcion.Text)
        m_Epi.Marca = System.Convert.ToString(if(txtMarca.Text = "", Nothing, txtMarca.Text))
        m_Epi.Marca_IsDBNull = if(txtMarca.Text = "", True, False)
        m_Epi.Modelo = System.Convert.ToString(if(txtModelo.Text = "", Nothing, txtModelo.Text))
        m_Epi.Modelo_IsDBNull = if(txtModelo.Text = "", True, False)
        'm_Epi.EpiTipoID = System.Convert.ToInt32(if(txtEpiTipoID.Text = "", Nothing, txtEpiTipoID.Text))
        'm_Epi.EpiTipoID_IsDBNull = if(txtEpiTipoID.Text = "", True, False)
        m_Epi.EpiTipoID = cboEpisTipos.SelectedValue


        m_Epi.RiesgoQuimico = System.Convert.ToBoolean(txtRiesgoQuimico.Checked)
        m_Epi.RiesgoMecanico = System.Convert.ToBoolean(txtRiesgoMecanico.Checked)
        m_Epi.RiesgoMicrobiologico = System.Convert.ToBoolean(txtRiesgoMicrobiologico.Checked)
        m_Epi.RiesgoFrio = System.Convert.ToBoolean(txtRiesgoFrio.Checked)
        m_Epi.RiesgoTermico = System.Convert.ToBoolean(txtRiesgoTermico.Checked)
        m_Epi.Usos = System.Convert.ToString(if(txtUsos.Text = "", Nothing, txtUsos.Text))
        m_Epi.Usos_IsDBNull = if(txtUsos.Text = "", True, False)
        m_Epi.Advertencias = System.Convert.ToString(if(txtAdvertencias.Text = "", Nothing, txtAdvertencias.Text))
        m_Epi.Advertencias_IsDBNull = if(txtAdvertencias.Text = "", True, False)
        m_Epi.Observaciones = System.Convert.ToString(if(txtObservaciones.Text = "", Nothing, txtObservaciones.Text))
        m_Epi.Observaciones_IsDBNull = if(txtObservaciones.Text = "", True, False)
        m_Epi.aMecanico = System.Convert.ToString(if(txtaMecanico.Text = "", Nothing, txtaMecanico.Text))
        m_Epi.aMecanico_IsDBNull = if(txtaMecanico.Text = "", True, False)
        m_Epi.bMecanico = System.Convert.ToString(if(txtbMecanico.Text = "", Nothing, txtbMecanico.Text))
        m_Epi.bMecanico_IsDBNull = if(txtbMecanico.Text = "", True, False)
        m_Epi.cMecanico = System.Convert.ToString(if(txtcMecanico.Text = "", Nothing, txtcMecanico.Text))
        m_Epi.cMecanico_IsDBNull = if(txtcMecanico.Text = "", True, False)
        m_Epi.dMecanico = System.Convert.ToString(if(txtdMecanico.Text = "", Nothing, txtdMecanico.Text))
        m_Epi.dMecanico_IsDBNull = if(txtdMecanico.Text = "", True, False)
        m_Epi.aQuimico = System.Convert.ToString(if(txtaQuimico.Text = "", Nothing, txtaQuimico.Text))
        m_Epi.aQuimico_IsDBNull = if(txtaQuimico.Text = "", True, False)
        m_Epi.aMicrobiologico = System.Convert.ToString(if(txtaMicrobiologico.Text = "", Nothing, txtaMicrobiologico.Text))
        m_Epi.aMicrobiologico_IsDBNull = if(txtaMicrobiologico.Text = "", True, False)
        m_Epi.aFrio = System.Convert.ToString(if(txtaFrio.Text = "", Nothing, txtaFrio.Text))
        m_Epi.aFrio_IsDBNull = if(txtaFrio.Text = "", True, False)
        m_Epi.bFrio = System.Convert.ToString(if(txtbFrio.Text = "", Nothing, txtbFrio.Text))
        m_Epi.bFrio_IsDBNull = if(txtbFrio.Text = "", True, False)
        m_Epi.cFrio = System.Convert.ToString(if(txtcFrio.Text = "", Nothing, txtcFrio.Text))
        m_Epi.cFrio_IsDBNull = if(txtcFrio.Text = "", True, False)
        m_Epi.FechaModificacion = System.DateTime.Now.date
        m_Epi.FechaModificacion_IsDBNull = False
        m_Epi.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        m_Epi.UsuarioModificacion_IsDBNull = False
    End Sub

    Overrides Sub Guardar()
        Dim m_NewEpi As New DBO_Epis
        GetValores(m_NewEpi)
        If Me.Text.Substring(0, 3) = "Ins" Then
            spEpis.InsertEpis(m_NewEpi, dtb)
        Else
            spEpis.UpdateEpis(m_Epi, m_NewEpi, dtb)
        End If
        Me.Close()
    End Sub

    Overrides Sub MoveRecord(ByVal Move As String)
        Select Case Move
            Case Is = "First"
                m_Pos = 0
            Case Is = "Previous"
                m_Pos = m_Pos - 1
            Case Is = "Next"
                m_Pos = m_Pos + 1
            Case Is = "Last"
                m_Pos = GeneralBindingSource.Count - 1
        End Select
        GeneralBindingSource.Position = m_Pos
        m_Epi = spEpis.Select_Record(GeneralBindingSource(m_Pos).Item("EpiID"), dtb)
        SetValores()
    End Sub

End Class
