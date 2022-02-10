Imports NEGOCIO.Operaciones
Imports ENTIDADES.Operaciones


Public Class FrmAnulaLiquidacion

    Public Codigo As String
    Public Descrip As String
    Public compañia As String
 

    Private Sub FrmAnulaLiquidacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

      
            Dim obj As New NEGOCIO.Operaciones.TipoDatoGeneral_BLL
            Dim lista As New List(Of ENTIDADES.Operaciones.TipoDatoGeneral)
            lista = obj.Lista_Tipo_Dato_General(compañia, "STANLQ")
            KryptonComboBox1.DataSource = lista
            KryptonComboBox1.DisplayMember = "DESC_TIPO"
            KryptonComboBox1.ValueMember = "CODIGO_TIPO"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Sub KryptonButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    '    Codigo = KryptonComboBox1.ValueMember.ToString
    '    Descrip = KryptonComboBox1.DisplayMember.ToString
    '    Me.Close()



    'End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try

    
            Codigo = CType(KryptonComboBox1.ComboBox.SelectedItem, ENTIDADES.Operaciones.TipoDatoGeneral).CODIGO_TIPO
            Descrip = CType(KryptonComboBox1.ComboBox.SelectedItem, ENTIDADES.Operaciones.TipoDatoGeneral).DESC_TIPO
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click


        Me.Close()


    End Sub
End Class