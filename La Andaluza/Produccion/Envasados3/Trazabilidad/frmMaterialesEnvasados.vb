Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmMaterialesEnvasados
    Inherits BasesParaCompatibilidad.gridsimpleform



    Private dboMaterialesEnvasados As DBO_MaterialesEnvasados

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spMaterialesEnvasados, MaestroID)
        InitializeComponent()

        dboMaterialesEnvasados = New DBO_MaterialesEnvasados


        MyBase.newRegForm = New frmEntMaterialesEnvasados(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboMaterialesEnvasados = New DBO_MaterialesEnvasados
        If m_MaestroID <> 0 Then dboMaterialesEnvasados.FormatoEnvasadoID = m_MaestroID
        newRegForm.SetDataBussinesObject(Me.dboMaterialesEnvasados)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboMaterialesEnvasados = CType(sp, spMaterialesEnvasados).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dboMaterialesEnvasados Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboMaterialesEnvasados)
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
                .Columns("Id").Visible = False
                .FormatoColumna("HoraInicio", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("HoraFin", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Lote", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Cantidad", BasesParaCompatibilidad.TiposColumna.Miles, 50)
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
