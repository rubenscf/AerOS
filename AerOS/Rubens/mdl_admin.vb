Imports Oracle.DataAccess.Client

Module mdl_admin
    Sub _INSERTAR_CLIENTE(ByVal dpi As String, ByVal passp As String, ByVal nacion As String, ByVal fecha As Date, ByVal nombre As String, ByVal apellido As String, ByVal usuario As String, ByVal pass As String)
        ' Dim contenedor As Integer
        frm_main._cmd.CommandType = CommandType.StoredProcedure
        frm_main._cmd.CommandText = "INSERTAR_CLIENTE"
        With frm_main._cmd.Parameters
            .Add("p_dpi", OracleDbType.Varchar2).Value = dpi
            .Add("p_passp", OracleDbType.Varchar2).Value = passp
            .Add("p_nacion", OracleDbType.Varchar2).Value = nacion
            .Add("p_fecha", OracleDbType.Date).Value = fecha
            .Add("p_nombre", OracleDbType.Varchar2).Value = nombre
            .Add("p_apellido", OracleDbType.Varchar2).Value = apellido
            .Add("p_usuario", OracleDbType.Varchar2).Value = usuario
            .Add("p_pass", OracleDbType.Varchar2).Value = pass
        End With
        frm_main._cmd.ExecuteNonQuery()
    End Sub
    Sub _INSERTAR_TRABAJADOR(ByVal nombre As String, ByVal apellido As String, ByVal nacion As String, ByVal pro As Integer, ByVal linea As Integer, ByVal usuario As String, ByVal pass As String)
        ' Dim contenedor As Integer
        frm_main._cmd.CommandType = CommandType.StoredProcedure
        frm_main._cmd.CommandText = "INSERTAR_TRABAJADOR"
        With frm_main._cmd.Parameters
            .Add("p_nombre", OracleDbType.Varchar2).Value = nombre
            .Add("p_apellido", OracleDbType.Varchar2).Value = apellido
            .Add("p_nacion", OracleDbType.Varchar2).Value = nacion
            .Add("p_pro", OracleDbType.Int16).Value = pro
            .Add("p_linea", OracleDbType.Int16).Value = linea
            .Add("p_usuario", OracleDbType.Varchar2).Value = usuario
            .Add("p_pass", OracleDbType.Varchar2).Value = pass
        End With
        frm_main._cmd.ExecuteNonQuery()
    End Sub
End Module
