Public Class CodigoBarra
    Private Const CODIGO_EMPRESA As String = "08411831"
    Private Const LONGITUD_BARCODE_2 As Integer = 18 '17 '18


    'Public codigo1 As String
    'Public codigo2 As String


    Public Function digito_control_ean(ByVal num As String, g13 As String) As Integer
        Dim arr() As Char = num.ToCharArray()
        ' Use Array.Reverse function.
        Array.Reverse(arr)
        ' Construct new string.
        Dim cadenacorregida As String = New String(arr)

        Dim cont As Integer = 0
        Dim conPosiciones As Integer = 3
        Dim res As Integer = 0

        While cont < Len(cadenacorregida)
            res = res + cadenacorregida.Substring(cont, 1) * conPosiciones

            If conPosiciones = 1 Then
                conPosiciones = 3
            Else
                conPosiciones = 1
            End If

            cont = cont + 1
        End While

        Dim menor As Integer = res
        While res Mod 10 <> 0
            res = res + 1
        End While

        Return res - menor
    End Function

    'Public Function digito_control_ean(ByVal num As String) As Integer

    '    Dim cont As Integer = 0
    '    Dim conPosiciones As Integer = 1
    '    Dim res As Integer = 0

    '    While cont < Len(num)
    '        res = res + num.Substring(cont, 1) * conPosiciones

    '        If conPosiciones = 1 Then
    '            conPosiciones = 3
    '        Else
    '            conPosiciones = 1
    '        End If

    '        cont = cont + 1
    '    End While

    '    Dim menor As Integer = res
    '    While res Mod 10 <> 0
    '        res = res + 1
    '    End While

    '    Return res - menor
    'End Function

    Public Function calcular_codigo_barras_1(ByVal ean14 As String, ByVal lote As String) As GS1
        'Return "(01)" & ean14 & "(10)" & lote
        'Me.codigo1 = "(01)" & ean14 & "(10)" & lote
        Dim gs As New GS1
        gs.Codigo1 = "(01)" & ean14
        gs.Codugo2 = "(10)" & lote
        Return gs
        'Return "(01)" & ean14 & "(10)" & lote


        '"{CODE C}{FNC1}0118411831520015{CODE B}10" & Var0'
    End Function

    Public Function calcular_codigoBarras2(ByVal scc As String, ByVal caducidad As String) As GS1
        'Dim Campo As String = if(caducidad = "", scc, caducidad)
        'Dim cod As String = "[00]" & CODIGO_EMPRESA
        'Dim cont As Integer = Len(cod) - 4
        'Dim tope As Integer = LONGITUD_BARCODE_2 - Len(Campo)

        'While cont < tope
        '    cod = cod & "0"
        '    cont = cont + 1
        'End While

        'cod = cod & Campo
        Dim gs As New GS1
        Dim cadena As String = caducidad.Replace("/", "")
        'Dim Campo As String = If(caducidad = "", scc, scc & "[17]" & cadena.Substring(0, 4) & cadena.Substring(6, 2))
        ' Dim Campo As String = scc
        'Dim cod As String = "(00)" & CODIGO_EMPRESA
        'Dim cont As Integer = Len(cod) - 4
        'Dim tope As Integer = LONGITUD_BARCODE_2 - Len(Campo)

        'While cont < tope
        '    cod = cod & "0"
        '    cont = cont + 1
        'End While
        If caducidad = "" Then
            'cod = cod & scc
            gs.Codigo1 = "(00)" & scc 'cod
            gs.Codugo2 = ""
        Else

            gs.Codigo1 = "(00)" & scc 'cod
            gs.Codugo2 = "(17)" & cadena

            'cod = cod & scc & "[17]" & cadena.Substring(0, 4) & cadena.Substring(6, 2)
            ' cod = cod & scc & "(17)" & cadena

        End If

        ' cod = cod & digito_control_ean(cod)

        'gs.control = digito_control_ean(gs.Codigo1.Replace("(00)", ""))
        'Dim cod As String = "[00]" & CODIGO_EMPRESA

        'If caducidad = "" Then
        '    'Dim cont As Integer = Len(cod) - 4
        '    'Dim tope As Integer = LONGITUD_BARCODE_2 - Len(scc)

        '    'While cont < tope
        '    '    cod = cod & "0"
        '    '    cont = cont + 1
        '    'End While


        '    cod = cod & scc
        'Else
        '    cod = cod & scc & "(17)" & caducidad
        'End If
        'Me.codigo2 = cod


        Return gs
        'Return cod
    End Function

    Public Function ajustarSCC(ByVal scc As String, g13 As String) As String
        Dim cod As String = "(00)" & CODIGO_EMPRESA
        Dim sccCorregido As String = CODIGO_EMPRESA
        Dim cont As Integer = Len(cod) - 4
        Dim tope As Integer = LONGITUD_BARCODE_2 - Len(scc)

        While cont < tope
            sccCorregido = sccCorregido & "0"
            cont = cont + 1
        End While

        Dim matricula As String = sccCorregido & scc
        'Dim control As String = digito_control_ean(matricula.Replace("(00)", ""), g13)

        Return matricula '& control
    End Function

    Public Function ajustarSCC_Con_Digito_Control(ByVal scc As String, g13 As String) As String
        Dim cod As String = "(00)" & CODIGO_EMPRESA
        Dim sccCorregido As String = CODIGO_EMPRESA
        Dim cont As Integer = Len(cod) - 4
        Dim tope As Integer = LONGITUD_BARCODE_2 - 1 - Len(scc)

        While cont < tope
            sccCorregido = sccCorregido & "0"
            cont = cont + 1
        End While

        Dim matricula As String = sccCorregido & scc
        Dim control As String = digito_control_ean(matricula.Replace("(00)", ""), g13)

        Return matricula & control
    End Function
End Class
