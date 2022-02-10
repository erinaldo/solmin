Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports CrystalDecisions.CrystalReports.Engine
Imports System
Imports System.Text
Imports System.IO
Imports System.IO.Directory
Imports System.Data
Imports System.Reflection
Imports System.Data.OleDb
Imports System.ComponentModel

Module ImpresionEtiquetasSDS

    Public Function Posiciones(ByVal dtb As DataTable)

        Dim printername As String
        printername = Configuration.ConfigurationSettings.AppSettings("ZebraPrinter").ToString()

        For i As Integer = 0 To dtb.Rows.Count - 1

            Dim command As New System.Text.StringBuilder
            With command
                .Append("^XA~TA000~JSN^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^PR2,2^MD10^JUS^LRN^CI0^XZ")
                .Append("~DG000.GRF,01280,020,")
                .Append(",::::::::::::::P02E2E0J0IE8EA8002EHE2E80,P054140J0I505540015541540,P0BE3EA0I0IFAFFA003FFE3FE8,P054150J0I515H5H015541550,P0HE2E80I0IE8EHE802EHE2EFA,P0541540I0I515H5H015541554,O02FA3FA0I0BFFABFF803FFE3FFE,O01541540I0I515H5H0155415H5,O02EE2EE80H0IE8EHE802EHE2EHE80,O01541540I0I505H5H015541554,O03FE3FFA0H0IFAFHF803FFE3FFE,O0H541550I0I515H5H015541554,O0IE3EEA0H0EFE8EFE003EHE3EE8,O0H5415540H0I515540015541540,N03FFA3FFE0H0BFFABFA003FFE3FE0,N0155415H5I0I515H5H015541550,O08AA08H8I0A8K8I0I808A8,,N02A2K2I0I2022A202J2A2A,N0I5415H5I0I515H540155415H5,N0HEFE2EFE800EHE8EIE02EFE2EFE80,N0I5415H54005H505I50155415H540,M02FHFE3FHFA00FFBAFIF83FFE3FHFE0,M015I515H54005H515I50155415H540,M02EIE2EIEH0IE8EIE82EHE2EIE0,M015H5415H54005H505I50155415H540,M03FHFE3FHFE80FBFAFIF83FFE3FHFE0,M0I510145H5H0I515I50155415H540,M0EFE0I03EF80EFE8EFEE83EFE3EFEE0,M0H540I0155405H505H540155415H5,L02FFE0I02FFE0FFBAFHFA03FFE3FHF80,L015540J0I505H515H5H015541554,L02EE80J0IE0EHE8EHE802EHE2EE8,L015540J0H5405H505540015541550,L03FFA0J0BFF0FHFAFEA003FFE3FA8,L010R010L01010,,::::::::::::^XA")
                .Append("^MMT")
                .Append("^LL0305")
                .Append("^PW609")
                .Append("^LS0")
                .Append("^FT64,64^XG000.GRF,1,1^FS")
                .Append("^BY4,3,91^FT104,154^BCN,,N,N")
                .Append("^FD>:" & dtb.Rows(i).Item(0).Replace("-", "").Replace(" ", "") & "^FS")
                .Append("^FT260,195^A0N,34,33^FH\^FD" & dtb.Rows(i).Item(0).ToString.Trim & "^FS")
                .Append("^PQ1,0,1,Y^XZ")
                .Append("^XA^ID000.GRF^FS^XZ")
            End With

            RawPrinterHelper.SendStringToPrinter(printername, command.ToString)
        Next

    End Function

    Public Function Posiciones(ByVal Posicion As String)

        Dim printername As String
        printername = Configuration.ConfigurationSettings.AppSettings("ZebraPrinter").ToString()


        Dim command As New System.Text.StringBuilder
        With command
            .Append("^XA~TA000~JSN^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^PR2,2^MD10^JUS^LRN^CI0^XZ")
            .Append("~DG000.GRF,01280,020,")
            .Append(",::::::::::::::P02E2E0J0IE8EA8002EHE2E80,P054140J0I505540015541540,P0BE3EA0I0IFAFFA003FFE3FE8,P054150J0I515H5H015541550,P0HE2E80I0IE8EHE802EHE2EFA,P0541540I0I515H5H015541554,O02FA3FA0I0BFFABFF803FFE3FFE,O01541540I0I515H5H0155415H5,O02EE2EE80H0IE8EHE802EHE2EHE80,O01541540I0I505H5H015541554,O03FE3FFA0H0IFAFHF803FFE3FFE,O0H541550I0I515H5H015541554,O0IE3EEA0H0EFE8EFE003EHE3EE8,O0H5415540H0I515540015541540,N03FFA3FFE0H0BFFABFA003FFE3FE0,N0155415H5I0I515H5H015541550,O08AA08H8I0A8K8I0I808A8,,N02A2K2I0I2022A202J2A2A,N0I5415H5I0I515H540155415H5,N0HEFE2EFE800EHE8EIE02EFE2EFE80,N0I5415H54005H505I50155415H540,M02FHFE3FHFA00FFBAFIF83FFE3FHFE0,M015I515H54005H515I50155415H540,M02EIE2EIEH0IE8EIE82EHE2EIE0,M015H5415H54005H505I50155415H540,M03FHFE3FHFE80FBFAFIF83FFE3FHFE0,M0I510145H5H0I515I50155415H540,M0EFE0I03EF80EFE8EFEE83EFE3EFEE0,M0H540I0155405H505H540155415H5,L02FFE0I02FFE0FFBAFHFA03FFE3FHF80,L015540J0I505H515H5H015541554,L02EE80J0IE0EHE8EHE802EHE2EE8,L015540J0H5405H505540015541550,L03FFA0J0BFF0FHFAFEA003FFE3FA8,L010R010L01010,,::::::::::::^XA")
            .Append("^MMT")
            .Append("^LL0305")
            .Append("^PW609")
            .Append("^LS0")
            .Append("^FT64,64^XG000.GRF,1,1^FS")
            .Append("^BY4,3,91^FT104,154^BCN,,N,N")
            .Append("^FD>:" & Posicion.Replace("-", "").Replace(" ", "") & "^FS")
            .Append("^FT260,195^A0N,34,33^FH\^FD" & Posicion.ToString.Trim & "^FS")
            .Append("^PQ1,0,1,Y^XZ")
            .Append("^XA^ID000.GRF^FS^XZ")
        End With

        'RawPrinterHelper.SendStringToPrinter(printername, command.ToString)
        RawPrinterHelper.SendStringToPrinter(GLOBAL_IMPRESORA_ZEBRA, command.ToString)


    End Function

    Public Function Mercaderia(ByVal Codigo As String, ByVal Descripcion As String, ByVal cclnt As String)

        Dim printername As String

        Dim lstr_etiqueta As String = ""

        If cclnt = "11232" Then
            lstr_etiqueta = EtiquetaChica_ABB(Codigo, Descripcion)
        Else
            lstr_etiqueta = EtiquetaChica_OTK(Codigo, Descripcion)
        End If

        RawPrinterHelper.SendStringToPrinter(GLOBAL_IMPRESORA_ZEBRA, lstr_etiqueta)

    End Function

    Private Function EtiquetaChica_ABB(ByVal Codigo As String, ByVal Descripcion As String) As String
        Dim command As New System.Text.StringBuilder
        With command
            '.Append("^XA~TA000~JSN^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^PR2,2^MD10^JUS^LRN^CI0^XZ")
            '.Append("~DG000.GRF,01280,020,")
            '.Append(",::::::Q015150I01514140H0H15140,R0A8A80I0HA82A0H02AA8A8,Q0174740H017747740057757740,R0A8A80I0HA82AA002AA0AA80,Q01FD7D0H01FFD7DF005FD9DFD0,Q02A8AA0I0HA82AA802AA8AHA0,Q057C750H017F477F405F717F70,Q02A8AA0I0HA82AA802AA8AHA0,Q07FDFF4001FFC7FFC03FF1FHF0,Q0HA8AA80H0HA82AA802AA8AHA0,P017747740017747H7407H757740,Q0HA82A80H0IA2AA002AA8AA80,P01FFDFFD001FFD7FD003FF5FF,P02AA8AHAI0HA82A8002AA8AA,P07F7C7F70017F477D007F757F40,,O017FFDFHF801FFC7FHF05FF9FHFC,P0IA8AHA800AA82AHA02AA8AHA8,O017H757H74017747I7057717H76,P0IA8AHA800AA82AHA02AA0AIA,O05FHFD7FFD01FFC7DFDC5FD9DFDF,O02AHA8AIAH0HA82AHA82AA8AIA,O0J7D7H7F017F477F745F717F77,O02AA282AHAH0HA82AHA82AA8AIA,N017FD1001FFC1FFC7FHF03FF1FHFD,O0HA80I0HA80AHA2AHA02AA8AHA8,N017740I0H7417747H7407H757H74,O0HA80I02A80AA82AA002AA8AHA0,N01FF0J07FD1FFD7FF003FF5FFD0,N02AA80I02AA0AHA2A8002AA8AA,N05440J01440544540H0145154,,:::::::::::::::::::::::::^XA")
            '.Append("^MMT")
            '.Append("^LL0203")
            '.Append("^PW406")
            '.Append("^LS0")
            '.Append("^FT32,64^XG000.GRF,1,1^FS")
            '.Append("^BY2,3,70^FT125,150^BCN,,Y,N")
            '.Append("^FD>;" & Codigo.Substring(0, Codigo.Length - 2) & ">6" & Codigo.Substring(Codigo.Length - 2) & "^FS")
            '.Append("^FT59,71^A0N,23,24^FH\^FD" & Descripcion & "^FS")
            '.Append("^PQ1,0,1,Y^XZ")
            '.Append("^XA^ID000.GRF^FS^XZ")



            .Append("")
            .Append("^FX Precompiled file for " & Application.StartupPath & "\ZebraTextFiles\logo.JPG width (pixels)=50 height (pixels)=20^FS")
            .Append("^FX Scale factors: xf=1.758 yf=1.798 orientation=0 scaled width (bytes)=13 scaled height (bytes)=36^FS")
            .Append("~DG4H!PBlog,468,13,")
            .Append(",")
            .Append(":")
            .Append(":")
            .Append(":")
            .Append(":")
            .Append("I01ECI0FE1H01FHC,")
            .Append(":")
            .Append("I01EFI0FE7F01FCFE,")
            .Append(":")
            .Append("I07EFCH0FE7FC1FCFE,")
            .Append(":")
            .Append("I07EFCH0FE7FC1FCHF8,")
            .Append(":")
            .Append("I0FEFEH0FE7F01FCFE,")
            .Append("I0FEFEH0FE7C01FCF8,")
            .Append(":")
            .Append("O0CL0CF8,")
            .Append(":")
            .Append("H03FEHF80FE7FC1FCHF8,")
            .Append(":")
            .Append("H03FEHF80FE7HF1FCHFC,")
            .Append(":")
            .Append("H0KFE0FE7HF1FCHFC,")
            .Append("H0F8H03E0FE7HF1FCHF8,")
            .Append(":")
            .Append("03F8H03F8FE7FC1FCHF8,")
            .Append(":")
            .Append("03FI01F8381H01FCE,")
            .Append(":")
            .Append(",")
            .Append(":")
            .Append(":")
            .Append(":")
            .Append(":")
            .Append(":")
            .Append(":")
            .Append("^XA")
            .Append("^PRC")
            .Append("^LH0,0^FS")
            .Append("^LL400")
            .Append("^MD0")
            .Append("^MNY")
            .Append("^LH0,0^FS")
            .Append("^BY2,3.0^FO56,62^B3N,N,69,Y,N^FR^FD" & Codigo & "^FS")
            .Append("^FO30,6^FR^XG4H!PBlog,1,1^FS")
            .Append("^FO36,43^A0N,16,14^CI13^FR^FD" & Descripcion & "^FS")
            .Append("^PQ1,0,0,N")
            .Append("^XZ")
            .Append("^FX End of job")
            .Append("^XA")
            .Append("^IDR:ID*.*")
            .Append("^XZ")

        End With
        Return command.ToString
    End Function

    Private Function EtiquetaChica_OTK(ByVal codigo As String, ByVal descripcion As String) As String
        Dim lstr_texto As New Text.StringBuilder
        lstr_texto.Append("^FX Precompiled file for C:\otk.bmp width (pixels)=87 height (pixels)=29^FS")
        lstr_texto.Append("^FX Scale factors: xf=1.003 yf=1.011 orientation=0 scaled width (bytes)=11 scaled height (bytes)=29^FS")
        lstr_texto.Append("~DG!V$4otk,319,11,")
        lstr_texto.Append(",")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append("H03E,")
        lstr_texto.Append("H0HFC,")
        lstr_texto.Append("01C1EJ0CJ0C,")
        lstr_texto.Append("03806J0CJ0C,")
        lstr_texto.Append("07H071H03F87C1F83E01C0")
        lstr_texto.Append("06H031803F9HF1F8HF07C0")
        lstr_texto.Append("06H019810C1C70E0E38F,")
        lstr_texto.Append("06H019018C3018C181HC,")
        lstr_texto.Append("06H019818C3018C181HC,")
        lstr_texto.Append("06H019018C3H0HC38798,")
        lstr_texto.Append("06H031018C7H0HCH3E18,")
        lstr_texto.Append("06H031018C3H0HC3F01C,")
        lstr_texto.Append("03H071818C3018C1CH0C,")
        lstr_texto.Append("0380E1838C3838C1CH0C,")
        lstr_texto.Append("01F7C1C70E1C7061CH0F,")
        lstr_texto.Append("H0HF80HF060FE070FH07C0")
        lstr_texto.Append("H03EH03C0207CI03801C0")
        lstr_texto.Append(",")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append("^XA")
        lstr_texto.Append("^PRC")
        lstr_texto.Append("^LH0,0^FS")
        lstr_texto.Append("^LL400")
        lstr_texto.Append("^MD0")
        lstr_texto.Append("^MNY")
        lstr_texto.Append("^LH0,0^FS")
        lstr_texto.Append("^FO13,6^FR^XG!V$4otk,1,1^FS")
        lstr_texto.Append("^BY2,3.0^FO33,74^B3N,N,51,Y,N^FR^FD" & codigo & "^FS")
        lstr_texto.Append("^FO16,47^A0N,27,23^CI13^FR^FD" & descripcion & "^FS")
        lstr_texto.Append("^PQ1,0,0,N")
        lstr_texto.Append("^XZ")
        lstr_texto.Append("^FX End of job")
        lstr_texto.Append("^XA")
        lstr_texto.Append("^IDR:ID*.*")
        lstr_texto.Append("^XZ")
        Return lstr_texto.ToString
    End Function

    Public Function Mercaderia_6x4(ByVal Codigo As String, ByVal Descripcion As String, ByVal Usuario As String, ByVal Referencia As String, ByVal unimed As String, Optional ByVal cantunidad As String = "", Optional ByVal cclnt As String = "", Optional ByVal OrdComp As String = "", Optional ByVal Ubicacion As String = "", Optional ByVal VC_ALMACEN As String = "", Optional ByVal CZNALM As String = "", Optional ByVal TCMPCL As String = "", Optional ByVal CRTLTE As String = "")

        Dim printername As String
        printername = "Generic / Text Only"
        Dim lstr_command As String

        If cclnt = "11232" Then

            lstr_command = EtiquetaABB(Codigo, Descripcion, Usuario, OrdComp, unimed, cclnt, VC_ALMACEN, TCMPCL, CRTLTE)
        Else
            lstr_command = EtiquetaOtk(Codigo, Descripcion, Usuario, Referencia, unimed, cantunidad, cclnt, OrdComp, Ubicacion, TCMPCL, CRTLTE)
        End If

        RawPrinterHelper.SendStringToPrinter(GLOBAL_IMPRESORA_ZEBRA, lstr_command)

    End Function



    Private Function EtiquetaABB(ByVal Codigo As String, ByVal Descripcion As String, ByVal Usuario As String, ByVal OC As String, ByVal unimed As String, Optional ByVal cclnt As String = "", Optional ByVal VC_ALMACEN As String = "", Optional ByVal RazonSocial As String = "", Optional ByVal Lote As String = "") As String
        Dim command As New System.Text.StringBuilder
        With command

            '.Append("^FX Precompiled file for " & Application.StartupPath & "\ZebraTextFiles\" & "abblogo.bmp" & " width (pixels)=152 height (pixels)=63^FS")
            '.Append("^FX Scale factors: xf=0.863 yf=1.364 orientation=0 scaled width (bytes)=17 scaled height (bytes)=86^FS")
            '.Append("~DG!MA0Cabb,1462,17,")

            .Append("J01F9FEJ01IFCFCI01IFDFC,")
            .Append("J03F9FEJ01IFCHFI01IFDHF,")
            .Append(":")
            .Append("J03F9FEJ01IFCHFCH01IFDHFC,")
            .Append("J03F9HFJ01IFCIFH01IFDIF,")
            .Append("J07F9HFJ01IFCIF801IFDIF,")
            .Append(":")
            .Append("J07F9HFJ01IFCIFC01IFDIF8,")
            .Append(":")
            .Append(":")
            .Append("J07F9HFJ01IFCIFC01IFDIFC,")
            .Append(":")
            .Append("J07F9HF8I01IFCIFC01IFDIFE,")
            .Append(":")
            .Append("J0HF9HF8I01IFCIFE01IFDIFE,")
            .Append(":")
            .Append("J0HF9HFCI01IFCIFE01IFDIFE,")
            .Append(":")
            .Append("I01HF9HFCI01IFCIFE01IFDIFE,")
            .Append(":")
            .Append("I03HF9HFEI01IFCIFE01IFDIFE,")
            .Append(":")
            .Append(":")
            .Append(":")
            .Append(":")
            .Append("I07HF9IFI01IFCIFC01IFDIFC,")
            .Append(":")
            .Append("I07HF9IF8H01IFCIFC01IFDIF8,")
            .Append(":")
            .Append("I0IF9IF8H01IFCIFC01IFDIF8,")
            .Append("I0IF9IF8H01IFCIF801IFDIF,")
            .Append("I0IF9IFCH01IFCIFH01IFDIF,")
            .Append(":")
            .Append("H01IF9IFCH01IFCHFEH01IFDHFE,")
            .Append("H01IF9IFCH01IFCHFCH01IFDHFC,")
            .Append("H01IF9IFCH01IFCIFH01IFDHFE,")
            .Append(":")
            .Append("H03IFDIFCH01IFCIF801IFDIF,")
            .Append("H03IFDIFCH01IFCIFC01IFDIF,")
            .Append(":")
            .Append(",")
            .Append(":")
            .Append("H03IFDIFEH01IFCJF01IFDIFE,")
            .Append(":")
            .Append("H07IFDJFH01IFCJF81IFDJF,")
            .Append("H07IFDJFH01IFCJF81IFDJF80")
            .Append("H07IFDJFH01IFCJFC1IFDJF80")
            .Append(":")
            .Append("H07IFDJF801IFCJFC1IFDJFC0")
            .Append("H0JFDJF801IFCJFC1IFDJFC0")
            .Append("H0JFDJF801IFCJFE1IFDJFC0")
            .Append(":")
            .Append("H0JFDJFC01IFCJFE1IFDJFC0")
            .Append("01JFDJFC01IFCJFE1IFDJFC0")
            .Append(":")
            .Append("01JFDJFE01IFCJFE1IFDJFC0")
            .Append(":")
            .Append("03JFDJFE01IFCJFE1IFDJFC0")
            .Append(":")
            .Append(":")
            .Append("07JFDKF01IFCJFE1IFDJFC0")
            .Append(":")
            .Append(":")
            .Append(":")
            .Append("0IFE39KF01IFCJFE1IFDJFC0")
            .Append("0IF8J0IF01IFCJFC1IFDJFC0")
            .Append(":")
            .Append(":")
            .Append("0IF8J0IF81IFCJF81IFDJF80")
            .Append(":")
            .Append("0IF8J07HF81IFCJF81IFDJF80")
            .Append("0IFK07HFC1IFCJF01IFDJF,")
            .Append("1IFK07HFC1IFCIFE01IFDIFE,")
            .Append(":")
            .Append("1HFEK03HFC1IFCIFC01IFDIFC,")
            .Append("1HFEK03HFE1IFCIFC01IFDIF8,")
            .Append("3HFEK03HFE1IFCIF801IFDIF,")
            .Append(":")
            .Append("3HFCK01HFE1IFCHFEH01IFDIF,")
            .Append("3HFCK01IF1IFCHF8H01IFDHFC,")
            .Append("7HFCK01IF1IFCF8I01IFDFC,")
            .Append(":")
            .Append(",")
            .Append(":")
            .Append(":")
            .Append(":")
            .Append("^XA")
            .Append("^PRC")
            .Append("^LH0,0^FS")
            .Append("^LL560")
            .Append("^MD0")
            .Append("^MNY")
            .Append("^LH0,0^FS")
            '.Append("^FO35,32^FR^XG!MA0Cabb,1,1^FS")
            .Append("^FO575,196^A0N,30,25^CI13^FR^FD" & objSeguridadBN.pUsuario & "^FS")
            .Append("^FO238,49^A0N,55,53^CI13^FR^FD" & Codigo & "^FS")

            'FECHA
            .Append("^FO598,289^A0N,27,23^CI13^FR^FD" & Today.ToShortDateString() & "^FS")
            .Append("^FO509,287^A0N,27,23^CI13^FR^FDFECHA :^FS")
            'HORA
            .Append("^FO510,329^A0N,27,23^CI13^FR^FDHORA :^FS")
            .Append("^FO609,329^A0N,27,23^CI13^FR^FD" & Now.ToShortTimeString & "^FS")
            'ALMACEN
            .Append("^FO510,245^A0N,30,26^CI13^FR^FDALMACEN :^FS")
            .Append("^FO630,245^A0N,30,26^CI13^FR^FD" & Trim(VC_ALMACEN) & "^FS")
            '.Append("^FO549,287^A0N,27,23^CI13^FR^FDPROYECTO:^FS")
            '.Append("^FO670,289^A0N,27,23^CI13^FR^FD" & VC_ALMACEN & "^FS")


            '.Append("^FO549,413^A0N,27,23^CI13^FR^FDU/M :^FS")
            '.Append("^FO608,414^A0N,27,23^CI13^FR^FD" & Trim(unimed) & "^FS")
            'UM
            .Append("^FO509,455^A0N,27,23^CI13^FR^FDU/M :^FS")
            .Append("^FO568,455^A0N,27,23^CI13^FR^FD" & Trim(unimed) & "^FS")

            'miguel 27012015
            '.Append("^FO580,411^A0N,27,23^CI13^FR^FDALMACEN :^FS")
            '.Append("^FO698,411^A0N,27,23^CI13^FR^FD" & VC_ALMACEN & "^FS")
            '---
            .Append("^FO25,100^A0N,55,55^CI13^FR^FD" & RazonSocial & "^FS")
            .Append("^FO25,159^A0N,45,40^CI13^FR^FD" & Trim(Descripcion) & "^FS")
            .Append("^BY2,3.0^FO33,224^B3N,N,137,Y,N^FR^FD" & Trim(Codigo) & "^FS")
            'OC
            .Append("^FO569,371^A0N,27,23^CI13^FR^FD" & Trim(OC) & "^FS")
            .Append("^FO510,371^A0N,27,23^CI13^FR^FDO/C :^FS")

            'EGL - HUNDRED
            .Append("^FO579,413^A0N,27,23^CI13^FR^FD" & Trim(Lote) & "^FS")
            .Append("^FO510,413^A0N,27,23^CI13^FR^FDLOTE :^FS")
            '.Append("^FO619,413^A0N,27,23^CI13^FR^FD" & Trim(Lote) & "^FS")
            '.Append("^FO550,413^A0N,27,23^CI13^FR^FDLOTE :^FS")

            .Append("^PQ1,0,0,N")
            .Append("^XZ")
            .Append("^FX End of job")
            .Append("^XA")
            .Append("^IDR:ID*.*")
            .Append("^XZ")

        End With
        Return command.ToString
    End Function

    Private Function EtiquetaOtk(ByVal Codigo As String, ByVal Descripcion As String, ByVal Usuario As String, ByVal referencia As String, ByVal unimed As String, ByVal cant As String, Optional ByVal cclnt As String = "", Optional ByVal ordcomp As String = "", Optional ByVal ubicacion As String = "", Optional ByVal RazonSocial As String = "", Optional ByVal Lote As String = "") As String
        Dim lstr_texto As New Text.StringBuilder

        'lstr_texto.Append("^FX Precompiled file for C:\otk.bmp width (pixels)=87 height (pixels)=29^FS")
        'lstr_texto.Append("^FX Scale factors: xf=2.879 yf=3.652 orientation=0 scaled width (bytes)=32 scaled height (bytes)=106^FS")
        'lstr_texto.Append("~DGESR0Cotk,3392,32,")
        '    lstr_texto.Append("^FO100,100^A0N,24,21^CI13^FR^FDCAN : " & RazonSocial & "^FS")

        lstr_texto.Append(",")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append("L01IF8,")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append("K07LFC,")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append("J03FEI07HF8Q03FR01F8,")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append("I01HFK01F8Q03FR01F8,")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append("I07F8K01HFH0EM0KFI0IFCI0JFCI0IFEK03FC,")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append("I07CM03FH0FCL0KF03LFH0JFC03KF8I0IFC,")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append("I07CN07E0FCI01CH03FI03FE01HFH01HFI03FEH0HFH07HF,")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append("I07CN07E0EJ01F803FH01F8J07E01F8H01F8I01FE07E,")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append("I07CN07E0FCI01F803FH01F8J07E01F8H01F8I01FE07E,")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append("I07CN07E0EJ01F803FH01F8K0FC1F8H07F8H07HF03F,")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append("I07CM03FH0EJ01F803FH0HF8K0FC1F8H07C0IFEH03F,")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append("I07CM03FH0EJ01F803FH01F8K0FC1F8H07IFCJ03FE,")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append("I01F8K01HFH0FCI01F803FH01F8J07E01F8H01HFM07E,")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append("I01HFK0HF8H0FCI0HF803FH01HFI03FE01F8H01HFM07E,")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append("J03IF8IFCI0HF803FCH03FCH03FE01HFI03FH01HFM07HF,")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append("K07KFEJ01KFCI07CI07JF8I03FEH03HFCL0IFC,")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append("L01IF8M07HFL0CJ0IFCQ0HF8L03FC,")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(",")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append(":")
        lstr_texto.Append("^XA")
        lstr_texto.Append("^PR10")
        lstr_texto.Append("^LH0,0^FS")
        lstr_texto.Append("^LL1215")
        lstr_texto.Append("^MD0")
        lstr_texto.Append("^MNY")
        lstr_texto.Append("^LH0,0^FS")
        lstr_texto.Append("^FO21,10^FR^XGESR0Cotk,1,1^FS")
        lstr_texto.Append("^FO312,43^A0N,54,47^CI13^FR^FD" & Codigo & "^FS")

        If Descripcion.Length > 30 Then
            lstr_texto.Append("^FO39,149^A0N,45,45^CI13^FR^FD" & Descripcion.Substring(0, 30) & "^FS")
            lstr_texto.Append("^FO39,199^A0N,45,45^CI13^FR^FD" & Descripcion.Substring(30) & "^FS")
        Else
            lstr_texto.Append("^FO39,169^A0N,40,40^CI13^FR^FD" & Descripcion & "^FS")
        End If

        lstr_texto.Append("^FO39,95^A0N,55,55^CI13^FR^FD" & RazonSocial & "^FS")
        lstr_texto.Append("^BY2,3.0^FO37,256^B3N,N,183,Y,N^FR^FD" & Codigo & "^FS")

        
        lstr_texto.Append("^FO488,262^A0N,31,28^CI13^FR^FDREF : " & referencia & "^FS")
        lstr_texto.Append("^FO491,315^A0N,24,21^CI13^FR^FDO/C : " & ordcomp & "^FS")
        'EGL - HUNDRED
        lstr_texto.Append("^FO491,359^A0N,24,21^CI13^FR^FDLOTE : " & Trim(Lote) & "^FS")

        lstr_texto.Append("^FO491,403^A0N,24,21^CI13^FR^FDCAN : " & cant & "^FS")
        lstr_texto.Append("^FO491,444^A0N,24,21^CI13^FR^FDUBI : " & ubicacion & "^FS")
        'lstr_texto.Append("^FO531,444^A0N,24,21^CI13^FR^FDUBI : " & ubicacion & "^FS")


        'lstr_texto.Append("^FO603,358^A0N,31,28^CI13^FR^FD" & cant & "^FS")
        'lstr_texto.Append("^FO603,310^A0N,31,28^CI13^FR^FD" & ordcomp & "^FS")
        'lstr_texto.Append("^FO603,400^A0N,31,28^CI13^FR^FD" & ubicacion & "^FS")
        lstr_texto.Append("^PQ1,0,0,N")
        lstr_texto.Append("^XZ")
        lstr_texto.Append("^FX End of job")
        lstr_texto.Append("^XA")
        lstr_texto.Append("^IDR:ID*.*")
        lstr_texto.Append("^XZ")
        Return lstr_texto.ToString
    End Function


End Module