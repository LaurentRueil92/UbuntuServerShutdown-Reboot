<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIP1 = New System.Windows.Forms.TextBox()
        Me.txtIP2 = New System.Windows.Forms.TextBox()
        Me.txtIP3 = New System.Windows.Forms.TextBox()
        Me.txtIP4 = New System.Windows.Forms.TextBox()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxUser = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxPwd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxFolderPuTTY = New System.Windows.Forms.TextBox()
        Me.ButtonBrowsePuTTY = New System.Windows.Forms.Button()
        Me.ButtonShutdown = New System.Windows.Forms.Button()
        Me.LabelPuTTYCommand = New System.Windows.Forms.Label()
        Me.CheckBoxKeepOpened = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ShutdownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveSettignsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonReboot = New System.Windows.Forms.Button()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CréerRaccourcisShutdownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CréerRaccourcisRebootSurLeBureauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IP                               .               .               ."
        '
        'txtIP1
        '
        Me.txtIP1.Location = New System.Drawing.Point(81, 32)
        Me.txtIP1.MaxLength = 3
        Me.txtIP1.Name = "txtIP1"
        Me.txtIP1.Size = New System.Drawing.Size(31, 20)
        Me.txtIP1.TabIndex = 1
        Me.txtIP1.Tag = ""
        Me.txtIP1.Text = "192"
        '
        'txtIP2
        '
        Me.txtIP2.Location = New System.Drawing.Point(130, 32)
        Me.txtIP2.MaxLength = 3
        Me.txtIP2.Name = "txtIP2"
        Me.txtIP2.Size = New System.Drawing.Size(31, 20)
        Me.txtIP2.TabIndex = 2
        Me.txtIP2.Tag = ""
        Me.txtIP2.Text = "168"
        '
        'txtIP3
        '
        Me.txtIP3.Location = New System.Drawing.Point(180, 32)
        Me.txtIP3.MaxLength = 3
        Me.txtIP3.Name = "txtIP3"
        Me.txtIP3.Size = New System.Drawing.Size(31, 20)
        Me.txtIP3.TabIndex = 3
        Me.txtIP3.Tag = ""
        Me.txtIP3.Text = "1"
        '
        'txtIP4
        '
        Me.txtIP4.Location = New System.Drawing.Point(231, 32)
        Me.txtIP4.MaxLength = 3
        Me.txtIP4.Name = "txtIP4"
        Me.txtIP4.Size = New System.Drawing.Size(31, 20)
        Me.txtIP4.TabIndex = 4
        Me.txtIP4.Tag = ""
        Me.txtIP4.Text = "1"
        '
        'txtIP
        '
        Me.txtIP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIP.Location = New System.Drawing.Point(294, 32)
        Me.txtIP.MaxLength = 15
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(77, 20)
        Me.txtIP.TabIndex = 7
        Me.txtIP.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Lunit user"
        '
        'TextBoxUser
        '
        Me.TextBoxUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxUser.Location = New System.Drawing.Point(81, 66)
        Me.TextBoxUser.MaxLength = 32
        Me.TextBoxUser.Name = "TextBoxUser"
        Me.TextBoxUser.Size = New System.Drawing.Size(290, 20)
        Me.TextBoxUser.TabIndex = 9
        Me.TextBoxUser.Text = "lunit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Password"
        '
        'TextBoxPwd
        '
        Me.TextBoxPwd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxPwd.Location = New System.Drawing.Point(81, 96)
        Me.TextBoxPwd.MaxLength = 32
        Me.TextBoxPwd.Name = "TextBoxPwd"
        Me.TextBoxPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
        Me.TextBoxPwd.Size = New System.Drawing.Size(290, 20)
        Me.TextBoxPwd.TabIndex = 11
        Me.TextBoxPwd.Text = "fcr-iip"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "PuTTY"
        '
        'TextBoxFolderPuTTY
        '
        Me.TextBoxFolderPuTTY.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxFolderPuTTY.Location = New System.Drawing.Point(81, 131)
        Me.TextBoxFolderPuTTY.MaxLength = 32
        Me.TextBoxFolderPuTTY.Name = "TextBoxFolderPuTTY"
        Me.TextBoxFolderPuTTY.Size = New System.Drawing.Size(247, 20)
        Me.TextBoxFolderPuTTY.TabIndex = 13
        Me.TextBoxFolderPuTTY.Text = "C:\Program Files\PuTTY"
        '
        'ButtonBrowsePuTTY
        '
        Me.ButtonBrowsePuTTY.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonBrowsePuTTY.Location = New System.Drawing.Point(334, 132)
        Me.ButtonBrowsePuTTY.Name = "ButtonBrowsePuTTY"
        Me.ButtonBrowsePuTTY.Size = New System.Drawing.Size(37, 23)
        Me.ButtonBrowsePuTTY.TabIndex = 14
        Me.ButtonBrowsePuTTY.Text = "..."
        Me.ButtonBrowsePuTTY.UseVisualStyleBackColor = True
        '
        'ButtonShutdown
        '
        Me.ButtonShutdown.Location = New System.Drawing.Point(81, 191)
        Me.ButtonShutdown.Name = "ButtonShutdown"
        Me.ButtonShutdown.Size = New System.Drawing.Size(75, 31)
        Me.ButtonShutdown.TabIndex = 15
        Me.ButtonShutdown.Text = "Shutdown"
        Me.ButtonShutdown.UseVisualStyleBackColor = True
        '
        'LabelPuTTYCommand
        '
        Me.LabelPuTTYCommand.AutoSize = True
        Me.LabelPuTTYCommand.Location = New System.Drawing.Point(12, 187)
        Me.LabelPuTTYCommand.Name = "LabelPuTTYCommand"
        Me.LabelPuTTYCommand.Size = New System.Drawing.Size(39, 13)
        Me.LabelPuTTYCommand.TabIndex = 16
        Me.LabelPuTTYCommand.Text = "Label5"
        Me.LabelPuTTYCommand.Visible = False
        '
        'CheckBoxKeepOpened
        '
        Me.CheckBoxKeepOpened.AutoSize = True
        Me.CheckBoxKeepOpened.Checked = True
        Me.CheckBoxKeepOpened.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxKeepOpened.Location = New System.Drawing.Point(84, 163)
        Me.CheckBoxKeepOpened.Name = "CheckBoxKeepOpened"
        Me.CheckBoxKeepOpened.Size = New System.Drawing.Size(205, 17)
        Me.CheckBoxKeepOpened.TabIndex = 17
        Me.CheckBoxKeepOpened.Text = "Debug : Keep Command Prompt open"
        Me.CheckBoxKeepOpened.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShutdownToolStripMenuItem, Me.ConfigToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(396, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ShutdownToolStripMenuItem
        '
        Me.ShutdownToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ToolStripMenuItem1, Me.QuitToolStripMenuItem})
        Me.ShutdownToolStripMenuItem.Name = "ShutdownToolStripMenuItem"
        Me.ShutdownToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ShutdownToolStripMenuItem.Text = "Shutdown"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(104, 6)
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'ConfigToolStripMenuItem
        '
        Me.ConfigToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveSettignsToolStripMenuItem, Me.ToolStripMenuItem2, Me.CréerRaccourcisShutdownToolStripMenuItem, Me.CréerRaccourcisRebootSurLeBureauToolStripMenuItem})
        Me.ConfigToolStripMenuItem.Name = "ConfigToolStripMenuItem"
        Me.ConfigToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ConfigToolStripMenuItem.Text = "Config"
        '
        'SaveSettignsToolStripMenuItem
        '
        Me.SaveSettignsToolStripMenuItem.Name = "SaveSettignsToolStripMenuItem"
        Me.SaveSettignsToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.SaveSettignsToolStripMenuItem.Text = "Save Settigns"
        '
        'ButtonReboot
        '
        Me.ButtonReboot.Location = New System.Drawing.Point(296, 191)
        Me.ButtonReboot.Name = "ButtonReboot"
        Me.ButtonReboot.Size = New System.Drawing.Size(75, 31)
        Me.ButtonReboot.TabIndex = 19
        Me.ButtonReboot.Text = "Reboot"
        Me.ButtonReboot.UseVisualStyleBackColor = True
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(287, 6)
        '
        'CréerRaccourcisShutdownToolStripMenuItem
        '
        Me.CréerRaccourcisShutdownToolStripMenuItem.Name = "CréerRaccourcisShutdownToolStripMenuItem"
        Me.CréerRaccourcisShutdownToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.CréerRaccourcisShutdownToolStripMenuItem.Text = "Créer Raccourci Shutdown sur le Bureau"
        '
        'CréerRaccourcisRebootSurLeBureauToolStripMenuItem
        '
        Me.CréerRaccourcisRebootSurLeBureauToolStripMenuItem.Name = "CréerRaccourcisRebootSurLeBureauToolStripMenuItem"
        Me.CréerRaccourcisRebootSurLeBureauToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.CréerRaccourcisRebootSurLeBureauToolStripMenuItem.Text = "Créer Raccourci Reboot sur le Bureau"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 230)
        Me.Controls.Add(Me.ButtonReboot)
        Me.Controls.Add(Me.CheckBoxKeepOpened)
        Me.Controls.Add(Me.LabelPuTTYCommand)
        Me.Controls.Add(Me.ButtonShutdown)
        Me.Controls.Add(Me.ButtonBrowsePuTTY)
        Me.Controls.Add(Me.TextBoxFolderPuTTY)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxPwd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.txtIP4)
        Me.Controls.Add(Me.txtIP3)
        Me.Controls.Add(Me.txtIP2)
        Me.Controls.Add(Me.txtIP1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(412, 269)
        Me.MinimumSize = New System.Drawing.Size(412, 269)
        Me.Name = "Form1"
        Me.Text = "Shutdown Lunit by L. MOLINA - 2022"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIP1 As TextBox
    Friend WithEvents txtIP2 As TextBox
    Friend WithEvents txtIP3 As TextBox
    Friend WithEvents txtIP4 As TextBox
    Friend WithEvents txtIP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxUser As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxPwd As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxFolderPuTTY As TextBox
    Friend WithEvents ButtonBrowsePuTTY As Button
    Friend WithEvents ButtonShutdown As Button
    Friend WithEvents LabelPuTTYCommand As Label
    Friend WithEvents CheckBoxKeepOpened As CheckBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ShutdownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveSettignsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonReboot As Button
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents CréerRaccourcisShutdownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CréerRaccourcisRebootSurLeBureauToolStripMenuItem As ToolStripMenuItem
End Class
