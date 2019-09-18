Imports System.IO

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub btnLoadFile_Click(sender As Object, e As EventArgs) Handles btnLoadFile.Click
        Try
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|Contacts (*.vcf)|*.vcf"
            Dim reply As DialogResult
            Dim filePath As String

            reply = openFileDialog1.ShowDialog()
            If reply <> Windows.Forms.DialogResult.Cancel Then
                filePath = openFileDialog1.FileName

                Dim sr As StreamReader
                sr = New StreamReader(filePath)
                Dim Allcontact As String
                Allcontact = sr.ReadToEnd
                Dim tel As String()
                Dim countCell, countNumbers As Integer

                countCell = 0
                countNumbers = 0

                tel = Allcontact.Split(vbCrLf)
                For Each cellDetails As String In tel
                    If cellDetails.Contains("TEL") Then
                        If cellDetails.Contains(" ") Then cellDetails = cellDetails.Replace(" ", "")

                        lstTelCell.Items.Add(cellDetails)
                        countCell += 1

                        'Extract the Numbers and separate each number with comma into a TextBox
                        Dim telNum As String()
                        telNum = cellDetails.Split(":")
                        For Each cellNumber As String In telNum
                            If cellNumber.StartsWith("0") Or cellNumber.StartsWith("+") Then
                                txtPhoneNumbers.Text = txtPhoneNumbers.Text & "," & cellNumber
                                countNumbers += 1
                            End If
                        Next
                    End If
                Next

                MessageBox.Show("There are " & countCell & " Telephone Contacts" & vbCrLf & _
                                        "And " & countNumbers & " Valid textable numbers in total all")

                sr.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lstTelCell.Items.Clear()
        txtPhoneNumbers.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim TelNum As String
        TelNum = InputBox("Enter your telephone number", "FIND NUMBER", "08064555381")
        For Each itm As Object In lstTelCell.Items
            If itm.ToString.Contains(TelNum) Then
                MessageBox.Show("Telephone number " & TelNum & " is in the contact")
                lstTelCell.SelectedItem = itm
                Exit For
            End If
        Next
    End Sub
End Class
