Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class frmMigracionCambioTipo
    Private m_dbo_mantener As DBO_Articulos1
    Private m_dbo_borrar As DBO_Articulos1
    Private dtb As BasesParaCompatibilidad.DataBase
    Public Sub New(ByVal id As Integer)
        InitializeComponent()

        dtb = New BasesParaCompatibilidad.DataBase
        Me.m_dbo_mantener = New DBO_Articulos1
        Me.m_dbo_mantener.ID = id
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        dtb.EmpezarTransaccion()

        Dim migrateCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[ArticulosMigrarTipo]")

        Try
            migrateCommand.CommandType = CommandType.StoredProcedure
            migrateCommand.Parameters.AddWithValue("@artMantener", m_dbo_mantener.ID)
            migrateCommand.Parameters.AddWithValue("@tipo", Me.cboArticulo.SelectedValue)

            migrateCommand.ExecuteNonQuery()



            dtb.TerminarTransaccion()
            messagebox.show("Migracion completada", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            dtb.CancelarTransaccion()
            messagebox.show("Se encontró un problema a realizar la migración. Se BasesParaCompatibilidad.BD.Cerrará la ventana, vuelva a intentarlo en unos segundos." & Environment.NewLine _
                   & " Detalles: " & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try

    End Sub

    Private Sub frmMigracionEntreArticulos_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.Pantalla.centerHorizontalyIn(Me.lIntruccion, Me.Panel3)
        BasesParaCompatibilidad.Pantalla.centerHorizontalyIn(Me.Panel4, Me.Panel2)
    End Sub

    Private Sub frmMigracionEntreArticulos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cboArticulo.mam_DataSource("Articulos1_ArticulosTiposCboRestringido", False, dtb)
    End Sub
End Class