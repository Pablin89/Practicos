Public Class Formulario1

    Private Sub Formulario1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TNombre.Focus()
    End Sub
    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        TResultado.Text = TNombre.Text + " " + TApellido.Text
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        End
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        TResultado.Clear()
    End Sub

    Private Sub Formulario1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Control + Keys.S Then
            BSalir.Show()
        End If
    End Sub
End Class
