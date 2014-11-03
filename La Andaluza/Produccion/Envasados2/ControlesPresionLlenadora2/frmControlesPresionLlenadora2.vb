Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmControlesPresionLlenadora2
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private m_VerID As Boolean = True
    Private padre As frmEntEnvasados2
    Private frmEnt As frmEntControlesPresionLlenadora2
    Public Sub New(ByVal MaestroID As Integer, Optional embebido As Boolean = False, Optional padre As frmEntEnvasados2 = Nothing)
        MyBase.New(New spControlesPresionLlenadora2, MaestroID)
        InitializeComponent()
        Me.Embebido = embebido
        Me.padre = padre
        spSelectDgv = "ControlesPresionLlenadora1SelectDgvByEnvasadoID '" & MaestroID & "'"

        m_VerID = False
    End Sub

    'Public Sub New()
    '    MyBase.New(New spControlesPresionLlenadora2, 0)
    '    InitializeComponent()
    '    spSelectDgv = "ControlesPresionLlenadora1SelectDgv"
    'End Sub

    Overrides Sub Eliminar()
        If Me.dgvGeneral.RowCount > 0 Then
            If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", _
                          "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim dtb As New BasesParaCompatibilidad.DataBase
                If CType(sp, spControlesPresionLlenadora2).ControlesPresionLlenadora1Delete(dgvGeneral.CurrentRow.Cells("ControlPresionLlenadora1ID").Value, dtb) Then
                    dgvFill()
                End If
            End If
        End If
    End Sub


    Overrides Sub Action(ByVal TipoAction As String)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim m_ControlePresionLlenadora1 As New DBO_ControlesPresionLlenadora2
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then
            If m_MaestroID <> 0 Then m_ControlePresionLlenadora1.EnvasadoID = m_MaestroID
        Else
            Dim dtb As New BasesParaCompatibilidad.DataBase
            m_ControlePresionLlenadora1 = CType(sp, spControlesPresionLlenadora2).Select_Record(GeneralBindingSource(m_Pos).Item("ControlPresionLlenadora1ID"), dtb)
        End If

        frmEnt = New frmEntControlesPresionLlenadora2(TipoAction, m_ControlePresionLlenadora1, m_Pos, m_VerID)
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

                .Columns("ControlPresionLlenadora1ID").Visible = False
                .FormatoColumna("Hora", BasesParaCompatibilidad.TiposColumna.Hora, 85, 1)
                .FormatoColumna("Verificador", BasesParaCompatibilidad.TiposColumna.Persona)
                .FormatoColumna("Presion", BasesParaCompatibilidad.TiposColumna.Double2)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Observaciones, True)
                .FormatoGeneral()
            End With

            'If Me.dgvGeneral.RowCount > 0 Then
            '    butExcel.Visible = True
            '    butWord.Visible = True
            '    butExcel.Enabled = True
            '    butWord.Enabled = True
            '    butModificar.Visible = True
            '    butModificar.Enabled = True
            '    butEliminar.Visible = True
            '    butEliminar.Enabled = True
            '    butVer.Visible = True
            '    butVer.Enabled = True
            'Else
            '    butExcel.Visible = False
            '    butWord.Visible = False
            '    butExcel.Enabled = False
            '    butWord.Enabled = False
            '    butModificar.Visible = False
            '    butModificar.Enabled = False
            '    butEliminar.Visible = False
            '    butEliminar.Enabled = False
            '    butVer.Visible = False
            '    butVer.Enabled = False
            'End If

        End If
    End Sub


End Class
