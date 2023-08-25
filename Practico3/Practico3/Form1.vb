Public Class Form1
    Private Sub TDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDni.KeyPress

        If (Char.IsNumber(e.KeyChar)) Then

            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
            MessageBox.Show("Solo se permiten numeros", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

    End Sub


    Private Sub TApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellido.KeyPress

        If (Char.IsLetter(e.KeyChar)) Then

            e.Handled = False

        ElseIf (Char.IsSeparator(e.KeyChar)) Then

            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
            MessageBox.Show("Solo se permiten letras", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

    End Sub

    Private Sub TNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress

        If (Char.IsLetter(e.KeyChar)) Then

            e.Handled = False

        ElseIf (Char.IsSeparator(e.KeyChar)) Then

            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
            MessageBox.Show("Solo se permiten letras", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

    End Sub


    Private Sub BGuardar_Click(ByVal sender As Object, e As EventArgs) Handles BGuardar.Click

        Dim ask As MsgBoxResult

        If ((TApellido.Text <> "") And (TNombre.Text <> "") And (TDni.Text <> "") And (TTelefono.Text <> "")) Then

            Lmodificar.Text() = TNombre.Text() + " " + TApellido.Text()

            ask = MsgBox("Seguro desea ingresar un nuevo cliente?", MsgBoxStyle.YesNo, "Confirmar inserción")

            If ask = MsgBoxResult.Yes Then
                MsgBox("Nuevo cliente insertado", MsgBoxStyle.OkOnly, "Cliente insertado")

            Else
                MsgBox("No se insertó un nuevo cliente", MsgBoxStyle.OkOnly, "Cliente insertado")

            End If


        Else

            MsgBox("Debe completar los campos", MsgBoxStyle.Exclamation, "Error")

        End If

    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        Dim ask As MsgBoxResult

        If ((TApellido.Text <> "") And (TNombre.Text <> "") And (TDni.Text <> "") And (String.IsNullOrEmpty(TTelefono.Text))) Then

            Lmodificar.Text() = TNombre.Text() + " " + TApellido.Text()

            ask = MsgBox("Está a punto de eliminar el cliente: " + Lmodificar.Text() + "?", 4 + vbDefaultButton2, "Confirmar eliminación")

            If ask = MsgBoxResult.Yes Then
                MsgBox("El cliente " + Lmodificar.Text() + " se eliminó correctamente", MsgBoxStyle.OkOnly, "Confirmar eliminación")
                TDni.Clear()
                TNombre.Clear()
                TApellido.Clear()
                TTelefono.Clear()
                Lmodificar.Text = "modificar"

            Else
                MsgBox("No se eliminó el cliente", MsgBoxStyle.OkOnly, "Confirmar eliminación")

            End If


        Else

            MsgBox("Debe completar los campos", MsgBoxStyle.Exclamation, "Error")

        End If
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Seguro que desea salir? ", vbYesNo + vbDefaultButton2 + vbExclamation, "Salir")

        If ask = 6 Then

            Me.Close()
        End If


    End Sub


End Class
