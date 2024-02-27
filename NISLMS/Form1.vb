Public Class Form1
    Private Sub btnshow_CheckedChanged(sender As Object, e As EventArgs) Handles btnshow.CheckedChanged
        If btnshow.Checked = True Then
            password.UseSystemPasswordChar = True

        Else
            password.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Application.Exit()
    End Sub
End Class
