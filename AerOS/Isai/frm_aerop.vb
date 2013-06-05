Imports Oracle.DataAccess.Client
Public Class frm_aeropuerto

    

    Private Sub frm_aeropuerto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            frm_main._cnn.Open()
            _LLENAR_CMB("select cod_pa as id, nombre from pais order by id ASC", cmb_pais)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            frm_main._cnn.Close()
        End Try
    End Sub

    


    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            frm_main._cnn.Open()
            Dim sql As String = "insert into aeropuerto(nombre, cod_ciud ) values('" + txt_aerop.Text + "' , " & cmb_ciudad.SelectedValue & ")"
            frm_main._cmd = New OracleCommand(sql, frm_main._cnn)
            frm_main._cmd.ExecuteNonQuery()
            txt_aerop.Text = ""
            MsgBox("Datos insertados correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            frm_main._cnn.Close()

        End Try
    End Sub

    Private Sub cmb_ciudad_GotFocus(sender As Object, e As EventArgs) Handles cmb_ciudad.GotFocus
        Try
            frm_main._cnn.Open()
            _LLENAR_CMB2("select cod_ciud as id, nombre from ciudad where cod_pa = " & cmb_pais.SelectedValue & " order by id ASC ", cmb_ciudad)
            If cmb_ciudad.Items.Count = 0 Then
                cmb_ciudad.DisplayMember = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            frm_main._cnn.Close()
        End Try
    End Sub

   
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class