Public Class Form1
    Dim file As New OpenFileDialog()

    Private Sub Btn_agregar_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim palabra, definicion As String
        palabra = TextBox1.Text
        definicion = TextBox2.Text
        Dim def As New ListViewItem(palabra + ": " + definicion + ". " + file.FileName)
        def.SubItems.AddRange(New String() {palabra, definicion, file.FileName})
        Lista.ListView1.Items.Add(def)
        Elimina.ListView1.Items.Add(def.Clone)
        Lista.Show()
        Me.Hide()
    End Sub

    Private Sub menuClick(sender As Object, e As EventArgs) Handles Button2.Click
        Menu.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_imagen_Click(sender As Object, e As EventArgs) Handles btn_imagen.Click

        file.Filter = "Archivo JPG|*.jpg"

        If file.ShowDialog() = DialogResult.OK Then
            pbx_imagen.Image = Image.FromFile(file.FileName)
            'MsgBox(file.FileName)
        End If
    End Sub

End Class