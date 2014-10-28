Public Class frmWstepPrimario
    Implements wizardable
    Private pan As Object
    Private id As Integer
    Private modoDeApertura As Integer
    Public Event actualizarExtras()

    Private dtb As BasesParaCompatibilidad.DataBase
    Public Sub New(ByVal mode As Integer, ByVal stub As Byte)

        InitializeComponent()
        dtb = New BasesParaCompatibilidad.DataBase
        Me.id = 0
        Me.modoDeApertura = BasesParaCompatibilidad.DetailedSimpleForm.INSERCION

        Select Case mode
            Case 0
                Me.rbmonodosis.Checked = True
            Case 1
                Me.rbDoypack.Checked = True
        End Select
    End Sub

    Public Sub New(ByVal articuloid As Integer)
        InitializeComponent()

        dtb = New BasesParaCompatibilidad.DataBase
        Me.id = articuloid
        Me.modoDeApertura = BasesParaCompatibilidad.DetailedSimpleForm.MODIFICACION
        EstablecerValores()
        Me.gpTipo.Enabled = False
    End Sub

    Private Sub frmWstepPrimario_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.Pantalla.centerIn(Me.panContenidos, Me)
    End Sub

    Private Sub rbmonodosis_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbmonodosis.CheckedChanged, rbNinguno.CheckedChanged, rbDoypack.CheckedChanged

        If sender Is rbNinguno Then
            Me.pansubtipo.Controls.Clear()
            pan = Nothing

        ElseIf sender Is rbmonodosis Then
            pan = New frmPanMonodosis(Me.id, If(Me.modoDeApertura = BasesParaCompatibilidad.DetailedSimpleForm.MODIFICACION, False, True))
            Engine_LA.FormEnPestaña(pan, pansubtipo)

        ElseIf sender Is rbDoypack Then
            Dim f As New frmPanDoypack(Me.id, If(Me.modoDeApertura = BasesParaCompatibilidad.DetailedSimpleForm.MODIFICACION, False, True))
            AddHandler f.actualizarExtras, AddressOf Me.raiseRefresh
            pan = f
            Engine_LA.FormEnPestaña(pan, pansubtipo)

        End If
    End Sub

    Private Sub raiseRefresh()
        RaiseEvent actualizarExtras()
    End Sub

    Public Sub actualizarDatos()
        Try
            Me.pan.ActualizarDatos()
        Catch ex As Exception
        End Try
    End Sub

    Public Function comprobarCampos() As Boolean Implements wizardable.comprobarCampos
        If pan Is Nothing Then
            Return True
        Else
            Return Me.pan.comprobarCampos()
        End If
    End Function

    Public Sub EstablecerValores() Implements wizardable.EstablecerValores
        Dim spMonodosis As New spMonodosis
        Dim aux As DBO_Monodosis = spMonodosis.selectRecord(Me.id, dtb)
        If Not aux Is Nothing Then
            Me.rbmonodosis.Checked = True
        Else
            Dim spdoypack As New spdoypack
            If spdoypack.esDoypack(Me.id, dtb) Then
                Me.rbDoypack.Checked = True
            End If
        End If


        If Not pan Is Nothing Then
            Me.pan.EstablecerValores()
        End If
    End Sub

    Public Function grabarDatos(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean Implements wizardable.grabarDatos
        If pan Is Nothing Then
            Dim spMonodosis As New spMonodosis
            Return spMonodosis.limpiarDatos(dtb, Me.id)
        Else
            Return Me.pan.grabarDatos(dtb)
        End If
    End Function

    Public Function recuperarValor(nombre As String) As Object Implements wizardable.recuperarValor
        If Me.pan Is Nothing Then
            Return Nothing
        Else
            Return Me.pan.recuperarValor
        End If
    End Function
End Class