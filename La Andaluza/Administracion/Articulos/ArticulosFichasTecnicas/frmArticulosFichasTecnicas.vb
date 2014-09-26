Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmArticulosFichasTecnicas
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private m_VerID As Boolean = True
    Private tsCarpeta As ToolStripButton
    Private frmEnt As frmEntArticulosFichasTecnicas
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spArticulosFichasTecnicas, MaestroID)
        InitializeComponent()
        spSelectDgv = "ArticulosFichasTecnicasSelectDgvByArticuloID '" & MaestroID & "'"

        m_VerID = False

        tsCarpeta = Me.bdnGeneral.Items.Add("Abre el archivo")
        tsCarpeta.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsCarpeta.ToolTipText = "Abre el archivo"
        tsCarpeta.Image = My.Resources.open
        tsCarpeta.TextDirection = ToolStripTextDirection.Horizontal
        tsCarpeta.TextAlign = ContentAlignment.MiddleRight
        AddHandler tsCarpeta.Click, AddressOf abrirCarpeta
    End Sub

    Public Sub New()
        MyBase.New(New spArticulosFichasTecnicas, 0)
        InitializeComponent()
        spSelectDgv = "ArticulosFichasTecnicasSelectDgv"

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
        If MessageBox.Show(" �Realmente quieres eliminar este registro ? ", _
                          "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then CType(sp, spArticulosFichasTecnicas).ArticulosFichasTecnicasDelete(dgvGeneral.CurrentRow.Cells("ArticuloFichaTecnicaID").Value)
        dgvFill()
    End Sub

    Overrides Sub Action(ByVal TipoAction As String)
        Dim m_ArticulosFichasTecnica As New DBO_ArticulosFichasTecnicas
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then
            If m_MaestroID <> 0 Then m_ArticulosFichasTecnica.ArticuloID = m_MaestroID
        Else
            m_ArticulosFichasTecnica = CType(sp, spArticulosFichasTecnicas).Select_Record(GeneralBindingSource(m_Pos).Item("ArticuloFichaTecnicaID"))
        End If

        frmEnt = New frmEntArticulosFichasTecnicas(m_ArticulosFichasTecnica, m_Pos, m_VerID)
        frmEnt.Text = String.Format("{0} {1}", TipoAction, Me.Text)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)

        dgvFill()
    End Sub


    Protected Overrides Sub cargar_datos()
        dataSource = dtb.Consultar(spSelectDgv)
    End Sub

    Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource

            butExcel.Visible = False
            butWord.Visible = False

            With dgvGeneral
                .DataSource = GeneralBindingSource

                .Columns("ArticuloFichaTecnicaID").Visible = False
                .Columns("Ruta").Visible = False
                .FormatoColumna("Proveedor", BasesParaCompatibilidad.TiposColumna.Izquierda, 200)
                .FormatoColumna("Version", BasesParaCompatibilidad.TiposColumna.Derecha, 50)
                .FormatoColumna("Estado", BasesParaCompatibilidad.TiposColumna.Izquierda, 70)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, 380)
                .FormatoGeneral()
            End With
        End If
    End Sub
End Class
