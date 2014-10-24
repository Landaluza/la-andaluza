Public Class frmEntArticulosTipos
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_ArticulosTipos As DBO_ArticulosTipos
    Private frmArticulosTiposDocumentos As frmArticulosTiposDocumentos

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spArticulosTipos = Nothing, Optional ByRef v_dbo As DBO_ArticulosTipos = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spArticulosTipos, v_sp)
        m_DBO_ArticulosTipos = if(v_dbo Is Nothing, New DBO_ArticulosTipos, v_dbo)
        dbo = m_DBO_ArticulosTipos
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEntArticulosTipos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spEmpleados
        s.cargar_Empleados(Me.cboResponsable, dtb)
        If Me.mododeapertura = VISION Then
            Me.cboResponsable.enabled = False
            Me.lblResponsableID.enabled = False
        End If
    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.modoDeApertura = INSERCION Then
            Me.m_DBO_ArticulosTipos = New dbo_ArticulosTipos
        Else
            Me.m_DBO_ArticulosTipos = dbo
        End If

        cboResponsable.SelectedValue = m_DBO_ArticulosTipos.ResponsableID
        txtDescripcion.Text = m_DBO_ArticulosTipos.Descripcion
        txtUtilizacion.Text = m_DBO_ArticulosTipos.Utilizacion
        txtObservaciones.Text = m_DBO_ArticulosTipos.Observaciones
        txtCodificacion.Text = m_DBO_ArticulosTipos.Codificacion


        frmArticulosTiposDocumentos = New frmArticulosTiposDocumentos(Me.m_DBO_ArticulosTipos.ID)
        frmArticulosTiposDocumentos.Embebido = True
        Engine_LA.FormEnPestaña(frmArticulosTiposDocumentos, tpDocumentos)
        If Me.ModoDeApertura = INSERCION Then
            frmArticulosTiposDocumentos.Enabled = False
        End If
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        m_DBO_ArticulosTipos.Descripcion = txtDescripcion.Text


        m_DBO_ArticulosTipos.Utilizacion = txtUtilizacion.Text


        m_DBO_ArticulosTipos.Observaciones = txtObservaciones.Text


        m_DBO_ArticulosTipos.Codificacion = txtCodificacion.Text
        m_DBO_ArticulosTipos.ResponsableID = Me.cboResponsable.SelectedValue

        If errores = String.empty Then
            Dbo = m_DBO_ArticulosTipos
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

    Private Sub butVerResponsableID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerResponsableID.Click
        Dim frmEnt As New frmEmpleados()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddResponsableID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddResponsableID.Click
        Dim DBO_Empleados As New DBO_Empleados
        Dim frmEnt As New frmEntEmpleados(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spEmpleados, DBO_Empleados)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spEmpleados
        s.cargar_Empleados(Me.cboResponsable, dtb)
    End Sub

End Class
