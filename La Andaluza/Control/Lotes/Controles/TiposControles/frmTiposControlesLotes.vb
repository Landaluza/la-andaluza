Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmTiposControlesLotes
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboTiposControlesLotes As DBO_TiposControlesLotes

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spTiposControlesLotes, MaestroID)
        InitializeComponent()

        dboTiposControlesLotes = New DBO_TiposControlesLotes


        MyBase.newRegForm = CType(New frmEntTiposControlesLotes(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub


    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboTiposControlesLotes = New DBO_TiposControlesLotes
        newRegForm.SetDataBussinesObject(CType(Me.dboTiposControlesLotes, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboTiposControlesLotes = CType(sp, spTiposControlesLotes).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
        If Not dboTiposControlesLotes Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboTiposControlesLotes, BasesParaCompatibilidad.DataBussines))
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
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("RutaControles", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If

    End Sub

End Class
