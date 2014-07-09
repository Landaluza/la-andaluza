Public Class frmOrganizacion
    Private frmEspera As BasesParaCompatibilidad.frmEspera
    Private frmTiposUsuarios As frmTiposUsuarios
    Private frmEmpleados As frmEmpleados
    Private frmPuestosTrabajos As frmPuestosTrabajos
    Private frmTiposContratos As frmTipos_contratos
    Private frmPersonalCompetencias As frmPersonalCompetencias

    Private ListadoEmpleados As InformesEmpleados.ListadoEmpleados
    Private ControlEmpleados As InformesEmpleados.ControlEmpleados
    Private ControlEmpleados2 As InformesEmpleados.ControlEmpleados
    Private frmInformeContratoEmpleados As ContratosEmpleados.frmInformeContratoEmpleados
    Private frmInformePuestosEmpleados As InformePuestosEmpleados.Form1
    Public Sub New()

        InitializeComponent()

        frmEmpleados = New frmEmpleados
        frmPuestosTrabajos = New frmPuestosTrabajos
        frmTiposContratos = New frmTipos_contratos
        frmPersonalCompetencias = New frmPersonalCompetencias
        frmTiposUsuarios = New frmTiposUsuarios
        Engine_LA.FormEnPestaña(frmEmpleados, TabPage1)
        Engine_LA.FormEnPestaña(frmPuestosTrabajos, TabPage2)
        Engine_LA.FormEnPestaña(Me.frmTiposContratos, TabPage3)
        Engine_LA.FormEnPestaña(Me.frmPersonalCompetencias, TabPage4)
        Engine_LA.FormEnPestaña(frmTiposUsuarios, TabPage5)
    End Sub

    Private Sub btnInformeEmpelados_Click(sender As System.Object, e As System.EventArgs) Handles btnInformeEmpelados.Click
        frmEspera = New BasesParaCompatibilidad.frmEspera("Generando informe")
        frmEspera.Show()

        Try
            ListadoEmpleados = New InformesEmpleados.ListadoEmpleados(BasesParaCompatibilidad.Config.connectionString)
            ListadoEmpleados.Text = "Listado empleados"
            GUImain.añadirPestaña(ListadoEmpleados)
        Catch ex As Exception
            MessageBox.Show("Error mostrando el informe. Detalles:" & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frmEspera.Close()
        End Try
    End Sub


    Private Sub btnControlHorario_Click(sender As System.Object, e As System.EventArgs) Handles btnControlHorario.Click
        frmEspera = New BasesParaCompatibilidad.frmEspera("Generando informe")
        frmEspera.Show()
        Try
            ControlEmpleados = New InformesEmpleados.ControlEmpleados(BasesParaCompatibilidad.Config.connectionString)
            ControlEmpleados.Text = "Control empleados"
            GUImain.añadirPestaña(ControlEmpleados)
        Catch ex As Exception
            MessageBox.Show("Error mostrando el informe. Detalles:" & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frmEspera.Close()
        End Try
    End Sub

    Private Sub btnControlHoras_Click(sender As Object, e As EventArgs) Handles btnControlHoras.Click
        frmEspera = New BasesParaCompatibilidad.frmEspera("Generando informe")
        frmEspera.Show()
        Try
            ControlEmpleados2 = New InformesEmpleados.ControlEmpleados(BasesParaCompatibilidad.Config.connectionString)
            ControlEmpleados2.Text = "Control horas"
            GUImain.añadirPestaña(ControlEmpleados2)
        Catch ex As Exception
            MessageBox.Show("Error mostrando el informe. Detalles:" & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frmEspera.Close()
        End Try
    End Sub

    Private Sub btnInfContratos_Click(sender As Object, e As EventArgs) Handles btnInfContratos.Click
        frmEspera = New BasesParaCompatibilidad.frmEspera("Generando informe")
        frmEspera.Show()
        Try
            frmInformeContratoEmpleados = New ContratosEmpleados.frmInformeContratoEmpleados(BasesParaCompatibilidad.Config.connectionString)
            frmInformeContratoEmpleados.Text = "Informe contratos"
            GUImain.añadirPestaña(frmInformeContratoEmpleados)
        Catch ex As Exception
            MessageBox.Show("Error mostrando el informe. Detalles:" & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frmEspera.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmEspera = New BasesParaCompatibilidad.frmEspera("Generando informe")
        frmEspera.Show()
        Try
            frmInformePuestosEmpleados = New InformePuestosEmpleados.Form1(BasesParaCompatibilidad.Config.connectionString)
            frmInformePuestosEmpleados.Text = "Informe puestos"
            GUImain.añadirPestaña(frmInformePuestosEmpleados)
        Catch ex As Exception
            MessageBox.Show("Error mostrando el informe. Detalles:" & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frmEspera.Close()
        End Try
    End Sub
End Class