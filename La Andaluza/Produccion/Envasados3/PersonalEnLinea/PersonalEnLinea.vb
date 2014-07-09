Public Class PersonalEnLinea
    
    Dim spTiposFormatosLineas_TiposFormatos As spTiposFormatosLineas_TiposFormatos
    Dim dboTipoLinea As DBO_TiposFormatosLineas_TiposFormatos 

    Private formato As DBO_FormatosEnvasados
    Private Linea As Integer
    Private Event formato_changed()

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

    Public Sub New(ByVal linea As Integer, Optional ByVal embebido As Boolean = False)

        InitializeComponent()

        Me.formato = New DBO_FormatosEnvasados
        Me.dboTipoLinea = New DBO_TiposFormatosLineas_TiposFormatos
        Me.spTiposFormatosLineas_TiposFormatos = New spTiposFormatosLineas_TiposFormatos

        Me.ToolTip1.SetToolTip(Me.btnALinea, "Añade el empleado a la linea")
        Me.ToolTip1.SetToolTip(Me.btnfueraLinea, "Saca el empleado a la linea")
        Me.Linea = linea
        If embebido Then Me.btnConfirmar.Visible = False
    End Sub

    Public Sub New()

        InitializeComponent()

        Me.formato = New DBO_FormatosEnvasados
        Me.dboTipoLinea = New DBO_TiposFormatosLineas_TiposFormatos
        Me.spTiposFormatosLineas_TiposFormatos = New spTiposFormatosLineas_TiposFormatos

        Me.ToolTip1.SetToolTip(Me.btnALinea, "Añade el empleado a la linea")
        Me.ToolTip1.SetToolTip(Me.btnfueraLinea, "Saca el empleado a la linea")
    End Sub

    Private Sub btnALinea_Click(sender As System.Object, e As System.EventArgs) Handles btnALinea.Click
        If Not Me.dgvEnLinea.CurrentRow Is Nothing Then
            Me.DgvDisponibles.Rows.Add(New String() {Me.dgvEnLinea.CurrentRow.Cells(0).Value, Me.dgvEnLinea.CurrentRow.Cells(1).Value})
            Me.dgvEnLinea.Rows.Remove(Me.dgvEnLinea.CurrentRow)
        End If
    End Sub

    Private Sub btnfueraLinea_Click(sender As System.Object, e As System.EventArgs) Handles btnfueraLinea.Click
        If Not Me.DgvDisponibles.CurrentRow Is Nothing Then
            Me.dgvEnLinea.Rows.Add(New String() {Me.DgvDisponibles.CurrentRow.Cells(0).Value, Me.DgvDisponibles.CurrentRow.Cells(1).Value, if(Me.dgvEnLinea.Rows.Count + 1 > Me.lRecomendado.Text, True, False)})
            Me.DgvDisponibles.Rows.Remove(Me.DgvDisponibles.CurrentRow)
        End If
    End Sub

    Private Sub PersonalEnLinea_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim spEmlpeados As New spEmpleados
        Dim dtLinea As DataTable
        Dim dtEmpleados As DataTable

        dtEmpleados = spEmlpeados.devolver_Empleados_Envasados
        dtLinea = spEmlpeados.devolver_empleados_por_linea(Me.Linea)

        If dtEmpleados Is Nothing Or dtLinea Is Nothing Then
            messagebox.show("No se pudo recuperar los datos. Introduzca el personal que arranca la linea manualmente.","", MessageBoxButtons.OK, MessageBoxIcon.Error )
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
    End Sub

    Private Sub btnConfirmar_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirmar.Click
        guardar()
    End Sub

    Private Sub PersonalEnLinea_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.DetailedSimpleForm.centerIn(Me.Panel1, Me)
    End Sub

    Private Sub PersonalEnLinea_refresh() Handles Me.formato_changed
        Try
            dboTipoLinea = spTiposFormatosLineas_TiposFormatos.Select_Record(spTiposFormatosLineas_TiposFormatos.Select_Id_By(formato.TipoFormatoLineaID, formato.TipoFormatoEnvasadoID))
            Me.lRecomendado.Text = dboTipoLinea.PersonalRecomendado

            If Me.dgvEnLinea.Rows.Count > Me.lRecomendado.Text Then
                Dim cont As Integer = lRecomendado.Text

                While cont < Me.dgvEnLinea.Rows.Count
                    If Not Convert.ToBoolean(Me.dgvEnLinea.Rows(cont).Cells(2).Value) Then
                        Me.dgvEnLinea.Rows(cont).Cells(2).Value = True
                    End If
                    cont = cont + 1
                End While

            End If
        Catch ex As Exception
            Me.lRecomendado.Text = 0
        End Try
    End Sub

    Public Function guardar() As Boolean
        If Me.dgvEnLinea.Rows.Count > 0 Then
            'Dim sp As New spempleados_envasados
            'BasesParaCompatibilidad.BD.EmpezarTransaccion()
            'Try
            'For Each row As DataGridViewRow In Me.dgvEnLinea.Rows
            '    Me.dbo.Id_empleado = row.Cells(0).Value
            '    If Not sp.Grabar(dbo, BasesParaCompatibilidad.BD.transaction) Then
            '        BasesParaCompatibilidad.BD.CancelarTransaccion()
            '        messagebox.show("No se pudo guardar los datos. Introduzca el personal que arranca la linea manualmente.","", MessageBoxButtons.OK, MessageBoxIcon.Error )
            '        Me.Close()
            '    End If
            'Next

            'BasesParaCompatibilidad.BD.TerminarTransaccion()
            'Catch ex As Exception
            'BasesParaCompatibilidad.BD.CancelarTransaccion()
            'End Try
            For Each row As DataGridViewRow In Me.dgvEnLinea.Rows

                'GUIEnvasado.EmpleadosEnLinea.Add()
            Next



            'Me.Close()
            Return True
        Else
            messagebox.show("No ha confirmado el personal que estará en la linea", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function
End Class