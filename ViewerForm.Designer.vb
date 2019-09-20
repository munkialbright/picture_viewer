<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewerForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewerForm))
        Me.mnuPictureContext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DrawBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ofdSelectPicture = New System.Windows.Forms.OpenFileDialog()
        Me.btnEnlarge = New System.Windows.Forms.Button()
        Me.btnShrink = New System.Windows.Forms.Button()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        Me.mnuMainMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpenPicture = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGetFileAttributesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConfirmOnExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRotate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDrawBorder = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuViewPictureLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbrMainToolbar = New System.Windows.Forms.ToolStrip()
        Me.tbbOpenPicture = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbbDrawBorder = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbbOptions = New System.Windows.Forms.ToolStripButton()
        Me.tbbGetFileAttributes = New System.Windows.Forms.ToolStripButton()
        Me.tbbShowLog = New System.Windows.Forms.ToolStripButton()
        Me.tbbRotate = New System.Windows.Forms.ToolStripButton()
        Me.tbbZoomOut = New System.Windows.Forms.ToolStripButton()
        Me.tbbZoomIn = New System.Windows.Forms.ToolStripButton()
        Me.sbrMyStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.picShowPicture = New System.Windows.Forms.PictureBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.mnuPictureContext.SuspendLayout()
        Me.mnuMainMenu.SuspendLayout()
        Me.tbrMainToolbar.SuspendLayout()
        Me.sbrMyStatusStrip.SuspendLayout()
        CType(Me.picShowPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuPictureContext
        '
        Me.mnuPictureContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DrawBorderToolStripMenuItem})
        Me.mnuPictureContext.Name = "mnuPictureContext"
        Me.mnuPictureContext.Size = New System.Drawing.Size(140, 26)
        '
        'DrawBorderToolStripMenuItem
        '
        Me.DrawBorderToolStripMenuItem.Name = "DrawBorderToolStripMenuItem"
        Me.DrawBorderToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.DrawBorderToolStripMenuItem.Text = "Draw Border"
        '
        'ofdSelectPicture
        '
        Me.ofdSelectPicture.Filter = "JPEG Files|*.JPG|PNG Files|*PNG|Windows Bitmaps|*.BMP|All Files|*.*"
        Me.ofdSelectPicture.Multiselect = True
        Me.ofdSelectPicture.RestoreDirectory = True
        Me.ofdSelectPicture.Title = "Select Picture"
        '
        'btnEnlarge
        '
        Me.btnEnlarge.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnlarge.Location = New System.Drawing.Point(339, 285)
        Me.btnEnlarge.Name = "btnEnlarge"
        Me.btnEnlarge.Size = New System.Drawing.Size(21, 23)
        Me.btnEnlarge.TabIndex = 6
        Me.btnEnlarge.Tag = ""
        Me.btnEnlarge.Text = "^"
        Me.btnEnlarge.UseVisualStyleBackColor = True
        '
        'btnShrink
        '
        Me.btnShrink.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShrink.Location = New System.Drawing.Point(360, 285)
        Me.btnShrink.Name = "btnShrink"
        Me.btnShrink.Size = New System.Drawing.Size(21, 23)
        Me.btnShrink.TabIndex = 7
        Me.btnShrink.Tag = ""
        Me.btnShrink.Text = "v"
        Me.btnShrink.UseVisualStyleBackColor = True
        '
        'lblX
        '
        Me.lblX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(336, 256)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(17, 13)
        Me.lblX.TabIndex = 3
        Me.lblX.Text = "X:"
        '
        'lblY
        '
        Me.lblY.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblY.AutoSize = True
        Me.lblY.Location = New System.Drawing.Point(336, 269)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(17, 13)
        Me.lblY.TabIndex = 4
        Me.lblY.Text = "Y:"
        '
        'mnuMainMenu
        '
        Me.mnuMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolToolStripMenuItem})
        Me.mnuMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMainMenu.Name = "mnuMainMenu"
        Me.mnuMainMenu.Size = New System.Drawing.Size(384, 24)
        Me.mnuMainMenu.TabIndex = 8
        Me.mnuMainMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpenPicture, Me.mnuGetFileAttributesToolStripMenuItem, Me.mnuConfirmOnExit, Me.mnuQuit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mnuOpenPicture
        '
        Me.mnuOpenPicture.Image = Global.Picture_Viewer.My.Resources.Resources.Open
        Me.mnuOpenPicture.Name = "mnuOpenPicture"
        Me.mnuOpenPicture.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuOpenPicture.Size = New System.Drawing.Size(209, 22)
        Me.mnuOpenPicture.Text = "&Open Picture"
        '
        'mnuGetFileAttributesToolStripMenuItem
        '
        Me.mnuGetFileAttributesToolStripMenuItem.Image = Global.Picture_Viewer.My.Resources.Resources.Properties
        Me.mnuGetFileAttributesToolStripMenuItem.Name = "mnuGetFileAttributesToolStripMenuItem"
        Me.mnuGetFileAttributesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuGetFileAttributesToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.mnuGetFileAttributesToolStripMenuItem.Text = "&Get File Attributes"
        '
        'mnuConfirmOnExit
        '
        Me.mnuConfirmOnExit.Checked = True
        Me.mnuConfirmOnExit.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuConfirmOnExit.Name = "mnuConfirmOnExit"
        Me.mnuConfirmOnExit.Size = New System.Drawing.Size(209, 22)
        Me.mnuConfirmOnExit.Text = "Confirm on Exit"
        '
        'mnuQuit
        '
        Me.mnuQuit.Name = "mnuQuit"
        Me.mnuQuit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.mnuQuit.Size = New System.Drawing.Size(209, 22)
        Me.mnuQuit.Text = "&Quit"
        '
        'ToolToolStripMenuItem
        '
        Me.ToolToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRotate, Me.mnuDrawBorder, Me.ToolStripSeparator1, Me.mnuViewPictureLogToolStripMenuItem, Me.mnuOptions})
        Me.ToolToolStripMenuItem.Name = "ToolToolStripMenuItem"
        Me.ToolToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.ToolToolStripMenuItem.Text = "&Tool"
        '
        'mnuRotate
        '
        Me.mnuRotate.Image = Global.Picture_Viewer.My.Resources.Resources.rotate
        Me.mnuRotate.Name = "mnuRotate"
        Me.mnuRotate.Size = New System.Drawing.Size(202, 22)
        Me.mnuRotate.Text = "&Rotate Image"
        '
        'mnuDrawBorder
        '
        Me.mnuDrawBorder.Image = Global.Picture_Viewer.My.Resources.Resources.DrawBorder
        Me.mnuDrawBorder.Name = "mnuDrawBorder"
        Me.mnuDrawBorder.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.mnuDrawBorder.Size = New System.Drawing.Size(202, 22)
        Me.mnuDrawBorder.Text = "&Draw Border"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(199, 6)
        '
        'mnuViewPictureLogToolStripMenuItem
        '
        Me.mnuViewPictureLogToolStripMenuItem.Image = Global.Picture_Viewer.My.Resources.Resources.Log
        Me.mnuViewPictureLogToolStripMenuItem.Name = "mnuViewPictureLogToolStripMenuItem"
        Me.mnuViewPictureLogToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.mnuViewPictureLogToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.mnuViewPictureLogToolStripMenuItem.Text = "&View Picture Log"
        '
        'mnuOptions
        '
        Me.mnuOptions.Image = Global.Picture_Viewer.My.Resources.Resources.Options
        Me.mnuOptions.Name = "mnuOptions"
        Me.mnuOptions.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuOptions.Size = New System.Drawing.Size(202, 22)
        Me.mnuOptions.Text = "&Options"
        '
        'tbrMainToolbar
        '
        Me.tbrMainToolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbbOpenPicture, Me.ToolStripSeparator3, Me.tbbDrawBorder, Me.ToolStripSeparator2, Me.tbbOptions, Me.tbbGetFileAttributes, Me.tbbShowLog, Me.tbbRotate, Me.tbbZoomOut, Me.tbbZoomIn})
        Me.tbrMainToolbar.Location = New System.Drawing.Point(0, 24)
        Me.tbrMainToolbar.Name = "tbrMainToolbar"
        Me.tbrMainToolbar.Size = New System.Drawing.Size(384, 25)
        Me.tbrMainToolbar.TabIndex = 10
        Me.tbrMainToolbar.Text = "ToolStrip1"
        '
        'tbbOpenPicture
        '
        Me.tbbOpenPicture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbOpenPicture.Image = CType(resources.GetObject("tbbOpenPicture.Image"), System.Drawing.Image)
        Me.tbbOpenPicture.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbOpenPicture.Name = "tbbOpenPicture"
        Me.tbbOpenPicture.Size = New System.Drawing.Size(23, 22)
        Me.tbbOpenPicture.Text = "Open Picture"
        Me.tbbOpenPicture.ToolTipText = "Open Picture"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tbbDrawBorder
        '
        Me.tbbDrawBorder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbDrawBorder.Image = CType(resources.GetObject("tbbDrawBorder.Image"), System.Drawing.Image)
        Me.tbbDrawBorder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbDrawBorder.Name = "tbbDrawBorder"
        Me.tbbDrawBorder.Size = New System.Drawing.Size(23, 22)
        Me.tbbDrawBorder.Text = "Draw Border"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tbbOptions
        '
        Me.tbbOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbOptions.Image = CType(resources.GetObject("tbbOptions.Image"), System.Drawing.Image)
        Me.tbbOptions.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbOptions.Name = "tbbOptions"
        Me.tbbOptions.Size = New System.Drawing.Size(23, 22)
        Me.tbbOptions.Text = "Options"
        '
        'tbbGetFileAttributes
        '
        Me.tbbGetFileAttributes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbGetFileAttributes.Image = CType(resources.GetObject("tbbGetFileAttributes.Image"), System.Drawing.Image)
        Me.tbbGetFileAttributes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbGetFileAttributes.Name = "tbbGetFileAttributes"
        Me.tbbGetFileAttributes.Size = New System.Drawing.Size(23, 22)
        Me.tbbGetFileAttributes.Text = "ToolStripButton1"
        Me.tbbGetFileAttributes.ToolTipText = "Get File Attributes"
        '
        'tbbShowLog
        '
        Me.tbbShowLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbShowLog.Image = CType(resources.GetObject("tbbShowLog.Image"), System.Drawing.Image)
        Me.tbbShowLog.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbShowLog.Name = "tbbShowLog"
        Me.tbbShowLog.Size = New System.Drawing.Size(23, 22)
        Me.tbbShowLog.Text = "View Picture Log"
        '
        'tbbRotate
        '
        Me.tbbRotate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbRotate.Image = Global.Picture_Viewer.My.Resources.Resources.rotate
        Me.tbbRotate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbRotate.Name = "tbbRotate"
        Me.tbbRotate.Size = New System.Drawing.Size(23, 22)
        Me.tbbRotate.Text = "Rotate Image"
        '
        'tbbZoomOut
        '
        Me.tbbZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbZoomOut.Image = Global.Picture_Viewer.My.Resources.Resources.zoom_out
        Me.tbbZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbZoomOut.Name = "tbbZoomOut"
        Me.tbbZoomOut.Size = New System.Drawing.Size(23, 22)
        Me.tbbZoomOut.Text = "Zoom Out"
        '
        'tbbZoomIn
        '
        Me.tbbZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbZoomIn.Image = Global.Picture_Viewer.My.Resources.Resources.zoom_in
        Me.tbbZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbZoomIn.Name = "tbbZoomIn"
        Me.tbbZoomIn.Size = New System.Drawing.Size(23, 22)
        Me.tbbZoomIn.Text = "Zoom In"
        '
        'sbrMyStatusStrip
        '
        Me.sbrMyStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.sbrMyStatusStrip.Location = New System.Drawing.Point(0, 314)
        Me.sbrMyStatusStrip.Name = "sbrMyStatusStrip"
        Me.sbrMyStatusStrip.Size = New System.Drawing.Size(384, 22)
        Me.sbrMyStatusStrip.TabIndex = 11
        Me.sbrMyStatusStrip.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(98, 17)
        Me.lblStatus.Text = "No image loaded"
        '
        'picShowPicture
        '
        Me.picShowPicture.AccessibleDescription = ""
        Me.picShowPicture.AccessibleName = ""
        Me.picShowPicture.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picShowPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picShowPicture.ContextMenuStrip = Me.mnuPictureContext
        Me.picShowPicture.Location = New System.Drawing.Point(8, 52)
        Me.picShowPicture.Name = "picShowPicture"
        Me.picShowPicture.Size = New System.Drawing.Size(322, 257)
        Me.picShowPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picShowPicture.TabIndex = 2
        Me.picShowPicture.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.AllowDrop = True
        Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNext.Location = New System.Drawing.Point(360, 153)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(21, 23)
        Me.btnNext.TabIndex = 12
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.AllowDrop = True
        Me.btnPrevious.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrevious.Location = New System.Drawing.Point(339, 153)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(21, 23)
        Me.btnPrevious.TabIndex = 13
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'ViewerForm
        '
        Me.AccessibleDescription = "Picture Viewer"
        Me.AccessibleName = "Picture Viewer"
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Application
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(384, 336)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.sbrMyStatusStrip)
        Me.Controls.Add(Me.tbrMainToolbar)
        Me.Controls.Add(Me.lblY)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.btnShrink)
        Me.Controls.Add(Me.btnEnlarge)
        Me.Controls.Add(Me.picShowPicture)
        Me.Controls.Add(Me.mnuMainMenu)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuMainMenu
        Me.Name = "ViewerForm"
        Me.Text = "Picture Viewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuPictureContext.ResumeLayout(False)
        Me.mnuMainMenu.ResumeLayout(False)
        Me.mnuMainMenu.PerformLayout()
        Me.tbrMainToolbar.ResumeLayout(False)
        Me.tbrMainToolbar.PerformLayout()
        Me.sbrMyStatusStrip.ResumeLayout(False)
        Me.sbrMyStatusStrip.PerformLayout()
        CType(Me.picShowPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picShowPicture As System.Windows.Forms.PictureBox
    Friend WithEvents ofdSelectPicture As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnEnlarge As System.Windows.Forms.Button
    Friend WithEvents btnShrink As System.Windows.Forms.Button
    Friend WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents lblY As System.Windows.Forms.Label
    Friend WithEvents mnuMainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpenPicture As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConfirmOnExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuQuit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDrawBorder As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPictureContext As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DrawBorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbrMainToolbar As System.Windows.Forms.ToolStrip
    Friend WithEvents tbbOpenPicture As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbbDrawBorder As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbbOptions As System.Windows.Forms.ToolStripButton
    Friend WithEvents sbrMyStatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tbbGetFileAttributes As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuGetFileAttributesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbbShowLog As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuViewPictureLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbbRotate As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuRotate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbbZoomOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbbZoomIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button

End Class
