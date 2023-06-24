Public Class Form1

    Dim StoredPrice() As Double = {0.0, 0.0}
    Dim total As Double = 0
    Dim totalPrice As Double = 0
    Dim average As Double = 0
    Dim str As String
    Dim str2 As String



    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click


        total = total + 1
        ReDim StoredPrice(total)
        str = total.ToString
        LblTotalItems.Text = str


        str2 = TxtInput.Text
        StoredPrice(total) = CDbl(str2)
        totalPrice = CDbl(str2) + totalPrice


        For index = 0 To StoredPrice.GetUpperBound(0)

            lblTotalSales.Text = StoredPrice(index) + totalPrice


            average = totalPrice / total
            LblAverage.Text = average.ToString


        Next




    End Sub


End Class
