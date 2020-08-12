Public Class Form2

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value >= 100 Then
            ProgressBar1.Value = 0
            Timer1.Stop()
            Timer2.Start()
        Else
            ProgressBar1.Value = ProgressBar1.Value + 5
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer2.Tick
        If ProgressBar1.Value >= 100 Then
            ProgressBar1.Value = 0
            Timer2.Stop()
            Timer1.Start()
        Else
            ProgressBar1.Value = ProgressBar1.Value + 10
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer3.Tick
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Me.Close()
        Form1.Label2.Text = "Setup is completed"
        Form1.ProgressBar1.Visible = False
        Form1.Button1.Visible = False
        Form1.CheckBox1.Visible = False
        Form1.CheckBox2.Visible = False
        Form1.Button2.Text = "Finish"
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer3.Start()
    End Sub
End Class