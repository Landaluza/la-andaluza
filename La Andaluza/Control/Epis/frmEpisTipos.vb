Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmEpisTipos
    Inherits BasesParaCompatibilidad.FrmAheredarOld


    Public Sub New()
        MyBase.New(New spEpisTipos, 0)
        InitializeComponent()

        spSelectDgv = "EpisTiposSelectDgv"
    End Sub
    Protected Overrides Sub cargar_datos()
        dataSource = dtb.Consultar(spSelectDgv, True)
    End Sub

    Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then

            With dgvGeneral

                .DataSource = GeneralBindingSource
                .Columns("EpiTipoID").Visible = False
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, 200, 1)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, 200, 2)
                .FormatoGeneral()
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
        If MessageBox.Show(" �Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then CType(sp, spEpisTipos).DeleteEpisTipos(dgvGeneral.CurrentRow.Cells("EpiTipoID").Value)
        dgvFill() ' GeneralBindingSource. dataSource = dtb.consultar(spSelectDgv)
    End Sub



    Public Shadows Sub Action(ByVal TipoAction As String)
        Dim m_EpisTipo As New DBO_EpisTipos
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then
            'Asignar las propiedades del objeto creado cuyos valores se obtengan en este Form.
        Else
            m_EpisTipo = CType(sp, spEpisTipos).Select_Record(GeneralBindingSource(m_Pos).Item("EpiTipoID"))
        End If

        Dim frmEnt As New frmEntEpisTipos(m_EpisTipo, m_Pos)
        frmEnt.Text = String.Format("{0} {1}", TipoAction, Me.Text)
        frmEnt.ShowDialog()
        dgvFill() 'GeneralBindingSource. dataSource = dtb.consultar(spSelectDgv)
    End Sub



End Class
