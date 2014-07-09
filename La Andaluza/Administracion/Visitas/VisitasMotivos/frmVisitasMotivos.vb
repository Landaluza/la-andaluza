Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmVisitasMotivos
    Inherits BasesParaCompatibilidad.FrmAheredarOld


    Private m_VerID As Boolean = True
    Private frmEnt As frmEntVisitasMotivos
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spVisitasMotivos, MaestroID)
        InitializeComponent()
        spSelectDgv = "VisitasMotivosSelectDgvByID '" & MaestroID & "'"

        m_VerID = False
    End Sub

    Public Sub New()
        MyBase.New(New spVisitasMotivos, 0)
        InitializeComponent()
        spSelectDgv = "VisitasMotivosSelectDgv"
    End Sub

    Private Sub frmVisitasMotivos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        butExcel.Visible = False
        butWord.Visible = False

    End Sub

    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If CType(sp, spVisitasMotivos).VisitasMotivosDelete(dgvGeneral.CurrentRow.Cells("VisitaMotivoID").Value) Then
                dgvFill()
            End If
        End If

    End Sub


    Overrides Sub Action(ByVal TipoAction As String)
        Dim m_VisitaMotivo As New DBO_VisitasMotivos
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then
            If m_MaestroID <> 0 Then m_VisitaMotivo.Descripcion = m_MaestroID
        Else
            m_VisitaMotivo = CType(sp, spVisitasMotivos).Select_Record(GeneralBindingSource(m_Pos).Item("VisitaMotivoID"))
        End If

        frmEnt = New frmEntVisitasMotivos(m_VisitaMotivo, m_Pos, m_VerID)
        frmEnt.Text = String.Format("{0} {1}", TipoAction, Me.Text)
        frmEnt.ShowDialog()

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

                .Columns("VisitaMotivoID").Visible = False
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 1, 200)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 2, 200)
            End With
        End If
    End Sub


End Class
