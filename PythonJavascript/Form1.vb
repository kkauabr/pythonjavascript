Public Class Form1
    Dim terminou As Integer = 0

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value >= 100 Then
            ProgressBar1.Value = 100
            Timer1.Stop()
            terminou = 1
        Else
            ProgressBar1.Value = ProgressBar1.Value + 1
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        CheckBox1.Enabled = False
        CheckBox2.Enabled = False
        ProgressBar1.Visible = True
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If ProgressBar1.Value = 100 Then
            Timer2.Stop()
            Form2.Show()
            Label2.Text = "Please wait while we configure PyCharm JavaScript"
            ProgressBar1.Value = 0
            ProgressBar1.Style = ProgressBarStyle.Marquee
        End If
    End Sub
End Class
