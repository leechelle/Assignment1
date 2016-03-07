
Public Class Form4
    Private Sub ButtExit_Click(sender As Object, e As EventArgs) Handles ButtExit.Click
        Me.Close()

    End Sub

    Private Sub ButtBack_Click(sender As Object, e As EventArgs) Handles ButtBack.Click
        Form3.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("MEMBER.txt",
   System.Text.Encoding.UTF32)
        MsgBox(fileReader)



        MemberInfo.Text = Form3.txtMembership.Text
    End Sub


End Class