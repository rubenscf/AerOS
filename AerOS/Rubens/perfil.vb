Public Class perfil

    

    Private Sub lbl_logout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_logout.LinkClicked

        'variables de contenedoras
        frm_main._cod_usuario = 0
        frm_main._admin = 0
        frm_main._cod_clie = 0
        frm_main._cod_pro = 0
        frm_main._cod_line = 0
        frm_main._cod_perso = 0

        'Declaracion de variables de session
        frm_main._trabajador = False
        frm_main._adtrabajador = False
        frm_main._cajero = False
        frm_main._cliente = False
        frm_main._cadmin = False
        frm_main.Perfil1.Hide()
        frm_main.Ctrl_login1.Show()
        Me.lbl_nombre.Text = ""
        'menu del sistema
        frm_main.UBICACIONToolStripMenuItem.Visible = False
        frm_main.AEROLINEAToolStripMenuItem.Visible = False
        frm_main.VUELOSToolStripMenuItem.Visible = False
        frm_main.CLIENTESToolStripMenuItem.Visible = False
        frm_main.BOLETOSToolStripMenuItem.Visible = False
        frm_main.CUENTAToolStripMenuItem.Visible = False
        frm_main.MICUENTAToolStripMenuItem.Visible = False
        frm_main.TORRESDECONTROLToolStripMenuItem.Visible = False
    End Sub


  
   
    Private Sub perfil_Load(sender As Object, e As EventArgs) Handles MyBase.Paint
        lbl_nombre.Text = frm_main._nombre + frm_main._apellido
        If frm_main._cadmin Then
            lbl_bienv.Text = "Administrador"
            lbl1.Text = ""
            lbl2.Text = ""
            lbl3.Text = ""
        ElseIf frm_main._adtrabajador Then
            lbl_bienv.Text = "Administrador de Aerolinea"
            lbl1.Text = ""
            lbl2.Text = ""
            lbl3.Text = ""
        ElseIf frm_main._cliente Then
            lbl_bienv.Text = "Cliente"
            lbl1.Text = ""
            lbl2.Text = ""
            lbl3.Text = ""
        ElseIf frm_main._trabajador Then
            lbl_bienv.Text = "Trabajador de Aerolinea"
            lbl1.Text = ""
            lbl2.Text = ""
            lbl3.Text = ""
        End If
    End Sub


End Class
