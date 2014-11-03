Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmEnvasadosProductos
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboEnvasadosProductos As DBO_EnvasadosProductos


    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spEnvasadosProductos, MaestroID)
        InitializeComponent()

        dboEnvasadosProductos = New DBO_EnvasadosProductos


        MyBase.newRegForm = CType(New frmEntEnvasadosProductos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboEnvasadosProductos = New DBO_EnvasadosProductos
        MyBase.newRegForm = CType(New frmEntEnvasadosProductos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
        AddHandler newRegForm.afterSave, AddressOf dgvFill
        dboEnvasadosProductos.EnvasadoID = m_MaestroID
        newRegForm.SetDataBussinesObject(CType(Me.dboEnvasadosProductos, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboEnvasadosProductos = CType(sp, spEnvasadosProductos).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
        If Not dboEnvasadosProductos Is Nothing Then
            MyBase.newRegForm = CType(New frmEntEnvasadosProductos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
            AddHandler newRegForm.afterSave, AddressOf dgvFill
            newRegForm.SetDataBussinesObject(CType(Me.dboEnvasadosProductos, BasesParaCompatibilidad.DataBussines))
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
                .FormatoColumna("Producto", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("HoraInicio", BasesParaCompatibilidad.TiposColumna.Hora, 90)
                .FormatoColumna("HoraFinal", BasesParaCompatibilidad.TiposColumna.Hora, 90)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
            End With
        End If
    End Sub

    Sub deshabilitarAcciones()
        Me.butEliminar.Enabled = False
        Me.butModificar.Enabled = False
        Me.butNuevo.Enabled = False
        If Me.butExcel.Visible Then Me.butExcel.Enabled = False
        If Me.butWord.Visible Then Me.butWord.Enabled = False
        If Me.butVer.Visible Then Me.butVer.Enabled = False
        If Me.butImprimir.Visible Then Me.butImprimir.Enabled = False
    End Sub

    Sub habilitarAcciones()
        Me.butEliminar.Enabled = True
        Me.butModificar.Enabled = True
        Me.butNuevo.Enabled = True
        If Me.butExcel.Visible Then Me.butExcel.Enabled = True
        If Me.butWord.Visible Then Me.butWord.Enabled = True
        If Me.butVer.Visible Then Me.butVer.Enabled = True
        If Me.butImprimir.Visible Then Me.butImprimir.Enabled = True
    End Sub

End Class
