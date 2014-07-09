﻿Public Class CodigoLote
    Private ctlTipPro As spTiposProductos
    Private ctlTipLot As spTiposLotes

    Public Sub New()
        ctlTipPro = New spTiposProductos
        ctlTipLot = New spTiposLotes
    End Sub

    Function GenerarCodigoDiferencias(ByVal fecha As Date, ByVal productoId As Integer, ByVal TipoLoteId As Integer) As String
        Try
            Dim mes As String

            If fecha.Month < 10 Then
                mes = "0" & fecha.Month
            Else
                mes = fecha.Month
            End If

            Dim abrProducto As String = ctlTipPro.Select_Record(productoId, BasesParaCompatibilidad.BD.transaction).Abreviatura
            Dim abrLote As String = ctlTipLot.Select_Record(TipoLoteId, BasesParaCompatibilidad.BD.transaction).Abreviatura

            If abrProducto = "" Or abrLote = "" Then
                Return ""
            Else
                Return fecha.Year & mes & "01" & abrProducto & abrLote & "1"
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Function GenerarCodigoLoteFinal(ByVal fecha As Date, ByVal productoId As Integer, ByVal TipoLoteId As Integer) As String
        Try
            Dim dia, mes As String
            If fecha.Day < 10 Then
                dia = "0" & fecha.Day
            Else
                dia = fecha.Day
            End If
            If fecha.Month < 10 Then
                mes = "0" & fecha.Month
            Else
                mes = fecha.Month
            End If

            Dim abrProducto As String = ctlTipPro.Select_Record(productoId, BasesParaCompatibilidad.BD.transaction).Abreviatura
            Dim abrLote As String = ctlTipLot.Select_Record(TipoLoteId, BasesParaCompatibilidad.BD.transaction).Abreviatura

            Return fecha.Year & mes & dia & abrProducto & abrLote & "1"
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Function GenerarCodigoLoteProcesoCompra(ByVal fecha As Date, ByVal productoid As Integer, ByVal tipoloteid As Integer) As String
        Try
            Dim dia, mes As String
            If fecha.Day < 10 Then
                dia = "0" & fecha.Day
            Else
                dia = fecha.Day
            End If
            If fecha.Month < 10 Then
                mes = "0" & fecha.Month
            Else
                mes = fecha.Month
            End If

            Dim abrProducto As String = ctlTipPro.Select_Record(productoid, BasesParaCompatibilidad.BD.transaction).Abreviatura
            Dim abrLote As String = ctlTipLot.Select_Record(TipoLoteId, BasesParaCompatibilidad.BD.transaction).Abreviatura


            If abrProducto = "" Or abrLote = "" Then
                Return ""
            Else
                Return fecha.Year & mes & dia & abrProducto & abrLote & "1"
            End If

        Catch ex As Exception
            Return ""
        End Try

    End Function

    Function GenerarCodigoLote(ByVal fecha As Date, ByVal productoId As Integer, ByVal TipoLoteId As Integer) As String
        Try
            Dim dia, mes As String
            If fecha.Day < 10 Then
                dia = "0" & fecha.Day
            Else
                dia = fecha.Day
            End If
            If fecha.Month < 10 Then
                mes = "0" & fecha.Month
            Else
                mes = fecha.Month
            End If

            Dim abrProducto As String = ctlTipPro.Select_Record(productoId, BasesParaCompatibilidad.BD.transaction).Abreviatura
            Dim abrLote As String = ctlTipLot.Select_Record(TipoLoteId, BasesParaCompatibilidad.BD.transaction).Abreviatura

            If abrProducto = "" Or abrLote = "" Then
                Return ""
            Else
                Return fecha.Year & mes & dia & abrProducto & abrLote & "1"
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Function GenerarCodigoLoteCompra(ByVal fecha As Date, ByVal productoid As Integer, ByVal DescripcionTipoLoteRecepcion As String) As String
        Try
            Dim dia, mes As String
            If fecha.Day < 10 Then
                dia = "0" & fecha.Day
            Else
                dia = fecha.Day
            End If
            If fecha.Month < 10 Then
                mes = "0" & fecha.Month
            Else
                mes = fecha.Month
            End If

            Dim abrProducto As String = ctlTipPro.Select_Record(productoid, BasesParaCompatibilidad.BD.transaction).Abreviatura
            Dim abrlote As String = ctlTipLot.DevolverPorDescripcion(DescripcionTipoLoteRecepcion, BasesParaCompatibilidad.BD.transaction).Abreviatura

            If abrProducto = "" Or abrlote = "" Then
                Return ""
            Else
                Return fecha.Year & mes & dia & abrProducto & abrlote & "1"
            End If

        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function GenerarCodigoLoteSalida(ByVal fecha As Date, ByVal productoid As Integer, ByVal tipoloteid As Integer) As String
        Try
            Dim dia, mes As String
            If fecha.Day < 10 Then
                dia = "0" & fecha.Day
            Else
                dia = fecha.Day
            End If
            If fecha.Month < 10 Then
                mes = "0" & fecha.Month
            Else
                mes = fecha.Month
            End If

            Dim abrProducto As String = ctlTipPro.Select_Record(productoid, BasesParaCompatibilidad.BD.transaction).Abreviatura
            Dim abrLote As String = ctlTipLot.Select_Record(tipoloteid, BasesParaCompatibilidad.BD.transaction).Abreviatura

            If abrProducto = "" Or abrLote = "" Then
                Return ""
            Else
                Return fecha.Year & mes & dia & _
                    abrProducto & abrLote & "1"
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Sub validarCodigoLote(ByVal Local_EsUnicoCampo As String, ByVal Local_EsUnicoCampoID As String, _
                                 ByVal Local_EsUnicoTabla As String, ByVal Local_EsUnicoID As String, ByRef texto As String)
        If texto <> "" And texto <> Nothing Then
            Try
                If (Local_EsUnicoCampo <> "" And Local_EsUnicoCampoID <> "" And Local_EsUnicoTabla <> "") Then
                    Dim ctl As New BasesParaCompatibilidad.ctlCuadroDeTexto
                    If ctl.Validar(Local_EsUnicoID, Local_EsUnicoCampo, texto, Local_EsUnicoCampoID, Local_EsUnicoTabla) Then
                        Dim aux As String
                        aux = texto.Substring(0, 14)


                        Dim c As Char = texto.Substring(14, 1)
                        Dim digit As Integer = Convert.ToInt32(c)
                        If digit = 57 Then digit = 64
                        digit += 1
                        c = ChrW(digit)
                        aux = aux & c


                        If aux.Length > 15 Then
                            messageBox.show("Solo se permite 9 lotes por dia.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                        texto = aux
                        validarCodigoLote(Local_EsUnicoCampo, Local_EsUnicoCampoID, Local_EsUnicoTabla, Local_EsUnicoID, texto)
                    End If
                End If
            Catch ex As Exception
                texto = ""
            End Try
        End If
    End Sub
End Class
