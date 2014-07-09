Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmAlbaranCargaProMaestro
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private ctlAlb As ctlAlbaranCargaProMaestro
    Private dtsAlb As dtsAlbaranCargaProMaestro.AlbaranCargaProMaestroDataTable


    Public Sub New()
        MyBase.New()
        InitializeComponent()
        ctlAlb = New ctlAlbaranCargaProMaestro
        dtsAlb = New dtsAlbaranCargaProMaestro.AlbaranCargaProMaestroDataTable
    End Sub
    Protected Overrides Sub cargar_datos()
        ctlAlb.mostrarTodosAlbaranCargaProMaestro(dtsAlb)
    End Sub
    Protected Overrides Sub BindDataSource()

        GeneralBindingSource.DataMember = "AlbaranCargaProMaestro"
        GeneralBindingSource.DataSource = dtsAlb
        dgvGeneral.DataSource = GeneralBindingSource
        dgvGeneral.ReadOnly = True

        With dgvGeneral
            .Columns("AlbaranCargaProMaestroID").Visible = False
            .FormatoColumna("Numero", "Num", BasesParaCompatibilidad.TiposColumna.Derecha, 40, 0)
            .FormatoColumna("Fecha", "Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, , 1)
            .FormatoColumna("ResponsableCargaID", "Quien carga", BasesParaCompatibilidad.TiposColumna.Izquierda, 150, 2)
            .FormatoColumna("Observaciones", "Observaciones", BasesParaCompatibilidad.TiposColumna.Observaciones, 300, 3)
            dgvGeneral.Columns("Reserva1").Visible = False
            dgvGeneral.Columns("Reserva2").Visible = False
            dgvGeneral.Columns("Reserva3").Visible = False
            .FormatoGeneral()
        End With
    End Sub
#Region "Sobrecargas BindingNavigator"

    Overrides Sub Insertar()
        Dim FrmEnt As New frmEntAlbaranCargaProMaestro
        FrmEnt.Text = ACCION_INSERTAR & " AlbaranCargaProMaestro"
        FrmEnt.CargarDatos(0, 0, 0, Today, 0, "", "", "", "")
        FrmEnt.ShowDialog()
        ctlAlb.mostrarTodosAlbaranCargaProMaestro(dtsAlb)
        GeneralBindingSource.Position = 1
        GeneralBindingSource.Position = 0
    End Sub

    Overrides Sub Modificar()
        Dim Posicion As Integer = GeneralBindingSource.Position
        If Posicion >= 0 Then
            Dim FrmEnt As New frmEntAlbaranCargaProMaestro
            FrmEnt.Text = ACCION_MODIFICAR & " AlbaranCargaProMaestro"
            FrmEnt.CargarDatos(Posicion, _
                               dgvGeneral.Rows(Posicion).Cells(0).Value, _
                               dgvGeneral.Rows(Posicion).Cells(1).Value, _
                               dgvGeneral.Rows(Posicion).Cells(2).Value, _
                               dgvGeneral.Rows(Posicion).Cells(3).Value, _
                               dgvGeneral.Rows(Posicion).Cells(4).Value, _
                               dgvGeneral.Rows(Posicion).Cells(5).Value, _
                               dgvGeneral.Rows(Posicion).Cells(6).Value, _
                               dgvGeneral.Rows(Posicion).Cells(7).Value)
            FrmEnt.ShowDialog()
            ctlAlb.mostrarTodosAlbaranCargaProMaestro(dtsAlb)
            GeneralBindingSource.Position = 1
            GeneralBindingSource.Position = Posicion
        Else
            MessageBox.Show("Seleccionar alguna celda", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Overrides Sub Ver()
        Dim Posicion As Integer = GeneralBindingSource.Position
        If Posicion >= 0 Then
            Dim FrmEnt As New frmEntAlbaranCargaProMaestro
            FrmEnt.Text = ACCION_VER & " AlbaranCargaProMaestro"
            FrmEnt.CargarDatos(Posicion, _
                               dgvGeneral.Rows(Posicion).Cells(0).Value, _
                               dgvGeneral.Rows(Posicion).Cells(1).Value, _
                               dgvGeneral.Rows(Posicion).Cells(2).Value, _
                               dgvGeneral.Rows(Posicion).Cells(3).Value, _
                               dgvGeneral.Rows(Posicion).Cells(4).Value, _
                               dgvGeneral.Rows(Posicion).Cells(5).Value, _
                               dgvGeneral.Rows(Posicion).Cells(6).Value, _
                               dgvGeneral.Rows(Posicion).Cells(7).Value)
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
                ctlAlb.SetAlbaranCargaProMaestroID(dgvGeneral.Rows(Posicion).Cells(0).Value)
                ctlAlb.EliminarAlbaranCargaProMaestro()
                ctlAlb.mostrarTodosAlbaranCargaProMaestro(dtsAlb)
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
