Imports SOLMIN_SC.Negocio
Imports SOLMIN_SC.Entidad
Public Class frmVisorForol
    Private objForol As beForol
    Private strTipo As String
    Private psTipoFormato As String
    Sub New(ByVal pobjForol As beForol, ByVal pstrTipo As String, ByVal pTipoFormato As String)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        objForol = pobjForol
        strTipo = pstrTipo
        psTipoFormato = pTipoFormato
    End Sub
    Private Sub MostrarFormatoMenor2010()
        Dim objCrep As New rptForol
        CType(objCrep.ReportDefinition.ReportObjects("txtOS"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.OS
        CType(objCrep.ReportDefinition.ReportObjects("txtCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Cliente
        CType(objCrep.ReportDefinition.ReportObjects("txtMercaderia"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Mercaderia
        CType(objCrep.ReportDefinition.ReportObjects("txtProveedor"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Proveedor
        CType(objCrep.ReportDefinition.ReportObjects("txtRefCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.RefCliente
        CType(objCrep.ReportDefinition.ReportObjects("txtBeneficio"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Beneficio
        CType(objCrep.ReportDefinition.ReportObjects("txtTercero"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Tercero
        CType(objCrep.ReportDefinition.ReportObjects("txtDireccion"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Direccion
        CType(objCrep.ReportDefinition.ReportObjects("txtHorario"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Horario
        CType(objCrep.ReportDefinition.ReportObjects("txtContacto"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Contacto
        CType(objCrep.ReportDefinition.ReportObjects("txtObservacion1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Observacion1
        CType(objCrep.ReportDefinition.ReportObjects("txtObservacion2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Observacion2
        Select Case objForol.Medio
            Case "AEREO"
                CType(objCrep.ReportDefinition.ReportObjects("txtMedio1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "MARITIMO"
                CType(objCrep.ReportDefinition.ReportObjects("txtMedio2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "POSTAL"
                CType(objCrep.ReportDefinition.ReportObjects("txtMedio3"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "TERRESTRE"
                CType(objCrep.ReportDefinition.ReportObjects("txtMedio4"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
        End Select
        Select Case objForol.Regimen
            Case "IMPORTACION DEFINITIVA"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "EXPORTACION DEFINITIVA"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "IMPORTACION TEMPORAL"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg3"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "EXPORTACION TEMPORAL"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg4"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "ADMISION TEMPORAL"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg5"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "SIMPLIFICADA"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg6"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "DEPOSITO"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg7"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "REIMPORTACION"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg8"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "REEXPORTACION"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg9"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "TRANSBORDO"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg10"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "REEMBARQUE"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg11"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "TRANSITO"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg12"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
        End Select
        Select Case objForol.Despacho
            Case "NORMAL"
                CType(objCrep.ReportDefinition.ReportObjects("txtDesp1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "URGENTE"
                CType(objCrep.ReportDefinition.ReportObjects("txtDesp2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "ANTICIPADO"
                CType(objCrep.ReportDefinition.ReportObjects("txtDesp3"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "SOCORRO"
                CType(objCrep.ReportDefinition.ReportObjects("txtDesp4"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
        End Select
        Select Case objForol.Transporte
            Case "PROPIO"
                CType(objCrep.ReportDefinition.ReportObjects("txtTrans1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "AGENCIAS"
                CType(objCrep.ReportDefinition.ReportObjects("txtTrans2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "TERCEROS"
                CType(objCrep.ReportDefinition.ReportObjects("txtTrans3"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
        End Select
        'Marcar_Documentos()
        Dim intCont As Integer
        With CType(objForol.Documentos, DataTable)
            For intCont = 0 To .Rows.Count - 1
                If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Or .Rows(intCont).Item("FLGCOP").ToString.Trim = "X" Then
                    Select Case .Rows(intCont).Item("NCODRG").ToString.Trim
                        Case "1"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtFacOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtFacCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtFacNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "2"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtDocOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtDocCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtDocNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "3"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtPolOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtPolCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtPolNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "4"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtVolOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtVolCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtVolNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "5"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtTraOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtTraCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtTraNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "6"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtDecOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtDecCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtDecNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "7"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtCerOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtCerCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtCerNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "8"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtPacOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtPacCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtPacNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "9"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtSofOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtSofCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtSofNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "10"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtPreOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtPreCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtPreNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "11"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtCarOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtCarCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtCarNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "12"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtOrdOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtOrdCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtOrdNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "13"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtHomOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtHomCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtHomNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "14"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtBooOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtBooCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtBooNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "15"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtProOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtProCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtProNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "16"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtDuaBOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtDuaBCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtDuaBNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "17"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtDuaDOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtDuaDCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtDuaDNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                    End Select
                End If
            Next intCont
        End With

        VisorForol.ReportSource = objCrep
    End Sub

    Private Sub MostrarFormato2010()
        Dim objCrep2010 As New rptForol2010
        CType(objCrep2010.ReportDefinition.ReportObjects("txtOS"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.OS
        CType(objCrep2010.ReportDefinition.ReportObjects("txtCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Cliente
        CType(objCrep2010.ReportDefinition.ReportObjects("txtMercaderia"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Mercaderia
        CType(objCrep2010.ReportDefinition.ReportObjects("txtProveedor"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Proveedor
        CType(objCrep2010.ReportDefinition.ReportObjects("txtRefCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.RefCliente
        CType(objCrep2010.ReportDefinition.ReportObjects("txtBeneficio"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Beneficio
        CType(objCrep2010.ReportDefinition.ReportObjects("txtTercero"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Tercero
        CType(objCrep2010.ReportDefinition.ReportObjects("txtDireccion"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Direccion
        CType(objCrep2010.ReportDefinition.ReportObjects("txtHorario"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Horario
        CType(objCrep2010.ReportDefinition.ReportObjects("txtContacto"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Contacto
        CType(objCrep2010.ReportDefinition.ReportObjects("txtObservacion1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Observacion1
        CType(objCrep2010.ReportDefinition.ReportObjects("txtObservacion2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Observacion2
        Select Case objForol.Medio
            Case "AEREO"
                CType(objCrep2010.ReportDefinition.ReportObjects("txtMedio1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "MARITIMO"
                CType(objCrep2010.ReportDefinition.ReportObjects("txtMedio2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "POSTAL"
                CType(objCrep2010.ReportDefinition.ReportObjects("txtMedio3"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "TERRESTRE"
                CType(objCrep2010.ReportDefinition.ReportObjects("txtMedio4"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
        End Select
        Select Case objForol.Regimen
            Case "IMPORTACION PARA EL CONSUMO"
                CType(objCrep2010.ReportDefinition.ReportObjects("txtReg1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "EXPORTACION DEFINITIVA"
                CType(objCrep2010.ReportDefinition.ReportObjects("txtReg2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "ADMISION TEMPORAL PARA REEXPORTACION"
                CType(objCrep2010.ReportDefinition.ReportObjects("txtReg3"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "ADMISION TEMPORAL PARA PERFECCIONAMIENTO"
                CType(objCrep2010.ReportDefinition.ReportObjects("txtReg4"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "EXPORTACION TEMPORAL PARA REIMPORTACION"
                CType(objCrep2010.ReportDefinition.ReportObjects("txtReg5"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "EXPORTACION TEMPORAL PARA PERFECCIONAMIENTO"
                CType(objCrep2010.ReportDefinition.ReportObjects("txtReg6"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "DEPOSITO"
                CType(objCrep2010.ReportDefinition.ReportObjects("txtReg7"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "REIMPORTACION EN EL MISMO ESTADO"
                CType(objCrep2010.ReportDefinition.ReportObjects("txtReg8"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "TRANSBORDO"
                CType(objCrep2010.ReportDefinition.ReportObjects("txtReg9"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "REEMBARQUE"
                CType(objCrep2010.ReportDefinition.ReportObjects("txtReg10"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "TRANSITO"
                CType(objCrep2010.ReportDefinition.ReportObjects("txtReg11"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
        End Select
        Select Case objForol.Despacho
            Case "NORMAL"
                CType(objCrep2010.ReportDefinition.ReportObjects("txtDesp1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "URGENTE"
                CType(objCrep2010.ReportDefinition.ReportObjects("txtDesp2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "ANTICIPADO"
                CType(objCrep2010.ReportDefinition.ReportObjects("txtDesp3"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "SOCORRO"
                CType(objCrep2010.ReportDefinition.ReportObjects("txtDesp4"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
        End Select
        Select Case objForol.Transporte
            Case "PROPIO"
                CType(objCrep2010.ReportDefinition.ReportObjects("txtTrans1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "AGENCIAS"
                CType(objCrep2010.ReportDefinition.ReportObjects("txtTrans2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "TERCEROS"
                CType(objCrep2010.ReportDefinition.ReportObjects("txtTrans3"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
        End Select
        'Marcar_Documentos()
        Dim intCont As Integer
        With CType(objForol.Documentos, DataTable)
            For intCont = 0 To .Rows.Count - 1
                If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Or .Rows(intCont).Item("FLGCOP").ToString.Trim = "X" Then
                    Select Case .Rows(intCont).Item("NCODRG").ToString.Trim
                        Case "1"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtFacOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtFacCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2010.ReportDefinition.ReportObjects("txtFacNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "2"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtDocOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtDocCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2010.ReportDefinition.ReportObjects("txtDocNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "3"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtPolOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtPolCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2010.ReportDefinition.ReportObjects("txtPolNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "4"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtVolOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtVolCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2010.ReportDefinition.ReportObjects("txtVolNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "5"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtTraOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtTraCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2010.ReportDefinition.ReportObjects("txtTraNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "6"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtDecOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtDecCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2010.ReportDefinition.ReportObjects("txtDecNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "7"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtCerOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtCerCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2010.ReportDefinition.ReportObjects("txtCerNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "8"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtPacOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtPacCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2010.ReportDefinition.ReportObjects("txtPacNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "9"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtSofOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtSofCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2010.ReportDefinition.ReportObjects("txtSofNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "10"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtPreOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtPreCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2010.ReportDefinition.ReportObjects("txtPreNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "11"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtCarOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtCarCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2010.ReportDefinition.ReportObjects("txtCarNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "12"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtOrdOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtOrdCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2010.ReportDefinition.ReportObjects("txtOrdNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "13"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtHomOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtHomCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2010.ReportDefinition.ReportObjects("txtHomNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "14"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtBooOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtBooCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2010.ReportDefinition.ReportObjects("txtBooNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "15"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtProOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtProCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2010.ReportDefinition.ReportObjects("txtProNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "16"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtDuaBOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtDuaBCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2010.ReportDefinition.ReportObjects("txtDuaBNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "17"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtDuaDOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2010.ReportDefinition.ReportObjects("txtDuaDCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2010.ReportDefinition.ReportObjects("txtDuaDNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                    End Select
                End If
            Next intCont
        End With

        VisorForol.ReportSource = objCrep2010
    End Sub

    Private Sub MostrarFormato2011()
        Dim objCrep2011 As New rptForol2011
        CType(objCrep2011.ReportDefinition.ReportObjects("txtOS"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.OS
        CType(objCrep2011.ReportDefinition.ReportObjects("txtCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Cliente
        CType(objCrep2011.ReportDefinition.ReportObjects("txtMercaderia"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Mercaderia
        CType(objCrep2011.ReportDefinition.ReportObjects("txtProveedor"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Proveedor
        CType(objCrep2011.ReportDefinition.ReportObjects("txtRefCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.RefCliente
        CType(objCrep2011.ReportDefinition.ReportObjects("txtBeneficio"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Beneficio
        CType(objCrep2011.ReportDefinition.ReportObjects("txtTercero"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Tercero
        CType(objCrep2011.ReportDefinition.ReportObjects("txtDireccion"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Direccion
        CType(objCrep2011.ReportDefinition.ReportObjects("txtHorario"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Horario
        CType(objCrep2011.ReportDefinition.ReportObjects("txtContacto"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Contacto
        CType(objCrep2011.ReportDefinition.ReportObjects("txtObservacion1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Observacion1
        CType(objCrep2011.ReportDefinition.ReportObjects("txtObservacion2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Observacion2
        Select Case objForol.Medio
            Case "AEREO"
                CType(objCrep2011.ReportDefinition.ReportObjects("txtMedio1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "MARITIMO"
                CType(objCrep2011.ReportDefinition.ReportObjects("txtMedio2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "POSTAL"
                CType(objCrep2011.ReportDefinition.ReportObjects("txtMedio3"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "TERRESTRE"
                CType(objCrep2011.ReportDefinition.ReportObjects("txtMedio4"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
        End Select
        Select Case objForol.Regimen
            Case "IMPORTACION PARA EL CONSUMO"
                CType(objCrep2011.ReportDefinition.ReportObjects("txtReg1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "EXPORTACION DEFINITIVA"
                CType(objCrep2011.ReportDefinition.ReportObjects("txtReg2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "ADMISION TEMPORAL PARA REEXPORTACION"
                CType(objCrep2011.ReportDefinition.ReportObjects("txtReg3"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "ADMISION TEMPORAL PARA PERFECCIONAMIENTO"
                CType(objCrep2011.ReportDefinition.ReportObjects("txtReg4"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "EXPORTACION TEMPORAL PARA REIMPORTACION"
                CType(objCrep2011.ReportDefinition.ReportObjects("txtReg5"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "EXPORTACION TEMPORAL PARA PERFECCIONAMIENTO"
                CType(objCrep2011.ReportDefinition.ReportObjects("txtReg6"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "DEPOSITO ADUANERO"
                CType(objCrep2011.ReportDefinition.ReportObjects("txtReg7"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "REIMPORTACION EN EL MISMO ESTADO"
                CType(objCrep2011.ReportDefinition.ReportObjects("txtReg8"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "TRANSBORDO"
                CType(objCrep2011.ReportDefinition.ReportObjects("txtReg9"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "REEMBARQUE"
                CType(objCrep2011.ReportDefinition.ReportObjects("txtReg10"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "TRANSITO ADUANERO"
                CType(objCrep2011.ReportDefinition.ReportObjects("txtReg11"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
        End Select
        Select Case objForol.Despacho
            Case "NORMAL"
                CType(objCrep2011.ReportDefinition.ReportObjects("txtDesp1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "URGENTE"
                CType(objCrep2011.ReportDefinition.ReportObjects("txtDesp2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "ANTICIPADO"
                CType(objCrep2011.ReportDefinition.ReportObjects("txtDesp3"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "SOCORRO"
                CType(objCrep2011.ReportDefinition.ReportObjects("txtDesp4"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
        End Select
        Select Case objForol.Transporte
            Case "PROPIO"
                CType(objCrep2011.ReportDefinition.ReportObjects("txtTrans1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "AGENCIAS"
                CType(objCrep2011.ReportDefinition.ReportObjects("txtTrans2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "TERCEROS"
                CType(objCrep2011.ReportDefinition.ReportObjects("txtTrans3"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
        End Select
        'Marcar_Documentos()

        Dim intCont As Integer
        With CType(objForol.Documentos, DataTable)
            For intCont = 0 To .Rows.Count - 1
                If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Or .Rows(intCont).Item("FLGCOP").ToString.Trim = "X" Then
                    Select Case .Rows(intCont).Item("NCODRG").ToString.Trim
                        Case "1"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtFacOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtFacCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2011.ReportDefinition.ReportObjects("txtFacNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "2"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtDocOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtDocCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2011.ReportDefinition.ReportObjects("txtDocNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "3"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtPolOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtPolCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2011.ReportDefinition.ReportObjects("txtPolNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "4"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtVolOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtVolCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2011.ReportDefinition.ReportObjects("txtVolNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "5"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtTraOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtTraCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2011.ReportDefinition.ReportObjects("txtTraNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "6"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtDecOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtDecCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2011.ReportDefinition.ReportObjects("txtDecNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "7"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtCerOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtCerCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2011.ReportDefinition.ReportObjects("txtCerNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "8"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtPacOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtPacCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2011.ReportDefinition.ReportObjects("txtPacNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "9"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtSofOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtSofCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2011.ReportDefinition.ReportObjects("txtSofNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "10"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtPreOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtPreCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2011.ReportDefinition.ReportObjects("txtPreNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "11"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtCarOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtCarCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2011.ReportDefinition.ReportObjects("txtCarNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "12"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtOrdOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtOrdCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2011.ReportDefinition.ReportObjects("txtOrdNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "13"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtHomOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtHomCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2011.ReportDefinition.ReportObjects("txtHomNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "14"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtBooOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtBooCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2011.ReportDefinition.ReportObjects("txtBooNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "15"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtProOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtProCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2011.ReportDefinition.ReportObjects("txtProNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "16"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtDuaBOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtDuaBCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2011.ReportDefinition.ReportObjects("txtDuaBNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "17"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtDuaDOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep2011.ReportDefinition.ReportObjects("txtDuaDCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep2011.ReportDefinition.ReportObjects("txtDuaDNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                    End Select
                End If
            Next intCont
        End With
        VisorForol.ReportSource = objCrep2011
    End Sub

    Private Sub MostrarFormato2012()
        Dim objCrep As New rptForol2012
        CType(objCrep.ReportDefinition.ReportObjects("txtOS"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.OS
        CType(objCrep.ReportDefinition.ReportObjects("txtCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Cliente
        CType(objCrep.ReportDefinition.ReportObjects("txtMercaderia"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Mercaderia
        CType(objCrep.ReportDefinition.ReportObjects("txtProveedor"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Proveedor
        CType(objCrep.ReportDefinition.ReportObjects("txtRefCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.RefCliente
        CType(objCrep.ReportDefinition.ReportObjects("txtBeneficio"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Beneficio
        CType(objCrep.ReportDefinition.ReportObjects("txtTercero"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Tercero
        CType(objCrep.ReportDefinition.ReportObjects("txtDireccion"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Direccion
        CType(objCrep.ReportDefinition.ReportObjects("txtHorario"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Horario
        CType(objCrep.ReportDefinition.ReportObjects("txtContacto"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Contacto
        CType(objCrep.ReportDefinition.ReportObjects("txtObservacion1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Observacion1
        CType(objCrep.ReportDefinition.ReportObjects("txtObservacion2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Observacion2
        Select Case objForol.Medio
            Case "AEREO"
                CType(objCrep.ReportDefinition.ReportObjects("txtMedio1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "MARITIMO"
                CType(objCrep.ReportDefinition.ReportObjects("txtMedio2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "POSTAL"
                CType(objCrep.ReportDefinition.ReportObjects("txtMedio3"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "TERRESTRE"
                CType(objCrep.ReportDefinition.ReportObjects("txtMedio4"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
        End Select
        Select Case objForol.Regimen
            Case "IMPORTACION PARA EL CONSUMO"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "EXPORTACION DEFINITIVA"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "ADMISION TEMPORAL PARA REEXPORTACION"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg3"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "ADMISION TEMPORAL PARA PERFECCIONAMIENTO"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg4"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "EXPORTACION TEMPORAL PARA REIMPORTACION"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg5"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "EXPORTACION TEMPORAL PARA PERFECCIONAMIENTO"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg6"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "DEPOSITO ADUANERO"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg7"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "REIMPORTACION EN EL MISMO ESTADO"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg8"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "TRANSBORDO"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg9"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "REEMBARQUE"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg10"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "TRANSITO ADUANERO"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg11"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
        End Select
        Select Case objForol.Despacho
            Case "NORMAL"
                CType(objCrep.ReportDefinition.ReportObjects("txtDesp1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "URGENTE"
                CType(objCrep.ReportDefinition.ReportObjects("txtDesp2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "ANTICIPADO"
                CType(objCrep.ReportDefinition.ReportObjects("txtDesp3"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "SOCORRO"
                CType(objCrep.ReportDefinition.ReportObjects("txtDesp4"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
        End Select
        Select Case objForol.Transporte
            Case "PROPIO"
                CType(objCrep.ReportDefinition.ReportObjects("txtTrans1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "AGENCIAS"
                CType(objCrep.ReportDefinition.ReportObjects("txtTrans2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "TERCEROS"
                CType(objCrep.ReportDefinition.ReportObjects("txtTrans3"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
        End Select
     
        Dim intCont As Integer
        With CType(objForol.Documentos, DataTable)
            For intCont = 0 To .Rows.Count - 1
                If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Or .Rows(intCont).Item("FLGCOP").ToString.Trim = "X" Then
                    Select Case .Rows(intCont).Item("NCODRG").ToString.Trim
                        Case "1"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtFacOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtFacCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtFacNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "2"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtDocOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtDocCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtDocNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "3"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtPolOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtPolCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtPolNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "4"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtVolOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtVolCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtVolNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "5"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtTraOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtTraCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtTraNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "6"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtDecOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtDecCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtDecNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "7"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtCerOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtCerCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtCerNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "8"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtPacOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtPacCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtPacNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "9"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtSofOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtSofCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtSofNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "10"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtPreOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtPreCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtPreNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "11"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtCarOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtCarCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtCarNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "12"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtOrdOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtOrdCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtOrdNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "13"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtHomOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtHomCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtHomNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "14"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtBooOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtBooCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtBooNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "15"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtProOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtProCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtProNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "16"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtDuaBOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtDuaBCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtDuaBNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "17"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtDuaDOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtDuaDCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtDuaDNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                    End Select
                End If
            Next intCont
        End With
        VisorForol.ReportSource = objCrep
    End Sub

    Private Sub MostrarFormato2012_1()
        Dim objCrep As New rptForol2012_1
        CType(objCrep.ReportDefinition.ReportObjects("txtOS"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.OS
        CType(objCrep.ReportDefinition.ReportObjects("txtCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Cliente
        CType(objCrep.ReportDefinition.ReportObjects("txtMercaderia"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Mercaderia
        CType(objCrep.ReportDefinition.ReportObjects("txtProveedor"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Proveedor
        CType(objCrep.ReportDefinition.ReportObjects("txtRefCliente"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.RefCliente
        CType(objCrep.ReportDefinition.ReportObjects("txtBeneficio"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Beneficio
        CType(objCrep.ReportDefinition.ReportObjects("txtTercero"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Tercero
        CType(objCrep.ReportDefinition.ReportObjects("txtDireccion"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Direccion
        CType(objCrep.ReportDefinition.ReportObjects("txtHorario"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Horario
        CType(objCrep.ReportDefinition.ReportObjects("txtContacto"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Contacto
        CType(objCrep.ReportDefinition.ReportObjects("txtObservacion1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Observacion1
        CType(objCrep.ReportDefinition.ReportObjects("txtObservacion2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objForol.Observacion2
        Select Case objForol.Medio
            Case "AEREO"
                CType(objCrep.ReportDefinition.ReportObjects("txtMedio1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "MARITIMO"
                CType(objCrep.ReportDefinition.ReportObjects("txtMedio2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "POSTAL"
                CType(objCrep.ReportDefinition.ReportObjects("txtMedio3"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "TERRESTRE"
                CType(objCrep.ReportDefinition.ReportObjects("txtMedio4"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
        End Select
        Select Case objForol.Regimen
            Case "IMPORTACION PARA EL CONSUMO"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "EXPORTACION DEFINITIVA"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "ADMISION TEMPORAL PARA REEXPORTACION"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg3"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "ADMISION TEMPORAL PARA PERFECCIONAMIENTO"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg4"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "EXPORTACION TEMPORAL PARA REIMPORTACION"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg5"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "EXPORTACION TEMPORAL PARA PERFECCIONAMIENTO"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg6"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "DEPOSITO ADUANERO"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg7"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "REIMPORTACION EN EL MISMO ESTADO"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg8"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "TRANSBORDO"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg9"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "REEMBARQUE"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg10"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "TRANSITO ADUANERO"
                CType(objCrep.ReportDefinition.ReportObjects("txtReg11"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
        End Select
        Select Case objForol.Despacho
            Case "NORMAL"
                CType(objCrep.ReportDefinition.ReportObjects("txtDesp1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "URGENTE"
                CType(objCrep.ReportDefinition.ReportObjects("txtDesp2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "ANTICIPADO"
                CType(objCrep.ReportDefinition.ReportObjects("txtDesp3"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "SOCORRO"
                CType(objCrep.ReportDefinition.ReportObjects("txtDesp4"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
        End Select
        Select Case objForol.Transporte
            Case "PROPIO"
                CType(objCrep.ReportDefinition.ReportObjects("txtTrans1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "AGENCIAS"
                CType(objCrep.ReportDefinition.ReportObjects("txtTrans2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
            Case "TERCEROS"
                CType(objCrep.ReportDefinition.ReportObjects("txtTrans3"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
        End Select

        Dim intCont As Integer
        With CType(objForol.Documentos, DataTable)
            For intCont = 0 To .Rows.Count - 1
                If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Or .Rows(intCont).Item("FLGCOP").ToString.Trim = "X" Then
                    Select Case .Rows(intCont).Item("NCODRG").ToString.Trim
                        Case "1"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtFacOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtFacCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtFacNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "2"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtDocOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtDocCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtDocNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "3"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtPolOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtPolCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtPolNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "4"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtVolOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtVolCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtVolNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "5"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtTraOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtTraCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtTraNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "6"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtDecOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtDecCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtDecNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "7"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtCerOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtCerCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtCerNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "8"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtPacOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtPacCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtPacNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "9"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtSofOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtSofCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtSofNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "10"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtPreOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtPreCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtPreNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "11"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtCarOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtCarCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtCarNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "12"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtOrdOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtOrdCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtOrdNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "13"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtHomOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtHomCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtHomNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "14"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtBooOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtBooCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtBooNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "15"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtProOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtProCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtProNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "16"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtDuaBOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtDuaBCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtDuaBNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                        Case "17"
                            If .Rows(intCont).Item("FLGORG").ToString.Trim = "X" Then
                                CType(objCrep.ReportDefinition.ReportObjects("txtDuaDOrg"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            Else
                                CType(objCrep.ReportDefinition.ReportObjects("txtDuaDCop"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "X"
                            End If
                            CType(objCrep.ReportDefinition.ReportObjects("txtDuaDNum"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "(" & .Rows(intCont).Item("NUMDOC").ToString.Trim & ")"
                    End Select
                End If
            Next intCont
        End With
        VisorForol.ReportSource = objCrep
    End Sub

    Private Sub frmVisorForol_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            Select Case psTipoFormato

                Case "FOROL"
                    Dim AnioTipoForol As Int32 = 0
                    AnioTipoForol = Convert.ToInt32(strTipo)
                    If (AnioTipoForol >= 20111001) Then
                        MostrarFormato2012()
                    ElseIf (AnioTipoForol >= 20110101 AndAlso AnioTipoForol < 20111001) Then
                        MostrarFormato2011()
                    ElseIf AnioTipoForol >= 20100101 AndAlso AnioTipoForol < 20110101 Then
                        MostrarFormato2010()
                    ElseIf AnioTipoForol < 20100101 Then
                        MostrarFormatoMenor2010()
                    End If

                Case "FMIN"

                    MostrarFormato2012_1()

            End Select


            
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub
End Class
