Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntPersonalEnvasado
    Private spTiposFormatosLineas_TiposFormatos As spTiposFormatosLineas_TiposFormatos
    Private dboTipoLinea As DBO_TiposFormatosLineas_TiposFormatos

    Private formato As DBO_FormatosEnvasados
    Private m_envasadoID As Integer
    Private Linea As Integer
    Private Event formato_changed()
    Private dtb As BasesParaCompatibilidad.DataBase

    Public WriteOnly Property Formato_Envasado As Integer
        Set(value As Integer)
            Me.formato.TipoFormatoEnvasadoID = value
            RaiseEvent formato_changed()
        End Set
    End Property

    Public WriteOnly Property Formato_Linea As Integer
        Set(value As Integer)
            Me.formato.TipoFormatoLineaID = value
            RaiseEvent formato_changed()
        End Set
    End Property

    Public WriteOnly Property FormatoEnvasado As Integer
        Set(value As Integer)
            Me.formato.ID = value
            RaiseEvent formato_changed()
        End Set
    End Property

    Public Sub New(ByVal linea As Integer, ByVal EnvasadoID As Integer, Optional ByVal embebido As Boolean = False)

        InitializeComponent()

        dtb = New BasesParaCompatibilidad.DataBase
        Me.formato = New DBO_FormatosEnvasados
        Me.dboTipoLinea = New DBO_TiposFormatosLineas_TiposFormatos
        Me.spTiposFormatosLineas_TiposFormatos = New spTiposFormatosLineas_TiposFormatos
        Me.m_envasadoID = EnvasadoID

        Me.ToolTip1.SetToolTip(Me.btnALinea, "Añade el empleado a la linea")
        Me.ToolTip1.SetToolTip(Me.btnfueraLinea, "Saca el empleado a la linea")
        Me.Linea = linea
        dtpInicio.activarFoco()
    End Sub

    Public Sub New()

        InitializeComponent()

        dtb = New BasesParaCompatibilidad.DataBase
        Me.formato = New DBO_FormatosEnvasados
        Me.dboTipoLinea = New DBO_TiposFormatosLineas_TiposFormatos
        Me.spTiposFormatosLineas_TiposFormatos = New spTiposFormatosLineas_TiposFormatos

        Me.ToolTip1.SetToolTip(Me.btnALinea, "Añade el empleado a la linea")
        Me.ToolTip1.SetToolTip(Me.btnfueraLinea, "Saca el empleado a la linea")
        dtpInicio.activarFoco()
    End Sub

    Private Sub btnALinea_Click(sender As System.Object, e As System.EventArgs) Handles btnALinea.Click
        If Not Me.dgvEnLinea.CurrentRow Is Nothing Then
            Me.DgvDisponibles.Rows.Add(New String() {Me.dgvEnLinea.CurrentRow.Cells(0).Value, Me.dgvEnLinea.CurrentRow.Cells(1).Value})
            Me.dgvEnLinea.Rows.Remove(Me.dgvEnLinea.CurrentRow)
            PersonalEnLinea_refresh()
        End If
    End Sub

    Private Sub btnfueraLinea_Click(sender As System.Object, e As System.EventArgs) Handles btnfueraLinea.Click
        If Not Me.DgvDisponibles.CurrentRow Is Nothing Then
            Me.dgvEnLinea.Rows.Add(New String() {Me.DgvDisponibles.CurrentRow.Cells(0).Value, Me.DgvDisponibles.CurrentRow.Cells(1).Value, If(Me.dgvEnLinea.Rows.Count + 1 > Me.lRecomendado.Text, True, False)})
            Me.DgvDisponibles.Rows.Remove(Me.DgvDisponibles.CurrentRow)
            PersonalEnLinea_refresh()
        End If
    End Sub

    Private Sub PersonalEnLinea_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim dtLinea As DataTable
        Dim dtEmpleados As DataTable
        Dim spEmlpeados As New spEmpleados

        dtEmpleados = spEmlpeados.devolver_Empleados_Envasados_libres(dtb)
        dtLinea = spEmlpeados.devolver_empleados_por_linea_libres(Me.Linea, dtb)


        If dtEmpleados Is Nothing Or dtLinea Is Nothing Then
            MessageBox.Show("No se pudo recuperar los datos. Introduzca el personal que arranca la linea manualmente.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If

        For Each row As DataRow In dtEmpleados.Rows
            DgvDisponibles.Rows.Add(New String() {row(0), row(1)})
        Next

        For Each row As DataRow In dtLinea.Rows
            dgvEnLinea.Rows.Add(New String() {row(0), row(1)})
        Next

        For Each row As DataGridViewRow In Me.dgvEnLinea.Rows
            For Each ro2 As DataGridViewRow In Me.DgvDisponibles.Rows
                If row.Cells(0).Value = ro2.Cells(0).Value Then
                    Me.DgvDisponibles.Rows.Remove(ro2)
                End If
            Next
        Next



        Dim spEnvasados As New spEnvasados
        Dim dbo_envasados As DBO_Envasados = spEnvasados.Select_Record(m_envasadoID, dtb)
        Me.dtpInicio.Value = New DateTime(dbo_envasados.Fecha.Year, dbo_envasados.Fecha.Month, dbo_envasados.Fecha.Day, Now.Hour, Now.Minute, Now.Second)

        Dim frm As New frmPersonalEnvasadoOcupado(Me.m_envasadoID)
        Engine_LA.FormEnPestaña(frm, Me.panOcupados)
    End Sub



    Private Sub PersonalEnLinea_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.pantalla.centerIn(Me.Panel1, Me)
    End Sub

    Private Sub PersonalEnLinea_refresh() Handles Me.formato_changed
        Try
            dboTipoLinea = spTiposFormatosLineas_TiposFormatos.Select_Record(spTiposFormatosLineas_TiposFormatos.Select_Id_By(formato.TipoFormatoLineaID, formato.TipoFormatoEnvasadoID, dtb), dtb)
            Me.lRecomendado.Text = dboTipoLinea.PersonalRecomendado

            If Me.dgvEnLinea.Rows.Count > Me.lRecomendado.Text Then
                'Dim cont As Integer = lRecomendado.Text
                Dim cont As Integer = 0
                While cont < lRecomendado.Text
                    If Convert.ToBoolean(Me.dgvEnLinea.Rows(cont).Cells(2).Value) Then
                        Me.dgvEnLinea.Rows(cont).Cells(2).Value = False
                    End If
                    cont = cont + 1
                End While

                While cont < Me.dgvEnLinea.Rows.Count
                    If Not Convert.ToBoolean(Me.dgvEnLinea.Rows(cont).Cells(2).Value) Then
                        Me.dgvEnLinea.Rows(cont).Cells(2).Value = True
                    End If
                    cont = cont + 1
                End While

            Else
                For Each row As DataGridViewRow In Me.dgvEnLinea.Rows
                    row.Cells(2).Value = False
                Next
            End If
        Catch ex As Exception
            Me.lRecomendado.Text = 0
        End Try
    End Sub

    Public Function getVAlores() As Boolean
        If Me.dgvEnLinea.Rows.Count > 0 Then
            If Me.dgvEnLinea.Rows.Count >= Me.lRecomendado.Text Then
                Return True
            Else
                Dim res As DialogResult = MessageBox.Show("Hay menos empleados de lo recomendado, ¿es esto correcto?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If res = DialogResult.Yes Then
                    Return True
                Else
                    Return False
                End If
            End If
        Else
            Return True
        End If

    End Function

    Public Function guardar(ByVal formatoEnvasado As Integer) As Boolean
        If Me.dgvEnLinea.Rows.Count > 0 Then
            Dim sp As New spempleados_formatosEnvasados
            Dim dbo As New DBO_empleados_formatosEnvasados
            dbo.Inicio = New TimeSpan(Me.dtpInicio.Value.Hour, Me.dtpInicio.Value.Minute, 0)
            'dbo.Inicio = New Date(Now.Year, Now.Month, Now.Day, Now.Hour, Now.Minute, Now.Second)
            dbo.id_formatoEnvasado = formatoEnvasado
            'dtb.EmpezarTransaccion()
            'Try
            For Each row As DataGridViewRow In Me.dgvEnLinea.Rows
                dbo.id_empleado = row.Cells(0).Value
                If Not sp.Grabar(dbo, Nothing) Then
                    '        dtb.CancelarTransaccion ()
                    MessageBox.Show("No se pudo guardar los datos. Introduzca el personal que arranca la linea manualmente.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    '        Me.Close()
                Else
                    If Convert.ToBoolean(row.Cells(2).Value) Then
                        Dim spCausas As New spPartesEnvasados_CausasPartesEnvasado
                        Dim dboCAusas As New DBO_PartesEnvasados_CausasPartesEnvasado
                        dboCAusas.Id_ParteEnvasado = sp.seleccionarUltimoRegistro(dtb)
                        dboCAusas.Id_CausaParteEnvasado = 3
                        spCausas.Grabar(dboCAusas, dtb)
                    End If
                End If
            Next

            'dtb.TerminarTransaccion ()
            'Catch ex As Exception
            'dtb.CancelarTransaccion ()
            'End Try
            For Each row As DataGridViewRow In Me.dgvEnLinea.Rows

                'GUIEnvasado.EmpleadosEnLinea.Add()
            Next



            'Me.Close()
            Return True
        Else
            MessageBox.Show("No ha confirmado el personal que estará en la linea", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

End Class