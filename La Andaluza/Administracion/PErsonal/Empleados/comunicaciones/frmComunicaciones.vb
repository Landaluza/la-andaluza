Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmComunicaciones
    Inherits BasesParaCompatibilidad.gridsimpleform
    Implements BasesParaCompatibilidad.Queriable

    Private dboComunicaciones As DBO_Comunicaciones

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spComunicaciones, MaestroID)
        InitializeComponent()

        dboComunicaciones = New DBO_Comunicaciones


        MyBase.newRegForm = CType(New frmEntComunicaciones(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)


    End Sub



    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        EventHandeld = True
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboComunicaciones = CType(sp, spComunicaciones).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer))
        If Not dboComunicaciones Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboComunicaciones, BasesParaCompatibilidad.DataBussines))
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource() Implements BasesParaCompatibilidad.Queriable.dataGridViewFill

        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("MovilEmpresa", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("EmailEmpresa", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Extension", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoGeneral()
            End With

        End If

        Me.butNuevo.Visible = False
        Me.butEliminar.Visible = False
    End Sub


End Class
