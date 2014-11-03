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

        Dim ts As New ToolStripButton("Vigencia")
        ts.Image = My.Resources.checkbox_2
        ts.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        AddHandler ts.Click, AddressOf cambiarVigencia
        Me.bdnGeneral.Items.Add(ts)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(CType(Me.dboNoticias, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboNoticias = CType(sp, spNoticias).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
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

    Private Sub cambiarVigencia(sender As Object, e As EventArgs)
        Dim dtb As New BasesParaCompatibilidad.DataBase
        If CType(sp, spNoticias).CambiarVigencia(dgvGeneral.CurrentRow.Cells("Id").Value, dtb) Then
            dgvFill()
        End If
    End Sub
End Class
