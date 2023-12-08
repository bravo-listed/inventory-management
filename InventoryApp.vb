' InventoryApp.vb
Module InventoryApp
    Sub Main()
        Dim product1 As New Product(101, "Laptop", 999.99)
        Dim product2 As New Product(102, "Smartphone", 599.99)

        Dim customer As New Customer(1, "John Doe", "john.doe@example.com")

        Dim order As New Order(1, customer)
        order.AddProduct(product1)
        order.AddProduct(product2)

        Console.WriteLine("Order Information:")
        order.DisplayInfo()
    End Sub
End Module
