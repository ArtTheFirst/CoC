Imports System.IO
Imports System.Text
Imports System.Security.Cryptography

Module Encryption

    Function ToHex(ByVal ba() As Byte) As String
        If ba Is Nothing OrElse ba.Length = 0 Then
            Return ""
        End If
        Const HexFormat As String = "{0:X2}"
        Dim sb As New StringBuilder
        For Each b As Byte In ba
            sb.Append(String.Format(HexFormat, b))
        Next
        Return sb.ToString
    End Function

    Public Function Encrypt(ByVal key As String, s As Byte(), Optional ByVal txtdata As Byte() = Nothing) As Byte()
        Dim enctxt As Byte()
        Using outputStream As MemoryStream = New MemoryStream()
            Dim algorithm As RijndaelManaged = getAlgorithm(key, s)
            Using cryptoStream As CryptoStream = New CryptoStream(outputStream,
                                        algorithm.CreateEncryptor(), CryptoStreamMode.Write)
                If txtdata Is Nothing Then
                    txtdata = System.Text.Encoding.ASCII.GetBytes(key)
                End If
                cryptoStream.Write(txtdata, 0, txtdata.Length)
                cryptoStream.FlushFinalBlock()
                enctxt = outputStream.ToArray()
            End Using
        End Using
        Return enctxt
    End Function
    Function getAlgorithm(ByVal key As String, ByVal s As Byte()) As RijndaelManaged
        Const keySize As Integer = 256
        Dim keyBuilder As Rfc2898DeriveBytes =
        New Rfc2898DeriveBytes(key, s)
        Dim algorithm As RijndaelManaged = New RijndaelManaged()
        algorithm.KeySize = keySize
        algorithm.IV = keyBuilder.GetBytes(CType(algorithm.BlockSize / 8, Integer))
        algorithm.Key = keyBuilder.GetBytes(CType(algorithm.KeySize / 8, Integer))
        algorithm.Padding = PaddingMode.PKCS7
        Return algorithm
    End Function

    Public Function SerialId() As String
        Dim csprng As New RNGCryptoServiceProvider()
        Dim salt As Byte() = New Byte(24) {}
        csprng.GetBytes(salt)
        SerialId = Left(ToHex(salt), 6)
    End Function

End Module
