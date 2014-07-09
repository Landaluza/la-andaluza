<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlmacenEntradasInforme
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.MonthCalendar = New System.Windows.Forms.MonthCalendar()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.bdnGeneral = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.butSalir = New System.Windows.Forms.ToolStripButton()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdnGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bdnGeneral.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.MonthCalendar)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgv)
        Me.SplitContainer1.Size = New System.Drawing.Size(1373, 766)
        Me.SplitContainer1.SplitterDistance = 303
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 0
        '
        'MonthCalendar
        '
        Me.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 4)
        Me.MonthCalendar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MonthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday
        Me.MonthCalendar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.MonthCalendar.Location = New System.Drawing.Point(0, 0)
        Me.MonthCalendar.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.MonthCalendar.MaxDate = New Date(2012, 12, 31, 0, 0, 0, 0)
        Me.MonthCalendar.Name = "MonthCalendar"
        Me.MonthCalendar.SelectionRange = New System.Windows.Forms.SelectionRange(New Date(2012, 9, 1, 0, 0, 0, 0), New Date(2012, 9, 1, 0, 0, 0, 0))
        Me.MonthCalendar.TabIndex = 2
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 0)
        Me.dgv.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(1065, 766)
        Me.dgv.TabIndex = 0
        '
        'bdnGeneral
        '
        Me.bdnGeneral.AddNewItem = Nothing
        Me.bdnGeneral.CountItem = Nothing
        Me.bdnGeneral.DeleteItem = Nothing
        Me.bdnGeneral.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.bdnGeneral.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.butSalir})
        Me.bdnGeneral.Location = New System.Drawing.Point(0, 0)
        Me.bdnGeneral.MoveFirstItem = Nothing
        Me.bdnGeneral.MoveLastItem = Nothing
        Me.bdnGeneral.MoveNextItem = Nothing
        Me.bdnGeneral.MovePreviousItem = Nothing
        Me.bdnGeneral.Name = "bdnGeneral"
        Me.bdnGeneral.PositionItem = Nothing
        Me.bdnGeneral.Size = New System.Drawing.Size(1373, 25)
        Me.bdnGeneral.TabIndex = 8
        Me.bdnGeneral.Text = "BindingNavigatorGeneral"
        '
        'butSalir
        '
        Me.butSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.butSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butSalir.Image = Global.La_Andaluza.My.Resources.Resources.application_xit_3
        Me.butSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butSalir.Name = "butSalir"
        Me.butSalir.Size = New System.Drawing.Size(23, 22)
        Me.butSalir.Text = "Salir"
        '
        'frmAlmacenEntradasInforme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1373, 791)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.bdnGeneral)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(1064, 612)
        Me.Name = "frmAlmacenEntradasInforme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmAlmacenEntradasInforme"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdnGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bdnGeneral.ResumeLayout(False)
        Me.bdnGeneral.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents MonthCalendar As System.Windows.Forms.MonthCalendar
    Private WithEvents dgv As System.Windows.Forms.DataGridView
    Private WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents bdnGeneral As System.Windows.Forms.BindingNavigator
    Private WithEvents butSalir As System.Windows.Forms.ToolStripButton
End Class
