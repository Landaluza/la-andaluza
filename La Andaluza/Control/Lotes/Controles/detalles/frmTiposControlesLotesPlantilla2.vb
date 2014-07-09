Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmTiposControlesLotesPlantilla2
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboTiposControlesLotesPlantilla As DBO_TiposControlesLotesPlantilla
    Private m_maestro2 As Integer
    Public Event SeleccionHecha(ByVal sender As System.Object, ByVal e As System.EventArgs)

    Public ReadOnly Property SelectedValue As Integer
        Get
            If Me.dgvGeneral.CurrentRow Is Nothing Then Return 0
            If Me.dgvGeneral.CurrentRow.Cells("Id").Value Is Nothing Then Return 0
            Return Me.dgvGeneral.CurrentRow.Cells("Id").Value
        End Get
    End Property

    Public Sub New(ByVal MaestroID As Integer, ByVal maestro2 As Integer)
        MyBase.New(New spTiposControlesLotesPlantilla, MaestroID.ToString & "','" & maestro2)
        InitializeComponent()

        dboTiposControlesLotesPlantilla = New DBO_TiposControlesLotesPlantilla

        m_maestro2 = maestro2

        'sp.DataGridViewStoredProcedure= sp.DataGridViewStoredProcedureForFilteredSelect & "'" & Me.m_MaestroID & "'" & ", '" & Me.m_maestro2 & "'"

        Me.bdnGeneral.Visible = False
        RemoveHandler Me.dgvGeneral.CellDoubleClick, AddressOf MyBase.dgvGeneral_CellDoubleClick
        AddHandler Me.dgvGeneral.SelectionChanged, AddressOf cell_click
        Me.dgvGeneral.MultiSelect = False
    End Sub

    Private Sub cell_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            RaiseEvent SeleccionHecha(Me.dgvGeneral.CurrentRow.Cells("Id").Value, e)

        Catch ex As Exception

        End Try
    End Sub



    Protected Overrides Sub BindDataSource()

        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .FormatoColumna("Tipo", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Frecuencia", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Procedimiento", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If

    End Sub

End Class
