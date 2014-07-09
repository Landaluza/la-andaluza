Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmEnvasadosControles
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private m_LineaID As Integer
    Private m_DBO_EnvasadoControlLinea As Object
    Private m_FormLinea As Object
    Private padre As frmEntFormatosEnvasados2
    Private frmEnt As frmEntEnvasadosControles
    Public Sub New(ByVal MaestroID As Integer, ByVal LineaID As Integer, Optional embebido As Boolean = False, Optional padre As frmEntFormatosEnvasados2 = Nothing)
        MyBase.New(New spEnvasadosControles, MaestroID)
        InitializeComponent()
        spSelectDgv = "EnvasadosControlesSelectDgvByFormatoEnvasadoID '" & MaestroID & "'"

        m_LineaID = LineaID

        Me.Embebido = embebido
        Me.padre = padre

    End Sub


    Private Sub frmEnvasadosControles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        butExcel.Visible = False
        butWord.Visible = False
    End Sub

    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If CType(sp, spEnvasadosControles).EnvasadosControlesDelete(dgvGeneral.CurrentRow.Cells("EnvasadoControlID").Value) Then
                dgvFill()
            End If
        End If
    End Sub

    Overrides Sub Action(ByVal TipoAction As String)
        Dim m_EnvasadoControles As New DBO_EnvasadosControles
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then
            If m_MaestroID <> 0 Then m_EnvasadoControles.FormatoEnvasadoID = m_MaestroID
        Else
            m_EnvasadoControles = CType(sp, spEnvasadosControles).Select_Record(GeneralBindingSource(m_Pos).Item("EnvasadoControlID"))
        End If

        'Como el Form auxiliar depende de la linea.
        'Defino aqui el DBO detalle y el Form auxiliar del detalle
        'Los paso como parametros a frmEntEnvasadosControles
        Select Case m_LineaID
            Case Is = 1
                Dim spEnvasadosControles1 As New spEnvasadosControles1
                'Hay que comentar esta linea  "DBO_EnvasadosControles1 = Nothing" en el sp correspondiente
                m_DBO_EnvasadoControlLinea = spEnvasadosControles1.SelectByEnvasadoControlID(m_EnvasadoControles.EnvasadoControlID)
                m_FormLinea = New frmEntEnvasadosControles1(TipoAction, m_DBO_EnvasadoControlLinea)
            Case Is = 2
                Dim spEnvasadosControles2 As New spEnvasadosControles2
                m_DBO_EnvasadoControlLinea = spEnvasadosControles2.SelectByEnvasadoControlID(m_EnvasadoControles.EnvasadoControlID)
                m_FormLinea = New frmEntEnvasadosControles2(TipoAction, m_DBO_EnvasadoControlLinea)
            Case Is = 3 'Ulma
                Dim spEnvasadosControlesUlma As New spEnvasadosControlesUlma
                m_DBO_EnvasadoControlLinea = spEnvasadosControlesUlma.SelectByEnvasadoControlID(m_EnvasadoControles.EnvasadoControlID)
                m_FormLinea = New frmEntEnvasadosControlesUlma(TipoAction, m_DBO_EnvasadoControlLinea)
            Case Is = 5 'Imar
                Dim spEnvasadosControlesImar As New spEnvasadosControlesImar
                m_DBO_EnvasadoControlLinea = spEnvasadosControlesImar.SelectByEnvasadoControlID(m_EnvasadoControles.EnvasadoControlID)
                m_FormLinea = New frmEntEnvasadosControlesImar(TipoAction, m_DBO_EnvasadoControlLinea)
        End Select

        frmEnt = New frmEntEnvasadosControles(TipoAction, m_EnvasadoControles, m_DBO_EnvasadoControlLinea, m_FormLinea)
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

                .Columns("EnvasadoControlID").Visible = False
                .FormatoColumna("Responsable", BasesParaCompatibilidad.TiposColumna.Izquierda, 150, 1)
                .FormatoColumna("Hora", BasesParaCompatibilidad.TiposColumna.Hora, 85, 2)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 3)
                .FormatoGeneral()
            End With
        End If
    End Sub


End Class
