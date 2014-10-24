Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntNoticias
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_Noticias As DBO_Noticias
    Private frmNoticias_TiposUsuarios As frmNoticias_TiposUsuarios

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spNoticias = Nothing, Optional ByRef v_dbo As DBO_Noticias = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spNoticias, v_sp)
        m_DBO_Noticias = If(v_dbo Is Nothing, New DBO_Noticias, v_dbo)
        dbo = m_DBO_Noticias
        dtpFecha.activarFoco()
    End Sub

    Public Sub New()
        MyBase.New(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spNoticias, New DBO_Noticias)
        InitializeComponent()
        dtpFecha.activarFoco()
    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores

        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_Noticias = New DBO_Noticias
            Me.TabControl1.Enabled = False
        Else
            Me.m_DBO_Noticias = dbo
            Me.TabControl1.Enabled = True
        End If

        frmNoticias_TiposUsuarios = New frmNoticias_TiposUsuarios(Me.m_DBO_Noticias.ID)
        Engine_LA.FormEnPestaña(frmNoticias_TiposUsuarios, Me.TabPage1)

        txtTitulo.Text = m_DBO_Noticias.Titulo
        txtTexto.Text = m_DBO_Noticias.Texto
        dtpFecha.Value = m_DBO_Noticias.Fecha
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty
        m_DBO_Noticias.Titulo = txtTitulo.Text
        m_DBO_Noticias.Texto = txtTexto.Text
        m_DBO_Noticias.Fecha = dtpFecha.Value

        If errores = String.Empty Then
            dbo = m_DBO_Noticias
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'Error")
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        If Me.GetValores Then
            Dim terminar As Boolean
            If Not dtb Is Nothing Then
                Me.dtb = dtb
                terminar = False
            Else
                terminar = True
            End If
            If terminar Then Me.dtb.EmpezarTransaccion()


            Try
                If sp.Grabar(dbo, Me.dtb) Then
                    If Me.ModoDeApertura = INSERCION Then Me.m_DBO_Noticias.ID = Convert.ToInt32(Me.dtb.Consultar("select max(id) from noticias", False).Rows(0).Item(0))
                    If terminar Then Me.dtb.TerminarTransaccion()

                    evitarCerrarSinGuardar = False
                    RaiseEvent afterSave(Me, Nothing)

                    If Me.ModoDeApertura <> INSERCION Then
                        Me.Close()
                    Else
                        Me.ModoDeApertura = MODIFICACION
                        Me.Text = "Modificar noticia"
                        SetValores()
                    End If
                Else
                    If terminar Then
                        Me.dtb.CancelarTransaccion()
                        MessageBox.Show("No se pudo guardar el registro. Asegurese de tener conexion a la red.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        Throw New Exception("Error 1 al guardar el registro")
                    End If
                End If
            Catch ex As Exception
                If terminar Then
                    Me.dtb.CancelarTransaccion()
                    MessageBox.Show("No se pudo guardar el registro. Detalles:" & Environment.NewLine & Environment.NewLine, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Throw New Exception("Error 2 al guardar el registro")
                End If
            End Try
        End If
    End Sub

End Class
