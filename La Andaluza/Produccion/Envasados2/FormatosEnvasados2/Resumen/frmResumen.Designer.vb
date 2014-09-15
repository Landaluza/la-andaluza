<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResumen
    Inherits BasesParaCompatibilidad.FrmAheredarOld

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
    Private Overloads Sub InitializeComponent()
        Dim Label37 As System.Windows.Forms.Label
        Dim Label39 As System.Windows.Forms.Label
        Dim Label42 As System.Windows.Forms.Label
        Dim Label43 As System.Windows.Forms.Label
        Dim Label41 As System.Windows.Forms.Label
        Dim Label27 As System.Windows.Forms.Label
        Dim TotalLitrosLabel As System.Windows.Forms.Label
        Dim TotalBotellasLabel As System.Windows.Forms.Label
        Dim HoraFinLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim TotalCajasLabel As System.Windows.Forms.Label
        Dim PaletsLabel As System.Windows.Forms.Label
        Dim HoraInicioLabel As System.Windows.Forms.Label
        Me.lblTiemposNoJustificados = New System.Windows.Forms.Label()
        Me.lblTiemposTotalIncidencias = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblTiemposIncidenciasNoEvitables = New System.Windows.Forms.Label()
        Me.lblTiemposAsignado = New System.Windows.Forms.Label()
        Me.lblTiemposIncidenciasEvitables = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblMinutos = New System.Windows.Forms.Label()
        Me.lblIncOtrNumero = New System.Windows.Forms.Label()
        Me.lblIncOtrTiempo = New System.Windows.Forms.Label()
        Me.lblTotalCajasCompletadas = New System.Windows.Forms.Label()
        Me.lblTotalLitros = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblTotalBotellas = New System.Windows.Forms.Label()
        Me.lblTotalNroCajas = New System.Windows.Forms.Label()
        Me.lblTotalCajasSueltas = New System.Windows.Forms.Label()
        Me.dtpHoraFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.lblEfectividad = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblIncIntNumero = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblIncRecNumero = New System.Windows.Forms.Label()
        Me.grbEstadisticas = New System.Windows.Forms.GroupBox()
        Me.lblMediaBotellasHoras = New System.Windows.Forms.Label()
        Me.lblTiempoMedioProduccion = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.grbProduccion = New System.Windows.Forms.GroupBox()
        Me.lblTotalPalets = New System.Windows.Forms.Label()
        Me.lblIncIntTiempo = New System.Windows.Forms.Label()
        Me.lblIncRecTiempo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblIncCalNumero = New System.Windows.Forms.Label()
        Me.lblIncCalTiempo = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lblIncMecNumero = New System.Windows.Forms.Label()
        Me.lblIncMecTiempo = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Label37 = New System.Windows.Forms.Label()
        Label39 = New System.Windows.Forms.Label()
        Label42 = New System.Windows.Forms.Label()
        Label43 = New System.Windows.Forms.Label()
        Label41 = New System.Windows.Forms.Label()
        Label27 = New System.Windows.Forms.Label()
        TotalLitrosLabel = New System.Windows.Forms.Label()
        TotalBotellasLabel = New System.Windows.Forms.Label()
        HoraFinLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        TotalCajasLabel = New System.Windows.Forms.Label()
        PaletsLabel = New System.Windows.Forms.Label()
        HoraInicioLabel = New System.Windows.Forms.Label()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbEstadisticas.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grbProduccion.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label37
        '
        Label37.AutoSize = True
        Label37.Location = New System.Drawing.Point(8, 210)
        Label37.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label37.Name = "Label37"
        Label37.Size = New System.Drawing.Size(146, 17)
        Label37.TabIndex = 4
        Label37.Text = "Tiempo no justificado:"
        '
        'Label39
        '
        Label39.AutoSize = True
        Label39.Location = New System.Drawing.Point(8, 181)
        Label39.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label39.Name = "Label39"
        Label39.Size = New System.Drawing.Size(118, 17)
        Label39.TabIndex = 2
        Label39.Text = "Total incidencias:"
        '
        'Label42
        '
        Label42.AutoSize = True
        Label42.Location = New System.Drawing.Point(8, 151)
        Label42.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label42.Name = "Label42"
        Label42.Size = New System.Drawing.Size(162, 17)
        Label42.TabIndex = 0
        Label42.Text = "Incidencias no evitables:"
        '
        'Label43
        '
        Label43.AutoSize = True
        Label43.Location = New System.Drawing.Point(8, 92)
        Label43.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label43.Name = "Label43"
        Label43.Size = New System.Drawing.Size(71, 17)
        Label43.TabIndex = 12
        Label43.Text = "Asignado:"
        '
        'Label41
        '
        Label41.AutoSize = True
        Label41.Location = New System.Drawing.Point(8, 122)
        Label41.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label41.Name = "Label41"
        Label41.Size = New System.Drawing.Size(142, 17)
        Label41.TabIndex = 13
        Label41.Text = "Incidencias evitables:"
        '
        'Label27
        '
        Label27.AutoSize = True
        Label27.Location = New System.Drawing.Point(16, 187)
        Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label27.Name = "Label27"
        Label27.Size = New System.Drawing.Size(132, 17)
        Label27.TabIndex = 1000000064
        Label27.Text = "Cajas completando:"
        '
        'TotalLitrosLabel
        '
        TotalLitrosLabel.AutoSize = True
        TotalLitrosLabel.Location = New System.Drawing.Point(16, 156)
        TotalLitrosLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TotalLitrosLabel.Name = "TotalLitrosLabel"
        TotalLitrosLabel.Size = New System.Drawing.Size(47, 17)
        TotalLitrosLabel.TabIndex = 4
        TotalLitrosLabel.Text = "Litros:"
        '
        'TotalBotellasLabel
        '
        TotalBotellasLabel.AutoSize = True
        TotalBotellasLabel.Location = New System.Drawing.Point(16, 126)
        TotalBotellasLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TotalBotellasLabel.Name = "TotalBotellasLabel"
        TotalBotellasLabel.Size = New System.Drawing.Size(62, 17)
        TotalBotellasLabel.TabIndex = 2
        TotalBotellasLabel.Text = "Botellas:"
        '
        'HoraFinLabel
        '
        HoraFinLabel.AutoSize = True
        HoraFinLabel.Location = New System.Drawing.Point(8, 63)
        HoraFinLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        HoraFinLabel.Name = "HoraFinLabel"
        HoraFinLabel.Size = New System.Drawing.Size(66, 17)
        HoraFinLabel.TabIndex = 1000000034
        HoraFinLabel.Text = "Hora Fin:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(16, 64)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(98, 17)
        Label3.TabIndex = 13
        Label3.Text = "Cajas Sueltas:"
        '
        'TotalCajasLabel
        '
        TotalCajasLabel.AutoSize = True
        TotalCajasLabel.Location = New System.Drawing.Point(16, 95)
        TotalCajasLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TotalCajasLabel.Name = "TotalCajasLabel"
        TotalCajasLabel.Size = New System.Drawing.Size(47, 17)
        TotalCajasLabel.TabIndex = 0
        TotalCajasLabel.Text = "Cajas:"
        '
        'PaletsLabel
        '
        PaletsLabel.AutoSize = True
        PaletsLabel.Location = New System.Drawing.Point(16, 33)
        PaletsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PaletsLabel.Name = "PaletsLabel"
        PaletsLabel.Size = New System.Drawing.Size(87, 17)
        PaletsLabel.TabIndex = 12
        PaletsLabel.Text = "Total Palets:"
        '
        'HoraInicioLabel
        '
        HoraInicioLabel.AutoSize = True
        HoraInicioLabel.Location = New System.Drawing.Point(8, 33)
        HoraInicioLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        HoraInicioLabel.Name = "HoraInicioLabel"
        HoraInicioLabel.Size = New System.Drawing.Size(79, 17)
        HoraInicioLabel.TabIndex = 1000000032
        HoraInicioLabel.Text = "Hora Inicio:"
        '
        'lblTiemposNoJustificados
        '
        Me.lblTiemposNoJustificados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTiemposNoJustificados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiemposNoJustificados.Location = New System.Drawing.Point(181, 207)
        Me.lblTiemposNoJustificados.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTiemposNoJustificados.Name = "lblTiemposNoJustificados"
        Me.lblTiemposNoJustificados.Size = New System.Drawing.Size(55, 22)
        Me.lblTiemposNoJustificados.TabIndex = 1000000093
        Me.lblTiemposNoJustificados.Text = "------"
        Me.lblTiemposNoJustificados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTiemposTotalIncidencias
        '
        Me.lblTiemposTotalIncidencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTiemposTotalIncidencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiemposTotalIncidencias.Location = New System.Drawing.Point(181, 177)
        Me.lblTiemposTotalIncidencias.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTiemposTotalIncidencias.Name = "lblTiemposTotalIncidencias"
        Me.lblTiemposTotalIncidencias.Size = New System.Drawing.Size(55, 22)
        Me.lblTiemposTotalIncidencias.TabIndex = 1000000092
        Me.lblTiemposTotalIncidencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 30)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(126, 18)
        Me.Label13.TabIndex = 1000000070
        Me.Label13.Text = "Minutos por palet:"
        '
        'lblTiemposIncidenciasNoEvitables
        '
        Me.lblTiemposIncidenciasNoEvitables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTiemposIncidenciasNoEvitables.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiemposIncidenciasNoEvitables.Location = New System.Drawing.Point(181, 148)
        Me.lblTiemposIncidenciasNoEvitables.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTiemposIncidenciasNoEvitables.Name = "lblTiemposIncidenciasNoEvitables"
        Me.lblTiemposIncidenciasNoEvitables.Size = New System.Drawing.Size(55, 22)
        Me.lblTiemposIncidenciasNoEvitables.TabIndex = 1000000091
        Me.lblTiemposIncidenciasNoEvitables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTiemposAsignado
        '
        Me.lblTiemposAsignado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTiemposAsignado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiemposAsignado.Location = New System.Drawing.Point(181, 89)
        Me.lblTiemposAsignado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTiemposAsignado.Name = "lblTiemposAsignado"
        Me.lblTiemposAsignado.Size = New System.Drawing.Size(55, 22)
        Me.lblTiemposAsignado.TabIndex = 1000000090
        Me.lblTiemposAsignado.Text = "------"
        Me.lblTiemposAsignado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTiemposIncidenciasEvitables
        '
        Me.lblTiemposIncidenciasEvitables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTiemposIncidenciasEvitables.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiemposIncidenciasEvitables.Location = New System.Drawing.Point(181, 118)
        Me.lblTiemposIncidenciasEvitables.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTiemposIncidenciasEvitables.Name = "lblTiemposIncidenciasEvitables"
        Me.lblTiemposIncidenciasEvitables.Size = New System.Drawing.Size(55, 22)
        Me.lblTiemposIncidenciasEvitables.TabIndex = 1000000089
        Me.lblTiemposIncidenciasEvitables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(280, 47)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 15)
        Me.Label5.TabIndex = 1000000090
        Me.Label5.Text = "Minutos"
        '
        'lblMinutos
        '
        Me.lblMinutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMinutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinutos.Location = New System.Drawing.Point(283, 65)
        Me.lblMinutos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinutos.Name = "lblMinutos"
        Me.lblMinutos.Size = New System.Drawing.Size(55, 22)
        Me.lblMinutos.TabIndex = 1000000089
        Me.lblMinutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIncOtrNumero
        '
        Me.lblIncOtrNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIncOtrNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncOtrNumero.Location = New System.Drawing.Point(133, 139)
        Me.lblIncOtrNumero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIncOtrNumero.Name = "lblIncOtrNumero"
        Me.lblIncOtrNumero.Size = New System.Drawing.Size(55, 22)
        Me.lblIncOtrNumero.TabIndex = 1000000088
        Me.lblIncOtrNumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIncOtrTiempo
        '
        Me.lblIncOtrTiempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIncOtrTiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncOtrTiempo.Location = New System.Drawing.Point(207, 139)
        Me.lblIncOtrTiempo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIncOtrTiempo.Name = "lblIncOtrTiempo"
        Me.lblIncOtrTiempo.Size = New System.Drawing.Size(51, 22)
        Me.lblIncOtrTiempo.TabIndex = 1000000087
        Me.lblIncOtrTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalCajasCompletadas
        '
        Me.lblTotalCajasCompletadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCajasCompletadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCajasCompletadas.Location = New System.Drawing.Point(164, 183)
        Me.lblTotalCajasCompletadas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalCajasCompletadas.Name = "lblTotalCajasCompletadas"
        Me.lblTotalCajasCompletadas.Size = New System.Drawing.Size(55, 22)
        Me.lblTotalCajasCompletadas.TabIndex = 1000000095
        Me.lblTotalCajasCompletadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalLitros
        '
        Me.lblTotalLitros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalLitros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalLitros.Location = New System.Drawing.Point(164, 153)
        Me.lblTotalLitros.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalLitros.Name = "lblTotalLitros"
        Me.lblTotalLitros.Size = New System.Drawing.Size(55, 22)
        Me.lblTotalLitros.TabIndex = 1000000094
        Me.lblTotalLitros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(21, 143)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(47, 17)
        Me.Label21.TabIndex = 1000000086
        Me.Label21.Text = "Otras:"
        '
        'lblTotalBotellas
        '
        Me.lblTotalBotellas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalBotellas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBotellas.Location = New System.Drawing.Point(164, 119)
        Me.lblTotalBotellas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalBotellas.Name = "lblTotalBotellas"
        Me.lblTotalBotellas.Size = New System.Drawing.Size(55, 22)
        Me.lblTotalBotellas.TabIndex = 1000000093
        Me.lblTotalBotellas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalNroCajas
        '
        Me.lblTotalNroCajas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalNroCajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalNroCajas.Location = New System.Drawing.Point(164, 91)
        Me.lblTotalNroCajas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalNroCajas.Name = "lblTotalNroCajas"
        Me.lblTotalNroCajas.Size = New System.Drawing.Size(55, 22)
        Me.lblTotalNroCajas.TabIndex = 1000000092
        Me.lblTotalNroCajas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalCajasSueltas
        '
        Me.lblTotalCajasSueltas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCajasSueltas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCajasSueltas.Location = New System.Drawing.Point(164, 60)
        Me.lblTotalCajasSueltas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalCajasSueltas.Name = "lblTotalCajasSueltas"
        Me.lblTotalCajasSueltas.Size = New System.Drawing.Size(55, 22)
        Me.lblTotalCajasSueltas.TabIndex = 1000000089
        Me.lblTotalCajasSueltas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpHoraFin
        '
        Me.dtpHoraFin.CustomFormat = "HH:mm"
        Me.dtpHoraFin.Enabled = False
        Me.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraFin.Location = New System.Drawing.Point(165, 58)
        Me.dtpHoraFin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpHoraFin.Name = "dtpHoraFin"
        Me.dtpHoraFin.ShowUpDown = True
        Me.dtpHoraFin.Size = New System.Drawing.Size(71, 22)
        Me.dtpHoraFin.TabIndex = 1000000095
        '
        'dtpHoraInicio
        '
        Me.dtpHoraInicio.CustomFormat = "HH:mm"
        Me.dtpHoraInicio.Enabled = False
        Me.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraInicio.Location = New System.Drawing.Point(165, 31)
        Me.dtpHoraInicio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpHoraInicio.Name = "dtpHoraInicio"
        Me.dtpHoraInicio.ShowUpDown = True
        Me.dtpHoraInicio.Size = New System.Drawing.Size(71, 22)
        Me.dtpHoraInicio.TabIndex = 1000000094
        '
        'lblEfectividad
        '
        Me.lblEfectividad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEfectividad.Location = New System.Drawing.Point(224, 76)
        Me.lblEfectividad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEfectividad.Name = "lblEfectividad"
        Me.lblEfectividad.Size = New System.Drawing.Size(55, 20)
        Me.lblEfectividad.TabIndex = 1000000075
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 54)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(168, 18)
        Me.Label12.TabIndex = 1000000071
        Me.Label12.Text = "Velocidad (Botellas/hrs):"
        '
        'lblIncIntNumero
        '
        Me.lblIncIntNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIncIntNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncIntNumero.Location = New System.Drawing.Point(133, 113)
        Me.lblIncIntNumero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIncIntNumero.Name = "lblIncIntNumero"
        Me.lblIncIntNumero.Size = New System.Drawing.Size(55, 22)
        Me.lblIncIntNumero.TabIndex = 1000000082
        Me.lblIncIntNumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 78)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 18)
        Me.Label1.TabIndex = 1000000072
        Me.Label1.Text = "Efectividad (%):"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(21, 117)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(75, 17)
        Me.Label23.TabIndex = 1000000080
        Me.Label23.Text = "Intrinsicas:"
        '
        'lblIncRecNumero
        '
        Me.lblIncRecNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIncRecNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncRecNumero.Location = New System.Drawing.Point(133, 87)
        Me.lblIncRecNumero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIncRecNumero.Name = "lblIncRecNumero"
        Me.lblIncRecNumero.Size = New System.Drawing.Size(55, 22)
        Me.lblIncRecNumero.TabIndex = 1000000079
        Me.lblIncRecNumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grbEstadisticas
        '
        Me.grbEstadisticas.Controls.Add(Me.lblEfectividad)
        Me.grbEstadisticas.Controls.Add(Me.lblMediaBotellasHoras)
        Me.grbEstadisticas.Controls.Add(Me.lblTiempoMedioProduccion)
        Me.grbEstadisticas.Controls.Add(Me.Label1)
        Me.grbEstadisticas.Controls.Add(Me.Label12)
        Me.grbEstadisticas.Controls.Add(Me.Label13)
        Me.grbEstadisticas.Location = New System.Drawing.Point(16, 62)
        Me.grbEstadisticas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grbEstadisticas.Name = "grbEstadisticas"
        Me.grbEstadisticas.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grbEstadisticas.Size = New System.Drawing.Size(323, 118)
        Me.grbEstadisticas.TabIndex = 1000000075
        Me.grbEstadisticas.TabStop = False
        Me.grbEstadisticas.Text = "Medias Artículo Envasado"
        '
        'lblMediaBotellasHoras
        '
        Me.lblMediaBotellasHoras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMediaBotellasHoras.Location = New System.Drawing.Point(224, 50)
        Me.lblMediaBotellasHoras.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMediaBotellasHoras.Name = "lblMediaBotellasHoras"
        Me.lblMediaBotellasHoras.Size = New System.Drawing.Size(55, 20)
        Me.lblMediaBotellasHoras.TabIndex = 1000000074
        '
        'lblTiempoMedioProduccion
        '
        Me.lblTiempoMedioProduccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTiempoMedioProduccion.Location = New System.Drawing.Point(224, 23)
        Me.lblTiempoMedioProduccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTiempoMedioProduccion.Name = "lblTiempoMedioProduccion"
        Me.lblTiempoMedioProduccion.Size = New System.Drawing.Size(55, 20)
        Me.lblTiempoMedioProduccion.TabIndex = 1000000073
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpHoraFin)
        Me.GroupBox2.Controls.Add(Me.dtpHoraInicio)
        Me.GroupBox2.Controls.Add(Me.lblTiemposNoJustificados)
        Me.GroupBox2.Controls.Add(Me.lblTiemposTotalIncidencias)
        Me.GroupBox2.Controls.Add(Me.lblTiemposIncidenciasNoEvitables)
        Me.GroupBox2.Controls.Add(Me.lblTiemposAsignado)
        Me.GroupBox2.Controls.Add(Me.lblTiemposIncidenciasEvitables)
        Me.GroupBox2.Controls.Add(HoraInicioLabel)
        Me.GroupBox2.Controls.Add(HoraFinLabel)
        Me.GroupBox2.Controls.Add(Label37)
        Me.GroupBox2.Controls.Add(Label39)
        Me.GroupBox2.Controls.Add(Label41)
        Me.GroupBox2.Controls.Add(Label42)
        Me.GroupBox2.Controls.Add(Label43)
        Me.GroupBox2.Location = New System.Drawing.Point(717, 62)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(257, 241)
        Me.GroupBox2.TabIndex = 1000000078
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Totales tiempos en minutos."
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(284, 27)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(49, 15)
        Me.Label26.TabIndex = 1000000085
        Me.Label26.Text = "TOTAL"
        '
        'grbProduccion
        '
        Me.grbProduccion.Controls.Add(Me.lblTotalCajasCompletadas)
        Me.grbProduccion.Controls.Add(Me.lblTotalLitros)
        Me.grbProduccion.Controls.Add(Me.lblTotalBotellas)
        Me.grbProduccion.Controls.Add(Me.lblTotalNroCajas)
        Me.grbProduccion.Controls.Add(Me.lblTotalPalets)
        Me.grbProduccion.Controls.Add(Me.lblTotalCajasSueltas)
        Me.grbProduccion.Controls.Add(Label27)
        Me.grbProduccion.Controls.Add(TotalLitrosLabel)
        Me.grbProduccion.Controls.Add(TotalBotellasLabel)
        Me.grbProduccion.Controls.Add(Label3)
        Me.grbProduccion.Controls.Add(TotalCajasLabel)
        Me.grbProduccion.Controls.Add(PaletsLabel)
        Me.grbProduccion.Location = New System.Drawing.Point(983, 62)
        Me.grbProduccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grbProduccion.Name = "grbProduccion"
        Me.grbProduccion.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grbProduccion.Size = New System.Drawing.Size(236, 241)
        Me.grbProduccion.TabIndex = 1000000076
        Me.grbProduccion.TabStop = False
        Me.grbProduccion.Text = "Totales envasado."
        '
        'lblTotalPalets
        '
        Me.lblTotalPalets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalPalets.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPalets.Location = New System.Drawing.Point(164, 31)
        Me.lblTotalPalets.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalPalets.Name = "lblTotalPalets"
        Me.lblTotalPalets.Size = New System.Drawing.Size(55, 22)
        Me.lblTotalPalets.TabIndex = 1000000090
        Me.lblTotalPalets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIncIntTiempo
        '
        Me.lblIncIntTiempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIncIntTiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncIntTiempo.Location = New System.Drawing.Point(207, 113)
        Me.lblIncIntTiempo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIncIntTiempo.Name = "lblIncIntTiempo"
        Me.lblIncIntTiempo.Size = New System.Drawing.Size(51, 22)
        Me.lblIncIntTiempo.TabIndex = 1000000081
        Me.lblIncIntTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIncRecTiempo
        '
        Me.lblIncRecTiempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIncRecTiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncRecTiempo.Location = New System.Drawing.Point(207, 87)
        Me.lblIncRecTiempo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIncRecTiempo.Name = "lblIncRecTiempo"
        Me.lblIncRecTiempo.Size = New System.Drawing.Size(51, 22)
        Me.lblIncRecTiempo.TabIndex = 1000000078
        Me.lblIncRecTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblMinutos)
        Me.GroupBox1.Controls.Add(Me.lblIncOtrNumero)
        Me.GroupBox1.Controls.Add(Me.lblIncOtrTiempo)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.lblIncIntNumero)
        Me.GroupBox1.Controls.Add(Me.lblIncIntTiempo)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.lblIncRecNumero)
        Me.GroupBox1.Controls.Add(Me.lblIncRecTiempo)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.lblIncCalNumero)
        Me.GroupBox1.Controls.Add(Me.lblIncCalTiempo)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.lblIncMecNumero)
        Me.GroupBox1.Controls.Add(Me.lblIncMecTiempo)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Location = New System.Drawing.Point(347, 62)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(363, 167)
        Me.GroupBox1.TabIndex = 1000000077
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Totales incidencias"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(21, 91)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(100, 17)
        Me.Label20.TabIndex = 1000000077
        Me.Label20.Text = "Recuperables:"
        '
        'lblIncCalNumero
        '
        Me.lblIncCalNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIncCalNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncCalNumero.Location = New System.Drawing.Point(133, 36)
        Me.lblIncCalNumero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIncCalNumero.Name = "lblIncCalNumero"
        Me.lblIncCalNumero.Size = New System.Drawing.Size(55, 22)
        Me.lblIncCalNumero.TabIndex = 1000000076
        Me.lblIncCalNumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIncCalTiempo
        '
        Me.lblIncCalTiempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIncCalTiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncCalTiempo.Location = New System.Drawing.Point(207, 36)
        Me.lblIncCalTiempo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIncCalTiempo.Name = "lblIncCalTiempo"
        Me.lblIncCalTiempo.Size = New System.Drawing.Size(51, 22)
        Me.lblIncCalTiempo.TabIndex = 1000000075
        Me.lblIncCalTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(21, 65)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 17)
        Me.Label17.TabIndex = 1000000074
        Me.Label17.Text = "Mecanicas:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(201, 20)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(58, 15)
        Me.Label29.TabIndex = 1000000070
        Me.Label29.Text = "Minutos"
        '
        'lblIncMecNumero
        '
        Me.lblIncMecNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIncMecNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncMecNumero.Location = New System.Drawing.Point(133, 62)
        Me.lblIncMecNumero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIncMecNumero.Name = "lblIncMecNumero"
        Me.lblIncMecNumero.Size = New System.Drawing.Size(55, 22)
        Me.lblIncMecNumero.TabIndex = 1000000069
        Me.lblIncMecNumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIncMecTiempo
        '
        Me.lblIncMecTiempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIncMecTiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncMecTiempo.Location = New System.Drawing.Point(207, 62)
        Me.lblIncMecTiempo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIncMecTiempo.Name = "lblIncMecTiempo"
        Me.lblIncMecTiempo.Size = New System.Drawing.Size(51, 22)
        Me.lblIncMecTiempo.TabIndex = 1000000067
        Me.lblIncMecTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(21, 39)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(59, 17)
        Me.Label32.TabIndex = 9
        Me.Label32.Text = "Calidad:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(131, 20)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(58, 15)
        Me.Label33.TabIndex = 1000000068
        Me.Label33.Text = "Numero"
        '
        'frmResumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1233, 560)
        Me.Controls.Add(Me.grbEstadisticas)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grbProduccion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmResumen"
        Me.Text = "Form1"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.grbProduccion, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.grbEstadisticas, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbEstadisticas.ResumeLayout(False)
        Me.grbEstadisticas.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grbProduccion.ResumeLayout(False)
        Me.grbProduccion.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Private WithEvents grbEstadisticas As System.Windows.Forms.GroupBox
    Private WithEvents lblTiemposNoJustificados As System.Windows.Forms.Label
    Private WithEvents lblTiemposTotalIncidencias As System.Windows.Forms.Label
    Private WithEvents Label13 As System.Windows.Forms.Label
    Private WithEvents lblTiemposIncidenciasNoEvitables As System.Windows.Forms.Label
    Private WithEvents lblTiemposAsignado As System.Windows.Forms.Label
    Private WithEvents lblTiemposIncidenciasEvitables As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents lblMinutos As System.Windows.Forms.Label
    Private WithEvents lblIncOtrNumero As System.Windows.Forms.Label
    Private WithEvents lblIncOtrTiempo As System.Windows.Forms.Label
    Private WithEvents lblTotalCajasCompletadas As System.Windows.Forms.Label
    Private WithEvents lblTotalLitros As System.Windows.Forms.Label
    Private WithEvents Label21 As System.Windows.Forms.Label
    Private WithEvents lblTotalBotellas As System.Windows.Forms.Label
    Private WithEvents lblTotalNroCajas As System.Windows.Forms.Label
    Private WithEvents lblTotalCajasSueltas As System.Windows.Forms.Label
    Private WithEvents dtpHoraFin As System.Windows.Forms.DateTimePicker
    Private WithEvents dtpHoraInicio As System.Windows.Forms.DateTimePicker
    Private WithEvents lblEfectividad As System.Windows.Forms.Label
    Private WithEvents Label12 As System.Windows.Forms.Label
    Private WithEvents lblIncIntNumero As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label23 As System.Windows.Forms.Label
    Private WithEvents lblIncRecNumero As System.Windows.Forms.Label
    Private WithEvents lblMediaBotellasHoras As System.Windows.Forms.Label
    Private WithEvents lblTiempoMedioProduccion As System.Windows.Forms.Label
    Private WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents Label26 As System.Windows.Forms.Label
    Private WithEvents grbProduccion As System.Windows.Forms.GroupBox
    Private WithEvents lblTotalPalets As System.Windows.Forms.Label
    Private WithEvents lblIncIntTiempo As System.Windows.Forms.Label
    Private WithEvents lblIncRecTiempo As System.Windows.Forms.Label
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents Label20 As System.Windows.Forms.Label
    Private WithEvents lblIncCalNumero As System.Windows.Forms.Label
    Private WithEvents lblIncCalTiempo As System.Windows.Forms.Label
    Private WithEvents Label17 As System.Windows.Forms.Label
    Private WithEvents Label29 As System.Windows.Forms.Label
    Private WithEvents lblIncMecNumero As System.Windows.Forms.Label
    Private WithEvents lblIncMecTiempo As System.Windows.Forms.Label
    Private WithEvents Label32 As System.Windows.Forms.Label
    Private WithEvents Label33 As System.Windows.Forms.Label
End Class
