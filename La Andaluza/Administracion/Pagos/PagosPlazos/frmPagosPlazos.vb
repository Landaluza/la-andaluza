Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmPagosPlazos
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private m_VerID As Boolean = True
    Private m_PagosPlazos As DBO_PagosPlazos
    Private frmEnt As frmEntPagosPlazos
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spPagosPlazos, MaestroID)
        InitializeComponent()
        spSelectDgv = "PagosPlazosSelectDgvByID '" & MaestroID & "'"

        m_VerID = False
    End Sub
    Public Sub New()
        MyBase.New(New spPagosPlazos, 0)
        InitializeComponent()
        spSelectDgv = "PagosPlazosSelectDgv"
    End Sub


    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", _
                           "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim dtb As New BasesParaCompatibilidad.DataBase
            If CType(sp, spPagosPlazos).PagosPlazosDelete(dgvGeneral.CurrentRow.Cells("PagoPlazoID").Value, dtb) Then
                dgvFill()
            End If
        End If
    End Sub

    Overrides Sub Action(ByVal TipoAction As String)
        m_PagosPlazos = New DBO_PagosPlazos
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then

            If m_MaestroID <> 0 Then m_PagosPlazos.Descripcion = m_MaestroID
        Else
            Dim dtb As New BasesParaCompatibilidad.DataBase
            m_PagosPlazos = CType(sp, spPagosPlazos).Select_Record(GeneralBindingSource(m_Pos).Item("PagoPlazoID"), dtb)
        End If

        frmEnt = New frmEntPagosPlazos(m_PagosPlazos, m_Pos, m_VerID)
        frmEnt.Text = String.Format("{0} {1}", TipoAction, Me.Text)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)

        dgvFill()
    End Sub

    Protected Overrides Sub cargar_datos()
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dataSource = dtb.Consultar(spSelectDgv, True)
    End Sub
    Protected Overrides Sub dgvFill()
        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            butExcel.Visible = True

            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("PagoPlazoID").Visible = False
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 1, 200)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 2, 380)
                .FormatoGeneral()
            End With
        End If
    End Sub


End Class
