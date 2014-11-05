Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmCamposADD
    Inherits BasesParaCompatibilidad.FrmAheredarOld


    Private m_VerID As Boolean = True

    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spCamposADD, MaestroID)
        InitializeComponent()

        spSelectDgv = "CamposADDSelectDgvByArticuloTipoID '" & MaestroID & "'"
        m_VerID = False
    End Sub

    Public Sub New()
        MyBase.New(New spCamposADD, 0)
        InitializeComponent()
        spSelectDgv = "CamposADDSelectDgv"
    End Sub

    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", _
                          "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim dtb As New BasesParaCompatibilidad.DataBase
            If CType(sp, spCamposADD).CamposADDDelete(dgvGeneral.CurrentRow.Cells("ID").Value, dtb) Then
                dgvFill()
            End If
        End If

    End Sub



    Overrides Sub Action(ByVal TipoAction As String)
        Dim m_CampoADD As New DBO_CamposADD
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then

            If m_MaestroID <> 0 Then m_CampoADD.ArticuloTipoID = m_MaestroID
        Else
            Dim dtb As New BasesParaCompatibilidad.DataBase
            m_CampoADD = CType(sp, spCamposADD).Select_Record(GeneralBindingSource(m_Pos).Item("ID"), dtb)
        End If

        Dim frmEnt As New frmEntCamposADD(m_CampoADD, m_Pos, m_VerID)
        frmEnt.Text = String.Format("{0} {1}", TipoAction, Me.Text)
        'BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        AddHandler frmEnt.FormClosed, AddressOf dgvFill
        GUImain.añadirPestaña(frmEnt)

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


            'GeneralBindingSource. dataSource = dtb.consultar(spSelectDgv)


            butExcel.Visible = True

            With dgvGeneral
                '.Width = 825
                .DataSource = GeneralBindingSource
                .Columns("ID").Visible = False
                .FormatoColumna("Solicitante", BasesParaCompatibilidad.TiposColumna.Izquierda, 162)
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, 157)
                .FormatoColumna("Utilizacion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoGeneral()
            End With
        End If
    End Sub


End Class
