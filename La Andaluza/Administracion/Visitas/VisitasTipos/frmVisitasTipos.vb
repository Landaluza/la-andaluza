Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmVisitasTipos
    Inherits BasesParaCompatibilidad.FrmAheredarOld


    Private m_VerID As Boolean = True
    Private frmEnt As frmEntVisitasTipos
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spVisitasTipos, MaestroID)
        InitializeComponent()
        spSelectDgv = "VisitasTiposSelectDgvByID '" & MaestroID & "'"

        m_VerID = False
    End Sub

    Public Sub New()
        MyBase.New(New spVisitasTipos, 0)
        InitializeComponent()
        spSelectDgv = "VisitasTiposSelectDgv"
    End Sub

    Private Sub frmVisitasTipos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        butExcel.Visible = False
        butWord.Visible = False


        'dgvFill()
    End Sub

    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim dtb As New BasesParaCompatibilidad.DataBase
            If CType(sp, spVisitasTipos).VisitasTiposDelete(dgvGeneral.CurrentRow.Cells("VisitaTipoID").Value, dtb) Then
                dgvFill()
            End If
        End If

    End Sub

    Overrides Sub Action(ByVal TipoAction As String)
        Dim m_VisitaTipo As New DBO_VisitasTipos
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then
            If m_MaestroID <> 0 Then m_VisitaTipo.Descripcion = m_MaestroID
        Else
            Dim dtb As New BasesParaCompatibilidad.DataBase
            m_VisitaTipo = CType(sp, spVisitasTipos).Select_Record(GeneralBindingSource(m_Pos).Item("VisitaTipoID"), dtb)
        End If

        frmEnt = New frmEntVisitasTipos(m_VisitaTipo, m_Pos, m_VerID)
        frmEnt.Text = String.Format("{0} {1}", TipoAction, Me.Text)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)

        dgvFill()
    End Sub

    Protected Overrides Sub cargar_datos()
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dtb.PrepararConsulta(spSelectDgv)
        dataSource = dtb.Consultar()
    End Sub

    Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            GeneralBindingSource.DataSource = dataSource

            With dgvGeneral
                .DataSource = GeneralBindingSource

                .Columns("VisitaTipoID").Visible = False
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 1, 200)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 2, 200)
            End With
        End If
    End Sub


End Class
