Public Class Main
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SQLSTATEMENT As String = "UPDATE 'user' SET 'TextBox1' ='" & TextBox1.Text & "', 'Textbox2' =" & TextBox1.Text & "', 'TextBox3' ='" & TextBox2.Text
        save(SQLSTATEMENT)
        MsgBox("Data updated successfuly", vbInformation)
    End Sub
End Class