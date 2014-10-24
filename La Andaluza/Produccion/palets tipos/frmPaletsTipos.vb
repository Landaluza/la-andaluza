Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmPaletsTipos
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboPaletsTipos As DBO_PaletsTipos

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spPaletsTipos, MaestroID)
        InitializeComponent()

        dboPaletsTipos = New DBO_PaletsTipos


        MyBase.newRegForm = CType(New frmEntPaletsTipos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub



    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(CType(Me.dboPaletsTipos, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboPaletsTipos = CType(sp, spPaletsTipos).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
        If Not dboPaletsTipos Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboPaletsTipos, BasesParaCompatibilidad.DataBussines))
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
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("CodigoQS", BasesParaCompatibilidad.TiposColumna.Miles, 50)
                .FormatoColumna("Largo", BasesParaCompatibilidad.TiposColumna.Double2, 50)
                .FormatoColumna("Ancho", BasesParaCompatibilidad.TiposColumna.Double2, 50)
                .FormatoColumna("Alto", BasesParaCompatibilidad.TiposColumna.Double2, 50)
                .FormatoColumna("Peso", BasesParaCompatibilidad.TiposColumna.Double2, 50)
                .FormatoColumna("Material", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Alias", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If

    End Sub

End Class
