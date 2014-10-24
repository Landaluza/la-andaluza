Public Class frmModDetalle
    Private frmDetalles As Object
    Private tsDescripcion As Boolean
    Public Event actualizarExtras()

    Public Sub New(ByVal articuloId As Integer, ByVal TipoArticulo As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        Select Case TipoArticulo
            Case Is = 1 'Materias primas
                Me.frmDetalles = New frmWstepMateriasPrimas(articuloId)
                Engine_LA.FormEnPestaña(Me.frmDetalles, Me.Panel1)

            Case Is = 4 'Graneles
                Me.frmDetalles = New frmWstepGraneles(articuloId)
                Engine_LA.FormEnPestaña(Me.frmDetalles, Me.Panel1)

            Case Is = 6 'Ingredientes
                Me.frmDetalles = New frmWstepIngredientes(False, (articuloId))
                Engine_LA.FormEnPestaña(Me.frmDetalles, Me.Panel1)

            Case Is = 57 'Ingredientes
                Me.frmDetalles = New frmWstepIngredientes(True, (articuloId))
                Engine_LA.FormEnPestaña(Me.frmDetalles, Me.Panel1)

            Case Is = 8 ' primarios 
                Dim f As New frmWstepPrimario(articuloId)
                AddHandler f.actualizarExtras, AddressOf Me.datosModificados
                Me.frmDetalles = f
                Engine_LA.FormEnPestaña(Me.frmDetalles, Me.Panel1)


            Case Is = 9 'Envases secundarios (cajas)
                Dim f As frmWstepArticuloSecundario = New frmWstepArticuloSecundario(articuloId)
                AddHandler f.actualizarExtras, AddressOf Me.datosModificados
                Me.frmDetalles = f
                Engine_LA.FormEnPestaña(Me.frmDetalles, Me.Panel1)
                Me.tsDescripcion = True

            Case Is = 10 'Envases terciarios (palets)
                Me.frmDetalles = New frmWstepArticuloTerciario(articuloId)
                Dim f As frmWstepArticuloTerciario = frmDetalles
                AddHandler f.actualizarExtras, AddressOf Me.datosModificados
                Engine_LA.FormEnPestaña(Me.frmDetalles, Me.Panel1)
                Me.tsDescripcion = True

            Case Else
                Me.Enabled = False
        End Select

    End Sub

    Public Sub datosModificados()
        RaiseEvent actualizarExtras()
    End Sub

    Public Sub actualizarDatos()
        Try
            Me.frmDetalles.ActualizarDatos()
        Catch ex As Exception
        End Try
    End Sub

    Public Function grabarDatos(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Return Me.frmDetalles.grabarDatos(dtb)
    End Function

    Public Function comprobarCampos() As Boolean
        Return Me.frmDetalles.comprobarCampos
    End Function
End Class