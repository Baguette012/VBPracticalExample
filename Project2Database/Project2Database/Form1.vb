Imports System.Data.SqlClient

Public Class Form1
    Private Function GetDatabaseConnection() As SqlConnection
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gared\source\repos\Project2Database\ItemDatabase.mdf;Integrated Security=True"
        Return New SqlConnection(connectionString)
    End Function


    Private Sub AddItem(itemName As String, itemPrice As Double, saleDate As DateTime, soldBy As String)
        Using connection As SqlConnection = GetDatabaseConnection()
            connection.Open()

            Dim command As New SqlCommand("INSERT INTO Items (item_name, item_price, sale_date, sold_by) VALUES (@itemName, @itemPrice, @saleDate, @soldBy)", connection)
            command.Parameters.AddWithValue("@itemName", itemName)
            command.Parameters.AddWithValue("@itemPrice", itemPrice)
            command.Parameters.AddWithValue("@saleDate", saleDate)
            command.Parameters.AddWithValue("@soldBy", soldBy)

            command.ExecuteNonQuery()
        End Using
    End Sub



    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        ' Assuming you have textboxes called txtItemName, txtItemPrice, and txtSoldBy in your form
        Dim itemName As String = txtItemName.Text
        Dim itemPrice As Double = CDbl(txtItemPrice.Text)
        Dim saleDate As DateTime = DateTime.Now
        Dim soldBy As String = txtSoldBy.Text

        AddItem(itemName, itemPrice, saleDate, soldBy)

        ' Optional: Clear input fields after adding the item
        txtItemName.Clear()
        txtItemPrice.Clear()
        txtSoldBy.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
