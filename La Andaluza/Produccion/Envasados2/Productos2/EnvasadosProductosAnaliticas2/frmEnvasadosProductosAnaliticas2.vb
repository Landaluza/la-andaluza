Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmEnvasadosProductosAnaliticas2
    Inherits BasesParaCompatibilidad.FrmAheredarOld


    Private m_VerID As Boolean = True
    Private v_ver As Boolean
    Private frmEnt As frmEntEnvasadosProductosAnaliticas2
    Public Sub New(ByVal MaestroID As Integer, Optional ByVal _ver As Boolean = False)
        MyBase.New(New spEnvasadosProductosAnaliticas2, MaestroID)
        InitializeComponent()
        spSelectDgv = "EnvasadosProductosAnaliticasSelectDgvByEnvasadoProductoID '" & MaestroID & "'"

        m_VerID = False
        Me.v_ver = _ver
    End Sub

    Public Sub New()
        MyBase.New(New spEnvasadosProductosAnaliticas2, 0)
        InitializeComponent()
        spSelectDgv = "EnvasadosProductosAnaliticasSelectDgv"
    End Sub

    Private Sub frmEnvasadosProductosAnaliticas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        butExcel.Visible = True
        BindingNavigatorSinRegistros()
        butModificar.Visible = True
        butEliminar.Visible = True
        butSalir.Visible = False


        If Me.v_ver Then Me.butGuardar.Enabled = False
    End Sub

    Overrides Sub Eliminar()
        If Me.dgvGeneral.RowCount > 0 Then
            If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim dtb As New BasesParaCompatibilidad.DataBase
                If CType(sp, spEnvasadosProductosAnaliticas2).EnvasadosProductosAnaliticasDelete(dgvGeneral.CurrentRow.Cells("EnvasadoProductoAnaliticaID").Value, dtb) Then
                    dgvFill()

                End If
            End If
        End If
    End Sub


    Overrides Sub Action(ByVal TipoAction As String)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim m_EnvasadoProductoAnalitica As New DBO_EnvasadosProductosAnaliticas2
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then

            If m_MaestroID <> 0 Then m_EnvasadoProductoAnalitica.EnvasadoProductoID = m_MaestroID
        Else
            Dim dtb As New BasesParaCompatibilidad.DataBase
            m_EnvasadoProductoAnalitica = CType(sp, spEnvasadosProductosAnaliticas2).Select_Record(GeneralBindingSource(m_Pos).Item("EnvasadoProductoAnaliticaID"), dtb)
        End If

        frmEnt = New frmEntEnvasadosProductosAnaliticas2(TipoAction, m_EnvasadoProductoAnalitica, m_Pos, m_VerID)
        'frmEnt.Text = String.Format("{0} {1}", TipoAction, Titulo)
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

                .Columns("EnvasadoProductoAnaliticaID").Visible = False
                .FormatoColumna("Analista", BasesParaCompatibilidad.TiposColumna.Izquierda, 200, 1)
                .FormatoColumna("Hora", BasesParaCompatibilidad.TiposColumna.Hora, 85, 2)
                .FormatoColumna("Parametro", BasesParaCompatibilidad.TiposColumna.Izquierda, 120, 3)
                .FormatoColumna("Valor", BasesParaCompatibilidad.TiposColumna.Double2, 50, 4)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 5)
            End With
        End If
    End Sub




End Class
