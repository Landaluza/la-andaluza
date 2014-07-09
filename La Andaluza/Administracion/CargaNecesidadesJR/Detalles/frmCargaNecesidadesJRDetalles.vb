Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmCargaNecesidadesJRDetalles
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private ctlCar As ctlCargaNecesidadesJRDetalles
    Private dtsCar As dtsCargaNecesidadesJRDetalles.CargaNecesidadesJRDetallesDataTable

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        ctlCar = New ctlCargaNecesidadesJRDetalles
        dtsCar = New dtsCargaNecesidadesJRDetalles.CargaNecesidadesJRDetallesDataTable
    End Sub

    Private Sub frmCargaNecesidadesJRDetalles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "CargaNecesidadesJRDetalles"

    End Sub

    Protected Overrides Sub cargar_datos()
        ctlCar.mostrarTodosCargaNecesidadesJRDetalles(dtsCar)
    End Sub

    Protected Overrides Sub BindDataSource()
        GeneralBindingSource.DataMember = "CargaNecesidadesJRDetalles"
        GeneralBindingSource.DataSource = dtsCar
        dgvGeneral.DataSource = GeneralBindingSource
        dgvGeneral.ReadOnly = True
        dgvGeneral.Columns("CargaNecesidadesJRDetalleID").Visible = False
        dgvGeneral.FormatoColumna("CargaNecesidadesJRDetalleID", BasesParaCompatibilidad.TiposColumna.Miles)
        dgvGeneral.Columns("CargaNecesidadesJRMaestroID").Visible = True
        dgvGeneral.FormatoColumna("CargaNecesidadesJRMaestroID", BasesParaCompatibilidad.TiposColumna.Miles)
        dgvGeneral.Columns("ArticuloID").Visible = True
        dgvGeneral.FormatoColumna("ArticuloID", BasesParaCompatibilidad.TiposColumna.Miles)
        dgvGeneral.Columns("Carga").Visible = True
        dgvGeneral.FormatoColumna("Carga", BasesParaCompatibilidad.TiposColumna.Miles)
        dgvGeneral.Columns("Stock").Visible = True
        dgvGeneral.FormatoColumna("Stock", BasesParaCompatibilidad.TiposColumna.Miles)
        dgvGeneral.Columns("Observaciones").Visible = True
        dgvGeneral.Columns("Reserva1").Visible = True
        dgvGeneral.Columns("Reserva2").Visible = True
        dgvGeneral.Columns("Reserva3").Visible = True
    End Sub

#Region "Sobrecargas BindingNavigator"



    Overrides Sub Eliminar()
        Dim Posicion As Integer = GeneralBindingSource.Position
        If Posicion >= 0 Then
            Dim response As DialogResult
            response = MessageBox.Show(" Realmente desea eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = DialogResult.Yes Then
                ctlCar.SetCargaNecesidadesJRDetalleID(dgvGeneral.Rows(Posicion).Cells(0).Value)
                ctlCar.EliminarCargaNecesidadesJRDetalle()
                ctlCar.mostrarTodosCargaNecesidadesJRDetalles(dtsCar)
                If Posicion > 0 Then
                    GeneralBindingSource.Position = Posicion - 1
                Else
                    GeneralBindingSource.Position = 0
                End If
            End If
        Else
            MessageBox.Show("Seleccionar alguna celda", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
#End Region


End Class
