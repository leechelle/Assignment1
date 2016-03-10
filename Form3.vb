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

        Dim str As New Random()
        Dim numbers = str.Next(0, 999)
        txtMembership.Text = numbers

        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yy"

        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "yyyyMMdd"

        txtMembership.Text = (txtMembership.Text + DateTimePicker1.Text + DateTimePicker2.Text)



        Dim path As String = "MEMBER.txt "
        If System.IO.File.Exists(path) = True Then
            Dim text As New FileStream(path, FileMode.Create, FileAccess.Write)

            text.Close()



            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter("MEMBER.txt ", True)

            file.WriteLine("Membership Number = " + txtMembership.Text & ",")
            file.WriteLine("First name = " + txtFirstName.Text & ",")
            file.WriteLine("Surname = " + txtSurname.Text & ",")
            file.WriteLine("Date of Birth = " + DateTimePicker1.Text & ",")
            file.WriteLine("Date Joined = " + DateTimePicker2.Text & ",")
            file.WriteLine("Oustanding fee = " + txtOutFee.Text & ",")
            file.WriteLine("Race In = " + txtRace.Text & ",")
            file.WriteLine("Race time Completed = " + txtRaceTime.Text & ",")



            file.Close()

            MessageBox.Show("file saved")
        Else
            MessageBox.Show("File didnt save")
        End If

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

        txtEdit.Text = ListBox1.SelectedIndex

        Form4.MemberInfo.Items.Add(txtMembership.Text)


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

        ListBox1.ClearSelected()

    End Sub

    Private Sub ButtEdit_Click(sender As Object, e As EventArgs) Handles txtEdit.Click





        If ListBox1.Items.Count > 0 Then
            If MessageBox.Show("updated the information ", "mesaage", MessageBoxButtons.OKCancel) Then
                ListBox1.Items.Add(ListBox1.SelectedItem.ToString)
            End If
        End If




    End Sub
End Class
