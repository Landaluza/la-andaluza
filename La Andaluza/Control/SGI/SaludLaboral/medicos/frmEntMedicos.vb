Public Class frmEntMedicos
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_Medicos As DBO_Medicos

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spMedicos = Nothing, Optional ByRef v_dbo As DBO_Medicos = Nothing)
       MyBase.new(modoDeApertura, v_sp, v_dbo)
       InitializeComponent()
       sp = if(v_sp Is Nothing, New spMedicos, v_sp)
       m_DBO_Medicos = if(v_dbo Is Nothing, New DBO_Medicos, v_dbo)
       dbo = m_DBO_Medicos
   End Sub

   Public Sub New()
       InitializeComponent()
   End Sub

   Private Sub frmEntMedicos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
       If Me.modoDeApertura = INSERCION Then
       Me.m_DBO_Medicos = new dbo_Medicos
       Else
       Me.m_DBO_Medicos = dbo
       End If

           txtnombre.Text = m_DBO_Medicos.nombre
           txtapellido.Text = m_DBO_Medicos.apellido
           txtapellido2.Text = m_DBO_Medicos.apellido2
           txtobservaciones.Text = m_DBO_Medicos.observaciones
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty

        If Me.txtnombre.Text = "" Then
            errores &= "El nombre no puede estar vacío" & Environment.NewLine
        Else
            Me.m_DBO_Medicos.nombre = Me.txtnombre.Text
        End If

        If Me.txtapellido.Text = "" Then
            errores &= "El primer apellido no puede estar vacío" & Environment.NewLine
        Else
            Me.m_DBO_Medicos.apellido = Me.txtapellido.Text
        End If
        Me.m_DBO_Medicos.apellido2 = Me.txtapellido2.Text
        Me.m_DBO_Medicos.observaciones = Me.txtobservaciones.Text




        If errores = String.Empty Then
            dbo = m_DBO_Medicos
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As sqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

End Class
