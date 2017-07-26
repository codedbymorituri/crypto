Option Strict On
Option Explicit On

Public Class GUI

    Private Sub ButtonCryption_Click(sender As Object, e As EventArgs) Handles ButtonCryption.Click
        Dim CryptionString As String = Me.TextBoxStringToEncrypt.Text
        Dim PassPhrase As String = Me.TextBoxPassPhrase.Text
        Dim SaltValue As String = Me.TextBoxSalt.Text
        Dim PasswordIterations As Integer = CInt(Me.TextBoxIterations.Text)
        Dim InitVector As String = Me.TextBoxInitVector.Text
        Dim HashAlgorithm As String = "SHA256"
        Dim KeySize As Integer = 256
        Dim c As Crypto = New Crypto
        c.TypeOfCryption = Crypto.CryptionType.Encrypt
        If c.Cryption(CryptionString, PassPhrase, SaltValue, HashAlgorithm, PasswordIterations, InitVector, KeySize) = True Then
            Me.TextBoxEncrypted.Text = c.CipherText
        Else
            MessageBox.Show(c.ErrorMessage, "YBCryptoAdmin", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        c.TypeOfCryption = Crypto.CryptionType.Decrypt
        If c.Cryption(c.CipherText, PassPhrase, SaltValue, HashAlgorithm, PasswordIterations, InitVector, KeySize) = True Then
            Me.TextBoxDecrypted.Text = c.PlainText
        Else
            MessageBox.Show(c.ErrorMessage, "YBCryptoAdmin", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class
