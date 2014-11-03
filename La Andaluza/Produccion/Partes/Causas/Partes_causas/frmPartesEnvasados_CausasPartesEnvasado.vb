Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmPartesEnvasados_CausasPartesEnvasado
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboPartesEnvasados_CausasPartesEnvasado As DBO_PartesEnvasados_CausasPartesEnvasado

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spPartesEnvasados_CausasPartesEnvasado, MaestroID)
        InitializeComponent()

        dboPartesEnvasados_CausasPartesEnvasado = New DBO_PartesEnvasados_CausasPartesEnvasado


        MyBase.newRegForm = New frmEntPartesEnvasados_CausasPartesEnvasado(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboPartesEnvasados_CausasPartesEnvasado = New DBO_PartesEnvasados_CausasPartesEnvasado
        If m_MaestroID <> 0 Then
            dboPartesEnvasados_CausasPartesEnvasado.Id_ParteEnvasado = m_MaestroID
        End If
        newRegForm.SetDataBussinesObject(Me.dboPartesEnvasados_CausasPartesEnvasado)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboPartesEnvasados_CausasPartesEnvasado = CType(sp, spPartesEnvasados_CausasPartesEnvasado).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboPartesEnvasados_CausasPartesEnvasado Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboPartesEnvasados_CausasPartesEnvasado)
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
                .FormatoColumna("Inicio", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Fin", BasesParaCompatibilidad.TiposColumna.Hora, True)
                .FormatoColumna("Causa", BasesParaCompatibilidad.TiposColumna.Hora, True)
            End With
        End If
    End Sub

    Public Function grabar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Return True
    End Function

    Public ReadOnly Property Count As Integer
        Get
            Return Me.dgvGeneral.RowCount
        End Get
    End Property

End Class
