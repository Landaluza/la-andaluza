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
            If avisosDatasource.Rows.Count = 0 Then Return
            cargar()
        End Sub

        Public Sub New(ByVal proveedor As Integer)

            If proveedor = 0 Then Return

            bd = New bdAvisoPedido
            avisosDatasource = bd.seleccionar_avisos_por_proveedor(proveedor)
            cargar()
        End Sub

        Private Sub cargar()
            registroActual = 0
            gui = New guiAVisoPedido
            AddHandler gui.btnAvanzar.Click, AddressOf Me.siguiente_registro
            AddHandler gui.btnAtras.Click, AddressOf Me.anterior_registro
            AddHandler gui.btnMarcar.Click, AddressOf Me.marcar_registro
            AddHandler gui.btnMarcarTodos.Click, AddressOf Me.marcar_todos

            cargar_registro()
            gui.ShowDialog()
        End Sub

        Private Sub cargar_registro()            
            Dim detalles As DataTable = Me.bd.seleccionar_detalles_aviso(avisosDatasource.Rows(registroActual).Item(0))

            Me.gui.lResultados.Text = "Aviso " & (registroActual + 1).ToString & "/" & avisosDatasource.Rows.Count.ToString
            If Not Convert.IsDBNull(detalles.Rows(0).Item("cabecera")) Then Me.gui.lCabecera.Text = detalles.Rows(0).Item("cabecera")
            If Not Convert.IsDBNull(detalles.Rows(0).Item("detalle")) Then Me.gui.lDetalle.Text = detalles.Rows(0).Item("detalle")
            If Not Convert.IsDBNull(detalles.Rows(0).Item("fecha")) Then
                Dim fecha As Date = CType(detalles.Rows(0).Item("fecha"), Date).Date
                Me.gui.lFecha.Text = fecha.Day & "/" & fecha.Month & "/" & fecha.Year
            End If
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
            Try
                If bd.marcar_leido(avisosDatasource.Rows(registroActual).Item(0)) Then
                    MessageBox.Show("Este registro no se mostrara mas.", "Leido", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No se pudo realizar la operacion", "Operacion no disponible", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MessageBox.Show("No se pudo realizar la operacion. " & ex.Message, "Operacion no disponible", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Sub

        Private Sub marcar_todos()
            bd.EmpezarTransaccion()

            Try
                For Each dr As DataRow In avisosDatasource.Rows
                    If Not bd.marcar_leido(avisosDatasource.Rows(registroActual).Item(0)) Then
                        Throw New Exception("No se pudo actualizar uno de los registros")
                    End If
                Next

                bd.TerminarTransaccion()
                gui.Close()
            Catch ex As Exception
                MessageBox.Show("No se pudo realizar la operacion. " & ex.Message, "Operacion no disponible", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                bd.CancelarTransaccion()
            End Try
            
        End Sub

    End Class

End Namespace
