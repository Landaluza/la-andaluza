Public Class frmEntTiposProductos
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_TiposProductos As DBO_TiposProductos
    Private frmFamilia As frmFamliaProductos_TiposProductos
    Private frmClase As frmTiposProductos_ClasesProductos

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spTiposProductos = Nothing, Optional ByRef v_dbo As DBO_TiposProductos = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spTiposProductos, v_sp)
        m_DBO_TiposProductos = if(v_dbo Is Nothing, New DBO_TiposProductos, v_dbo)
        dbo = m_DBO_TiposProductos
    End Sub

    Public Sub New()
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spTiposProductos, New DBO_TiposProductos)
        InitializeComponent()
    End Sub

    Private Sub frmEntTiposProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spMedidasProductos
        s.cargar_MedidasProductos(Me.cboMedida)

        Dim s1 As New spPaletsProducidos
        s1.cargar_PaletsProducidos(Me.cboid_palet_no_conforme)

        If Me.mododeapertura = VISION Then
            Me.cboMedida.enabled = False
            Me.lblMedidaID.enabled = False

            Me.cboid_palet_no_conforme.enabled = False
            Me.lblid_palet_no_conforme.enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.modoDeApertura = INSERCION Then
            Me.m_DBO_TiposProductos = New dbo_TiposProductos
        Else
            Me.m_DBO_TiposProductos = dbo
        End If

        txtDescripcion.Text = m_DBO_TiposProductos.Descripcion
        txtAbreviatura.Text = m_DBO_TiposProductos.Abreviatura
        chbEnologico.Checked = m_DBO_TiposProductos.Enologico
        cboMedida.SelectedValue = m_DBO_TiposProductos.MedidaID
        If Not m_DBO_TiposProductos.id_palet_no_conforme = Nothing Then cboid_palet_no_conforme.SelectedValue = m_DBO_TiposProductos.id_palet_no_conforme

        If Me.ModoDeApertura <> INSERCION Then
            frmFamilia = New frmFamliaProductos_TiposProductos(Me.m_DBO_TiposProductos.ID)
            Me.frmClase = New frmTiposProductos_ClasesProductos(Me.m_DBO_TiposProductos.ID)
            Engine_LA.FormEnPestaña(frmFamilia, tpFamillia)
            Engine_LA.FormEnPestaña(frmClase, tpClase)
        Else
            Engine_LA.FormEnPestaña(New Form, tpFamillia)
            Engine_LA.FormEnPestaña(New Form, tpFamillia)
        End If

    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        If txtDescripcion.Text = "" Then
            If errores = "" Then txtDescripcion.Focus()
            errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_TiposProductos.Descripcion = txtDescripcion.Text
        End If



        If txtAbreviatura.Text = "" Then
            If errores = "" Then txtAbreviatura.Focus()
            errores = errores & "El campo Abreviatura no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_TiposProductos.Abreviatura = txtAbreviatura.Text
        End If



        m_DBO_TiposProductos.Enologico = chbEnologico.Checked

        If cboMedida.SelectedValue is Nothing Then
            If errores = "" Then cboMedida.Focus()
            errores = errores & "No seleccionó un valor para MedidaID." & Environment.NewLine
        Else
            m_DBO_TiposProductos.MedidaID = System.Convert.ToInt32(cboMedida.SelectedValue)
        End If

        If Me.chbNC.Checked Then
            Me.m_DBO_TiposProductos.id_palet_no_conforme = cboid_palet_no_conforme.SelectedValue
        End If

        If errores = String.Empty Then
            dbo = m_DBO_TiposProductos
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butVerMedidaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerMedidaID.Click
        Dim frmEnt As New frmMedidasProductos()
        frmEnt.ShowDialog()
    End Sub

    Private Sub butAddMedidaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddMedidaID.Click
        Dim DBO_MedidasProductos As New DBO_MedidasProductos
        Dim frmEnt As New frmEntMedidasProductos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spMedidasProductos, DBO_MedidasProductos)
        frmEnt.ShowDialog()
        Dim s As New spMedidasProductos
        s.cargar_MedidasProductos(Me.cboMedida)
    End Sub

  

    Private Sub chbNC_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbNC.CheckedChanged
        Me.cboid_palet_no_conforme.Enabled = Me.chbNC.Checked
    End Sub
End Class
