Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmProveedores_Articulos
    Inherits BasesParaCompatibilidad.gridsimpleform



    Private dboProveedores_Articulos As DBO_Proveedores_Articulos

    Public Sub New(Optional ByVal MaestroID As Integer = 0, Optional ByVal MaestroID2 As Integer = Nothing)
        MyBase.New(New spProveedores_Articulos(If(MaestroID = 0, True, False)), _
                                               If(MaestroID = 0, MaestroID2, MaestroID))
        InitializeComponent()

        dboProveedores_Articulos = New DBO_Proveedores_Articulos


        dboProveedores_Articulos.ProveedorID = MaestroID
        dboProveedores_Articulos.ArticuloID = MaestroID2

        'sp.DataGridViewStoredProcedure= sp.DataGridViewStoredProcedureForFilteredSelect & "'" & Me.m_MaestroID & "'"
        MyBase.newRegForm = New frmEntProveedores_Articulos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboProveedores_Articulos = New DBO_Proveedores_Articulos
        'if m_maestroid <> 0 Then dboProveedores_Articulos.ProveedorID = m_MaestroID
        newRegForm.SetDataBussinesObject(Me.dboProveedores_Articulos)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboProveedores_Articulos = CType(sp, spProveedores_Articulos).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboProveedores_Articulos Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboProveedores_Articulos)
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub cargar_datos()
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dtb.PrepararConsulta(Me.sp.DataGridViewStoredProcedure)
        dataSource = dtb.Consultar()
    End Sub
    Protected Overrides Sub BindDataSource()




        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .Columns("Nombre").Visible = False
                .Columns("PeriodosServicio").Visible = False
                .FormatoColumna("Articulo", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("ProveedorPrincipal", "Principal", BasesParaCompatibilidad.TiposColumna.Centro, 60)
                .FormatoColumna("ProveedorUnico", "Unico", BasesParaCompatibilidad.TiposColumna.Centro)
                .FormatoColumna("CantidadPedidoHabitual", "Habitual", BasesParaCompatibilidad.TiposColumna.Miles, 60)
                .FormatoColumna("CantidadPedidoMinima", "Minima", BasesParaCompatibilidad.TiposColumna.Miles, 60)
                .FormatoColumna("PlazoEntrega", "Plazo", BasesParaCompatibilidad.TiposColumna.Miles, 50)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If
    End Sub

End Class
