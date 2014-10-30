Public Class frmAsistenteArticulosEnvasados
    Inherits wizard

    Private frmArticulos1 As frmWstepArticulos1
    Private frmdatos As frmWstepDatosGenerales
    Private frmArticulos1b As frmWstepArticulos1
    Private frmSecundario As frmWstepArticuloSecundario
    Private frmTerciario As frmWstepArticuloTerciario

    Public Sub New()
        MyBase.New()
        ' This call is required by the designer.
        InitializeComponent()

        Me.title = "Asistente de creación de articulo para envasado"


        Me.frmdatos = New frmWstepDatosGenerales
        MyBase.forms.Add(Me.frmdatos)
        Me.titles.Add("Detalles genericos del articulo par el articulo secundario y terciario")

        Me.frmArticulos1 = New frmWstepArticulos1       
        MyBase.forms.Add(Me.frmArticulos1)
        Me.titles.Add("Detalles genericos del articulo secundario (Cajas)")

        Me.frmSecundario = New frmWstepArticuloSecundario
        MyBase.forms.Add(Me.frmSecundario)
        Me.titles.Add("Detalles especificos del articulo secundario (Cajas)")

        Me.frmArticulos1b = New frmWstepArticulos1
        MyBase.forms.Add(Me.frmArticulos1b)
        Me.titles.Add("Detalles genericos del articulo terciario (Palet)")

        Me.frmTerciario = New frmWstepArticuloTerciario
        MyBase.forms.Add(Me.frmTerciario)
        Me.titles.Add("Detalles especificos del articulo terciario (Cajas)")
    End Sub

    Private Sub cambioPanel(ByRef sender As Object, e As EventArgs) Handles Me.PanelChanged
        Dim panel As Form = CType(sender, Form)

        If panel.GetType = Me.frmArticulos1.GetType And Me.wizardStep = 1 Then
            Me.frmArticulos1.Descripcion = Me.frmdatos.recuperarValor(frmWstepDatosGenerales.DESCRIPCION)
            Me.frmArticulos1.TipoArticulo = 9
            Me.frmArticulos1.NoCrearSecundario = Me.frmdatos.recuperarValor(frmWstepDatosGenerales.CREAR_SECUNDARIO)

            If Not Me.frmdatos.recuperarValor(frmWstepDatosGenerales.CREAR_SECUNDARIO) Then
                MyBase.titles.Remove(2)
                MyBase.titles.Add("Detalles genericos para el formato envasado", 2, 2)
                MyBase.titles.Remove(3)
                MyBase.titles.Add("Detalles especificos para el formato envasado", 3, 3)

                If Not Me.frmdatos.recuperarValor(frmWstepDatosGenerales.CREAR_FORMATO) Then
                    Me.frmSecundario.Enabled = False
                    Me.frmArticulos1.Enabled = False
                End If
            Else
                MyBase.titles.Remove(2)
                MyBase.titles.Add("Detalles genericos del articulo secundario (Cajas)", 2, 2)
                MyBase.titles.Remove(3)
                MyBase.titles.Add("Detalles especificos del articulo secundario (Cajas)", 3, 3)


            End If
        ElseIf panel.GetType = Me.frmSecundario.GetType And Me.wizardStep = 2 Then
            'Me.frmSecundario.Descripcion = Me.frmdatos.recuperarValor(frmWstepDatosGenerales.DESCRIPCION)
            Me.frmSecundario.TipoProducto = Me.frmdatos.recuperarValor(frmWstepDatosGenerales.PRODUCTO)
            Me.frmSecundario.NoCrearSecundario = Me.frmdatos.recuperarValor(frmWstepDatosGenerales.CREAR_SECUNDARIO)
            Me.frmSecundario.Formato = Me.frmdatos.recuperarValor(frmWstepDatosGenerales.FORMATO)
            Me.frmSecundario.cboCajaID.SelectedValue = Me.frmdatos.recuperarValor(frmWstepDatosGenerales.CAJA)
            Me.frmSecundario.cboProducto.SelectedValue = Me.frmdatos.recuperarValor(frmWstepDatosGenerales.PRODUCTO)
            Me.frmSecundario.Descripcion = Me.frmdatos.recuperarValor(frmWstepDatosGenerales.DESCRIPCION)

            If Me.frmSecundario.Enabled Then
                Me.frmSecundario.QS = Me.frmArticulos1.QS
            End If

        ElseIf panel.GetType = Me.frmArticulos1.GetType And Me.wizardStep = 3 Then
            Me.frmArticulos1b.Descripcion = Me.frmdatos.recuperarValor(frmWstepDatosGenerales.DESCRIPCION)
            Me.frmArticulos1b.Datos = Me.frmArticulos1.Datos
            Me.frmArticulos1b.TipoArticulo = 10
        ElseIf panel.GetType = Me.frmTerciario.GetType Then
            Me.frmTerciario.Marca = Me.frmdatos.recuperarValor(frmWstepDatosGenerales.MARCA_ID)
            Me.frmTerciario.Formato = Me.frmdatos.recuperarValor(frmWstepDatosGenerales.FORMATO)
            Me.frmTerciario.TipoPalet = Me.frmdatos.recuperarValor(frmWstepDatosGenerales.TIPO_PALET)
            Me.frmTerciario.cboMarca.SelectedValue = Me.frmdatos.recuperarValor(frmWstepDatosGenerales.MARCA_ID)
            Me.frmTerciario.cboPalet.SelectedValue = Me.frmdatos.recuperarValor(frmWstepDatosGenerales.TIPO_PALET)
        End If

    End Sub

    Private Sub frmAsistenteArticulosEnvasados_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.cambiarPanel(1)
    End Sub

    Private Sub finished() Handles Me.FinishWizard
        If MyBase.guardar(Me.dtb) Then
            Me.Close()
        Else
            MessageBox.Show("No se ha podido guardar. Vuelva a intentarlos en unos segundos o revise los datos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class