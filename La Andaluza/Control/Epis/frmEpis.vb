Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmEpis
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Public Sub New(Optional ByVal Maestroid As Integer = 0)
        MyBase.New(New spEpis, Maestroid)
        InitializeComponent()
        spSelectDgv = "EpisSelectDgv"
    End Sub

    Protected Overrides Sub cargar_datos()
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dataSource = dtb.Consultar(spSelectDgv, True)
    End Sub

    Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then


            With dgvGeneral

                .DataSource = GeneralBindingSource
                .Columns("EpiID").Visible = False

                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, 200, 1)
                .FormatoColumna("Marca", BasesParaCompatibilidad.TiposColumna.Izquierda, 100, 2)
                .FormatoColumna("EpisTiposDescripcion", "Tipo de Epi", BasesParaCompatibilidad.TiposColumna.Izquierda, 100, 3)
                .FormatoColumna("Usos", BasesParaCompatibilidad.TiposColumna.Izquierda, 200, 4)

                '   .FormatoGeneral()
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
            If CType(sp, spEpis).DeleteEpis(dgvGeneral.CurrentRow.Cells("EpiID").Value, dtb) Then
                dgvFill()
            End If
            'GeneralBindingSource. dataSource = dtb.consultar(spSelectDgv)
        End If
    End Sub



    Public Shadows Sub Action(ByVal TipoAction As String)
        Dim m_Epi As New DBO_Epis
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then
            'Asignar las propiedades del objeto creado cuyos valores se obtengan en este Form.
        Else
            Dim spEpis As New spEpis
            Dim dtb As New BasesParaCompatibilidad.DataBase
            m_Epi = spEpis.Select_Record(GeneralBindingSource(m_Pos).Item("EpiID"), dtb)
        End If

        Dim frmEnt As New frmEntEpis(m_Epi, m_Pos)
        frmEnt.Text = String.Format("{0} {1}", TipoAction, Me.Text)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        dgvFill() ' GeneralBindingSource. dataSource = dtb.consultar(spSelectDgv)
    End Sub



End Class
