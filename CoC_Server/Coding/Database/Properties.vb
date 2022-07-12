Module Properties

    Dim uId As String
    Public Property _Id As String
        Get
            Return uId
        End Get
        Set(ByVal Value As String)
            uId = Value
        End Set
    End Property

    Dim acc As String
    Public Property Acct As String
        Get
            Return acc
        End Get
        Set(ByVal Value As String)
            acc = Value
        End Set
    End Property

    Dim u As String
    Public Property usr As String
        Get
            Return u
        End Get
        Set(ByVal Value As String)
            u = Value
        End Set
    End Property

    Dim us As accessMode
    Public Property userMode As accessMode
        Get
            Return us
        End Get
        Set(ByVal Value As accessMode)
            us = Value
        End Set
    End Property

End Module
