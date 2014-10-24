Public Class frmEntVentasArticulo
    Private spArt As spArticulos1
    Private spVentas As spVentas
    Private mes As Integer
    Private agno As Integer
    Private dtb As BasesParaCompatibilidad.DataBase
    Public Sub New(ByVal month As Integer, ByVal agno As Integer)

        InitializeComponent()

        dtb = New BasesParaCompatibilidad.DataBase
        spArt = New spArticulos1
        spVentas = New spVentas

        Me.mes = month
        Me.agno = agno
    End Sub

    Private Sub setValores()
        spArt.cargar_Articulos_Por_Tipo(Me.cboArticulo, 9, dtb)
        Me.lMes.Text = Me.mes
        Me.lAgno.Text = Me.agno
    End Sub

    Private Function getValores() As Boolean
        Dim errores As String = String.Empty

        If Me.txtCantidad.Text <> String.Empty Then
            If Not IsNumeric(Me.txtCantidad.Text) Then
                errores = errores & "La cantidad debe ser numérica & Environment.NewLine"
            End If
        Else
            errores = errores & "No especificó una cantidad" & Environment.NewLine
        End If

        If Me.cboArticulo.SelectedValue Is Nothing Then
            errores = errores & "No seleccionó un artículo" & Environment.NewLine
        End If

        If Me.txtCodigoQS.Text = String.Empty Then
            errores = errores & "No hay codigoQs para el artículo" & Environment.NewLine
        End If

        If errores = String.Empty Then
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function


    Private Sub Grabar()
        If getValores() Then
            Try
                If Me.spVentas.grabar_venta(Me.mes, Me.agno, Me.txtCodigoQS.Text, Me.cboArticulo.Text, Me.txtCantidad.Text) Then
                    Me.Close()
                Else
                    messagebox.show("Error al guardar. Vuelva a intentarlo en unos minutos","", MessageBoxButtons.OK, MessageBoxIcon.Error )
                End If

            Catch ex As Exception
                messagebox.show("Error al guardar. Detalles:" & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub cboArticulo_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cboArticulo.SelectedValueChanged
        Try

            Dim dboArt As DBO_Articulos1 = spArt.Select_Record(cboArticulo.SelectedValue, dtb)
            Me.txtCodigoQS.Text = dboArt.CodigoQS
            Me.txtCodigoLA.Text = dboArt.CodigoLA
        Catch ex As Exception
            Me.txtCodigoQS.Text = String.Empty
            Me.txtCodigoLA.Text = String.Empty
        End Try
    End Sub

    Private Sub frmEntVentasArticulo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        setvalores()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Grabar()
    End Sub

    Private Sub frmEntVentasArticulo_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.Pantalla.centerIn(Me.Panel2, Me)
    End Sub
End Class