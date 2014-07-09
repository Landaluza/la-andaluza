Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmArticulosFichasCondiciones3
    Inherits BasesParaCompatibilidad.FrmAheredarOld


    Private m_VerID As Boolean = True
    Private tsCarpeta As ToolStripButton
    Private frmEnt As frmEntArticulosFichasCondiciones3
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spArticulosFichasCondiciones3, MaestroID)
        InitializeComponent()
        spSelectDgv = "ArticulosFichasCondiciones3SelectDgvByArticuloFichaCondicionID '" & MaestroID & "'"
        m_VerID = False
    End Sub

    Public Sub New()
        MyBase.New(New spArticulosFichasCondiciones3, 0)
        InitializeComponent()
        spSelectDgv = "ArticulosFichasCondiciones3SelectDgv"

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
            If CType(sp, spArticulosFichasCondiciones3).ArticulosFichasCondiciones3Delete((dgvGeneral.CurrentRow.Cells("ArticuloFichaCondicionID").Value)) Then
                dgvFill()
            End If
        End If
    End Sub

    Overrides Sub Action(ByVal TipoAction As String)
        Dim m_ArticulosFichasCondiciones3 As New DBO_ArticulosFichasCondiciones3
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then
            If m_MaestroID <> 0 Then m_ArticulosFichasCondiciones3.ArticuloID = m_MaestroID
        Else
            m_ArticulosFichasCondiciones3 = CType(sp, spArticulosFichasCondiciones3).Select_Record(GeneralBindingSource(m_Pos).Item("ArticuloFichaCondicionID"))
        End If

        frmEnt = New frmEntArticulosFichasCondiciones3(m_ArticulosFichasCondiciones3, m_Pos, m_VerID)
        frmEnt.Text = String.Format("{0} {1}", TipoAction, Me.Text)
        frmEnt.ShowDialog()

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
                .Columns("ArticuloFichaCondicionID").Visible = False

                If m_MaestroID = 0 Then 'Desde un menu directo "ArticulosFichasCondiciones3SelectDgv"
                    .FormatoColumna("DescripcionLA", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 0)
                    .FormatoColumna("Proveedor", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 1)
                    .FormatoColumna("EurosUnidad", BasesParaCompatibilidad.TiposColumna.Double5, 90, 2)
                    .FormatoColumna("Medida", BasesParaCompatibilidad.TiposColumna.Izquierda, 70, 3)
                    .FormatoColumna("FechaInicio", BasesParaCompatibilidad.TiposColumna.FechaCorta, 85, 4)
                    .FormatoColumna("PrecioAnterior", BasesParaCompatibilidad.TiposColumna.Double5, 200, 5)
                    .FormatoColumna("Incremento", BasesParaCompatibilidad.TiposColumna.Double2, 50, 6)
                    .FormatoColumna("Vigente", BasesParaCompatibilidad.TiposColumna.Centro, 50, 7)
                    .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 38)
                Else 'Desde una pestaña "ArticulosFichasCondiciones3SelectDgvByArticuloFichaCondicionID '" & MaestroID & "'"
                    .Columns("Ruta").Visible = False
                    .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 0, 150)
                    .FormatoColumna("Proveedor", BasesParaCompatibilidad.TiposColumna.Izquierda, 200, 1)
                    .FormatoColumna("EurosUnidad", BasesParaCompatibilidad.TiposColumna.Double5, 90, 2)
                    .FormatoColumna("Medida", BasesParaCompatibilidad.TiposColumna.Izquierda, 70, 3)
                    .FormatoColumna("FechaInicio", BasesParaCompatibilidad.TiposColumna.FechaCorta, , 4)
                    .FormatoColumna("PrecioAnterior", BasesParaCompatibilidad.TiposColumna.Double5, 200, 5)
                    .FormatoColumna("Incremento", BasesParaCompatibilidad.TiposColumna.Double2, 50, 6)
                    .FormatoColumna("Vigente", BasesParaCompatibilidad.TiposColumna.Centro, 50, 7)
                    .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 8, 181)
                End If

            End With
        End If
    End Sub


End Class
