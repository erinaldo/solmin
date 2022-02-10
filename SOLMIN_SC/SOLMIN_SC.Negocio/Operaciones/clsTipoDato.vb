Imports SOLMIN_SC.Entidad
Public Class clsTipoDato
    Private oTipoDato As Datos.clsTipoDato
    Private oDt As DataTable

    Sub New()
        oTipoDato = New Datos.clsTipoDato
    End Sub

    Property Lista()
        Get
            Return oDt
        End Get
        Set(ByVal value)
            oDt = value
        End Set
    End Property
#Region "Tipo Datos Filtrados para Almacen Destino"
    Public Sub Crea_DetalleTipoDato(ByVal objTipoDato As Entidad.beTipoDato)
        oDt = oTipoDato.Lista_TipoDatoDetalle(objTipoDato)
    End Sub
    Public Function RetornaDiasAlmacen(ByVal sTipoDetalle As String, ByVal nCliente As Integer) As Double
        Dim oDtSelect As DataTable = oDt.Copy
        Dim oDr As DataRow()
        oDr = oDtSelect.Select("TDSCRG = '" & sTipoDetalle & "' AND CCLNT1 = " & nCliente)
        If oDr.Length = 0 Then
            oDr = oDtSelect.Select("TDSCRG = '" & sTipoDetalle & "' AND CCLNT1 = " & 0)
        End If
        If oDr.Length = 1 Then
            Return oDr(0).Item("QCNTN")
        Else
            Return 0
        End If
    End Function
#End Region

    Public Function Lista_TipoDato(ByVal objTipoDato As Entidad.beTipoDato) As DataTable
        Return oTipoDato.Lista_TipoDato(objTipoDato)
    End Function

    Public Function Lista_TipoDatoDetalle(ByVal objTipoDato As Entidad.beTipoDato) As DataTable
        Return oTipoDato.Lista_TipoDatoDetalle(objTipoDato)
    End Function
    Public Sub Actualiza_TipoDato(ByVal objTipoDato As Entidad.beTipoDato)
        oTipoDato.Actualiza_TipoDato(objTipoDato)
    End Sub
    Public Sub Actualiza_TipoDatoDetalle(ByVal objTipoDato As Entidad.beTipoDato)
        oTipoDato.Actualiza_TipoDatoDetalle(objTipoDato)
    End Sub
    Public Function Eliminar_TipoDato(ByVal objTipoDato As Entidad.beTipoDato) As Integer
        Return oTipoDato.Eliminar_TipoDato(objTipoDato)
    End Function
    Public Function Eliminar_TipoDatoDetalle(ByVal objTipoDato As Entidad.beTipoDato) As Integer
        Return oTipoDato.Eliminar_TipoDatoDetalle(objTipoDato)
    End Function
    Public Sub Inserta_TipoDato(ByVal objTipoDato As Entidad.beTipoDato)
        oTipoDato.Inserta_TipoDato(objTipoDato)
    End Sub
    Public Sub Inserta_TipoDatoDetalle(ByVal objTipoDato As Entidad.beTipoDato)
        oTipoDato.Inserta_TipoDatoDetalle(objTipoDato)
    End Sub

    '*****************************************
    Public Enum TIPO_DATO
        'REGIMEN = 3
        DOCUMENTO_ADJUNTO = 5
        TRASNPORTE_AGENCIA = 7
        TIPO_DESPACHO = 8
        TIPO_CARGA = 9
        ALMACEN_DESTINO_LOCAL = 28
    End Enum

#Region "PERSISTENCIA"
    Private NTPODT_FIND As Decimal = 0
    Private Function TipoDato_x_NTPODT(ByVal oBE_TipoDato As beTipoDato) As Boolean
        Return oBE_TipoDato.PNNTPODT = NTPODT_FIND
    End Function
    Public Function Lista_TipoDato_x_NTPODT(ByVal oListTipoDato As List(Of beTipoDato), ByVal NTPODT As TIPO_DATO) As List(Of beTipoDato)
        NTPODT_FIND = NTPODT
        Dim oInfoFindListBE_TipoDato As List(Of beTipoDato)
        oInfoFindListBE_TipoDato = oListTipoDato.FindAll(AddressOf TipoDato_x_NTPODT)
        Return oInfoFindListBE_TipoDato
    End Function
#End Region
    Public Function Lista_TipoDato_Todos() As List(Of beTipoDato)
        Dim oListoBE_TipoDato As New List(Of beTipoDato)
        Dim oDAL_TipoDato As New Datos.clsTipoDato
        oListoBE_TipoDato = oDAL_TipoDato.Lista_TipoDato_Todos()
        Return oListoBE_TipoDato
    End Function
    Public Function Lista_TipoDato_X_Codigo(ByVal pBE_TipoDato As beTipoDato) As List(Of beTipoDato)
        Dim oListoBE_TipoDato As New List(Of beTipoDato)
        Dim oDAL_TipoDato As New Datos.clsTipoDato
        oListoBE_TipoDato = oDAL_TipoDato.Lista_TipoDato_X_Codigo(pBE_TipoDato)
        Return oListoBE_TipoDato
    End Function
    '**********************************************
End Class


