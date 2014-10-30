Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmPropuestas2
    Inherits BasesParaCompatibilidad.FrmAheredarOld



    Private formatoId As Integer
    Private padre As frmEntFormatosEnvasados2
    Private frmEnt As frmEntPropuestas2
    Public Sub New(formatoId As Integer, Optional embebido As Boolean = False, Optional padre As frmEntFormatosEnvasados2 = Nothing)
        MyBase.New(New spPropuestas2, formatoId)
        InitializeComponent()
        Me.Embebido = embebido
        Me.padre = padre
        Me.formatoId = formatoId
        spSelectDgv = "Propuestas2SelectPorFormatoEnvasado " & Me.formatoId
    End Sub

    Overrides Sub Eliminar()
        If Me.dgvGeneral.RowCount > 0 Then
            If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                CType(sp, spPropuestas2).Propuestas2Delete(dgvGeneral.CurrentRow.Cells("PropuestaID").Value, dtb)
                dgvFill()
            End If
        End If
    End Sub

    Overrides Sub Action(ByVal TipoAction As String)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        Dim m_Propuestas2 As DBO_Propuestas2 = DBO_Propuestas2.Instance
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then
            m_Propuestas2.Limpiar()
            m_Propuestas2.FormatoEnvasadoID = Me.formatoId
        Else
            m_Propuestas2 = CType(sp, spPropuestas2).Select_Record(GeneralBindingSource(m_Pos).Item("PropuestaID"), dtb)
        End If

        frmEnt = New frmEntPropuestas2(TipoAction, Me.formatoId)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)

        dgvFill()

    End Sub

    Protected Overrides Sub cargar_datos()
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dataSource = dtb.Consultar(spSelectDgv, True)
    End Sub

    Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource

            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("PropuestaID").Visible = False
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoGeneral()
            End With
        End If
    End Sub


End Class
