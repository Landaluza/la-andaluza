Public Class frnEtiquetaEditable
    Public Dataset As etiquetas.LADataSet
    Public Sub New(ByVal dataset As etiquetas.LADataSet)

        InitializeComponent()

        Me.Dataset = dataset
    End Sub

    Private Sub frnEtiquetaEditable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.Dataset.EtiquetasPaletSelect(0).IsmarcaNull Then
            Me.lMarca.Text = ""
        Else
            Me.lMarca.Text = Me.Dataset.EtiquetasPaletSelect(0).marca
        End If

        If Me.Dataset.EtiquetasPaletSelect(0).IsproductoNull Then
            Me.lProducto.Text = ""
        Else
            Me.lProducto.Text = Me.Dataset.EtiquetasPaletSelect(0).producto
        End If

        If Me.Dataset.EtiquetasPaletSelect(0).IsbotellasNull Then
            Me.lCajasBotellas.Text = ""
        Else
            Me.lCajasBotellas.Text = Me.Dataset.EtiquetasPaletSelect(0).botellas
        End If

        If Me.Dataset.EtiquetasPaletSelect(0).IspaletNull Then
            Me.lPalet.Text = ""
        Else
            Me.lPalet.Text = Me.Dataset.EtiquetasPaletSelect(0).palet
        End If

        If Me.Dataset.EtiquetasPaletSelect(0).IscajasNull Then
            Me.lnCajas.Text = ""
        Else
            Me.lnCajas.Text = Me.Dataset.EtiquetasPaletSelect(0).cajas
        End If

        If Me.Dataset.EtiquetasPaletSelect(0).IscantidadBotellasNull Then
            Me.lnBotellas.Text = ""
        Else
            Me.lnBotellas.Text = Me.Dataset.EtiquetasPaletSelect(0).cantidadBotellas
        End If

        If Me.Dataset.EtiquetasPaletSelect(0).Isean13Null Then
            Me.lean13.Text = ""
            Me.lean13.Enabled = False
        Else
            Me.lean13.Text = Me.Dataset.EtiquetasPaletSelect(0).ean13
        End If

        If Me.Dataset.EtiquetasPaletSelect(0).Isean14Null Then
            Me.lean14.Text = ""
            Me.lean14.Enabled = False
        Else
            Me.lean14.Text = Me.Dataset.EtiquetasPaletSelect(0).ean14
        End If


        Me.llote.Text = Dataset.EtiquetasPaletSelect(0).loteTexto
        Me.lscc.Text = Dataset.EtiquetasPaletSelect(0).SCC.Substring(12, 5)

        If Dataset.EtiquetasPaletSelect(0).IscabeceraNull Then
            Me.txtCabecera.Text = ""
        Else
            Me.txtCabecera.Text = Dataset.EtiquetasPaletSelect(0).cabecera
        End If


        If Dataset.EtiquetasPaletSelect(0).anoscaducidad = "" Then
            lCaducidad.Text = ""
        Else
            lCaducidad.Text = Dataset.EtiquetasPaletSelect(0).CaducidadTexto
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Dataset.EtiquetasPaletSelect(0).marca = Me.lMarca.Text
        Me.Dataset.EtiquetasPaletSelect(0).producto = Me.lProducto.Text
        Me.Dataset.EtiquetasPaletSelect(0).botellas = Me.lCajasBotellas.Text
        Me.Dataset.EtiquetasPaletSelect(0).palet = Me.lPalet.Text
        Me.Dataset.EtiquetasPaletSelect(0).cajas = Me.lnCajas.Text
        Me.Dataset.EtiquetasPaletSelect(0).cantidadBotellas = Me.lnBotellas.Text
        If Me.lean13.Enabled Then Me.Dataset.EtiquetasPaletSelect(0).ean13 = Me.lean13.Text
        If Me.lean14.Enabled Then Me.Dataset.EtiquetasPaletSelect(0).ean14 = Me.lean14.Text

        Dataset.EtiquetasPaletSelect(0).loteTexto = Me.llote.Text
        Dataset.EtiquetasPaletSelect(0).SCC = Me.lscc.Text
        Dataset.EtiquetasPaletSelect(0).cabecera = Me.txtCabecera.Text
        Dataset.EtiquetasPaletSelect(0).CaducidadTexto = lCaducidad.Text

        Me.Hide()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub


End Class