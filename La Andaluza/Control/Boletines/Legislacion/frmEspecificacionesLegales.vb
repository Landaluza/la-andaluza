Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmEspecificacionesLegales
    Inherits BasesParaCompatibilidad.gridsimpleform
    Implements BasesParaCompatibilidad.Queriable


    Private dbolegislacionProductos As DBO_EspecificacionLegal

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spEspecificacionLegal, MaestroID)
        InitializeComponent()

        dbolegislacionProductos = New DBO_EspecificacionLegal


        MyBase.newRegForm = New frmEntEspecificacionesLegales(ACCION_INSERTAR, sp)
        AddHandler newRegForm.afterSave, AddressOf dgvFill
    End Sub

    Private Sub frmlegislacionProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        butExcel.Visible = True
        ''Permisos()


    End Sub


    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dbolegislacionProductos = New DBO_EspecificacionLegal
        If m_MaestroID <> "0" Or m_MaestroID = "" Then dbolegislacionProductos.Nombre = m_MaestroID
        newRegForm.SetDataBussinesObject(CType(Me.dbolegislacionProductos, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dbolegislacionProductos = CType(sp, spEspecificacionLegal).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dbolegislacionProductos Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dbolegislacionProductos, BasesParaCompatibilidad.DataBussines))
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource() Implements BasesParaCompatibilidad.Queriable.dataGridViewFill
        GeneralBindingSource.DataSource = dataSource 'DataTableFill(Me.splegislacionProductos.DataGridViewStoredProcedure)

        If Not GeneralBindingSource.DataSource Is Nothing Then
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
