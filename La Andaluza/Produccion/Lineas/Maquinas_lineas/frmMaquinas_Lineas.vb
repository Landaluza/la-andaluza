Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmMaquinas_Lineas
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboMaquinas_Lineas As DBO_Maquinas_Lineas

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spMaquinas_Lineas, MaestroID)
        InitializeComponent()

        dboMaquinas_Lineas = New DBO_Maquinas_Lineas


        MyBase.newRegForm = New frmEntMaquinas_Lineas(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub



    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboMaquinas_Lineas = New DBO_Maquinas_Lineas
        If m_MaestroID <> 0 Then dboMaquinas_Lineas.LineaID = m_MaestroID
        newRegForm.SetDataBussinesObject(Me.dboMaquinas_Lineas)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboMaquinas_Lineas = CType(sp, spMaquinas_Lineas).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dboMaquinas_Lineas Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboMaquinas_Lineas)
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
                .FormatoColumna("Maquina", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .Columns("Id").Visible = False
                .Columns("Linea").Visible = False

            End With
        End If



    End Sub

End Class
