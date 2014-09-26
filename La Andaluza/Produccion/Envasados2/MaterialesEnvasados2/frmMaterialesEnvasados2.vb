Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmMaterialesEnvasados2
    Inherits BasesParaCompatibilidad.FrmAheredarOld


    Private m_VerID As Boolean = True

    Private m_Envasado As DBO_Envasados2
    Private formatoId As Integer
    Private padre As frmEntFormatosEnvasados2
    Private frmEnt As frmEntMaterialesEnvasados2
    Public Sub New(formatoId As Integer, Optional embebido As Boolean = False, Optional padre As frmEntFormatosEnvasados2 = Nothing)
        MyBase.New(New spMaterialesEnvasados2, formatoId)
        InitializeComponent()
        butExcel.Visible = True
        Me.Embebido = embebido
        Me.padre = padre

        m_Envasado = DBO_Envasados2.Instance
        Me.formatoId = formatoId
        spSelectDgv = "MaterialesEnvasados2SelectPorFormatoEnvasado " & Me.formatoId
    End Sub




    Overrides Sub Eliminar()
        If Me.dgvGeneral.RowCount > 0 Then
            If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                CType(sp, spMaterialesEnvasados2).MaterialesEnvasados2Delete(dgvGeneral.CurrentRow.Cells("MaterialEnvasadoID").Value)
                dgvFill()
            End If
        End If
    End Sub


    Overrides Sub Action(ByVal TipoAction As String)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        Dim m_MaterialesEnvasados2 As New DBO_MaterialesEnvasados2
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then
            m_MaterialesEnvasados2.MaterialEnvasadoID = 0
            m_MaterialesEnvasados2.HoraInicio = DateTime.Now.TimeOfDay
            m_MaterialesEnvasados2.HoraFin = DateTime.Now.TimeOfDay
        Else
            m_MaterialesEnvasados2 = CType(Me.sp, spMaterialesEnvasados2).Select_Record(GeneralBindingSource(m_Pos).Item("MaterialEnvasadoID"))
        End If
        m_MaterialesEnvasados2.FormatoEnvasadoID = Me.formatoId

        Dim spf As New spFormatosEnvasados
        Dim dbo As DBO_FormatosEnvasados
        Dim spAux As New spTiposFormatosLineas
        dbo = spf.Select_Record(Me.formatoId)
        Dim dbo_linea As DBO_TiposFormatosLineas = spAux.Select_Record(dbo.TipoFormatoLineaID)

        frmEnt = New frmEntMaterialesEnvasados2(Me.formatoId, TipoAction, m_MaterialesEnvasados2, dbo_linea.LineaEnvasadoID, m_Pos, m_VerID)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)

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
                .Columns("MaterialEnvasadoID").Visible = False
                .FormatoColumna("Inicio", BasesParaCompatibilidad.TiposColumna.Hora, 80, 0)
                .FormatoColumna("Fin", BasesParaCompatibilidad.TiposColumna.Hora, 80, 1)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoGeneral()
            End With

        End If
    End Sub


End Class
