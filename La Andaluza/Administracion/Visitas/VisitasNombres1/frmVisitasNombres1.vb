Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmVisitasNombres1
    Inherits BasesParaCompatibilidad.FrmAheredarOld


    Private frmEnt As frmEntVisitasNombres1
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spVisitasNombres1, MaestroID)
        InitializeComponent()
        spSelectDgv = "VisitasNombres1SelectDgvByID '" & MaestroID & "'"

    End Sub

    Public Sub New()
        MyBase.New(New spVisitasNombres1, 0)
        InitializeComponent()
        spSelectDgv = "VisitasNombres1SelectDgv"
    End Sub

    Private Sub frmVisitasNombres1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        butExcel.Visible = True

    End Sub

    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim dtb As New BasesParaCompatibilidad.DataBase
            If CType(sp, spVisitasNombres1).VisitasNombres1Delete(dgvGeneral.CurrentRow.Cells("VisitaNombreID").Value, dtb) Then
                dgvFill()
            End If
        End If
    End Sub



    Overrides Sub Action(ByVal TipoAction As String)
        Dim m_VisitaNombre1 As New DBO_VisitasNombres1

        If TipoAction = ACCION_INSERTAR Then
            If m_MaestroID <> 0 Then m_VisitaNombre1.EmpresaID = m_MaestroID
        Else
            Dim dtb As New BasesParaCompatibilidad.DataBase
            m_VisitaNombre1 = CType(sp, spVisitasNombres1).Select_Record(dgvGeneral.CurrentRow.Cells("VisitaNombreID").Value, dtb)
        End If

        frmEnt = New frmEntVisitasNombres1(m_VisitaNombre1, If(m_VisitaNombre1.VisitaTipoID.HasValue, m_VisitaNombre1.VisitaTipoID, -1))
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

                .Columns("VisitaNombreID").Visible = False
                .FormatoColumna("TipoVisita", BasesParaCompatibilidad.TiposColumna.Izquierda, 80)
                .FormatoColumna("Empresa", BasesParaCompatibilidad.TiposColumna.Izquierda, 200)
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, 200)
                .FormatoColumna("DNI", BasesParaCompatibilidad.TiposColumna.Izquierda, 200)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 100, 150)
            End With
        End If
    End Sub




End Class
