Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmCargaNecesidadesJR2Maestro
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private m_VerID As Boolean = True
    Private frmEnt As frmEntCargaNecesidadesJR2Maestro
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spCargaNecesidadesJR2Maestro, MaestroID)
        InitializeComponent()


        spSelectDgv = "CargaNecesidadesJRMaestroSelectDgvByID '" & MaestroID & "'"
        m_VerID = False
    End Sub

    Public Sub New()
        MyBase.New(New spCargaNecesidadesJR2Maestro, 0)
        InitializeComponent()
        spSelectDgv = "CargaNecesidadesJRMaestroSelectDgv"
    End Sub




    Overrides Sub Eliminar()
        'Hay que hacer la eliminacion en cascada
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            CType(sp, spCargaNecesidadesJR2Maestro).CargaNecesidadesJRMaestroDelete(dgvGeneral.CurrentRow.Cells("CargaNecesidadesJRMaestroID").Value)
        End If
        dgvFill()
    End Sub


    Overrides Sub Action(ByVal TipoAction As String)
        Dim m_CargaNecesidadesJRMaestro As New DBO_CargaNecesidadesJR2Maestro
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then

            If m_MaestroID <> 0 Then m_CargaNecesidadesJRMaestro.CargaNecesidadesJRMaestroID = m_MaestroID
        Else
            m_CargaNecesidadesJRMaestro = CType(sp, spCargaNecesidadesJR2Maestro).Select_Record(GeneralBindingSource(m_Pos).Item("CargaNecesidadesJRMaestroID"))
        End If

        frmEnt = New frmEntCargaNecesidadesJR2Maestro(m_CargaNecesidadesJRMaestro, m_Pos, m_VerID)
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
                .Width = 800
                .DataSource = GeneralBindingSource
                .Columns("CargaNecesidadesJRMaestroID").Visible = False
                .Columns("Hora").Visible = False
                .Columns("Reserva1").Visible = False
                .Columns("Reserva2").Visible = False
                .Columns("Reserva3").Visible = False
                .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.Izquierda, 130, 0)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, 180, 1)
                .FormatoGeneral()
            End With
        End If
    End Sub
End Class
