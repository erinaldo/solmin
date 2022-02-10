Public Class Dimensiones_BLL

    Dim ObjDimensiones_DAL As Dimensiones_DAL

    Function fListar_Dimensiones(ByVal Obj As Dimensiones) As List(Of Dimensiones)
        ObjDimensiones_DAL = New Dimensiones_DAL

        Return ObjDimensiones_DAL.fListar_Dimensiones(Obj)

    End Function

    Sub fInsertar_Dimensiones(ByVal Obj As Dimensiones)
        ObjDimensiones_DAL = New Dimensiones_DAL

        ObjDimensiones_DAL.Insertar_Dimensiones(Obj)

    End Sub

    Sub fModificar_Dimensiones(ByVal Obj As Dimensiones)
        ObjDimensiones_DAL = New Dimensiones_DAL

        ObjDimensiones_DAL.Modificar_Dimensiones(Obj)

    End Sub

    Sub fEliminar_Dimensiones(ByVal Obj As Dimensiones)
        ObjDimensiones_DAL = New Dimensiones_DAL

        ObjDimensiones_DAL.Eliminar_Dimensiones(Obj)

    End Sub


End Class
