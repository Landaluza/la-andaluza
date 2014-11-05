Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmControlesContenidoEfectivo2
    Inherits BasesParaCompatibilidad.FrmAheredarOld


    Private m_VerID As Boolean = True
    Private padre As frmEntEnvasados2
    Private frmEnt As frmEntControlesContenidoEfectivo2
    Public Sub New(ByVal MaestroID As Integer, Optional embebido As Boolean = False, Optional padre As frmEntEnvasados2 = Nothing)
        MyBase.New(New spControlesContenidoEfectivo2, MaestroID)
        InitializeComponent()
        Me.Embebido = embebido
        Me.padre = padre
        spSelectDgv = "ControlesContenidoEfectivoSelectDgvByEnvasadoID '" & MaestroID & "'"

        m_VerID = False
    End Sub

    Public Sub New()
        MyBase.New(New spControlesContenidoEfectivo2, 0)
        InitializeComponent()
        spSelectDgv = "ControlesContenidoEfectivoSelectDgv"
    End Sub

    Overrides Sub Eliminar()
        If Me.dgvGeneral.RowCount > 0 Then
            If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim dtb As New BasesParaCompatibilidad.DataBase
                If CType(sp, spControlesContenidoEfectivo2).ControlesContenidoEfectivoDelete(dgvGeneral.CurrentRow.Cells("ControlContenidoEfectivoID").Value, dtb) Then
                    dgvFill()
                End If
            End If
        End If
    End Sub


    Overrides Sub Action(ByVal TipoAction As String)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim m_ControleContenidoEfectivo As New DBO_ControlesContenidoEfectivo2
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then
            If m_MaestroID <> 0 Then m_ControleContenidoEfectivo.EnvasadoID = m_MaestroID
        Else
            Dim dtb As New BasesParaCompatibilidad.DataBase
            m_ControleContenidoEfectivo = CType(sp, spControlesContenidoEfectivo2).Select_Record(Me.dgvGeneral.CurrentRow.Cells("ControlContenidoEfectivoID").Value, dtb)
        End If

        frmEnt = New frmEntControlesContenidoEfectivo2(TipoAction, m_ControleContenidoEfectivo, m_Pos, m_VerID)
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

                .Columns("ControlContenidoEfectivoID").Visible = False
                .FormatoColumna("Verificador", BasesParaCompatibilidad.TiposColumna.Persona)
                .FormatoColumna("Lote", BasesParaCompatibilidad.TiposColumna.Izquierda, 85)
                .FormatoColumna("Inicio", BasesParaCompatibilidad.TiposColumna.Hora)
                .FormatoColumna("Final", BasesParaCompatibilidad.TiposColumna.Hora)
                .FormatoColumna("Nominal", BasesParaCompatibilidad.TiposColumna.Miles)
                .FormatoColumna("Maximo", BasesParaCompatibilidad.TiposColumna.Double2)
                .FormatoColumna("Minimo", BasesParaCompatibilidad.TiposColumna.Double2)
                .FormatoColumna("T1", BasesParaCompatibilidad.TiposColumna.Double2)
                .FormatoColumna("T2", BasesParaCompatibilidad.TiposColumna.Double2)
                .FormatoColumna("Media", BasesParaCompatibilidad.TiposColumna.Double2)
                .FormatoColumna("Desviacion", BasesParaCompatibilidad.TiposColumna.Double2)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Observaciones, True)
                .FormatoGeneral()
            End With

            If Me.dgvGeneral.RowCount > 0 Then
                butExcel.Visible = True
                butWord.Visible = True
                butExcel.Enabled = True
                butWord.Enabled = True
                butModificar.Visible = True
                butModificar.Enabled = True
                butEliminar.Visible = True
                butEliminar.Enabled = True
                butVer.Visible = True
                butVer.Enabled = True
            Else
                butExcel.Visible = False
                butWord.Visible = False
                butExcel.Enabled = False
                butWord.Enabled = False
                butModificar.Visible = False
                butModificar.Enabled = False
                butEliminar.Visible = False
                butEliminar.Enabled = False
                butVer.Visible = False
                butVer.Enabled = False
            End If
            ' 
        End If
    End Sub


End Class
