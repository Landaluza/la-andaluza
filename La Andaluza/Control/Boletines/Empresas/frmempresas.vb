Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmempresas
    Inherits BasesParaCompatibilidad.gridsimpleform



    Private dboempresas As DBO_empresas

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spempresas, MaestroID)
        InitializeComponent()

        dboempresas = New DBO_empresas


        MyBase.newRegForm = New frmEntempresas(ACCION_INSERTAR, sp)
    End Sub



    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboempresas = New DBO_empresas
        If m_MaestroID <> "0" And m_MaestroID <> "" Then dboempresas.nombre = m_MaestroID
        newRegForm.SetDataBussinesObject(Me.dboempresas)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboempresas = CType(sp, spempresas).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboempresas Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboempresas)
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
                .Columns("id").Visible = False
                .FormatoColumna("nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("ruta_logo", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("fax", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("tlf", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("email", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("web", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("direccion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If

    End Sub

End Class
