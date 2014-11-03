Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmCompuestoPor
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private frmEnt As frmEntCompuestoPor
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spCompuestoPor, MaestroID)
        InitializeComponent()
        spSelectDgv = "CompuestoPorSelectDgvByLotePartida '" & MaestroID & "'"

    End Sub

    Public Sub New()
        MyBase.New(New spCompuestoPor, 0)
        InitializeComponent()
        spSelectDgv = "CompuestoPorSelectDgv"
    End Sub

    Private Sub frmCompuestoPor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        butExcel.Visible = True

    End Sub

    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim dtb As New BasesParaCompatibilidad.DataBase
            If CType(sp, spCompuestoPor).CompuestoPorDelete(dgvGeneral.CurrentRow.Cells("LoteFinal").Value, dgvGeneral.CurrentRow.Cells("LotePartida").Value, dgvGeneral.CurrentRow.Cells("MovimientoID").Value, dtb) Then
                dgvFill()
            End If
        End If
    End Sub


    Overrides Sub Action(ByVal TipoAction As String)
        Dim m_DBO_CompuestoPor As New DBO_CompuestoPor

        If TipoAction = ACCION_INSERTAR Then
            If m_MaestroID <> 0 Then m_DBO_CompuestoPor.LotePartida = m_MaestroID
        Else
            Dim dtb As New BasesParaCompatibilidad.DataBase
            m_DBO_CompuestoPor = CType(sp, spCompuestoPor).Select_Record(dgvGeneral.CurrentRow.Cells("LoteFinal").Value, dgvGeneral.CurrentRow.Cells("LotePartida").Value, dgvGeneral.CurrentRow.Cells("MovimientoID").Value, dtb)
        End If

        frmEnt = New frmEntCompuestoPor(m_DBO_CompuestoPor)
        frmEnt.Text = String.Format("{0} {1}", TipoAction, Me.Text)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)

        dgvFill()
    End Sub

    Protected Overrides Sub cargar_datos()
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dataSource = dtb.Consultar(spSelectDgv, True)
    End Sub

    Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource


            With dgvGeneral
                .DataSource = GeneralBindingSource

                .Columns("LoteFinal").Visible = False
                .Columns("LotePartida").Visible = False
                .Columns("MovimientoID").Visible = False
                .FormatoColumna("Cantidad", BasesParaCompatibilidad.TiposColumna.Double2, 50)
            End With

        End If
    End Sub




End Class
