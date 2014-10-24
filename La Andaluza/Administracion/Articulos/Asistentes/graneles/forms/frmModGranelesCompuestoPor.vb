Imports BasesParaCompatibilidad.ComboBoxExtension
Public Class frmModGranelesCompuestoPor
    Private m_dbo As DBO_articulosGranelesCompuestoPor
    Private sp As spArticulosGranelesCompuestoPor
    Private spArticulosGraneles As spArticulosGraneles
    Private dtb As BasesParaCompatibilidad.DataBase
    Public Sub New(ByVal id As Integer)
        InitializeComponent()

        dtb = New BasesParaCompatibilidad.DataBase()
        sp = New spArticulosGranelesCompuestoPor
        m_dbo = New DBO_articulosGranelesCompuestoPor
        spArticulosGraneles = New spArticulosGraneles
        m_dbo.Set_ArticuloPrincipal(id, dtb)

        Me.cboArticulo.mam_DataSource(sp.CargarCombo(id, dtb), False)

        Dim aux As New spelaboraciones_fases
        Dim d As DBO_ArticulosGraneles = spArticulosGraneles.Select_RecordByArticuloID(id, dtb)
        aux.cargar_elaboraciones_fases(Me.cboFase, d.GranelID, dtb)
    End Sub

    Public Sub New(ByVal id As Integer, ByVal id_compuesto As Integer, ByVal fase As Integer)
        InitializeComponent()

        Dim aux As New spelaboraciones_fases
        spArticulosGraneles = New spArticulosGraneles
        Dim d As DBO_ArticulosGraneles = spArticulosGraneles.Select_RecordByArticuloID(id, dtb)

        sp = New spArticulosGranelesCompuestoPor
        m_dbo = New DBO_articulosGranelesCompuestoPor
        m_dbo.Set_ArticuloPrincipal(id, dtb)

        Me.cboArticulo.mam_DataSource(sp.CargarCombo(id, dtb), False)

        aux.cargar_elaboraciones_fases(Me.cboFase, d.GranelID, dtb)

        Me.cboArticulo.Enabled = False
        m_dbo.Set_ArticuloComponente(id_compuesto, dtb)
        Me.m_dbo.Fase = fase
        Me.cboFase.SelectedValue = fase
        Me.cboFase.Enabled = False

        Me.sp.select_record(Me.m_dbo, dtb)
        Me.txtcantidad.Text = m_dbo.Cantidad
        Me.txtOrden.Text = Me.m_dbo.Orden
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If getValores() Then
            If Me.cboArticulo.Enabled Then
                If Me.sp.Insertar(Me.m_dbo, dtb) Then
                    Me.Close()
                Else
                    MessageBox.Show("No se pudo guardar el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If Me.sp.Actualizar(Me.m_dbo, dtb) Then
                    Me.Close()
                Else
                    MessageBox.Show("No se pudo guardar el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub frmModGranelesCompuestoPor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.cboArticulo.SelectedValue = If(m_dbo.ArticuloComponente = Nothing, 0, m_dbo.ArticuloComponente)

    End Sub

    Private Function getValores() As Boolean
        Dim errores As String = ""

        If Me.cboArticulo.SelectedValue Is Nothing Then
            errores &= "Seleccione un articulo en el desplegable. " & Environment.NewLine
        Else
            Me.m_dbo.Set_ArticuloComponente(Me.cboArticulo.SelectedValue, dtb)
        End If

        If Not IsNumeric(Me.txtcantidad.Text) Then
            errores &= "La cantidad debe ser numérica. " & Environment.NewLine
        Else
            Me.m_dbo.Cantidad = Me.txtcantidad.Text
        End If

        If Not IsNumeric(Me.txtOrden.Text) Then
            errores &= "El orden debe ser numérica. " & Environment.NewLine
        Else
            Me.m_dbo.Orden = Me.txtOrden.Text
        End If

        If Me.cboArticulo.SelectedValue Is Nothing Then
            errores &= "Seleccione una fase en el desplegable. " & Environment.NewLine
        Else
            Me.m_dbo.Fase = Me.cboFase.SelectedValue
        End If


        If errores = "" Then
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario. Se han encontrado los siguientes errores:" & Environment.NewLine & errores, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Private Sub btnaddfase_Click(sender As System.Object, e As System.EventArgs) Handles btnaddfase.Click
        Dim d As DBO_ArticulosGraneles = spArticulosGraneles.Select_RecordByArticuloID(Me.m_dbo.ArticuloPrincipal, dtb)
        Dim frm As New frmelaboraciones_fases(d.GranelID)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)

        Dim aux As New spelaboraciones_fases
        aux.cargar_elaboraciones_fases(Me.cboFase, d.GranelID, dtb)
    End Sub

    Private Sub cboArticulo_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cboArticulo.SelectedValueChanged
        Try
            Select Case cboArticulo.SelectedItem(2)
                Case 0
                    Me.lUnidad.Text = "nd"
                Case 1
                    Me.lUnidad.Text = "L"
                Case 2
                    Me.lUnidad.Text = "Kg"
            End Select
        Catch ex As Exception
            Me.lUnidad.Text = "nd"
        End Try

    End Sub
End Class