Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmAguaPotablePuntosMuestreos
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboAguaPotablePuntosMuestreos As DBO_AguaPotablePuntosMuestreos

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spAguaPotablePuntosMuestreos, MaestroID)
        InitializeComponent()

        dboAguaPotablePuntosMuestreos = New DBO_AguaPotablePuntosMuestreos


        MyBase.newRegForm = New frmEntAguaPotablePuntosMuestreos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboAguaPotablePuntosMuestreos)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboAguaPotablePuntosMuestreos = CType(sp, spAguaPotablePuntosMuestreos).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboAguaPotablePuntosMuestreos Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboAguaPotablePuntosMuestreos)
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
                .FormatoColumna("Id", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Referencia", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
