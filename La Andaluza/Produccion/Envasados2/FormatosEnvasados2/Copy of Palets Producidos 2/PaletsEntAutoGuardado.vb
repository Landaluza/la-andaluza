Public Class PaletsEntAutoGuardado
    Private frmPadre As frmEntPaletsProducidos2
    Private spPaletsProducidos2 As spPaletsProducidos2
    Private dtb As BasesParaCompatibilidad.DataBase
    Public Sub New(ByRef frm As frmEntPaletsProducidos2)
        InitializeComponent()
        dtb = New BasesParaCompatibilidad.DataBase
        spPaletsProducidos2 = New spPaletsProducidos2
        Me.frmPadre = frm
    End Sub

    Private Sub PaletsEntAutoGuardado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim PaletProducidoID As Integer = 0

        While spPaletsProducidos2.message <> ""
            Me.pbSCC.Value = 0
            Me.lMensaje.Text = "Buscando nuevo scc"
            frmPadre.actualizar_sscc()

            Me.pbSCC.Value = 50
            Me.lMensaje.Text = "Guardando el palet"

            Try
                PaletProducidoID = spPaletsProducidos2.InsertPaletsProducidos2(frmPadre.m_DBO_PaletProducido, dtb)
            Catch ex As Exception
            End Try


            If spPaletsProducidos2.message <> "" Then
                Me.pbSCC.Value = 75
                Me.lMensaje.Text = "Reintentando la operacion"
                System.Threading.Thread.Sleep(1000)
            End If

        End While

        Me.frmPadre.m_DBO_PaletProducido.PaletProducidoID = PaletProducidoID

        Me.pbSCC.Value = 100
        Me.lMensaje.Text = "Palet guardado con el scc " & Me.frmPadre.m_DBO_PaletProducido.SCC
        Me.btnCancelar.Text = "Aceptar"

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click        
        If Me.btnCancelar.Text = "Aceptar" Then        
            Me.frmPadre.Close()
        End If

        Me.Close()
    End Sub
End Class