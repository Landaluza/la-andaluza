Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmPaletsMovimientoSubTipo
    Inherits BasesParaCompatibilidad.FrmAheredarOld


    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spPaletsMovimientoSubTipo, MaestroID)
        InitializeComponent()

        spSelectDgv = "PaletsMovimientoSubTipoByTipo '" & MaestroID & "'"

    End Sub

    Public Sub New()
        MyBase.New(New spPaletsMovimientoSubTipo, 0)
        InitializeComponent()

        spSelectDgv = "PaletsMovimientoSubTipoSelectDgv"
    End Sub

    Protected Overrides Sub cargar_datos()
        dataSource = dtb.Consultar(spSelectDgv, True)
    End Sub

    Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource

            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("ID").Visible = False
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, 200, 2)
                .FormatoGeneral()
            End With
        End If
    End Sub

    Overrides Sub Insertar()
        Action(ACCION_INSERTAR)
        GeneralBindingSource.DataSource = dtb.Consultar(spSelectDgv, True)

    End Sub

    Overrides Sub Modificar()
        Action(ACCION_MODIFICAR)
        GeneralBindingSource.DataSource = dtb.Consultar(spSelectDgv, True)
    End Sub

    Overrides Sub Ver()
        Action(ACCION_VER)
    End Sub

    Overrides Sub Eliminar()
        Dim response As DialogResult
        response = MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", _
                          "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = DialogResult.Yes Then
            CType(sp, spPaletsMovimientoSubTipo).DeletePaletsMovimientoSubTipo(dgvGeneral.CurrentRow.Cells("ID").Value)
            GeneralBindingSource.DataSource = dtb.Consultar(spSelectDgv, True)
        End If
    End Sub

    Public Overrides Sub Action(ByVal TipoAction As String)
        Dim m_ID As Int32

        'm_ID = if(dgvGeneral.RowCount > 0, dgvGeneral.CurrentRow.Cells("ID").Value, 0)
        If dgvGeneral.RowCount > 0 Then
            m_ID = dgvGeneral.CurrentRow.Cells("ID").Value
        Else
            m_ID = 0
        End If

        Dim frmEnt As New frmEntPaletsMovimientoSubTipo(m_ID, m_MaestroID)
        If TipoAction = ACCION_MODIFICAR Then
            frmEnt.Text = String.Format("Modificar {0}", Me.Text)
        ElseIf TipoAction = ACCION_VER Then
            frmEnt.Text = String.Format("Ver {0}", Me.Text)
        Else
            frmEnt.Text = String.Format("Insertar {0}", Me.Text)
        End If
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub



End Class
