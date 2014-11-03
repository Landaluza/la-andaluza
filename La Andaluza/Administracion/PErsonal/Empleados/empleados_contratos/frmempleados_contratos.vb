Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmempleados_contratos
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboempleados_contratos As DBO_empleados_contratos

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spempleados_contratos, MaestroID)
        InitializeComponent()

        dboempleados_contratos = New DBO_empleados_contratos


        MyBase.newRegForm = New frmEntempleados_contratos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboempleados_contratos = New DBO_empleados_contratos
        If m_MaestroID <> 0 Then dboempleados_contratos.id_empleado = m_MaestroID
        newRegForm.SetDataBussinesObject(Me.dboempleados_contratos)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboempleados_contratos = CType(sp, spempleados_contratos).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboempleados_contratos Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboempleados_contratos)
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub cargar_datos()
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dataSource = sp.select_DgvBy(Me.m_MaestroID, dtb)
    End Sub
    Protected Overrides Sub BindDataSource()


        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .Columns("ruta_documentacion").Visible = False
                .Columns("Empleado").Visible = False
                .FormatoColumna("fecha_inicio", "Inicio", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("fecha_final", "Finalizacion", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("fecha_baja", "Baja", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("referencia", "Referencia", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("observaciones", "Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Contrato", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Puesto", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
