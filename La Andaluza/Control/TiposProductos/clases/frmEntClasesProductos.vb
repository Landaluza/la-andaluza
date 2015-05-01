Public Class frmEntClasesProductos
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_ClasesProductos As DBO_ClasesProductos
    Private frmProductos As frmClasesProductosPorClase

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spClasesProductos = Nothing, Optional ByRef v_dbo As DBO_ClasesProductos = Nothing)
        MyBase.new(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.databussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spClasesProductos, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_ClasesProductos = If(v_dbo Is Nothing, New DBO_ClasesProductos, v_dbo)
        dbo = m_DBO_ClasesProductos
    End Sub

    Public Sub New()
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, CType(New spClasesProductos, BasesParaCompatibilidad.storedprocedure), CType(New DBO_ClasesProductos, BasesParaCompatibilidad.databussines))
        InitializeComponent()
    End Sub

    Private Sub frmEntClasesProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (Me.mododeapertura = VISION) Then
        End If
        If Config.UserType <> 4 AndAlso Config.UserType <> 9 Then
        End If

    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        If (Me.modoDeApertura = INSERCION) Then
            Me.m_DBO_ClasesProductos = New dbo_ClasesProductos
        Else
            Me.m_DBO_ClasesProductos = CType(dbo, DBO_ClasesProductos)
        End If

        txtNombre.Text = m_DBO_ClasesProductos.Nombre
        txtObservaciones.Text = m_DBO_ClasesProductos.Observaciones

        If Me.ModoDeApertura <> INSERCION Then
            Me.frmProductos = New frmClasesProductosPorClase(Me.m_DBO_ClasesProductos.ID)
            Engine_LA.FormEnPestaña(frmProductos, tpProductos)
        Else
            Engine_LA.FormEnPestaña(New Form, tpProductos)
        End If
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.empty


        If txtNombre.Text = "" Then
            If errores = "" Then txtNombre.Focus()
            errores = errores & "El campo Nombre no puede estar vacío." & Environment.NewLine()
        Else
            m_DBO_ClasesProductos.Nombre = txtNombre.Text
        End If



        m_DBO_ClasesProductos.Observaciones = txtObservaciones.Text


        If (errores = String.empty) Then
            Dbo = CType(m_DBO_ClasesProductos, BasesParaCompatibilidad.databussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

    Private Sub frmEntClasesProductos_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.pantalla.centerIn(CType(Me.tlpMiddle, Control), Me)
    End Sub
End Class
