Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmArticulosUnidadesMedidas
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private m_VerID As Boolean = True
    Private frmEnt As frmEntArticulosUnidadesMedidas
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spArticulosUnidadesMedidas, MaestroID)
        InitializeComponent()

        spSelectDgv = "ArticulosUnidadesMedidasSelectDgvByArticuloUnidadMedidaID '" & MaestroID & "'"
        m_VerID = False
    End Sub

    Public Sub New()
        MyBase.New(New spArticulosUnidadesMedidas, 0)
        InitializeComponent()
        spSelectDgv = "ArticulosUnidadesMedidasSelectDgv"
    End Sub




    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", _
                           "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            CType(sp, spArticulosUnidadesMedidas).ArticulosUnidadesMedidasDelete(dgvGeneral.CurrentRow.Cells("ArticuloUnidadMedidaID").Value)
        End If
        dgvFill()
    End Sub



    Overrides Sub Action(ByVal TipoAction As String)
        Dim m_ArticuloUnidadeMedida As New DBO_ArticulosUnidadesMedidas
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then

            If m_MaestroID <> 0 Then m_ArticuloUnidadeMedida.ArticuloUnidadMedidaID = m_MaestroID
        Else
            m_ArticuloUnidadeMedida = CType(sp, spArticulosUnidadesMedidas).Select_Record(GeneralBindingSource(m_Pos).Item("ArticuloUnidadMedidaID"))
        End If

        frmEnt = New frmEntArticulosUnidadesMedidas(m_ArticuloUnidadeMedida, m_Pos, m_VerID)
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

                .Columns("ArticuloUnidadMedidaID").Visible = False
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, 200, 1)
                .FormatoColumna("Abreviatura", BasesParaCompatibilidad.TiposColumna.Izquierda, 200, 2)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, 200, 3)
                .FormatoGeneral()
            End With
        End If
    End Sub
End Class
