Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmdetallePorFamilia
   Inherits BasesParaCompatibilidad.gridsimpleform
   Implements BasesParaCompatibilidad.Queriable

    Private dbodetallePorFamilia As DBO_FamliaProductos_TiposProductos
       
   Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spFamliaProductos_TiposProductos(), MaestroID.ToString)
       InitializeComponent()
        dbodetallePorFamilia = New DBO_FamliaProductos_TiposProductos
        MyBase.newRegForm = CType(New frmEntdetallePorFamilia(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, CType(sp, spFamliaProductos_TiposProductos)), BasesParaCompatibilidad.DetailedSimpleForm)
   End Sub

   Private Sub Insert_Before() Handles MyBase.BeforeInsert
           MyBase.newRegForm = ctype(New frmEntdetallePorFamilia(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR), BasesParaCompatibilidad.DetailedSimpleForm)
           dbodetallePorFamilia.Id_FamiliaProducto = m_MaestroID
       newRegForm.SetDataBussinesObject(ctype(Me.dbodetallePorFamilia, BasesParaCompatibilidad.databussines))
   End Sub

   Private Sub modify_Before() Handles MyBase.BeforeModify
        dbodetallePorFamilia = CType(sp, spFamliaProductos_TiposProductos).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer))
       If Not dbodetallePorFamilia Is Nothing Then
           MyBase.newRegForm = ctype(New frmEntdetallePorFamilia(BasesParaCompatibilidad.GridSimpleForm.ACCION_MODIFICAR), BasesParaCompatibilidad.DetailedSimpleForm)
           newRegForm.SetDataBussinesObject(ctype(Me.dbodetallePorFamilia,BasesParaCompatibilidad.databussines))
       Else
           MyBase.EventHandeld = True
           Messagebox.show("No se pudo recuperar los datos",  "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
       End If
   End Sub

   Protected Overrides Sub BindDataSource() Implements BasesParaCompatibilidad.Queriable.dataGridViewFill
       'dim dt as datatable = DataTableFill(Me.spdetallePorFamilia.DataGridViewStoredProcedure)

       If not datasource Is Nothing Then
       GeneralBindingSource.DataSource = datasource
               With dgvGeneral
                   .DataSource = GeneralBindingSource
               .Columns("Id").Visible = False
               End With
       End If

   End Sub

End Class
