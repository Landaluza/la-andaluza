Imports BasesParaCompatibilidad.DataGridViewExtension


Public Class frmCargaNecesidadesJRMaestro
    inherits BasesParaCompatibilidad.FrmAheredarOld


    Public Sub New()
        MyBase.New(New spCargasNecesidades, 0)
        InitializeComponent()
    End Sub
    Protected Overrides Sub cargar_datos()
        dtb.PrepararConsulta("SelectCargaNecesidadesMaestroByServido")
        dataSource = dtb.Consultar
    End Sub

    Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            HabilitarBotones()
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("MaestroID").Visible = False
                .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 95, 0)
                .FormatoColumna("Hora", BasesParaCompatibilidad.TiposColumna.Hora, 90, 1)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Observaciones, True, 2)
            End With
        End If
    End Sub


#Region "Sobrecargas Metodos del BindingNavigator"
    Overrides Sub Insertar()
        Dim frmEnt As New frmEntCargaNecesidadesJRMaestro
        frmEnt.Text = "Insertar CargaNecesidadesJRMaestro"
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        ' dgvFill()
        GeneralBindingSource.DataSource = dtb.Consultar("SelectCargaNecesidadesMaestroALL", True)
        GeneralBindingSource.MoveLast()
        HabilitarBotones()
    End Sub

    Overrides Sub Modificar()
        Dim currentRow As DataGridViewRow = dgvGeneral.SelectedRows(0)
        Dim frmEnt As New frmEntCargaNecesidadesJRMaestro(currentRow)
        frmEnt.Text = "Modificar CargaNecesidadesJRMaestro"
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Overrides Sub Ver()
        Dim Posicion As Integer = GeneralBindingSource.Position
        Dim frmEnt As New frmEntCargaNecesidadesJRMaestro(GeneralBindingSource.DataSource, Posicion)
        frmEnt.Text = "Ver CargaNecesidadesJRMaestro"
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Overrides Sub Eliminar()
        Dim response As DialogResult
        response = MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", _
                          "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = DialogResult.Yes Then
            CType(sp, spCargasNecesidades).spDeleteCargaNecesidadesJRMaestro(dgvGeneral.CurrentRow.Cells("MaestroID").Value, dtb)
            GeneralBindingSource.DataSource = dtb.Consultar("SelectCargaNecesidadesMaestroALL", True)
        End If
        HabilitarBotones()
    End Sub
#End Region

    Public Sub HabilitarBotones()
        If GeneralBindingSource.Count > 0 Then
            Me.Separator1.Visible = False
            Me.ToolStripSeparator2.Visible = False
            Me.butEliminar.Visible = True
            Me.butModificar.Visible = True
            Me.butVer.Visible = True
        Else
            Me.Separator1.Visible = False
            Me.ToolStripSeparator2.Visible = False
            Me.butEliminar.Visible = False
            Me.butModificar.Visible = False
            Me.butVer.Visible = False
        End If
    End Sub



    Public Overrides Sub Refrescar()
        GeneralBindingSource.DataSource = dtb.Consultar("SelectCargaNecesidadesMaestroALL", True)
        HabilitarBotones()
        With dgvGeneral
            .DataSource = GeneralBindingSource
            .Columns("MaestroID").Visible = False
            .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, , 0)
            .FormatoColumna("Hora", BasesParaCompatibilidad.TiposColumna.Hora, , 1)
            .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Observaciones, True, 2)
        End With
    End Sub

End Class
