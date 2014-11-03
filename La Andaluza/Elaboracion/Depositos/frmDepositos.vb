Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmDepositos
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private Posicion As Integer
    Private ctlDep As ctlDepositos
    Private dtsDep As dtsDepositos.DepositosDataTable


    Public Sub New()
        MyBase.New()
        InitializeComponent()
        ctlDep = New ctlDepositos
        dtsDep = New dtsDepositos.DepositosDataTable
    End Sub

    Protected Overrides Sub cargar_datos()
        Dim dtb As New BasesParaCompatibilidad.DataBase
        ctlDep.mostrarTodosDepositos(dtb, dtsDep)
        'dataSource = dtsDep
    End Sub

    Protected Overrides Sub BindDataSource()
        If Not dtsDep Is Nothing Then
            GeneralBindingSource.DataMember = "Depositos"
            GeneralBindingSource.DataSource = dtsDep

            ' GeneralBindingSource.DataSource = dtsDep
            dgvGeneral.DataSource = GeneralBindingSource

            dgvGeneral.Columns("DepositoID").Visible = False
            dgvGeneral.Columns("Codigo").Visible = True
            dgvGeneral.Columns("FechaCreacion").Visible = False
            dgvGeneral.Columns("Capacidad").Visible = True
            dgvGeneral.Columns("DoctoUbicacionFisica").Visible = False
            dgvGeneral.Columns("TonelID").Visible = False
            dgvGeneral.Columns("TransicubaID").Visible = False
            dgvGeneral.Columns("BotaID").Visible = False
            dgvGeneral.Columns("BotaPiernaID").Visible = False
            dgvGeneral.Columns("Tipo").Visible = True
            dgvGeneral.Columns("MaterialConstruccionID").Visible = False
            dgvGeneral.Columns("listado").Visible = True
            dgvGeneral.ReadOnly = True


            dgvGeneral.FormatoColumna("Codigo", BasesParaCompatibilidad.TiposColumna.Derecha, True)
            dgvGeneral.FormatoColumna("Capacidad", BasesParaCompatibilidad.TiposColumna.Miles, True)
            dgvGeneral.FormatoColumna("Tipo", BasesParaCompatibilidad.TiposColumna.Centro, True)
            dgvGeneral.FormatoColumna("listado", "Listado", BasesParaCompatibilidad.TiposColumna.Centro, True)
        End If
    End Sub
#Region "Sobrecargas BindingNavigator"

    Overrides Sub Insertar()
        LlamarCargar(ACCION_INSERTAR)
        Dim dtb As New BasesParaCompatibilidad.DataBase
        ctlDep.mostrarTodosDepositos(dtb, dtsDep)
        GeneralBindingSource.Position = 1
        GeneralBindingSource.Position = 0
    End Sub

    Overrides Sub Modificar()
        LlamarCargar(ACCION_MODIFICAR)
        Dim dtb As New BasesParaCompatibilidad.DataBase
        ctlDep.mostrarTodosDepositos(dtb, dtsDep)
        GeneralBindingSource.Position = 1
        GeneralBindingSource.Position = Posicion
    End Sub

    Overrides Sub Ver()
        LlamarCargar(ACCION_VER)
    End Sub

    Overrides Sub Eliminar()
        Dim Posicion As Integer = GeneralBindingSource.Position
        If Posicion >= 0 Then
            Dim response As DialogResult
            response = MessageBox.Show(" ¿Realmente desea eliminar este registro? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If response = DialogResult.Yes Then
                ctlDep.SetDepositoID(dgvGeneral.Rows(Posicion).Cells(0).Value)
                Dim dtb As New BasesParaCompatibilidad.DataBase
                If ctlDep.EliminarDeposito(dtb) Then
                    ctlDep.mostrarTodosDepositos(dtb, dtsDep)
                    If Posicion > 0 Then
                        GeneralBindingSource.Position = Posicion - 1
                    Else
                        GeneralBindingSource.Position = 0
                    End If
                End If
            End If
        Else
            MessageBox.Show("Seleccionar alguna celda", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
#End Region

    Sub LlamarCargar(ByVal Tipo As String)
        Posicion = GeneralBindingSource.Position
        If Posicion >= 0 Then
            Dim FrmEnt As New frmEntDepositos
            FrmEnt.Text = Tipo & " Depositos"
            If Tipo <> ACCION_INSERTAR Then
                Try
                    FrmEnt.CargarDatos(Posicion, _
                                       dgvGeneral.Rows(Posicion).Cells(0).Value, _
                                       dgvGeneral.Rows(Posicion).Cells(1).Value, _
                                       dgvGeneral.Rows(Posicion).Cells(2).Value, _
                                       dgvGeneral.Rows(Posicion).Cells(3).Value, _
                                       dgvGeneral.Rows(Posicion).Cells(4).Value, _
                                       dgvGeneral.Rows(Posicion).Cells(5).Value, _
                                       dgvGeneral.Rows(Posicion).Cells(6).Value, _
                                       dgvGeneral.Rows(Posicion).Cells(7).Value, _
                                       dgvGeneral.Rows(Posicion).Cells(9).Value, _
                                       dgvGeneral.Rows(Posicion).Cells(10).Value, _
                                       dgvGeneral.Rows(Posicion).Cells(11).Value)
                Catch ex As Exception
                    MessageBox.Show("Problemas en los datos del deposito", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
            Else
                FrmEnt.CargarDatos(0, _
                                   0, _
                                   0, _
                                   DateTime.Now, _
                                   0, _
                                   "", _
                                   0, _
                                   0, _
                                   0, _
                                   0, _
                                   0, _
                                   False)
            End If
            BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Else
            MessageBox.Show("Seleccionar alguna celda", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    'Private Sub dgvGeneral_CellContentDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
    '    Modificar()
    'End Sub
End Class
