Public Class Form1

    Dim StoredPrice() As Double = {0.0, 0.0}
    Dim total As Double = 0
    Dim totalPrice As Double = 0
    Dim average As Double = 0
    Dim str As String
    Dim str2 As String
    Dim filePath As String = "C:\Users\Gared\source\VB\Hw1Arrays2\Hw1Arrays2\stored.txt"


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



        Update2()
    End Sub



    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        Dim sv As New System.IO.StreamWriter(filePath)
        For Each price As Double In StoredPrice
            sv.WriteLine(price.ToString())

        Next
        sv.Close()
        MessageBox.Show("Data saved to file.")

    End Sub
    Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles BtnLoad.Click

        If System.IO.File.Exists(filePath) Then
            Dim lines() As String = System.IO.File.ReadAllLines(filePath)
            total = 0
            totalPrice = 0
            ReDim StoredPrice(1)
            For Each line As String In lines
                If Not String.IsNullOrEmpty(line) Then
                    total += 1
                    ReDim Preserve StoredPrice(total)
                    StoredPrice(total) = CDbl(line)
                    totalPrice += StoredPrice(total)
                End If
            Next

        End If


        Update2()

    End Sub

    Private Sub Update2()
        lblTotalSales.Text = totalPrice.ToString()
        average = totalPrice / total
        LblAverage.Text = average.ToString()
        LblTotalItems.Text = total.ToString()
    End Sub
End Class
'System.IO.File.WriteAllLines("C:\Users\Gared\source\VB\Hw1Arrays2\Hw1Arrays2\stored.TXT", StoredPrice)

'Dim fileReader As String = My.Computer.FileSystem.ReadAllText("C:\Users\Gared\source\VB\Hw1Arrays2\Hw1Arrays2\stored.TXT")
'Dim lines() As String = fileReader.Split(New Char() {ControlChars.Lf, ControlChars.Cr}, StringSplitOptions.RemoveEmptyEntries)
'Dim values(lines.Length - 1) As Double
'For i As Integer = 0 To lines.Length - 1
'values(i) = CDbl(lines(i))
'Next

'MsgBox(String.Join("", StoredPrice))#
