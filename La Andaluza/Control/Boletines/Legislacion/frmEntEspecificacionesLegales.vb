Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmEntEspecificacionesLegales
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As System.Object, e As System.EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_legislacionProductos As DBO_EspecificacionLegal

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spEspecificacionLegal = Nothing, Optional ByRef v_dbo As DBO_EspecificacionLegal = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spEspecificacionLegal, v_sp)
        m_DBO_legislacionProductos = If(v_dbo Is Nothing, New DBO_EspecificacionLegal, v_dbo)
        dbo = m_DBO_legislacionProductos
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEntlegislacionProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        butVer.Visible = True
    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_legislacionProductos = New DBO_EspecificacionLegal
        Else
            Me.m_DBO_legislacionProductos = dbo
        End If

        txtNombre.Text = m_DBO_legislacionProductos.Nombre
    End Sub

    Private Sub dgvFill()
        Dim spLegislacion As New spEspecificacionLegal()
        spLegislacion.cargarParametros(Me.dgv, dtb, If(Me.ModoDeApertura = MODIFICACION, Me.m_DBO_legislacionProductos.Id, Nothing))

        If Not dgv.DataSource Is Nothing Then
            With dgv
                .ReadOnly = False
                .Columns("parametroid").Visible = False
                .Columns("maximo").ReadOnly = False
                .Columns("minimo").ReadOnly = False
                .FormatoColumna("nombre", "Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("maximo", "Maximo", BasesParaCompatibilidad.TiposColumna.Double2, 80, 2)
                .FormatoColumna("minimo", "Minimo", BasesParaCompatibilidad.TiposColumna.Double2, 80, 3)
                '
            End With
        End If
    End Sub


    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty

        If txtNombre.Text = "" Then
            If errores = "" Then txtNombre.Focus()
            errores = errores & "El campo Nombre no puede estar vac�o." & Environment.NewLine()
        Else
            m_DBO_legislacionProductos.Nombre = txtNombre.Text
        End If

        '<Tag=[Two][End]> -- please do not remove this line
        If errores = String.Empty Then
            dbo = m_DBO_legislacionProductos
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'Error")
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar

        If Me.GetValores Then
            Dim terminar As Boolean
            If Not dtb Is Nothing Then
                Me.dtb = dtb
                terminar = False
            Else
                terminar = True
            End If

            Try
                If terminar Then Me.dtb.EmpezarTransaccion()

                If sp.Grabar(dbo, Me.dtb) Then
                    Dim splegislacionProductos As New spEspecificacionLegal
                    If Me.ModoDeApertura = MODIFICACION Then splegislacionProductos.borrarParametros(Me.m_DBO_legislacionProductos.Id, Me.dtb)

                    If splegislacionProductos.GuardarParametros(Me.dgv, Me.dtb, Me.m_DBO_legislacionProductos.Id) Then
                        If terminar Then Me.dtb.TerminarTransaccion()
                        RaiseEvent afterSave(Me, Nothing)
                        Me.Close()
                    Else
                        If terminar Then
                            Me.dtb.CancelarTransaccion()
                            MessageBox.Show("No se pudo guardar el registro. Asegurese de tener conexion a la red.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            Throw New Exception("Error 1 al guardar el registro")
                        End If
                    End If
                Else
                    If terminar Then
                        Me.dtb.CancelarTransaccion()
                        MessageBox.Show("No se pudo guardar el registro. Asegurese de tener conexion a la red.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        Throw New Exception("Error 2 al guardar el registro")
                    End If
                End If
            Catch ex As Exception
                If terminar Then
                    Me.dtb.CancelarTransaccion()
                    MessageBox.Show("No se pudo guardar el registro. Detalles:" & Environment.NewLine() & Environment.NewLine(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Throw New Exception("Error 3 al guardar el registro")
                End If
            End Try
        End If

    End Sub

    'Public Overrides Sub Ver()
    '    Try
    '        Dim psi As New ProcessStartInfo()
    '        psi.UseShellExecute = True
    '        psi.FileName = txtRuta.Text
    '        Process.Start(psi)
    '    Catch ex As Exception
    '        messageBox.show(ex.ToString)
    '    End Try
    'End Sub

    'Private Sub dgv_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellClick
    '    'If Me.dgv.Columns(e.ColumnIndex).Name = "maximo" Or Me.dgv.Columns(e.ColumnIndex).Name = "minimo" Then
    '    '    Me.dgv.ReadOnly = False
    '    'Else
    '    '    Me.dgv.ReadOnly = True
    '    'End If
    'End Sub

    Private Sub frmEntlegislacionProductos_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        dgvFill()
    End Sub


    'Private Sub btnBrowser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowser.Click
    '    If Me.txtWeb.Text <> "" Then
    '        Try
    '            Process.Start("IExplore.exe", Me.txtWeb.Text)
    '        Catch ex As Exception

    '        End Try
    '    End If
    'End Sub



    'Private Sub dgv_CellValueChanged(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellValueChanged


    'End Sub

    Private Sub dgv_DataError(sender As System.Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv.DataError

    End Sub



    'Private Sub dgv_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgv.CellFormatting
    '    If (dgv.Columns(e.ColumnIndex).Name = "maximo") Then
    '        If Not Convert.IsDBNull(e.Value) Then
    '            Dim deger As String = e.Value
    '            deger = String.Format("{0:0.00}", deger)
    '        End If
    '    End If
    'End Sub

    Private Sub dgv_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellEndEdit
        Try
            If Me.dgv.Columns(e.ColumnIndex).Name = "maximo" Or Me.dgv.Columns(e.ColumnIndex).Name = "minimo" Then

                '' Valor actual de la celda 
                'Dim value As String = dgv.CurrentCell.EditedFormattedValue.ToString
                '' Reemplazamos el punto por la coma Double. 
                ''value = value.Replace(",", ".")

                '' Escribimos el nuevo valor. 
                ''Dim cellValue As Double = CType(value / 100, Double)
                ''If dgv.CurrentCell.Value <> value Then
                'dgv.CurrentCell.Value = value
                ''End If

                Dim value As String = dgv.Rows(e.RowIndex).Cells(e.ColumnIndex).EditedFormattedValue.ToString
                dgv.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = value
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
