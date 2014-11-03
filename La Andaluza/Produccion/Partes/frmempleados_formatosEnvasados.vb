Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmempleados_formatosEnvasados
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboempleados_formatosEnvasados As DBO_empleados_formatosEnvasados
    Private numero_empleados_necesarios As Integer
    Private ts As ToolStripButton
    Private frmEntPersonalEnvasadoFin As frmEntPersonalEnvasadoFin

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spempleados_formatosEnvasados, MaestroID)
        InitializeComponent()

        dboempleados_formatosEnvasados = New DBO_empleados_formatosEnvasados


        Dim frm As New frmEntempleados_formatosEnvasados(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
        MyBase.newRegForm = frm
        Me.butSalir.Visible = False
        Me.Embebido = True
        AddHandler MyBase.newRegForm.afterSave, AddressOf Me.dgvFill
        AddHandler frm.afterSave, AddressOf Me.dgvFill

        ts = Me.bdnGeneral.Items.Add("Finalizar en lote")
        ts.Text = "Finalizar en lote"
        ts.Image = My.Resources.package_green
        AddHandler ts.Click, AddressOf Me.FinalizarEnLote
    End Sub

    Private Sub FinalizarEnLote()
        frmEntPersonalEnvasadoFin = New frmEntPersonalEnvasadoFin(Me.m_MaestroID)
        frmEntPersonalEnvasadoFin.ShowDialog()
        Me.dgvFill()
    End Sub


    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        Dim frm As New frmEntempleados_formatosEnvasados(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
        MyBase.newRegForm = frm
        AddHandler frm.afterSave, AddressOf Me.dgvFill
        dboempleados_formatosEnvasados.id_formatoEnvasado = m_MaestroID
        Dim d As New DBO_empleados_formatosEnvasados
        d.id_formatoEnvasado = Me.dboempleados_formatosEnvasados.id_formatoEnvasado
        newRegForm.SetDataBussinesObject(d)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboempleados_formatosEnvasados = CType(sp, spempleados_formatosEnvasados).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboempleados_formatosEnvasados Is Nothing Then
            Dim frm As New frmEntempleados_formatosEnvasados(BasesParaCompatibilidad.gridsimpleform.ACCION_MODIFICAR, sp)
            MyBase.newRegForm = frm
            AddHandler frm.afterSave, AddressOf Me.dgvFill
            newRegForm.SetDataBussinesObject(Me.dboempleados_formatosEnvasados)
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then
            dataSource.Columns(5).DataType = System.Type.GetType("System.Boolean")

            GeneralBindingSource.DataSource = dataSource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .Columns("FormatoEnvasadoID").Visible = False
                .FormatoColumna("Empleado", BasesParaCompatibilidad.TiposColumna.Persona, 200)
                .FormatoColumna("Inicio", BasesParaCompatibilidad.TiposColumna.Hora, 80)
                .FormatoColumna("Fin", BasesParaCompatibilidad.TiposColumna.Hora, 80)
                .FormatoColumna("Causa", BasesParaCompatibilidad.TiposColumna.Descripcion, True)
                .FormatoColumna("NoConforme", "NC", BasesParaCompatibilidad.TiposColumna.Centro, 40)

            End With
        End If




        'If Config.UserType = 3 Then
        '    Me.butModificar.Visible = False
        '    Me.butModificar.Enabled = False
        'End If
    End Sub

    'Private Sub check_eliminar() Handles MyBase.BeforeDelete
    '    If Config.UserType = 3 Then
    '        If Me.sp.es_parte_envasado(Me.dgvGeneral.CurrentRow.Cells("Id").Value) Then
    '            EventHandeld = True
    '        End If
    '    End If
    'End Sub

    Sub deshabilitarAcciones()
        Me.butEliminar.Enabled = False
        Me.butModificar.Enabled = False
        Me.butNuevo.Enabled = False
        If Me.butExcel.Visible Then Me.butExcel.Enabled = False
        If Me.butWord.Visible Then Me.butWord.Enabled = False
        If Me.butVer.Visible Then Me.butVer.Enabled = False
        If Me.butImprimir.Visible Then Me.butImprimir.Enabled = False
    End Sub



End Class
