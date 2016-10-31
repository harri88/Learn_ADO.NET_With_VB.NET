Imports System.Data.SqlClient
Imports System.Data.OleDb



Module Module1
    Sub Main()
        Dim connection As SqlConnection = Widget.SqlServerConnection
    End Sub

    Class Widget
        Public Shared Function SqlServerConnection() As SqlConnection
            Return New SqlConnection("Data Source=SqlServerNameOrIP;Initial Catalog=DBName;Integrated Security=True")
        End Function
        'Public Shared Function OracleConnection() As OracleConnection
        'Return New OracleConnection("Data Source=MyOracleDB;User Id=myUsername;Password=myPassword;");
        'End Function
        Public Shared Function MsAccessConnection() As OleDbConnection
            Return New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DBName.mdb;User Id=admin; Password=;")
        End Function

        'http://www.visual-basic-tutorials.com/database/ado.net-command.php
    End Class
End Module
