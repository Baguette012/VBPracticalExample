Public Class Form1

    Dim TagSaleItems As New List(Of TagSaleItem)
    Dim StoredPrice() As Double = {0.0, 0.0}
    Dim total As Double = 0
    Dim totalPrice As Double = 0
    Dim average As Double = 0
    Dim str As String
    Dim str2 As String
    Dim filePath As String = "C:\Users\Gared\source\VB\repos\HW3Objectss\HW3Objectss\stored.txt"

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click

        Dim newItem As New TagSaleItem()

        If Not Double.TryParse(TxtInput.Text, newItem.ItemPrice) Then
            MessageBox.Show("Please enter a valid price.")
            Return
        End If

        newItem.ItemName = TxtName.Text

        TagSaleItems.Add(newItem)

        totalPrice += newItem.ItemPrice
        average = totalPrice / TagSaleItems.Count

        Update2()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        Dim sv As New System.IO.StreamWriter(filePath)
        For Each item As TagSaleItem In TagSaleItems
            sv.WriteLine(item.ItemName & "," & item.ItemPrice.ToString())
        Next
        sv.Close()
        MessageBox.Show("Data saved to file.")

    End Sub

    Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles BtnLoad.Click

        If System.IO.File.Exists(filePath) Then
            Dim lines() As String = System.IO.File.ReadAllLines(filePath)
            TagSaleItems.Clear()
            totalPrice = 0
            For Each line As String In lines
                If Not String.IsNullOrEmpty(line) Then
                    Dim parts() As String = line.Split(",")
                    If parts.Length = 2 Then
                        Dim newItem As New TagSaleItem()
                        newItem.ItemName = parts(0)
                        Double.TryParse(parts(1), newItem.ItemPrice)
                        TagSaleItems.Add(newItem)
                        totalPrice += newItem.ItemPrice
                    End If
                End If
            Next
        End If

        Update2()

    End Sub

    Private Sub Update2()
        lblTotalSales.Text = totalPrice.ToString()
        LblAverage.Text = average.ToString()
        LblTotalItems.Text = TagSaleItems.Count.ToString()
    End Sub

End Class

Public Class TagSaleItem

    Private _itemPrice As Double
    Private _itemName As String

    Public Property ItemPrice As Double
        Get
            Return _itemPrice
        End Get
        Set(value As Double)
            _itemPrice = value
        End Set
    End Property

    Public Property ItemName As String
        Get
            Return _itemName
        End Get
        Set(value As String)
            _itemName = value
        End Set
    End Property

End Class
