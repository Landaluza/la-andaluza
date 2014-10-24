Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmOrdenesCarga
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private m_VerID As Boolean = True
    Private frmEnt As frmEntOrdenesCarga
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spOrdenesCarga, MaestroID)
        InitializeComponent()
        spSelectDgv = "OrdenesCargaSelectDgvByID '" & MaestroID & "'"

        m_VerID = False
    End Sub

    Public Sub New()
        MyBase.New(New spOrdenesCarga, 0)
        InitializeComponent()
        spSelectDgv = "OrdenesCargaSelectDgv"
    End Sub

    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If CType(sp, spOrdenesCarga).OrdenesCargaDelete(dgvGeneral.CurrentRow.Cells("OrdenCargaID").Value, dtb) Then
                dgvFill()
            End If
        End If
    End Sub

    Overrides Sub Action(ByVal TipoAction As String)
        Dim m_OrdeneCarga As New DBO_OrdenesCarga
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If Not TipoAction = ACCION_INSERTAR Then
            m_OrdeneCarga = CType(sp, spOrdenesCarga).Select_Record(GeneralBindingSource(m_Pos).Item("OrdenCargaID"), dtb)
        End If

        frmEnt = New frmEntOrdenesCarga(m_OrdeneCarga, m_Pos, m_VerID)
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

                .Columns("OrdenCargaID").Visible = False
                .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 85, 1)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
            End With
        End If
    End Sub


End Class
