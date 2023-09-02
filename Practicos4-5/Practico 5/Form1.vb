Imports System.ComponentModel

Public Class Form1
    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        Dim opcion As MsgBoxResult
        Dim sexo As String
        Dim filas As Integer = DataGridView1.Rows.Count

        If String.IsNullOrEmpty(TNombre.Text) Or String.IsNullOrEmpty(TApellido.Text) Or Not IsNumeric(TSaldo.Text) Or
            Not Rbmujer.Checked And Not Rbhombre.Checked Or Me.PictureBox1.Image Is Nothing Then
            MsgBox("Debe completar todos los campos", vbOK + vbDefaultButton2 + vbCritical, "Agregar")

        Else
            opcion = MsgBox("Los datos serán guardados", vbYesNo + vbDefaultButton2 + vbInformation, "Agregar")
            If (opcion = DialogResult.Yes) And Rbhombre.Checked Then
                sexo = Rbhombre.Text
                DataGridView1.Rows.Add(TApellido.Text, TNombre.Text, DateTimePicker1.Text, sexo, TSaldo.Text, "Eliminar", PictureBox1.Image)
                For i = 0 To filas
                    If TSaldo.Text <= 50 Then
                        DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Red
                    Else
                        DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.White
                    End If
                Next
                TNombre.Clear()
                TApellido.Clear()
                TSaldo.Clear()
                PictureBox1.Image = My.Resources.avatar
                Rbhombre.Checked = Nothing
                DateTimePicker1.Text = Nothing

            ElseIf (opcion = DialogResult.Yes) And Rbmujer.Checked Then
                sexo = Rbmujer.Text
                DataGridView1.Rows.Add(TApellido.Text, TNombre.Text, DateTimePicker1.Text, sexo, TSaldo.Text, "Eliminar", PictureBox1.Image)
                For i = 0 To filas
                    If TSaldo.Text <= 50 Then
                        DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Red
                    Else
                        DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.White
                    End If
                Next
                TNombre.Clear()
                TApellido.Clear()
                TSaldo.Clear()
                PictureBox1.Image = My.Resources.avatar
                Rbmujer.Checked = Nothing
                DateTimePicker1.Text = Nothing


            End If
        End If
    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        OpenFileDialog1.InitialDirectory = "D:"
        OpenFileDialog1.Filter = "Archivos imagenes|*.jpg |Archivos imagenes|*.png"
        OpenFileDialog1.ShowDialog()
        PictureBox1.BackgroundImage = Nothing
        PictureBox1.ImageLocation = OpenFileDialog1.FileName
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim col As Integer = DataGridView1.CurrentCell.ColumnIndex
        Dim opcion As MsgBoxResult

        If (col = 5) Then
            opcion = MsgBox("Esta seguro que desea eliminar?", vbYesNo + vbDefaultButton2 + vbCritical, "Eliminar")
            If (opcion = DialogResult.Yes) Then
                DataGridView1.Rows.Remove(DataGridView1.CurrentRow)

            End If
        End If
    End Sub

    Private Sub TNombre_TextChanged(sender As Object, e As EventArgs) Handles TNombre.TextChanged

    End Sub

    Private Sub TNombre_Validating(sender As Object, e As CancelEventArgs) Handles TNombre.Validating
        If Not String.IsNullOrWhiteSpace(TNombre.Text) Then
            Me.ErrorNombre.SetError(sender, "")
        Else
            Me.ErrorNombre.SetError(sender, "completar campo")
        End If
    End Sub

    Private Sub TApellido_TextChanged(sender As Object, e As EventArgs) Handles TApellido.TextChanged

    End Sub

    Private Sub TApellido_Validating(sender As Object, e As CancelEventArgs) Handles TApellido.Validating
        If Not String.IsNullOrWhiteSpace(TApellido.Text) Then
            Me.ErrorApellido.SetError(sender, "")
        Else
            Me.ErrorApellido.SetError(sender, "completar campo")
        End If
    End Sub

    Private Sub TSaldo_TextChanged(sender As Object, e As EventArgs) Handles TSaldo.TextChanged

    End Sub

    Private Sub TSaldo_Validating(sender As Object, e As CancelEventArgs) Handles TSaldo.Validating
        If IsNumeric(TSaldo.Text) Then
            Me.ErrorSaldo.SetError(sender, "")
        Else
            Me.ErrorSaldo.SetError(sender, "solo numerico")
        End If
    End Sub

End Class
