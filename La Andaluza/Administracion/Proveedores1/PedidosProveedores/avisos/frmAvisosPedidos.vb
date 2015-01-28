Imports BasesParaCompatibilidad.DataGridViewExtension

Namespace Proveedores
    Public Class frmAvisosPedidos
        Inherits BasesParaCompatibilidad.gridsimpleform
        Implements BasesParaCompatibilidad.Queriable

        Private dboAvisosPedidos As DBO_AvisosPedidos
        Public Sub New(Optional ByVal MaestroID As Integer = 0)
            MyBase.New(New spAvisosPedidos(), MaestroID.ToString)
            InitializeComponent()
            dboAvisosPedidos = New DBO_AvisosPedidos            
            MyBase.newRegForm = CType(New frmEntAvisosPedidos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, CType(sp, spAvisosPedidos)), BasesParaCompatibilidad.DetailedSimpleForm)
        End Sub

        Private Sub Insert_Before() Handles MyBase.BeforeInsert
            dboAvisosPedidos = New DBO_AvisosPedidos
            newRegForm.SetDataBussinesObject(CType(Me.dboAvisosPedidos, BasesParaCompatibilidad.DataBussines))
        End Sub

        Private Sub modify_Before() Handles MyBase.BeforeModify
            dboAvisosPedidos = CType(sp, spAvisosPedidos).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), New BasesParaCompatibilidad.DataBase)
            If Not dboAvisosPedidos Is Nothing Then
                newRegForm.SetDataBussinesObject(CType(Me.dboAvisosPedidos, BasesParaCompatibilidad.DataBussines))
            Else
                MyBase.EventHandeld = True
                MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End Sub

        Protected Overrides Sub BindDataSource() Implements BasesParaCompatibilidad.Queriable.dataGridViewFill
            'dim dt as datatable = DataTableFill(Me.spAvisosPedidos.DataGridViewStoredProcedure)

            If Not dataSource Is Nothing Then
                GeneralBindingSource.DataSource = dataSource
                With dgvGeneral
                    .DataSource = GeneralBindingSource
                    .Columns("Id").Visible = False
                    .FormatoColumna("ProveedorID", "Proveedor", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                    .FormatoColumna("ArticuloID", "Articulo", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                    .FormatoColumna("Cabecera", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                    .FormatoColumna("Detalle", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                    .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, True)
                End With
            End If

        End Sub

    End Class
End Namespace