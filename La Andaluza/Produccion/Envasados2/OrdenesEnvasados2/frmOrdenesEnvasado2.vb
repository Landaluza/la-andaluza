Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmOrdenesEnvasado2
    Inherits BasesParaCompatibilidad.FrmAheredarOld


    Public Sub New()
        MyBase.New(New spOrdenesEnvasado2, 0)
        InitializeComponent()
        spSelectDgv = "OrdenesEnvasados2SelectDgv"
    End Sub

    Private Sub frmOrdenesEnvasado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        butExcel.Visible = False
        butWord.Visible = False
        dgvGeneral.MoveLast()
    End Sub

    Overrides Sub Eliminar()
        'TO DO: Da error porq la eliminacion no se hace en cascada
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim dtb As New BasesParaCompatibilidad.DataBase
            If CType(sp, spOrdenesEnvasado2).OrdenesEnvasadoDelete(dgvGeneral.CurrentRow.Cells("OrdenEnvasadoID").Value, dtb) Then
                dgvFill()
            End If
        End If
    End Sub

    Overrides Sub Action(ByVal TipoAction As String)
        Dim m_OrdenesEnvasado As New DBO_OrdenesEnvasado2
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then
            If m_MaestroID <> 0 Then m_OrdenesEnvasado.OrdenEnvasadoID = m_MaestroID
        Else
            Dim dtb As New BasesParaCompatibilidad.DataBase
            m_OrdenesEnvasado = CType(sp, spOrdenesEnvasado2).Select_Record(GeneralBindingSource(m_Pos).Item("OrdenEnvasadoID"), dtb)
        End If

        Dim frmEnt As New frmEntOrdenesEnvasado2(m_OrdenesEnvasado, m_Pos)
        frmEnt.Text = String.Format("{0} {1}", TipoAction, Me.Text)
        'BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        AddHandler frmEnt.FormClosed, AddressOf dgvFill
        GUImain.añadirPestaña(frmEnt)

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

                .Columns("OrdenEnvasadoID").Visible = False
                .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 85)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, 382)
            End With

        End If
    End Sub
End Class
