Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmTiposProductos_ClasesProductos
   Inherits BasesParaCompatibilidad.gridsimpleform
   Implements BasesParaCompatibilidad.Queriable

   private dboTiposProductos_ClasesProductos As DBO_TiposProductos_ClasesProductos
       
   Public Sub New(Optional ByVal MaestroID As Integer = 0)
       MyBase.new(new spTiposProductos_ClasesProductos(),MaestroID.ToString)
       InitializeComponent()
       dboTiposProductos_ClasesProductos = new DBO_TiposProductos_ClasesProductos
       MyBase.newRegForm = ctype(New frmEntTiposProductos_ClasesProductos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(sp, spTiposProductos_ClasesProductos)), BasesParaCompatibilidad.DetailedSimpleForm)
   End Sub

   Private Sub Insert_Before() Handles MyBase.BeforeInsert
           MyBase.newRegForm = ctype(New frmEntTiposProductos_ClasesProductos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR), BasesParaCompatibilidad.DetailedSimpleForm)
           dboTiposProductos_ClasesProductos.Id_TipoProducto = m_MaestroID
       newRegForm.SetDataBussinesObject(ctype(Me.dboTiposProductos_ClasesProductos, BasesParaCompatibilidad.databussines))
   End Sub

   Private Sub modify_Before() Handles MyBase.BeforeModify
       dboTiposProductos_ClasesProductos =ctype(sp, spTiposProductos_ClasesProductos).Select_Record(ctype(dgvGeneral.CurrentRow.Cells("Id").Value, integer))
       If Not dboTiposProductos_ClasesProductos Is Nothing Then
           MyBase.newRegForm = ctype(New frmEntTiposProductos_ClasesProductos(BasesParaCompatibilidad.GridSimpleForm.ACCION_MODIFICAR), BasesParaCompatibilidad.DetailedSimpleForm)
           newRegForm.SetDataBussinesObject(ctype(Me.dboTiposProductos_ClasesProductos,BasesParaCompatibilidad.databussines))
       Else
           MyBase.EventHandeld = True
           Messagebox.show("No se pudo recuperar los datos",  "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
       End If
   End Sub

   Protected Overrides Sub BindDataSource() Implements BasesParaCompatibilidad.Queriable.dataGridViewFill
       'dim dt as datatable = DataTableFill(Me.spTiposProductos_ClasesProductos.DataGridViewStoredProcedure)

       If not datasource Is Nothing Then
       GeneralBindingSource.DataSource = datasource
               With dgvGeneral
                   .DataSource = GeneralBindingSource
               .Columns("Id").Visible = False
               .FormatoColumna("TipoProductoID", BasesParaCompatibilidad.TiposColumna.Izquierda, true)
               .FormatoColumna("Id", BasesParaCompatibilidad.TiposColumna.Izquierda, true)
               End With
       End If

   End Sub

End Class
