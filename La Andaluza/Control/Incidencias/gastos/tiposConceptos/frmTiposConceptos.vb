Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmTiposConceptos
   Inherits BasesParaCompatibilidad.gridsimpleform
   Implements BasesParaCompatibilidad.Queriable

   private dboTiposConceptos As DBO_TiposConceptos
       
   Public Sub New(Optional ByVal MaestroID As Integer = 0)
       MyBase.new(new spTiposConceptos(),MaestroID.ToString)
       InitializeComponent()
       dboTiposConceptos = new DBO_TiposConceptos
       MyBase.newRegForm = ctype(New frmEntTiposConceptos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(sp, spTiposConceptos)), BasesParaCompatibilidad.DetailedSimpleForm)
   End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(CType(Me.dboTiposConceptos, BasesParaCompatibilidad.databussines))
    End Sub

   Private Sub modify_Before() Handles MyBase.BeforeModify
        dboTiposConceptos = CType(sp, spTiposConceptos).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
       If Not dboTiposConceptos Is Nothing Then
           newRegForm.SetDataBussinesObject(ctype(Me.dboTiposConceptos,BasesParaCompatibilidad.databussines))
       Else
           MyBase.EventHandeld = True
           Messagebox.show("No se pudo recuperar los datos",  "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
       End If
   End Sub

   Protected Overrides Sub BindDataSource() Implements BasesParaCompatibilidad.Queriable.dataGridViewFill
       'dim dt as datatable = DataTableFill(Me.spTiposConceptos.DataGridViewStoredProcedure)

       If not datasource Is Nothing Then
       GeneralBindingSource.DataSource = datasource
               With dgvGeneral
                   .DataSource = GeneralBindingSource
               .Columns("Id").Visible = False
                   .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, true)
               End With
       End If

   End Sub

End Class
