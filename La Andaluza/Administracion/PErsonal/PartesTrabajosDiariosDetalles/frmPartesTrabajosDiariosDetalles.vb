Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmPartesTrabajosDiariosDetalles
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private m_VerID As Boolean = True
    Private m_ParteTrabajoDiarioDetalle As DBO_PartesTrabajosDiariosDetalles
    Private frmEnt As frmEntPartesTrabajosDiariosDetalles
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spPartesTrabajosDiariosDetalles, MaestroID)
        InitializeComponent()
        spSelectDgv = "PartesTrabajosDiariosDetallesSelectDgvByParteTrabajoDiarioMaestroID '" & MaestroID & "'"

        m_VerID = False
    End Sub

    Public Sub New()
        MyBase.New(New spPartesTrabajosDiariosDetalles, 0)
        InitializeComponent()
        spSelectDgv = "PartesTrabajosDiariosDetallesSelectDgv"
    End Sub

    Private Sub frmPartesTrabajosDiariosDetalles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        butExcel.Visible = True
    End Sub

    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", _
                  " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If CType(sp, spPartesTrabajosDiariosDetalles).PartesTrabajosDiariosDetallesDelete(dgvGeneral.CurrentRow.Cells("ParteTrabajoDiarioDetalleID").Value) Then
                dgvFill()
            End If
        End If
    End Sub



    Overrides Sub Action(ByVal TipoAction As String)
        m_ParteTrabajoDiarioDetalle = New DBO_PartesTrabajosDiariosDetalles
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then
            If m_MaestroID <> 0 Then m_ParteTrabajoDiarioDetalle.ParteTrabajoDiarioMaestroID = m_MaestroID
        Else
            m_ParteTrabajoDiarioDetalle = CType(sp, spPartesTrabajosDiariosDetalles).Select_Record(dgvGeneral.CurrentRow.Cells("ParteTrabajoDiarioDetalleID").Value)
        End If

        frmEnt = New frmEntPartesTrabajosDiariosDetalles(m_ParteTrabajoDiarioDetalle, m_Pos, m_VerID)
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

                .Columns("ParteTrabajoDiarioDetalleID").Visible = False
                .FormatoColumna("Inicio", BasesParaCompatibilidad.TiposColumna.Hora, 65)
                .FormatoColumna("Final", BasesParaCompatibilidad.TiposColumna.Hora, 65)
                .FormatoColumna("Tarea", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
            End With
        End If
    End Sub



End Class
