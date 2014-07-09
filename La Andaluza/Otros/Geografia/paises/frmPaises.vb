Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmPaises
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboPaises As DBO_Paises

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spPaises, MaestroID)
        InitializeComponent()

        dboPaises = New DBO_Paises


        MyBase.newRegForm = New frmEntPaises(ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        If m_MaestroID <> 0 Then dboPaises.Pais = m_MaestroID
        newRegForm.SetDataBussinesObject(Me.dboPaises)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboPaises = CType(sp, spPaises).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dboPaises Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboPaises)
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
                .Columns("PaisID").Visible = False
                .FormatoColumna("Pais", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If

    End Sub

End Class
