Public Class frmEntClientes
    inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Tabla As DataTable
    Private m_Pos As Integer
    Private m_ClienteID As Int32
    Private spClientes As spClientes
    Private m_RegistroActual As DBO_Clientes
    Private dtb as BasesParaCompatibilidad.Database
    Public Sub New(ByVal ClienteID As Int32, ByVal Pos As Integer)
        InitializeComponent()
        m_ClienteID = ClienteID
        m_Pos = Pos
        spClientes = New spClientes
        dtb = new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
    End Sub

    Private Sub frmEntClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.Text.Substring(0, 3) = "Ver" Then
            m_Tabla = dtb.consultar("ClientesSelectAll")
            GeneralBindingSource.DataSource = m_Tabla
            GeneralBindingSource.Position = m_Pos
        End If
        If Me.Text.Substring(0, 3) = "Ver" Or Me.Text.Substring(0, 3) = "Mod" Then
            m_RegistroActual = spClientes.Select_Record(m_ClienteID)
            SetValores()
        End If
        ModificarBindingNavigator()
    End Sub

    Overrides Sub MoveRecord(ByVal Move As String)
        Select Case Move
            Case Is = "First"
                m_Pos = 0
            Case Is = "Previous"
                m_Pos = m_Pos - 1
            Case Is = "Next"
                m_Pos = m_Pos + 1
            Case Is = "Last"
                m_Pos = m_Tabla.Rows.Count - 1
        End Select
        GeneralBindingSource.Position = m_Pos
        m_ClienteID = m_Tabla.Rows(m_Pos).Item("ClienteID")
        m_RegistroActual = spClientes.Select_Record(m_ClienteID)
        SetValores()
    End Sub

    Overrides Sub Guardar()
        Dim m_NewRegistroActual As New DBO_Clientes
        GetValores(m_NewRegistroActual)
        If Me.Text.Substring(0, 3) = "Ins" Then
            spClientes.InsertClientes(m_NewRegistroActual)
        Else
            GetValores(m_NewRegistroActual)
            Try
                If Not spClientes.UpdateClientes(m_RegistroActual, m_NewRegistroActual) Then
                    MessageBox.Show("Error", "No se ha actualizado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.DialogResult = Windows.Forms.DialogResult.Retry
                Else
                    m_RegistroActual = m_NewRegistroActual
                End If
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Catch ex As Exception
                MessageBox.Show(ex.Message, Convert.ToString (ex.GetType))
            End Try
            Update()
        End If
        Me.Close()
    End Sub

    Public Overrides Sub SetValores()
        txtClienteID.Text = m_RegistroActual.ClienteID
        txtNombre.Text = m_RegistroActual.Nombre
        txtCodigoQS.Text = m_RegistroActual.CodigoQS
    End Sub

    Private Sub GetValores(ByVal m_RegistroActual As DBO_Clientes) 
        m_RegistroActual.Nombre = txtNombre.Text
        m_RegistroActual.CodigoQS = If(txtCodigoQS.Text = "", 0, System.Convert.ToInt32(txtCodigoQS.Text))
    End Sub

End Class
