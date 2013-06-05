<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
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
        Me.MenuAdmin = New System.Windows.Forms.MenuStrip()
        Me.UBICACIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CiudadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AeropuertoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AEROLINEAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VUELOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INSCRIBIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HISTORIALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BOLETOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TORRESDECONTROLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MICUENTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SOLICITARBOLETOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HISTORIALDEVUELOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PERFILToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CUENTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MISTURNOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HISTORIALDEVUELOToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PERFILToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Ds = New AerOS.Ds()
        Me.CLIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLIENTETableAdapter = New AerOS.DsTableAdapters.CLIENTETableAdapter()
        Me.TableAdapterManager = New AerOS.DsTableAdapters.TableAdapterManager()
        Me.Ctrl_login1 = New AerOS.ctrl_login()
        Me.Perfil1 = New AerOS.perfil()
        Me.MenuAdmin.SuspendLayout()
        CType(Me.Ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuAdmin
        '
        Me.MenuAdmin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UBICACIONToolStripMenuItem, Me.AEROLINEAToolStripMenuItem, Me.VUELOSToolStripMenuItem, Me.CLIENTESToolStripMenuItem, Me.BOLETOSToolStripMenuItem, Me.TORRESDECONTROLToolStripMenuItem, Me.MICUENTAToolStripMenuItem, Me.CUENTAToolStripMenuItem})
        Me.MenuAdmin.Location = New System.Drawing.Point(0, 0)
        Me.MenuAdmin.Name = "MenuAdmin"
        Me.MenuAdmin.Size = New System.Drawing.Size(733, 24)
        Me.MenuAdmin.TabIndex = 1
        Me.MenuAdmin.Text = "MenuStrip1"
        '
        'UBICACIONToolStripMenuItem
        '
        Me.UBICACIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaisToolStripMenuItem, Me.CiudadToolStripMenuItem, Me.AeropuertoToolStripMenuItem})
        Me.UBICACIONToolStripMenuItem.Name = "UBICACIONToolStripMenuItem"
        Me.UBICACIONToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.UBICACIONToolStripMenuItem.Text = "UBICACION"
        '
        'PaisToolStripMenuItem
        '
        Me.PaisToolStripMenuItem.Name = "PaisToolStripMenuItem"
        Me.PaisToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.PaisToolStripMenuItem.Text = "Pais"
        '
        'CiudadToolStripMenuItem
        '
        Me.CiudadToolStripMenuItem.Name = "CiudadToolStripMenuItem"
        Me.CiudadToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.CiudadToolStripMenuItem.Text = "Ciudad"
        '
        'AeropuertoToolStripMenuItem
        '
        Me.AeropuertoToolStripMenuItem.Name = "AeropuertoToolStripMenuItem"
        Me.AeropuertoToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.AeropuertoToolStripMenuItem.Text = "Aeropuerto"
        '
        'AEROLINEAToolStripMenuItem
        '
        Me.AEROLINEAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpresaToolStripMenuItem, Me.PersonalToolStripMenuItem, Me.AvionToolStripMenuItem, Me.TurnosToolStripMenuItem})
        Me.AEROLINEAToolStripMenuItem.Name = "AEROLINEAToolStripMenuItem"
        Me.AEROLINEAToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.AEROLINEAToolStripMenuItem.Text = "AEROLINEA"
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EmpresaToolStripMenuItem.Text = "Empresa"
        '
        'PersonalToolStripMenuItem
        '
        Me.PersonalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.ConsultarActualizarToolStripMenuItem, Me.HistorialToolStripMenuItem2})
        Me.PersonalToolStripMenuItem.Name = "PersonalToolStripMenuItem"
        Me.PersonalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PersonalToolStripMenuItem.Text = "Personal"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.AgregarToolStripMenuItem.Text = "Nuevo"
        '
        'ConsultarActualizarToolStripMenuItem
        '
        Me.ConsultarActualizarToolStripMenuItem.Name = "ConsultarActualizarToolStripMenuItem"
        Me.ConsultarActualizarToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ConsultarActualizarToolStripMenuItem.Text = "Consultar / Actualizar"
        '
        'HistorialToolStripMenuItem2
        '
        Me.HistorialToolStripMenuItem2.Name = "HistorialToolStripMenuItem2"
        Me.HistorialToolStripMenuItem2.Size = New System.Drawing.Size(188, 22)
        Me.HistorialToolStripMenuItem2.Text = "Historial"
        '
        'AvionToolStripMenuItem
        '
        Me.AvionToolStripMenuItem.Name = "AvionToolStripMenuItem"
        Me.AvionToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AvionToolStripMenuItem.Text = "Aviones"
        '
        'TurnosToolStripMenuItem
        '
        Me.TurnosToolStripMenuItem.Name = "TurnosToolStripMenuItem"
        Me.TurnosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TurnosToolStripMenuItem.Text = "Turnos"
        '
        'VUELOSToolStripMenuItem
        '
        Me.VUELOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramasToolStripMenuItem, Me.ConsultarToolStripMenuItem})
        Me.VUELOSToolStripMenuItem.Name = "VUELOSToolStripMenuItem"
        Me.VUELOSToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.VUELOSToolStripMenuItem.Text = "VUELOS"
        '
        'ProgramasToolStripMenuItem
        '
        Me.ProgramasToolStripMenuItem.Name = "ProgramasToolStripMenuItem"
        Me.ProgramasToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ProgramasToolStripMenuItem.Text = "Nuevos Programas"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'CLIENTESToolStripMenuItem
        '
        Me.CLIENTESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INSCRIBIRToolStripMenuItem, Me.HISTORIALToolStripMenuItem, Me.HistorialToolStripMenuItem1})
        Me.CLIENTESToolStripMenuItem.Name = "CLIENTESToolStripMenuItem"
        Me.CLIENTESToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.CLIENTESToolStripMenuItem.Text = "CLIENTES"
        '
        'INSCRIBIRToolStripMenuItem
        '
        Me.INSCRIBIRToolStripMenuItem.Name = "INSCRIBIRToolStripMenuItem"
        Me.INSCRIBIRToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.INSCRIBIRToolStripMenuItem.Text = "Nuevos"
        '
        'HISTORIALToolStripMenuItem
        '
        Me.HISTORIALToolStripMenuItem.Name = "HISTORIALToolStripMenuItem"
        Me.HISTORIALToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.HISTORIALToolStripMenuItem.Text = "Consultar  / Actualizar"
        '
        'HistorialToolStripMenuItem1
        '
        Me.HistorialToolStripMenuItem1.Name = "HistorialToolStripMenuItem1"
        Me.HistorialToolStripMenuItem1.Size = New System.Drawing.Size(191, 22)
        Me.HistorialToolStripMenuItem1.Text = "Historial"
        '
        'BOLETOSToolStripMenuItem
        '
        Me.BOLETOSToolStripMenuItem.Name = "BOLETOSToolStripMenuItem"
        Me.BOLETOSToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.BOLETOSToolStripMenuItem.Text = "BOLETOS"
        '
        'TORRESDECONTROLToolStripMenuItem
        '
        Me.TORRESDECONTROLToolStripMenuItem.Name = "TORRESDECONTROLToolStripMenuItem"
        Me.TORRESDECONTROLToolStripMenuItem.Size = New System.Drawing.Size(136, 20)
        Me.TORRESDECONTROLToolStripMenuItem.Text = "TORRES DE CONTROL"
        '
        'MICUENTAToolStripMenuItem
        '
        Me.MICUENTAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SOLICITARBOLETOToolStripMenuItem, Me.HISTORIALDEVUELOToolStripMenuItem, Me.PERFILToolStripMenuItem})
        Me.MICUENTAToolStripMenuItem.Name = "MICUENTAToolStripMenuItem"
        Me.MICUENTAToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.MICUENTAToolStripMenuItem.Text = "MI CUENTA"
        '
        'SOLICITARBOLETOToolStripMenuItem
        '
        Me.SOLICITARBOLETOToolStripMenuItem.Name = "SOLICITARBOLETOToolStripMenuItem"
        Me.SOLICITARBOLETOToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.SOLICITARBOLETOToolStripMenuItem.Text = "Solicitar Boleto"
        '
        'HISTORIALDEVUELOToolStripMenuItem
        '
        Me.HISTORIALDEVUELOToolStripMenuItem.Name = "HISTORIALDEVUELOToolStripMenuItem"
        Me.HISTORIALDEVUELOToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.HISTORIALDEVUELOToolStripMenuItem.Text = "Historial de vuelo"
        '
        'PERFILToolStripMenuItem
        '
        Me.PERFILToolStripMenuItem.Name = "PERFILToolStripMenuItem"
        Me.PERFILToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.PERFILToolStripMenuItem.Text = "Perfil"
        '
        'CUENTAToolStripMenuItem
        '
        Me.CUENTAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MISTURNOSToolStripMenuItem, Me.HISTORIALDEVUELOToolStripMenuItem1, Me.PERFILToolStripMenuItem1})
        Me.CUENTAToolStripMenuItem.Name = "CUENTAToolStripMenuItem"
        Me.CUENTAToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.CUENTAToolStripMenuItem.Text = "CUENTA"
        '
        'MISTURNOSToolStripMenuItem
        '
        Me.MISTURNOSToolStripMenuItem.Name = "MISTURNOSToolStripMenuItem"
        Me.MISTURNOSToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.MISTURNOSToolStripMenuItem.Text = "Proximo Turno"
        '
        'HISTORIALDEVUELOToolStripMenuItem1
        '
        Me.HISTORIALDEVUELOToolStripMenuItem1.Name = "HISTORIALDEVUELOToolStripMenuItem1"
        Me.HISTORIALDEVUELOToolStripMenuItem1.Size = New System.Drawing.Size(166, 22)
        Me.HISTORIALDEVUELOToolStripMenuItem1.Text = "Historial de vuelo"
        '
        'PERFILToolStripMenuItem1
        '
        Me.PERFILToolStripMenuItem1.Name = "PERFILToolStripMenuItem1"
        Me.PERFILToolStripMenuItem1.Size = New System.Drawing.Size(166, 22)
        Me.PERFILToolStripMenuItem1.Text = "Perfil"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Ds
        '
        Me.Ds.DataSetName = "Ds"
        Me.Ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CLIENTEBindingSource
        '
        Me.CLIENTEBindingSource.DataMember = "CLIENTE"
        Me.CLIENTEBindingSource.DataSource = Me.Ds
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
        'Ctrl_login1
        '
        Me.Ctrl_login1.BackColor = System.Drawing.Color.Transparent
        Me.Ctrl_login1.Location = New System.Drawing.Point(433, 103)
        Me.Ctrl_login1.Name = "Ctrl_login1"
        Me.Ctrl_login1.Size = New System.Drawing.Size(295, 214)
        Me.Ctrl_login1.TabIndex = 0
        '
        'Perfil1
        '
        Me.Perfil1.BackColor = System.Drawing.Color.Transparent
        Me.Perfil1.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Perfil1.Location = New System.Drawing.Point(413, 41)
        Me.Perfil1.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Perfil1.Name = "Perfil1"
        Me.Perfil1.Size = New System.Drawing.Size(320, 345)
        Me.Perfil1.TabIndex = 2
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AerOS.My.Resources.Resources.bg_main_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(733, 385)
        Me.Controls.Add(Me.Ctrl_login1)
        Me.Controls.Add(Me.MenuAdmin)
        Me.Controls.Add(Me.Perfil1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuAdmin
        Me.Name = "frm_main"
        Me.Text = "AerOS"
        Me.MenuAdmin.ResumeLayout(False)
        Me.MenuAdmin.PerformLayout()
        CType(Me.Ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuAdmin As System.Windows.Forms.MenuStrip
    Friend WithEvents UBICACIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CiudadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AeropuertoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AEROLINEAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpresaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AvionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VUELOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgramasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CLIENTESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents INSCRIBIRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HISTORIALToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistorialToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistorialToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TurnosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BOLETOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Ctrl_login1 As AerOS.ctrl_login
    Friend WithEvents MICUENTAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SOLICITARBOLETOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HISTORIALDEVUELOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PERFILToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TORRESDECONTROLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CUENTAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MISTURNOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HISTORIALDEVUELOToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PERFILToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Perfil1 As AerOS.perfil
    Friend WithEvents Ds As AerOS.Ds
    Friend WithEvents CLIENTEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CLIENTETableAdapter As AerOS.DsTableAdapters.CLIENTETableAdapter
    Friend WithEvents TableAdapterManager As AerOS.DsTableAdapters.TableAdapterManager

End Class
