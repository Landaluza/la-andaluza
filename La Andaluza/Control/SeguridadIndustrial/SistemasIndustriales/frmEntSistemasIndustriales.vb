Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntSistemasIndustriales
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer
    Private m_SistemasIndustriale As DBO_SistemasIndustriales
    Private spSistemasIndustriales As New spSistemasIndustriales

    Public Sub New(ByRef SistemasIndustriale As DBO_SistemasIndustriales, ByVal Pos As Integer)
        InitializeComponent()
        m_SistemasIndustriale = SistemasIndustriale
        m_Pos = Pos
        txtFechaInstalacion.activarFoco()
        txtFechaPresentacionIndustria.activarFoco()
        txtFechaRegistroIndustria.activarFoco()
    End Sub

    Private Sub frmEntSistemasIndustriales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ModificarBindingNavigator()

        If Me.Text.Substring(0, 3) = "Ver" Then
            'GeneralBindingSource. dataSource = dtb.Consultar("SistemasIndustrialesSelectAll")
            GeneralBindingSource.Position = m_Pos
        End If

        SetValores()
    End Sub

    Public Overrides Sub SetValores()
        txtSistemaIndustrialID.Text = m_SistemasIndustriale.SistemaIndustrialID
        txtDescripcion.Text = m_SistemasIndustriale.Descripcion
        txtFechaInstalacion.Text = If(m_SistemasIndustriale.FechaInstalacion_IsDBNull = True, Nothing, m_SistemasIndustriale.FechaInstalacion)
        txtFechaRegistroIndustria.Text = If(m_SistemasIndustriale.FechaRegistroIndustria_IsDBNull = True, Nothing, m_SistemasIndustriale.FechaRegistroIndustria)
        txtReferenciaExpedienteIndustria.Text = If(m_SistemasIndustriale.ReferenciaExpedienteIndustria_IsDBNull = True, Nothing, m_SistemasIndustriale.ReferenciaExpedienteIndustria)
        txtReferenciaRegistroIndustria.Text = If(m_SistemasIndustriale.ReferenciaRegistroIndustria_IsDBNull = True, Nothing, m_SistemasIndustriale.ReferenciaRegistroIndustria)
        txtFechaPresentacionIndustria.Text = If(m_SistemasIndustriale.FechaPresentacionIndustria_IsDBNull = True, Nothing, m_SistemasIndustriale.FechaPresentacionIndustria)
        txtAutorProyecto.Text = If(m_SistemasIndustriale.AutorProyecto_IsDBNull = True, Nothing, m_SistemasIndustriale.AutorProyecto)
        txtObservaciones.Text = If(m_SistemasIndustriale.Observaciones_IsDBNull = True, Nothing, m_SistemasIndustriale.Observaciones)
    End Sub

    Private Sub GetValores(ByVal m_SistemasIndustriale As DBO_SistemasIndustriales)
        m_SistemasIndustriale.Descripcion = System.Convert.ToString(txtDescripcion.Text)
        m_SistemasIndustriale.FechaInstalacion = System.Convert.ToDateTime(If(txtFechaInstalacion.Text = "", Nothing, txtFechaInstalacion.Text))
        m_SistemasIndustriale.FechaInstalacion_IsDBNull = If(txtFechaInstalacion.Text = "", True, False)
        m_SistemasIndustriale.FechaRegistroIndustria = System.Convert.ToDateTime(If(txtFechaRegistroIndustria.Text = "", Nothing, txtFechaRegistroIndustria.Text))
        m_SistemasIndustriale.FechaRegistroIndustria_IsDBNull = If(txtFechaRegistroIndustria.Text = "", True, False)
        m_SistemasIndustriale.ReferenciaExpedienteIndustria = System.Convert.ToString(If(txtReferenciaExpedienteIndustria.Text = "", Nothing, txtReferenciaExpedienteIndustria.Text))
        m_SistemasIndustriale.ReferenciaExpedienteIndustria_IsDBNull = If(txtReferenciaExpedienteIndustria.Text = "", True, False)
        m_SistemasIndustriale.ReferenciaRegistroIndustria = System.Convert.ToString(If(txtReferenciaRegistroIndustria.Text = "", Nothing, txtReferenciaRegistroIndustria.Text))
        m_SistemasIndustriale.ReferenciaRegistroIndustria_IsDBNull = If(txtReferenciaRegistroIndustria.Text = "", True, False)
        m_SistemasIndustriale.FechaPresentacionIndustria = System.Convert.ToDateTime(If(txtFechaPresentacionIndustria.Text = "", Nothing, txtFechaPresentacionIndustria.Text))
        m_SistemasIndustriale.FechaPresentacionIndustria_IsDBNull = If(txtFechaPresentacionIndustria.Text = "", True, False)
        m_SistemasIndustriale.AutorProyecto = System.Convert.ToString(If(txtAutorProyecto.Text = "", Nothing, txtAutorProyecto.Text))
        m_SistemasIndustriale.AutorProyecto_IsDBNull = If(txtAutorProyecto.Text = "", True, False)
        m_SistemasIndustriale.Observaciones = System.Convert.ToString(If(txtObservaciones.Text = "", Nothing, txtObservaciones.Text))
        m_SistemasIndustriale.Observaciones_IsDBNull = If(txtObservaciones.Text = "", True, False)
        m_SistemasIndustriale.FechaModificacion = System.DateTime.Now.Date
        m_SistemasIndustriale.FechaModificacion_IsDBNull = False
        m_SistemasIndustriale.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        m_SistemasIndustriale.UsuarioModificacion_IsDBNull = False
    End Sub

    Overrides Sub Guardar()
        Dim m_NewSistemasIndustriale As New DBO_SistemasIndustriales
        GetValores(m_NewSistemasIndustriale)
        If Me.Text.Substring(0, 3) = "Ins" Then
            spSistemasIndustriales.InsertSistemasIndustriales(m_NewSistemasIndustriale)
        Else
            spSistemasIndustriales.UpdateSistemasIndustriales(m_SistemasIndustriale, m_NewSistemasIndustriale)
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
        m_SistemasIndustriale = spSistemasIndustriales.Select_Record(GeneralBindingSource(m_Pos).Item("SistemaIndustrialID"))
        SetValores()
    End Sub


End Class
