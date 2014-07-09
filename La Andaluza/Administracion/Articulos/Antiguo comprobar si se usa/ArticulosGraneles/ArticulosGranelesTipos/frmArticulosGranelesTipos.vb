Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmArticulosGranelesTipos
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private m_VerID As Boolean = True
    Private frmEnt As frmEntArticulosGranelesTipos
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spArticulosGranelesTipos, MaestroID)
        InitializeComponent()

        spSelectDgv = "ArticulosGranelesTiposSelectDgvByGranelTipoID '" & MaestroID & "'"
        m_VerID = False
    End Sub

    Public Sub New()
        MyBase.New(New spArticulosGranelesTipos, 0)
        InitializeComponent()
        spSelectDgv = "ArticulosGranelesTiposSelectDgv"
    End Sub




    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then CType(sp, spArticulosGranelesTipos).ArticulosGranelesTiposDelete(dgvGeneral.CurrentRow.Cells("GranelTipoID").Value)
        dgvFill()
    End Sub



    Overrides Sub Action(ByVal TipoAction As String)
        Dim m_ArticuloGranelTipo As New DBO_ArticulosGranelesTipos
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then

            If m_MaestroID <> 0 Then m_ArticuloGranelTipo.GranelTipoID = m_MaestroID
        Else
            m_ArticuloGranelTipo = CType(sp, spArticulosGranelesTipos).Select_Record(GeneralBindingSource(m_Pos).Item("GranelTipoID"))
        End If

        frmEnt = New frmEntArticulosGranelesTipos(m_ArticuloGranelTipo, m_Pos, m_VerID)
        frmEnt.Text = String.Format("{0} {1}", TipoAction, Me.Text)
        frmEnt.ShowDialog()

        dgvFill()
    End Sub

    Protected Overrides Sub cargar_datos()
        dataSource = dtb.Consultar(spSelectDgv)
    End Sub

    Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource

            butExcel.Visible = True

            With dgvGeneral
                .DataSource = GeneralBindingSource

                .Columns("GranelTipoID").Visible = False
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, 200, 1)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, 200, 2)
                .FormatoGeneral()
            End With
        End If
    End Sub


End Class
