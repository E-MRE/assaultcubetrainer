Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If (CheckBox1.Checked = True) Then
                WritePointerInteger("ac_client", &H51E20C, TextBox1.Text, &H374, &H8, &HF8)
            End If

            If (CheckBox2.Checked = True) Then
                WritePointerInteger("ac_client", &H509B74, TextBox2.Text, &H374, &H8, &HFC)
            End If

            If (CheckBox3.Checked = True) Then
                WritePointerInteger("ac_client", &H509B74, TextBox3.Text, &H360, &H14, &H0)
            End If

            If (CheckBox4.Checked = True) Then
                WritePointerInteger("ac_client", &H50F4F4, TextBox4.Text, &H37C, &H10, &H0)
            End If

            If (CheckBox5.Checked = True) Then
                WritePointerInteger("ac_client", &H51E20C, TextBox5.Text, &H37C, &H44, &HF0)
            End If
            MessageBox.Show("İşlem Başarıyla Gerçekleştirildi..")
        Catch ex As Exception
            MessageBox.Show("Hata Yaptınız : " + ex.Message)
        End Try

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged, CheckBox5.CheckedChanged, CheckBox4.CheckedChanged, CheckBox3.CheckedChanged, CheckBox2.CheckedChanged
        If (CheckBox1.Checked = True) Then
            TextBox1.Enabled = True
        Else
            TextBox1.Enabled = False
        End If

        If (CheckBox2.Checked = True) Then
            TextBox2.Enabled = True
        Else
            TextBox2.Enabled = False
        End If

        If (CheckBox3.Checked = True) Then
            TextBox3.Enabled = True
        Else
            TextBox3.Enabled = False
        End If

        If (CheckBox4.Checked = True) Then
            TextBox4.Enabled = True
        Else
            TextBox4.Enabled = False
        End If

        If (CheckBox5.Checked = True) Then
            TextBox5.Enabled = True
        Else
            TextBox5.Enabled = False
        End If
    End Sub
End Class
