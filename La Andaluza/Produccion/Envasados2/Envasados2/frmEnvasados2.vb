Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEnvasados2
    Inherits BasesParaCompatibilidad.FrmAheredarOld


    Private DateSelected As Date = Nothing
    Private EtiquetadoraPalets As Etiquetador
    Private frmEnt As frmEntEnvasados2
    Private Fechas As System.Collections.Generic.List(Of DateTime)

    Public Sub New()
        MyBase.New(New spEnvasados2, 0)
        InitializeComponent()
        spSelectDgv = "Envasados2SelectDgv"

        EtiquetadoraPalets = New Etiquetador
        dtpGregoriana.activarFoco()
        FormatoCalendario()
        Me.dgvGeneral.Visible = False

    End Sub

    Private Sub frmEnvasados2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        BindingNavigatorSinRegistros()
        butModificar.Visible = True
        butImprimir.Visible = True
        butImprimir.ToolTipText = "Ver informe diario (F9)"
        butWord.Visible = False
        butExcel.Visible = False

        If Config.UserType <> 4 And Config.UserType <> 9 Then
            Me.panExtras.Visible = False
        End If
    End Sub

    Overrides Sub Action(ByVal TipoAction As String)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim m_Envasado As DBO_Envasados2 = DBO_Envasados2.Instance
        frmEnt = New frmEntEnvasados2(TipoAction)
        m_Envasado.Fecha = MonthCalendar.SelectionRange.Start

        If TipoAction = ACCION_INSERTAR Then
            m_Envasado.EnvasadoID = 0
            frmEnt.Text = "envasado el dia " & DateSelected.ToString.Substring(0, 10)
        Else
            If Not DateSelected.Equals(MonthCalendar.SelectionStart) Then
                DateSelected = MonthCalendar.SelectionRange.Start
            End If
            m_Envasado.EnvasadoID = CType(sp, spEnvasados2).GetEnvasadoIDPorFecha(m_Envasado.Fecha)
            If m_Envasado.EnvasadoID <> 0 Then
                m_Envasado = CType(sp, spEnvasados2).Select_Record(m_Envasado.EnvasadoID)
                frmEnt.Text = "envasados del dia " & DateSelected.ToString.Substring(0, 10)
            Else
                MessageBox.Show("No existe un envasado a modificar para la fecha seleccionada.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
        End If

        'BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        frmEnt.ShowDialog()
        FormatoCalendario()
    End Sub

    Private Sub FormatoCalendario()
        Fechas = New System.Collections.Generic.List(Of DateTime)

        MonthCalendar.MaxDate = Today '.AddDays(2)
        MonthCalendar.BoldedDates = Nothing

        Dim i As Integer = 0
        Dim dtfechas As DataTable = dtb.Consultar(spSelectDgv)

        While i < dtfechas.Rows.Count 'And Convert.ToDateTime(dtfechas.Rows(i).Item("Fecha")) <= Now.Date
            Fechas.Add(Convert.ToDateTime(dtfechas.Rows(i).Item("Fecha")))
            i += 1
        End While

        Me.MonthCalendar.BoldedDates = Fechas.ToArray()
        Me.MonthCalendar.SelectionStart = Today
    End Sub

    Private Sub MonthCalendar_DateSelected(sender As Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar.DateSelected
        Dim m_Envasado As DBO_Envasados2 = DBO_Envasados2.Instance
        m_Envasado.Fecha = MonthCalendar.SelectionRange.Start
        If Not DateSelected.Equals(MonthCalendar.SelectionStart) Then
            DateSelected = MonthCalendar.SelectionRange.Start
        End If
        m_Envasado.EnvasadoID = CType(sp, spEnvasados2).GetEnvasadoIDPorFecha(m_Envasado.Fecha)
        If m_Envasado.EnvasadoID <> 0 Then
            Modificar()
        Else
            Insertar()
        End If
    End Sub

    Private Sub btnGregorianaToJuliana_Click(sender As System.Object, e As System.EventArgs) Handles btnGregorianaToJuliana.Click
        Dim calendar As New BasesParaCompatibilidad.Calendar
        txtJuliana.Text = calendar.DevuelveFechaJuliana(dtpGregoriana.Value)
    End Sub

    Private Sub btnJulianaToGregoriana_Click(sender As System.Object, e As System.EventArgs) Handles btnJulianaToGregoriana.Click
        Try
            Dim calendar As New BasesParaCompatibilidad.Calendar
            Dim m_fecha As String = Mid(txtJuliana.Text, 4, 2) & Mid(txtJuliana.Text, 1, 3)
            dtpGregoriana.Value = calendar.JulianToSerial(m_fecha)
        Catch ex As Exception
            MessageBox.Show("Error. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmEnvasados2_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.Pantalla.centerHorizontalyIn(Me.Panconversor, Me.PanDBelow)
        BasesParaCompatibilidad.pantalla.centerIn(Me.MonthCalendar, Me)
    End Sub

    Private Sub frmEnvasados2_shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        EtiquetadoraPalets.setup()
    End Sub

    Private Sub btnConfigurarImpresora_Click(sender As System.Object, e As System.EventArgs) Handles btnConfigurarImpresora.Click
        EtiquetadoraPalets.reconfigurar()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New frmTiposLoteados
        GUImain.añadirPestaña(frm)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New frmArticulosLoteados
        GUImain.añadirPestaña(frm)
    End Sub

    Private Sub btnBotellas_Click(sender As Object, e As EventArgs) Handles btnBotellas.Click
        Dim frmTiposBotellas As New frmTiposBotellas
        GUImain.añadirPestaña(frmTiposBotellas)
    End Sub

    Private Sub btnCajas_Click(sender As Object, e As EventArgs) Handles btnCajas.Click
        Dim frmTiposCajas As New frmTiposCajas
        GUImain.añadirPestaña(frmTiposCajas)
    End Sub

    Private Sub btnLinea_Click(sender As Object, e As EventArgs) Handles btnLinea.Click
        Dim frmLineasEnvasado As New frmLineasEnvasado
        GUImain.añadirPestaña(frmLineasEnvasado)
    End Sub
End Class
