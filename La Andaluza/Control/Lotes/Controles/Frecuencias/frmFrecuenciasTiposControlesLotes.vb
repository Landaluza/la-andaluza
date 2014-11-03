Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmFrecuenciasTiposControlesLotes
    Inherits BasesParaCompatibilidad.gridsimpleform

    Private dboFrecuenciasTiposControlesLotes As DBO_FrecuenciasTiposControlesLotes

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spFrecuenciasTiposControlesLotes, MaestroID)
        InitializeComponent()

        dboFrecuenciasTiposControlesLotes = New DBO_FrecuenciasTiposControlesLotes

        MyBase.newRegForm = CType(New frmEntFrecuenciasTiposControlesLotes(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboFrecuenciasTiposControlesLotes = New DBO_FrecuenciasTiposControlesLotes
        newRegForm.SetDataBussinesObject(CType(Me.dboFrecuenciasTiposControlesLotes, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboFrecuenciasTiposControlesLotes = CType(sp, spFrecuenciasTiposControlesLotes).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
        If Not dboFrecuenciasTiposControlesLotes Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboFrecuenciasTiposControlesLotes, BasesParaCompatibilidad.DataBussines))
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
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If

    End Sub

End Class
