Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmEmpleados
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboEmpleados As DBO_Empleados

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spEmpleados, MaestroID)
        InitializeComponent()

        dboEmpleados = New DBO_Empleados


        MyBase.newRegForm = New frmEntEmpleados(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub frmEmpleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim ts As ToolStripButton = Me.bdnGeneral.Items.Add("Ver inactivos")
        ts.ToolTipText = "Ver Inactivos"
        AddHandler ts.Click, AddressOf dgvFillInactivos

        Dim ts2 As ToolStripButton = Me.bdnGeneral.Items.Add("Ver activos")
        ts2.ToolTipText = "Ver activos"
        AddHandler ts2.Click, AddressOf dgvFill
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboEmpleados)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboEmpleados = CType(sp, spEmpleados).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboEmpleados Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboEmpleados)
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource()

        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            dgvGeneral.DataSource = GeneralBindingSource
            formato()
        End If
    End Sub

    Protected Sub dgvFillInactivos()
        dataSource = CType(Me.sp, spEmpleados).devolver_empleados_inactivos(dtb)
        BindDataSource()
    End Sub

    Private Sub formato()
        With dgvGeneral
            .Columns("Id").Visible = False
            .Columns("ContratoVigente").Visible = False
            .Columns("ruta_foto").Visible = False
            .Columns("FechaNacimiento").Visible = False
            .Columns("DireccionDomicilio").Visible = False
            .Columns("CodigoPostal").Visible = False
            .Columns("NSS").Visible = False
            .Columns("Email").Visible = False
            .Columns("Usuario").Visible = False
            .Columns("PoblacionNacimiento").Visible = False
            .Columns("PoblacionDomicilio").Visible = False

            .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
            .FormatoColumna("NIF", BasesParaCompatibilidad.TiposColumna.Derecha, 96)
            .FormatoColumna("Fijo", BasesParaCompatibilidad.TiposColumna.Derecha, 96)
            .FormatoColumna("Movil", BasesParaCompatibilidad.TiposColumna.Derecha, 96)
            .FormatoColumna("Urgencia", BasesParaCompatibilidad.TiposColumna.Derecha, 96)
            .FormatoColumna("Empresa", BasesParaCompatibilidad.TiposColumna.Derecha, 96)
            .FormatoColumna("PersonaContactoUrgencia", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
        End With
    End Sub
End Class
