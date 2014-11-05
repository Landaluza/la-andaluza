Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmTurnosTrabajo
    Inherits BasesParaCompatibilidad.FrmAheredarOld


    Private m_VerID As Boolean = True
    Private m_TurnosTrabajo As DBO_TurnosTrabajo
    Private frmEnt As frmEntTurnosTrabajo
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spTurnosTrabajo, MaestroID)
        InitializeComponent()
        spSelectDgv = "TurnosTrabajoSelectDgvByID '" & MaestroID & "'"

        m_VerID = False
    End Sub

    Public Sub New()
        MyBase.New(New spTurnosTrabajo, 0)
        InitializeComponent()
        spSelectDgv = "TurnosTrabajoSelectDgv"
    End Sub



    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim dtb As New BasesParaCompatibilidad.DataBase
            If CType(sp, spTurnosTrabajo).TurnosTrabajoDelete(dgvGeneral.CurrentRow.Cells("TurnoTrabajoID").Value, dtb) Then
                dgvFill()
            End If
        End If
    End Sub
    Overrides Sub Action(ByVal TipoAction As String)
        m_TurnosTrabajo = New DBO_TurnosTrabajo
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then
            If m_MaestroID <> 0 Then m_TurnosTrabajo.TurnoTrabajoID = m_MaestroID
        Else
            Dim dtb As New BasesParaCompatibilidad.DataBase
            m_TurnosTrabajo = CType(sp, spTurnosTrabajo).Select_Record(GeneralBindingSource(m_Pos).Item("TurnoTrabajoID"), dtb)
        End If

        frmEnt = New frmEntTurnosTrabajo(m_TurnosTrabajo, m_Pos, m_VerID)
        frmEnt.Text = String.Format("{0} {1}", TipoAction, Me.Text)
        AddHandler frmEnt.FormClosed, AddressOf dgvFill
        'BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        GUImain.añadirPestaña(frmEnt)


        'dgvFill()
    End Sub

    Protected Overrides Sub cargar_datos()
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dtb.PrepararConsulta(spSelectDgv)
        dataSource = dtb.Consultar()
    End Sub
    Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            'GeneralBindingSource. dataSource = dtb.consultar(spSelectDgv)

            butExcel.Visible = True

            With dgvGeneral
                '.Width = 542
                .DataSource = GeneralBindingSource
                .Columns("TurnoTrabajoID").Visible = False
                .FormatoColumna("Ano", "Año", BasesParaCompatibilidad.TiposColumna.FechaCorta, 80, 1)
                .FormatoColumna("Semana", BasesParaCompatibilidad.TiposColumna.Miles, 50, 2)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 3)

            End With
        End If
    End Sub

End Class
