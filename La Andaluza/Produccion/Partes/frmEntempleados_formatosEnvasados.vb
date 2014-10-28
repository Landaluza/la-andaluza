Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntempleados_formatosEnvasados
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_empleados_formatosEnvasados As DBO_empleados_formatosEnvasados
    Private formAuxiliar As Object

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spempleados_formatosEnvasados = Nothing, Optional ByRef v_dbo As DBO_empleados_formatosEnvasados = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spempleados_formatosEnvasados, v_sp)
        m_DBO_empleados_formatosEnvasados = If(v_dbo Is Nothing, New DBO_empleados_formatosEnvasados, v_dbo)
        dbo = m_DBO_empleados_formatosEnvasados

        If Config.UserType = 3 Then
            Me.butVerid_empleado.Enabled = False
            Me.butAddid_empleado.Enabled = False
        End If
        dtpFin.activarFoco()
        dtpInicio.activarFoco()
    End Sub

    Public Sub New()
        InitializeComponent()
        dtpFin.activarFoco()
        dtpInicio.activarFoco()
    End Sub

    Private Sub frmEntempleados_formatosEnvasados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.ModoDeApertura = VISION Then
            Me.cboid_empleado.Enabled = False
            Me.lblid_empleado.Enabled = False
        End If
        Me.cbFin.Checked = True
    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        Me.m_DBO_empleados_formatosEnvasados = dbo

        Dim spFormatosEnvasados As New spFormatosEnvasados
        Dim dboFormato As DBO_FormatosEnvasados = spFormatosEnvasados.Select_Record(Me.m_DBO_empleados_formatosEnvasados.id_formatoEnvasado, dtb)
        Dim spLineas As New spTiposFormatosLineas
        Dim dboFormatoLinea As DBO_TiposFormatosLineas = spLineas.Select_Record(dboFormato.TipoFormatoLineaID, dtb)

        Dim s2 As New spEmpleados

        If Me.ModoDeApertura = INSERCION Then
            s2.cargar_Empleados_Envasados_libres(Me.cboid_empleado, dtb)
            Me.cboid_empleado.Enabled = True
            Dim dbo_formato As DBO_FormatosEnvasados = spFormatosEnvasados.Select_Record(Me.m_DBO_empleados_formatosEnvasados.id_formatoEnvasado, dtb)
            dtpInicio.Value = DateTime.Now.Date.Add(dbo_formato.inicio)
            dtpFin.Value = DateTime.Now.Date.Add(dbo_formato.fin)
            ' Me.cbApoyo.Visible = True
        Else
            s2.cargar_empleados_envasados(Me.cboid_empleado, dtb)
            Me.cboid_empleado.Enabled = False
            'Me.cbApoyo.Visible = False
            dtpInicio.Value = DateTime.Now.Date.Add(m_DBO_empleados_formatosEnvasados.Inicio)
            dtpFin.Value = DateTime.Now.Date.Add(m_DBO_empleados_formatosEnvasados.Fin)
        End If

        cboid_empleado.SelectedValue = m_DBO_empleados_formatosEnvasados.id_empleado
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty

        If cboid_empleado.SelectedValue Is Nothing Then
            If errores = "" Then cboid_empleado.Focus()
            errores = errores & "No seleccionó un valor para id_empleado." & Environment.NewLine
        Else
            m_DBO_empleados_formatosEnvasados.id_empleado = System.Convert.ToInt32(cboid_empleado.SelectedValue)
        End If

        If dtpFin.Enabled Then
            If dtpInicio.Value > dtpFin.Value Then
                errores = errores & "La hora de inicio es mayor que la de final." & Environment.NewLine
            Else
                m_DBO_empleados_formatosEnvasados.Inicio = New TimeSpan(dtpInicio.Value.Hour, dtpInicio.Value.Minute, 0)
                m_DBO_empleados_formatosEnvasados.Fin = New TimeSpan(dtpFin.Value.Hour, dtpFin.Value.Minute, 0)
            End If
        Else
            m_DBO_empleados_formatosEnvasados.Inicio = New TimeSpan(dtpInicio.Value.Hour, dtpInicio.Value.Minute, 0)
            m_DBO_empleados_formatosEnvasados.Fin = Nothing
        End If

        If errores = String.Empty Then
            Dim spAux As New spempleados_formatosEnvasados
            Dim dboF As DBO_FormatosEnvasados
            Dim spf As New spFormatosEnvasados
            dboF = spf.Select_Record(Me.m_DBO_empleados_formatosEnvasados.id_formatoEnvasado, dtb)

            If spAux.EstaDesdoblado(m_DBO_empleados_formatosEnvasados, dboF.EnvasadoID, Me.m_DBO_empleados_formatosEnvasados.ID, dtb) Then
                errores = errores & "El empleado se encontraba ocupado durante esa hora." & Environment.NewLine
            End If
        End If

        If errores = String.Empty Then

            dbo = m_DBO_empleados_formatosEnvasados
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        If Me.ModoDeApertura = INSERCION Then
            'If Me.cbApoyo.Checked Then
            If GetValores() Then
                Dim terminar As Boolean
                If dtb Is Nothing Then
                    terminar = True
                    Me.dtb.EmpezarTransaccion()
                Else
                    Me.dtb = dtb
                    terminar = False
                End If


                Try
                    If Me.sp.Grabar(Me.m_DBO_empleados_formatosEnvasados, Me.dtb) Then
                        If Me.cbApoyo.Checked Then
                            Dim spCausas As New spPartesEnvasados_CausasPartesEnvasado
                            Dim dboCAusas As New DBO_PartesEnvasados_CausasPartesEnvasado
                            Dim spAux As New spempleados_formatosEnvasados

                            dboCAusas.Id_ParteEnvasado = spAux.seleccionarUltimoRegistro(Me.dtb)
                            dboCAusas.Id_CausaParteEnvasado = 3

                            If Not spCausas.Grabar(dboCAusas, Me.dtb) Then
                                If terminar Then
                                    Me.dtb.CancelarTransaccion()
                                    MessageBox.Show("No se pudo completar la operacion", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Return
                                Else
                                    Throw New Exception("Erro al guardar , ERR1")
                                End If

                            End If
                        End If
                        If terminar Then Me.dtb.TerminarTransaccion()
                            RaiseEvent afterSave(Me, Nothing)
                            Me.Close()
                    Else
                        If terminar Then
                            Me.dtb.CancelarTransaccion()
                            MessageBox.Show("No se pudo completar la operacion", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        Else
                            Throw New Exception("Erro al guardar, ERR2")
                        End If
                    End If
                Catch ex As Exception
                    If terminar Then
                        Me.dtb.CancelarTransaccion()
                        MessageBox.Show("No se pudo completar la operacion", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    Else
                        Throw New Exception("Error al guardar , ERR3")
                    End If
                End Try
            End If

            'MyBase.Guardar(me.dtb)
            'End If
        Else
            If GetValores() Then

                Dim terminar As Boolean
                If dtb Is Nothing Then
                    terminar = True
                    Me.dtb.EmpezarTransaccion()
                Else
                    Me.dtb = dtb
                    terminar = False
                End If

                Try
                    If Me.sp.Grabar(Me.m_DBO_empleados_formatosEnvasados, Me.dtb) Then
                        Dim spCausas As New spPartesEnvasados_CausasPartesEnvasado
                        Dim dboCAusas As New DBO_PartesEnvasados_CausasPartesEnvasado
                        Dim spAux As New spempleados_formatosEnvasados

                        If Not spCausas.DeleteByParte(m_DBO_empleados_formatosEnvasados.ID, Me.dtb) Then
                            If terminar Then
                                dtb.CancelarTransaccion()
                                MessageBox.Show("No se pudo completar la operacion", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return
                            Else
                                Throw New Exception("error al guardar , ERR4")
                            End If
                        End If

                            If Me.cbApoyo.Checked Then
                                dboCAusas.Id_ParteEnvasado = m_DBO_empleados_formatosEnvasados.ID
                                dboCAusas.Id_CausaParteEnvasado = 3

                            If Not spCausas.Grabar(dboCAusas, Me.dtb) Then
                                If terminar Then
                                    Me.dtb.CancelarTransaccion()
                                    MessageBox.Show("No se pudo completar la operacion", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Return
                                Else
                                    Throw New Exception("Error al guardar , ERR5")
                                End If
                            End If
                            End If

                        If terminar Then Me.dtb.TerminarTransaccion()
                            RaiseEvent afterSave(Me, Nothing)
                            Me.Close()
                    Else
                        If terminar Then
                            Me.dtb.CancelarTransaccion()
                            MessageBox.Show("No se pudo completar la operacion", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        Else
                            Throw New Exception("Error al guardar ERr6")
                        End If
                    End If
                Catch ex As Exception
                    If terminar Then
                        Me.dtb.CancelarTransaccion()
                        MessageBox.Show("No se pudo completar la operacion", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    Else
                        Throw New Exception("Erro al guardar ERR7")
                    End If
                End Try
            End If
        End If
    End Sub

    Private Sub butVerid_empleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerid_empleado.Click
        Dim frmEnt As New frmEmpleados()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddid_empleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddid_empleado.Click
        Dim spFormatosEnvasados As New spFormatosEnvasados
        Dim dboFormato As DBO_FormatosEnvasados = spFormatosEnvasados.Select_Record(Me.m_DBO_empleados_formatosEnvasados.id_formatoEnvasado, dtb)
        Dim spLineas As New spTiposFormatosLineas
        Dim dboFormatoLinea As DBO_TiposFormatosLineas = spLineas.Select_Record(dboFormato.TipoFormatoLineaID, dtb)

        Dim v_dbo As New DBO_Empleados_LineasEnvasado
        v_dbo.Id_LineaEnvasado = dboFormatoLinea.LineaEnvasadoID
        Dim frm As New frmEntEmpleados_LineasEnvasado(INSERCION, New spEmpleados_LineasEnvasado, v_dbo)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)

        Dim s As New spEmpleados
        s.cargar_empleados_por_linea(Me.cboid_empleado, dboFormatoLinea.LineaEnvasadoID, dtb)
    End Sub

    Private Sub frmEntempleados_formatosEnvasados_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.pantalla.centerIn(Me.panGeneral, Me)
    End Sub

    Private Sub cbFin_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbFin.CheckedChanged
        Me.dtpFin.Enabled = Me.cbFin.Checked
    End Sub
End Class
