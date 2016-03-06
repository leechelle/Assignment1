Imports System.IO

Public Class Form4
    Private Sub ButtExit_Click(sender As Object, e As EventArgs) Handles ButtExit.Click
        Me.Close()

    End Sub

    Private Sub ButtBack_Click(sender As Object, e As EventArgs) Handles ButtBack.Click
        Form3.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim filenum As Integer = FreeFile()
        Dim tempS As String = ""
        Dim tempL As String
        FileOpen(filenum, "MEMBER.txt", OpenMode.Input)
        Do Until EOF(filenum)
            tempL = LineInput(filenum)
            tempS += tempL + vbCrLf

        Loop
        FileClose(filenum)
        ComboBox1.Text = tempS
        ListBox1.Items.Add(ComboBox1.Text)
        ComboBox1.Text = Form3.txtMembership.Text
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class