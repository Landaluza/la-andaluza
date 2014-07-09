Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmProveedoresMailsPedidos
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboProveedoresMailsPedidos As DBO_ProveedoresMailsPedidos

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spProveedoresMailsPedidos, MaestroID)
        InitializeComponent()

        dboProveedoresMailsPedidos = New DBO_ProveedoresMailsPedidos


        MyBase.newRegForm = CType(New frmEntProveedoresMailsPedidos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub



    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        MyBase.newRegForm = CType(New frmEntProveedoresMailsPedidos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
        AddHandler newRegForm.afterSave, AddressOf dgvFill
        dboProveedoresMailsPedidos.Proveedores_ProveedorID = m_MaestroID
        newRegForm.SetDataBussinesObject(CType(Me.dboProveedoresMailsPedidos, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboProveedoresMailsPedidos = CType(sp, spProveedoresMailsPedidos).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer))
        If Not dboProveedoresMailsPedidos Is Nothing Then
            MyBase.newRegForm = CType(New frmEntProveedoresMailsPedidos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
            AddHandler newRegForm.afterSave, AddressOf dgvFill
            newRegForm.SetDataBussinesObject(CType(Me.dboProveedoresMailsPedidos, BasesParaCompatibilidad.DataBussines))
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource()

        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Mail", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Cargo", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
            End With
        End If

    End Sub

End Class
