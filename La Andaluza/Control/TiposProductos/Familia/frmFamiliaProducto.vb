Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmFamiliaProducto
   Inherits BasesParaCompatibilidad.gridsimpleform
   Implements BasesParaCompatibilidad.Queriable

   private dboFamiliaProducto As DBO_FamiliaProducto
       
   Public Sub New(Optional ByVal MaestroID As Integer = 0)
       MyBase.new(new spFamiliaProducto(),MaestroID.ToString)
       InitializeComponent()
       dboFamiliaProducto = new DBO_FamiliaProducto
       MyBase.newRegForm = ctype(New frmEntFamiliaProducto(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(sp, spFamiliaProducto)), BasesParaCompatibilidad.DetailedSimpleForm)
   End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(CType(Me.dboFamiliaProducto, BasesParaCompatibilidad.databussines))
    End Sub

   Private Sub modify_Before() Handles MyBase.BeforeModify
        dboFamiliaProducto = CType(sp, spFamiliaProducto).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
       If Not dboFamiliaProducto Is Nothing Then
           newRegForm.SetDataBussinesObject(ctype(Me.dboFamiliaProducto,BasesParaCompatibilidad.databussines))
       Else
           MyBase.EventHandeld = True
           Messagebox.show("No se pudo recuperar los datos",  "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
       End If
   End Sub

   Protected Overrides Sub BindDataSource() Implements BasesParaCompatibilidad.Queriable.dataGridViewFill
       'dim dt as datatable = DataTableFill(Me.spFamiliaProducto.DataGridViewStoredProcedure)

       If not datasource Is Nothing Then
       GeneralBindingSource.DataSource = datasource
               With dgvGeneral
                   .DataSource = GeneralBindingSource
               .Columns("Id").Visible = False
                   .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, true)
                   .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, true)
               End With
       End If

   End Sub

End Class
