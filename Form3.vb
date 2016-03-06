Imports System.IO
Public Class Form3


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtBack.Click
        Form2.Show()
        Me.Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ButtContinue.Click
        Form4.Show()
        Me.Close()

    End Sub

    Private Sub ButtAdd_Click(sender As Object, e As EventArgs) Handles ButtSave.Click

        Dim rand As New Random()
        Dim number = rand.Next(0, 999)
        txtMembership.Text = number

        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yy"

        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "yyyyMMdd"

        txtMembership.Text = (txtMembership.Text + DateTimePicker1.Text + DateTimePicker2.Text)



        Dim path As String = "C:\Users\Leechellek\Documents\Visual Studio 2015\Projects\assignement 1\assignement 1\bin\Debug\MEMBER.txt "
        Dim text As New FileStream(path, FileMode.Create, FileAccess.Write)

        text.Close()



        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\Leechellek\Documents\Visual Studio 2015\Projects\assignement 1\assignement 1\bin\Debug\MEMBER.txt ", True)

        file.WriteLine(txtMembership.Text & "")
        file.WriteLine(txtFirstName.Text & "")
        file.WriteLine(txtSurname.Text & "")
        file.WriteLine(DateTimePicker1.Text & "")
        file.WriteLine(DateTimePicker2.Text & "")
        file.WriteLine(txtOutFee.Text & "")
        file.WriteLine(txtRace.Text & "")
        file.WriteLine(txtRaceTime.Text & "")



        file.Close()



        If Not IsNumeric(txtMembership.Text) Then
            MessageBox.Show("please enter a Membership Number")

        End If

        If Not IsNumeric(txtRace.Text) Then
            MessageBox.Show("please enter kilometers")

        End If

        If Not IsNumeric(txtRaceTime.Text) Then
            MessageBox.Show("please enter time completed in ")
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim c As String = "Membership Number=" + txtMembership.Text
        Dim a As String = "First name = " + txtFirstName.Text
        Dim b As String = "Surname = " + txtSurname.Text
        Dim d As String = "Oustanding fee = " + txtOutFee.Text
        Dim l As String = "Race In = " + txtRace.Text
        Dim f As String = "Race time Completed = " + txtRaceTime.Text
        Dim g As String = "Date of Birth = " + DateTimePicker1.Text
        Dim h As String = "Date Joined = " + DateTimePicker2.Text

        ListBox1.Items.Add(c)
        ListBox1.Items.Add(a)
        ListBox1.Items.Add(b)
        ListBox1.Items.Add(d)
        ListBox1.Items.Add(l)
        ListBox1.Items.Add(f)
        ListBox1.Items.Add(g)
        ListBox1.Items.Add(h)

        Form4.ComboBox1.Items.Add(txtMembership.Text)


        If (txtFemale.Checked = True) Then
            ListBox1.Items.Add("FEMALE")
        Else
            If (txtMale.Checked = True) Then
                ListBox1.Items.Add("MALE")
            End If
        End If


    End Sub

    Private Sub ButtDelete_Click(sender As Object, e As EventArgs) Handles ButtDelete.Click
        If ListBox1.Items.Count > 0 Then
            If MessageBox.Show("do you want to delete the item selected", "mesaage", MessageBoxButtons.OKCancel) Then
                ListBox1.Items.Remove(ListBox1.SelectedItem.ToString)
            End If
        End If
    End Sub

    Private Sub ButtClear_Click(sender As Object, e As EventArgs) Handles ButtClear.Click

        txtFirstName.Text = ""
        txtSurname.Text = ""
        txtOutFee.Text = ""
        txtRace.Text = ""
        txtRaceTime.Text = ""
        txtRace.Text = ""

    End Sub
End Class
