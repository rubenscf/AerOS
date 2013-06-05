Imports Oracle.DataAccess.Client
Module mdl_cmb
    Sub _LLENAR_CMB(ByVal sql As String, ByRef _cmb As ComboBox)
        Dim Dt As DataTable
        Dim Da As New OracleDataAdapter
        With frm_main._cmd
            .CommandType = CommandType.Text
            .CommandText = sql
            .Connection = frm_main._cnn
        End With
        Da.SelectCommand = frm_main._cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With _cmb
            .DataSource = Dt
            .DisplayMember = "nombre"
            .ValueMember = "id"
        End With
    End Sub
    Sub _LLENAR_CMB2(ByVal sql As String, ByRef _cmb As ComboBox)
        Dim Dt As DataTable
        Dim Da As New OracleDataAdapter
        With frm_main._cmd
            .CommandType = CommandType.Text
            .CommandText = sql
            .Connection = frm_main._cnn
        End With
        Da.SelectCommand = frm_main._cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With _cmb
            .DataSource = Dt
            .DisplayMember = "nombre"
            .ValueMember = "id"
        End With
    End Sub
  
End Module
