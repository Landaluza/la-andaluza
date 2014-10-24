Public Class frmEntMedidasProductos
   inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
     Public Event afterSave1(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave

    Private m_DBO_MedidasProductos As DBO_MedidasProductos

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spMedidasProductos = Nothing, Optional ByRef v_dbo As DBO_MedidasProductos = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spMedidasProductos, v_sp)
        m_DBO_MedidasProductos = if(v_dbo Is Nothing, New DBO_MedidasProductos, v_dbo)
        dbo = m_DBO_MedidasProductos
    End Sub

    Public Sub New()
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spMedidasProductos, New DBO_MedidasProductos)
        InitializeComponent()
    End Sub

    Private Sub frmEntMedidasProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_MedidasProductos = New DBO_MedidasProductos
        Else
            Me.m_DBO_MedidasProductos = dbo
        End If

        txtDescripcion.Text = m_DBO_MedidasProductos.Descripcion
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.Empty


        If txtDescripcion.Text = "" Then
            If errores = "" Then txtDescripcion.Focus()
            errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_MedidasProductos.Descripcion = txtDescripcion.Text
        End If



        If errores = String.Empty Then
            dbo = m_DBO_MedidasProductos
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub


    Private Sub frmEntMedidasProductos_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.pantalla.centerIn(Me.Panel1, Me)
    End Sub
End Class
