Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmArticulosCertificadosTipos
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private m_VerID As Boolean = True
    Private frmEnt As frmEntArticulosCertificadosTipos
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spArticulosCertificadosTipos, MaestroID)
        InitializeComponent()

        spSelectDgv = "ArticulosCertificadosTiposSelectDgvByID '" & MaestroID & "'"

        m_VerID = False
    End Sub

    Public Sub New()
        MyBase.New(New spArticulosCertificadosTipos, 0)
        InitializeComponent()
        spSelectDgv = "ArticulosCertificadosTiposSelectDgv"
    End Sub




    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then CType(sp, spArticulosCertificadosTipos).ArticulosCertificadosTiposDelete((dgvGeneral.CurrentRow.Cells("ArticuloCertificadoTipoID").Value))
        dgvFill()
    End Sub


    Overrides Sub Action(ByVal TipoAction As String)
        Dim m_ArticuloCertificadoTipo As New DBO_ArticulosCertificadosTipos
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then

            If m_MaestroID <> 0 Then m_ArticuloCertificadoTipo.Descripcion = Convert.ToString(m_MaestroID)
        Else
            m_ArticuloCertificadoTipo = CType(sp, spArticulosCertificadosTipos).Select_Record((GeneralBindingSource(m_Pos).Item("ArticuloCertificadoTipoID")))
        End If

        frmEnt = New frmEntArticulosCertificadosTipos(m_ArticuloCertificadoTipo, m_Pos, m_VerID)
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

                .Columns("ArticuloCertificadoTipoID").Visible = False
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, 200, 1)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, 200, 2)
                .FormatoGeneral()
            End With
        End If
    End Sub
End Class
