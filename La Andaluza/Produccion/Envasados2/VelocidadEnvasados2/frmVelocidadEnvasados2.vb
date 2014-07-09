Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmVelocidadEnvasados2
    Inherits BasesParaCompatibilidad.FrmAheredarOld


    Private m_VerID As Boolean = True

    Private m_Envasado As DBO_Envasados2
    Private formatoId As Integer
    Private padre As frmEntFormatosEnvasados2
    Private frmEnt As frmEntVelocidadEnvasados2
    Public Sub New(formatoId As Integer, Optional embebido As Boolean = False, Optional padre As frmEntFormatosEnvasados2 = Nothing)
        MyBase.New(New spVelocidadEnvasados2, formatoId)
        InitializeComponent()
        butExcel.Visible = True
        Me.Embebido = embebido
        Me.padre = padre

        m_Envasado = DBO_Envasados2.Instance
        Me.formatoId = formatoId
        spSelectDgv = "VelocidadEnvasados2SelectPorFormatosEnvasados " & Me.formatoId
    End Sub

    Private Sub frmVelocidadEnvasados2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.Embebido Then
            Me.butSalir.Visible = False
        End If
    End Sub

    Overrides Sub Eliminar()
        If Me.dgvGeneral.RowCount > 0 Then
            If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                CType(sp, spVelocidadEnvasados2).VelocidadEnvasados2Delete(dgvGeneral.CurrentRow.Cells("VelocidadEnvasadoID").Value)
                dgvFill()
            End If
        End If
    End Sub


    Overrides Sub Action(ByVal TipoAction As String)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        Dim m_VelocidadEnvasados2 As New DBO_VelocidadEnvasados2
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then
            m_VelocidadEnvasados2.VelocidadEnvasadoID = 0
            m_VelocidadEnvasados2.HoraInicio = Now.Date.TimeOfDay
        Else
            m_VelocidadEnvasados2 = CType(sp, spVelocidadEnvasados2).Select_Record(GeneralBindingSource(m_Pos).Item("VelocidadEnvasadoID"))
        End If
        m_VelocidadEnvasados2.FormatoEnvasadoID = Me.formatoId

        frmEnt = New frmEntVelocidadEnvasados2(Me.formatoId, TipoAction, m_VelocidadEnvasados2, m_Pos, m_VerID)
        frmEnt.ShowDialog()

        dgvFill()

    End Sub

    Protected Overrides Sub cargar_datos()
        dataSource = dtb.Consultar(spSelectDgv)
    End Sub

    Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource



            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("VelocidadEnvasadoID").Visible = False
                .FormatoColumna("HoraInicio", "Inicio", BasesParaCompatibilidad.TiposColumna.Hora, 85, 0)
                .FormatoColumna("FormatoEnvasadoID", BasesParaCompatibilidad.TiposColumna.Izquierda, 200, 5)
                .FormatoColumna("Observacion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoGeneral()
            End With
        End If
    End Sub


End Class
