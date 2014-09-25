Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmClasesProductos
   Inherits BasesParaCompatibilidad.gridsimpleform
   Implements BasesParaCompatibilidad.Queriable

   private dboClasesProductos As DBO_ClasesProductos
       
   Public Sub New(Optional ByVal MaestroID As Integer = 0)
       MyBase.new(new spClasesProductos(),MaestroID.ToString)
       InitializeComponent()
       dboClasesProductos = new DBO_ClasesProductos
       MyBase.newRegForm = ctype(New frmEntClasesProductos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(sp, spClasesProductos)), BasesParaCompatibilidad.DetailedSimpleForm)
   End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(CType(Me.dboClasesProductos, BasesParaCompatibilidad.databussines))
    End Sub

   Private Sub modify_Before() Handles MyBase.BeforeModify
       dboClasesProductos =ctype(sp, spClasesProductos).Select_Record(ctype(dgvGeneral.CurrentRow.Cells("Id").Value, integer))
       If Not dboClasesProductos Is Nothing Then
           newRegForm.SetDataBussinesObject(ctype(Me.dboClasesProductos,BasesParaCompatibilidad.databussines))
       Else
           MyBase.EventHandeld = True
           Messagebox.show("No se pudo recuperar los datos",  "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
       End If
   End Sub

   Protected Overrides Sub BindDataSource() Implements BasesParaCompatibilidad.Queriable.dataGridViewFill
       'dim dt as datatable = DataTableFill(Me.spClasesProductos.DataGridViewStoredProcedure)

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
