Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmEnvasadosControles2
    Inherits BasesParaCompatibilidad.FrmAheredarOld


    Private m_VerID As Boolean = True
    Private frmEnt As frmEntEnvasadosControles2
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spEnvasadosControles2, MaestroID)
        InitializeComponent()

        spSelectDgv = CType(sp, spEnvasadosControles2).DataGridViewStoredProcedureForFilteredSelect & " '" & MaestroID & "'"

        m_VerID = False
    End Sub

    Public Sub New()
        MyBase.New(New spEnvasadosControles2, 0)
        InitializeComponent()
        spSelectDgv = CType(sp, spEnvasadosControles2).DataGridViewStoredProcedureForSelect
    End Sub




    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            CType(sp, spEnvasadosControles2).EnvasadosControles2Delete(dgvGeneral.CurrentRow.Cells("EnvasadoControl2ID").Value)
        End If
        dgvFill()
    End Sub


    Overrides Sub Action(ByVal TipoAction As String)
        Dim m_EnvasadoControle2 As New DBO_EnvasadosControles2
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then

            If m_MaestroID <> 0 Then m_EnvasadoControle2.EnvasadoControlID = m_MaestroID
        Else
            m_EnvasadoControle2 = CType(sp, spEnvasadosControles2).Select_Record(GeneralBindingSource(m_Pos).Item("EnvasadoControl2ID"))
        End If

        frmEnt = New frmEntEnvasadosControles2(TipoAction, m_EnvasadoControle2)
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

                .Columns("EnvasadoControl2ID").Visible = False
                .FormatoColumna("EnvasadoControlID", BasesParaCompatibilidad.TiposColumna.Miles, 50, 1)
                .FormatoGeneral()
            End With
        End If
    End Sub
End Class
