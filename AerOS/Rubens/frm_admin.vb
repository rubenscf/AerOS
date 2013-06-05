Public Class frm_admin

    Private Sub frm_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(frm_main._cnn.ServerVersion)
    End Sub
End Class