Public Class frmSituacionPersonal
    Private sp As spEmpleados
    Private cont1 As Integer
    Private cont2 As Integer
    Private cont3 As Integer
    Private cont4 As Integer
    Private cont5 As Integer
    Private cont6 As Integer

    Public Sub New()

        InitializeComponent()
        Me.sp = New spEmpleados
        cont1 = 1
        cont2 = 1
        cont3 = 1
        cont4 = 1
        cont5 = 1
        cont6 = 1
    End Sub


    Private Sub frmSituacionPersonal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim dt As DataTable = sp.devolver_Empleados_Envasados_Situacion_Actual
        Dim lab As Label
        Dim labArt As Label
        Dim pan As Panel
        Dim IDpos As TableLayoutPanelCellPosition

        For Each dr As DataRow In dt.Rows
            lab = New Label
            labArt = New Label
            pan = New Panel

            lab.AutoSize = False
            labArt.AutoSize = False

            lab.Dock = DockStyle.Fill
            labArt.Dock = DockStyle.Bottom
            pan.Dock = DockStyle.Fill

            lab.Text = dr.Item("NombreCompleto")
            labArt.Text = dr.Item("descripcionLa")
            labArt.Height = 60

            Select Case dr.Item("LineaEnvasadoID")
                Case 1
                    IDpos = New TableLayoutPanelCellPosition(Me.cont1, 1) ' col row
                    Me.cont1 = Me.cont1 + 1
                Case 2
                    IDpos = New TableLayoutPanelCellPosition(Me.cont2, 2)
                    Me.cont2 = Me.cont2 + 1
                Case 3
                    IDpos = New TableLayoutPanelCellPosition(Me.cont3, 3)
                    Me.cont3 = Me.cont3 + 1
                Case 4
                    IDpos = New TableLayoutPanelCellPosition(Me.cont4, 4)
                    Me.cont4 = Me.cont4 + 1
                Case 5
                    IDpos = New TableLayoutPanelCellPosition(Me.cont5, 5)
                    Me.cont5 = Me.cont5 + 1
                Case 6
                    IDpos = New TableLayoutPanelCellPosition(Me.cont6, 6)
                    Me.cont6 = Me.cont6 + 1

            End Select

            pan.Controls.Add(labArt)
            pan.Controls.Add(lab)

            Tabla.SetCellPosition(pan, IDpos)
            Tabla.Controls.Add(pan)

        Next

    End Sub


End Class
