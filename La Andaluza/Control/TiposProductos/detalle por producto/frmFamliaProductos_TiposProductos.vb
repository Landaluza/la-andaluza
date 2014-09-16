Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmFamliaProductos_TiposProductos
   Inherits BasesParaCompatibilidad.gridsimpleform
   Implements BasesParaCompatibilidad.Queriable

   private dboFamliaProductos_TiposProductos As DBO_FamliaProductos_TiposProductos
       
   Public Sub New(Optional ByVal MaestroID As Integer = 0)
       MyBase.new(new spFamliaProductos_TiposProductos(),MaestroID.ToString)
       InitializeComponent()
       dboFamliaProductos_TiposProductos = new DBO_FamliaProductos_TiposProductos
       MyBase.newRegForm = ctype(New frmEntFamliaProductos_TiposProductos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(sp, spFamliaProductos_TiposProductos)), BasesParaCompatibilidad.DetailedSimpleForm)
   End Sub

   Private Sub Insert_Before() Handles MyBase.BeforeInsert
           MyBase.newRegForm = ctype(New frmEntFamliaProductos_TiposProductos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR), BasesParaCompatibilidad.DetailedSimpleForm)
           dboFamliaProductos_TiposProductos.Id_TipoProducto = m_MaestroID
       newRegForm.SetDataBussinesObject(ctype(Me.dboFamliaProductos_TiposProductos, BasesParaCompatibilidad.databussines))
   End Sub

   Private Sub modify_Before() Handles MyBase.BeforeModify
       dboFamliaProductos_TiposProductos =ctype(sp, spFamliaProductos_TiposProductos).Select_Record(ctype(dgvGeneral.CurrentRow.Cells("Id").Value, integer))
       If Not dboFamliaProductos_TiposProductos Is Nothing Then
           MyBase.newRegForm = ctype(New frmEntFamliaProductos_TiposProductos(BasesParaCompatibilidad.GridSimpleForm.ACCION_MODIFICAR), BasesParaCompatibilidad.DetailedSimpleForm)
           newRegForm.SetDataBussinesObject(ctype(Me.dboFamliaProductos_TiposProductos,BasesParaCompatibilidad.databussines))
       Else
           MyBase.EventHandeld = True
           Messagebox.show("No se pudo recuperar los datos",  "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
       End If
   End Sub

   Protected Overrides Sub BindDataSource() Implements BasesParaCompatibilidad.Queriable.dataGridViewFill
       'dim dt as datatable = DataTableFill(Me.spFamliaProductos_TiposProductos.DataGridViewStoredProcedure)

       If not datasource Is Nothing Then
       GeneralBindingSource.DataSource = datasource
               With dgvGeneral
                   .DataSource = GeneralBindingSource
               .Columns("Id").Visible = False
               .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, true)
               End With
       End If

   End Sub

End Class
