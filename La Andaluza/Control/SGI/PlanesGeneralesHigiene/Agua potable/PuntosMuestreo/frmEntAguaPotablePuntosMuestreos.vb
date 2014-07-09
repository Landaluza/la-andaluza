Public Class frmEntAguaPotablePuntosMuestreos
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_AguaPotablePuntosMuestreos As DBO_AguaPotablePuntosMuestreos

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spAguaPotablePuntosMuestreos = Nothing, Optional ByRef v_dbo As DBO_AguaPotablePuntosMuestreos = Nothing)
       MyBase.new(modoDeApertura, v_sp, v_dbo)
       InitializeComponent()
       sp = if(v_sp Is Nothing, New spAguaPotablePuntosMuestreos, v_sp)
       m_DBO_AguaPotablePuntosMuestreos = if(v_dbo Is Nothing, New DBO_AguaPotablePuntosMuestreos, v_dbo)
       dbo = m_DBO_AguaPotablePuntosMuestreos
   End Sub

   Public Sub New()
       InitializeComponent()
   End Sub

   Private Sub frmEntAguaPotablePuntosMuestreos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       dim s as new spEmpleados
       s.cargar_empleados(Me.cboResponsable)
       If me.mododeapertura = VISION Then
           Me.cboResponsable.enabled = False
           Me.lblResponsableID.enabled = False
           
       End If

   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
       If Me.modoDeApertura = INSERCION Then
       Me.m_DBO_AguaPotablePuntosMuestreos = new dbo_AguaPotablePuntosMuestreos
       Else
       Me.m_DBO_AguaPotablePuntosMuestreos = dbo
       End If

           cboResponsable.SelectedValue = m_DBO_AguaPotablePuntosMuestreos.ResponsableID
           txtReferencia.Text = m_DBO_AguaPotablePuntosMuestreos.Referencia
           txtDescripcion.Text = m_DBO_AguaPotablePuntosMuestreos.Descripcion
           txtObservaciones.Text = m_DBO_AguaPotablePuntosMuestreos.Observaciones
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty

        If txtReferencia.Text = "" Then
            errores &= Environment.NewLine & "El campo referencia no puede estar vacio"
        Else
            m_DBO_AguaPotablePuntosMuestreos.Referencia = txtReferencia.Text
        End If

        If txtDescripcion.Text = "" Then
            errores &= Environment.NewLine & "El campo descripcion no puede estar vacio"
        Else
            m_DBO_AguaPotablePuntosMuestreos.Descripcion = txtDescripcion.Text
        End If

        If Me.cboResponsable.SelectedValue is Nothing Then
            errores &= Environment.NewLine & "El campo responsable no puede estar vacio"
        Else
            Me.m_DBO_AguaPotablePuntosMuestreos.ResponsableID = cboResponsable.SelectedValue
        End If

        m_DBO_AguaPotablePuntosMuestreos.Observaciones = txtObservaciones.Text


        If errores = String.Empty Then
            dbo = m_DBO_AguaPotablePuntosMuestreos
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As sqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

   Private Sub butVerResponsableID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerResponsableID.Click
       Dim frmEnt As New frmEmpleados()
       frmEnt.ShowDialog()
   End Sub

   Private Sub butAddResponsableID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddResponsableID.Click
       Dim DBO_Empleados As New DBO_Empleados
        Dim frmEnt As New frmEntEmpleados(BasesParaCompatibilidad.DetailedSimpleForm.INSERCION, New spEmpleados, New DBO_Empleados)
       frmEnt.ShowDialog()
       dim s as new spEmpleados
       s.cargar_empleados(Me.cboResponsable)
   End Sub

End Class
