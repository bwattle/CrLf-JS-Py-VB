Public Class CrLf
    Dim msg1 = "Message 1 - no apostrphe"
    Dim msg2 = "Message 2 - You didn't win"
    Dim msg3 = "Apostrophes are no problem in VB"
    Dim msg4 = "This is message 4"

    Private Sub btnMsg1_Click(sender As Object, e As EventArgs) Handles btnMsg1.Click
        MessageBox.Show(msg1 & " " & msg2 & " " & msg3,
             "All 1 line", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub btnMsg2_Click(sender As Object, e As EventArgs) Handles btnMsg2.Click
        MessageBox.Show(msg1 & vbCrLf & msg2 & vbLf & msg3,
                     "2 line breaks", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub btnMsg3_Click(sender As Object, e As EventArgs) Handles btnMsg3.Click
        MessageBox.Show(msg1 & Chr(13) & Chr(10) & "with 1 line feed and carriage return using '& Chr(13) & Chr(10)'",
                     "Chr(13) & Chr(10)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub btnMsg4_Click(sender As Object, e As EventArgs) Handles btnMsg4.Click
        MessageBox.Show(msg1 & vbCrLf & "with 2 line feeds" & vbLf & "and 1 carriage return using 'vbLf'",
                     "vbCrLf then vbLf", MessageBoxButtons.OK, MessageBoxIcon.Question)
    End Sub

    Private Sub btnMsg5_Click(sender As Object, e As EventArgs) Handles btnMsg5.Click
        MessageBox.Show(msg1 & vbCrLf & "with 2 line feeds" & vbCr & "and 1 carriage return using 'vbCr'",
                     "Header Text", MessageBoxButtons.OK, MessageBoxIcon.Hand)
    End Sub

    Private Sub btnMsg6_Click(sender As Object, e As EventArgs) Handles btnMsg6.Click
        MessageBox.Show(msg1 & vbCrLf & "in VB, it seems just a line feed still does a CR" & Chr(10) & "             xx",
                     "Header Text", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
