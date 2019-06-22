Imports System.Data.OleDb
Module Module1
    Public Cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\bd1.mdb")
    Public cmd As New OleDbCommand("select * from T_plan ", Cn)
    Public da As New OleDbDataAdapter(cmd)
    Public ds As New DataSet
    Public dr As OleDbDataReader
    Public cb As New OleDbCommandBuilder(da)

End Module
