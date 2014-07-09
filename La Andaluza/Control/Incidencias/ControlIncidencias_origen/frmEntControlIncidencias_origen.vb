Public Class frmEntControlIncidencias_origen
    Private frmEntControlIncidencias_Clientes As frmEntControlIncidencias_Clientes
    Private frmEntControlIncidencias_Empleados As frmEntControlIncidencias_Empleados
    Private frmEntControlIncidencias_Proveedores As frmEntControlIncidencias_Proveedores
    Private m_maestroID As Integer

    Public Sub New(ByVal controlIncidenciaID As Integer)
        InitializeComponent()
        Me.m_maestroID = controlIncidenciaID
    End Sub

  

    Private Sub rb_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbCliente.CheckedChanged, rbEmpleado.CheckedChanged, rbProveedor.CheckedChanged
        If rbCliente.Checked Then
            Dim dbo As New DBO_ControlIncidencias_Clientes
            dbo.Id_control_incidencias = m_maestroID
            frmEntControlIncidencias_Clientes = New frmEntControlIncidencias_Clientes(frmEntControlIncidencias_Clientes.INSERCION, New spControlIncidencias_Clientes, dbo)
            AddHandler frmEntControlIncidencias_Clientes.FormClosed, AddressOf closeForm
            Engine_LA.FormEnPestaña(frmEntControlIncidencias_Clientes, Me.panForm)
        Else
            If rbProveedor.Checked Then
                Dim dbo As New DBO_ControlIncidencias_Proveedores
                dbo.Id_control_incidencias = m_maestroID
                frmEntControlIncidencias_Proveedores = New frmEntControlIncidencias_Proveedores(frmEntControlIncidencias_Proveedores.INSERCION, New spControlIncidencias_Proveedores, dbo)
                AddHandler frmEntControlIncidencias_Proveedores.FormClosed, AddressOf closeForm
                Engine_LA.FormEnPestaña(frmEntControlIncidencias_Proveedores, Me.panForm)
            Else
                If rbEmpleado.Checked Then
                    Dim dbo As New DBO_ControlIncidencias_Empleados
                    dbo.Id_control_incidencias = m_maestroID
                    frmEntControlIncidencias_Empleados = New frmEntControlIncidencias_Empleados(frmEntControlIncidencias_Empleados.INSERCION, New spControlIncidencias_Empleados, dbo)
                    AddHandler frmEntControlIncidencias_Empleados.FormClosed, AddressOf closeForm
                    Engine_LA.FormEnPestaña(frmEntControlIncidencias_Empleados, Me.panForm)
                End If
            End If
        End If
    End Sub

    Private Sub closeForm()
        Me.close()
    End Sub

    Private Sub frmEntControlIncidencias_origen_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.DetailedSimpleForm.centerVerticalyIn(Me.gbOrigen, Me)
    End Sub
End Class