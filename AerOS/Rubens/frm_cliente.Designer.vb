<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.components = New System.ComponentModel.Container()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.CLIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds = New AerOS.Ds()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_dpi = New System.Windows.Forms.Label()
        Me.txt_dpi = New System.Windows.Forms.TextBox()
        Me.txt_passaport = New System.Windows.Forms.TextBox()
        Me.lbl_passaport = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_fe = New System.Windows.Forms.DateTimePicker()
        Me.txt_nacional = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.CLIENTETableAdapter = New AerOS.DsTableAdapters.CLIENTETableAdapter()
        Me.TableAdapterManager = New AerOS.DsTableAdapters.TableAdapterManager()
        Me.lbl_sts = New System.Windows.Forms.Label()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(420, 374)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'CLIENTEBindingSource
        '
        Me.CLIENTEBindingSource.DataMember = "CLIENTE"
        Me.CLIENTEBindingSource.DataSource = Me.Ds
        '
        'Ds
        '
        Me.Ds.DataSetName = "Ds"
        Me.Ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.SkyBlue
        Me.LineShape2.BorderWidth = 50
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = -50
        Me.LineShape2.X2 = 435
        Me.LineShape2.Y1 = 280
        Me.LineShape2.Y2 = 280
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.SkyBlue
        Me.LineShape1.BorderWidth = 10
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -12
        Me.LineShape1.X2 = 529
        Me.LineShape1.Y1 = 54
        Me.LineShape1.Y2 = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SkyBlue
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.25!)
        Me.Label1.Location = New System.Drawing.Point(33, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "INSCRIBIR UN NUEVO CLIENTE"
        '
        'lbl_dpi
        '
        Me.lbl_dpi.AutoSize = True
        Me.lbl_dpi.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.lbl_dpi.ForeColor = System.Drawing.Color.White
        Me.lbl_dpi.Location = New System.Drawing.Point(36, 76)
        Me.lbl_dpi.Name = "lbl_dpi"
        Me.lbl_dpi.Size = New System.Drawing.Size(35, 19)
        Me.lbl_dpi.TabIndex = 3
        Me.lbl_dpi.Text = "DPI "
        '
        'txt_dpi
        '
        Me.txt_dpi.Location = New System.Drawing.Point(40, 98)
        Me.txt_dpi.Name = "txt_dpi"
        Me.txt_dpi.Size = New System.Drawing.Size(159, 22)
        Me.txt_dpi.TabIndex = 4
        '
        'txt_passaport
        '
        Me.txt_passaport.Location = New System.Drawing.Point(224, 98)
        Me.txt_passaport.Name = "txt_passaport"
        Me.txt_passaport.Size = New System.Drawing.Size(159, 22)
        Me.txt_passaport.TabIndex = 6
        '
        'lbl_passaport
        '
        Me.lbl_passaport.AutoSize = True
        Me.lbl_passaport.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.lbl_passaport.ForeColor = System.Drawing.Color.White
        Me.lbl_passaport.Location = New System.Drawing.Point(220, 76)
        Me.lbl_passaport.Name = "lbl_passaport"
        Me.lbl_passaport.Size = New System.Drawing.Size(83, 19)
        Me.lbl_passaport.TabIndex = 5
        Me.lbl_passaport.Text = "PASAPORTE"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(40, 156)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(159, 22)
        Me.txt_nombre.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(36, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nombre"
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(224, 156)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(159, 22)
        Me.txt_apellido.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(220, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(36, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Fecha de Nacimiento"
        '
        'txt_fe
        '
        Me.txt_fe.Location = New System.Drawing.Point(39, 214)
        Me.txt_fe.Name = "txt_fe"
        Me.txt_fe.Size = New System.Drawing.Size(160, 22)
        Me.txt_fe.TabIndex = 12
        '
        'txt_nacional
        '
        Me.txt_nacional.Location = New System.Drawing.Point(224, 214)
        Me.txt_nacional.Name = "txt_nacional"
        Me.txt_nacional.Size = New System.Drawing.Size(159, 22)
        Me.txt_nacional.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(220, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 19)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Nacionalidad"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(39, 279)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(159, 22)
        Me.txt_usuario.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.SkyBlue
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(35, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Usuario"
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(224, 279)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(159, 22)
        Me.txt_pass.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.SkyBlue
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(220, 257)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 19)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Contraseña"
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_agregar.Image = Global.AerOS.My.Resources.Resources.add_user_26
        Me.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_agregar.Location = New System.Drawing.Point(288, 318)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(95, 38)
        Me.btn_agregar.TabIndex = 19
        Me.btn_agregar.Text = "Inscribir"
        Me.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'CLIENTETableAdapter
        '
        Me.CLIENTETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AEROPUERTOTableAdapter = Nothing
        Me.TableAdapterManager.AVIONTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BOLETOTableAdapter = Nothing
        Me.TableAdapterManager.CIUDADTableAdapter = Nothing
        Me.TableAdapterManager.CLIENTETableAdapter = Me.CLIENTETableAdapter
        Me.TableAdapterManager.ESCALATableAdapter = Nothing
        Me.TableAdapterManager.LINEATableAdapter = Nothing
        Me.TableAdapterManager.PAISTableAdapter = Nothing
        Me.TableAdapterManager.PERSONALTableAdapter = Nothing
        Me.TableAdapterManager.PROFESIONTableAdapter = Nothing
        Me.TableAdapterManager.TURNOTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AerOS.DsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USUARIOTableAdapter = Nothing
        Me.TableAdapterManager.VUELOTableAdapter = Nothing
        '
        'lbl_sts
        '
        Me.lbl_sts.ForeColor = System.Drawing.Color.White
        Me.lbl_sts.Location = New System.Drawing.Point(37, 326)
        Me.lbl_sts.Name = "lbl_sts"
        Me.lbl_sts.Size = New System.Drawing.Size(164, 30)
        Me.lbl_sts.TabIndex = 20
        '
        'frm_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(420, 374)
        Me.Controls.Add(Me.lbl_sts)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_nacional)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_fe)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_passaport)
        Me.Controls.Add(Me.lbl_passaport)
        Me.Controls.Add(Me.txt_dpi)
        Me.Controls.Add(Me.lbl_dpi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_cliente"
        Me.Text = "Administracion de clientes"
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_dpi As System.Windows.Forms.Label
    Friend WithEvents txt_dpi As System.Windows.Forms.TextBox
    Friend WithEvents txt_passaport As System.Windows.Forms.TextBox
    Friend WithEvents lbl_passaport As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_fe As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_nacional As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents Ds As AerOS.Ds
    Friend WithEvents CLIENTEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CLIENTETableAdapter As AerOS.DsTableAdapters.CLIENTETableAdapter
    Friend WithEvents TableAdapterManager As AerOS.DsTableAdapters.TableAdapterManager
    Friend WithEvents lbl_sts As System.Windows.Forms.Label
End Class
