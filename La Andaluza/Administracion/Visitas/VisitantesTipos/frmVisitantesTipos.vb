Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmVisitantesTipos
    Inherits BasesParaCompatibilidad.FrmAheredarOld


    Private m_VisitanteTipo As New DBO_VisitantesTipos
    Private frmEnt As frmEntVisitantesTipos
    Public Sub New()
        MyBase.New(New spVisitantesTipos, 0)
        InitializeComponent()
        spSelectDgv = "VisitantesTiposSelectDgv"

    End Sub

    Private Sub frmVisitantesTipos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        butExcel.Visible = False
        butWord.Visible = False


    End Sub

    Overrides Sub Eliminar()
        If MessageBox.Show(" �Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim dtb As New BasesParaCompatibilidad.DataBase
            If CType(sp, spVisitantesTipos).VisitantesTiposDelete(dgvGeneral.CurrentRow.Cells("VisitanteTipoID").Value, dtb) Then
                dgvFill()
            End If
        End If
    End Sub

    Overrides Sub Action(ByVal TipoAction As String)
        Dim dtb As New BasesParaCompatibilidad.DataBase
        If TipoAction <> ACCION_INSERTAR Then m_VisitanteTipo = CType(sp, spVisitantesTipos).Select_Record(dgvGeneral.CurrentRow.Cells("VisitanteTipoID").Value, dtb)
        'FormEntradaDatos(frmEntVisitantesTipos, m_VisitanteTipo, TipoAction, Titulo)

        frmEnt = New frmEntVisitantesTipos(m_VisitanteTipo)
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


            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("VisitanteTipoID").Visible = False
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, 200)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, 200)
            End With

            BindingNavigatorActualizar(dgvGeneral.RowCount)
        End If
    End Sub





End Class
