' Product.vb
Public Class Product
    Public Property ProductID As Integer
    Public Property Name As String
    Public Property Price As Decimal

    Public Sub New(id As Integer, name As String, price As Decimal)
        ProductID = id
        Me.Name = name
        Me.Price = price
    End Sub

    Public Sub DisplayInfo()
        Console.WriteLine($"Product ID: {ProductID}")
        Console.WriteLine($"Name: {Name}")
        Console.WriteLine($"Price: {Price:C}")
    End Sub
End Class
