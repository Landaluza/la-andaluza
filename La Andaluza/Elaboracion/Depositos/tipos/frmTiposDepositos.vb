Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmTiposDepositos
   Inherits BasesParaCompatibilidad.gridsimpleform
   Implements BasesParaCompatibilidad.Queriable

   private dboTiposDepositos As DBO_TiposDepositos
       
   Public Sub New()
       MyBase.new(new spTiposDepositos(), "")
       InitializeComponent()
       dboTiposDepositos = new DBO_TiposDepositos
       MyBase.newRegForm = ctype(New frmEntTiposDepositos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(sp, spTiposDepositos)), BasesParaCompatibilidad.DetailedSimpleForm)
   End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        Me.dboTiposDepositos = New DBO_TiposDepositos
        newRegForm.SetDataBussinesObject(CType(Me.dboTiposDepositos, BasesParaCompatibilidad.DataBussines))
    End Sub

   Private Sub modify_Before() Handles MyBase.BeforeModify
        dboTiposDepositos = CType(sp, spTiposDepositos).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
       If Not dboTiposDepositos Is Nothing Then
           newRegForm.SetDataBussinesObject(ctype(Me.dboTiposDepositos,BasesParaCompatibilidad.databussines))
       Else
           MyBase.EventHandeld = True
           Messagebox.show("No se pudo recuperar los datos",  "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
       End If
   End Sub

   Protected Overrides Sub BindDataSource() Implements BasesParaCompatibilidad.Queriable.dataGridViewFill
       'dim dt as datatable = DataTableFill(Me.spTiposDepositos.DataGridViewStoredProcedure)

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
