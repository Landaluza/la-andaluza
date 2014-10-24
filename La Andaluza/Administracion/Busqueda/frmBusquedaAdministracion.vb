Public Class frmBusquedaAdministracion    
    Private spBusqueda As spBusquedaAdministracion
    Private datasource As DataTable
    Private img As DataGridViewImageColumn
    Private row As DataGridViewRow
    Private c As DataGridViewImageCell
    Private dtb As BasesParaCompatibilidad.DataBase
    Public Sub New()

        InitializeComponent()
        dtb = New BasesParaCompatibilidad.DataBase
        spBusqueda = New spBusquedaAdministracion

        img = New DataGridViewImageColumn()
        img.HeaderText = ""
        img.Name = "s"
        img.Image = My.Resources.package_broken
        img.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        img.Width = 15
        img.DisplayIndex = 0
        dgvResultados.Columns.Add(img)
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBusqueda.TextChanged
        datasource = spBusqueda.recuperarDatos(txtBusqueda.Text, dtb, Me.cbCamiones.Checked, Me.cbConductores.Checked)

        If Not datasource Is Nothing Then
            Me.dgvResultados.SuspendLayout()
            Me.dgvResultados.DataSource = datasource
            Me.dgvResultados.Columns("id").Visible = False
            Me.dgvResultados.Columns("tipo").Visible = False
            Me.dgvResultados.Columns("nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            Me.dgvResultados.Columns("nombre").Width = 140

            For Each row In dgvResultados.Rows
                c = row.Cells("s")

                Select Case Convert.ToInt32(row.Cells("tipo").Value)
                    Case 1
                        c.Value = My.Resources.vcard
                    Case Else
                        c.Value = My.Resources.car
                End Select
            Next

            Me.dgvResultados.ResumeLayout()
        End If
    End Sub


    Private Sub dgvResultados_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvResultados.CellClick
        Dim id As Integer = Convert.ToInt32(Me.dgvResultados.CurrentRow.Cells("id").Value)
        Select Case Convert.ToInt32(Me.dgvResultados.CurrentRow.Cells("tipo").Value)
            Case 1
                Dim sp As New spConductores
                Dim dbo As DBO_Conductores = sp.Select_Record(id, dtb)

                Dim frm As New frmEntConductores(BasesParaCompatibilidad.GridSimpleForm.ACCION_MODIFICAR, sp, dbo)
                GUImain.añadirPestaña(frm)
            Case 2
                Dim sp As New spCamiones
                Dim dbo As DBO_Camiones = sp.Select_Record(id, dtb)

                Dim frm As New frmEntCamiones(BasesParaCompatibilidad.GridSimpleForm.ACCION_MODIFICAR, sp, dbo)
                GUImain.añadirPestaña(frm)
        End Select
    End Sub

    Private Sub frmBusquedaAdministracion_Enter(sender As System.Object, e As System.EventArgs) Handles MyBase.Enter
        txtBusqueda.Focus()
    End Sub

End Class