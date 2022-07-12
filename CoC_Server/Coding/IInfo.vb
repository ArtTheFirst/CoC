Imports CoC_Server

Public Interface IInfo

    Function GetName(ByVal size As Integer) As String

    Sub Draw()
    Sub Rotate(ByVal sngDegrees As Single)
    Sub Translate(ByVal x As Integer, ByVal y As Integer)
    Sub Reflect(ByVal iSlope As Integer,
                 ByVal iIntercept As Integer)

    Property clAvatar As String
    Property clName As String
    Property clAddress As String
    Property clPhone As String
    Property clEmail As String
    Property clSetDate As String
    Property IsHQ As Integer
    Property clType As String

    Class AppDetails
        Implements IInfo

        Public Property clAddress As String Implements IInfo.clAddress
            Get
                Throw New NotImplementedException()
            End Get
            Set(value As String)
                Throw New NotImplementedException()
            End Set
        End Property

        Public Property clAvatar As String Implements IInfo.clAvatar
            Get
                Throw New NotImplementedException()
            End Get
            Set(value As String)
                Throw New NotImplementedException()
            End Set
        End Property

        Public Property clEmail As String Implements IInfo.clEmail
            Get
                Throw New NotImplementedException()
            End Get
            Set(value As String)
                Throw New NotImplementedException()
            End Set
        End Property

        Public Property clName As String Implements IInfo.clName
            Get
                Throw New NotImplementedException()
            End Get
            Set(value As String)
                Throw New NotImplementedException()
            End Set
        End Property

        Public Property clPhone As String Implements IInfo.clPhone
            Get
                Throw New NotImplementedException()
            End Get
            Set(value As String)
                Throw New NotImplementedException()
            End Set
        End Property

        Public Property clSetDate As String Implements IInfo.clSetDate
            Get
                Throw New NotImplementedException()
            End Get
            Set(value As String)
                Throw New NotImplementedException()
            End Set
        End Property

        Public Property clType As String Implements IInfo.clType
            Get
                Throw New NotImplementedException()
            End Get
            Set(value As String)
                Throw New NotImplementedException()
            End Set
        End Property

        Public Property IsHQ As Integer Implements IInfo.IsHQ
            Get
                Throw New NotImplementedException()
            End Get
            Set(value As Integer)
                Throw New NotImplementedException()
            End Set
        End Property

        Public Sub Draw() Implements IInfo.Draw
            Throw New NotImplementedException()
        End Sub

        Public Sub Reflect(iSlope As Integer, iIntercept As Integer) Implements IInfo.Reflect
            Throw New NotImplementedException()
        End Sub

        Public Sub Rotate(sngDegrees As Single) Implements IInfo.Rotate
            Throw New NotImplementedException()
        End Sub

        Public Sub Translate(x As Integer, y As Integer) Implements IInfo.Translate
            Throw New NotImplementedException()
        End Sub

        Public Function GetName(size As Integer) As String Implements IInfo.GetName
            Throw New NotImplementedException()
            If size = 0 Then
                Return "Zero"
            End If
            Return "Unknown"
        End Function
        Public Function GetNameDirect(size As Integer) As String
            ' A class method.
            If size = 0 Then
                Return "Zero"
            End If
            Return "Unknown"
        End Function

    End Class

End Interface
