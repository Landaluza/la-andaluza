Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmControlesEntregasEpis
    Inherits BasesParaCompatibilidad.FrmAheredarOld


    Public Sub New()
        MyBase.New(New spControlesEntregasEpis, 0)
        InitializeComponent()
        spSelectDgv = "ControlesEntregasEpisSelectDgv"
    End Sub
    Protected Overrides Sub cargar_datos()
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dtb.PrepararConsulta(spSelectDgv)
        dataSource = dtb.Consultar()
    End Sub

    Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then

            With dgvGeneral

                .DataSource = GeneralBindingSource
                .Columns("ControlEntregaEpiID").Visible = False
                .FormatoColumna("FechaEntrega", BasesParaCompatibilidad.TiposColumna.Derecha, 80, 1)
                .FormatoColumna("Descripcion", "EPIS", BasesParaCompatibilidad.TiposColumna.Izquierda, 100, 2)
                .FormatoColumna("Nombre", "Empleado", BasesParaCompatibilidad.TiposColumna.Izquierda, 100, 3)
            End With


            butExcel.Visible = True
        End If
    End Sub

    'Overrides Sub Insertar()
    '    Action(ACCION_INSERTAR)
    '    GeneralBindingSource.MoveLast()
    'End Sub

    'Overrides Sub Modificar()
    '    Action(ACCION_MODIFICAR)
    'End Sub

    'Overrides Sub Ver()
    '    Action(ACCION_VER)
    'End Sub

    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim dtb As New BasesParaCompatibilidad.DataBase
            If CType(sp, spControlesEntregasEpis).DeleteControlesEntregasEpis(dgvGeneral.CurrentRow.Cells("ControlEntregaEpiID").Value, dtb) Then
                dgvFill()
            End If
            ' GeneralBindingSource. dataSource = dtb.consultar(spSelectDgv)
        End If

    End Sub


    Public Shadows Sub Action(ByVal TipoAction As String)
        Dim m_ControlesEntregasEpi As New DBO_ControlesEntregasEpis
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then
            'Asignar las propiedades del objeto creado cuyos valores se obtengan en este Form.
        Else
            Dim dtb As New BasesParaCompatibilidad.DataBase
            m_ControlesEntregasEpi = CType(sp, spControlesEntregasEpis).Select_Record(GeneralBindingSource(m_Pos).Item("ControlEntregaEpiID"), dtb)
        End If

        Dim frmEnt As New frmEntControlesEntregasEpis(m_ControlesEntregasEpi, m_Pos)
        frmEnt.Text = String.Format("{0} {1}", TipoAction, Me.Text)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        dgvFill() 'GeneralBindingSource. dataSource = dtb.consultar(spSelectDgv)
    End Sub



End Class
