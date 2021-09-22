'Elliot Heiner
'RCET0265
'Spring 2021
'ConvertAndValidate
'https://github.com/heinelli/ConvertAndValidate.git

Module ConvertAndValidate
    Sub Main()
        Dim convertThisString As String
        Dim thisInteger As Integer

        Console.WriteLine("Type in a number please.")
        convertThisString = (Console.ReadLine())
        ConvertAndValidate(convertThisString, thisInteger)
        Console.WriteLine(thisInteger)
        Console.Read()

    End Sub

    Private Function ConvertAndValidate(ByVal convertThisString As String, ByRef toThisInteger As Integer)
        Try
            toThisInteger = CInt(convertThisString)
            toThisInteger = 60
        Catch
            toThisInteger = 90
        End Try
        Return toThisInteger
    End Function

End Module
