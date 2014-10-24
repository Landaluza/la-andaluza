Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmCostesPorConcepto
   Inherits BasesParaCompatibilidad.gridsimpleform
   Implements BasesParaCompatibilidad.Queriable

   private dboCostesPorConcepto As DBO_CostesPorConcepto
       
   Public Sub New(Optional ByVal MaestroID As Integer = 0)
       MyBase.new(new spCostesPorConcepto(),MaestroID.ToString)
       InitializeComponent()
       dboCostesPorConcepto = new DBO_CostesPorConcepto
       MyBase.newRegForm = ctype(New frmEntCostesPorConcepto(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(sp, spCostesPorConcepto)), BasesParaCompatibilidad.DetailedSimpleForm)
   End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboCostesPorConcepto = New DBO_CostesPorConcepto
        MyBase.newRegForm = CType(New frmEntCostesPorConcepto(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR), BasesParaCompatibilidad.DetailedSimpleForm)
        dboCostesPorConcepto.Id_ConceptosGastosIncidencias = m_MaestroID
        newRegForm.SetDataBussinesObject(CType(Me.dboCostesPorConcepto, BasesParaCompatibilidad.DataBussines))
    End Sub

   Private Sub modify_Before() Handles MyBase.BeforeModify
        dboCostesPorConcepto = CType(sp, spCostesPorConcepto).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
       If Not dboCostesPorConcepto Is Nothing Then
           MyBase.newRegForm = ctype(New frmEntCostesPorConcepto(BasesParaCompatibilidad.GridSimpleForm.ACCION_MODIFICAR), BasesParaCompatibilidad.DetailedSimpleForm)
           newRegForm.SetDataBussinesObject(ctype(Me.dboCostesPorConcepto,BasesParaCompatibilidad.databussines))
       Else
           MyBase.EventHandeld = True
           Messagebox.show("No se pudo recuperar los datos",  "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
       End If
   End Sub

   Protected Overrides Sub BindDataSource() Implements BasesParaCompatibilidad.Queriable.dataGridViewFill
       'dim dt as datatable = DataTableFill(Me.spCostesPorConcepto.DataGridViewStoredProcedure)

       If not datasource Is Nothing Then
       GeneralBindingSource.DataSource = datasource
               With dgvGeneral
                   .DataSource = GeneralBindingSource
               .Columns("Id").Visible = False
               .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, true)
                   .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 80)
               End With
       End If

   End Sub

End Class
