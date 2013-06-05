Imports Oracle.DataAccess.Client
Public Class frm_profesion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            frm_main._cnn.Open()
            Dim sql As String = "insert into profesion(nombre, sueldo ) values('" + txt_nombre.Text + "' , " & CInt(txt_sueldo.Text) & ")"
            frm_main._cmd = New OracleCommand(sql, frm_main._cnn)
            frm_main._cmd.ExecuteNonQuery()
            txt_nombre.Text = ""
            txt_sueldo.Text = ""
            MsgBox("Datos insertados correctamente")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical    )
        Finally
            frm_main._cnn.Close()

        End Try
    End Sub
End Class