Public Class frmPartesEnvasadoCausasIns
    Private m_DBO_PartesEnvasados_CausasPartesEnvasado As DBO_PartesEnvasados_CausasPartesEnvasado
    Private dtb As BasesParaCompatibilidad.DataBase
    Public WriteOnly Property MaestroID As Integer
        Set(value As Integer)
            Me.m_DBO_PartesEnvasados_CausasPartesEnvasado.Id_ParteEnvasado = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
        dtb = New BasesParaCompatibilidad.DataBase
        Me.m_DBO_PartesEnvasados_CausasPartesEnvasado = New DBO_PartesEnvasados_CausasPartesEnvasado
    End Sub

    Private Sub tsNuevo_Click(sender As System.Object, e As System.EventArgs) Handles tsNuevo.Click
        Dim frm As New frmEntPartesEnvasadosCausasIns()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)

        Dim dbo As DBO_PartesEnvasados_CausasPartesEnvasado = frm.DBO

        If Not dbo Is Nothing Then
            For Each drow As DataGridViewRow In dgv.Rows
                If drow.Cells("Id_causa").Value = dbo.Id_CausaParteEnvasado Then
                    Return
                End If
            Next

            Dim sp As New spCausasPartesEnvasado
            Dim dbocausa As DBO_CausasPartesEnvasado = sp.Select_Record(dbo.Id_CausaParteEnvasado, dtb)

            Dim dgvRow As New DataGridViewRow
            Dim dgvCell As DataGridViewCell

            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = dbocausa.Descripcion
            dgvRow.Cells.Add(dgvCell)

            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = dbo.Id_CausaParteEnvasado
            dgvRow.Cells.Add(dgvCell)

            dgv.Rows.Add(dgvRow)

        End If
    End Sub

    Private Sub tsEliminar_Click(sender As System.Object, e As System.EventArgs) Handles tsEliminar.Click
        Try
            Me.dgv.Rows.Remove(Me.dgv.CurrentRow)
        Catch ex As Exception
        End Try
    End Sub

    Public Function Grabar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim sp As New spPartesEnvasados_CausasPartesEnvasado
        Dim retorno As Boolean = True

        For Each row As DataGridViewRow In dgv.Rows
            Me.m_DBO_PartesEnvasados_CausasPartesEnvasado.Id_CausaParteEnvasado = row.Cells("Id_causa").Value()
            retorno = retorno And sp.Grabar(Me.m_DBO_PartesEnvasados_CausasPartesEnvasado, dtb)
        Next

        Return retorno
    End Function

    Public ReadOnly Property Count As Boolean
        Get
            Return Me.dgv.Rows.Count
        End Get
    End Property
End Class