Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntPedidosClientesDetalles2
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer
    Private m_DBO_PedidosClientesDetalles2 As DBO_PedidosClientesDetalles2
    Private m_VerID As Boolean = False
    Private spTiposFormatos As spArticulosEnvasadosHistoricos
    Private mercadona As Integer
    Private spPedidosClientesDetalles2 As spPedidosClientesDetalles2

    Public Sub New(ByRef PedidosClientesDetalles2 As DBO_PedidosClientesDetalles2, _
                   ByVal Pos As Integer, ByVal VerID As Boolean, ByVal mercadona As Boolean)
        InitializeComponent()
        m_DBO_PedidosClientesDetalles2 = PedidosClientesDetalles2
        m_Pos = Pos
        m_VerID = VerID
        spTiposFormatos = New spArticulosEnvasadosHistoricos
        Me.mercadona = mercadona
        spPedidosClientesDetalles2 = New spPedidosClientesDetalles2
        dtpFechaServicio.activarFoco()
    End Sub

    Private Sub frmEntPedidosClientesDetalles2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'PROBLEMA: si cambio la consulta para que tire de la Tabla Articulos1, ya no coinciden los ID con la tabla actual TiposFormatos 

        If Me.Text.Contains(BasesParaCompatibilidad.FrmAheredarOld.ACCION_INSERTAR) Then
            If Not mercadona Then
                spTiposFormatos.cargar_TiposFormatos(cboArticuloID, dtb)
            Else
                spTiposFormatos.cargar_TiposFormatos_por_palet(cboArticuloID, 10, dtb)
            End If

            ' spTiposFormatos.cargar_TiposFormatos(Me.cboArticuloID)
            'Me.cboArticuloID.mam_DataSource("PedidosClientesDetalles2_TiposFormatosCboAll"), False)
        Else
            spTiposFormatos.cargar_TiposFormatos_Todos(Me.cboArticuloID, dtb)
            'Me.cboArticuloID.mam_DataSource("PedidosClientesDetalles2_TiposFormatosCbo"), False)
        End If


        SetValores(m_DBO_PedidosClientesDetalles2.PedidoClienteDatalleID, False)
    End Sub

    Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)

        txtPedidoclienteMaestroID.Text = m_DBO_PedidosClientesDetalles2.PedidoclienteMaestroID

        If m_SelectRecord Then m_DBO_PedidosClientesDetalles2 = spPedidosClientesDetalles2.Select_Record(m_ID, dtb)
        If m_ID > 0 Then
            txtPedidoClienteDatalleID.Text = m_DBO_PedidosClientesDetalles2.PedidoClienteDatalleID

            cboArticuloID.SelectedValue = If(m_DBO_PedidosClientesDetalles2.ArticuloID = Nothing, -1, m_DBO_PedidosClientesDetalles2.ArticuloID)
            txtCantidad.Text = m_DBO_PedidosClientesDetalles2.Cantidad
            chbServido.Checked = m_DBO_PedidosClientesDetalles2.Servido
            txtObservaciones.Text = m_DBO_PedidosClientesDetalles2.Observaciones
            dtpFechaServicio.Text = If(m_DBO_PedidosClientesDetalles2.FechaServicio.HasValue, Convert.ToString(m_DBO_PedidosClientesDetalles2.FechaServicio), "")
        End If
    End Sub

    Private Sub GetValores()
        m_DBO_PedidosClientesDetalles2.PedidoclienteMaestroID = System.Convert.ToInt32(txtPedidoclienteMaestroID.Text)
        m_DBO_PedidosClientesDetalles2.ArticuloID = System.Convert.ToInt32(cboArticuloID.SelectedValue)
        m_DBO_PedidosClientesDetalles2.Cantidad = System.Convert.ToInt32(txtCantidad.Text)
        m_DBO_PedidosClientesDetalles2.Servido = System.Convert.ToBoolean(chbServido.Checked)
        m_DBO_PedidosClientesDetalles2.Observaciones = If(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)
        m_DBO_PedidosClientesDetalles2.FechaServicio = If(dtpFechaServicio.Text = "", System.DateTime.Now.Date, dtpFechaServicio.Value.Date)
        m_DBO_PedidosClientesDetalles2.FechaModificacion = System.DateTime.Now.Date
        m_DBO_PedidosClientesDetalles2.UsuarioModificacion = BasesParaCompatibilidad.Config.User
    End Sub

    Overrides Sub Guardar()
        GetValores()
        spPedidosClientesDetalles2.GrabarPedidosClientesDetalles2(m_DBO_PedidosClientesDetalles2, dtb)
        Me.Close()
    End Sub

End Class
