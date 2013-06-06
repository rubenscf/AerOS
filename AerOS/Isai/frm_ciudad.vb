Imports AerOS.mdl_cmb
Imports Oracle.DataAccess.Client

Public Class frm_ciudad

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            frm_main._cnn.Open()
            _LLENAR_CMB("select cod_pa as id, nombre from pais order by id ASC", cmb_pais)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            frm_main._cnn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            frm_main._cnn.Open()
            Dim sql As String = "insert into ciudad(nombre, cod_pa ) values('" + txt_ciudad.Text + "' , " & cmb_pais.SelectedValue & ")"
            frm_main._cmd = New OracleCommand(sql, frm_main._cnn)
            frm_main._cmd.ExecuteNonQuery()
            txt_ciudad.Text = ""
            MsgBox("Datos insertados correctamente")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            frm_main._cnn.Close()

        End Try
    End Sub
End Class