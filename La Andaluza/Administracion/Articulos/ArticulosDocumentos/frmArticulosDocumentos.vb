Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmArticulosDocumentos
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private m_VerID As Boolean = True
    Private tsCarpeta As ToolStripButton
    Private frmEnt As frmEntArticulosDocumentos
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spArticulosDocumentos, MaestroID)
        InitializeComponent()
        spSelectDgv = "ArticulosDocumentosSelectDgvByArticuloID @ArticuloID = " & MaestroID

        m_VerID = False
    End Sub

    Public Sub New()
        MyBase.New(New spArticulosDocumentos, 0)
        InitializeComponent()
        spSelectDgv = "ArticulosDocumentosSelectDgv"
    End Sub

    Private Sub frmArticulosDocumentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        butExcel.Visible = False
        butWord.Visible = False



        tsCarpeta = Me.bdnGeneral.Items.Add("Abre el archivo")
        tsCarpeta.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsCarpeta.ToolTipText = "Abre el archivo"
        tsCarpeta.Image = My.Resources.open
        tsCarpeta.TextDirection = ToolStripTextDirection.Horizontal
        tsCarpeta.TextAlign = ContentAlignment.MiddleRight
        AddHandler tsCarpeta.Click, AddressOf abrirCarpeta
    End Sub

    Private Sub abrirCarpeta()
        If Not IsDBNull(Me.dgvGeneral.CurrentRow.Cells("Ruta").Value) Then
            Try
                Dim s As String() = Convert.ToString(Me.dgvGeneral.CurrentRow.Cells("Ruta").Value).Split("\")
                Dim ruta As String = ""

                For i As Integer = 0 To s.Length - 2
                    ruta = ruta & s(i) & "\"
                Next

                Process.Start(ruta)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Public Overrides Sub Ver()
        Try
            Dim psi As New ProcessStartInfo()
            psi.UseShellExecute = True
            psi.FileName = dgvGeneral.CurrentRow.Cells("Ruta").Value
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", _
                           "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            CType(sp, spArticulosDocumentos).ArticulosDocumentosDelete(dgvGeneral.CurrentRow.Cells("ArticuloDocumentoID").Value)
        End If
        dgvFill()
    End Sub

    Overrides Sub Action(ByVal TipoAction As String)
        Dim m_ArticulosDocumento As New DBO_ArticulosDocumentos
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then
            If m_MaestroID <> 0 Then
                m_ArticulosDocumento.ArticuloID = m_MaestroID
            End If
        Else
            m_ArticulosDocumento = CType(sp, spArticulosDocumentos).Select_Record(GeneralBindingSource(m_Pos).Item("ArticuloDocumentoID"))
        End If

        frmEnt = New frmEntArticulosDocumentos(m_ArticulosDocumento, m_Pos, m_VerID)
        frmEnt.Text = String.Format("{0} {1}", TipoAction, Me.Text)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frmEnt)

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

                .Columns("ArticuloDocumentoID").Visible = False
                .Columns("Ruta").Visible = False
                .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta)
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Fuente", BasesParaCompatibilidad.TiposColumna.Izquierda, 150)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoGeneral()
            End With
        End If
    End Sub


End Class
