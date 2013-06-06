Public Class frm_personal
    Private Sub frm_personal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            frm_main._cnn.Open()
            _LLENAR_CMB("select cod_pro as id, nombre from profesion order by id ASC", cmb_pro)
            _LLENAR_CMB("select cod_line as id, nombre from linea order by id ASC", cmb_line)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            frm_main._cnn.Close()
        End Try

    End Sub

    Private Sub bto_agre_Click(sender As Object, e As EventArgs) Handles bto_agre.Click

        Try
            frm_main._cnn.Open()
            _INSERTAR_TRABAJADOR(txt_nombre.Text, txt_apellido.Text, txt_nacion.Text, cmb_pro.SelectedValue, cmb_line.SelectedValue, txt_usua.Text, txt_pass.Text)
            txt_nombre.Text = ""
            txt_apellido.Text = ""
            txt_nacion.Text = ""
            txt_usua.Text = ""
            txt_pass.Text = ""
            MsgBox("Trabajador inscrito correctamente")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            frm_main._cnn.Close()
        End Try
    End Sub
End Class