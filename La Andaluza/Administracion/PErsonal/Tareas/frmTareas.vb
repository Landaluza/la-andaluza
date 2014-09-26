Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmTareas
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private m_VerID As Boolean = True
    Private frmEnt As frmEntTareas
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spTareas, MaestroID)
        InitializeComponent()
        spSelectDgv = "TareasSelectDgvByID '" & MaestroID & "'"

        m_VerID = False
    End Sub

    Public Sub New()
        MyBase.New(New spTareas, 0)
        InitializeComponent()
        spSelectDgv = "TareasSelectDgv"
    End Sub

    Private Sub frmTareas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        butExcel.Visible = True

    End Sub

    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", _
                          "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then CType(sp, spTareas).TareasDelete(dgvGeneral.CurrentRow.Cells("TareaID").Value)
        dgvFill()
    End Sub



    Overrides Sub Action(ByVal TipoAction As String)
        Dim m_Tarea As New DBO_Tareas
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then
            If m_MaestroID <> 0 Then m_Tarea.Descripcion = m_MaestroID.ToString
        Else
            m_Tarea = CType(sp, spTareas).Select_Record(dgvGeneral.CurrentRow.Cells("TareaID").Value)
        End If

        frmEnt = New frmEntTareas(m_Tarea, m_Pos, m_VerID)
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


            With dgvGeneral
                .DataSource = GeneralBindingSource

                .Columns("TareaID").Visible = False
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, 200)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, 200)

            End With
        End If
    End Sub





End Class
