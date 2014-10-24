Public Class frmControlesPorLote
    Private frmPlantillas As frmTiposControlesLotesPlantilla2
    Private frmResultados As frmControlesLotes
    Private dboLote As DBO_Lotes1
    Private spLotes1 As spLotes1

    Public Sub New(ByVal loteid As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)

        InitializeComponent()

        spLotes1 = New spLotes1
        Me.dboLote = spLotes1.Select_Record(loteid, dtb)
        frmResultados = New frmControlesLotes(loteid)
        frmPlantillas = New frmTiposControlesLotesPlantilla2(dboLote.TipoLoteID, dboLote.TipoProductoID)

        Engine_LA.FormEnPestaña(frmResultados, Panel1)
        Engine_LA.FormEnPestaña(frmPlantillas, Panel2)

        AddHandler frmResultados.insert, AddressOf actualizarDatos
        AddHandler frmPlantillas.SeleccionHecha, AddressOf actualizarDatos 'frmResultados.Insertar
    End Sub

    Private Sub actualizarDatos()
        frmResultados.Plantilla = frmPlantillas.SelectedValue
    End Sub


End Class