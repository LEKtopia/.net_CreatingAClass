Public Class Student
    Private strLastName As String
    Private strFirstName As String
    Private strId As String

    Public Property LastName() As String                'Set a property
        Get
            Return strLastName
        End Get
        Set(ByVal value As String)
            strLastName = value
        End Set
    End Property

    Public Property ID() As String
        Get
            Return strId
        End Get
        Set(ByVal value As String)
            If value.Length = 6 Then                    'Error handling
                strId = value
            Else
                Throw New ArgumentException("ID must be 6 digits")
            End If
        End Set
    End Property

End Class
