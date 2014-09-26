Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmSistemasIndustriales
    Inherits BasesParaCompatibilidad.FrmAheredarOld


    Public Sub New()
        MyBase.New(New spSistemasIndustriales, 0)
        InitializeComponent()
        spSelectDgv = "SistemasIndustrialesSelectDgv"
    End Sub
    Protected Overrides Sub cargar_datos()
        dataSource = dtb.Consultar(spSelectDgv)
    End Sub

    Protected Overrides Sub dgvFill()
        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource

            With dgvGeneral

                .DataSource = GeneralBindingSource
                .Columns("SistemaIndustrialID").Visible = False
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, 200, 1)
                .FormatoColumna("FechaInstalacion", BasesParaCompatibilidad.TiposColumna.Derecha, 50, 2)
                .FormatoColumna("FechaRegistroIndustria", BasesParaCompatibilidad.TiposColumna.Derecha, 50, 3)
                .FormatoColumna("ReferenciaExpedienteIndustria", BasesParaCompatibilidad.TiposColumna.Izquierda, 200, 4)
                .FormatoColumna("ReferenciaRegistroIndustria", BasesParaCompatibilidad.TiposColumna.Izquierda, 200, 5)
                .FormatoColumna("FechaPresentacionIndustria", BasesParaCompatibilidad.TiposColumna.Derecha, 50, 6)
                .FormatoColumna("AutorProyecto", BasesParaCompatibilidad.TiposColumna.Izquierda, 200, 7)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, 200, 8)
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
            If CType(sp, spSistemasIndustriales).DeleteSistemasIndustriales(dgvGeneral.CurrentRow.Cells("SistemaIndustrialID").Value) Then
                dgvFill()
            End If
            ' GeneralBindingSource. dataSource = dtb.Consultar(spSelectDgv)
        End If

    End Sub


    Public Overrides Sub Action(ByVal TipoAction As String)
        Dim m_SistemasIndustriale As New DBO_SistemasIndustriales
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then
            'Asignar las propiedades del objeto creado cuyos valores se obtengan en este Form.
        Else
            m_SistemasIndustriale = CType(sp, spSistemasIndustriales).Select_Record(GeneralBindingSource(m_Pos).Item("SistemaIndustrialID"))
        End If

        Dim frmEnt As New frmEntSistemasIndustriales(m_SistemasIndustriale, m_Pos)
        frmEnt.Text = String.Format("{0} {1}", TipoAction, Me.Text)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        dgvFill() 'GeneralBindingSource. dataSource = dtb.Consultar(spSelectDgv)
    End Sub



End Class
