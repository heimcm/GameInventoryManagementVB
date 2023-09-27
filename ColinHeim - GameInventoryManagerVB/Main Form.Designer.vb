<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lstBoxGames = New System.Windows.Forms.ListBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtPublisher = New System.Windows.Forms.TextBox()
        Me.chkSealed = New System.Windows.Forms.CheckBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpRegion = New System.Windows.Forms.GroupBox()
        Me.rdoPAL = New System.Windows.Forms.RadioButton()
        Me.rdoNTSC = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.grpRegion.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstBoxGames
        '
        Me.lstBoxGames.FormattingEnabled = True
        Me.lstBoxGames.ItemHeight = 20
        Me.lstBoxGames.Location = New System.Drawing.Point(16, 42)
        Me.lstBoxGames.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstBoxGames.Name = "lstBoxGames"
        Me.lstBoxGames.Size = New System.Drawing.Size(193, 324)
        Me.lstBoxGames.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(399, 41)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(219, 27)
        Me.txtName.TabIndex = 3
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(399, 78)
        Me.txtYear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(219, 27)
        Me.txtYear.TabIndex = 5
        '
        'txtPublisher
        '
        Me.txtPublisher.Location = New System.Drawing.Point(399, 115)
        Me.txtPublisher.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.Size = New System.Drawing.Size(219, 27)
        Me.txtPublisher.TabIndex = 7
        '
        'chkSealed
        '
        Me.chkSealed.AutoSize = True
        Me.chkSealed.BackColor = System.Drawing.Color.LightSteelBlue
        Me.chkSealed.Location = New System.Drawing.Point(417, 152)
        Me.chkSealed.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkSealed.Name = "chkSealed"
        Me.chkSealed.Size = New System.Drawing.Size(80, 24)
        Me.chkSealed.TabIndex = 8
        Me.chkSealed.Text = "S&ealed?"
        Me.chkSealed.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnAdd.Location = New System.Drawing.Point(479, 332)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(123, 35)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "Add &New item"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnUpdate.Location = New System.Drawing.Point(349, 332)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(121, 35)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnClear.Location = New System.Drawing.Point(219, 332)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(123, 35)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "&Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(631, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 19)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'grpRegion
        '
        Me.grpRegion.BackColor = System.Drawing.Color.LightSteelBlue
        Me.grpRegion.Controls.Add(Me.rdoPAL)
        Me.grpRegion.Controls.Add(Me.rdoNTSC)
        Me.grpRegion.Location = New System.Drawing.Point(417, 188)
        Me.grpRegion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpRegion.Name = "grpRegion"
        Me.grpRegion.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpRegion.Size = New System.Drawing.Size(147, 112)
        Me.grpRegion.TabIndex = 9
        Me.grpRegion.TabStop = False
        Me.grpRegion.Text = "Region"
        '
        'rdoPAL
        '
        Me.rdoPAL.AutoSize = True
        Me.rdoPAL.Location = New System.Drawing.Point(32, 65)
        Me.rdoPAL.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoPAL.Name = "rdoPAL"
        Me.rdoPAL.Size = New System.Drawing.Size(51, 24)
        Me.rdoPAL.TabIndex = 1
        Me.rdoPAL.TabStop = True
        Me.rdoPAL.Text = "P&AL"
        Me.rdoPAL.UseVisualStyleBackColor = True
        '
        'rdoNTSC
        '
        Me.rdoNTSC.AutoSize = True
        Me.rdoNTSC.Location = New System.Drawing.Point(32, 29)
        Me.rdoNTSC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoNTSC.Name = "rdoNTSC"
        Me.rdoNTSC.Size = New System.Drawing.Size(63, 24)
        Me.rdoNTSC.TabIndex = 0
        Me.rdoNTSC.TabStop = True
        Me.rdoNTSC.Text = "N&TSC"
        Me.rdoNTSC.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label1.Location = New System.Drawing.Point(355, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "&Year"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label2.Location = New System.Drawing.Point(323, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "&Publisher"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label3.Location = New System.Drawing.Point(300, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&Game Name"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnDelete.Location = New System.Drawing.Point(53, 374)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(118, 32)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "&Delete Item"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnExit.Location = New System.Drawing.Point(479, 375)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(123, 35)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(631, 418)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpRegion)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.chkSealed)
        Me.Controls.Add(Me.txtPublisher)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lstBoxGames)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Playstation 2 Game Collection"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpRegion.ResumeLayout(False)
        Me.grpRegion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstBoxGames As ListBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtPublisher As TextBox
    Friend WithEvents chkSealed As CheckBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grpRegion As GroupBox
    Friend WithEvents rdoPAL As RadioButton
    Friend WithEvents rdoNTSC As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExit As Button
End Class
