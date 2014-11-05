Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmProveedoresTipos
    Inherits BasesParaCompatibilidad.FrmAheredarOld


    Private m_VerID As Boolean = True
    Private frmEnt As frmEntProveedoresTipos
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spProveedoresTipos, MaestroID)
        InitializeComponent()

        spSelectDgv = "ProveedoresTiposSelectDgvByID '" & MaestroID & "'"
        m_VerID = False
    End Sub

    Public Sub New()
        MyBase.New(New spProveedoresTipos, 0)
        InitializeComponent()
        spSelectDgv = "ProveedoresTiposSelectDgv"
    End Sub




    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim dtb As New BasesParaCompatibilidad.DataBase
            If CType(sp, spProveedoresTipos).ProveedoresTiposDelete(dgvGeneral.CurrentRow.Cells("ProveedorTipoID").Value, dtb) Then
                dgvFill()
            End If
        End If
    End Sub


    Overrides Sub Action(ByVal TipoAction As String)
        Dim m_ProveedorTipo As New DBO_ProveedoresTipos
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then

            If m_MaestroID <> 0 Then m_ProveedorTipo.Descripcion = m_MaestroID
        Else
            Dim dtb As New BasesParaCompatibilidad.DataBase
            m_ProveedorTipo = CType(sp, spProveedoresTipos).Select_Record(GeneralBindingSource(m_Pos).Item("ProveedorTipoID"), dtb)
        End If

        frmEnt = New frmEntProveedoresTipos(m_ProveedorTipo, m_Pos, m_VerID)
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

                .Columns("ProveedorTipoID").Visible = False
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, 200, 1)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 2)
                .FormatoGeneral()
            End With
        End If
    End Sub

End Class
