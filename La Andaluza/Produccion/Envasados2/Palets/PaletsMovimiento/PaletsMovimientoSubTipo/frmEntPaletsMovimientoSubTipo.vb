Imports BasesParaCompatibilidad.ComboBoxExtension
Public Class frmEntPaletsMovimientoSubTipo
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_ID As Int32
    Private m_Maestro As Int32
    Private m_RegistroActual As DBO_PaletsMovimientoSubTipo
    Private spPaletsMovimientoSubTipo As spPaletsMovimientoSubTipo

    Public Sub New(ByVal ID As Int32, ByVal Maestro As Integer)
        InitializeComponent()
        spPaletsMovimientoSubTipo = New spPaletsMovimientoSubTipo
        m_ID = ID
        m_Maestro = Maestro
    End Sub

    Private Sub frmEntPaletsMovimientoSubTipo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboTipo.mam_DataSource("PaletsMovimientosTipos1Cbo", True)
        cboTipo.SelectedValue = m_Maestro

        m_RegistroActual = spPaletsMovimientoSubTipo.Select_Record(m_ID)
        SetValores()
        ModificarBindingNavigator()
    End Sub

    Overrides Sub Guardar()
        Dim m_NewRegistroActual As New DBO_PaletsMovimientoSubTipo
        GetValores(m_NewRegistroActual)
        If Me.Text.Substring(0, 3) = "Ins" Then
            spPaletsMovimientoSubTipo.InsertPaletsMovimientoSubTipo(m_NewRegistroActual)
        Else
            GetValores(m_NewRegistroActual)
            Try
                If Not spPaletsMovimientoSubTipo.UpdatePaletsMovimientoSubTipo(m_RegistroActual, m_NewRegistroActual) Then
                    MessageBox.Show("Error", "No se ha actualizado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.DialogResult = Windows.Forms.DialogResult.Retry
                Else
                    m_RegistroActual = m_NewRegistroActual
                End If
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Catch ex As Exception
                MessageBox.Show(ex.Message, Convert.ToString(ex.GetType))
            End Try
            Update()
        End If
        Me.Close()
    End Sub

    Public Overrides Sub SetValores()
        txtID.Text = m_RegistroActual.ID
        'cboTipo.SelectedValue = if(m_RegistroActual.Tipo_IsDBNull = True, Nothing, m_RegistroActual.Tipo)
        txtDescripcion.Text = If(m_RegistroActual.Descripcion_IsDBNull = True, Nothing, m_RegistroActual.Descripcion)
    End Sub

    Private Sub GetValores(ByVal m_RegistroActual As DBO_PaletsMovimientoSubTipo)
        m_RegistroActual.Tipo = System.Convert.ToInt32(If(cboTipo.Text = "", Nothing, cboTipo.SelectedValue))
        m_RegistroActual.Tipo_IsDBNull = If(cboTipo.Text = "", True, False)
        m_RegistroActual.Descripcion = System.Convert.ToString(If(txtDescripcion.Text = "", Nothing, txtDescripcion.Text))
        m_RegistroActual.Descripcion_IsDBNull = If(txtDescripcion.Text = "", True, False)
        m_RegistroActual.FechaModificacion = System.DateTime.Now.Date
        m_RegistroActual.FechaModificacion_IsDBNull = False
        m_RegistroActual.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        m_RegistroActual.UsuarioModificacion_IsDBNull = False
    End Sub

End Class
