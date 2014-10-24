Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmLotesEnologico
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private ctlLot As ctlLotes
    Private dtsLot As dtsLotes.LotesDataTable
    Private Posicion As Integer
    Private FrmEnt As frmEntLotesEnologicos

    Public Sub New()
        MyBase.New()
        InitializeComponent()

        ctlLot = New ctlLotes
        dtsLot = New dtsLotes.LotesDataTable

    End Sub
    Protected Overrides Sub cargar_datos()
        ctlLot.mostrarTodosLotesEnologicos(dtb, dtsLot)
    End Sub

    Protected Overrides Sub BindDataSource()
        GeneralBindingSource.DataMember = "Lotes"
        GeneralBindingSource.DataSource = dtsLot
        With dgvGeneral
            .DataSource = GeneralBindingSource

            .Columns("LoteID").Visible = False
            .Columns("Descripcion").Visible = False
            .Columns("Fecha").Visible = True
            .Columns("CantidadRestante").Visible = True
            .Columns("Observacion").Visible = False
            .Columns("Botellas").Visible = False
            .Columns("Cantidad").Visible = True
            .Columns("Medida").Visible = False
            .Columns("Especificacion").Visible = False
            .Columns("TipoLote").Visible = False
            .Columns("TipoProducto").Visible = True
            .FormatoColumna("TipoProducto", BasesParaCompatibilidad.TiposColumna.Derecha, True)
            .Columns("Corredor").Visible = False
            .Columns("Proveedor").Visible = True
            .FormatoColumna("Proveedor", BasesParaCompatibilidad.TiposColumna.Derecha, True)
            .Columns("LoteConjuntoCompra").Visible = False
            .Columns("SinEspecificacion").Visible = False
            .Columns("CodigoLote").Visible = True
            .Columns("DepositoID").Visible = False
            .Columns("LoteProveedor").Visible = True
            .FormatoColumna("LoteProveedor", BasesParaCompatibilidad.TiposColumna.Derecha, True)
            .Columns("Referencia").Visible = False
            .Columns("DepositoPrevio").Visible = False
            .Columns("RecipienteSalidaID").Visible = False

            .Columns("Fecha").DisplayIndex = 1
            .Columns("CodigoLote").DisplayIndex = 2
            .Columns("Cantidad").DisplayIndex = 3

            .Columns("CantidadRestante").HeaderText = "Quedan"

            .FormatoColumna("CantidadRestante", BasesParaCompatibilidad.TiposColumna.Miles, 100)
            .FormatoColumna("CodigoLote", BasesParaCompatibilidad.TiposColumna.Miles, 135)

            .ReadOnly = True
        End With

        Me.butNuevo.Enabled = False
        Me.butModificar.Enabled = False
        Me.butEliminar.Enabled = False
    End Sub
#Region "Sobrecargas BindingNavigator"
    'Overrides Sub Insertar()
    '    LlamarCargar(ACCION_INSERTAR)
    '    ctlLot.mostrarTodosLotesEnologicos(dtsLot)
    '    GeneralBindingSource.Position = 1
    '    GeneralBindingSource.Position = 0
    'End Sub

    'Overrides Sub Modificar()
    '    LlamarCargar(ACCION_MODIFICAR)
    '    ctlLot.mostrarTodosLotesEnologicos(dtsLot)
    '    GeneralBindingSource.Position = 1
    '    GeneralBindingSource.Position = Posicion
    'End Sub

    Overrides Sub Ver()
        LlamarCargar(ACCION_VER)
    End Sub

    'Overrides Sub Eliminar()
    '    Dim Posicion As Integer = GeneralBindingSource.Position
    '    If Posicion >= 0 Then
    '        Dim response As DialogResult
    '        response = MessageBox.Show(" ¿Realmente desea eliminar este registro? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    '        If response = DialogResult.Yes Then
    '            ctlLot.EliminarLote(dgvGeneral.Rows(Posicion).Cells(0).Value)
    '            ctlLot.mostrarTodosLotesEnologicos(dtsLot)
    '            If Posicion > 0 Then
    '                GeneralBindingSource.Position = Posicion - 1
    '            Else
    '                GeneralBindingSource.Position = 0
    '            End If
    '        End If
    '    Else
    '        MessageBox.Show("Seleccionar alguna celda", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '    End If
    'End Sub

    Sub LlamarCargar(ByVal Tipo As String)
        Posicion = GeneralBindingSource.Position
        If Posicion >= 0 Then
            FrmEnt = New frmEntLotesEnologicos
            FrmEnt.Text = Tipo & " Lotes Enologicos"
            If Tipo <> ACCION_INSERTAR Then
                FrmEnt.CargarDatos(Posicion, _
                                   dgvGeneral.Rows(Posicion).Cells("LoteID").Value, _
                                   dgvGeneral.Rows(Posicion).Cells("Descripcion").Value, _
                                   dgvGeneral.Rows(Posicion).Cells("Fecha").Value, _
                                   dgvGeneral.Rows(Posicion).Cells("CantidadRestante").Value, _
                                   dgvGeneral.Rows(Posicion).Cells("TipoLote").Value, _
                                   dgvGeneral.Rows(Posicion).Cells("TipoProducto").Value, _
                                   dgvGeneral.Rows(Posicion).Cells("Proveedor").Value, _
                                   dgvGeneral.Rows(Posicion).Cells("CodigoLote").Value, _
                                   dgvGeneral.Rows(Posicion).Cells("LoteProveedor").Value)
            Else
                FrmEnt.CargarDatos(0, 0, "", Today, 0, 0, 0, 0, "", "")
            End If
            BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Else
            MessageBox.Show("Seleccionar alguna celda", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
#End Region


End Class
