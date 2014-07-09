Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmSeleccionMonodosis
    Private dbo As Dbo_DoyPack
    Private descripcionMonodosis As String
    Private spMonodosis As spMonodosis

    Public ReadOnly Property Descripcion As String
        Get
            Return descripcionMonodosis
        End Get
    End Property

    Public ReadOnly Property monodosis As Dbo_DoyPack
        Get
            Return Me.dbo
        End Get
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        spMonodosis = New spMonodosis

    End Sub
    Private Sub frmSeleccionMonodosis_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim filterManager As New DgvFilterPopup.DgvFilterManager(Me.DataGridView1)
        dgvFill()
    End Sub

    Private Sub dgvFill()
        Dim dt As DataTable = spMonodosis.selectDgv
        If Not dt Is Nothing Then
            Me.DataGridView1.DataSource = dt
            Me.DataGridView1.Columns("ArticuloId").Visible = False
            Me.DataGridView1.FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Descripcion, True)
        Else
            Me.btnAceptar.Enabled = False
        End If
    End Sub

    Private Sub terminar()
        Me.dbo = New Dbo_DoyPack

        If Not IsNumeric(Me.txtCantidad.Text) Then
            MessageBox.Show("La cantidad debe ser numérica", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If Me.DataGridView1.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione una fila antes", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Me.descripcionMonodosis = Me.DataGridView1.CurrentRow.Cells("Descripcion").Value
        dbo.Cantidad = txtCantidad.Text
        dbo.MonodosisID = Me.DataGridView1.CurrentRow.Cells("ArticuloId").Value
        Me.Close()
    End Sub

    Private Sub frmSeleccionMonodosis_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.DetailedSimpleForm.centerHorizontalyIn(Me.Panel4, Me.Panel3)
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        terminar()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.dbo = Nothing
        Me.descripcionMonodosis = ""
        Me.Close()
    End Sub

    Private Sub frmSeleccionMonodosis_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Me.DataGridView1.Rows(0).Selected = True
        Me.DataGridView1.Focus()
        Me.txtCantidad.Focus()
        BasesParaCompatibilidad.DetailedSimpleForm.centerHorizontalyIn(Me.Panel4, Me.Panel3)
    End Sub

    Private Sub frmSeleccionMonodosis_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = 23 Then
            terminar()
        End If
    End Sub
End Class