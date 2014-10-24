Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmConceptosGastosIncidencias
   Inherits BasesParaCompatibilidad.gridsimpleform
   Implements BasesParaCompatibilidad.Queriable

   private dboConceptosGastosIncidencias As DBO_ConceptosGastosIncidencias
       
   Public Sub New(Optional ByVal MaestroID As Integer = 0)
       MyBase.new(new spConceptosGastosIncidencias(),MaestroID.ToString)
       InitializeComponent()
       dboConceptosGastosIncidencias = new DBO_ConceptosGastosIncidencias
       MyBase.newRegForm = ctype(New frmEntConceptosGastosIncidencias(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(sp, spConceptosGastosIncidencias)), BasesParaCompatibilidad.DetailedSimpleForm)
   End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(CType(Me.dboConceptosGastosIncidencias, BasesParaCompatibilidad.databussines))
    End Sub

   Private Sub modify_Before() Handles MyBase.BeforeModify
        dboConceptosGastosIncidencias = CType(sp, spConceptosGastosIncidencias).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
       If Not dboConceptosGastosIncidencias Is Nothing Then
           newRegForm.SetDataBussinesObject(ctype(Me.dboConceptosGastosIncidencias,BasesParaCompatibilidad.databussines))
       Else
           MyBase.EventHandeld = True
           Messagebox.show("No se pudo recuperar los datos",  "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
       End If
   End Sub

   Protected Overrides Sub BindDataSource() Implements BasesParaCompatibilidad.Queriable.dataGridViewFill
       'dim dt as datatable = DataTableFill(Me.spConceptosGastosIncidencias.DataGridViewStoredProcedure)

       If not datasource Is Nothing Then
       GeneralBindingSource.DataSource = datasource
               With dgvGeneral
                   .DataSource = GeneralBindingSource
               .Columns("Id").Visible = False
                   .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, true)
               .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, true)
               .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, true)
               End With
       End If

   End Sub

End Class
