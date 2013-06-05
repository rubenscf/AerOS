<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrl_login
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.lbl_pass = New System.Windows.Forms.Label()
        Me.lbl_sts = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.ForeColor = System.Drawing.Color.White
        Me.lbl_usuario.Location = New System.Drawing.Point(21, 52)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(43, 13)
        Me.lbl_usuario.TabIndex = 5
        Me.lbl_usuario.Text = "Usuario"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(88, 52)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(100, 20)
        Me.txt_usuario.TabIndex = 0
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(88, 83)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(183)
        Me.txt_pass.Size = New System.Drawing.Size(100, 20)
        Me.txt_pass.TabIndex = 1
        '
        'lbl_pass
        '
        Me.lbl_pass.AutoSize = True
        Me.lbl_pass.ForeColor = System.Drawing.Color.White
        Me.lbl_pass.Location = New System.Drawing.Point(21, 86)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(61, 13)
        Me.lbl_pass.TabIndex = 6
        Me.lbl_pass.Text = "Contraseña"
        '
        'lbl_sts
        '
        Me.lbl_sts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_sts.Location = New System.Drawing.Point(10, 158)
        Me.lbl_sts.Name = "lbl_sts"
        Me.lbl_sts.Size = New System.Drawing.Size(225, 53)
        Me.lbl_sts.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Image = Global.AerOS.My.Resources.Resources.lock_32
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 35)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Entrar al Sistema"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.SystemColors.Control
        Me.btn_login.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.Image = Global.AerOS.My.Resources.Resources.login_26
        Me.btn_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_login.Location = New System.Drawing.Point(88, 109)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(100, 42)
        Me.btn_login.TabIndex = 2
        Me.btn_login.Text = "ENTRAR"
        Me.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'ctrl_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.lbl_sts)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.lbl_pass)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Name = "ctrl_login"
        Me.Size = New System.Drawing.Size(238, 211)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents btn_login As System.Windows.Forms.Button
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents lbl_pass As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_sts As System.Windows.Forms.Label

End Class
