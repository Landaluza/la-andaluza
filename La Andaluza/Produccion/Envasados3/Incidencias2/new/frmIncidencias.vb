Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmIncidencias
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboIncidencias As DBO_Incidencias

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spIncidencias, MaestroID)
        InitializeComponent()

        dboIncidencias = New DBO_Incidencias


        If Config.UserType = 4 Then
            MyBase.newRegForm = New frmEntIncidencias_SU(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
        Else
            MyBase.newRegForm = New frmEntIncidencias(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
        End If
        AddHandler newRegForm.afterSave, AddressOf dgvFill
    End Sub

    Private Sub frmIncidencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Config.UserType <> 4 Then
            Me.butNuevo.Visible = False
        End If
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        Me.dboIncidencias = New DBO_Incidencias
        If m_MaestroID <> 0 Then dboIncidencias.FormatoEnvasadoID = m_MaestroID
        newRegForm.SetDataBussinesObject(Me.dboIncidencias)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboIncidencias = CType(sp, spIncidencias).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dboIncidencias Is Nothing Then
            If Config.UserType <> 4 Then
                Dim spTipos As New spTiposIncidencias
                Dim c As Object = newRegForm
                c.ClaseIncidencia = spTipos.Select_Record(dboIncidencias.TipoIncidenciaID).CategoriaIncidenciaID
            End If
            newRegForm.SetDataBussinesObject(Me.dboIncidencias)
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
                .FormatoColumna("HoraInicio", "Inicio", BasesParaCompatibilidad.TiposColumna.Hora, 85, 1)
                .FormatoColumna("HoraFin", "Fin", BasesParaCompatibilidad.TiposColumna.Hora, 85, 2)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Observaciones, True, 5)
                .FormatoColumna("Tipo", BasesParaCompatibilidad.TiposColumna.Descripcion, 200, 3)
                .FormatoColumna("Categoria", BasesParaCompatibilidad.TiposColumna.Descripcion, 150, 4)

            End With
        End If



    End Sub

    Public Sub InsertarInc(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As frmEntIncidencias = MyBase.newRegForm

        Me.dboIncidencias = New DBO_Incidencias
        Dim c As Object = newRegForm
        c.ClaseIncidencia = sender.tag
        If m_MaestroID <> 0 Then dboIncidencias.FormatoEnvasadoID = m_MaestroID
        newRegForm.SetDataBussinesObject(Me.dboIncidencias)
        Me.EventHandeld = True
        Action(ACCION_INSERTAR)
        ' GeneralBindingSource.MoveLast()


    End Sub

    Sub deshabilitarAcciones()
        Me.butEliminar.Enabled = False
        Me.butModificar.Enabled = False
        Me.butNuevo.Enabled = False
        If Me.butExcel.Visible Then Me.butExcel.Enabled = False
        If Me.butWord.Visible Then Me.butWord.Enabled = False
        If Me.butVer.Visible Then Me.butVer.Enabled = False
        If Me.butImprimir.Visible Then Me.butImprimir.Enabled = False
    End Sub

End Class
