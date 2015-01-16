Namespace Proveedores
    Public Class AvisoPedido
        Private registroActual As Integer
        Private gui As guiAVisoPedido
        Private bd As bdAvisoPedido
        Private avisosDatasource As DataTable

        Public Sub New(ByVal proveedor As Integer, ByVal articulo As Integer)

            If proveedor = 0 And articulo = 0 Then Return

            bd = New bdAvisoPedido
            avisosDatasource = bd.seleccionar_avisos_por_articulo_y_proveedor(proveedor, articulo)

            If avisosDatasource Is Nothing Then Return
            registroActual = 0
            gui = New guiAVisoPedido
            AddHandler gui.btnAvanzar.Click, AddressOf Me.siguiente_registro
            AddHandler gui.btnAtras.Click, AddressOf Me.anterior_registro
            AddHandler gui.btnMarcar.Click, AddressOf Me.marcar_registro
            AddHandler gui.btnMarcarTodos.Click, AddressOf Me.marcar_todos

            gui.ShowDialog()
        End Sub

        Private Sub cargar_registro()            
            Dim detalles As DataTable = Me.bd.seleccionar_detalles_aviso(avisosDatasource.Rows(registroActual).Item(0))

            Me.gui.lResultados.Text = "Aviso " & (registroActual + 1).ToString & "/" & (avisosDatasource.Rows.Count + 1).ToString
            Me.gui.lCabecera.Text = detalles.Rows(0).Item("cabecera")
            Me.gui.lDetalle.Text = detalles.Rows(0).Item("detalles")
            Me.gui.lFecha.Text = CType(detalles.Rows(0).Item("cabecera"), Date).Date.ToString()
        End Sub
        Private Sub siguiente_registro()
            registroActual = registroActual + 1
            If registroActual > avisosDatasource.Rows.Count Then registroActual = 0

            cargar_registro()
        End Sub

        Private Sub anterior_registro()
            registroActual = registroActual - 1
            If registroActual < 0 Then registroActual = avisosDatasource.Rows.Count - 1

            cargar_registro()
        End Sub

        Private Sub marcar_registro()
            gui.Close()
        End Sub

        Private Sub marcar_todos()
            gui.Close()
        End Sub

    End Class

End Namespace
