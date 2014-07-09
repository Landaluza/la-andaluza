﻿Public Class frmWstepArticulos1
    Implements  BasesParaCompatibilidad.wizardable
    Private m_DBO_Articulos1 As DBO_Articulos1
    Private no_crear As Boolean

    Public ReadOnly Property EstaDescripcionHabilitada As Boolean
        Get
            Return Me.txtDescripcion.Visible
        End Get
    End Property

    Public ReadOnly Property EsdescripcionEditable As Boolean
        Get
            Return Me.txtDescripcion.Enabled
        End Get
    End Property

    Public Property Datos As DBO_Articulos1
        Set(value As DBO_Articulos1)
            Me.m_DBO_Articulos1.Activo = value.Activo            
            Me.m_DBO_Articulos1.CodigoLA = value.CodigoLA
            Me.m_DBO_Articulos1.CodigoQS = value.CodigoQS
            Me.m_DBO_Articulos1.CodigoTARIC = value.CodigoTARIC
            Me.m_DBO_Articulos1.DescripcionLA = value.DescripcionLA
            Me.m_DBO_Articulos1.InformacionGeneral = value.InformacionGeneral
            Me.m_DBO_Articulos1.Observaciones = value.Observaciones
            asignar()
            deshabilitarCampos()
        End Set
        Get
            Return Me.m_DBO_Articulos1
        End Get
    End Property

    Private Sub asignar()
        Me.txtCodigoLA.Text = m_DBO_Articulos1.CodigoLA
        Me.txtCodigoQS.Text = m_DBO_Articulos1.CodigoQS
        Me.txtCodigoTARIC.Text = m_DBO_Articulos1.CodigoTARIC
        Me.txtDescripcion.Text = m_DBO_Articulos1.DescripcionLA
        Me.txtObservaciones.Text = m_DBO_Articulos1.Observaciones
        Me.txtUtilizacion.Text = m_DBO_Articulos1.Utilizacion
        Me.txtInfoGeneral.Text = m_DBO_Articulos1.InformacionGeneral
        Me.chbTienePedidos.Checked = m_DBO_Articulos1.TienePedidos
        Me.chbActivo.Checked = m_DBO_Articulos1.Activo
    End Sub

    Private Sub deshabilitarCampos()
        Me.txtCodigoLA.Enabled = False
        Me.txtCodigoQS.Enabled = False
        Me.txtCodigoTARIC.Enabled = False
        Me.txtDescripcion.Enabled = False
        Me.txtObservaciones.Enabled = False
        Me.txtUtilizacion.Enabled = False
        Me.txtInfoGeneral.Enabled = False
        Me.chbTienePedidos.Enabled = False
        Me.chbActivo.Enabled = False
    End Sub

    Public Sub New()

        InitializeComponent()

        m_DBO_Articulos1 = New DBO_Articulos1
        Me.no_crear = True
    End Sub

    Public Sub New(ByVal descripcionManual As Boolean, TipoArticulo As Integer)
        Me.New()

        If descripcionManual Then
            Me.lDescripcion.Visible = True
            Me.txtDescripcion.Visible = True
        End If

        If TipoArticulo <> Nothing Then
            Me.m_DBO_Articulos1.ArticuloTpoID = TipoArticulo
            Me.chbActivo.Enabled = False
            Me.chbActivo.Checked = True
        End If
    End Sub

    Public Sub New(ByVal articuloID As Integer)
        Dim spArticulos1 As New spArticulos1
        InitializeComponent()

        Me.m_DBO_Articulos1 = spArticulos1.Select_Record(articuloID)
        Me.lDescripcion.Visible = True
        Me.txtDescripcion.Visible = True

        If Me.m_DBO_Articulos1.ArticuloTpoID = 9 Or Me.m_DBO_Articulos1.ArticuloTpoID = 10 Then '9=Secundario, 10 = terciarios
            If Config.UserType <> 1 And Config.UserType <> 9 And Config.UserType <> 4 Then
                Me.lDescripcion.Enabled = False
                Me.txtDescripcion.Enabled = False
            End If

            chbTienePedidos.Visible = False

            If Me.m_DBO_Articulos1.ArticuloTpoID = 10 Then '10 = terciarios
                Me.lblCodigoTARIC.Visible = False
                Me.txtCodigoTARIC.Visible = False
                'Me.lblCodigoQS.Visible = False
                'Me.txtCodigoQS.Visible = False
            End If
        End If

        Me.no_crear = True
        establecerValores()
    End Sub

    Public WriteOnly Property TipoArticulo As Integer
        Set(ByVal value As Integer)
            m_DBO_Articulos1.ArticuloTpoID = value
        End Set
    End Property

    Public WriteOnly Property Descripcion As String
        Set(ByVal value As String)
            m_DBO_Articulos1.DescripcionLA = value
        End Set
    End Property

    Public ReadOnly Property QS As Integer
        Get
            Return m_DBO_Articulos1.CodigoLA
        End Get
    End Property

    Public WriteOnly Property NoCrearSecundario As Boolean
        Set(ByVal value As Boolean)
            Me.no_crear = value
        End Set
    End Property

    Private Sub frmWstepArticulos1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.DetailedSimpleForm.centerIn(Me.panContenidos, Me)
    End Sub

    Public Sub establecerValores() Implements  BasesParaCompatibilidad.wizardable.EstablecerValores
        If Me.m_DBO_Articulos1.ID <> Nothing Then
            Me.txtCodigoLA.Text = m_DBO_Articulos1.CodigoLA
            Me.txtCodigoQS.Text = m_DBO_Articulos1.CodigoQS
            Me.txtCodigoTARIC.Text = m_DBO_Articulos1.CodigoTARIC
            Me.txtDescripcion.Text = m_DBO_Articulos1.DescripcionLA
            Me.txtObservaciones.Text = m_DBO_Articulos1.Observaciones
            Me.txtUtilizacion.Text = m_DBO_Articulos1.Utilizacion
            Me.txtInfoGeneral.Text = m_DBO_Articulos1.InformacionGeneral
            Me.chbTienePedidos.Checked = m_DBO_Articulos1.TienePedidos
            Me.chbActivo.Checked = m_DBO_Articulos1.Activo
            Me.txtEvolucion.Text = m_DBO_Articulos1.EvolucionPrecio
        End If
    End Sub

    Public Function recuperarValor(ByVal nombre As String) As Object Implements  BasesParaCompatibilidad.wizardable.recuperarValor
        Return Nothing
    End Function

    Public Function grabarDatos() As Boolean Implements  BasesParaCompatibilidad.wizardable.grabarDatos
        Dim spArticulos1 As New spArticulos1
        If Me.m_DBO_Articulos1.ArticuloTpoID = Nothing Then
            Return False
        Else
            If Me.no_crear Then
                Return spArticulos1.Grabar(m_DBO_Articulos1, BasesParaCompatibilidad.BD.transaction)
            Else
                Return True
            End If
        End If
    End Function

    Public Function comprobarCampos() As Boolean Implements  BasesParaCompatibilidad.wizardable.comprobarCampos

        Dim errores As String = ""
        Dim respuesta As Boolean = True

        If Me.Enabled Then
            m_DBO_Articulos1.CodigoTARIC = If(txtCodigoTARIC.Text = "", String.Empty, txtCodigoTARIC.Text)
            m_DBO_Articulos1.Utilizacion = If(txtUtilizacion.Text = "", String.Empty, txtUtilizacion.Text)
            m_DBO_Articulos1.InformacionGeneral = Me.txtInfoGeneral.Text
            m_DBO_Articulos1.TienePedidos = Me.chbTienePedidos.Checked
            m_DBO_Articulos1.EvolucionPrecio = Me.txtEvolucion.Text

            If Me.txtDescripcion.Visible Then
                'If Me.txtDescripcion.Text = String.Empty Then
                '    txtDescripcion.Focus()
                '    errores = errores & "El campo 'Descripción' no pude estar vacío" & Environment.NewLine
                'Else
                '    m_DBO_Articulos1.DescripcionLA = txtDescripcion.Text
                '    m_DBO_Articulos1.DescripcionCorta = txtDescripcion.Text
                '    m_DBO_Articulos1.DescripcionQS = txtDescripcion.Text
                'End If
                m_DBO_Articulos1.DescripcionLA = txtDescripcion.Text
            End If

            If txtCodigoLA.Text = "" Or Not IsNumeric(txtCodigoLA.Text) Then
                txtCodigoLA.Focus()
                errores = errores & "El valor de 'CodigoLA' debe ser numerico" & Environment.NewLine
            Else
                m_DBO_Articulos1.CodigoLA = System.Convert.ToInt32(If(txtCodigoLA.Text = "", Nothing, txtCodigoLA.Text))
            End If


            If txtCodigoQS.Text = "" Or Not IsNumeric(txtCodigoQS.Text) Then
                txtCodigoQS.Focus()
                errores = errores & "El valor de 'CodigoQS' debe ser numerico" & Environment.NewLine
            Else
                m_DBO_Articulos1.CodigoQS = System.Convert.ToInt32(If(txtCodigoQS.Text = "", Nothing, txtCodigoQS.Text))
            End If

            If txtCodigoLA.Text <> txtCodigoQS.Text Then
                If MessageBox.Show("Los codigos QS y La no coinciden, ¿es esto correcto?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> Windows.Forms.DialogResult.Yes Then

                    Return False
                End If

            End If

            m_DBO_Articulos1.Activo = Me.chbActivo.Checked
            m_DBO_Articulos1.Observaciones = If(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)
            m_DBO_Articulos1.TienePedidos = System.Convert.ToBoolean(If(chbTienePedidos.Checked = False, False, chbTienePedidos.Checked))
        End If

        If errores <> "" Then
            MessageBox.Show("Complete correctamente el formulario. Se han encontrado los siguientes errores: " & Environment.NewLine & errores, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        Else
            If respuesta Then
                Return True
            Else
                Return False
            End If
        End If
    End Function

    Private Sub btnInformacion_Click(sender As System.Object, e As System.EventArgs) Handles btnInformacion.Click
        Dim fc As New OpenFileDialog
        fc.InitialDirectory = Me.txtInfoGeneral.Text
        fc.ShowDialog()

        Try
            Me.txtInfoGeneral.Text = fc.FileName
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnEvolucion_Click(sender As System.Object, e As System.EventArgs) Handles btnEvolucion.Click
        Dim fc As New OpenFileDialog
        fc.InitialDirectory = Me.txtEvolucion.Text
        fc.ShowDialog()

        Try
            Me.txtEvolucion.Text = fc.FileName
        Catch ex As Exception
        End Try
    End Sub
End Class