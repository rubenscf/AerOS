Imports Oracle.DataAccess.Client
Public Class frm_linea

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            frm_main._cnn.Open()
            Dim sql As String = "insert into linea(nombre) values('" + txt_linea.Text + "')"
            frm_main._cmd = New OracleCommand(sql, frm_main._cnn)
            frm_main._cmd.ExecuteNonQuery()
            txt_linea.Text = ""
            MsgBox("Datos insertados correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            frm_main._cnn.Close()

        End Try
    End Sub
End Class