Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmTiposMateriales_Provedores
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private way As Boolean

    Private dboTiposMateriales_Provedores As DBO_TiposMateriales_Provedores

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spTiposMateriales_Provedores, MaestroID)
        InitializeComponent()

        dboTiposMateriales_Provedores = New DBO_TiposMateriales_Provedores


        MyBase.newRegForm = New frmEntTiposMateriales_Provedores(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
        Me.butModificar.Enabled = False
        Me.butModificar.Visible = False
        Me.way = False
        Me.dgvGeneral.ColumnHeadersVisible = False
    End Sub

    Public Sub New(MaestroID As Integer, ByVal stub As Boolean)
        MyBase.New(New spTiposMateriales_Provedores(True), MaestroID)
        InitializeComponent()

        dboTiposMateriales_Provedores = New DBO_TiposMateriales_Provedores


        MyBase.newRegForm = New frmEntTiposMateriales_Provedores(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
        Me.butModificar.Enabled = False
        Me.butModificar.Visible = False
        Me.way = True
        Me.dgvGeneral.ColumnHeadersVisible = False
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboTiposMateriales_Provedores = New DBO_TiposMateriales_Provedores

        If Me.way Then
            If m_MaestroID <> 0 Then
                dboTiposMateriales_Provedores.id_proveedor = m_MaestroID
            End If
        Else
            If m_MaestroID <> 0 Then
                dboTiposMateriales_Provedores.id_TiposMateriales = m_MaestroID
            End If
        End If

        newRegForm.SetDataBussinesObject(Me.dboTiposMateriales_Provedores)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboTiposMateriales_Provedores = CType(sp, spTiposMateriales_Provedores).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboTiposMateriales_Provedores Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboTiposMateriales_Provedores)
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
            End With
        End If
    End Sub

End Class
