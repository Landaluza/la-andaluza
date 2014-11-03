Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmControlesLotes
    Inherits BasesParaCompatibilidad.gridsimpleform

    Private dboControlesLotes As DBO_ControlesLotes
    Public Event insert()
    Private lote As Integer
    Public WriteOnly Property Plantilla As Integer
        Set(value As Integer)
            dboControlesLotes.Id_plantillaControlLote = value
            sp.DataGridViewStoredProcedure = sp.DataGridViewStoredProcedureForFilteredSelect & "'" & Me.dboControlesLotes.Id_lote & "', '" & dboControlesLotes.Id_plantillaControlLote & "'"
            dgvFill()
        End Set
    End Property

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spControlesLotes, MaestroID.ToString & "','0'")
        InitializeComponent()

        dboControlesLotes = New DBO_ControlesLotes

        dboControlesLotes.Id_lote = MaestroID
        lote = MaestroID
        'sp.DataGridViewStoredProcedure= sp.DataGridViewStoredProcedureForFilteredSelect & "'" & Me.m_MaestroID & "', '" & dboControlesLotes.Id_plantillaControlLote & "'"
        MyBase.newRegForm = CType(New frmEntControlesLotes(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)

        'RemoveHandler butNuevo.Click, AddressOf MyBase.butNuevo_Click
    End Sub

    Private Sub insertado()
        RaiseEvent insert()
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboControlesLotes = New DBO_ControlesLotes
        RaiseEvent insert()

        MyBase.newRegForm = CType(New frmEntControlesLotes(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
        'dboControlesLotes.Id_lote = Me.dboControlesLotes.Id_lote
        dboControlesLotes.Id_lote = lote
        AddHandler newRegForm.afterSave, AddressOf insertado
        newRegForm.SetDataBussinesObject(CType(Me.dboControlesLotes, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        RaiseEvent insert()

        MyBase.newRegForm = CType(New frmEntControlesLotes(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboControlesLotes = CType(sp, spControlesLotes).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)

        If Not dboControlesLotes Is Nothing Then
            AddHandler newRegForm.afterSave, AddressOf insertado
            newRegForm.SetDataBussinesObject(CType(Me.dboControlesLotes, BasesParaCompatibilidad.DataBussines))
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource()

        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            With dgvGeneral
                .DataSource = GeneralBindingSource

                .Columns("Id_plantillaControlLote").Visible = False
                .Columns("Id").Visible = False
                .FormatoColumna("Resultado", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If

    End Sub

End Class
