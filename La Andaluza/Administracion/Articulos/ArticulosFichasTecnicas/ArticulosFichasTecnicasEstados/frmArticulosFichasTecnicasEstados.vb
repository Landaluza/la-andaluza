Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmArticulosFichasTecnicasEstados
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private m_VerID As Boolean = True

    Private frmEnt As frmEntArticulosFichasTecnicasEstados
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spArticulosFichasTecnicasEstados, MaestroID)
        InitializeComponent()

        spSelectDgv = "ArticulosFichasTecnicasEstadosSelectDgvByID '" & MaestroID & "'"
        m_VerID = False
    End Sub

    Public Sub New()
        MyBase.New(New spArticulosFichasTecnicasEstados, 0)
        InitializeComponent()
        spSelectDgv = "ArticulosFichasTecnicasEstadosSelectDgv"
    End Sub




    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", _
                           "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then CType(sp, spArticulosFichasTecnicasEstados).ArticulosFichasTecnicasEstadosDelete(dgvGeneral.CurrentRow.Cells("ArticuloFichaTecnicaEstadoID").Value)
        dgvFill()
    End Sub


    Overrides Sub Action(ByVal TipoAction As String)
        Dim m_ArticulosFichasTecnicasEstado As New DBO_ArticulosFichasTecnicasEstados
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then

            'if m_maestroid <> 0 Then m_ArticulosFichasTecnicasEstados.Proveedores_ProveedorID = m_MaestroID
        Else
            m_ArticulosFichasTecnicasEstado = CType(sp, spArticulosFichasTecnicasEstados).Select_Record(GeneralBindingSource(m_Pos).Item("ArticuloFichaTecnicaEstadoID"))
        End If

        frmEnt = New frmEntArticulosFichasTecnicasEstados(m_ArticulosFichasTecnicasEstado, m_Pos, m_VerID)
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

                .Columns("ArticuloFichaTecnicaEstadoID").Visible = False
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, 200, 1)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, 200, 2)
                .FormatoGeneral()
            End With
        End If
    End Sub
End Class
