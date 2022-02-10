Imports SOLMIN_SC.Entidad
Imports System.Text
Imports Ransa.Utilitario
Public Class clsRepColumnaEmbarque
    Private Const _kNivelEmbarque As String = "EM"
    Private Const _kNivelEmbarqueItem As String = "IT"
    Public Const kNivelEmbarque As String = _kNivelEmbarque
    Public Const kNivelEmbarqueItem As String = _kNivelEmbarqueItem

    Public Function ListaColumnasEmbarque() As DataTable
        Dim dtColumna As New DataTable
        Dim dr As DataRow
        'CODIGO : Codigo de Columna
        'DESCRIPCION: Referido al Item
        'TIPO : Tipo de DATO : Texto ,Fecha ,Numerico
        dtColumna.Columns.Add("CODIGO")
        dtColumna.Columns.Add("DESCRIPCION")
        dtColumna.Columns.Add("TIPO")
        dtColumna.Columns.Add("NIVEL")

        Dim NPOI_SC As New HelpClass_NPOI_SC
        Dim pTTexto As String = NPOI_SC.keyDatoTexto
        Dim pTNumero As String = NPOI_SC.keyDatoNumero
        Dim pTFecha As String = NPOI_SC.keyDatoFecha
        Dim pNivelEmbarque As String = _kNivelEmbarque

        dr = dtColumna.NewRow
        dr("CODIGO") = "NORSCI"
        dr("DESCRIPCION") = "Embarque"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "FORSCI"
        dr("DESCRIPCION") = "Fecha"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)



        dr = dtColumna.NewRow
        dr("CODIGO") = "NREFCLEMB"
        dr("DESCRIPCION") = "Referencia Cliente"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "REFDO1"
        dr("DESCRIPCION") = "Referencia Documento"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)



        dr = dtColumna.NewRow
        dr("CODIGO") = "TDITES"
        dr("DESCRIPCION") = "Descripción Mercadería"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "TPRVCL"
        dr("DESCRIPCION") = "Proveedor"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "PNNMOS"
        dr("DESCRIPCION") = "Orden Servicio"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "DOCEMB"
        dr("DESCRIPCION") = "B/L AWB"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)




        dr = dtColumna.NewRow
        dr("CODIGO") = "CTRMAL"
        dr("DESCRIPCION") = "Terminal de Almacenamiento"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "REGIMEN"
        dr("DESCRIPCION") = "REGIMEN"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "DESPACHO"
        dr("DESCRIPCION") = "DESPACHO"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "CAGNCR"
        dr("DESCRIPCION") = "Agente de Carga"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "NUMSEG"
        dr("DESCRIPCION") = "N° Seguro"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "CMEDTRAGEN"
        dr("DESCRIPCION") = "Transporte Agencia"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "CMEDTR"
        dr("DESCRIPCION") = "Medio Transporte"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "NUMDUA"
        dr("DESCRIPCION") = "Número Dua"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "CANAL"
        dr("DESCRIPCION") = "CANAL"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "TNIMCIN"
        dr("DESCRIPCION") = "Línea Naviera"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "CVPRCN"
        dr("DESCRIPCION") = "Nave/Cia. Transporte"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "CPRTOE"
        dr("DESCRIPCION") = "Origen"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "CPRTOA"
        dr("DESCRIPCION") = "Destino"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "QVOLMR"
        dr("DESCRIPCION") = "M3"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "QPSOAR"
        dr("DESCRIPCION") = "Kg. Brutos"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "NDIALB"
        dr("DESCRIPCION") = "Días Libres"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "NDIASE"
        dr("DESCRIPCION") = "Días SobreEstadía"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)



        dr = dtColumna.NewRow
        dr("CODIGO") = "FACCOP"
        dr("DESCRIPCION") = "F. Factura Copia"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "FACORG"
        dr("DESCRIPCION") = "F. Factura Original"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "DEMCOP"
        dr("DESCRIPCION") = "F. BL/AWB Copia"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "DEMORG"
        dr("DESCRIPCION") = "F. BL/AWB Original"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "TRACOP"
        dr("DESCRIPCION") = "F. Traducción Copia"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "TRAORG"
        dr("DESCRIPCION") = "F. Traducción Original"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "VOLCOP"
        dr("DESCRIPCION") = "F. Volante Copia"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "VOLORG"
        dr("DESCRIPCION") = "F. Volante Original"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "SEGCOP"
        dr("DESCRIPCION") = "F. Seguro Copia"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "SEGORG"
        dr("DESCRIPCION") = "F. Seguro Original"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)



        dr = dtColumna.NewRow
        dr("CODIGO") = "CORCOP"
        dr("DESCRIPCION") = "F. Certificado Copia"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "CORORG"
        dr("DESCRIPCION") = "F. Certificado Original"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "OTRORG"
        dr("DESCRIPCION") = "F. Otro Original"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "CKCLPV"
        dr("DESCRIPCION") = "F. Entrega por el Proveedor"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "RECPOP"
        dr("DESCRIPCION") = "F. Entrega OC"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "CKIGAT"
        dr("DESCRIPCION") = "F. Llegada Material"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "CKCROK"
        dr("DESCRIPCION") = "F. Carga OK"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "CKCRDS"
        dr("DESCRIPCION") = "F. Carga Discrepancia"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)
 

        dr = dtColumna.NewRow
        dr("CODIGO") = "CKRECO"
        dr("DESCRIPCION") = "F. Recojo Material"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "CKAECL"
        dr("DESCRIPCION") = "F. Aprobacion Doc."
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "CHKEPR"
        dr("DESCRIPCION") = "F. Entrega Origen"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)



        dr = dtColumna.NewRow
        dr("CODIGO") = "CHKETA"
        dr("DESCRIPCION") = "ETA"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "CHKETD"
        dr("DESCRIPCION") = "ETD"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "FAPRAR"
        dr("DESCRIPCION") = "Fecha Embarque"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

   
        dr = dtColumna.NewRow
        dr("CODIGO") = "FAPREV"
        dr("DESCRIPCION") = "Fecha Llegada"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

 
        dr = dtColumna.NewRow
        dr("CODIGO") = "FCDCOR"
        dr("DESCRIPCION") = "F. Volante"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "FECNUM"
        dr("DESCRIPCION") = "F. Numeración"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "FECPGD"
        dr("DESCRIPCION") = "F. Pago Derechos"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "FECLEV"
        dr("DESCRIPCION") = "F. Levante"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "FECDCP"
        dr("DESCRIPCION") = "F. Doc. completos"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "FECALM"
        dr("DESCRIPCION") = "F. Entrega Almacén"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "FECPRO"
        dr("DESCRIPCION") = "F. Proforma"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "FECPGP"
        dr("DESCRIPCION") = "F. Pago Proforma"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "FECFAC"
        dr("DESCRIPCION") = "F. Entrega Factura"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "DIFPDA"
        dr("DESCRIPCION") = "F. Pag. Der vs Entrega Almacén"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "DIFDCN"
        dr("DESCRIPCION") = "F. Doc. Comp. vs F. Num"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "DIFRCCK"
        dr("DESCRIPCION") = "F. Entrega OC vs Entrega x Proveedor"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "DIFERM"
        dr("DESCRIPCION") = "F. Embarque vs Llegada"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "DIFEME"
        dr("DESCRIPCION") = "F. Llegada vs Levante"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "DIFEEP"
        dr("DESCRIPCION") = "F. Levante vs Almacén"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "DXF6F5"
        dr("DESCRIPCION") = "F. Num. vs Pag. Der."
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "DXF4F3"
        dr("DESCRIPCION") = "F. Doc. Completos vs ETA"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "DXF8F4"
        dr("DESCRIPCION") = "F. Entrega Almacén VS Doc. Completos"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "NOPRCN"
        dr("DESCRIPCION") = "Nro Operación"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "NDCFCC"
        dr("DESCRIPCION") = "Nro Factura Op."
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "FDCFCC"
        dr("DESCRIPCION") = "Fecha Factura Op."
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "EXW"
        dr("DESCRIPCION") = "EXW"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "GFOB"
        dr("DESCRIPCION") = "GFOB"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "FOB"
        dr("DESCRIPCION") = "FOB"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "FLETE"
        dr("DESCRIPCION") = "FLETE"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "SEGURO"
        dr("DESCRIPCION") = "SEGURO"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "CIF"
        dr("DESCRIPCION") = "CIF"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "ADVALOREM"
        dr("DESCRIPCION") = "ADVALOREM"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "IGV"
        dr("DESCRIPCION") = "IGV"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "IPM"
        dr("DESCRIPCION") = "IPM"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        'dr = dtColumna.NewRow
        'dr("CODIGO") = "OTSGAS"
        'dr("DESCRIPCION") = "Tasa Despacho"
        'dr("TIPO") = pTNumero
        'dr("NIVEL") = pNivelEmbarque
        'dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "COSVAR"
        dr("DESCRIPCION") = "Costos varios"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)



        dr = dtColumna.NewRow
        dr("CODIGO") = "TOTALDER"
        dr("DESCRIPCION") = "Total Derechos"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "ITTCAG"
        dr("DESCRIPCION") = "Comisión Agencias"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "ITTGOA"
        dr("DESCRIPCION") = "Gastos Operativos"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "ITTCEM"
        dr("DESCRIPCION") = "CARGO EMBARCADOR"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "ITTRAC"
        dr("DESCRIPCION") = "TRACCION"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "ESTADOEMB"
        dr("DESCRIPCION") = "Estado"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        Return dtColumna
    End Function

   
    Public Function ListaColumnasEmbarqueDetalle() As DataTable
        Dim dtColumna As New DataTable
        Dim dr As DataRow
        'CODIGO : Codigo de Columna
        'DESCRIPCION: Referido al Item
        'TIPO : Tipo de DATO : Texto ,Fecha ,Numerico
        ' NIVEL : NIVEL DE DATOS EMBARQUE(EM) ,NIVEL ITEM (IT)
        dtColumna.Columns.Add("CODIGO")
        dtColumna.Columns.Add("DESCRIPCION")
        dtColumna.Columns.Add("TIPO")
        dtColumna.Columns.Add("NIVEL")

        Dim NPOI_SC As New HelpClass_NPOI_SC

        Dim pTTexto As String = NPOI_SC.keyDatoTexto
        Dim pTNumero As String = NPOI_SC.keyDatoNumero
        Dim pTFecha As String = NPOI_SC.keyDatoFecha
        Dim pNivelEmbarque As String = _kNivelEmbarque
        Dim pNivelEmbarqueItem As String = _kNivelEmbarqueItem

        dr = dtColumna.NewRow
        dr("CODIGO") = "NORSCI"
        dr("DESCRIPCION") = "Embarque"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "FORSCI"
        dr("DESCRIPCION") = "Fecha"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)



        dr = dtColumna.NewRow
        dr("CODIGO") = "NREFCLEMB"
        dr("DESCRIPCION") = "Referencia Cliente"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "REFDO1"
        dr("DESCRIPCION") = "Referencia Documento"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)



        dr = dtColumna.NewRow
        dr("CODIGO") = "TDITES"
        dr("DESCRIPCION") = "Descripción Mercadería"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "TPRVCL"
        dr("DESCRIPCION") = "Proveedor"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "PNNMOS"
        dr("DESCRIPCION") = "Orden Servicio"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "DOCEMB"
        dr("DESCRIPCION") = "B/L AWB"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)




        dr = dtColumna.NewRow
        dr("CODIGO") = "CTRMAL"
        dr("DESCRIPCION") = "Terminal de Almacenamiento"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "REGIMEN"
        dr("DESCRIPCION") = "REGIMEN"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "DESPACHO"
        dr("DESCRIPCION") = "DESPACHO"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "CAGNCR"
        dr("DESCRIPCION") = "Agente de Carga"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "NUMSEG"
        dr("DESCRIPCION") = "N° Seguro"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "CMEDTRAGEN"
        dr("DESCRIPCION") = "Transporte Agencia"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "CMEDTR"
        dr("DESCRIPCION") = "Medio Transporte"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "NUMDUA"
        dr("DESCRIPCION") = "Número Dua"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "CANAL"
        dr("DESCRIPCION") = "CANAL"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "TNIMCIN"
        dr("DESCRIPCION") = "Línea Naviera"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "CVPRCN"
        dr("DESCRIPCION") = "Nave/Cia. Transporte"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "CPRTOE"
        dr("DESCRIPCION") = "Origen"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "CPRTOA"
        dr("DESCRIPCION") = "Destino"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "QVOLMR"
        dr("DESCRIPCION") = "M3"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "QPSOAR"
        dr("DESCRIPCION") = "Kg. Brutos"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "NDIALB"
        dr("DESCRIPCION") = "Días Libres"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "NDIASE"
        dr("DESCRIPCION") = "Días SobreEstadía"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)



        dr = dtColumna.NewRow
        dr("CODIGO") = "FACCOP"
        dr("DESCRIPCION") = "F. Factura Copia"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "FACORG"
        dr("DESCRIPCION") = "F. Factura Original"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "DEMCOP"
        dr("DESCRIPCION") = "F. BL/AWB Copia"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "DEMORG"
        dr("DESCRIPCION") = "F. BL/AWB Original"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "TRACOP"
        dr("DESCRIPCION") = "F. Traducción Copia"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "TRAORG"
        dr("DESCRIPCION") = "F. Traducción Original"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "VOLCOP"
        dr("DESCRIPCION") = "F. Volante Copia"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "VOLORG"
        dr("DESCRIPCION") = "F. Volante Original"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "SEGCOP"
        dr("DESCRIPCION") = "F. Seguro Copia"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "SEGORG"
        dr("DESCRIPCION") = "F. Seguro Original"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)



        dr = dtColumna.NewRow
        dr("CODIGO") = "CORCOP"
        dr("DESCRIPCION") = "F. Certificado Copia"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "CORORG"
        dr("DESCRIPCION") = "F. Certificado Original"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "OTRORG"
        dr("DESCRIPCION") = "F. Otro Original"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "CKCLPV"
        dr("DESCRIPCION") = "F. Entrega por el Proveedor"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "RECPOP"
        dr("DESCRIPCION") = "F. Entrega OC"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "CKIGAT"
        dr("DESCRIPCION") = "F. Llegada Material"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "CKCROK"
        dr("DESCRIPCION") = "F. Carga OK"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "CKCRDS"
        dr("DESCRIPCION") = "F. Carga Discrepancia"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "CKRECO"
        dr("DESCRIPCION") = "F. Recojo Material"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "CKAECL"
        dr("DESCRIPCION") = "F. Aprobacion Doc."
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "CHKEPR"
        dr("DESCRIPCION") = "F. Entrega Origen"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)



        dr = dtColumna.NewRow
        dr("CODIGO") = "CHKETA"
        dr("DESCRIPCION") = "ETA"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "CHKETD"
        dr("DESCRIPCION") = "ETD"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "FAPRAR"
        dr("DESCRIPCION") = "Fecha Embarque"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "FAPREV"
        dr("DESCRIPCION") = "Fecha Llegada"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "FCDCOR"
        dr("DESCRIPCION") = "F. Volante"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "FECNUM"
        dr("DESCRIPCION") = "F. Numeración"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "FECPGD"
        dr("DESCRIPCION") = "F. Pago Derechos"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "FECLEV"
        dr("DESCRIPCION") = "F. Levante"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "FECDCP"
        dr("DESCRIPCION") = "F. Doc. completos"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "FECALM"
        dr("DESCRIPCION") = "F. Entrega Almacén"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "FECPRO"
        dr("DESCRIPCION") = "F. Proforma"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "FECPGP"
        dr("DESCRIPCION") = "F. Pago Proforma"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "FECFAC"
        dr("DESCRIPCION") = "F. Entrega Factura"
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "DIFPDA"
        dr("DESCRIPCION") = "F. Pag. Der vs Entrega Almacén"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "DIFDCN"
        dr("DESCRIPCION") = "F. Doc. Comp. vs F. Num"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "DIFRCCK"
        dr("DESCRIPCION") = "F. Entrega OC vs Entrega x Proveedor"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "DIFERM"
        dr("DESCRIPCION") = "F. Embarque vs Llegada"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "DIFEME"
        dr("DESCRIPCION") = "F. Llegada vs Levante"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "DIFEEP"
        dr("DESCRIPCION") = "F. Levante vs Almacén"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "DXF6F5"
        dr("DESCRIPCION") = "F. Num. vs Pag. Der."
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "DXF4F3"
        dr("DESCRIPCION") = "F. Doc. Completos vs ETA"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "DXF8F4"
        dr("DESCRIPCION") = "F. Entrega Almacén VS Doc. Completos"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "NOPRCN"
        dr("DESCRIPCION") = "Nro Operación"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "NDCFCC"
        dr("DESCRIPCION") = "Nro Factura Op."
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "FDCFCC"
        dr("DESCRIPCION") = "Fecha Factura Op."
        dr("TIPO") = pTFecha
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)



        dr = dtColumna.NewRow
        dr("CODIGO") = "ESTADOEMB"
        dr("DESCRIPCION") = "Estado"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarque
        dtColumna.Rows.Add(dr)


        '////////////////////////////////////////////////////////////////////
        'DATOS OC
        '****************
        dr = dtColumna.NewRow
        dr("CODIGO") = "NORCML"
        dr("DESCRIPCION") = "Orden Compra"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarqueItem
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "NRITEM"
        dr("DESCRIPCION") = "Nro Item"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarqueItem
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "SBITOC"
        dr("DESCRIPCION") = "N° SubItem"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarqueItem
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "TDITES_ITEM"
        dr("DESCRIPCION") = "Descripción Item"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarqueItem
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "TCITCL"
        dr("DESCRIPCION") = "Código Item"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarqueItem
        dtColumna.Rows.Add(dr)

        'TCITCL  ,CPTDAR

        dr = dtColumna.NewRow
        dr("CODIGO") = "QRLCSC"
        dr("DESCRIPCION") = "Cant. Embarcada"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarqueItem
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "CPTDAR"
        dr("DESCRIPCION") = "Partida"
        dr("TIPO") = pTTexto
        dr("NIVEL") = pNivelEmbarqueItem
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "IVUNIT"
        dr("DESCRIPCION") = "Valor Unitario"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarqueItem
        dtColumna.Rows.Add(dr)

        '******************
        '////////////////////////////////////////////////////////////////////

        dr = dtColumna.NewRow
        dr("CODIGO") = "EXW"
        dr("DESCRIPCION") = "EXW"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarqueItem
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "GFOB"
        dr("DESCRIPCION") = "GFOB"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarqueItem
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "FOB"
        dr("DESCRIPCION") = "FOB"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarqueItem
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "FLETE"
        dr("DESCRIPCION") = "FLETE"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarqueItem
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "SEGURO"
        dr("DESCRIPCION") = "SEGURO"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarqueItem
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "CIF"
        dr("DESCRIPCION") = "CIF"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarqueItem
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "ADVALOREM"
        dr("DESCRIPCION") = "ADVALOREM"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarqueItem
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "IGV"
        dr("DESCRIPCION") = "IGV"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarqueItem
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "IPM"
        dr("DESCRIPCION") = "IPM"
        dr("TIPO") = pTNumero      
        dr("NIVEL") = pNivelEmbarqueItem
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "OTSGAS"
        dr("DESCRIPCION") = "Tasa Despacho"
        dr("TIPO") = pTNumero      
        dr("NIVEL") = pNivelEmbarqueItem
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "TOTALDER"
        dr("DESCRIPCION") = "Total Derechos"
        dr("TIPO") = pTNumero       
        dr("NIVEL") = pNivelEmbarqueItem
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "ITTCAG"
        dr("DESCRIPCION") = "Comisión Agencias"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarqueItem
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "ITTGOA"
        dr("DESCRIPCION") = "Gastos Operativos"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarqueItem
        dtColumna.Rows.Add(dr)


        dr = dtColumna.NewRow
        dr("CODIGO") = "ITTRAC"
        dr("DESCRIPCION") = "TRACCION"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarqueItem
        dtColumna.Rows.Add(dr)

        dr = dtColumna.NewRow
        dr("CODIGO") = "ITTCEM"
        dr("DESCRIPCION") = "CARGO EMBARCADOR"
        dr("TIPO") = pTNumero
        dr("NIVEL") = pNivelEmbarqueItem
        dtColumna.Rows.Add(dr)

        Return dtColumna
    End Function


    Public Function Listar_Resumen_Mensual_Embarque(ByVal obeResumenMensual As beResumenMensual) As DataSet
        Dim odaclsRepColumnaEmbarque As New Datos.clsRepColumnaEmbarque
        Return odaclsRepColumnaEmbarque.Listar_Resumen_Mensual_Embarque(obeResumenMensual)
    End Function
End Class
