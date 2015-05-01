Imports BasesParaCompatibilidad.DataGridViewExtension


Public Class frmReuniones
    Inherits BasesParaCompatibilidad.GridSimpleForm


    Private dboReuniones As DBO_Reuniones
    Private m_ruta As String

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spReuniones, MaestroID)
        InitializeComponent()

        dboReuniones = New DBO_Reuniones


        MyBase.newRegForm = New frmEntReuniones(ACCION_INSERTAR, sp)
        AddHandler dgvGeneral.CellClick, AddressOf dgvGeneral_CellClick2
    End Sub

    Public Sub New(ByVal MaestroID As Integer, ByVal ruta As String)
        Me.New(MaestroID)
        Me.m_ruta = ruta
        AddHandler dgvGeneral.CellClick, AddressOf dgvGeneral_CellClick2
    End Sub



    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboReuniones = New DBO_Reuniones
        If m_MaestroID <> "" AndAlso m_MaestroID <> "0" Then dboReuniones.Id_proveedor = m_MaestroID
        Me.dboReuniones.RutaDefecto = m_ruta
        newRegForm.SetDataBussinesObject(Me.dboReuniones)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboReuniones = CType(sp, spReuniones).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)

        If Not dboReuniones Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboReuniones)
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource()


        GeneralBindingSource.DataSource = dataSource ' DataTableFill(Me.sp.DataGridViewStoredProcedure)

        If Not GeneralBindingSource.DataSource Is Nothing Then
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .Columns("RutaDocumento").Visible = False

                If Me.m_MaestroID = Nothing Then

                    .FormatoColumna("Nombre1", "Proveedor", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                    .FormatoColumna("nombre", "TipoReunion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                    .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                    .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                Else
                    .Columns("nombre").Visible = False
                    .FormatoColumna("Nombre1", "TipoReunion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                    .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                    .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                End If

            End With
        End If

        If dgvGeneral.RowCount > 0 Then
            If Not Me.dgvGeneral.Columns.Contains("+") Then
                Dim buttonColumn As New DataGridViewImageColumn()
                buttonColumn.HeaderText = ""
                buttonColumn.Name = "+"
                buttonColumn.Image = My.Resources.document_16
                buttonColumn.Width = 30
                dgvGeneral.Columns.Add(buttonColumn)
            End If
        End If



    End Sub

    Private Sub dgvGeneral_CellClick2(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        If Not e.RowIndex < 0 Then
            If e.ColumnIndex = dgvGeneral.Columns("+").Index Then


                If Not IsDBNull(Me.dgvGeneral.CurrentRow.Cells("RutaDocumento").Value) Then
                    Dim f As New BasesParaCompatibilidad.File(Me.dgvGeneral.CurrentRow.Cells("RutaDocumento").Value)
                    f.open()
                End If
            End If
        End If
    End Sub


End Class
