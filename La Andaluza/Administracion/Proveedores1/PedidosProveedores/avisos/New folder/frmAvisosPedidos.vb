Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmAvisosPedidos
   Inherits BasesParaCompatibilidad.gridsimpleform
   Implements BasesParaCompatibilidad.Queriable

   private dboAvisosPedidos As DBO_AvisosPedidos
       
   Public Sub New(Optional ByVal MaestroID As Integer = 0)
       MyBase.new(new spAvisosPedidos(),MaestroID.ToString)
       InitializeComponent()
       dboAvisosPedidos = new DBO_AvisosPedidos
       MyBase.newRegForm = ctype(New frmEntAvisosPedidos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(sp, spAvisosPedidos)), BasesParaCompatibilidad.DetailedSimpleForm)
   End Sub

   Private Sub Insert_Before() Handles MyBase.BeforeInsert
       newRegForm.SetDataBussinesObject(ctype(Me.dboAvisosPedidos, BasesParaCompatibilidad.databussines))
   End Sub

   Private Sub modify_Before() Handles MyBase.BeforeModify
       dboAvisosPedidos =ctype(sp, spAvisosPedidos).Select_Record(ctype(dgvGeneral.CurrentRow.Cells("Id").Value, integer))
       If Not dboAvisosPedidos Is Nothing Then
           newRegForm.SetDataBussinesObject(ctype(Me.dboAvisosPedidos,BasesParaCompatibilidad.databussines))
       Else
           MyBase.EventHandeld = True
           Messagebox.show("No se pudo recuperar los datos",  "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
       End If
   End Sub

   Protected Overrides Sub BindDataSource() Implements BasesParaCompatibilidad.Queriable.dataGridViewFill
       'dim dt as datatable = DataTableFill(Me.spAvisosPedidos.DataGridViewStoredProcedure)

       If not datasource Is Nothing Then
       GeneralBindingSource.DataSource = datasource
               With dgvGeneral
                   .DataSource = GeneralBindingSource
               .Columns("Id").Visible = False
               .FormatoColumna("ProveedorID", BasesParaCompatibilidad.TiposColumna.Izquierda, true)
               .FormatoColumna("ArticuloID", BasesParaCompatibilidad.TiposColumna.Izquierda, true)
                   .FormatoColumna("Cabecera", BasesParaCompatibilidad.TiposColumna.Izquierda, true)
                   .FormatoColumna("Detalle", BasesParaCompatibilidad.TiposColumna.Izquierda, true)
                   .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 80)
               End With
       End If

   End Sub

End Class
