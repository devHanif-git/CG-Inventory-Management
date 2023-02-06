Imports System.Text
Module FuncEncDec
    Public Function Encrypt(Encryption As String) As String
        Dim msg As String = String.Empty
        Dim encode As Byte() = New Byte(Encryption.Length - 1) {}
        encode = Encoding.UTF8.GetBytes(Encryption)
        msg = Convert.ToBase64String(encode)
        Return msg
    End Function

    Public Function Decrypt(Decryption As String) As String
        Dim decrypttext As String = String.Empty
        Dim encodedtxt As New UTF8Encoding()
        Dim decode As Decoder = encodedtxt.GetDecoder()
        Dim code_byte As Byte() = Convert.FromBase64String(Decryption)
        Dim charcount As Integer = decode.GetCharCount(code_byte, 0, code_byte.Length)
        Dim decode_char As Char() = New Char(charcount - 1) {}
        decode.GetChars(code_byte, 0, code_byte.Length, decode_char, 0)
        decrypttext = New String(decode_char)
        Return decrypttext
    End Function

End Module
