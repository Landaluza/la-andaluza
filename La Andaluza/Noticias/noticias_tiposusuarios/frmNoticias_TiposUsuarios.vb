Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmNoticias_TiposUsuarios
    Inherits BasesParaCompatibilidad.gridsimpleform

    Private dboNoticias_TiposUsuarios As DBO_Noticias_TiposUsuarios

    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spNoticias_TiposUsuarios, MaestroID)
        InitializeComponent()

        dboNoticias_TiposUsuarios = New DBO_Noticias_TiposUsuarios

        ' sp.DataGridViewStoredProcedure= sp.DataGridViewStoredProcedureForFilteredSelect & "'" & Me.m_MaestroID & "'"
        MyBase.newRegForm = New frmEntNoticias_TiposUsuarios(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboNoticias_TiposUsuarios = New DBO_Noticias_TiposUsuarios
        If m_MaestroID <> "" Then dboNoticias_TiposUsuarios.Id_noticia = m_MaestroID
        newRegForm.SetDataBussinesObject(CType(Me.dboNoticias_TiposUsuarios, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboNoticias_TiposUsuarios = CType(sp, spNoticias_TiposUsuarios).Select_Record(Convert.ToInt32(dgvGeneral.CurrentRow.Cells("Id").Value), dtb)
        If Not dboNoticias_TiposUsuarios Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboNoticias_TiposUsuarios, BasesParaCompatibilidad.DataBussines))
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource()

        If Not dataSource Is Nothing Then
            'GeneralBindingSource.DataSource = datasource
            With dgvGeneral
                .DataSource = dataSource
                .Columns("Id").Visible = False
                .Columns("Titulo").Visible = False
                .FormatoColumna("Usuario", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
            End With
        End If
    End Sub
End Class
