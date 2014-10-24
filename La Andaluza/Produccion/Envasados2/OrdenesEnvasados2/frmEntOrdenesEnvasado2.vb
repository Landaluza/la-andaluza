Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntOrdenesEnvasado2
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer
    Public m_DBO_OrdenesEnvasado As DBO_OrdenesEnvasado2
    Private spOrdenesEnvasado2 As spOrdenesEnvasado2
    Private frmOrdenesEnvasado2Detalle1 As frmOrdenesEnvasado2Detalle
    Private frmOrdenesEnvasado2Detalle2 As frmOrdenesEnvasado2Detalle
    Private frmOrdenesEnvasado2Detalle3 As frmOrdenesEnvasado2Detalle
    Private frmOrdenesEnvasado2Detalle4 As frmOrdenesEnvasado2Detalle
    Private frmOrdenesEnvasado2Detalle5 As frmOrdenesEnvasado2Detalle

    Public Sub New(ByRef OrdenesEnvasado As DBO_OrdenesEnvasado2, ByVal Pos As Integer)
        InitializeComponent()
        m_DBO_OrdenesEnvasado = OrdenesEnvasado
        m_Pos = Pos
        spOrdenesEnvasado2 = New spOrdenesEnvasado2
        dtpFecha.activarFoco()

        'cboLineas.mam_DataSource("OrdenesEnvasados2SelectLineasEnvasados"), True, "Todas")
        SetValores(m_DBO_OrdenesEnvasado.OrdenEnvasadoID, False)
    End Sub

    'Private Sub frmEntOrdenesEnvasado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    'End Sub

    Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)
        'No quiero que sea pantalla completa
        'Me.Width = 1633
        'Me.Height = 776

        If m_SelectRecord Then m_DBO_OrdenesEnvasado = spOrdenesEnvasado2.Select_Record(m_ID, dtb)
        txtOrdenEnvasadoID.Text = m_DBO_OrdenesEnvasado.OrdenEnvasadoID
        dtpFecha.Text = If(m_DBO_OrdenesEnvasado.Fecha_IsDBNull = True, Nothing, m_DBO_OrdenesEnvasado.Fecha)
        txtObservaciones.Text = If(m_DBO_OrdenesEnvasado.Observaciones_IsDBNull = True, Nothing, m_DBO_OrdenesEnvasado.Observaciones)

        frmOrdenesEnvasado2Detalle1 = New frmOrdenesEnvasado2Detalle(m_DBO_OrdenesEnvasado, 1)
        frmOrdenesEnvasado2Detalle2 = New frmOrdenesEnvasado2Detalle(m_DBO_OrdenesEnvasado, 2)
        frmOrdenesEnvasado2Detalle3 = New frmOrdenesEnvasado2Detalle(m_DBO_OrdenesEnvasado, 3)
        frmOrdenesEnvasado2Detalle4 = New frmOrdenesEnvasado2Detalle(m_DBO_OrdenesEnvasado, 4)
        frmOrdenesEnvasado2Detalle5 = New frmOrdenesEnvasado2Detalle(m_DBO_OrdenesEnvasado, 5)

        Engine_LA.FormEnPestaña(frmOrdenesEnvasado2Detalle1, tbpLinea1)
        Engine_LA.FormEnPestaña(frmOrdenesEnvasado2Detalle2, tbpLinea2)
        Engine_LA.FormEnPestaña(frmOrdenesEnvasado2Detalle3, tbpLinea3)
        Engine_LA.FormEnPestaña(frmOrdenesEnvasado2Detalle4, tbpLinea4)
        Engine_LA.FormEnPestaña(frmOrdenesEnvasado2Detalle5, tbpLinea5)
    End Sub

    Private Sub GetValores()
        m_DBO_OrdenesEnvasado.Fecha = If(dtpFecha.Text = "", System.DateTime.Now.Date, dtpFecha.Value.Date)
        m_DBO_OrdenesEnvasado.Fecha_IsDBNull = If(dtpFecha.Text = "", True, False)
        m_DBO_OrdenesEnvasado.Observaciones = If(txtObservaciones.Text = "", Nothing, txtObservaciones.Text)
        m_DBO_OrdenesEnvasado.Observaciones_IsDBNull = If(txtObservaciones.Text = "", True, False)
        m_DBO_OrdenesEnvasado.FechaModificacion = System.DateTime.Now.Date
        m_DBO_OrdenesEnvasado.UsuarioModificacion = BasesParaCompatibilidad.Config.User
    End Sub

    Overrides Sub Guardar()
        GetValores()
        spOrdenesEnvasado2.GrabarOrdenesEnvasado(m_DBO_OrdenesEnvasado, dtb)
        If m_DBO_OrdenesEnvasado.OrdenEnvasadoID <> 0 And Me.Text.Substring(0, 3) = "Ins" Then
            Me.Text = Me.Text.Replace("Insertar", "Modificar")
            SetValores(m_DBO_OrdenesEnvasado.OrdenEnvasadoID, True)
        Else
            Me.Close()
        End If
    End Sub

    'Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
    '    ActualizarTabPages()
    'End Sub

    Private Sub dtpFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
        m_DBO_OrdenesEnvasado.Fecha = dtpFecha.Value
        m_DBO_OrdenesEnvasado.OrdenEnvasadoID = spOrdenesEnvasado2.GetIDByFecha(m_DBO_OrdenesEnvasado.Fecha, dtb)
        SetValores(m_DBO_OrdenesEnvasado.OrdenEnvasadoID, False)
    End Sub
End Class
