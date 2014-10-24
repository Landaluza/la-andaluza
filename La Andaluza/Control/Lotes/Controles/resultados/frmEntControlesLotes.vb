Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntControlesLotes
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_ControlesLotes As DBO_ControlesLotes
    Private ruta_defecto As String = "C\" 'temp

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spControlesLotes = Nothing, Optional ByRef v_dbo As DBO_ControlesLotes = Nothing)
        MyBase.New(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.DataBussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spControlesLotes, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_ControlesLotes = If(v_dbo Is Nothing, New DBO_ControlesLotes, v_dbo)
        dbo = m_DBO_ControlesLotes
        dtpFecha.activarFoco()
    End Sub

    Private Sub frmEntControlesLotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim s2 As New spEmpleados
        s2.cargar_Empleados(Me.cboempleado, dtb)

        If Me.ModoDeApertura = VISION Then
            Me.cboempleado.Enabled = False
            Me.lblId_empleado.Enabled = False

            Me.lblId_controlIncidencia.Enabled = False
        End If
        If Config.UserType <> 4 And Config.UserType <> 9 Then
            butAddId_empleado.Enabled = False
            butVerId_empleado.Enabled = False
            butAddId_controlIncidencia.Enabled = False
        End If

        butVer.Visible = True
    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        Me.m_DBO_ControlesLotes = CType(dbo, DBO_ControlesLotes)

        txtResultado.Text = m_DBO_ControlesLotes.Resultado
        chbCorrecto.Checked = m_DBO_ControlesLotes.Correcto
        cboempleado.SelectedValue = m_DBO_ControlesLotes.Id_empleado
        dtpFecha.Value = m_DBO_ControlesLotes.Fecha
        txtRutaControl.Text = m_DBO_ControlesLotes.RutaControl
        txtControlIncidencia.Text = m_DBO_ControlesLotes.Id_controlIncidencia
        txtObservaciones.Text = m_DBO_ControlesLotes.Observaciones


        'optimizar
        Dim spplant As New spTiposControlesLotesPlantilla
        Dim spCon As New spTiposControlesLotes

        Dim DBO_TiposControlesLotesPlantilla As DBO_TiposControlesLotesPlantilla = spplant.Select_Record(m_DBO_ControlesLotes.Id_plantillaControlLote, dtb)
        Dim dbo_con As DBO_TiposControlesLotes = spCon.Select_Record(DBO_TiposControlesLotesPlantilla.Id_TipoControl, dtb)
        ruta_defecto = dbo_con.RutaControles
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty

        If txtResultado.Text = "" Then
            errores = "EL resultado no puede estar vacio" & Environment.NewLine
        End If


        m_DBO_ControlesLotes.Resultado = txtResultado.Text
        m_DBO_ControlesLotes.Id_empleado = cboempleado.SelectedValue
        m_DBO_ControlesLotes.Id_controlIncidencia = If(txtControlIncidencia.Text = "", 0, Convert.ToInt32(txtControlIncidencia.Text))
        m_DBO_ControlesLotes.Correcto = chbCorrecto.Checked
        m_DBO_ControlesLotes.Fecha = dtpFecha.Value
        m_DBO_ControlesLotes.RutaControl = txtRutaControl.Text
        m_DBO_ControlesLotes.Observaciones = txtObservaciones.Text


        If errores = String.Empty Then
            dbo = CType(m_DBO_ControlesLotes, BasesParaCompatibilidad.DataBussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

    Private Sub butRutaControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRutaControl.Click
        Dim arch As String
        'Cambiar "C:\" por la ruta adecuada
        arch = BasesParaCompatibilidad.File.Elegir_archivo(ruta_defecto)

        If Me.Text.Substring(0, 3) <> "Ver" Then
            txtRutaControl.Text = arch
        End If
    End Sub

    Public Overrides Sub Ver()
        Try
            Dim psi As New ProcessStartInfo()
            psi.UseShellExecute = True
            psi.FileName = txtRutaControl.Text
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub butVerId_plantillaControlLote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEnt As New frmTiposControlesLotesPlantilla()
        GUImain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butVerId_empleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_empleado.Click
        Dim frmEnt As New frmEmpleados()
        GUImain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddId_empleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_empleado.Click
        Dim DBO_Empleados As New DBO_Empleados
        Dim frmEnt As New frmEntEmpleados(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spEmpleados, DBO_Empleados)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spEmpleados
        s.cargar_Empleados(Me.cboempleado, dtb)
    End Sub

    Private Sub butVerId_controlIncidencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEnt As New frmControlIncidencias()
        GUImain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddId_controlIncidencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_controlIncidencia.Click
        Dim frm As New frmSeleccionIncidencia
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
        Me.txtControlIncidencia.Text = frm.Id
    End Sub

    Private Sub frmEntControlesLotes_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.pantalla.centerIn(Me.tlpMiddle, Me)
    End Sub

    Private Sub btnLimpiarIncidencia_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiarIncidencia.Click
        txtControlIncidencia.Text = ""
    End Sub
End Class
