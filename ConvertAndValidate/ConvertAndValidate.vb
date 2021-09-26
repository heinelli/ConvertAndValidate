﻿'Elliot Heiner
'RCET0265
'Spring 2021
'ConvertAndValidate
'https://github.com/heinelli/ConvertAndValidate.git

Option Strict On
Option Explicit On

Module ConvertAndValidate
    Sub Main()
        Dim convertThisString As String
        Dim thisInteger As Integer

        Console.WriteLine("Type in a number please.")
        convertThisString = (Console.ReadLine())
        ConvertAndValidate(convertThisString, thisInteger)
        Console.WriteLine(ConvertAndValidate(convertThisString, thisInteger))
        Console.Read()
    End Sub

    Private Function ConvertAndValidate(ByVal convertThisString As String, ByRef toThisInteger As Integer) As String
        Dim returnMessage As String

        Try
            toThisInteger = CInt(convertThisString)
            returnMessage = ""
        Catch
            If convertThisString = "" Then
                returnMessage = "Is empty"
            Else
                returnMessage = "Must contain a number"
            End If
        End Try
        Return returnMessage
    End Function
End Module
