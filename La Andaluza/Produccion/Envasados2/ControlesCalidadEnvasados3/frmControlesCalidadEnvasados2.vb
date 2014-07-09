Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmControlesCalidadEnvasados2
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private m_VerID As Boolean = True
    Private padre As frmEntFormatosEnvasados2
    Private frmEnt As frmEntControlesCalidadEnvasados2
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spControlesCalidadEnvasados2, MaestroID)
        InitializeComponent()
        butExcel.Visible = True

        spSelectDgv = "ControlesCalidadEnvasados2SelectDgvByControlCalidadEnvasados2ID '" & MaestroID & "'"

        m_VerID = False
    End Sub

    Public Sub New(Optional embebido As Boolean = False, Optional padre As frmEntFormatosEnvasados2 = Nothing)
        MyBase.New(New spControlesCalidadEnvasados2, 0)
        InitializeComponent()
        Me.Embebido = embebido
        Me.padre = padre
        spSelectDgv = "ControlesCalidadEnvasados2SelectDgv"
    End Sub




    Overrides Sub Eliminar()
        If Me.dgvGeneral.RowCount > 0 Then
            If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                CType(sp, spControlesCalidadEnvasados2).ControlesCalidadEnvasados2Delete(dgvGeneral.CurrentRow.Cells("ControlCalidadEnvasados2ID").Value)
                dgvFill()
            End If
        End If
    End Sub


    Overrides Sub Action(ByVal TipoAction As String)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        Dim m_ControleCalidadEnvasado2 As New DBO_ControlesCalidadEnvasados2
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then

            If m_MaestroID <> 0 Then m_ControleCalidadEnvasado2.ControlCalidadEnvasados2ID = m_MaestroID
        Else
            m_ControleCalidadEnvasado2 = CType(sp, spControlesCalidadEnvasados2).Select_Record(GeneralBindingSource(m_Pos).Item("ControlCalidadEnvasados2ID"))
        End If

        frmEnt = New frmEntControlesCalidadEnvasados2(TipoAction, m_ControleCalidadEnvasado2, m_Pos, m_VerID)
        frmEnt.ShowDialog()

        dgvFill()

    End Sub

    Protected Overrides Sub cargar_datos()
        dataSource = dtb.Consultar(spSelectDgv)
    End Sub

    Protected Overrides Sub BindDataSource()
        Try
            If Not dataSource Is Nothing Then

                GeneralBindingSource.DataSource = dataSource



                With dgvGeneral
                    .DataSource = GeneralBindingSource

                    .Columns("ControlCalidadEnvasados2ID").Visible = False
                    .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                    .FormatoColumna("Nuevo", BasesParaCompatibilidad.TiposColumna.Izquierda, 200, 9)
                    .FormatoColumna("OtroNuevo", BasesParaCompatibilidad.TiposColumna.Izquierda, 200, 10)
                    .FormatoColumna("SegundoNuevo", BasesParaCompatibilidad.TiposColumna.Izquierda, 200, 11)
                    .FormatoGeneral()
                End With
            End If
            '
        Catch ex As Exception
            MessageBox.Show("Error en frmControlesCalidadEnvasados2. Detalles: " & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class
