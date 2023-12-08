' Order.vb
Public Class Order
    Public Property OrderID As Integer
    Public Property Customer As Customer
    Public Property Products As List(Of Product)

    Public Sub New(id As Integer, customer As Customer)
        OrderID = id
        Me.Customer = customer
        Products = New List(Of Product)()
    End Sub

    Public Sub AddProduct(product As Product)
        Products.Add(product)
    End Sub

    Public Function CalculateTotal() As Decimal
        Dim total As Decimal = 0
        For Each product In Products
            total += product.Price
        Next
        Return total
    End Function

    Public Sub DisplayInfo()
        Console.WriteLine($"Order ID: {OrderID}")
        Console.WriteLine("Customer Information:")
        Customer.DisplayInfo()
        Console.WriteLine("Products in the Order:")
        For Each product In Products
            product.DisplayInfo()
            Console.WriteLine()
        Next
        Console.WriteLine($"Total: {CalculateTotal():C}")
    End Sub
End Class
