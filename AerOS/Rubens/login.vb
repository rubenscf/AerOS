Imports Oracle.DataAccess.Client
Public Class ctrl_login

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            frm_main._cnn.Open()
            Dim usuario As String = txt_usuario.Text
            Dim pass As String = txt_pass.Text
            Dim sql As String
            Dim contenedor As OracleDataReader
           
            sql = "SELECT COD_USUARIO, ADMIN FROM USUARIO WHERE NOMBRE = '" + usuario + "' AND PASS = '" + pass + "'"
            frm_main._cmd = New OracleCommand(sql, frm_main._cnn)
            contenedor = frm_main._cmd.ExecuteReader()
            While contenedor.Read()
                frm_main._cod_usuario = contenedor.GetInt32(0)
                frm_main._admin = contenedor.GetInt32(1)
            End While
            contenedor.Close()
            If frm_main._cod_usuario > 0 And frm_main._admin = 1 Then
                frm_main._cadmin = True
                frm_main._nombre = "Administrador del sistema"
                entrar()
            ElseIf frm_main._admin = 0 Then

                sql = "SELECT U.COD_USUARIO, C.COD_CLIE, C.PASAPORTE, C.NACIONALIDAD, C.NOMBRE, C.APELLIDO FROM USUARIO U INNER JOIN CLIENTE C ON C.COD_USUARIO = U.COD_USUARIO WHERE U.NOMBRE LIKE '" + usuario + "' and U.PASS like '" + pass + "' "
                frm_main._cmd = New OracleCommand(sql, frm_main._cnn)   'ejecuta la consulta de usuario y contraseña
                contenedor = frm_main._cmd.ExecuteReader()   ' el resultado de la ejecucion se la asigna a reader
                While contenedor.Read()                    'mientras encuentre datos en reader 
                    frm_main._cod_usuario = contenedor.GetInt32(0)  ' asigna el cod usuario encontrado a la variable id_usuario
                    frm_main._cod_clie = contenedor.GetInt32(1)
                    frm_main._passaporte = contenedor.GetString(2)
                    frm_main._nacionalidad = contenedor.GetString(3)
                    frm_main._nombre = contenedor.GetString(4)
                    frm_main._apellido = contenedor.GetString(5)
                End While                                       ' finaliza el ciclo 
                contenedor.Close()                                  'cierra el lector de resultados 
                ' MsgBox(frm_main._id_usuario) ' muestra el id de usuario en pantalla
                If frm_main._cod_usuario > 0 And frm_main._cod_clie > 0 Then 'si encuentra un usuario
                    frm_main._cliente = True
                    entrar()
                End If
            ElseIf frm_main._cod_clie = 0 Then

                sql = "SELECT P.NOMBRE, P.APELLIDO, P.COD_PERSO, P.NACIONALIDAD, U.COD_USUARIO, U.ADMIN, P.COD_LINE, P.COD_PRO FROM AERO.PERSONAL P INNER JOIN AERO.USUARIO U ON P.COD_USUARIO = U.COD_USUARIO WHERE P.NOMBRE LIKE '" + usuario + "' AND U.PASS LIKE '" + pass + "'"
                frm_main._cmd = New OracleCommand(sql, frm_main._cnn)   'ejecuta la consulta de usuario y contraseña
                contenedor = frm_main._cmd.ExecuteReader()   ' el resultado de la ejecucion se la asigna a reader
                While contenedor.Read()                    'mientras encuentre datos en reader 
                    frm_main._nombre = contenedor.GetInt32(0)
                    frm_main._apellido = contenedor.GetInt32(1)
                    frm_main._cod_perso = contenedor.GetInt32(2)
                    frm_main._nacionalidad = contenedor.GetInt32(3)
                    frm_main._cod_usuario = contenedor.GetInt32(4)
                    frm_main._admin = contenedor.GetInt32(5)
                    frm_main._cod_line = contenedor.GetInt32(6)
                    frm_main._cod_pro = contenedor.GetInt32(7)

                End While                                       ' finaliza el ciclo 
                contenedor.Close()                                  'cierra el lector de resultados 
                ' MsgBox(frm_main._id_usuario) ' muestra el id de usuario en pantalla
                If frm_main._cod_usuario > 0 And frm_main._cod_pro > 0 Then 'si encuentra un trbajador
                    If frm_main._cod_pro = 1 Then
                        frm_main._adtrabajador = True

                    Else
                        frm_main._trabajador = True
                    End If
                    entrar()
                End If
            End If
            If (frm_main._cadmin = False) And (frm_main._cliente = False) And (frm_main._adtrabajador = False) And (frm_main._trabajador = False) Then
                lbl_sts.Text = "Combinacion incorrecta de usuario y contraseña"
            End If
        Catch ex As Exception
            lbl_sts.Text = ex.Message   ' si encuentra algun error lo muestra en un mensajen de texto
        Finally
            frm_main._cnn.Close()   ' cerra la conexion pase lo q pase
        End Try
    End Sub
    Sub entrar()
        frm_main.Ctrl_login1.txt_usuario.Text = ""   'borra el usuario ingresado de la caja de texto del login
        frm_main.Ctrl_login1.txt_pass.Text = ""     'borra la contraseña ingresado de la caja de texto del login
        frm_main.Ctrl_login1.Hide()                 'oculta la caja de login
        frm_main.Perfil1.Refresh()
        frm_main.Perfil1.Show()
        frm_main.Perfil1.lbl_nombre.Text = "Bienvenido, " & frm_main._nombre
        frm_main.MenuAdmin.Visible = True
        If frm_main._cadmin Then
            frm_main.UBICACIONToolStripMenuItem.Visible = True
            frm_main.AEROLINEAToolStripMenuItem.Visible = True
            frm_main.VUELOSToolStripMenuItem.Visible = True
            frm_main.CLIENTESToolStripMenuItem.Visible = True
            frm_main.BOLETOSToolStripMenuItem.Visible = True
            frm_main.TORRESDECONTROLToolStripMenuItem.Visible = True
        ElseIf frm_main._adtrabajador Then
            frm_main.AEROLINEAToolStripMenuItem.Visible = True
            frm_main.VUELOSToolStripMenuItem.Visible = True
            frm_main.TORRESDECONTROLToolStripMenuItem.Visible = True
        ElseIf frm_main._cliente Then
            frm_main.MICUENTAToolStripMenuItem.Visible = True
        ElseIf frm_main._trabajador Then
            frm_main.CUENTAToolStripMenuItem.Visible = True
        End If
    End Sub

    Private Sub ctrl_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub txt_pass_TextChanged(sender As Object, e As EventArgs) Handles txt_pass.TextChanged
        lbl_sts.Text = ""
    End Sub

    Private Sub txt_usuario_TextChanged(sender As Object, e As EventArgs) Handles txt_usuario.TextChanged
        lbl_sts.Text = ""
    End Sub
End Class
