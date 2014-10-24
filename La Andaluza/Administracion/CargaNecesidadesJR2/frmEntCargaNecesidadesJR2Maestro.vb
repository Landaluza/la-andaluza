Imports BasesParaCompatibilidad.DataGridViewExtension
Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntCargaNecesidadesJR2Maestro
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer
    Private m_DBO_CargaNecesidadesJRMaestro As DBO_CargaNecesidadesJR2Maestro
    Private m_VerID As Boolean = False
    Private spCargaNecesidadesJR2Detalles As spCargaNecesidadesJR2Detalles
    Private spCargaNecesidadesJR2Maestro As spCargaNecesidadesJR2Maestro

    Public Sub New(ByRef CargaNecesidadesJRMaestro As DBO_CargaNecesidadesJR2Maestro, ByVal Pos As Integer, ByVal VerID As Boolean)
        InitializeComponent()
        m_DBO_CargaNecesidadesJRMaestro = CargaNecesidadesJRMaestro
        m_Pos = Pos
        m_VerID = VerID
        dtb = New BasesParaCompatibilidad.DataBase()
        spCargaNecesidadesJR2Detalles = New spCargaNecesidadesJR2Detalles
        spCargaNecesidadesJR2Maestro = New spCargaNecesidadesJR2Maestro
        dtpFecha.activarFoco()
        dtpHora.activarFoco()
    End Sub

    Private Sub frmEntCargaNecesidadesJRMaestro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SetValores(m_DBO_CargaNecesidadesJRMaestro.CargaNecesidadesJRMaestroID, False)

        With dgvDetalles
            .Columns("CargaNecesidadesJRDetalleID").Visible = False
            .Columns("CargaNecesidadesJRMaestroID").Visible = False
            .Columns("ArticuloID").Visible = False
            .Columns("Reserva1").Visible = False
            .Columns("Reserva2").Visible = False
            .Columns("Reserva3").Visible = False
            .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, 250, 0)
            .FormatoColumna("Carga", BasesParaCompatibilidad.TiposColumna.Izquierda, 100, 1)
            .FormatoColumna("Stock", BasesParaCompatibilidad.TiposColumna.Izquierda, 100, 2)
            .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, 250, 3)
        End With
    End Sub

    Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)

        If m_SelectRecord Then m_DBO_CargaNecesidadesJRMaestro = spCargaNecesidadesJR2Maestro.Select_Record(m_ID, dtb)
        txtCargaNecesidadesJRMaestroID.Text = m_DBO_CargaNecesidadesJRMaestro.CargaNecesidadesJRMaestroID
        dtpFecha.Text = m_DBO_CargaNecesidadesJRMaestro.Fecha
        txtObservaciones.Text = m_DBO_CargaNecesidadesJRMaestro.Observaciones
        txtReserva1.Text = m_DBO_CargaNecesidadesJRMaestro.Reserva1
        txtReserva2.Text = m_DBO_CargaNecesidadesJRMaestro.Reserva2
        txtReserva3.Text = m_DBO_CargaNecesidadesJRMaestro.Reserva3
        txtServido.Checked = m_DBO_CargaNecesidadesJRMaestro.Servido
        ActualizarGrilla()
    End Sub

    Private Sub ActualizarGrilla()
        dtb.PrepararConsulta("CargaNecesidadesJRDetallesSelectByMaestroDgv @id")
        dtb.AñadirParametroConsulta("@id", m_DBO_CargaNecesidadesJRMaestro.CargaNecesidadesJRMaestroID)
        dgvDetalles.DataSource = dtb.Consultar
    End Sub

    Private Sub GetValores()
        m_DBO_CargaNecesidadesJRMaestro.Fecha = If(dtpFecha.Text = "", System.DateTime.Now, dtpFecha.Value.Date)
        m_DBO_CargaNecesidadesJRMaestro.Hora = New TimeSpan(Me.dtpHora.Value.Hour, Me.dtpHora.Value.Minute, 0) 'm_DBO_CargaNecesidadesJRMaestro.Fecha
        m_DBO_CargaNecesidadesJRMaestro.Observaciones = If(txtObservaciones.Text = "", Nothing, txtObservaciones.Text)
        m_DBO_CargaNecesidadesJRMaestro.Reserva1 = If(txtReserva1.Text = "", Nothing, txtReserva1.Text)
        m_DBO_CargaNecesidadesJRMaestro.Reserva2 = If(txtReserva2.Text = "", Nothing, txtReserva2.Text)
        m_DBO_CargaNecesidadesJRMaestro.Reserva3 = If(txtReserva3.Text = "", Nothing, txtReserva3.Text)
        m_DBO_CargaNecesidadesJRMaestro.FechaModificacion = System.DateTime.Now.Date
        m_DBO_CargaNecesidadesJRMaestro.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        m_DBO_CargaNecesidadesJRMaestro.Servido = System.Convert.ToBoolean(If(txtServido.Checked = False, False, txtServido.Checked))
    End Sub

    Overrides Sub Guardar()
        GetValores()
        spCargaNecesidadesJR2Maestro.GrabarCargaNecesidadesJRMaestro(m_DBO_CargaNecesidadesJRMaestro, dtb)
        Me.Close()
    End Sub

    Private Sub Action(ByVal TipoAction As String)
        Dim m_DBO_CargaNecesidadesJRDetalle As New DBO_CargaNecesidadesJR2Detalles
        Dim m_Pos As Integer

        Select Case TipoAction
            Case "Insertar"
                m_DBO_CargaNecesidadesJRDetalle.CargaNecesidadesJRMaestroID = m_DBO_CargaNecesidadesJRMaestro.CargaNecesidadesJRMaestroID
                m_DBO_CargaNecesidadesJRDetalle.CargaNecesidadesJRDetalleID = 0
            Case Else
                m_Pos = dgvDetalles.CurrentRow.Index
                m_DBO_CargaNecesidadesJRDetalle = spCargaNecesidadesJR2Detalles.Select_Record(dgvDetalles.CurrentRow.Cells("CargaNecesidadesJRDetalleID").Value, dtb)
        End Select

        Dim frmEnt As New frmEntCargaNecesidadesJR2Detalles(m_DBO_CargaNecesidadesJRDetalle, m_Pos, m_VerID)
        frmEnt.Text = String.Format("{0} Carga Necesidades JR", TipoAction)
        frmEnt.ShowDialog(Me)

        ActualizarGrilla()
    End Sub

    Private Sub tsInsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsInsertar.Click
        Action("Insertar")
    End Sub

    Private Sub tsModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsModificar.Click
        Action("Modificar")
    End Sub

    Private Sub tsEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsEliminar.Click
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", _
                          "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then Me.spCargaNecesidadesJR2Detalles.CargaNecesidadesJRDetallesDelete(dgvDetalles.CurrentRow.Cells("CargaNecesidadesJRDetalleID").Value, dtb)
        ActualizarGrilla()
    End Sub
End Class
