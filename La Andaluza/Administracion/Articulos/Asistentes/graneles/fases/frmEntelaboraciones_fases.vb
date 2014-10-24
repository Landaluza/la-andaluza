Public Class frmEntelaboraciones_fases
    Inherits Windows.Forms.Form
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_elaboraciones_fases As DBO_elaboraciones_fases
    Private mododeapertura As Integer
    Private sp As spelaboraciones_fases
    Private spArticulosGraneles As New spArticulosGraneles
    Private dtb As BasesParaCompatibilidad.DataBase
    Public Sub New(ByVal modoDeApertura As String, ByVal granelId As Integer, Optional id As Integer = Nothing)
        InitializeComponent()
        dtb = New BasesParaCompatibilidad.DataBase
        sp = New spelaboraciones_fases
        m_DBO_elaboraciones_fases = New DBO_elaboraciones_fases
        m_DBO_elaboraciones_fases.id_articuloGranel = granelId
        m_DBO_elaboraciones_fases.ID = id
        Me.mododeapertura = modoDeApertura
    End Sub


    Private Sub frmEntelaboraciones_fases_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        spArticulosGraneles.cargar_ArticulosGraneles(Me.cboid_articuloGranel, dtb)
    End Sub

    Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        If Me.mododeapertura = BasesParaCompatibilidad.DetailedSimpleForm.INSERCION Then
            'Me.m_DBO_elaboraciones_fases = New DBO_elaboraciones_fases
            Me.m_DBO_elaboraciones_fases.ID = Nothing
            If Me.m_DBO_elaboraciones_fases.id_articuloGranel <> Nothing Then
                Me.cboid_articuloGranel.Enabled = False
            End If
        Else
            Me.m_DBO_elaboraciones_fases = Me.sp.Select_Record(Me.m_DBO_elaboraciones_fases.ID, dtb)
            Me.cboid_articuloGranel.Enabled = False
            Me.txtfase.Enabled = False
        End If

        cboid_articuloGranel.SelectedValue = m_DBO_elaboraciones_fases.id_articuloGranel
        txtfase.Text = m_DBO_elaboraciones_fases.fase
        chbanalizar.Checked = m_DBO_elaboraciones_fases.analizar
        cbSobreTerminado.Checked = m_DBO_elaboraciones_fases.SobreTerminado
    End Sub

    Protected Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty

        If Not IsNumeric(Me.txtfase.Text) Then
            errores = errores & Environment.NewLine & " La fase debe ser numérica"
        Else
            Me.m_DBO_elaboraciones_fases.fase = Me.txtfase.Text
        End If

        If Me.cboid_articuloGranel.SelectedValue Is Nothing Then
            errores = errores & Environment.NewLine & "No seleccionó un valor para el granel"
        Else
            Me.m_DBO_elaboraciones_fases.id_articuloGranel = Me.cboid_articuloGranel.SelectedValue
        End If

        Me.m_DBO_elaboraciones_fases.analizar = Me.chbanalizar.Checked
        Me.m_DBO_elaboraciones_fases.SobreTerminado = Me.cbSobreTerminado.Checked

        If errores = String.Empty Then
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        If Me.GetValores Then
            If Me.mododeapertura = BasesParaCompatibilidad.DetailedSimpleForm.INSERCION Then
                If Me.sp.insertar(Me.m_DBO_elaboraciones_fases, dtb) Then
                    RaiseEvent afterSave(Me, Nothing)
                    Me.Close()
                End If
            Else
                If Me.sp.modificar(Me.m_DBO_elaboraciones_fases, dtb) Then
                    RaiseEvent afterSave(Me, Nothing)
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub tsGuardar_Click(sender As System.Object, e As System.EventArgs) Handles tsGuardar.Click
        Me.Guardar()
    End Sub

    Private Sub tssalir_Click(sender As System.Object, e As System.EventArgs) Handles tssalir.Click
        Me.Close()
    End Sub

    Private Sub frmEntelaboraciones_fases_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        SetValores()
    End Sub
End Class
