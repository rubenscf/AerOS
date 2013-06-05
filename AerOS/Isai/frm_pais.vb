Imports Oracle.DataAccess.Client


Public Class frm_pais

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            frm_main._cnn.Open()
            Dim sql As String = "insert into pais(nombre) values('" + txt_pais.Text + "')"
            frm_main._cmd = New OracleCommand(sql, frm_main._cnn)
            frm_main._cmd.ExecuteNonQuery()
            txt_pais.Text = ""
            MsgBox("Datos insertados correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            frm_main._cnn.Close()

        End Try

    End Sub

    Private Sub frm_pais_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class