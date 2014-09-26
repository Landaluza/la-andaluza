Public Class wizard
    Private Const CNEXT As Integer = 1
    Private Const CPREVIOUS As Integer = -1
    Protected wizardStep As Integer
    Protected forms As Collection
    Protected titles As Collection
    Public Event FinishWizard()
    Public Event PanelChanged(ByRef panel As Windows.Forms.Form)
    Protected title As String

    Public Sub New()

        InitializeComponent()

        Me.forms = New Collection
        Me.titles = New Collection
        Me.wizardStep = 1
    End Sub

    Public Sub New(ByVal paneles As Collection, ByVal titles As Collection, ByVal title As String)
        InitializeComponent()

        Me.forms = paneles
        Me.titles = titles
        Me.title = title
        Me.wizardStep = 1
        Me.Text = title
        Me.cambiarPanel(1)
    End Sub

    Public WriteOnly Property PanelesPasos As Collection
        Set(ByVal value As Collection)
            Me.forms = value
        End Set
    End Property

    Public WriteOnly Property TitulosPasos As Collection
        Set(ByVal value As Collection)
            Me.titles = value
        End Set
    End Property

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click

        action(wizardStep, CPREVIOUS)

    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click


        action(wizardStep, CNEXT)

    End Sub

    Protected Sub action(ByVal actualstep As Integer, ByVal way As Integer)
        If way = CPREVIOUS Then
            If actualstep - 1 > 0 Then
                cambiarPanel(actualstep - 1)
            End If

            Select Case (actualstep)
                Case 1
                    Me.Close()
                Case 2
                    Me.btnPrev.Image = My.Resources.dialog_cancel_3
                    Me.btnPrev.Text = "Cancelar"
                Case forms.Count
                    Me.btnNext.Image = My.Resources.go_next_5
                    Me.btnNext.Text = "Siguiente"
            End Select

            Me.wizardStep += way
        Else
            If Me.forms.Item(actualstep).comprobarCampos Then
                If actualstep + 1 <= Me.forms.Count Then
                    cambiarPanel(actualstep + 1)
                End If

                Select Case (actualstep)
                    Case Is = 1 And actualstep <> forms.Count
                        Me.btnPrev.Image = My.Resources.go_previous_5
                        Me.btnPrev.Text = "Anterior"

                        If actualstep = forms.Count - 1 Then
                            Me.btnNext.Image = My.Resources.dialog_apply
                            Me.btnNext.Text = "Finalizar"
                        End If
                    Case forms.Count - 1
                        Me.btnNext.Image = My.Resources.dialog_apply
                        Me.btnNext.Text = "Finalizar"
                    Case forms.Count
                        RaiseEvent FinishWizard()
                End Select

                If actualstep < Me.forms.Count Then Me.wizardStep += way
            End If
        End If
    End Sub

    Protected Sub cambiarPanel(ByVal actualstep As Integer)
        Dim form As Windows.Forms.Form = Me.forms.Item(actualstep)
        Me.Width = form.Width + 100
        Me.Height = form.Height + 145

        Engine_LA.FormEnPestaña(Me.forms.Item(actualstep), PanCentral)
        Me.lTitle.Text = Me.titles.Item(actualstep)
        BasesParaCompatibilidad.Pantalla.centerHorizontalyIn(Me.lTitle, Me.panTitle)
        Me.Text = title & " paso " & actualstep & " de " & Me.forms.Count

        Me.forms.Item(actualstep).EstablecerValores()

        Select Case (actualstep)
            Case 1
                Me.btnPrev.Image = My.Resources.dialog_cancel_3
                Me.btnPrev.Text = "Cancelar"

                If actualstep = forms.Count Then
                    Me.btnNext.Image = My.Resources.dialog_apply
                    Me.btnNext.Text = "Finalizar"
                Else
                    Me.btnNext.Image = My.Resources.go_next_5
                    Me.btnNext.Text = "Siguiente"
                End If
            Case forms.Count - 1
                Me.btnNext.Image = My.Resources.dialog_apply
                Me.btnNext.Text = "Finalizar"
                Me.btnPrev.Image = My.Resources.go_previous_5
                Me.btnPrev.Text = "Anterior"
        End Select
        Me.CenterToParent()
        RaiseEvent PanelChanged(Me.forms.Item(actualstep))
    End Sub

    Public Function guardar() As Boolean
        Me.Cursor = Cursors.WaitCursor
        Me.btnNext.Enabled = False
        Me.btnPrev.Enabled = False

        Dim retorno As Boolean
        BasesParaCompatibilidad.BD.EmpezarTransaccion()
        retorno = True

        Try
            For Each frm As Object In Me.forms
                retorno = retorno And frm.grabarDatos()
            Next

            If retorno Then
                BasesParaCompatibilidad.BD.TerminarTransaccion()
            Else
                BasesParaCompatibilidad.BD.CancelarTransaccion()
            End If
        Catch ex As Exception
            BasesParaCompatibilidad.BD.CancelarTransaccion()
            retorno = False
        End Try

        Me.btnNext.Enabled = True
        Me.btnPrev.Enabled = True
        Me.Cursor = Cursors.Default
        Return retorno
    End Function

    Public Sub añadirPaso(ByVal frm As Form, ByVal title As String)
        Me.forms.Add(frm)
        Me.titles.Add(title)
    End Sub

    Private Sub wizard_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.Pantalla.centerHorizontalyIn(Me.lTitle, Me.panTitle)
    End Sub
End Class