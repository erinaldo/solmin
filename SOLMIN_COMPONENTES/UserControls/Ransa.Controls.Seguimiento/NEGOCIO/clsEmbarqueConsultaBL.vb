
Imports System.Text

Public Class clsEmbarqueConsultaBL

  Dim odt As New DataTable

  'Pestaña Ordenes Embarcadas
  Public Function Lista_Detalle_OC_Embarque_Ajuste_Consulta(ByVal CCLNT As Decimal, ByVal NORSCI As Decimal) As DataTable
    Dim oDAL As New clsEmbarqueConsultaDAL
    Dim ds As New DataSet
    Dim odtOC As New DataTable
    Dim odtCostos As New DataTable
    Dim NORCML As String = ""
    Dim NRITOC As Decimal = 0
    Dim NRPEMB As Decimal = 0
    Dim CODVAR As String = ""
    Dim SB_EXPRESION As New StringBuilder
    Dim MONTO_DOLAR As Decimal = 0
    Dim oColumnasCostos As New Hashtable
    ' Nombre Columna | Codigo Costo
    oColumnasCostos.Add("TOTFOB", "FOB")
    oColumnasCostos.Add("TOTFLT", "FLETE")
    oColumnasCostos.Add("TOTSEG", "SEGURO")
    oColumnasCostos.Add("TOTCIF", "CIF")
    oColumnasCostos.Add("TOTADV", "ADVALO")
    oColumnasCostos.Add("TOTIGV", "IGV")
    oColumnasCostos.Add("TOTIPM", "IPM")
    oColumnasCostos.Add("TOTOGS", "OTSGAS")
    oColumnasCostos.Add("TOLDER", "CALCULO_TOLDER") 'CALCULO IGV + IPM +ADVALO + OTSGAS
    oColumnasCostos.Add("ITTCAG", "ITTCAG")
    oColumnasCostos.Add("ITTGOA", "ITTGOA")
    oColumnasCostos.Add("ITTRAC", "ITTRAC")
    oColumnasCostos.Add("HANDLI", "HANDLI")
    oColumnasCostos.Add("DESALM", "DESALM")
    oColumnasCostos.Add("ITTAAG", "ITTAAG")
    oColumnasCostos.Add("ITTEXW", "ITTEXW")
    oColumnasCostos.Add("GFOB", "GFOB")
    oColumnasCostos.Add("ITTGAM", "ITTGAM")
    oColumnasCostos.Add("ITTTRM", "ITTTRM")
    oColumnasCostos.Add("ITTCEM", "ITTCEM")
    oColumnasCostos.Add("ITTCRS", "ITTCRS")
    oColumnasCostos.Add("ALMLOC", "ALMLOC")
    oColumnasCostos.Add("CARDES", "CARDES")
    oColumnasCostos.Add("ITTTRA", "ITTTRA")
    oColumnasCostos.Add("CARDEC", "CARDEC")
    oColumnasCostos.Add("INLAD", "INLAD")
    oColumnasCostos.Add("MONIMP", "GASADU")

    'ds.Tables(0).TableName = "DET_OC"
    'ds.Tables(1).TableName = "COSTOS"
    ds = oDAL.Lista_Detalle_OC_Embarque_Ajuste_Consulta(CCLNT, NORSCI)
    odtOC = ds.Tables("DET_OC")
    odtCostos = ds.Tables("COSTOS")
    For Each item As DictionaryEntry In oColumnasCostos
      odtOC.Columns.Add(item.Key, GetType(System.Decimal))
    Next
    Dim dr() As DataRow
    Dim TOT_DERECHOS As Decimal = 0
    For FILA As Integer = 0 To odtOC.Rows.Count - 1
      NORCML = odtOC.Rows(FILA)("NORCML").ToString.Trim
      NRITOC = odtOC.Rows(FILA)("NRITEM")
      NRPEMB = odtOC.Rows(FILA)("NRPEMB")
      For Each item As DictionaryEntry In oColumnasCostos
        CODVAR = item.Value
        SB_EXPRESION.Length = 0
        MONTO_DOLAR = 0
        Select Case CODVAR
          Case "CALCULO_TOLDER"
            SB_EXPRESION.Append("CCLNT=" & CCLNT & " AND NORSCI=" & NORSCI & " AND ")
            SB_EXPRESION.Append(" NORCML='" & NORCML & "'" & " AND NRITEM=" & NRITOC & " AND ")
            SB_EXPRESION.Append("NRPEMB=" & NRPEMB & " AND CODVAR IN ('IGV','IPM','ADVALO','OTSGAS')")
          Case Else
            SB_EXPRESION.Append("CCLNT=" & CCLNT & " AND NORSCI=" & NORSCI & " AND ")
            SB_EXPRESION.Append(" NORCML='" & NORCML & "'" & " AND NRITEM=" & NRITOC & " AND ")
            SB_EXPRESION.Append("NRPEMB=" & NRPEMB & " AND CODVAR='" & CODVAR & "'")
        End Select
        dr = odtCostos.Select(SB_EXPRESION.ToString)
        If dr.Length > 0 Then
          For Each drItem As DataRow In dr
            MONTO_DOLAR = MONTO_DOLAR + drItem("IVLDOL")
          Next
        Else
          MONTO_DOLAR = 0
        End If
        odtOC.Rows(FILA)(item.Key) = MONTO_DOLAR
      Next

    Next
    Return odtOC
  End Function

  ' Pestaña Datos de Embarque
  Public Function Lista_DatosEmbarqueConsulta(ByVal CCLNT As Decimal, ByVal NORSCI As Decimal) As Hashtable
    Dim oDAL As New clsEmbarqueConsultaDAL
    Return oDAL.Lista_DatosEmbarqueConsulta(CCLNT, NORSCI)
  End Function

  'Pestaña Apertura O/S
  Public Function Lista_DatosAperturaOS(ByVal CCLNT As Decimal, ByVal NORSCI As Decimal) As Hashtable
    Dim oDAL As New clsEmbarqueConsultaDAL
    Return oDAL.Lista_AperturaOS_Consulta(CCLNT, NORSCI)
  End Function

  'Tab Documentos Adjuntos
  Public Function Lista_DatosDocAdjuntos(ByVal CCLNT As Decimal, ByVal NORSCI As Decimal) As DataTable
    Dim oDAL As New clsEmbarqueConsultaDAL
    Dim dt As DataTable
    dt = oDAL.Lista_DocAbjunto(CCLNT, NORSCI)
    Return dt
  End Function

    'Public Function Lista_Doc_Embarque_Consulta(ByVal PNCCLNT As Double, ByVal PNNORSCI As Double) As List(Of beDocCargaInternacionalConsulta)
    '  Dim oDAL As New clsEmbarqueConsultaDAL
    '  Return oDAL.Lista_Doc_Embarque_Consulta(PNCCLNT, PNNORSCI)
    'End Function

  'Tab de Costos de Seguimiento: 4 tab's

    'Public Function Lista_Costos_Totales_Embarque_Consulta(ByVal pdblEmbarque As Double) As DataTable
    '  Dim oDAL As New clsEmbarqueConsultaDAL
    '  Return oDAL.Lista_Costos_Totales_Embarque_Consulta(pdblEmbarque)
    'End Function

    'Public Function Lista_Documentos_Costo_X_Costo_Total_Embarque_Consulta(ByVal pdblEmbarque As Double, ByVal pstrCodVariable As String) As DataTable
    '  Dim oDAL As New clsEmbarqueConsultaDAL
    '  Return oDAL.Lista_Documentos_Costo_X_Costo_Total_Embarque_Consulta(pdblEmbarque, pstrCodVariable)
    'End Function

    'Public Function Lista_Documentos_Costo_Embarque_Consulta(ByVal pdblEmbarque As Double) As DataTable
    '  Dim oDAL As New clsEmbarqueConsultaDAL
    '  Return oDAL.Lista_Documentos_Costo_Embarque_Consulta(pdblEmbarque)
    'End Function

  ' Tab Observaciones : carga internacional y embarque aduanas
  Public Function Lista_Observacion_Embarque_Consulta(ByVal PNNORSCI As Decimal) As DataSet
    Dim oDAL As New clsEmbarqueConsultaDAL
    Return oDAL.Lista_Observacion_Embarque_Consulta(PNNORSCI)
  End Function

    'Public Function Lista_Observacion_CI_X_Embarque_Consulta(ByVal CCLNT As Decimal, ByVal pdblEmbarque As Double) As DataTable
    '  Dim oDAL As New clsEmbarqueConsultaDAL
    '  Return oDAL.Lista_Observacion_CI_X_Embarque_Consulta(CCLNT, pdblEmbarque)
    'End Function

  'Tab Servicios
  Public Function Lista_Servicios_X_Operacion_Consulta(ByVal oServicioSIL As beServicioFacturarConsulta) As DataTable
    Dim oDAL As New clsEmbarqueConsultaDAL
    Dim odtServicio As New DataTable
    odtServicio = oDAL.Lista_Servicios_X_Operacion_Consulta(oServicioSIL)
    Return odtServicio
  End Function

  'Tab Checkpoint

  Public Function Lista_CheckPoint_X_Embarque_Consulta(ByVal obeParamCheckPoint As beCheckpointConsulta) As DataTable
    Dim oDAL As New clsEmbarqueConsultaDAL
    Dim dt As New DataTable
    dt = oDAL.Lista_CheckPoint_X_Embarque_Consulta(obeParamCheckPoint)
    Return dt
  End Function

  'Tab Costos de seguimiento

  Public Function Lista_Costos_Seguimiento(ByVal PNNORSCI As Double) As DataSet
    Dim oDAL As New clsEmbarqueConsultaDAL
    Return oDAL.Lista_Costos_Seguimiento(PNNORSCI)
  End Function

  'Crear tabpages
  Public Function Lista_Para_Crear_TabPages()
    Dim oDAL As New clsEmbarqueConsultaDAL
    Return oDAL.Lista_Variable("COSTO_TOTAL")
  End Function

  'Descripcion de los costos de embarque
  Public Function Lista_Concepto_Costo_Embarque(ByVal pstrDescripcion As String) As DataTable
    Dim oDAL As New clsEmbarqueConsultaDAL
    Return oDAL.Lista_Concepto_Costo_Embarque(pstrDescripcion)
  End Function

End Class
