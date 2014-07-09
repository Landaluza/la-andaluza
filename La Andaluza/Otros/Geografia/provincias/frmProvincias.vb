Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmProvincias
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboProvincias As DBO_Provincias

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spProvincias, MaestroID)
        InitializeComponent()

        dboProvincias = New DBO_Provincias


        MyBase.newRegForm = New frmEntProvincias(ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        If m_MaestroID <> 0 Then dboProvincias.Id_pais = m_MaestroID
        newRegForm.SetDataBussinesObject(Me.dboProvincias)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboProvincias = CType(sp, spProvincias).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dboProvincias Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboProvincias)
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource()
        GeneralBindingSource.DataSource = dataSource ' DataTableFill(Me.sp.DataGridViewStoredProcedure)

        If Not GeneralBindingSource.DataSource Is Nothing Then
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
