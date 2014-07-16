Public Class frmImportarExcel
    Private Pantalla As BasesParaCompatibilidad.Pantalla

    Public Sub New()

        InitializeComponent()

        Me.Pantalla = New BasesParaCompatibilidad.Pantalla
    End Sub

    Private Sub btnChooseFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChooseFile.Click
        If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.txtPath.Text = OpenFileDialog1.FileName.ToString

            If Not Me.txtPath.Text.Contains("JR") Then
                err.Visible = True
                Me.ToolTip3.SetToolTip(err, "Deberia ser un archivo de JR")
            End If
        End If
    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        If Me.txtPath.Text <> "" And IsNumeric(Me.txtResultados.Text) And Me.txtPath2.Text <> "" And IsNumeric(Me.TextBox1.Text) _
            And Me.txtPath3.Text <> "" And IsNumeric(Me.TextBox2.Text) And Me.txtPath4.Text <> "" And IsNumeric(Me.TextBox3.Text) Then            




            Dim importer As New ExcelImporter
            Me.Cursor = Cursors.WaitCursor

            If importer.import(Me.cbMonth.SelectedIndex + 1, Me.txtPath.Text, Me.txtResultados.Text) Then
                If err.Visible Then err.Visible = False
            Else
                If Not err.Visible Then err.Visible = True
            End If

            If importer.import(Me.cbMonth.SelectedIndex + 1, Me.txtPath2.Text, Me.TextBox1.Text) Then
                If err1.Visible Then err1.Visible = False
            Else
                If Not err1.Visible Then err1.Visible = True
            End If

            If importer.import(Me.cbMonth.SelectedIndex + 1, Me.txtPath3.Text, Me.TextBox2.Text) Then
                If err2.Visible Then err2.Visible = False
            Else
                If Not err2.Visible Then err2.Visible = True
            End If

            If importer.import(Me.cbMonth.SelectedIndex + 1, Me.txtPath4.Text, Me.TextBox3.Text) Then
                If err3.Visible Then err3.Visible = False
            Else
                If Not err3.Visible Then err3.Visible = True
            End If

            Me.Cursor = Cursors.Default
            If err.Visible Or err1.Visible Or err2.Visible Or err3.Visible Then
                MessageBox.Show("No se pudo importar el archivo. Se revertira la operación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not importer.delete(Me.cbMonth.SelectedIndex + 1, Today.Year) Then
                    MessageBox.Show("No se pudo revertir la operación." & Environment.NewLine & "Espere unos minutos e intente borrar el mes manualmente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else

                MessageBox.Show("Importado con exito", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        
        Else
            MessageBox.Show("Debe indicar las rutas y numeros de resultados.", "Formulario incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub frmImportarExcel_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.cbMonth.SelectedIndex = (Today.Month - 2)        
    End Sub

    Private Sub txtResultados_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtResultados.Enter        
        Pantalla.fadeInPanel(Me.PanHelp)
    End Sub

    Private Sub txtResultados_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtResultados.Leave        
        Pantalla.fadeOutPanel(Me.PanHelp)
    End Sub

    Private Sub txtResultados_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtResultados.MouseEnter
        If Not Me.PanHelp.Visible Then Pantalla.fadeInPanel(Me.PanHelp) 'Me.PanHelp.Visible = True        
    End Sub

    Private Sub txtResultados_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtResultados.MouseLeave
        If Not Me.txtResultados.Focused And Me.PanHelp.Visible Then Pantalla.fadeOutPanel(Me.PanHelp) 'Me.PanHelp.Visible = False
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim Respuesta As DialogResult
        Respuesta = messagebox.show(" ¿Eliminar las entradas del mes seleccionado?", _
                           "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Respuesta = DialogResult.Yes Then
            Dim importer As New ExcelImporter

            If importer.delete(Me.cbMonth.SelectedIndex + 1, Today.Year) Then
                MessageBox.Show("Eliminado con exito", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                messagebox.show("No se pudo eliminar el historial. Se revertira la operación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub frmImportarExcel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(btnEliminar, "Elimina los resultados para el mes selccionado del año " & Today.Year)
        ToolTip2.SetToolTip(Me.txtResultados, "Introduce el el valor de fila anterior al ultimo total del excel")
        ToolTip4.SetToolTip(btnManual, "Crear entrada para un articulo manualmente")
    End Sub

    Private Sub TextBox1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.MouseEnter
        If Not Me.PanHelp.Visible Then Pantalla.fadeInPanel(Me.PanHelp) 'Me.PanHelp.Visible = True        
    End Sub

    Private Sub TextBox2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.MouseEnter
        If Not Me.PanHelp.Visible Then Pantalla.fadeInPanel(Me.PanHelp) 'Me.PanHelp.Visible = True        
    End Sub

    Private Sub TextBox3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.MouseEnter
        If Not Me.PanHelp.Visible Then Pantalla.fadeInPanel(Me.PanHelp) 'Me.PanHelp.Visible = True        
    End Sub

    Private Sub TextBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Enter
        Pantalla.fadeInPanel(Me.PanHelp)
    End Sub

    Private Sub TextBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.Enter
        Pantalla.fadeInPanel(Me.PanHelp)
    End Sub

    Private Sub TextBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.Enter
        Pantalla.fadeInPanel(Me.PanHelp)
    End Sub

    Private Sub TextBox1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Leave
        Pantalla.fadeOutPanel(Me.PanHelp)
    End Sub

    Private Sub TextBox2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.Leave
        Pantalla.fadeOutPanel(Me.PanHelp)
    End Sub

    Private Sub TextBox3_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.Leave
        Pantalla.fadeOutPanel(Me.PanHelp)
    End Sub

    Private Sub TextBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.MouseLeave
        If Not Me.txtResultados.Focused And Me.PanHelp.Visible Then Pantalla.fadeOutPanel(Me.PanHelp) 'Me.PanHelp.Visible = False
    End Sub

    Private Sub TextBox2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.MouseLeave
        If Not Me.txtResultados.Focused And Me.PanHelp.Visible Then Pantalla.fadeOutPanel(Me.PanHelp) 'Me.PanHelp.Visible = False
    End Sub

    Private Sub TextBox3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.MouseLeave
        If Not Me.txtResultados.Focused And Me.PanHelp.Visible Then Pantalla.fadeOutPanel(Me.PanHelp) 'Me.PanHelp.Visible = False
    End Sub

    Private Sub btnChooseFile2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChooseFile2.Click
        If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.txtPath2.Text = OpenFileDialog1.FileName.ToString

            If Not Me.txtPath2.Text.Contains("JR") Then
                err1.Visible = True
                Me.ToolTip3.SetToolTip(err1, "Deberia ser un archivo de JR")
            End If
        End If
    End Sub

    Private Sub btnChooseFile3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChooseFile3.Click
        If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.txtPath3.Text = OpenFileDialog1.FileName.ToString

            If Not Me.txtPath3.Text.Contains("VLA") Then
                err1.Visible = True
                Me.ToolTip3.SetToolTip(err2, "Deberia ser un archivo de VLA")
            End If
        End If
    End Sub

    Private Sub btnChooseFile4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChooseFile4.Click
        If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.txtPath4.Text = OpenFileDialog1.FileName.ToString

            If Not Me.txtPath4.Text.Contains("VLA") Then
                err1.Visible = True
                Me.ToolTip3.SetToolTip(err3, "Deberia ser un archivo de VLA")
            End If
        End If
    End Sub

    Private Sub btnManual_Click(sender As System.Object, e As System.EventArgs) Handles btnManual.Click
        Dim frm As New frmEntVentasArticulo(Me.cbMonth.SelectedIndex + 1, Today.Year)
        GUImain.añadirPestaña(frm)
    End Sub

    Private Sub frmImportarExcel_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.DetailedSimpleForm.centerIn(Me.Panel1, Me)
    End Sub

    Private Sub txtPath3_TextChanged(sender As Object, e As EventArgs) Handles txtPath3.TextChanged

    End Sub

    Private Sub txtPath2_TextChanged(sender As Object, e As EventArgs) Handles txtPath2.TextChanged

    End Sub

    Private Sub txtPath_TextChanged(sender As Object, e As EventArgs) Handles txtPath.TextChanged

    End Sub
End Class