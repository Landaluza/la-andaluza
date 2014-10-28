Imports BasesParaCompatibilidad.DataGridViewExtension
Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntCargaNecesidadesJRMaestro
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_currentRow As DataGridViewRow
    Private m_MaestroID As Integer = 1 'Lo hago = 1 solamente para que no de error al llamar a Update
    Private m_Tabla As DataTable
    Private m_Posicion As Integer
    Private YaGuardado As Boolean = False
    Private sp As New spCargasNecesidades

    Public Sub New() 'Insertar
        InitializeComponent()
        dtb = New BasesParaCompatibilidad.DataBase()

        Me.FechaDateTimePicker.activarFoco()
        Me.HoraDateTimePicker.activarFoco()
    End Sub

    Public Sub New(ByVal currentRow As DataGridViewRow) 'Modificar
        InitializeComponent()
        dtb = New BasesParaCompatibilidad.DataBase()

        m_currentRow = currentRow
        Me.FechaDateTimePicker.activarFoco()
        Me.HoraDateTimePicker.activarFoco()
    End Sub

    Public Sub New(ByVal Tabla As DataTable, ByVal Posicion As Integer) 'Ver
        InitializeComponent()
        dtb = New BasesParaCompatibilidad.DataBase()

        m_Tabla = Tabla
        m_Posicion = Posicion
        Me.FechaDateTimePicker.activarFoco()
        Me.HoraDateTimePicker.activarFoco()
    End Sub

    Private Sub frmEntCargaNecesidadesJRMaestro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ModificarBindingNavigator()

        If Me.Text.Substring(0, 3) = "Mod" Then
            CargaNecesidadesJRMaestroIDCuadroDeTexto.Text = m_currentRow.Cells("MaestroID").Value
            FechaDateTimePicker.Value = m_currentRow.Cells("Fecha").Value
            HoraDateTimePicker.Value = DateTime.Now.Date.Add(CType(m_currentRow.Cells("Hora").Value, TimeSpan))
            ObservacionesCuadroDeTexto.Text = m_currentRow.Cells("Observaciones").Value
            ServidoCheckBox.Checked = m_currentRow.Cells("Servido").Value
        ElseIf Me.Text.Substring(0, 3) = "Ver" Then
            GeneralBindingSource.DataSource = m_Tabla
            GeneralBindingSource.Position = m_Posicion
        End If

        If Me.Text.Substring(0, 3) = "Mod" Or Me.Text.Substring(0, 3) = "Ver" Then
            With dgv
                dtb.PrepararConsulta("SelectCargaNecesidadesDetallesByMaestroID @id")
                dtb.AñadirParametroConsulta("@id", CargaNecesidadesJRMaestroIDCuadroDeTexto.Text)
                .DataSource = dtb.Consultar()
                .Columns("DetalleID").Visible = False
                .Columns("MaestroID").Visible = False
                .FormatoColumna("Descripcion", "Articulo", BasesParaCompatibilidad.TiposColumna.Izquierda, 450, 2)
                .FormatoColumna("Carga", "Carga", BasesParaCompatibilidad.TiposColumna.Miles, , 3)
                .FormatoColumna("Stock", "Stock", BasesParaCompatibilidad.TiposColumna.Miles, , 4)
                .FormatoColumna("Observaciones", "Observaciones", BasesParaCompatibilidad.TiposColumna.Observaciones, 300, 5)
                .FormatoGeneral()
            End With
            m_MaestroID = CargaNecesidadesJRMaestroIDCuadroDeTexto.Text
        End If
        HabilitarBotonesDetalle()

    End Sub

    Overrides Sub Guardar()
        If Not YaGuardado Then
            Dim Action As Integer
            If Me.Text.Substring(0, 3) = "Ins" Then
                Action = Me.sp.insert
            ElseIf Me.Text.Substring(0, 3) = "Mod" Then
                Action = Me.sp.Update
                m_currentRow.Cells("MaestroID").Value = Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.Text
                m_currentRow.Cells("Fecha").Value = Me.FechaDateTimePicker.Value
                m_currentRow.Cells("Hora").Value = New TimeSpan(HoraDateTimePicker.Value.Hour, HoraDateTimePicker.Value.Minute, 0)
                m_currentRow.Cells("Observaciones").Value = Me.ObservacionesCuadroDeTexto.Text
                m_currentRow.Cells("Servido").Value = Me.ServidoCheckBox.Checked
            End If

            If Not Me.sp.spCargaNecesidadesJRMaestro(Action, _
                                        m_MaestroID, _
                                        FechaDateTimePicker.Value, _
                                        HoraDateTimePicker.Value, _
                                        ObservacionesCuadroDeTexto.Text, _
                                        Now(), _
                                        1, _
                                        Me.ServidoCheckBox.Checked, dtb) Then
                MessageBox.Show("No se pudo realizar la operacion", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            'Si entro en insertar por primer vez, busco el ultimo registro añadido y utilizo su ID 
            If dgv.RowCount = 0 Then
                tsInsertar.Enabled = True
                CargaNecesidadesJRMaestroIDCuadroDeTexto.Text = Me.sp.spMaxCargaNecesidadesMaestro(dtb)
                m_MaestroID = CargaNecesidadesJRMaestroIDCuadroDeTexto.Text
                YaGuardado = True
            Else
                Me.Close()
            End If
        Else
            Me.Close()
        End If

    End Sub

    Private Sub tsInsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsInsertar.Click
        Dim FrmEnt As New frmEntCargaNecesidadesJRDetalles(m_MaestroID)
        FrmEnt.Text = "Insertar"
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        FrmEnt.Dispose()
        dtb.PrepararConsulta("SelectCargaNecesidadesDetallesByMaestroID @id")
        dtb.AñadirParametroConsulta("@id", m_MaestroID)
        dgv.DataSource = dtb.Consultar
        dgv.MoveLast()
    End Sub

    Private Sub tsModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsModificar.Click
        Dim currentRow As DataGridViewRow = dgv.CurrentRow
        Dim frmEnt As New frmEntCargaNecesidadesJRDetalles(currentRow)
        frmEnt.Text = "Modificar"
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        frmEnt.Dispose()
    End Sub

    Private Sub tsEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsEliminar.Click
        Dim Posicion As Integer = dgv.CurrentRow.Index
        Dim DetalleID As String = Convert.ToString(dgv.Rows(Posicion).Cells("DetalleID").Value)

        Dim response As DialogResult
        response = MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", _
                          "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = DialogResult.Yes Then
            Me.sp.spDeleteCargaNecesidadesJRDetalle(DetalleID, dtb)
            dtb.PrepararConsulta("SelectCargaNecesidadesDetallesByMaestroID @id")
            dtb.AñadirParametroConsulta("@id", m_MaestroID)
            dgv.DataSource = dtb.Consultar
        End If
    End Sub

    Private Sub dgv_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgv.RowsAdded
        HabilitarBotonesDetalle()
    End Sub

    Private Sub dgv_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgv.RowsRemoved
        HabilitarBotonesDetalle()
    End Sub

    Sub HabilitarBotonesDetalle()
        If Me.Text.Substring(0, 3) = "Ver" Then
            tsFormatos1.Enabled = False
        ElseIf Me.Text.Substring(0, 3) = "Ins" Then
            tsFormatos1.Enabled = True
            If Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.Text = "" Then
                tsInsertar.Enabled = False
                tsModificar.Enabled = False
                tsEliminar.Enabled = False
            Else
                tsInsertar.Enabled = True
                If dgv.RowCount > 0 Then
                    tsModificar.Enabled = True
                    tsEliminar.Enabled = True
                Else
                    tsModificar.Enabled = False
                    tsEliminar.Enabled = False
                End If
            End If
        ElseIf Me.Text.Substring(0, 3) = "Mod" Then
            tsFormatos1.Enabled = True
            tsInsertar.Enabled = True
            If dgv.RowCount > 0 Then
                tsModificar.Enabled = True
                tsEliminar.Enabled = True
            Else
                tsModificar.Enabled = False
                tsEliminar.Enabled = False
            End If
        End If
    End Sub

End Class
