Option Strict On
Option Explicit On

Imports System.IO
Imports System.Text
Imports System.Security.Cryptography

Public Class Crypto

    Public PlainText As String
    Public CipherText As String
    Public TypeOfCryption As CryptionType
    Public ErrorMessage As String

    Public Enum CryptionType
        Encrypt
        Decrypt
    End Enum

    Public Function Cryption(ByVal CryptionString As String, ByVal PassPhrase As String, ByVal SaltValue As String, ByVal HashAlgorithm As String, ByVal PasswordIterations As Integer, ByVal InitVector As String, ByVal KeySize As Integer) As Boolean
        Try
            Dim initVectorBytes As Byte()
            initVectorBytes = Encoding.ASCII.GetBytes(InitVector)

            Dim saltValueBytes As Byte()
            saltValueBytes = Encoding.ASCII.GetBytes(SaltValue)

            Dim CryptorTextBytes As Byte()

            Dim password As New Rfc2898DeriveBytes(PassPhrase, saltValueBytes, PasswordIterations)

            Dim keyBytes As Byte()
            keyBytes = password.GetBytes(CInt(KeySize / 8))

            Dim symmetricKey As RijndaelManaged
            symmetricKey = New RijndaelManaged()
            symmetricKey.Mode = CipherMode.CBC

            Dim Cryptor As ICryptoTransform = Nothing
            Dim MemoryStream As MemoryStream = Nothing
            Dim CryptoStream As CryptoStream = Nothing

            Select Case TypeOfCryption
                Case Is = CryptionType.Encrypt
                    CryptorTextBytes = Encoding.UTF8.GetBytes(CryptionString)
                    Cryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes)
                    MemoryStream = New MemoryStream
                    CryptoStream = New CryptoStream(MemoryStream, Cryptor, CryptoStreamMode.Write)
                    CryptoStream.Write(CryptorTextBytes, 0, CryptorTextBytes.Length)
                    CryptoStream.FlushFinalBlock()
                    CryptorTextBytes = MemoryStream.ToArray()
                    CipherText = Convert.ToBase64String(CryptorTextBytes)
                Case Is = CryptionType.Decrypt
                    CryptorTextBytes = Convert.FromBase64String(CryptionString)
                    Cryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes)
                    MemoryStream = New MemoryStream(CryptorTextBytes)
                    CryptoStream = New CryptoStream(MemoryStream, Cryptor, CryptoStreamMode.Read)
                    ReDim CryptorTextBytes(CryptorTextBytes.Length)
                    Dim decryptedByteCount As Integer = CryptoStream.Read(CryptorTextBytes, 0, CryptorTextBytes.Length)
                    PlainText = Encoding.UTF8.GetString(CryptorTextBytes, 0, decryptedByteCount)
            End Select
            MemoryStream.Close()
            CryptoStream.Close()
            Return True

        Catch ex As Exception
            ErrorMessage = ex.Message
            Return False
        End Try

    End Function

End Class

