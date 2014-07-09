Public Class frmEntRecipientesSalidas
    inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Dim dtsRec As New dtsRecipientesSalidas.RecipientesSalidasDataTable
    Dim ctlRec As New ctlRecipientesSalidas

    Overrides Sub Guardar()
        Try
            ctlRec.GuardarRecipienteSalida(DescripcionCuadroDeTexto.Text)
            Me.Close()
        Catch ex As Exception
            messagebox.show(ex.Message, "Error", MessageBoxButtons.OK , MessageBoxIcon.Error )
        End Try
    End Sub
    Private Sub frmEntRecipientesSalidas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ModificarBindingNavigator()
        If Me.Text.Substring(0, 3) = "Ver" Then
            ctlRec.mostrarTodosRecipientesSalidas(dtsRec)
            GeneralBindingSource.DataSource = dtsRec
            GeneralBindingSource.Position = Posicion
        End If
    End Sub

    Public Sub CargarDatos(ByVal Pos As Integer, ByVal RecipienteSalidaID As Integer, _
               ByVal Descripcion As String)
        Posicion = pos
        ctlRec.SetRecipienteSalidaID(RecipienteSalidaID)
        DescripcionCuadroDeTexto.text = Descripcion
    End Sub


End Class
