Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmArticulos_AlmacenNoConforme
    Inherits BasesParaCompatibilidad.gridsimpleform



    Private dboArticulos_AlmacenNoConforme As DBO_Articulos_AlmacenNoConforme

    Public Event Index_change(ByVal ID As Integer)

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spArticulos_AlmacenNoConforme, MaestroID)
        InitializeComponent()

        dboArticulos_AlmacenNoConforme = New DBO_Articulos_AlmacenNoConforme


        MyBase.newRegForm = New frmEntArticulos_AlmacenNoConforme(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
        AddHandler dgvGeneral.SelectionChanged, AddressOf dgvGeneral_SelectionChanged
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboArticulos_AlmacenNoConforme = New DBO_Articulos_AlmacenNoConforme
        If m_MaestroID <> 0 Then dboArticulos_AlmacenNoConforme.Id_Controlincidencia = m_MaestroID
        newRegForm.SetDataBussinesObject(Me.dboArticulos_AlmacenNoConforme)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboArticulos_AlmacenNoConforme = CType(sp, spArticulos_AlmacenNoConforme).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboArticulos_AlmacenNoConforme Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboArticulos_AlmacenNoConforme)
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
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("FechaEntrada", "Entrada", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("FechaSalida", "Salida", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("Accion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Cantidad", BasesParaCompatibilidad.TiposColumna.Miles, 50)
                .FormatoColumna("Medida", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub


    Private Sub dgvGeneral_SelectionChanged(sender As System.Object, e As System.EventArgs)
        If Not Me.dgvGeneral.CurrentRow Is Nothing Then
            RaiseEvent Index_change(Me.dgvGeneral.CurrentRow.Cells("Id").Value)
        End If
    End Sub

    Private Sub despues_de_accion() Handles MyBase.AfterDelete, MyBase.AfterInsert
        If Not Me.dgvGeneral.CurrentRow Is Nothing Then
            RaiseEvent Index_change(Me.dgvGeneral.CurrentRow.Cells("Id").Value)
        End If
    End Sub
End Class
