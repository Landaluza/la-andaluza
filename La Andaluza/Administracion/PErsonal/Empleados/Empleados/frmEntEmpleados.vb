Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntEmpleados
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_Empleados As DBO_Empleados
    Private frmContratos As frmempleados_contratos
    Private frmEmpleados_competencias As frmEmpleados_competencias
    Private frmCostes As frmCostesAnuales_Empleados
    Private ctl_Paises As ctl_Paises
    Protected ctl_Provincias As Ctl_Provincias
    Protected ctl_Poblaciones As Ctl_Poblaciones

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spEmpleados = Nothing, Optional ByRef v_dbo As DBO_Empleados = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spEmpleados, v_sp)
        m_DBO_Empleados = If(v_dbo Is Nothing, New DBO_Empleados, v_dbo)
        dbo = m_DBO_Empleados

        ctl_Paises = New ctl_Paises
        ctl_Poblaciones = New Ctl_Poblaciones
        ctl_Provincias = New Ctl_Provincias
        Me.dtpFechaNacimiento.activarFoco()
    End Sub

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        ctl_Paises = New ctl_Paises
        ctl_Poblaciones = New Ctl_Poblaciones
        ctl_Provincias = New Ctl_Provincias
        Me.dtpFechaNacimiento.activarFoco()
    End Sub

    Private Sub frmEntEmpleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ctl_Paises.spPaises.cargar_ComboBox(Me.cbo_pais_domicilio)
        Me.ctl_Paises.spPaises.cargar_ComboBox(Me.cbo_pais_nacimiento)

        Dim spu As New spUsuarios
        spu.cargar_Usuarios(Me.cboid_usuario)
    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_Empleados = New DBO_Empleados

            Me.cbo_pais_nacimiento.SelectedValue = 198
            Me.cbo_pais_domicilio.SelectedValue = 198
        Else
            Me.m_DBO_Empleados = dbo

            Dim dboPoblaciones As DBO_Poblaciones
            Dim dboProvincias As DBO_Provincias

            If m_DBO_Empleados.id_poblacion_nacimiento <> Nothing Then
                dboPoblaciones = Me.ctl_Poblaciones.spPoblaciones.Select_Record(m_DBO_Empleados.id_poblacion_nacimiento)
                dboProvincias = Me.ctl_Provincias.spProvincias.Select_Record(dboPoblaciones.Id_provincia)

                Me.cbo_pais_nacimiento.SelectedValue = dboProvincias.Id_pais
                Me.cbo_provincia_nacimiento.SelectedValue = dboPoblaciones.Id_provincia
            End If

            If m_DBO_Empleados.id_poblacion_domicilio <> Nothing Then
                dboPoblaciones = Me.ctl_Poblaciones.spPoblaciones.Select_Record(m_DBO_Empleados.id_poblacion_domicilio)
                dboProvincias = Me.ctl_Provincias.spProvincias.Select_Record(dboPoblaciones.Id_provincia)

                Me.cbo_pais_domicilio.SelectedValue = dboProvincias.Id_pais
                Me.cbo_provincia_domicilio.SelectedValue = dboPoblaciones.Id_provincia
            End If

            If m_DBO_Empleados.ContratoVigente Then
                Dim spContratos As New spempleados_contratos
                Me.lVigente.Text = "Fecha finalización: " & spContratos.select_fecha_final(m_DBO_Empleados.ID)
                lVigente.Visible = True
            End If
        End If

        If Me.m_DBO_Empleados.ruta_foto = "" Then
            Me.pbFoto.Image = My.Resources.no_imagen_64
        Else
            Try
                Me.pbFoto.ImageLocation = Me.m_DBO_Empleados.ruta_foto
            Catch ex As Exception
                Me.pbFoto.Image = My.Resources.no_imagen_64
            End Try
        End If

        txtNombre.Text = m_DBO_Empleados.Nombre
        txtPrimerApellido.Text = m_DBO_Empleados.PrimerApellido
        txtSegundoApellido.Text = m_DBO_Empleados.SegundoApellido
        dtpFechaNacimiento.Text = m_DBO_Empleados.FechaNacimiento.ToString
        txtDireccionDomicilio.Text = m_DBO_Empleados.DireccionDomicilio
        txtCodigoPostal.Text = m_DBO_Empleados.CodigoPostal
        txtNIF.Text = m_DBO_Empleados.NIF
        txtNSS.Text = m_DBO_Empleados.NSS
        txtTelefonoFijo.Text = m_DBO_Empleados.TelefonoFijo
        txtTelefonoMovil.Text = m_DBO_Empleados.TelefonoMovil
        txtTelefonoUrgencia.Text = m_DBO_Empleados.TelefonoUrgencia
        txtPersonaContactoUrgencia.Text = m_DBO_Empleados.PersonaContactoUrgencia
        txtEmail.Text = m_DBO_Empleados.Email
        chbContratoVigente.Checked = m_DBO_Empleados.ContratoVigente
        cbo_poblacion_nacimiento.SelectedValue = m_DBO_Empleados.id_poblacion_nacimiento
        cbo_poblacion_domicilio.SelectedValue = m_DBO_Empleados.id_poblacion_domicilio
        cboid_usuario.SelectedValue = m_DBO_Empleados.id_usuario
        txtMvEmpresa.Text = m_DBO_Empleados.MovilEmpresa
        txtCorreoEmpresa.Text = m_DBO_Empleados.EmailEmpresa
        txtExtension.Text = m_DBO_Empleados.Extension

        If Me.ModoDeApertura <> INSERCION Then
            Me.SplitContainer1.Panel2Collapsed = False

            frmContratos = New frmempleados_contratos(Me.m_DBO_Empleados.ID)
            Engine_LA.FormEnPestaña(Me.frmContratos, tpContratos)

            frmEmpleados_competencias = New frmEmpleados_competencias(Me.m_DBO_Empleados.ID)
            Engine_LA.FormEnPestaña(Me.frmEmpleados_competencias, tpCompetencias)

            frmCostes = New frmCostesAnuales_Empleados(Me.m_DBO_Empleados.ID)
            Engine_LA.FormEnPestaña(Me.frmCostes, tpCostes)
        Else
            Me.SplitContainer1.Panel2Collapsed = True
        End If
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty


        If txtNombre.Text = "" Then
            If errores = "" Then txtNombre.Focus()
            errores = errores & "El campo Nombre no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_Empleados.Nombre = txtNombre.Text
        End If

        If txtPrimerApellido.Text = "" Then
            If errores = "" Then txtPrimerApellido.Focus()
            errores = errores & "El campo PrimerApellido no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_Empleados.PrimerApellido = txtPrimerApellido.Text
        End If

        If txtSegundoApellido.Text = "" Then
            If errores = "" Then txtSegundoApellido.Focus()
            errores = errores & "El campo SegundoApellido no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_Empleados.SegundoApellido = txtSegundoApellido.Text
        End If

        If txtTelefonoFijo.Text = "" And txtTelefonoMovil.Text = "" Then
            errores = errores & "No especificó un telefono de contacto." & Environment.NewLine
        Else
            m_DBO_Empleados.TelefonoFijo = txtTelefonoFijo.Text
            m_DBO_Empleados.TelefonoMovil = txtTelefonoMovil.Text
        End If

        m_DBO_Empleados.id_usuario = cboid_usuario.SelectedValue
        m_DBO_Empleados.id_poblacion_domicilio = cbo_poblacion_domicilio.SelectedValue
        m_DBO_Empleados.id_poblacion_nacimiento = cbo_poblacion_nacimiento.SelectedValue

        m_DBO_Empleados.FechaNacimiento = dtpFechaNacimiento.Value.Date
        m_DBO_Empleados.DireccionDomicilio = txtDireccionDomicilio.Text
        m_DBO_Empleados.CodigoPostal = txtCodigoPostal.Text
        m_DBO_Empleados.NIF = txtNIF.Text
        m_DBO_Empleados.NSS = txtNSS.Text
        m_DBO_Empleados.TelefonoUrgencia = txtTelefonoUrgencia.Text
        m_DBO_Empleados.PersonaContactoUrgencia = txtPersonaContactoUrgencia.Text
        m_DBO_Empleados.Email = txtEmail.Text
        m_DBO_Empleados.ContratoVigente = chbContratoVigente.Checked
        m_DBO_Empleados.MovilEmpresa = txtMvEmpresa.Text
        m_DBO_Empleados.Extension = txtExtension.Text
        m_DBO_Empleados.EmailEmpresa = txtCorreoEmpresa.Text

        If errores = String.Empty Then
            dbo = m_DBO_Empleados
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(trans)
    End Sub


    Private Sub butAddid_poblacion_nacimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddid_poblacion_nacimiento.Click
        Try
            Me.ctl_Poblaciones.Añadir_poblacion_para_combo(Me.cbo_poblacion_nacimiento, cbo_provincia_nacimiento.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cbo_pais_nacimiento_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbo_pais_nacimiento.SelectedIndexChanged
        Try
            ctl_Provincias.spProvincias.cargar_ComboBox(Me.cbo_provincia_nacimiento, cbo_pais_nacimiento.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cbo_municipio_nacimiento_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbo_provincia_nacimiento.SelectedIndexChanged
        Try
            ctl_Poblaciones.spPoblaciones.cargar_ComboBox(Me.cbo_poblacion_nacimiento, Me.cbo_provincia_nacimiento.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cbo_pais_domicilio_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbo_pais_domicilio.SelectedIndexChanged
        Try
            ctl_Provincias.spProvincias.cargar_ComboBox(Me.cbo_provincia_domicilio, cbo_pais_domicilio.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cbo_municipio_domicilio_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbo_provincia_domicilio.SelectedIndexChanged
        Try
            ctl_Poblaciones.spPoblaciones.cargar_ComboBox(Me.cbo_poblacion_domicilio, Me.cbo_provincia_domicilio.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAddPais_nacimineto_Click(sender As System.Object, e As System.EventArgs) Handles btnAddPais_nacimineto.Click
        ctl_Paises.Añadir_pais_para_combo(cbo_pais_nacimiento)
    End Sub

    Private Sub btn_pais_domicilio_Click(sender As System.Object, e As System.EventArgs) Handles btn_pais_domicilio.Click
        ctl_Paises.Añadir_pais_para_combo(cbo_pais_nacimiento)
    End Sub

    Private Sub btnAddProvincia_nacimietno_Click(sender As System.Object, e As System.EventArgs) Handles btnAddProvincia_nacimietno.Click
        Me.ctl_Provincias.Añadir_provincias_para_combo(cbo_provincia_nacimiento, Me.cbo_pais_nacimiento.SelectedValue)
    End Sub

    Private Sub btn_provincia_domicilio_Click(sender As System.Object, e As System.EventArgs) Handles btn_provincia_domicilio.Click
        Me.ctl_Provincias.Añadir_provincias_para_combo(cbo_provincia_domicilio, Me.cbo_pais_domicilio.SelectedValue)
    End Sub

    Private Sub butAddid_poblacion_domicilio_Click(sender As System.Object, e As System.EventArgs) Handles butAddid_poblacion_domicilio.Click
        Me.ctl_Poblaciones.Añadir_poblacion_para_combo(Me.cbo_poblacion_domicilio, cbo_provincia_domicilio.SelectedValue)
    End Sub

    Private Sub frmEntEmpleados_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.DetailedSimpleForm.centerIn(Me.Panel1, Me.SplitContainer1.Panel1)
    End Sub


    Private Sub butAddid_usuario_Click(sender As System.Object, e As System.EventArgs) Handles butAddid_usuario.Click
        Dim frm As New frmEntUsuarios(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spUsuarios, New DBO_Usuarios)
        frm.ShowDialog()
        Dim spu As New spUsuarios
        spu.cargar_Usuarios(Me.cboid_usuario)
    End Sub

    Private Sub pbFoto_Click(sender As System.Object, e As System.EventArgs) Handles pbFoto.Click
        Dim archivo As String = BasesParaCompatibilidad.File.Elegir_archivo(If(Me.m_DBO_Empleados.ruta_foto = "", "Z:\Recursos Humanos\Fotos personal\Fotos personal", Me.m_DBO_Empleados.ruta_foto))
        If archivo <> String.Empty Then
            Me.m_DBO_Empleados.ruta_foto = archivo
            Me.pbFoto.ImageLocation = archivo
        End If
    End Sub

    Private Sub btnModUsuario_Click(sender As Object, e As EventArgs) Handles btnModUsuario.Click        
        If Not Me.cboid_usuario.SelectedValue Is Nothing Then
            Dim spusuarios As New spUsuarios
            Dim dbousuarios As DBO_Usuarios = spusuarios.Select_Record(Me.cboid_usuario.SelectedValue)
            Dim frm As New frmEntUsuarios(BasesParaCompatibilidad.gridsimpleform.ACCION_MODIFICAR, spusuarios, dbousuarios)
            frm.ShowDialog()
            Dim spu As New spUsuarios
            spu.cargar_Usuarios(Me.cboid_usuario)
        End If
    End Sub
End Class
