Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmDepositos_TiposDepositos
   Inherits BasesParaCompatibilidad.gridsimpleform
   Implements BasesParaCompatibilidad.Queriable

   private dboDepositos_TiposDepositos As DBO_Depositos_TiposDepositos
       
   Public Sub New(Optional ByVal MaestroID As Integer = 0)
       MyBase.new(new spDepositos_TiposDepositos(),MaestroID.ToString)
       InitializeComponent()
       dboDepositos_TiposDepositos = new DBO_Depositos_TiposDepositos
       MyBase.newRegForm = ctype(New frmEntDepositos_TiposDepositos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(sp, spDepositos_TiposDepositos)), BasesParaCompatibilidad.DetailedSimpleForm)
   End Sub

   Private Sub Insert_Before() Handles MyBase.BeforeInsert
           MyBase.newRegForm = ctype(New frmEntDepositos_TiposDepositos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR), BasesParaCompatibilidad.DetailedSimpleForm)
           dboDepositos_TiposDepositos.Id_Deposito = m_MaestroID
       newRegForm.SetDataBussinesObject(ctype(Me.dboDepositos_TiposDepositos, BasesParaCompatibilidad.databussines))
   End Sub

   Private Sub modify_Before() Handles MyBase.BeforeModify
       dboDepositos_TiposDepositos =ctype(sp, spDepositos_TiposDepositos).Select_Record(ctype(dgvGeneral.CurrentRow.Cells("Id").Value, integer))
       If Not dboDepositos_TiposDepositos Is Nothing Then
           MyBase.newRegForm = ctype(New frmEntDepositos_TiposDepositos(BasesParaCompatibilidad.GridSimpleForm.ACCION_MODIFICAR), BasesParaCompatibilidad.DetailedSimpleForm)
           newRegForm.SetDataBussinesObject(ctype(Me.dboDepositos_TiposDepositos,BasesParaCompatibilidad.databussines))
       Else
           MyBase.EventHandeld = True
           Messagebox.show("No se pudo recuperar los datos",  "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
       End If
   End Sub

   Protected Overrides Sub BindDataSource() Implements BasesParaCompatibilidad.Queriable.dataGridViewFill
       'dim dt as datatable = DataTableFill(Me.spDepositos_TiposDepositos.DataGridViewStoredProcedure)

       If not datasource Is Nothing Then
       GeneralBindingSource.DataSource = datasource
               With dgvGeneral
                   .DataSource = GeneralBindingSource
               .Columns("Id").Visible = False
               .FormatoColumna("DepositoID", BasesParaCompatibilidad.TiposColumna.Izquierda, true)
               .FormatoColumna("Id", BasesParaCompatibilidad.TiposColumna.Izquierda, true)
               End With
       End If

   End Sub

End Class
