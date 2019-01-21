Public Class Form1

    Private objStudent As New Student   'Declare a variable of type Student and 
    'use the "New" To create an instance of the Student Class so that the objStudent is ready to recieve data.

    Private Sub btnSet_Click() Handles btnSet.Click

        Try
            objStudent.LastName = txtLastName.Text   'Assigns a value to the LastName (contents of the textbox to the LastName of the objStudent)
            objStudent.ID = txtID.Text
        Catch ex As ArgumentException                'Error handling
            MessageBox.Show(ex.Message, "Error")
        End Try

    End Sub

    Private Sub btnGet_Click(sender As Object, e As EventArgs) Handles btnGet.Click

        lblStudent.Text = objStudent.ID & ", " & objStudent.LastName   'Assigns a value to the label (contents of the lastName Property, ref by objStudent, to the Text of label control)

    End Sub
End Class
