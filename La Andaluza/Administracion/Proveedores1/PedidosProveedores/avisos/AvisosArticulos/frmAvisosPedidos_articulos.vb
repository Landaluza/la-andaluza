Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmAvisosPedidos_articulos
   Inherits BasesParaCompatibilidad.gridsimpleform
   Implements BasesParaCompatibilidad.Queriable

    Private dboAvisosPedidos_articulos As Proveedores.DBO_AvisosPedidos_articulos
       
   Public Sub New(Optional ByVal MaestroID As Integer = 0)
       MyBase.new(new spAvisosPedidos_articulos(),MaestroID.ToString)
       InitializeComponent()
        dboAvisosPedidos_articulos = New Proveedores.DBO_AvisosPedidos_articulos
       MyBase.newRegForm = ctype(New frmEntAvisosPedidos_articulos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(sp, spAvisosPedidos_articulos)), BasesParaCompatibilidad.DetailedSimpleForm)
   End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboAvisosPedidos_articulos = New Proveedores.DBO_AvisosPedidos_articulos
        dboAvisosPedidos_articulos.Id_articulo = m_MaestroID
        MyBase.newRegForm = CType(New frmEntAvisosPedidos_articulos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spAvisosPedidos_articulos, dboAvisosPedidos_articulos), BasesParaCompatibilidad.DetailedSimpleForm)
        AddHandler newRegForm.afterSave, AddressOf dgvFill
        ' newRegForm.SetDataBussinesObject(ctype(Me.dboAvisosPedidos_articulos, BasesParaCompatibilidad.databussines))
    End Sub

   Private Sub modify_Before() Handles MyBase.BeforeModify
        dboAvisosPedidos_articulos = CType(sp, spAvisosPedidos_articulos).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), New BasesParaCompatibilidad.DataBase)
       If Not dboAvisosPedidos_articulos Is Nothing Then
           MyBase.newRegForm = ctype(New frmEntAvisosPedidos_articulos(BasesParaCompatibilidad.GridSimpleForm.ACCION_MODIFICAR), BasesParaCompatibilidad.DetailedSimpleForm)
            newRegForm.SetDataBussinesObject(CType(Me.dboAvisosPedidos_articulos, BasesParaCompatibilidad.DataBussines))
            AddHandler newRegForm.afterSave, AddressOf dgvFill
       Else
           MyBase.EventHandeld = True
           Messagebox.show("No se pudo recuperar los datos",  "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
       End If
   End Sub

   Protected Overrides Sub BindDataSource() Implements BasesParaCompatibilidad.Queriable.dataGridViewFill
       'dim dt as datatable = DataTableFill(Me.spAvisosPedidos_articulos.DataGridViewStoredProcedure)

       If not datasource Is Nothing Then
       GeneralBindingSource.DataSource = datasource
               With dgvGeneral
                   .DataSource = GeneralBindingSource
               .Columns("Id").Visible = False
                .FormatoColumna("Id_proveedor", "Proveedor", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                   .FormatoColumna("Cabecera", BasesParaCompatibilidad.TiposColumna.Izquierda, true)
                   .FormatoColumna("Detalle", BasesParaCompatibilidad.TiposColumna.Izquierda, true)
                   .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 80)
            End With
            Me.Focus()
       End If

   End Sub

End Class
