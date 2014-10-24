Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmPagosFormas
    Inherits BasesParaCompatibilidad.FrmAheredarOld


    Private m_VerID As Boolean = True
    Private m_PagosFormas As DBO_PagosFormas
    Private frmEnt As frmEntPagosFormas
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spPagosFormas, MaestroID)
        InitializeComponent()
        spSelectDgv = "PagosFormasSelectDgvByID '" & MaestroID & "'"

        m_VerID = False
    End Sub

    Public Sub New()
        MyBase.New(New spPagosFormas, 0)
        InitializeComponent()
        spSelectDgv = "PagosFormasSelectDgv"
    End Sub

    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If CType(sp, spPagosFormas).PagosFormasDelete(dgvGeneral.CurrentRow.Cells("PagoFormaID").Value, dtb) Then
                dgvFill()
            End If
        End If
    End Sub
    Overrides Sub Action(ByVal TipoAction As String)
        m_PagosFormas = New DBO_PagosFormas
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then
            If m_MaestroID <> 0 Then m_PagosFormas.Descripcion = m_MaestroID
        Else
            m_PagosFormas = CType(sp, spPagosFormas).Select_Record(GeneralBindingSource(m_Pos).Item("PagoFormaID"), dtb)
        End If

        frmEnt = New frmEntPagosFormas(m_PagosFormas, m_Pos, m_VerID)
        frmEnt.Text = String.Format("{0} {1}", TipoAction, Me.Text)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)


        dgvFill()
    End Sub

    Protected Overrides Sub cargar_datos()
        dataSource = dtb.Consultar(spSelectDgv, True)
    End Sub
    Protected Overrides Sub BindDataSource()

        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            butExcel.Visible = True

            With dgvGeneral
                .DataSource = GeneralBindingSource

                .Columns("PagoFormaID").Visible = False
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 1, 200)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 2, 380)
            End With
        End If
    End Sub

End Class
