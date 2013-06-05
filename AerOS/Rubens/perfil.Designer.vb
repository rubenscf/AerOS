<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class perfil
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
        Me.lbl_bienv = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_logout = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_bienv
        '
        Me.lbl_bienv.AutoSize = True
        Me.lbl_bienv.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_bienv.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!)
        Me.lbl_bienv.ForeColor = System.Drawing.Color.White
        Me.lbl_bienv.Location = New System.Drawing.Point(76, 104)
        Me.lbl_bienv.Name = "lbl_bienv"
        Me.lbl_bienv.Size = New System.Drawing.Size(95, 23)
        Me.lbl_bienv.TabIndex = 1
        Me.lbl_bienv.Text = "Bienvenido,"
        Me.lbl_bienv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(320, 345)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.White
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 18
        Me.LineShape1.X2 = 326
        Me.LineShape1.Y1 = 93
        Me.LineShape1.Y2 = 93
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbl1.ForeColor = System.Drawing.Color.Silver
        Me.lbl1.Location = New System.Drawing.Point(77, 143)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(49, 19)
        Me.lbl1.TabIndex = 5
        Me.lbl1.Text = "Label1"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbl2.ForeColor = System.Drawing.Color.Silver
        Me.lbl2.Location = New System.Drawing.Point(77, 176)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(49, 19)
        Me.lbl2.TabIndex = 6
        Me.lbl2.Text = "Label1"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbl3.ForeColor = System.Drawing.Color.Silver
        Me.lbl3.Location = New System.Drawing.Point(77, 207)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(49, 19)
        Me.lbl3.TabIndex = 7
        Me.lbl3.Text = "Label1"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Segoe UI Semilight", 13.75!)
        Me.lbl_nombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_nombre.Location = New System.Drawing.Point(76, 59)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(63, 25)
        Me.lbl_nombre.TabIndex = 4
        Me.lbl_nombre.Text = "Label1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AerOS.My.Resources.Resources.Personal
        Me.PictureBox1.Location = New System.Drawing.Point(18, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'lbl_logout
        '
        Me.lbl_logout.BackColor = System.Drawing.Color.Tomato
        Me.lbl_logout.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_logout.ForeColor = System.Drawing.Color.Black
        Me.lbl_logout.Image = Global.AerOS.My.Resources.Resources.logout_8
        Me.lbl_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_logout.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_logout.Location = New System.Drawing.Point(204, 284)
        Me.lbl_logout.Name = "lbl_logout"
        Me.lbl_logout.Size = New System.Drawing.Size(116, 61)
        Me.lbl_logout.TabIndex = 2
        Me.lbl_logout.TabStop = True
        Me.lbl_logout.Text = "SALIR"
        Me.lbl_logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'perfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_logout)
        Me.Controls.Add(Me.lbl_bienv)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "perfil"
        Me.Size = New System.Drawing.Size(320, 345)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_bienv As System.Windows.Forms.Label
    Friend WithEvents lbl_logout As System.Windows.Forms.LinkLabel
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
