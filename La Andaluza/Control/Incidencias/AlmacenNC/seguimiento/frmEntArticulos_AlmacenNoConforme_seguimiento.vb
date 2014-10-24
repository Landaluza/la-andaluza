Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntArticulos_AlmacenNoConforme_seguimiento
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_Articulos_AlmacenNoConforme_seguimiento As DBO_Articulos_AlmacenNoConforme_seguimiento

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spArticulos_AlmacenNoConforme_seguimiento = Nothing, Optional ByRef v_dbo As DBO_Articulos_AlmacenNoConforme_seguimiento = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spArticulos_AlmacenNoConforme_seguimiento, v_sp)
        m_DBO_Articulos_AlmacenNoConforme_seguimiento = If(v_dbo Is Nothing, New DBO_Articulos_AlmacenNoConforme_seguimiento, v_dbo)
        dbo = m_DBO_Articulos_AlmacenNoConforme_seguimiento
        dtpFecha.activarFoco()
    End Sub

    Public Sub New()
        MyBase.New(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spArticulos_AlmacenNoConforme_seguimiento, New DBO_Articulos_AlmacenNoConforme_seguimiento)
        InitializeComponent()
        dtpFecha.activarFoco()
    End Sub

    Private Sub frmEntArticulos_AlmacenNoConforme_seguimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores

        Me.m_DBO_Articulos_AlmacenNoConforme_seguimiento = dbo

        dtpFecha.Text = m_DBO_Articulos_AlmacenNoConforme_seguimiento.Fecha.ToString
        txtobservaciones.Text = m_DBO_Articulos_AlmacenNoConforme_seguimiento.observaciones
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty


        m_DBO_Articulos_AlmacenNoConforme_seguimiento.Fecha = dtpFecha.Value.Date


        If txtobservaciones.Text = "" Then
            If errores = "" Then txtobservaciones.Focus()
            errores = errores & "El campo observaciones no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_Articulos_AlmacenNoConforme_seguimiento.observaciones = txtobservaciones.Text
        End If



        If errores = String.Empty Then
            dbo = m_DBO_Articulos_AlmacenNoConforme_seguimiento
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub



End Class
