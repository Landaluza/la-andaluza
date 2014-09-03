Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmEnvasadosControles7
    Inherits BasesParaCompatibilidad.FrmAheredarOld


    Private m_VerID As Boolean = True
    Private frmEnt As frmEntEnvasadosControles7
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spEnvasadosControles7, MaestroID)
        InitializeComponent()

        spSelectDgv = "EnvasadosControles1SelectDgvByEnvasadoControlID '" & MaestroID & "'"

        m_VerID = False
    End Sub

    Public Sub New()
        MyBase.New(New spEnvasadosControles7, 0)
        InitializeComponent()
        spSelectDgv = "EnvasadosControles1SelectDgv"
    End Sub


    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If CType(sp, spEnvasadosControles7).EnvasadosControles1Delete(dgvGeneral.CurrentRow.Cells("EnvasadoControl1ID").Value) Then
                dgvFill()
            End If
        End If

    End Sub


    Overrides Sub Action(ByVal TipoAction As String)
        Dim m_EnvasadoControle1 As New DBO_EnvasadosControles7
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then

            If m_MaestroID <> 0 Then m_EnvasadoControle1.EnvasadoControlID = m_MaestroID
        Else
            m_EnvasadoControle1 = CType(sp, spEnvasadosControles7).Select_Record(GeneralBindingSource(m_Pos).Item("EnvasadoControl1ID"))
        End If

        frmEnt = New frmEntEnvasadosControles7(TipoAction, m_EnvasadoControle1)
        'frmEnt.Text = String.Format("{0} {1}", TipoAction, Titulo)
        frmEnt.ShowDialog()

        dgvFill()
    End Sub

    Protected Overrides Sub cargar_datos()
        dataSource = dtb.Consultar(spSelectDgv)
    End Sub

    Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource


            butExcel.Visible = True

            With dgvGeneral
                .DataSource = GeneralBindingSource

                .Columns("EnvasadoControl1ID").Visible = False
                .FormatoColumna("EnvasadoControlID", BasesParaCompatibilidad.TiposColumna.Miles, 50, 1)
                .FormatoGeneral()
            End With
        End If
    End Sub
End Class
