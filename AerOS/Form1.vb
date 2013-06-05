Imports Oracle.DataAccess.Client
Public Class frm_main

    'declaracion de variables para la conexion a la base de datos
    Public _strcnn As String = "DATA SOURCE=;PERSIST SECURITY INFO=True;USER ID=AERO;Password=sistemas;"
    Public _cnn As New OracleConnection(_strcnn)
    Public _cmd As New OracleCommand

    'variables de contenedoras
    Public _cod_usuario, _admin, _cod_clie, _cod_pro, _cod_line, _cod_perso As Integer
    Public _nombre, _apellido, _passaporte, _nacionalidad As String

    'Declaracion de variables de session
    Public _trabajador As Boolean = False
    Public _adtrabajador As Boolean = False
    Public _cajero As Boolean = False
    Public _cliente As Boolean = False
    Public _cadmin As Boolean = False

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ds.CLIENTE' Puede moverla o quitarla según sea necesario.
        Me.CLIENTETableAdapter.Fill(Me.Ds.CLIENTE)
        Perfil1.Visible = False
        UBICACIONToolStripMenuItem.Visible = False
        AEROLINEAToolStripMenuItem.Visible = False
        VUELOSToolStripMenuItem.Visible = False
        CLIENTESToolStripMenuItem.Visible = False
        BOLETOSToolStripMenuItem.Visible = False
        CUENTAToolStripMenuItem.Visible = False
        MICUENTAToolStripMenuItem.Visible = False
        TORRESDECONTROLToolStripMenuItem.Visible = False
    End Sub


    Private Sub Ctrl_login1_Load(sender As Object, e As EventArgs) Handles Ctrl_login1.Load

    End Sub

    Private Sub INSCRIBIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INSCRIBIRToolStripMenuItem.Click
        frm_cliente.Show()
    End Sub

    Private Sub CLIENTEBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CLIENTEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ds)

    End Sub

    Private Sub PaisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaisToolStripMenuItem.Click
        frm_pais.Show()
    End Sub

    Private Sub CiudadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CiudadToolStripMenuItem.Click
        frm_ciudad.Show()
    End Sub

    Private Sub AeropuertoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AeropuertoToolStripMenuItem.Click
        frm_aeropuerto.Show()
    End Sub

    Private Sub ProgramasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramasToolStripMenuItem.Click
        frm_vuelo.Show()
    End Sub

    Private Sub PersonalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonalToolStripMenuItem.Click

    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        frm_personal.Show()
    End Sub

    Private Sub EmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresaToolStripMenuItem.Click
        frm_linea.Show()
    End Sub
End Class
