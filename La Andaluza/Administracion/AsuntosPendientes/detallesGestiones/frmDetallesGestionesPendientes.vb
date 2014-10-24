Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmDetallesGestionesPendientes
    Inherits BasesParaCompatibilidad.gridsimpleform



    Private dboDetallesGestionesPendientes As DBO_DetallesGestionesPendientes

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spDetallesGestionesPendientes, MaestroID)
        InitializeComponent()

        dboDetallesGestionesPendientes = New DBO_DetallesGestionesPendientes

        'sp.DataGridViewStoredProcedure= sp.DataGridViewStoredProcedureForFilteredSelect & "'" & Me.m_MaestroID & "'"
        MyBase.newRegForm = CType(New frmEntDetallesGestionesPendientes(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub


    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboDetallesGestionesPendientes = New DBO_DetallesGestionesPendientes
        MyBase.newRegForm = CType(New frmEntDetallesGestionesPendientes(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
        dboDetallesGestionesPendientes.GestionPendienteID = m_MaestroID
        newRegForm.SetDataBussinesObject(CType(Me.dboDetallesGestionesPendientes, BasesParaCompatibilidad.DataBussines))
        AddHandler newRegForm.afterSave, AddressOf dgvFill
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboDetallesGestionesPendientes = CType(sp, spDetallesGestionesPendientes).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
        If Not dboDetallesGestionesPendientes Is Nothing Then
            MyBase.newRegForm = CType(New frmEntDetallesGestionesPendientes(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
            newRegForm.SetDataBussinesObject(CType(Me.dboDetallesGestionesPendientes, BasesParaCompatibilidad.DataBussines))
            AddHandler newRegForm.afterSave, AddressOf dgvFill
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource()
        'Me.' dataSource = dtb.Consultar(Me.sp.DataGridViewStoredProcedure)

        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If

    End Sub

End Class
