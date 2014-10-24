Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmArticulos_ArticulosCertificadosTipos
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private m_VerID As Boolean = True
    Private frmEnt As frmEntArticulos_ArticulosCertificadosTipos
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spArticulos_ArticulosCertificadosTipos, MaestroID)
        InitializeComponent()

        spSelectDgv = "Articulos_ArticulosCertificadosTiposSelectDgvByArticuloID '" & MaestroID & "'"

        m_VerID = False
    End Sub

    Public Sub New()
        MyBase.New(New spArticulos_ArticulosCertificadosTipos, 0)
        InitializeComponent()
        spSelectDgv = "Articulos_ArticulosCertificadosTiposSelectDgv"
    End Sub




    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", _
                            "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then CType(sp, spArticulos_ArticulosCertificadosTipos).Articulos_ArticulosCertificadosTiposDelete(dgvGeneral.CurrentRow.Cells("Articulo_ArticuloCertificadoTipoID").Value, dtb)
        dgvFill()
    End Sub



    Overrides Sub Action(ByVal TipoAction As String)
        Dim m_Articulo_ArticuloCertificadoTipo As New DBO_Articulos_ArticulosCertificadosTipos
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then

            If m_MaestroID <> 0 Then m_Articulo_ArticuloCertificadoTipo.ArticuloID = m_MaestroID
        Else
            m_Articulo_ArticuloCertificadoTipo = CType(sp, spArticulos_ArticulosCertificadosTipos).Select_Record(GeneralBindingSource(m_Pos).Item("Articulo_ArticuloCertificadoTipoID"), dtb)
        End If

        frmEnt = New frmEntArticulos_ArticulosCertificadosTipos(m_Articulo_ArticuloCertificadoTipo, m_Pos, m_VerID)
        frmEnt.Text = String.Format("{0} {1}", TipoAction, Me.Text)
        'BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frmEnt)


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

                .Columns("Articulo_ArticuloCertificadoTipoID").Visible = False
                .FormatoColumna("ArticuloID", BasesParaCompatibilidad.TiposColumna.Miles, 50, 1)
                .FormatoColumna("ArticuloCertificadoTipoID", BasesParaCompatibilidad.TiposColumna.Miles, 50, 2)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, 200, 3)
                .FormatoGeneral()
            End With
        End If
    End Sub
End Class
