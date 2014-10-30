Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmGestionesPendientes
    Inherits BasesParaCompatibilidad.gridsimpleform



    Private dboGestionesPendientes As DBO_GestionesPendientes
    Private frmDetallesGestionesPendientes As frmDetallesGestionesPendientes
    Public Event ValueChanged(sender As Object, e As EventArgs)

    Public ReadOnly Property Id As Integer
        Get
            If dgvGeneral Is Nothing Then Return 0
            If dgvGeneral.CurrentRow Is Nothing Then Return 0
            Return If(dgvGeneral.CurrentRow.Cells("Id").Value Is Nothing, 0, Convert.ToInt32(dgvGeneral.CurrentRow.Cells("Id").Value))
        End Get
    End Property

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spGestionesPendientes, MaestroID)
        InitializeComponent()

        dboGestionesPendientes = New DBO_GestionesPendientes


        AddHandler dgvGeneral.SelectionChanged, AddressOf changing
    End Sub

    Private Sub changing()
        RaiseEvent ValueChanged(Nothing, Nothing)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboGestionesPendientes = New DBO_GestionesPendientes
        MyBase.newRegForm = CType(New frmEntGestionesPendientes(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
        dboGestionesPendientes.PendienteID = m_MaestroID
        AddHandler newRegForm.afterSave, AddressOf dgvFill
        newRegForm.SetDataBussinesObject(CType(Me.dboGestionesPendientes, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        'MyBase.newRegForm = CType(New frmEntGestionesPendientes(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
        dboGestionesPendientes = CType(sp, spGestionesPendientes).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
        If Not dboGestionesPendientes Is Nothing Then
            MyBase.newRegForm = CType(New frmEntGestionesPendientes(BasesParaCompatibilidad.gridsimpleform.ACCION_MODIFICAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
            newRegForm.SetDataBussinesObject(CType(Me.dboGestionesPendientes, BasesParaCompatibilidad.DataBussines))
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
                .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("PersonaContactada", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("MedioContacto", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If

    End Sub



End Class
