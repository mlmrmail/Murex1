Public Class Form1


    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        With dgv
            .Columns.Add("colDate", "DATE")
            .Columns.Add("colInstrument", "INSTRUMENTS")
            .Columns.Add("colPortfolio", "PORTFOLIO")
            .Columns.Add("colFlows", "FLOWS")
        End With




    End Sub



End Class
