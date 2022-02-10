'Imports Ransa.NEGO
Imports System.Windows.Forms

Module modGlobal
    Public Function mfblnBuscar_TipoAlmacen(ByRef strCodigo As String, ByRef strDescripcion As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        Dim oClsGeneral_BL As New ClsGeneral_BL
        'dtEntidad = clsGeneral.fdtBuscar_TipoAlmacen(strMensajeError, strDescripcion)
        dtEntidad = oClsGeneral_BL.fdtBuscar_TipoAlmacen(strMensajeError, strDescripcion)
        If strMensajeError <> "" Then
            strCodigo = ""
            strDescripcion = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDescripcion = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                Else
                    Using frmBuscar = New frmBusqueda
                        With frmBuscar
                            .Titulo = dtEntidad.TableName
                            .CampoDefault = 1
                            .DataSource = dtEntidad
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                strCodigo = ("" & .SelectedRow(0)).ToString.Trim
                                strDescripcion = ("" & .SelectedRow(1)).ToString.Trim
                            Else
                                strCodigo = ""
                                strDescripcion = ""
                            End If
                            .Dispose()
                        End With
                    End Using
                End If
                blnResultado = True
            Else
                strCodigo = ""
                strDescripcion = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

    Public Function mfblnBuscar_Almacen(ByVal strTipoAlmacen As String, ByRef strCodigo As String, ByRef strDescripcion As String) As Boolean
        Dim dtEntidad As DataTable = Nothing
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = False
        Dim oClsGeneral_BL As New ClsGeneral_BL
        'dtEntidad = clsGeneral.fdtBuscar_Almacen(strMensajeError, strTipoAlmacen, strDescripcion)
        dtEntidad = oClsGeneral_BL.fdtBuscar_Almacen(strMensajeError, strTipoAlmacen, strDescripcion)
        If strMensajeError <> "" Then
            strCodigo = ""
            strDescripcion = ""
            blnResultado = False
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If dtEntidad.Rows.Count > 0 Then
                If dtEntidad.Rows.Count = 1 Then
                    strCodigo = ("" & dtEntidad.Rows(0)(0)).ToString.Trim
                    strDescripcion = ("" & dtEntidad.Rows(0)(1)).ToString.Trim
                Else
                    Using frmBuscar = New frmBusqueda
                        With frmBuscar
                            .Titulo = dtEntidad.TableName
                            .CampoDefault = 1
                            .DataSource = dtEntidad
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                strCodigo = ("" & .SelectedRow(0)).ToString.Trim
                                strDescripcion = ("" & .SelectedRow(1)).ToString.Trim
                            Else
                                strCodigo = ""
                                strDescripcion = ""
                            End If
                            .Dispose()
                        End With
                    End Using
                End If
                blnResultado = True
            Else
                strCodigo = ""
                strDescripcion = ""
                blnResultado = False
                MessageBox.Show("No existe Información.", "Buscar:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        dtEntidad.Dispose()
        dtEntidad = Nothing
        Return blnResultado
    End Function

End Module
