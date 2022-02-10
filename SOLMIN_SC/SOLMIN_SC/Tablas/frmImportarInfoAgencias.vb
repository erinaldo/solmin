

Public Class frmImportarInfoAgencias

    Private Sub btnProceso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProceso.Click

        Me.CheckForIllegalCrossThreadCalls = False
        Me.barra.Visible = True

        Dim objProceso As New Threading.Thread(AddressOf Me.Procesar)
        objProceso.Start()


    End Sub
 
    Private Sub frmImportarInfoAgencias_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        For i As Int32 = Today.Year To (Today.Year - 1) Step -1
            Me.ddlAnio.Items.Add(i)
        Next

        Me.ddlAnio.SelectedIndex = 0
        Me.WindowState = FormWindowState.Normal
        Me.StartPosition = FormStartPosition.CenterScreen

    End Sub

    Public Sub Procesar()
        Dim objMigracionAgencias As New SOLMIN_SC.Negocio.MigracionAgencias_BLL

        Dim Tabla As New DataTable
        Dim I As Integer = 0
        Dim J As Integer = 0
        Dim OrdServicio As String = ""
        Dim Cod_Aduana As String
        Dim Zona As String
        Dim Factura As String
        Dim Serie As String
        Dim Coditem As String
        Dim Ord_Compra As String
        Dim Item_Oc As String


        Tabla = objMigracionAgencias.Listar_Ordenes_Proceso_Migracion(Me.ddlAnio.Text)

        Me.barra.Maximum = Tabla.Rows.Count + 1

        For I = 0 To Tabla.Rows.Count - 1

            'OrdServicio = Tabla.Rows(I).Item(0).ToString
            Cod_Aduana = Tabla.Rows(I).Item(1).ToString
            Serie = Tabla.Rows(I).Item(2).ToString
            Factura = Tabla.Rows(I).Item(3).ToString
            Coditem = Tabla.Rows(I).Item(4).ToString
            Ord_Compra = Tabla.Rows(I).Item(5).ToString
            Item_Oc = Tabla.Rows(I).Item(6).ToString

            Dim objParamZona As New List(Of String)
            objParamZona.Add(Cod_Aduana)
            Zona = objMigracionAgencias.Obtener_Zona_Migracion(objParamZona)

            If Item_Oc = "" Then
                Item_Oc = 0
            End If
            If Serie = "" Then
                Serie = 0
            End If

            If Coditem = "" Then
                Coditem = 0
            End If

            For J = 0 To 1

                If J = 0 Then
                    OrdServicio = Tabla.Rows(I).Item(0).ToString
                ElseIf J = 1 Then
                    OrdServicio = Tabla.Rows(I).Item(7).ToString
                End If


                Dim objTablaOS As New DataTable
                Dim objParamOS As New List(Of String)
                objParamOS.Add(OrdServicio)
                objParamOS.Add(Zona)

                objTablaOS = objMigracionAgencias.Obtener_Orden_Servicio(objParamOS)

                If objTablaOS.Rows.Count > 0 Then

                    Dim objParamActualizar As New List(Of String)
                    objParamActualizar.Add(Ord_Compra)
                    objParamActualizar.Add(Item_Oc)
                    objParamActualizar.Add(Factura)
                    objParamActualizar.Add(Coditem)
                    objParamActualizar.Add(OrdServicio)
                    objParamActualizar.Add(Zona)
                    objParamActualizar.Add(Serie)


                    objMigracionAgencias.Actualizar_Informacion_Agencias(objParamActualizar)
                    Exit For

                End If

                'If rec.HasRows Then
                '    Dim sql As String = " UPDATE DC@RNSLIB.DUAA1 " & _
                '                         "  SET NMRODC = '" & Ord_Compra & _
                '                         "',    NMITOC =  " & Item_Oc & _
                '                         ",     NMRFCT = '" & Factura & _
                '                         "',    NMITFC = " & Coditem & _
                '                         " WHERE NORDSR=" & OrdServicio & _
                '                         "   AND CCMPN = 'FZ' " & _
                '                         "   AND CDVSN = 'A' " & _
                '                         "   AND CPLNDV = 1 " & _
                '                         "   AND CZNFCC = " & Zona & _
                '                         "   AND nserie=" & Serie



                '    Exit For

                'End If
            Next J


            Me.barra.Value = Me.barra.Value + 1
            Me.EventViewer.Text = Me.EventViewer.Text & Chr(13) & "Orden Agencia " & OrdServicio

        Next I
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
