' Customer.vb
Public Class Customer
    Public Property CustomerID As Integer
    Public Property Name As String
    Public Property Email As String

    Public Sub New(id As Integer, name As String, email As String)
        CustomerID = id
        Me.Name = name
        Me.Email = email
    End Sub

    Public Sub DisplayInfo()
        Console.WriteLine($"Customer ID: {CustomerID}")
        Console.WriteLine($"Name: {Name}")
        Console.WriteLine($"Email: {Email}")
    End Sub
End Class
