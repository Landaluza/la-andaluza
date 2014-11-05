Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmVisitasRegistros
    Inherits BasesParaCompatibilidad.FrmAheredarOld


    Private m_VerID As Boolean = True
    Private frmEnt As frmEntVisitasRegistros
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spVisitasRegistros, MaestroID)
        InitializeComponent()
        spSelectDgv = "VisitasRegistrosSelectDgvByEmpresaID '" & MaestroID & "'"

        m_VerID = False
    End Sub

    Public Sub New()
        MyBase.New(New spVisitasRegistros, 0)
        InitializeComponent()
        spSelectDgv = "VisitasRegistrosSelectDgv"
    End Sub

    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim dtb As New BasesParaCompatibilidad.DataBase
            If CType(sp, spVisitasRegistros).VisitasRegistrosDelete(dgvGeneral.CurrentRow.Cells("VisitaRegistroID").Value, dtb) Then
                dgvFill()
            End If
        End If

    End Sub


    Overrides Sub Action(ByVal TipoAction As String)
        Dim m_VisitaRegistro As New DBO_VisitasRegistros
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then
            If m_MaestroID <> 0 Then m_VisitaRegistro.EmpresaID = m_MaestroID
        Else
            Dim dtb As New BasesParaCompatibilidad.DataBase
            m_VisitaRegistro = CType(sp, spVisitasRegistros).Select_Record(GeneralBindingSource(m_Pos).Item("VisitaRegistroID"), dtb)
        End If

        frmEnt = New frmEntVisitasRegistros(m_VisitaRegistro, m_Pos, m_VerID)
        frmEnt.Text = String.Format("{0} {1}", TipoAction, Me.Text)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)


        dgvFill()
    End Sub

    Protected Overrides Sub cargar_datos()
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dtb.PrepararConsulta(spSelectDgv)
        dataSource = dtb.Consultar()
    End Sub

    Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource


            butExcel.Visible = True

            With dgvGeneral
                .DataSource = GeneralBindingSource

                .Columns("VisitaRegistroID").Visible = False
                .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("Entrada", BasesParaCompatibilidad.TiposColumna.Hora, 80)
                .FormatoColumna("Salida", BasesParaCompatibilidad.TiposColumna.Hora, 80)
                .FormatoColumna("Tipo", BasesParaCompatibilidad.TiposColumna.Izquierda, 80)
                .FormatoColumna("Empresa", BasesParaCompatibilidad.TiposColumna.Izquierda, 200)
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, 200)
                .FormatoColumna("Motivo", BasesParaCompatibilidad.TiposColumna.Izquierda, 200)
                .FormatoColumna("Responsable", BasesParaCompatibilidad.TiposColumna.Izquierda, 200)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 100, 140)
                .FormatoGeneral()
            End With
        End If
    End Sub


End Class
