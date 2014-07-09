Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmPedidosProveedoresDocumentos1
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private m_VerID As Boolean = True
    Private frmEnt As frmEntPedidosProveedoresDocumentos1
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spPedidosProveedoresDocumentos1, MaestroID)
        InitializeComponent()
        spSelectDgv = "PedidosProveedoresDocumentos1SelectDgvByPedidoProveedorMaestroID '" & MaestroID & "'"

        m_VerID = False
    End Sub

    Public Sub New()
        MyBase.New(New spPedidosProveedoresDocumentos1, 0)
        InitializeComponent()
        spSelectDgv = "PedidosProveedoresDocumentos1SelectDgv"
    End Sub

    Private Sub frmPedidosProveedoresDocumentos1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        butExcel.Visible = False
        butWord.Visible = False


    End Sub

    Overrides Sub Ver()
        Dim f As New BasesParaCompatibilidad.File
        f.open(dgvGeneral.CurrentRow.Cells("Ruta").Value)

        'Try
        '    Dim psi As New ProcessStartInfo()
        '    psi.UseShellExecute = True
        '    psi.FileName = dgvGeneral.CurrentRow.Cells("Ruta").Value
        '    Process.Start(psi)
        'Catch ex As Exception
        '    messagebox.show(ex.Message)
        'End Try
    End Sub

    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If CType(sp, spPedidosProveedoresDocumentos1).PedidosProveedoresDocumentos1Delete(dgvGeneral.CurrentRow.Cells("PedidoProveedorDocumentoID").Value) Then
                dgvFill()

            End If
        End If
    End Sub

    'Overrides Sub ToExcel()
    '    ExportToExcel("Many", Me.Text, dgvGeneral)
    'End Sub

    'Overrides Sub ToWord()
    '    ExportToWord("Many", Me.Text, dgvGeneral)
    'End Sub

    Overrides Sub Action(ByVal TipoAction As String)
        Dim m_PedidosProveedoresDocumentos1 As New DBO_PedidosProveedoresDocumentos1
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then
            If m_MaestroID <> 0 Then m_PedidosProveedoresDocumentos1.PedidoProveedorMaestroID = m_MaestroID
        Else
            m_PedidosProveedoresDocumentos1 = CType(sp, spPedidosProveedoresDocumentos1).Select_Record(GeneralBindingSource(m_Pos).Item("PedidoProveedorDocumentoID"))
        End If

        frmEnt = New frmEntPedidosProveedoresDocumentos1(m_PedidosProveedoresDocumentos1, m_Pos, m_VerID)
        frmEnt.Text = String.Format("{0} {1}", TipoAction, Me.Text)
        frmEnt.ShowDialog()

        dgvFill()
    End Sub

    Protected Overrides Sub cargar_datos()
        dataSource = dtb.Consultar(spSelectDgv)
    End Sub
    Protected Overrides Sub dgvFill()
        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource

            With dgvGeneral
                .DataSource = GeneralBindingSource
                If m_MaestroID = 0 Then
                    .Columns("PedidoProveedorDocumentoID").Visible = False
                    .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 70)
                    .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, 350)
                    .FormatoColumna("Observaciones", "Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, 462)
                Else
                    .Columns("PedidoProveedorDocumentoID").Visible = False
                    .Columns("Ruta").Visible = False
                    .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 70)
                    .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, 350)
                    .FormatoColumna("Observaciones", "Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, 462)
                End If
                ' .FormatoGeneral()

            End With
        End If
    End Sub
End Class
