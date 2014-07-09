Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmNoticias
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboNoticias As DBO_Noticias

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spNoticias, MaestroID)
        InitializeComponent()

        dboNoticias = New DBO_Noticias


        Dim f As New frmEntNoticias(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
        AddHandler f.afterSave, AddressOf dgvFill
        MyBase.newRegForm = f
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(CType(Me.dboNoticias, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboNoticias = CType(sp, spNoticias).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dboNoticias Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboNoticias, BasesParaCompatibilidad.DataBussines))
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
                .FormatoColumna("Titulo", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Texto", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
            End With
        End If
    End Sub
End Class
