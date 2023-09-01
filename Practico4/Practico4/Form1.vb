Public Class Form1


    Private Sub TDesde_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDesde.KeyPress
        If (Char.IsNumber(e.KeyChar)) Then

            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
            MessageBox.Show("solo se permiten numeros", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub

    Private Sub THasta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles THasta.KeyPress
        If (Char.IsNumber(e.KeyChar)) Then

            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
            MessageBox.Show("solo se permiten numeros", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub

    Private Sub BFuncion_Click(sender As Object, e As EventArgs) Handles BFuncion.Click
        ListBox1.Items.Clear()
        Dim item As Integer = TDesde.Text
        While (item <= THasta.Text)
            ListBox1.Items.Add(item)
            item = item + 1
        End While
    End Sub



    Private Sub BPares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPares.Click

        ListBox1.Items.Clear()
        Dim num As Integer = Val(TDesde.Text)
        Dim hasta As Integer = Val(THasta.Text)
        Dim acumulador As Integer

        While (num <= hasta)

            If (num Mod 2 = 0) Then
                ListBox1.Items.Add(num)
                acumulador = acumulador + 1
            End If

            num = num + 1

        End While

        Chart1.Titles.Clear()
        Chart1.Series.Clear()
        Chart1.Series.Add("Datos")
        Chart1.Width = 400
        Chart1.Height = 400
        Chart1.Titles.Add("Graficos")
        Chart1.Series("Datos").ChartType = DataVisualization.Charting.SeriesChartType.Doughnut

        Dim j As Integer
        For j = 0 To acumulador - 1
            Chart1.Series("Datos").Points.AddXY([j], ListBox1.Items(j))
            Chart1.Series("Datos").IsValueShownAsLabel = True
        Next


    End Sub


    Private Sub BImpares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BImpares.Click

        ListBox1.Items.Clear()
        Dim num As Integer = Val(TDesde.Text)
        Dim acumulador As Integer

        While (num <= THasta.Text)

            If (num Mod 2 <> 0) Then
                ListBox1.Items.Add(num)
                acumulador = acumulador + 1
            End If

            num = num + 1

        End While

        Chart1.Titles.Clear()
        Chart1.Series.Clear()
        Chart1.Series.Add("Datos")
        Chart1.Width = 400
        Chart1.Height = 400
        Chart1.Titles.Add("Graficos")
        Chart1.Series("Datos").ChartType = DataVisualization.Charting.SeriesChartType.Doughnut

        Dim j As Integer
        For j = 0 To acumulador - 1
            Chart1.Series("Datos").Points.AddXY([j], ListBox1.Items(j))
            Chart1.Series("Datos").IsValueShownAsLabel = True
        Next

    End Sub


    Private Sub BPrimos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPrimos.Click

        ListBox1.Items.Clear()
        Dim num As Integer = Val(TDesde.Text)
        Dim acumulador As Integer

        While (num <= THasta.Text)

            Dim nro As Integer = 0

            For i = 1 To num

                If (num Mod i = 0) Then
                    nro = nro + 1
                End If

            Next

            If (nro = 2) Or (num = 1) Then
                ListBox1.Items.Add(num)
                acumulador = acumulador + 1

            End If

            num = num + 1

        End While

        Chart1.Titles.Clear()
        Chart1.Series.Clear()
        Chart1.Series.Add("Datos")
        Chart1.Width = 400
        Chart1.Height = 400
        Chart1.Titles.Add("Graficos")
        Chart1.Series("Datos").ChartType = DataVisualization.Charting.SeriesChartType.Doughnut

        Dim j As Integer
        For j = 0 To acumulador - 1
            Chart1.Series("Datos").Points.AddXY([j], ListBox1.Items(j))
            Chart1.Series("Datos").IsValueShownAsLabel = True
        Next

    End Sub


End Class
