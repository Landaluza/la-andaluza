Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmRecipientesSalidas
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private ctlRec As ctlRecipientesSalidas
    Private dtsRec As dtsRecipientesSalidas.RecipientesSalidasDataTable


    Public Sub New()
        MyBase.New()
        InitializeComponent()
        ctlRec = New ctlRecipientesSalidas
        dtsRec = New dtsRecipientesSalidas.RecipientesSalidasDataTable
    End Sub
    Protected Overrides Sub cargar_datos()
        ctlRec.mostrarTodosRecipientesSalidas(dtsRec)
    End Sub

    Protected Overrides Sub BindDataSource()
        GeneralBindingSource.DataMember = "RecipientesSalidas"
        GeneralBindingSource.DataSource = dtsRec
        dgvGeneral.DataSource = GeneralBindingSource
        dgvGeneral.ReadOnly = True
        dgvGeneral.Columns("RecipienteSalidaID").Visible = False
        dgvGeneral.FormatoColumna("RecipienteSalidaID", BasesParaCompatibilidad.TiposColumna.Miles)
        dgvGeneral.Columns("Descripcion").Visible = True
        Me.dgvGeneral.FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Descripcion, True)
    End Sub

#Region "Sobrecargas BindingNavigator"

    Overrides Sub Insertar()
        Dim FrmEnt As New frmEntRecipientesSalidas
        FrmEnt.Text = "Insertar Recipientes Salidas"
        FrmEnt.CargarDatos(0, 0, "")
        FrmEnt.ShowDialog()
        ctlRec.mostrarTodosRecipientesSalidas(dtsRec)
        GeneralBindingSource.Position = 1
        GeneralBindingSource.Position = 0
    End Sub

    Overrides Sub Modificar()
        Dim Posicion As Integer = GeneralBindingSource.Position
        If Posicion >= 0 Then
            Dim FrmEnt As New frmEntRecipientesSalidas
            FrmEnt.Text = "Modificar Recipientes Salidas"
            FrmEnt.CargarDatos(Posicion, _
                       dgvGeneral.Rows(Posicion).Cells(0).Value, _
                       Convert.ToString(dgvGeneral.Rows(Posicion).Cells(1).Value))
            FrmEnt.ShowDialog()
            ctlRec.mostrarTodosRecipientesSalidas(dtsRec)
            GeneralBindingSource.Position = 1
            GeneralBindingSource.Position = Posicion
        Else
            MessageBox.Show("Seleccionar alguna celda", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Overrides Sub Ver()
        Dim Posicion As Integer = GeneralBindingSource.Position
        If Posicion >= 0 Then
            Dim FrmEnt As New frmEntRecipientesSalidas
            FrmEnt.Text = "Ver Recipientes Salidas"
            FrmEnt.CargarDatos(Posicion, _
                       dgvGeneral.Rows(Posicion).Cells(0).Value, _
                       Convert.ToString(dgvGeneral.Rows(Posicion).Cells(1).Value))
            FrmEnt.ShowDialog()
        Else
            MessageBox.Show("Seleccionar alguna celda", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Overrides Sub Eliminar()
        Dim Posicion As Integer = GeneralBindingSource.Position
        If Posicion >= 0 Then
            Dim response As DialogResult
            response = MessageBox.Show(" Realmente desea eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = DialogResult.Yes Then
                ctlRec.SetRecipienteSalidaID(dgvGeneral.Rows(Posicion).Cells(0).Value)
                ctlRec.EliminarRecipienteSalida()
                ctlRec.mostrarTodosRecipientesSalidas(dtsRec)
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
