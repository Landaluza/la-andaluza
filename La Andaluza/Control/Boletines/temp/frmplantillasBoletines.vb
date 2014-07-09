Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmplantillasBoletines
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboplantillasBoletines As DBO_plantillasBoletines

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spplantillasBoletines, MaestroID)
        InitializeComponent()

        dboplantillasBoletines = New DBO_plantillasBoletines


        MyBase.newRegForm = New frmEntplantillasBoletines(ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        MyBase.newRegForm = New frmEntplantillasBoletines(ACCION_INSERTAR, sp)
        If m_MaestroID <> 0 Then dboplantillasBoletines.nombre = m_MaestroID
        newRegForm.SetDataBussinesObject(Me.dboplantillasBoletines)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify


        If Not dboplantillasBoletines Is Nothing Then
            dboplantillasBoletines = CType(sp, spplantillasBoletines).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
            MyBase.newRegForm = New frmEntplantillasBoletines(ACCION_MODIFICAR, sp, Me.dboplantillasBoletines)
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Sub refrescar() Handles MyBase.AfterInsert, MyBase.AfterModify, MyBase.AfterDelete
        dgvFill()
    End Sub

    Protected Overrides Sub BindDataSource()
        ' DataTableFill(Me.sp.DataGridViewStoredProcedure)

        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("id").Visible = False
                .FormatoColumna("nombre", "Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("pie1", "Pie", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("pie2", "2º pie", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("empresa", "Empresa", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Cabecera", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Parametros", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
