Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmGastosIncidencias
   Inherits BasesParaCompatibilidad.gridsimpleform
   Implements BasesParaCompatibilidad.Queriable

   private dboGastosIncidencias As DBO_GastosIncidencias
       
   Public Sub New(Optional ByVal MaestroID As Integer = 0)
       MyBase.new(new spGastosIncidencias(),MaestroID.ToString)
       InitializeComponent()
       dboGastosIncidencias = new DBO_GastosIncidencias
       MyBase.newRegForm = ctype(New frmEntGastosIncidencias(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(sp, spGastosIncidencias)), BasesParaCompatibilidad.DetailedSimpleForm)
   End Sub

   Private Sub Insert_Before() Handles MyBase.BeforeInsert
           MyBase.newRegForm = ctype(New frmEntGastosIncidencias(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR), BasesParaCompatibilidad.DetailedSimpleForm)
           dboGastosIncidencias.Id_controlIncidencia = m_MaestroID
       newRegForm.SetDataBussinesObject(ctype(Me.dboGastosIncidencias, BasesParaCompatibilidad.databussines))
   End Sub

   Private Sub modify_Before() Handles MyBase.BeforeModify
       dboGastosIncidencias =ctype(sp, spGastosIncidencias).Select_Record(ctype(dgvGeneral.CurrentRow.Cells("Id").Value, integer))
       If Not dboGastosIncidencias Is Nothing Then
           MyBase.newRegForm = ctype(New frmEntGastosIncidencias(BasesParaCompatibilidad.GridSimpleForm.ACCION_MODIFICAR), BasesParaCompatibilidad.DetailedSimpleForm)
           newRegForm.SetDataBussinesObject(ctype(Me.dboGastosIncidencias,BasesParaCompatibilidad.databussines))
       Else
           MyBase.EventHandeld = True
           Messagebox.show("No se pudo recuperar los datos",  "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
       End If
   End Sub

   Protected Overrides Sub BindDataSource() Implements BasesParaCompatibilidad.Queriable.dataGridViewFill
       'dim dt as datatable = DataTableFill(Me.spGastosIncidencias.DataGridViewStoredProcedure)

       If not datasource Is Nothing Then
       GeneralBindingSource.DataSource = datasource
               With dgvGeneral
                   .DataSource = GeneralBindingSource
               .Columns("Id").Visible = False
               .FormatoColumna("Id", BasesParaCompatibilidad.TiposColumna.Izquierda, true)
               .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, true)
               .FormatoColumna("Coste", BasesParaCompatibilidad.TiposColumna.Izquierda, true)
               .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, true)
               .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, true)
               .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, true)
               End With
       End If

   End Sub

End Class
