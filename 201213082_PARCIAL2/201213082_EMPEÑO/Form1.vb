Public Class Form1
    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        If contador < 6 Then
            Matriz(contador, 0) = Txtnombre
            Matriz(contador, 1) = Txtcui
            Matriz(contador, 2) = Txtdireccion
            Matriz(contador, 3) = ComboBox1.SelectedItem

            If Cblaptop.Checked Then
                Matriz(contador, 4) = Txtlaptop
            ElseIf Cbrefri.Checked Then
                Matriz(contador, 4) = Txtrefri
            ElseIf Cbtelefono.Checked Then
                Matriz(contador, 4) = Txttelefono
            ElseIf Cbtv.Checked Then
                Matriz(contador, 4) = Txttv
            End If

            If Cbtv.Checked Or Cbrefri.Checked Then
                Matriz(contador, 5) = Matriz(contador, 3) * descuentocorto1
            End If

            If Cbtv.Checked Or Cbrefri.Checked Then
                Matriz(contador, 5) = Matriz(contador, 3) * descuentolargo1
            End If

            If Cbtelefono.Checked Or Cblaptop.Checked Then
                Matriz(contador, 6) = Matriz(contador, 3) * descuentocorto2
            End If

            If Cbtelefono.Checked Or Cblaptop.Checked Then
                Matriz(contador, 6) = Matriz(contador, 3) * descuentolargo2
            End If

            ListBox1.Items.Add(Matriz(contador, 0))
            ListBox2.Items.Add(Matriz(contador, 1))
            ListBox3.Items.Add(Matriz(contador, 2))
            ListBox4.Items.Add(Matriz(contador, 3))
            ListBox5.Items.Add(Matriz(contador, 4))
            ListBox6.Items.Add(Matriz(contador, 5))

        End If
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        ListBox6.Items.Clear()
        ComboBox1.Items.Clear()
        Cblaptop.Checked = False
        Cbrefri.Checked = False
        Cbtelefono.Checked = False
        Cbtv.Checked = False
        Txtcui.Text = 0
        Txtdireccion.Text = 0
        Txtlaptop.Text = 0
        Txtnombre.Text = 0
        Txtrefri.Text = 0
        Txttelefono.Text = 0
        Txttv.Text = 0

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿Desea Salir?", vbYesNo) = vbYes Then
            End
        End If
    End Sub
End Class
