Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmCambiosFormatosEnvasados2
    Inherits BasesParaCompatibilidad.FrmAheredarOld


    Private m_VerID As Boolean = True

    Private m_Envasado As DBO_Envasados2
    Private m_FormatoEnvasadoID As Integer
    Private padre As frmEntFormatosEnvasados2
    Private frmEnt As frmEntCambiosFormatosEnvasados2
    Public Sub New(ByVal formatoId As Integer, Optional embebido As Boolean = False, Optional padre As frmEntFormatosEnvasados2 = Nothing)
        MyBase.New(New spCambiosFormatosEnvasados2, formatoId)
        InitializeComponent()
        butExcel.Visible = True
        Me.Embebido = embebido
        Me.padre = padre

        m_Envasado = DBO_Envasados2.Instance
        Dim spFormatos As New spFormatosEnvasados
        m_FormatoEnvasadoID = formatoId
        spSelectDgv = "CambiosFormatosEnvasados2SelectPorFormatoEnvasado " & m_FormatoEnvasadoID
    End Sub




    Overrides Sub Eliminar()
        If Me.dgvGeneral.RowCount > 0 Then
            If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                CType(sp, spCambiosFormatosEnvasados2).CambiosFormatosEnvasados2Delete(dgvGeneral.CurrentRow.Cells("CambioFormatoEnvasadoId").Value)
                dgvFill()
            End If
        End If
    End Sub


    Overrides Sub Action(ByVal TipoAction As String)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        Dim m_CambiosFormatosEnvasados2 As New DBO_CambiosFormatosEnvasados2
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then
            m_CambiosFormatosEnvasados2.CambioFormatoEnvasadoId = 0
            m_CambiosFormatosEnvasados2.HoraInicio = DateTime.Now.TimeOfDay
            m_CambiosFormatosEnvasados2.HoraFin = DateTime.Now.TimeOfDay
        Else
            m_CambiosFormatosEnvasados2 = CType(sp, spCambiosFormatosEnvasados2).Select_Record(GeneralBindingSource(m_Pos).Item("CambioFormatoEnvasadoId"))
        End If
        m_CambiosFormatosEnvasados2.FormatoEnvasadoAID = m_FormatoEnvasadoID

        frmEnt = New frmEntCambiosFormatosEnvasados2(TipoAction, m_CambiosFormatosEnvasados2, m_Pos, m_VerID, Me.m_FormatoEnvasadoID)
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
                .Columns("CambioFormatoEnvasadoId").Visible = False
                .Columns("FormatoEnvasadoAID").Visible = False
                .FormatoColumna("Inicio", BasesParaCompatibilidad.TiposColumna.Hora, 85, 0)
                .FormatoColumna("Fin", BasesParaCompatibilidad.TiposColumna.Hora, 85, 1)
                .FormatoColumna("Observacion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoGeneral()
            End With
            '
        End If
    End Sub


End Class
