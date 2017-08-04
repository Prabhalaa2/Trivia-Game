Public Class Form1
    Dim Question As Integer
    Dim score As Integer = 0




    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Question1_Click(sender As Object, e As EventArgs) Handles Question1.Click
        Label1.Text = "What Is Philadelphia 's football team"
        RadioButton1.Text = "Steelers"
        RadioButton2.Text = "Seahawks"
        RadioButton3.Text = "Eagles"
        RadioButton4.Text = "None of the above"
        Question = 1


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Submit.Click
        If RadioButton3.Checked And Question = 1 Then
            MsgBox("Correct")
            score = score + 1
        ElseIf RadioButton2.Checked And Question = 2 Then
            MsgBox("Correct")
            score = score + 1
        ElseIf RadioButton1.Checked And Question = 3 Then
            MsgBox("Correct")
            score = score + 1
        ElseIf RadioButton3.Checked And Question = 4 Then
            MsgBox("Correct")
            score = score + 1
        Else
            MsgBox("WRONG")
        End If

        Label3.Text = "Score" & score
        Panel1 D 
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = "What Is a Touchdown"
        RadioButton1.Text = "A Penalty"
        RadioButton2.Text = "A Goal"
        RadioButton3.Text = "Extra Points"
        RadioButton4.Text = "None of the above"
        Question = 2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Text = "Which team won the 2016 SuperBowl"
        RadioButton1.Text = "Patriots"
        RadioButton2.Text = "Panthers"
        RadioButton3.Text = "Saints"
        RadioButton4.Text = "None of the above"
        Question = 3
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label1.Text = "What is a QB"
        RadioButton1.Text = "Runner"
        RadioButton2.Text = "Catcher"
        RadioButton3.Text = "Thrower"
        RadioButton4.Text = "None of the above"
        Question = 4
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
