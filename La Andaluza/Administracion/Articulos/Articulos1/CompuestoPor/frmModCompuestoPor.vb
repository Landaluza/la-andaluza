Imports BasesParaCompatibilidad.ComboBoxExtension
Public Class frmModCompuestoPor
    Private m_dbo As DBO_Articulos1CompuestoPor
    Private sp As spArticulos1CompuestoPor

    Public Sub New(ByVal id As Integer, Optional ByVal idCompuesto As Integer = 0)
        InitializeComponent()

        sp = New spArticulos1CompuestoPor
        m_dbo = New DBO_Articulos1CompuestoPor
        m_dbo.ArticuloPrincipal = id

        Me.cboArticulo.mam_DataSource(sp.CargarCombo(id), False)



        If idCompuesto <> 0 Then
            Me.cboArticulo.Enabled = False
            m_dbo.ArticuloComponente = idCompuesto
        End If

    End Sub

    Private Function getValores() As Boolean
        Dim errores As String = ""

        If Me.cboArticulo.SelectedValue Is Nothing Then
            errores &= "Seleccione un articulo en el desplegable. " & Environment.NewLine
        Else
            Me.m_dbo.ArticuloComponente = Me.cboArticulo.SelectedValue
        End If

        If Not IsNumeric(Me.txtcantidad.Text) Then
            errores &= "La cantidad debe ser numérica. " & Environment.NewLine
        Else
            Me.m_dbo.Cantidad = Me.txtcantidad.Text
        End If

        If errores = "" Then
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario. Se han encontrado los siguientes errores:" & Environment.NewLine & errores, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If getValores() Then

            If Me.cboArticulo.Enabled Then
                Dim formato As Integer
                Dim spdoypack As New spdoypack
                Dim spMonodosis As New spMonodosis

                If spdoypack.esDoypack(Me.m_dbo.ArticuloPrincipal) And spMonodosis.esMonodosis(Me.m_dbo.ArticuloComponente) Then
                    formato = spdoypack.FormatoPorArticulo(Me.m_dbo.ArticuloPrincipal)

                    If formato = Nothing Then
                        Dim frm As New frmDoyPackInfoExtra
                        'BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
                        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
                        formato = frm.result

                        If formato = Nothing Then
                            MessageBox.Show("Debe elegir un formato para el envasado de doypack. Se cancelará el guardado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Return
                        End If
                    End If
                End If

                If Me.sp.Insertar(Me.m_dbo.ArticuloPrincipal, Me.m_dbo.ArticuloComponente, Me.m_dbo.Cantidad, formato) Then
                    Me.Close()
                Else
                    MessageBox.Show("No se pudo guardar el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If Me.sp.Actualizar(Me.m_dbo.ArticuloPrincipal, Me.m_dbo.ArticuloComponente, Me.m_dbo.Cantidad) Then
                    Me.Close()
                Else
                    MessageBox.Show("No se pudo guardar el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If

    End Sub

    Private Sub frmModCompuestoPor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.cboArticulo.SelectedValue = If(m_dbo.ArticuloComponente = Nothing, 0, m_dbo.ArticuloComponente)
    End Sub
End Class