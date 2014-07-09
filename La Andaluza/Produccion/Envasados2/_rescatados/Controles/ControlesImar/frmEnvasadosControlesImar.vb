Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmEnvasadosControlesImar
    Inherits BasesParaCompatibilidad.FrmAheredarOld


    Private m_VerID As Boolean = True
    Private frmEnt As frmEntEnvasadosControlesImar
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spEnvasadosControlesImar, MaestroID)
        InitializeComponent()
        spSelectDgv = "EnvasadosControlesImarSelectDgvByEnvasadoControlID '" & MaestroID & "'"

        m_VerID = False
    End Sub


    Private Sub frmEnvasadosControlesImar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        butExcel.Visible = False
        butWord.Visible = False
    End Sub

    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            CType(sp, spEnvasadosControlesImar).EnvasadosControlesImarDelete(dgvGeneral.CurrentRow.Cells("EnvasadoControlImarID").Value)
            dgvFill()
        End If

    End Sub

    Overrides Sub Action(ByVal TipoAction As String)
        Dim m_EnvasadoControleImar As New DBO_EnvasadosControlesImar
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then
            If m_MaestroID <> 0 Then m_EnvasadoControleImar.EnvasadoControlID = m_MaestroID
        Else
            m_EnvasadoControleImar = CType(sp, spEnvasadosControlesImar).Select_Record(GeneralBindingSource(m_Pos).Item("EnvasadoControlImarID"))
        End If

        frmEnt = New frmEntEnvasadosControlesImar(TipoAction, m_EnvasadoControleImar)
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

                .Columns("EnvasadoControlImarID").Visible = False
                .FormatoColumna("EnvasadoControlID", BasesParaCompatibilidad.TiposColumna.Miles, 50, 1)
                .FormatoGeneral()
            End With
        End If
    End Sub
End Class
