Public Class frmEntTiposFrecuenciasIncidencias
   inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Event After_Save(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_TiposFrecuenciasIncidencias As DBO_TiposFrecuenciasIncidencias

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spTiposFrecuenciasIncidencias = Nothing, Optional ByRef v_dbo As DBO_TiposFrecuenciasIncidencias = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spTiposFrecuenciasIncidencias, v_sp)
        m_DBO_TiposFrecuenciasIncidencias = if(v_dbo Is Nothing, New DBO_TiposFrecuenciasIncidencias, v_dbo)
        dbo = m_DBO_TiposFrecuenciasIncidencias
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEntTiposFrecuenciasIncidencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_TiposFrecuenciasIncidencias = New DBO_TiposFrecuenciasIncidencias
        Else
            Me.m_DBO_TiposFrecuenciasIncidencias = dbo
        End If

        txtdescripcion.Text = m_DBO_TiposFrecuenciasIncidencias.descripcion
        txtValor.Text = m_DBO_TiposFrecuenciasIncidencias.Valor
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.Empty


        If txtdescripcion.Text = "" Then
            If errores = "" Then txtdescripcion.Focus()
            errores = errores & "El campo descripcion no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_TiposFrecuenciasIncidencias.descripcion = txtdescripcion.Text
        End If



        m_DBO_TiposFrecuenciasIncidencias.Valor = System.Convert.ToDouble(txtValor.Text)


        If errores = String.Empty Then
            dbo = m_DBO_TiposFrecuenciasIncidencias
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

End Class
