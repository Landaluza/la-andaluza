Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmRecipientesSalidas
   Inherits BasesParaCompatibilidad.gridsimpleform
   Implements BasesParaCompatibilidad.Queriable

   private dboRecipientesSalidas As DBO_RecipientesSalidas
       
   Public Sub New(Optional ByVal MaestroID As Integer = 0)
       MyBase.new(new spRecipientesSalidas(),MaestroID.ToString)
       InitializeComponent()
       dboRecipientesSalidas = new DBO_RecipientesSalidas
       MyBase.newRegForm = ctype(New frmEntRecipientesSalidas(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(sp, spRecipientesSalidas)), BasesParaCompatibilidad.DetailedSimpleForm)
   End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(CType(Me.dboRecipientesSalidas, BasesParaCompatibilidad.databussines))
    End Sub

   Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboRecipientesSalidas = CType(sp, spRecipientesSalidas).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
       If Not dboRecipientesSalidas Is Nothing Then
           newRegForm.SetDataBussinesObject(ctype(Me.dboRecipientesSalidas,BasesParaCompatibilidad.databussines))
       Else
           MyBase.EventHandeld = True
           Messagebox.show("No se pudo recuperar los datos",  "Atenci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
       End If
   End Sub

   Protected Overrides Sub BindDataSource() Implements BasesParaCompatibilidad.Queriable.dataGridViewFill
       'dim dt as datatable = DataTableFill(Me.spRecipientesSalidas.DataGridViewStoredProcedure)

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
