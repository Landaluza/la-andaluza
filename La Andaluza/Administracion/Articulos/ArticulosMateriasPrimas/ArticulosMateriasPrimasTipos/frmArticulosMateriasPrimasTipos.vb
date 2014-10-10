Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmArticulosMateriasPrimasTipos
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private m_VerID As Boolean = True
    Private m_ArticuloMateriaPrimaTipo As DBO_ArticulosMateriasPrimasTipos
    Private frmEnt As frmEntArticulosMateriasPrimasTipos
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spArticulosMateriasPrimasTipos, MaestroID)
        InitializeComponent()

        spSelectDgv = "ArticulosMateriasPrimasTiposSelectDgvByMateriaPrimaTipoID '" & MaestroID & "'"
        m_VerID = False
    End Sub

    Public Sub New()
        MyBase.New(New spArticulosMateriasPrimasTipos, 0)
        InitializeComponent()
        spSelectDgv = "ArticulosMateriasPrimasTiposSelectDgv"
    End Sub



    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If CType(sp, spArticulosMateriasPrimasTipos).ArticulosMateriasPrimasTiposDelete(dgvGeneral.CurrentRow.Cells("MateriaPrimaTipoID").Value, dtb) Then
                dgvFill()
            End If
        End If
    End Sub



    Overrides Sub Action(ByVal TipoAction As String)
        m_ArticuloMateriaPrimaTipo = New DBO_ArticulosMateriasPrimasTipos
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then

            If m_MaestroID <> 0 Then m_ArticuloMateriaPrimaTipo.MateriaPrimaTipoID = m_MaestroID
        Else
            m_ArticuloMateriaPrimaTipo = CType(sp, spArticulosMateriasPrimasTipos).Select_Record(GeneralBindingSource(m_Pos).Item("MateriaPrimaTipoID"), dtb)
        End If

        frmEnt = New frmEntArticulosMateriasPrimasTipos(m_ArticuloMateriaPrimaTipo, m_Pos, m_VerID)
        frmEnt.Text = String.Format("{0} {1}", TipoAction, Me.Text)
        'BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        AddHandler frmEnt.FormClosed, AddressOf dgvFill
        GUImain.añadirPestaña(frmEnt)

        ''dgvFill()
    End Sub

    Protected Overrides Sub cargar_datos()
        dtb.PrepararConsulta(spSelectDgv)
        dataSource = dtb.Consultar
        'dataSource = dtb.Consultar(spSelectDgv, True)
    End Sub
    Protected Overrides Sub BindDataSource()

        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            'GeneralBindingSource. dataSource = dtb.consultar(spSelectDgv)

            butExcel.Visible = True

            With dgvGeneral
                .DataSource = GeneralBindingSource

                .Columns("MateriaPrimaTipoID").Visible = False
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 1)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 4)

            End With
        End If
    End Sub




End Class
