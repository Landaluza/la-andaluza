﻿Imports BasesParaCompatibilidad.ComboBoxExtension
Public Class frmWstepEtiquetas
    Implements wizardable
    Private dtb As BasesParaCompatibilidad.DataBase

    Public Sub New()

        InitializeComponent()

        dtb = New BasesParaCompatibilidad.DataBase
    End Sub


    Public Function comprobarCampos() As Boolean Implements wizardable.comprobarCampos
        'Dim errores As String = ""

        'If Me.cboMateriaPrimaTipoID.SelectedValue is Nothing Then
        '    cboMateriaPrimaTipoID.Focus()
        '    errores = "Debe seleccionar un valor par el tipo de materia prima." & Environment.NewLine
        'Else
        '    m_DBO_MateriaPrima.MateriaPrimaTipoID = System.Convert.ToInt32(cboMateriaPrimaTipoID.SelectedValue)
        'End If
        'm_DBO_MateriaPrima.FechaModificacion = System.DateTime.Now.Date
        'm_DBO_MateriaPrima.UsuarioModificacion = BasesParaCompatibilidad.Config.User

        'If errores <> "" Then
        '    messagebox.show("Complete correctamente el formulario. Se han encontrado los siguientes errores: " & Environment.NewLine & errores, "", MessageBoxButtons.OK , MessageBoxIcon.Exclamation )
        '    Return False
        'Else
        '    Return True
        'End If
        Return False
    End Function

    Public Sub EstablecerValores() Implements wizardable.EstablecerValores
        Me.cboEtiquetaTipo.mam_DataSource("ArticulosEtiquetasTiposCbo", False, dtb)
    End Sub

    Public Function grabarDatos(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean Implements wizardable.grabarDatos
        Return False
    End Function

    Public Function recuperarValor(nombre As String) As Object Implements wizardable.recuperarValor
        Return Nothing
    End Function
End Class