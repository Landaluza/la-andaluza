Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmEnvasadosControlesUlma
    Inherits BasesParaCompatibilidad.FrmAheredarOld


    Private m_VerID As Boolean = True
    Private frmEnt As frmEntEnvasadosControlesUlma
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spEnvasadosControlesUlma, MaestroID)
        InitializeComponent()

        spSelectDgv = "EnvasadosControlesUlmaSelectDgvByEnvasadoControlID '" & MaestroID & "'"

        m_VerID = False
    End Sub


    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            CType(sp, spEnvasadosControlesUlma).EnvasadosControlesUlmaDelete(dgvGeneral.CurrentRow.Cells("EnvasadoControlUlmaID").Value)
            dgvFill()
        End If
    End Sub



    Overrides Sub Action(ByVal TipoAction As String)
        Dim m_EnvasadoControleUlma As New DBO_EnvasadosControlesUlma
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then

            If m_MaestroID <> 0 Then m_EnvasadoControleUlma.EnvasadoControlID = m_MaestroID
        Else
            m_EnvasadoControleUlma = CType(sp, spEnvasadosControlesUlma).Select_Record(GeneralBindingSource(m_Pos).Item("EnvasadoControlUlmaID"))
        End If

        frmEnt = New frmEntEnvasadosControlesUlma(TipoAction, m_EnvasadoControleUlma)
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

                .Columns("EnvasadoControlUlmaID").Visible = False
                .FormatoColumna("EnvasadoControlID", BasesParaCompatibilidad.TiposColumna.Miles, 50, 1)
                .FormatoGeneral()
            End With
        End If
    End Sub
End Class
