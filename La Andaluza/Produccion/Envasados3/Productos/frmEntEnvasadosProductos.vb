Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntEnvasadosProductos
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_EnvasadosProductos As DBO_EnvasadosProductos
    Private frmEnvasadosProductosAnaliticas2 As frmEnvasadosProductosAnaliticas2

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spEnvasadosProductos = Nothing, Optional ByRef v_dbo As DBO_EnvasadosProductos = Nothing)
        MyBase.New(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.DataBussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spEnvasadosProductos, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_EnvasadosProductos = If(v_dbo Is Nothing, New DBO_EnvasadosProductos, v_dbo)
        dbo = m_DBO_EnvasadosProductos
        dtpHoraFinal.activarFoco()
        dtpHoraInicio.activarFoco()
    End Sub

    Private Sub frmEntEnvasadosProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim s1 As New spTiposProductos
        s1.cargar_ComboBox(Me.cboProducto, dtb)
        If Me.ModoDeApertura = VISION Then
            Me.cboProducto.Enabled = False
            Me.lblProductoID.Enabled = False
        End If

        If Config.UserType <> 4 And Config.UserType <> 9 Then
            butAddProductoID.Enabled = False
            butVerProductoID.Enabled = False
        End If
    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        Me.m_DBO_EnvasadosProductos = CType(dbo, DBO_EnvasadosProductos)

        cboProducto.SelectedValue = m_DBO_EnvasadosProductos.ProductoID
        'dtpHoraInicio.Value = DateTime.Now.Date.Add(m_DBO_EnvasadosProductos.HoraInicio)
        'dtpHoraFinal.Value = DateTime.Now.Date.Add(m_DBO_EnvasadosProductos.HoraFinal)
        txtObservaciones.Text = m_DBO_EnvasadosProductos.Observaciones


        If Me.ModoDeApertura <> INSERCION Then
            dtpHoraInicio.Value = DateTime.Now.Date.Add(m_DBO_EnvasadosProductos.HoraInicio)
            dtpHoraFinal.Value = DateTime.Now.Date.Add(m_DBO_EnvasadosProductos.HoraFinal)
            frmEnvasadosProductosAnaliticas2 = New frmEnvasadosProductosAnaliticas2(Me.m_DBO_EnvasadosProductos.ID, If(Me.ModoDeApertura = VISION, True, False))
            Engine_LA.FormEnPestaña(frmEnvasadosProductosAnaliticas2, Me.SplitContainer1.Panel2)
            SplitContainer1.Panel2.Enabled = True
        Else
            dtpHoraInicio.Value = DateTime.Now
            dtpHoraFinal.Value = Me.dtpHoraInicio.Value.AddMinutes(15)
            SplitContainer1.Panel2.Enabled = False
        End If
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty

        If dtpHoraInicio.Value >= dtpHoraFinal.Value Then
            If errores = "" Then dtpHoraFinal.Focus()
            errores = errores & "La hora de fin no puede ser menor o igual a la de inicio." & Environment.NewLine()
        Else
            m_DBO_EnvasadosProductos.HoraInicio = New TimeSpan(dtpHoraInicio.Value.Hour, dtpHoraInicio.Value.Minute, 0)
            m_DBO_EnvasadosProductos.HoraFinal = New TimeSpan(dtpHoraFinal.Value.Hour, dtpHoraFinal.Value.Minute, 0)
        End If

        m_DBO_EnvasadosProductos.Observaciones = txtObservaciones.Text

        If cboProducto.SelectedValue Is Nothing Then
            errores = errores & Environment.NewLine & "No selecciono un producto"
        Else
            Me.m_DBO_EnvasadosProductos.ProductoID = cboProducto.SelectedValue
        End If

        If errores = String.Empty Then
            dbo = CType(m_DBO_EnvasadosProductos, BasesParaCompatibilidad.DataBussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        If Me.GetValores Then
            Dim terminar As Boolean

            If dtb Is Nothing Then
                Me.dtb.EmpezarTransaccion()
                terminar = True
            Else
                Me.dtb = dtb
                terminar = False
            End If

            Try
                If sp.Grabar(dbo, Me.dtb) Then
                    If Me.ModoDeApertura = INSERCION Then
                        dtb.PrepararConsulta("Select max(envasadoProductoid) from envasadosProductos")
                        Me.m_DBO_EnvasadosProductos.ID = Convert.ToInt32(Me.dtb.Consultar().Rows(0).Item(0))
                    End If

                    If terminar Then Me.dtb.TerminarTransaccion()
                Else
                    If terminar Then
                        Me.dtb.CancelarTransaccion()
                        MessageBox.Show("No se pudo guardar el registro. Asegurese de tener conexion a la red.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    Else
                        Throw New Exception("Erro al gaurdar, ERR1")
                    End If
                End If
            Catch ex As Exception
                If terminar Then
                    Me.dtb.CancelarTransaccion()
                    MessageBox.Show("No se pudo guardar el registro. Detalles:" & Environment.NewLine() & Environment.NewLine(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                Else
                    Throw New Exception("Erro al guardar , ERR2")
                End If
            End Try



            evitarCerrarSinGuardar = False
            RaiseEvent afterSave(Me, Nothing)

            If Me.ModoDeApertura = INSERCION Then
                Me.ModoDeApertura = MODIFICACION
                SetValores()
            Else
                Me.Close()
            End If
        End If
    End Sub


    Private Sub butAddProductoID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddProductoID.Click
        Dim DBO_TiposProductos As New DBO_TiposProductos
        Dim frmEnt As New frmEntTiposProductos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spTiposProductos, DBO_TiposProductos)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spTiposProductos
        s.cargar_ComboBox(Me.cboProducto, dtb)
    End Sub

    Private Sub frmEntEnvasadosProductos_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.pantalla.centerIn(CType(Me.tlpMiddle, Control), Me.SplitContainer1.Panel2)
    End Sub
End Class
