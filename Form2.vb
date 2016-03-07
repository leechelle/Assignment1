Imports System.IO

Public Class Form2
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButAdd.Click
        'SAVE DATA TO FILE
        Dim path As String = "Details.txt "
        If System.IO.File.Exists(path) = True Then
            Dim text As New FileStream(path, FileMode.Create, FileAccess.Write)
            text.Close()



            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter("Details.txt ", True)

            file.WriteLine(txtEvent.Text & ",")
            file.WriteLine(txtLocation.Text & ",")
            file.WriteLine(txtRegfee.Text & ",")
            file.WriteLine(DateTimePicker1.Text & ",")
            file.WriteLine(txtTitle.Text & ",")
            file.Close()
            MessageBox.Show("saved file")
        Else
            MessageBox.Show("did not create")
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.Show()
    End Sub


End Class