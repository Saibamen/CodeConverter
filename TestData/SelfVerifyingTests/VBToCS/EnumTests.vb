﻿Imports System
Imports System.Linq
Imports Xunit

Public Class EnumTests
    Private Enum RankEnum As SByte
        First = 1
        Second = 2
    End Enum

    <Fact>
    Sub TestEnumCast()
        Dim eEnum = RankEnum.Second
        Dim sEnum = "2" 'Has to be an integer within the string, CType doesn't parse enums
        Dim iEnum = 2
        Dim enumToString As String = CType(eEnum, String)
        Dim enumToInt As Integer = CType(eEnum, Integer)
        Dim stringToEnum As RankEnum = CType(sEnum, RankEnum)
        Dim intToEnum As RankEnum = CType(iEnum, RankEnum)

        Assert.Equal(enumToString, sEnum)
        Assert.Equal(enumToInt, iEnum)
        Assert.Equal(stringToEnum, eEnum)
        Assert.Equal(intToEnum, eEnum)
    End Sub
End Class
