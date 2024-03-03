Public Class Form2
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Hide()
        Form3.Show()
        Timer1.Stop()
    End Sub
End Class