<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Screen
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Screen))
        Me.zMenu = New System.Windows.Forms.MenuStrip
        Me.xFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.xStartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.xHighscoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.xExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.xOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.xHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.xInstructionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.xAboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TabControlDisplay = New System.Windows.Forms.TabControl
        Me.TabPageStart = New System.Windows.Forms.TabPage
        Me.zInsturction = New System.Windows.Forms.Button
        Me.zStartButton = New System.Windows.Forms.Button
        Me.TabPageOptions = New System.Windows.Forms.TabPage
        Me.zOptionsOk = New System.Windows.Forms.Button
        Me.zFullScreen = New System.Windows.Forms.CheckBox
        Me.zGameGroupBox = New System.Windows.Forms.GroupBox
        Me.zStartingDifficultyTrackBar = New System.Windows.Forms.TrackBar
        Me.zStartingDifficultyLabel = New System.Windows.Forms.Label
        Me.zDifficultyChangeTrackBar = New System.Windows.Forms.TrackBar
        Me.zDifficultyChangeLabel = New System.Windows.Forms.Label
        Me.zSpeedTrackBar = New System.Windows.Forms.TrackBar
        Me.zSpeedLabel = New System.Windows.Forms.Label
        Me.zZoomLabel = New System.Windows.Forms.Label
        Me.zZoomTrackBar = New System.Windows.Forms.TrackBar
        Me.zKeyboardGroupBox = New System.Windows.Forms.GroupBox
        Me.zKeyboardMovementTrackBar = New System.Windows.Forms.TrackBar
        Me.zKeyboard = New System.Windows.Forms.CheckBox
        Me.zKeyboardMovementLabel = New System.Windows.Forms.Label
        Me.zAsk = New System.Windows.Forms.CheckBox
        Me.zMusic = New System.Windows.Forms.CheckBox
        Me.TabPageHelp = New System.Windows.Forms.TabPage
        Me.zHelpText = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.zHelpButton = New System.Windows.Forms.Button
        Me.zGameOverCancelButton = New System.Windows.Forms.Button
        Me.zGameOverOkButton = New System.Windows.Forms.Button
        Me.zGameOverLabel = New System.Windows.Forms.Label
        Me.zGameOverTextBox = New System.Windows.Forms.TextBox
        Me.zMenuButton = New System.Windows.Forms.Button
        Me.zMovementTimer = New System.Windows.Forms.Timer(Me.components)
        Me.zDifficultyChangeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTipText = New System.Windows.Forms.ToolTip(Me.components)
        Me.zMenu.SuspendLayout()
        Me.TabControlDisplay.SuspendLayout()
        Me.TabPageStart.SuspendLayout()
        Me.TabPageOptions.SuspendLayout()
        Me.zGameGroupBox.SuspendLayout()
        CType(Me.zStartingDifficultyTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.zDifficultyChangeTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.zSpeedTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.zZoomTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.zKeyboardGroupBox.SuspendLayout()
        CType(Me.zKeyboardMovementTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageHelp.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'zMenu
        '
        Me.zMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.zMenu.AutoSize = False
        Me.zMenu.Dock = System.Windows.Forms.DockStyle.None
        Me.zMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.xFileToolStripMenuItem, Me.xOptionsToolStripMenuItem, Me.xHelpToolStripMenuItem})
        Me.zMenu.Location = New System.Drawing.Point(0, 0)
        Me.zMenu.Name = "zMenu"
        Me.zMenu.Size = New System.Drawing.Size(850, 24)
        Me.zMenu.TabIndex = 0
        Me.zMenu.Text = "MenuStrip1"
        '
        'xFileToolStripMenuItem
        '
        Me.xFileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.xStartToolStripMenuItem, Me.xHighscoresToolStripMenuItem, Me.ResetToolStripMenuItem, Me.xExitToolStripMenuItem})
        Me.xFileToolStripMenuItem.Name = "xFileToolStripMenuItem"
        Me.xFileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.xFileToolStripMenuItem.Text = "&File"
        '
        'xStartToolStripMenuItem
        '
        Me.xStartToolStripMenuItem.Image = Global.Endless_Cave.My.Resources.Resources.Start
        Me.xStartToolStripMenuItem.Name = "xStartToolStripMenuItem"
        Me.xStartToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.xStartToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.xStartToolStripMenuItem.Text = "S&tart"
        '
        'xHighscoresToolStripMenuItem
        '
        Me.xHighscoresToolStripMenuItem.Image = Global.Endless_Cave.My.Resources.Resources.Highscores
        Me.xHighscoresToolStripMenuItem.Name = "xHighscoresToolStripMenuItem"
        Me.xHighscoresToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.xHighscoresToolStripMenuItem.Text = "High&scores"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Image = Global.Endless_Cave.My.Resources.Resources.Reset
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ResetToolStripMenuItem.Text = "&Reset Highscores"
        '
        'xExitToolStripMenuItem
        '
        Me.xExitToolStripMenuItem.Image = Global.Endless_Cave.My.Resources.Resources._Exit
        Me.xExitToolStripMenuItem.Name = "xExitToolStripMenuItem"
        Me.xExitToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.xExitToolStripMenuItem.Text = "&Exit"
        '
        'xOptionsToolStripMenuItem
        '
        Me.xOptionsToolStripMenuItem.Name = "xOptionsToolStripMenuItem"
        Me.xOptionsToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.xOptionsToolStripMenuItem.Text = "&Options"
        '
        'xHelpToolStripMenuItem
        '
        Me.xHelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.xInstructionToolStripMenuItem, Me.xAboutToolStripMenuItem})
        Me.xHelpToolStripMenuItem.Name = "xHelpToolStripMenuItem"
        Me.xHelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.xHelpToolStripMenuItem.Text = "&Help"
        '
        'xInstructionToolStripMenuItem
        '
        Me.xInstructionToolStripMenuItem.Image = Global.Endless_Cave.My.Resources.Resources.Instructions
        Me.xInstructionToolStripMenuItem.Name = "xInstructionToolStripMenuItem"
        Me.xInstructionToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.xInstructionToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.xInstructionToolStripMenuItem.Text = "&Instructions"
        '
        'xAboutToolStripMenuItem
        '
        Me.xAboutToolStripMenuItem.Image = Global.Endless_Cave.My.Resources.Resources.About
        Me.xAboutToolStripMenuItem.Name = "xAboutToolStripMenuItem"
        Me.xAboutToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.xAboutToolStripMenuItem.Text = "&About"
        '
        'TabControlDisplay
        '
        Me.TabControlDisplay.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControlDisplay.Controls.Add(Me.TabPageStart)
        Me.TabControlDisplay.Controls.Add(Me.TabPageOptions)
        Me.TabControlDisplay.Controls.Add(Me.TabPageHelp)
        Me.TabControlDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlDisplay.Location = New System.Drawing.Point(0, 0)
        Me.TabControlDisplay.Name = "TabControlDisplay"
        Me.TabControlDisplay.SelectedIndex = 0
        Me.TabControlDisplay.Size = New System.Drawing.Size(352, 293)
        Me.TabControlDisplay.TabIndex = 3
        '
        'TabPageStart
        '
        Me.TabPageStart.Controls.Add(Me.zInsturction)
        Me.TabPageStart.Controls.Add(Me.zStartButton)
        Me.TabPageStart.Location = New System.Drawing.Point(4, 25)
        Me.TabPageStart.Name = "TabPageStart"
        Me.TabPageStart.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageStart.Size = New System.Drawing.Size(344, 264)
        Me.TabPageStart.TabIndex = 0
        Me.TabPageStart.Text = "TabPage1"
        Me.TabPageStart.UseVisualStyleBackColor = True
        '
        'zInsturction
        '
        Me.zInsturction.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.zInsturction.Location = New System.Drawing.Point(135, 137)
        Me.zInsturction.Name = "zInsturction"
        Me.zInsturction.Size = New System.Drawing.Size(75, 23)
        Me.zInsturction.TabIndex = 4
        Me.zInsturction.Text = "Instructions"
        Me.ToolTipText.SetToolTip(Me.zInsturction, "Click to read how to play the game.")
        Me.zInsturction.UseVisualStyleBackColor = True
        '
        'zStartButton
        '
        Me.zStartButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.zStartButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.zStartButton.Location = New System.Drawing.Point(135, 108)
        Me.zStartButton.Name = "zStartButton"
        Me.zStartButton.Size = New System.Drawing.Size(75, 23)
        Me.zStartButton.TabIndex = 3
        Me.zStartButton.Text = "Start"
        Me.ToolTipText.SetToolTip(Me.zStartButton, "Click to start playing the game.")
        Me.zStartButton.UseVisualStyleBackColor = True
        '
        'TabPageOptions
        '
        Me.TabPageOptions.Controls.Add(Me.zOptionsOk)
        Me.TabPageOptions.Controls.Add(Me.zFullScreen)
        Me.TabPageOptions.Controls.Add(Me.zGameGroupBox)
        Me.TabPageOptions.Controls.Add(Me.zKeyboardGroupBox)
        Me.TabPageOptions.Controls.Add(Me.zAsk)
        Me.TabPageOptions.Controls.Add(Me.zMusic)
        Me.TabPageOptions.Location = New System.Drawing.Point(4, 25)
        Me.TabPageOptions.Name = "TabPageOptions"
        Me.TabPageOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageOptions.Size = New System.Drawing.Size(344, 264)
        Me.TabPageOptions.TabIndex = 1
        Me.TabPageOptions.Text = "TabPage2"
        Me.TabPageOptions.UseVisualStyleBackColor = True
        '
        'zOptionsOk
        '
        Me.zOptionsOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.zOptionsOk.Location = New System.Drawing.Point(222, 233)
        Me.zOptionsOk.Name = "zOptionsOk"
        Me.zOptionsOk.Size = New System.Drawing.Size(114, 23)
        Me.zOptionsOk.TabIndex = 6
        Me.zOptionsOk.Text = "Back"
        Me.ToolTipText.SetToolTip(Me.zOptionsOk, "Click to return to starting screen.")
        Me.zOptionsOk.UseVisualStyleBackColor = True
        '
        'zFullScreen
        '
        Me.zFullScreen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.zFullScreen.AutoSize = True
        Me.zFullScreen.Location = New System.Drawing.Point(222, 199)
        Me.zFullScreen.Name = "zFullScreen"
        Me.zFullScreen.Size = New System.Drawing.Size(79, 17)
        Me.zFullScreen.TabIndex = 4
        Me.zFullScreen.Text = "Full Screen"
        Me.ToolTipText.SetToolTip(Me.zFullScreen, "Tick if you want to play in full screen.")
        Me.zFullScreen.UseVisualStyleBackColor = True
        '
        'zGameGroupBox
        '
        Me.zGameGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.zGameGroupBox.Controls.Add(Me.zStartingDifficultyTrackBar)
        Me.zGameGroupBox.Controls.Add(Me.zStartingDifficultyLabel)
        Me.zGameGroupBox.Controls.Add(Me.zDifficultyChangeTrackBar)
        Me.zGameGroupBox.Controls.Add(Me.zDifficultyChangeLabel)
        Me.zGameGroupBox.Controls.Add(Me.zSpeedTrackBar)
        Me.zGameGroupBox.Controls.Add(Me.zSpeedLabel)
        Me.zGameGroupBox.Controls.Add(Me.zZoomLabel)
        Me.zGameGroupBox.Controls.Add(Me.zZoomTrackBar)
        Me.zGameGroupBox.Location = New System.Drawing.Point(8, 6)
        Me.zGameGroupBox.Name = "zGameGroupBox"
        Me.zGameGroupBox.Size = New System.Drawing.Size(328, 141)
        Me.zGameGroupBox.TabIndex = 0
        Me.zGameGroupBox.TabStop = False
        Me.zGameGroupBox.Text = "Game"
        '
        'zStartingDifficultyTrackBar
        '
        Me.zStartingDifficultyTrackBar.Location = New System.Drawing.Point(6, 32)
        Me.zStartingDifficultyTrackBar.Maximum = 9
        Me.zStartingDifficultyTrackBar.Name = "zStartingDifficultyTrackBar"
        Me.zStartingDifficultyTrackBar.Size = New System.Drawing.Size(142, 42)
        Me.zStartingDifficultyTrackBar.TabIndex = 0
        Me.ToolTipText.SetToolTip(Me.zStartingDifficultyTrackBar, "This is how hard the game starts. From easy to hard.")
        Me.zStartingDifficultyTrackBar.Value = 1
        '
        'zStartingDifficultyLabel
        '
        Me.zStartingDifficultyLabel.AutoSize = True
        Me.zStartingDifficultyLabel.Location = New System.Drawing.Point(7, 16)
        Me.zStartingDifficultyLabel.Name = "zStartingDifficultyLabel"
        Me.zStartingDifficultyLabel.Size = New System.Drawing.Size(86, 13)
        Me.zStartingDifficultyLabel.TabIndex = 8
        Me.zStartingDifficultyLabel.Text = "Starting Difficulty"
        '
        'zDifficultyChangeTrackBar
        '
        Me.zDifficultyChangeTrackBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.zDifficultyChangeTrackBar.Location = New System.Drawing.Point(154, 32)
        Me.zDifficultyChangeTrackBar.Maximum = 9
        Me.zDifficultyChangeTrackBar.Name = "zDifficultyChangeTrackBar"
        Me.zDifficultyChangeTrackBar.Size = New System.Drawing.Size(168, 42)
        Me.zDifficultyChangeTrackBar.TabIndex = 2
        Me.ToolTipText.SetToolTip(Me.zDifficultyChangeTrackBar, "This is how quickly the difficulty increases. From one second to five seconds.")
        Me.zDifficultyChangeTrackBar.Value = 5
        '
        'zDifficultyChangeLabel
        '
        Me.zDifficultyChangeLabel.AutoSize = True
        Me.zDifficultyChangeLabel.Location = New System.Drawing.Point(151, 16)
        Me.zDifficultyChangeLabel.Name = "zDifficultyChangeLabel"
        Me.zDifficultyChangeLabel.Size = New System.Drawing.Size(99, 13)
        Me.zDifficultyChangeLabel.TabIndex = 6
        Me.zDifficultyChangeLabel.Text = "Difficulty Difference"
        '
        'zSpeedTrackBar
        '
        Me.zSpeedTrackBar.Location = New System.Drawing.Point(6, 93)
        Me.zSpeedTrackBar.Maximum = 9
        Me.zSpeedTrackBar.Name = "zSpeedTrackBar"
        Me.zSpeedTrackBar.Size = New System.Drawing.Size(142, 42)
        Me.zSpeedTrackBar.TabIndex = 1
        Me.ToolTipText.SetToolTip(Me.zSpeedTrackBar, "This is how quick you move through the level. From 10 segments per second to 100 " & _
                "segment per second.")
        Me.zSpeedTrackBar.Value = 6
        '
        'zSpeedLabel
        '
        Me.zSpeedLabel.AutoSize = True
        Me.zSpeedLabel.Location = New System.Drawing.Point(6, 77)
        Me.zSpeedLabel.Name = "zSpeedLabel"
        Me.zSpeedLabel.Size = New System.Drawing.Size(38, 13)
        Me.zSpeedLabel.TabIndex = 2
        Me.zSpeedLabel.Text = "Speed"
        '
        'zZoomLabel
        '
        Me.zZoomLabel.AutoSize = True
        Me.zZoomLabel.Location = New System.Drawing.Point(154, 77)
        Me.zZoomLabel.Name = "zZoomLabel"
        Me.zZoomLabel.Size = New System.Drawing.Size(34, 13)
        Me.zZoomLabel.TabIndex = 5
        Me.zZoomLabel.Text = "Zoom"
        '
        'zZoomTrackBar
        '
        Me.zZoomTrackBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.zZoomTrackBar.Location = New System.Drawing.Point(154, 93)
        Me.zZoomTrackBar.Maximum = 9
        Me.zZoomTrackBar.Name = "zZoomTrackBar"
        Me.zZoomTrackBar.Size = New System.Drawing.Size(168, 42)
        Me.zZoomTrackBar.TabIndex = 3
        Me.ToolTipText.SetToolTip(Me.zZoomTrackBar, "This is how many segments to you see. From 10 to 100 segments.")
        Me.zZoomTrackBar.Value = 3
        '
        'zKeyboardGroupBox
        '
        Me.zKeyboardGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.zKeyboardGroupBox.Controls.Add(Me.zKeyboardMovementTrackBar)
        Me.zKeyboardGroupBox.Controls.Add(Me.zKeyboard)
        Me.zKeyboardGroupBox.Controls.Add(Me.zKeyboardMovementLabel)
        Me.zKeyboardGroupBox.Location = New System.Drawing.Point(8, 153)
        Me.zKeyboardGroupBox.Name = "zKeyboardGroupBox"
        Me.zKeyboardGroupBox.Size = New System.Drawing.Size(208, 103)
        Me.zKeyboardGroupBox.TabIndex = 1
        Me.zKeyboardGroupBox.TabStop = False
        Me.zKeyboardGroupBox.Text = "Keyboard"
        '
        'zKeyboardMovementTrackBar
        '
        Me.zKeyboardMovementTrackBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.zKeyboardMovementTrackBar.Location = New System.Drawing.Point(6, 55)
        Me.zKeyboardMovementTrackBar.Maximum = 9
        Me.zKeyboardMovementTrackBar.Name = "zKeyboardMovementTrackBar"
        Me.zKeyboardMovementTrackBar.Size = New System.Drawing.Size(196, 42)
        Me.zKeyboardMovementTrackBar.TabIndex = 1
        Me.ToolTipText.SetToolTip(Me.zKeyboardMovementTrackBar, "This is how much the player moves when you press W or S. From one pixel to five p" & _
                "ixels.")
        '
        'zKeyboard
        '
        Me.zKeyboard.AutoSize = True
        Me.zKeyboard.Location = New System.Drawing.Point(6, 19)
        Me.zKeyboard.Name = "zKeyboard"
        Me.zKeyboard.Size = New System.Drawing.Size(125, 17)
        Me.zKeyboard.TabIndex = 0
        Me.zKeyboard.Text = "Keyboard for Gaming"
        Me.ToolTipText.SetToolTip(Me.zKeyboard, "Tick this if you want to use keyboard instead of mouse.")
        Me.zKeyboard.UseVisualStyleBackColor = True
        '
        'zKeyboardMovementLabel
        '
        Me.zKeyboardMovementLabel.AutoSize = True
        Me.zKeyboardMovementLabel.Location = New System.Drawing.Point(6, 39)
        Me.zKeyboardMovementLabel.Name = "zKeyboardMovementLabel"
        Me.zKeyboardMovementLabel.Size = New System.Drawing.Size(105, 13)
        Me.zKeyboardMovementLabel.TabIndex = 12
        Me.zKeyboardMovementLabel.Text = "Keyboard Movement"
        '
        'zAsk
        '
        Me.zAsk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.zAsk.AutoSize = True
        Me.zAsk.Location = New System.Drawing.Point(222, 176)
        Me.zAsk.Name = "zAsk"
        Me.zAsk.Size = New System.Drawing.Size(118, 17)
        Me.zAsk.TabIndex = 3
        Me.zAsk.Text = "Ask Caution for Exit"
        Me.ToolTipText.SetToolTip(Me.zAsk, "Tick you want a messagebox asking wether you want to close the game.")
        Me.zAsk.UseVisualStyleBackColor = True
        '
        'zMusic
        '
        Me.zMusic.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.zMusic.AutoSize = True
        Me.zMusic.Checked = True
        Me.zMusic.CheckState = System.Windows.Forms.CheckState.Checked
        Me.zMusic.Location = New System.Drawing.Point(222, 153)
        Me.zMusic.Name = "zMusic"
        Me.zMusic.Size = New System.Drawing.Size(77, 17)
        Me.zMusic.TabIndex = 2
        Me.zMusic.Text = "Play Music"
        Me.ToolTipText.SetToolTip(Me.zMusic, "Tick if you want the music playing.")
        Me.zMusic.UseVisualStyleBackColor = True
        '
        'TabPageHelp
        '
        Me.TabPageHelp.Controls.Add(Me.zHelpText)
        Me.TabPageHelp.Controls.Add(Me.Panel1)
        Me.TabPageHelp.Location = New System.Drawing.Point(4, 25)
        Me.TabPageHelp.Name = "TabPageHelp"
        Me.TabPageHelp.Size = New System.Drawing.Size(344, 264)
        Me.TabPageHelp.TabIndex = 2
        Me.TabPageHelp.Text = "TabPage3"
        Me.TabPageHelp.UseVisualStyleBackColor = True
        '
        'zHelpText
        '
        Me.zHelpText.BackColor = System.Drawing.Color.White
        Me.zHelpText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.zHelpText.Location = New System.Drawing.Point(0, 0)
        Me.zHelpText.Multiline = True
        Me.zHelpText.Name = "zHelpText"
        Me.zHelpText.ReadOnly = True
        Me.zHelpText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.zHelpText.ShortcutsEnabled = False
        Me.zHelpText.Size = New System.Drawing.Size(344, 224)
        Me.zHelpText.TabIndex = 2
        Me.zHelpText.Text = resources.GetString("zHelpText.Text")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.zHelpButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 224)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(344, 40)
        Me.Panel1.TabIndex = 3
        '
        'zHelpButton
        '
        Me.zHelpButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.zHelpButton.Location = New System.Drawing.Point(261, 9)
        Me.zHelpButton.Name = "zHelpButton"
        Me.zHelpButton.Size = New System.Drawing.Size(75, 23)
        Me.zHelpButton.TabIndex = 1
        Me.zHelpButton.Text = "Back"
        Me.ToolTipText.SetToolTip(Me.zHelpButton, "Click to return to the menu.")
        Me.zHelpButton.UseVisualStyleBackColor = True
        '
        'zGameOverCancelButton
        '
        Me.zGameOverCancelButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.zGameOverCancelButton.Enabled = False
        Me.zGameOverCancelButton.Location = New System.Drawing.Point(184, 258)
        Me.zGameOverCancelButton.Name = "zGameOverCancelButton"
        Me.zGameOverCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.zGameOverCancelButton.TabIndex = 3
        Me.zGameOverCancelButton.Text = "Cancel"
        Me.ToolTipText.SetToolTip(Me.zGameOverCancelButton, "Click to cancel and the highscores will display ""Unnamed"".")
        Me.zGameOverCancelButton.UseVisualStyleBackColor = True
        Me.zGameOverCancelButton.Visible = False
        '
        'zGameOverOkButton
        '
        Me.zGameOverOkButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.zGameOverOkButton.Enabled = False
        Me.zGameOverOkButton.Location = New System.Drawing.Point(265, 258)
        Me.zGameOverOkButton.Name = "zGameOverOkButton"
        Me.zGameOverOkButton.Size = New System.Drawing.Size(75, 23)
        Me.zGameOverOkButton.TabIndex = 2
        Me.zGameOverOkButton.Text = "Ok"
        Me.ToolTipText.SetToolTip(Me.zGameOverOkButton, "Click to accept the name into the highscores.")
        Me.zGameOverOkButton.UseVisualStyleBackColor = True
        Me.zGameOverOkButton.Visible = False
        '
        'zGameOverLabel
        '
        Me.zGameOverLabel.AutoSize = True
        Me.zGameOverLabel.Location = New System.Drawing.Point(12, 24)
        Me.zGameOverLabel.Name = "zGameOverLabel"
        Me.zGameOverLabel.Size = New System.Drawing.Size(101, 13)
        Me.zGameOverLabel.TabIndex = 1
        Me.zGameOverLabel.Text = "What is your name?"
        Me.zGameOverLabel.Visible = False
        '
        'zGameOverTextBox
        '
        Me.zGameOverTextBox.AccessibleDescription = ""
        Me.zGameOverTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.zGameOverTextBox.Enabled = False
        Me.zGameOverTextBox.Location = New System.Drawing.Point(12, 40)
        Me.zGameOverTextBox.MaxLength = 64
        Me.zGameOverTextBox.Name = "zGameOverTextBox"
        Me.zGameOverTextBox.Size = New System.Drawing.Size(328, 20)
        Me.zGameOverTextBox.TabIndex = 0
        Me.zGameOverTextBox.Tag = ""
        Me.ToolTipText.SetToolTip(Me.zGameOverTextBox, "Enter the name you want in the highscores.")
        Me.zGameOverTextBox.Visible = False
        '
        'zMenuButton
        '
        Me.zMenuButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.zMenuButton.AutoSize = True
        Me.zMenuButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.zMenuButton.BackColor = System.Drawing.Color.Red
        Me.zMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.zMenuButton.Location = New System.Drawing.Point(239, 12)
        Me.zMenuButton.Name = "zMenuButton"
        Me.zMenuButton.Size = New System.Drawing.Size(93, 25)
        Me.zMenuButton.TabIndex = 14
        Me.zMenuButton.Text = "Return to Menu"
        Me.ToolTipText.SetToolTip(Me.zMenuButton, "Click to exit the game.")
        Me.zMenuButton.UseVisualStyleBackColor = False
        '
        'zMovementTimer
        '
        Me.zMovementTimer.Interval = 40
        '
        'zDifficultyChangeTimer
        '
        Me.zDifficultyChangeTimer.Interval = 25
        '
        'Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 293)
        Me.Controls.Add(Me.zMenu)
        Me.Controls.Add(Me.TabControlDisplay)
        Me.Controls.Add(Me.zMenuButton)
        Me.Controls.Add(Me.zGameOverCancelButton)
        Me.Controls.Add(Me.zGameOverOkButton)
        Me.Controls.Add(Me.zGameOverTextBox)
        Me.Controls.Add(Me.zGameOverLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.zMenu
        Me.MinimumSize = New System.Drawing.Size(360, 320)
        Me.Name = "Screen"
        Me.Text = "Endless Cave"
        Me.zMenu.ResumeLayout(False)
        Me.zMenu.PerformLayout()
        Me.TabControlDisplay.ResumeLayout(False)
        Me.TabPageStart.ResumeLayout(False)
        Me.TabPageOptions.ResumeLayout(False)
        Me.TabPageOptions.PerformLayout()
        Me.zGameGroupBox.ResumeLayout(False)
        Me.zGameGroupBox.PerformLayout()
        CType(Me.zStartingDifficultyTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.zDifficultyChangeTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.zSpeedTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.zZoomTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.zKeyboardGroupBox.ResumeLayout(False)
        Me.zKeyboardGroupBox.PerformLayout()
        CType(Me.zKeyboardMovementTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageHelp.ResumeLayout(False)
        Me.TabPageHelp.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents zMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents xFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents xStartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents xExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents xOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents xHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents xInstructionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents xAboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControlDisplay As System.Windows.Forms.TabControl
    Friend WithEvents TabPageStart As System.Windows.Forms.TabPage
    Friend WithEvents TabPageOptions As System.Windows.Forms.TabPage
    Friend WithEvents zInsturction As System.Windows.Forms.Button
    Friend WithEvents zStartButton As System.Windows.Forms.Button
    Friend WithEvents zZoomTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents zDifficultyChangeTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents zStartingDifficultyTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents zSpeedTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents zAsk As System.Windows.Forms.CheckBox
    Friend WithEvents zMusic As System.Windows.Forms.CheckBox
    Friend WithEvents zStartingDifficultyLabel As System.Windows.Forms.Label
    Friend WithEvents zSpeedLabel As System.Windows.Forms.Label
    Friend WithEvents zDifficultyChangeLabel As System.Windows.Forms.Label
    Friend WithEvents zZoomLabel As System.Windows.Forms.Label
    Friend WithEvents TabPageHelp As System.Windows.Forms.TabPage
    Friend WithEvents zHelpButton As System.Windows.Forms.Button
    Friend WithEvents zKeyboardMovementTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents zKeyboardMovementLabel As System.Windows.Forms.Label
    Friend WithEvents zKeyboard As System.Windows.Forms.CheckBox
    Friend WithEvents xHighscoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents zMenuButton As System.Windows.Forms.Button
    Friend WithEvents zGameGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents zKeyboardGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents zMovementTimer As System.Windows.Forms.Timer
    Friend WithEvents zDifficultyChangeTimer As System.Windows.Forms.Timer
    Friend WithEvents zHelpText As System.Windows.Forms.TextBox
    Friend WithEvents zGameOverOkButton As System.Windows.Forms.Button
    Friend WithEvents zGameOverLabel As System.Windows.Forms.Label
    Friend WithEvents zGameOverTextBox As System.Windows.Forms.TextBox
    Friend WithEvents zGameOverCancelButton As System.Windows.Forms.Button
    Friend WithEvents zFullScreen As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolTipText As System.Windows.Forms.ToolTip
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents zOptionsOk As System.Windows.Forms.Button

End Class
