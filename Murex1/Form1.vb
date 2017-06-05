Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fr As New FileReader
        ' fr = New FileReader("D:\MYDATA\DEV\MUREX\MONIQUE\LIQ_TEST.xlsb")
        Try
            dgv.DataSource = fr.ReadExcelFile().Tables(0)
        Catch ex As Exception
            MsgBox(ex)
        End Try


    End Sub


End Class
