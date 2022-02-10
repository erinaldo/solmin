Imports SOLMIN_SC.Negocio
Imports System.Web
Imports SOLMIN_SC.Entidad
Imports Ransa.Utilitario

Public Class frmResumenPreEmbarqueEmbarque

#Region "Declaracion de variables"
    Private oCliente As clsCliente
    Private DsRepoteEmbarque As DataSet
#End Region

#Region "Enventos de control"

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try

            Dim dtResultado As New DataTable

            Dim dsNew As New DataSet
            Dim objCrep As New ResumenPreEmbarqueEmbarque
            Dim oclsRepGenerales As New clsRepGenerales


            If cmbCliente.pCodigo = 0 Then
                HelpClass.MsgBox("Debe seleccionar un Cliente")
                Exit Sub
            End If

            Muestra_Imagen()
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

            dtResultado = FiltrarData()


            dtResultado.TableName = "DtTable1"
            dsNew.Tables.Add(dtResultado.Copy)


           

            objCrep.SetDataSource(dsNew)

            objCrep.SetParameterValue(0, cmbCliente.pRazonSocial)
            objCrep.SetParameterValue(1, HelpUtil.UserName)


            VisorRep.ReportSource = objCrep
            Ocultar_Imagen()
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Ocultar_Imagen()
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try



    End Sub

    Private Sub frmResumenPreEmbarqueEmbarque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'oCliente = New clsCliente
        'oCliente.Lista = DirectCast(HttpRuntime.Cache.Get("Cliente"), clsCliente).Lista.Copy

        Me.cmbCliente.pAccesoPorUsuario = True
        Me.cmbCliente.pRequerido = True
        Me.cmbCliente.pUsuario = HelpUtil.UserName
    End Sub

    Private Sub ButtonSpecHeaderGroup3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

            If cmbCliente.pCodigo = 0 Then
                HelpClass.MsgBox("Debe seleccionar un Cliente")
                Exit Sub
            End If
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            ExportarExcel(FiltrarData())
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

#End Region

#Region "Procedimientos y funciones"

    Private Sub FormatDt(ByVal dt As DataTable)

        dt.Columns.Add("tcitcl", System.Type.GetType("System.String"))
        dt.Columns.Add("tdites", System.Type.GetType("System.String"))
        dt.Columns.Add("qAtendida", System.Type.GetType("System.Decimal"))
        dt.Columns.Add("Valor", System.Type.GetType("System.Decimal"))
        dt.Columns.Add("NMONOC", System.Type.GetType("System.String"))

        dt.Columns.Add("FechaCrea102", System.Type.GetType("System.String"))


        dt.Columns.Add("TPAGME", System.Type.GetType("System.String"))
        dt.Columns.Add("TTINTC", System.Type.GetType("System.String"))
        dt.Columns.Add("TNOMCOM", System.Type.GetType("System.String"))

        dt.Columns.Add("FechaCrea103", System.Type.GetType("System.String"))


        dt.Columns.Add("FechaCrea107", System.Type.GetType("System.String"))


        dt.Columns.Add("FechaCrea108", System.Type.GetType("System.String"))


        dt.Columns.Add("FechaCrea124", System.Type.GetType("System.String"))


    End Sub

    Private Sub Muestra_Imagen()
        Application.DoEvents()
        Me.pbxBuscar.Enabled = True
        Me.pbxBuscar.Update()
        Application.DoEvents()
        Me.pbxBuscar.Visible = True
        Application.DoEvents()
    End Sub

    Private Sub Ocultar_Imagen()
        Me.pbxBuscar.Visible = False
        Me.pbxBuscar.Enabled = False
    End Sub

    Private Sub ExportarExcel(ByVal dtListado As DataTable)
        Dim dtExcel As New DataTable
        Dim objDsExcel As New DataSet
        Dim nEstado As String = String.Empty
        dtExcel = dtListado.Copy



        Dim strlTitulo As New List(Of String)
        dtExcel.Columns("tcitcl").ColumnName = "Cod Item"
        dtExcel.Columns("tdites").ColumnName = "Descripción"
        dtExcel.Columns("qAtendida").ColumnName = "Cantidad"
        dtExcel.Columns("Valor").ColumnName = "Importe"
        dtExcel.Columns("NMONOC").ColumnName = "Moneda"

        dtExcel.Columns("FechaCrea102").ColumnName = "FECHA DE ENTREGA POR EL PROVEEDOR"


        dtExcel.Columns("TPAGME").ColumnName = "Tipo Compra"
        dtExcel.Columns("TTINTC").ColumnName = "Condición"
        dtExcel.Columns("TNOMCOM").ColumnName = "Comprador"



        dtExcel.Columns("FechaCrea103").ColumnName = "FECHA DE RECOJO POR AGENTE EMBARCADOR"


        dtExcel.Columns("FechaCrea107").ColumnName = "FECHA DE EMBARQUE"


        dtExcel.Columns("FechaCrea108").ColumnName = "FECHA DE LLEGADA"


        dtExcel.Columns("FechaCrea124").ColumnName = "ENTREGA EN ALM. DE CLIENTE"



        objDsExcel.Tables.Add(dtExcel)

        strlTitulo.Add("Cliente :\n" & IIf(Me.cmbCliente.pCodigo = 0, "TODOS", Me.cmbCliente.pCodigo & " - " & Me.cmbCliente.pRazonSocial))
        strlTitulo.Add("\n")

        Ransa.Utilitario.HelpClass.ExportExcelConTitulos(objDsExcel, strlTitulo)
    End Sub

    Private Function FiltrarData() As DataTable
        DsRepoteEmbarque = New DataSet
        Dim DtReporteEmbarque As New DataTable
        Dim dtListado As New DataTable
        Dim dtPreEmbarque As New DataTable
        Dim dtEmbarque As New DataTable
        Dim dsNew As New DataSet
        Dim objCrep As New ResumenPreEmbarqueEmbarque
        Dim oclsRepGenerales As New clsRepGenerales
        Dim intCont As Integer = 0



        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        DsRepoteEmbarque = oclsRepGenerales.Lista_Datos_PreEmbarque_Embarque(Convert.ToDecimal(cmbCliente.pCodigo))


        dtListado = DsRepoteEmbarque.Tables(0)
        dtPreEmbarque = DsRepoteEmbarque.Tables(1)
        dtEmbarque = DsRepoteEmbarque.Tables(2)



        For Each dr As DataRow In dtListado.Rows

            For Each drPre As DataRow In dtPreEmbarque.Rows

                If drPre("NRPEMB") = dr("NRPEMB") Then

                    For x As Integer = 0 To dtListado.Columns.Count - 1
                        If dtListado.Columns(x).ColumnName = "FECHACREA" & drPre("NESTDO").ToString Then
                            dtListado.Rows(intCont).Item("FechaCrea" & drPre("NESTDO").ToString) = drPre("DFECREA").ToString
                            dtListado.Rows(intCont).Item("FechaEst" & drPre("NESTDO").ToString) = drPre("DFECEST").ToString
                        End If
                    Next
                End If


            Next

            dtListado.AcceptChanges()
            intCont = intCont + 1

        Next

        intCont = 0
        For Each dr As DataRow In dtListado.Rows

            For Each drEmb As DataRow In dtEmbarque.Rows

                If drEmb("NORSCI") = dr("NORSCI") Then

                    For x As Integer = 0 To dtListado.Columns.Count - 1
                        If dtListado.Columns(x).ColumnName = "FECHACREA" & drEmb("NESTDO").ToString Then
                            dtListado.Rows(intCont).Item("FechaCrea" & drEmb("NESTDO").ToString) = drEmb("DFECREA").ToString
                            dtListado.Rows(intCont).Item("FechaEst" & drEmb("NESTDO").ToString) = drEmb("DFECEST").ToString
                        End If
                    Next
                End If


            Next

            dtListado.AcceptChanges()
            intCont = intCont + 1

        Next


        Dim dtResultado As New DataTable

        Dim bRegistrado As Boolean = False
        Dim drResultado As DataRow
        Dim nCantidad As Decimal = 0
        Dim nImporte As Decimal = 0

        FormatDt(dtResultado)

        intCont = -1
        For Each dr As DataRow In dtListado.Rows

            bRegistrado = False

           
            For Each drRegistrado As DataRow In dtResultado.Select("tcitcl = '" & dr("tcitcl") & "' and tdites='" & dr("tdites") & "' and NMONOC ='" & dr("NMONOC") & _
                         "' and TPAGME ='" & dr("TPAGME") & "' and TTINTC ='" & dr("TTINTC") & "' and TNOMCOM ='" & dr("TNOMCOM") & "' and FechaCrea103='" & dr("FechaCrea103") & _
                         "' and FechaCrea107 ='" & dr("FechaCrea107") & "'  and FechaCrea108='" & dr("FechaCrea108") & _
                         "' and FechaCrea124 ='" & dr("FechaCrea124") & "'")



                bRegistrado = True
            Next

            If bRegistrado Then

                For Each drRegistrado As DataRow In dtListado.Select("tcitcl = '" & dr("tcitcl") & "' and tdites='" & dr("tdites") & "' and NMONOC ='" & dr("NMONOC") & _
                         "' and TPAGME ='" & dr("TPAGME") & "' and TTINTC ='" & dr("TTINTC") & "' and TNOMCOM ='" & dr("TNOMCOM") & "' and FechaCrea103='" & dr("FechaCrea103") & _
                         "' and FechaCrea107 ='" & dr("FechaCrea107") & "'  and FechaCrea108='" & dr("FechaCrea108") & _
                         "' and FechaCrea124 ='" & dr("FechaCrea124") & "'")

                    nCantidad = nCantidad + Convert.ToDecimal(drRegistrado("qAtendida").ToString)
                    nImporte = nImporte + Convert.ToDecimal(drRegistrado("Valor").ToString)
                Next


                dtResultado.Rows(intCont).Item("qAtendida") = nCantidad
                dtResultado.Rows(intCont).Item("Valor") = nImporte
                nCantidad = 0
                nImporte = 0

                Continue For
            Else

                nCantidad = 0
                nImporte = 0
            End If




            drResultado = dtResultado.NewRow()
            drResultado("tcitcl") = dr("tcitcl")
            drResultado("tdites") = dr("tdites")
            drResultado("qAtendida") = dr("qAtendida")
            drResultado("Valor") = dr("Valor")
            drResultado("NMONOC") = dr("NMONOC")
            drResultado("FechaCrea102") = dr("FechaCrea102")

            drResultado("TPAGME") = dr("TPAGME")
            drResultado("TTINTC") = dr("TTINTC")
            drResultado("TNOMCOM") = dr("TNOMCOM")

            drResultado("FechaCrea103") = dr("FechaCrea103")



            drResultado("FechaCrea107") = dr("FechaCrea107")


            drResultado("FechaCrea108") = dr("FechaCrea108")


            drResultado("FechaCrea124") = dr("FechaCrea124")


            dtResultado.Rows.Add(drResultado)
            intCont = intCont + 1
        Next


        Return dtResultado
    End Function

#End Region








    Private Sub ButtonSpecHeaderGroup2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSpecHeaderGroup2.Click
        Try

            If cmbCliente.pCodigo = 0 Then
                HelpClass.MsgBox("Debe seleccionar un Cliente")
                Exit Sub
            End If
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            ExportarExcel(FiltrarData())
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
End Class
