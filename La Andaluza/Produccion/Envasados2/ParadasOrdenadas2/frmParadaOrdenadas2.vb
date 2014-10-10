Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmParadaOrdenadas2
    Inherits BasesParaCompatibilidad.FrmAheredarOld


    Private m_VerID As Boolean = True

    Private m_Envasado As DBO_Envasados2
    Private formatoId As Integer
    Private padre As frmEntFormatosEnvasados2
    Private frmEnt As frmEntParadaOrdenadas2
    Public Sub New(formatoId As Integer, Optional embebido As Boolean = False, Optional padre As frmEntFormatosEnvasados2 = Nothing)
        MyBase.New(New spParadaOrdenadas2, formatoId)
        InitializeComponent()
        butExcel.Visible = True
        Me.Embebido = embebido
        Me.padre = padre

        m_Envasado = DBO_Envasados2.Instance
        Me.formatoId = formatoId
        spSelectDgv = "ParadasOrdenadas2SelectPorFormatoEnvasado " & Me.formatoId
    End Sub




    Overrides Sub Eliminar()
        If Me.dgvGeneral.RowCount > 0 Then
            If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                CType(sp, spParadaOrdenadas2).ParadaOrdenadas2Delete(dgvGeneral.CurrentRow.Cells("ParadaOrdenadaID").Value)
                dgvFill()
            End If
        End If
    End Sub


    Overrides Sub Action(ByVal TipoAction As String)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        Dim m_ParadaOrdenadas2 As New DBO_ParadaOrdenadas2
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then
            m_ParadaOrdenadas2.ParadaOrdenadaID = 0
            m_ParadaOrdenadas2.HoraInicio = DateTime.Now.TimeOfDay
            m_ParadaOrdenadas2.HoraFinal = DateTime.Now.TimeOfDay
        Else
            m_ParadaOrdenadas2 = CType(sp, spParadaOrdenadas2).Select_Record(GeneralBindingSource(m_Pos).Item("ParadaOrdenadaID"))
        End If
        m_ParadaOrdenadas2.FormatoEnvasadoID = Me.formatoId

        frmEnt = New frmEntParadaOrdenadas2(Me.formatoId, TipoAction, m_ParadaOrdenadas2, m_Pos, m_VerID)
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
                .Columns("ParadaOrdenadaID").Visible = False
                .FormatoColumna("Inicio", BasesParaCompatibilidad.TiposColumna.FechaCorta, 85, 0)
                .FormatoColumna("Fin", BasesParaCompatibilidad.TiposColumna.FechaCorta, 85, 1)
                .FormatoColumna("Observacion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoGeneral()
            End With
        End If
    End Sub


End Class
