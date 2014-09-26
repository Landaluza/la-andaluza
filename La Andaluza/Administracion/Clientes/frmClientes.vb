Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmClientes
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Public Sub New(Optional ByVal Maestroid As Integer = 0)
        MyBase.New(New spClientes, Maestroid)
        InitializeComponent()
        spSelectDgv = "ClientesSelectDgv"
    End Sub
    Protected Overrides Sub cargar_datos()
        dataSource = dtb.Consultar(spSelectDgv, True)
    End Sub

    Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            With dgvGeneral
                '.Width = 377
                .DataSource = GeneralBindingSource
                .Columns("ClienteID").Visible = False
                .FormatoColumna("CodigoQS", BasesParaCompatibilidad.TiposColumna.QS, 77, 1)
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 2)
                .FormatoGeneral()
            End With
        End If
    End Sub
    Overrides Sub Insertar()
        Action(ACCION_INSERTAR)
        dgvFill()
    End Sub

    Overrides Sub Modificar()
        Action(ACCION_MODIFICAR)
        GeneralBindingSource.DataSource = dtb.Consultar(spSelectDgv)
    End Sub

    Overrides Sub Ver()
        Action(ACCION_VER)
    End Sub

    Overrides Sub Eliminar()
        Dim response As DialogResult
        response = MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", _
                          "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = DialogResult.Yes Then
            CType(sp, spClientes).DeleteClientes(dgvGeneral.CurrentRow.Cells("ClienteID").Value, dtb)
            'GeneralBindingSource. dataSource = dtb.consultar(spSelectDgv)
            GeneralBindingSource.DataSource = dtb.Consultar(spSelectDgv, True)
        End If
    End Sub

    Public Overrides Sub Action(ByVal TipoAction As String)
        Dim m_Pos As Integer = GeneralBindingSource.Position
        Dim m_ClienteID As Int32
        If TipoAction <> ACCION_INSERTAR Then
            m_ClienteID = dgvGeneral.CurrentRow.Cells("ClienteID").Value
        End If
        Dim frmEnt As New frmEntClientes(m_ClienteID, m_Pos)
        If TipoAction = ACCION_MODIFICAR Then
            frmEnt.Text = String.Format("Modificar {0}", Me.Text)
        ElseIf TipoAction = ACCION_VER Then
            frmEnt.Text = String.Format("Ver {0}", Me.Text)
        Else
            frmEnt.Text = String.Format("Insertar {0}", Me.Text)
        End If
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub


End Class
