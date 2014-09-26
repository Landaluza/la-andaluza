Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmPartesTrabajosDiariosMaestros
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private frmEnt As frmEntPartesTrabajosDiariosMaestros
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spPartesTrabajosDiariosMaestros, MaestroID)
        InitializeComponent()
        spSelectDgv = "PartesTrabajosDiariosMaestrosSelectDgvByEmpleadoID '" & MaestroID & "'"

    End Sub

    Public Sub New()
        MyBase.New(New spPartesTrabajosDiariosMaestros, 0)
        InitializeComponent()
        spSelectDgv = "PartesTrabajosDiariosMaestrosSelectDgv"
    End Sub

    Private Sub frmPartesTrabajosDiariosMaestros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        butExcel.Visible = False
        butWord.Visible = False
    End Sub

    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", _
                            "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If CType(sp, spPartesTrabajosDiariosMaestros).PartesTrabajosDiariosMaestrosDelete(dgvGeneral.CurrentRow.Cells("ParteTrabajoDiarioMaestroID").Value) Then
                dgvFill()
            End If
        End If
    End Sub

    Overrides Sub Action(ByVal TipoAction As String)
        Dim m_DBO_ParteTrabajoDiarioMaestro As New DBO_PartesTrabajosDiariosMaestros

        If TipoAction = ACCION_INSERTAR Then
            If m_MaestroID <> 0 Then m_DBO_ParteTrabajoDiarioMaestro.EmpleadoID = m_MaestroID
        Else
            m_DBO_ParteTrabajoDiarioMaestro = CType(sp, spPartesTrabajosDiariosMaestros).Select_Record(dgvGeneral.CurrentRow.Cells("ParteTrabajoDiarioMaestroID").Value)
        End If

        frmEnt = New frmEntPartesTrabajosDiariosMaestros(m_DBO_ParteTrabajoDiarioMaestro)
        frmEnt.Text = String.Format("{0} {1}", TipoAction, Me.Text)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)


        dgvFill()
    End Sub

    Protected Overrides Sub cargar_datos()
        dataSource = dtb.Consultar(spSelectDgv, True)
    End Sub

    Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource

            If dgvGeneral.RowCount > 0 Then
                frmEnt.OcultarBotonGrabar(True)
            Else
                frmEnt.OcultarBotonGrabar(False)
            End If


            With dgvGeneral
                .DataSource = GeneralBindingSource

                .Columns("ParteTrabajoDiarioMaestroID").Visible = False
                .FormatoColumna("Empleado", BasesParaCompatibilidad.TiposColumna.Izquierda, 190)
                .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With

        End If
    End Sub




End Class
