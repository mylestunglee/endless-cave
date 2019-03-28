Imports System.Drawing.Drawing2D

Public Class Screen

#Region "Varibles"
    'Remembers the drawn segments
    Dim ySegmentHeight() As Byte
    'Remembers the zoom of the game
    Dim yZoom As Integer = 40
    'Player Location
    Dim yPlayerLocation As Byte = 0
    'Starting difficulty for the game
    Dim yStartingDifficulty As Integer = 6
    'Score to remember what score the player is on
    Dim yScore As Integer = 0
    'Makes a the random number
    Dim yMaker As New Random
    'The line of change for generating the new segment
    Dim yChange As Integer
    'To tell wether the up arrow is pressed
    Dim yUpArrow As Boolean = False
    'To tell wether the down arrow is pressed
    Dim yDownArrow As Boolean = False
    'Keeps the highscore
    Dim yHighscoreRecord(2) As HighScore
    'Checks how much to move the player (pixles)
    Dim ySenitivity As Integer
    'Maximum score by player
    Dim yHighestScore As Integer = 0
    'Works out the score to add every movement
    Dim yCalculated As Integer
    'Finds out if the game is paused
    Dim yInGame As Boolean = False
    'Makes varible so when the form is resized the score doesn't drop to 0
    Dim yCheckScore As Boolean = False
    'Checks if the key is held down (P key)
    Dim yPauseHold As Boolean = True

    'Collection of data for high scores
    Structure HighScore
        'Stores name to idenity who got score
        Dim Name As String
        'Stores score to see how big the score is
        Dim Score As Integer
    End Structure
#End Region 'Makes varibles to record y...

    'Allows me to set all the of segments
    Public WriteOnly Property qSegmentHeightAll() As Byte
        Set(ByVal value As Byte)
            'Goes through each byte in segmentheight
            For Index As Integer = 1 To Me.ySegmentHeight.Length
                'Sets the segment to the selected value
                ySegmentHeight(Index - 1) = value
            Next
        End Set
    End Property

#Region "Form Events"

    'Sets the properties of things then the game is loaded
    Private Sub Start() Handles Me.Load
        'Sets the first name to the first saved name
        yHighscoreRecord(0).Name = My.Settings.Record_0_Name
        'Sets the first score to the first saved score
        yHighscoreRecord(0).Score = My.Settings.Record_0_Score
        'Sets the second name to the second saved name
        yHighscoreRecord(1).Name = My.Settings.Record_1_Name
        'Sets the second name to the second saved score
        yHighscoreRecord(1).Score = My.Settings.Record_1_Score
        'Sets the third name to the third saved name
        yHighscoreRecord(2).Name = My.Settings.Record_2_Name
        'Sets the thrid name to the thrid saved score
        yHighscoreRecord(2).Score = My.Settings.Record_2_Score
    End Sub

    'When the ingame exit button is clicked, it exits the game
    Private Sub zMenuButton_Click() Handles zMenuButton.Click, Me.Load
        'Disables the ingame button
        Me.zMenuButton.Enabled = False
        'Disables the timer
        Me.zMovementTimer.Enabled = False
        'The game is not running
        Me.yInGame = False
        'Disables the difficulty change
        Me.zDifficultyChangeTimer.Enabled = False
        'Shows the menu
        Me.zMenu.Visible = True
        'Shows the screen
        Me.TabControlDisplay.Visible = True
    End Sub

    'Finds out the diffence between the mouse and current poistion and  moves player
    Private Sub Screen_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove, zMenuButton.MouseMove
        'Only happens the when keyboard is not used
        If zKeyboard.Checked = True Then Exit Sub
        'Makes number to record the byte value of the mouse position
        Dim Number As Integer = CInt((e.Location.Y / Me.ClientSize.Height) * Byte.MaxValue)

        'Checks if the number is to big
        If Number > Byte.MaxValue Then
            'Sets the number to maximum
            yPlayerLocation = Byte.MaxValue
        ElseIf Number < Byte.MinValue Then
            'Sets number to minimum
            yPlayerLocation = Byte.MinValue
        Else
            'Sets the number to the calcuated byte term
            yPlayerLocation = CByte(Number)
        End If
    End Sub

    'Happens when the screen bounds are changed
    Private Sub Screen_SizeChanged() Handles Me.SizeChanged, Me.Resize, Me.ResizeBegin, Me.ResizeEnd, Me.LocationChanged, Me.Load, TabControlDisplay.SelectedIndexChanged
        'Sets the location to half the box and level with the top
        Me.zDifficultyChangeTrackBar.Location = New Point(Me.zGameGroupBox.Width \ 2, Me.zDifficultyChangeTrackBar.Location.Y)
        'Sets the location
        Me.zZoomTrackBar.Location = New Point(Me.zGameGroupBox.Width \ 2, Me.zZoomTrackBar.Location.Y)
        'Sets the location
        Me.zDifficultyChangeLabel.Location = New Point(Me.zDifficultyChangeTrackBar.Location.X - (Me.zStartingDifficultyTrackBar.Location.X - Me.zStartingDifficultyLabel.Location.X), Me.zDifficultyChangeLabel.Location.Y)
        'Sets the location
        Me.zZoomLabel.Location = New Point(Me.zDifficultyChangeLabel.Location.X, Me.zSpeedLabel.Location.Y)
        'Makes a integer so it doesn't need to calcuated it anymore
        Dim GroupBoxWidth As Integer = Me.zGameGroupBox.Width \ 2 - 5
        'Sets the width
        Me.zZoomTrackBar.Width = GroupBoxWidth
        'Sets the width
        Me.zDifficultyChangeTrackBar.Width = GroupBoxWidth
        'Sets the width
        Me.zSpeedTrackBar.Width = GroupBoxWidth
        'Sets the width
        Me.zStartingDifficultyTrackBar.Width = GroupBoxWidth
        'Checks if the game is running and if so, redraw the screen
        If yInGame = True Then Call Draw()
        Me.zHelpText.DeselectAll()
    End Sub

    'If the user put ask, it will ask the user to choose wether to close it *
    Private Sub Screen_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Checks if the checkbox is ticked. zAsk is about the closuere of the progame
        If zAsk.Checked Then
            'Ask the messagebox if the user wants the game to close and closes the game if the user clicked yes
            If MessageBox.Show("Do you want to exit " & Application.ProductName & "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.No Then e.Cancel = True
        End If
    End Sub

#Region "Key Detection"
    'Sets true when key is pressed
    Private Sub ScreenKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles zMenu.KeyDown, TabControlDisplay.KeyDown, TabPageStart.KeyDown, TabPageOptions.KeyDown, zInsturction.KeyDown, zStartButton.KeyDown, zZoomTrackBar.KeyDown, zDifficultyChangeTrackBar.KeyDown, zStartingDifficultyTrackBar.KeyDown, zSpeedTrackBar.KeyDown, zAsk.KeyDown, zMusic.KeyDown, zStartingDifficultyLabel.KeyDown, zSpeedLabel.KeyDown, zDifficultyChangeLabel.KeyDown, zZoomLabel.KeyDown, TabPageHelp.KeyDown, zHelpButton.KeyDown, zKeyboardMovementTrackBar.KeyDown, zKeyboardMovementLabel.KeyDown, zKeyboard.KeyDown, zMenuButton.KeyDown, zGameGroupBox.KeyDown, zKeyboardGroupBox.KeyDown
        'Finds out which key is pressed                                                                                               
        Select Case e.KeyCode
            Case Keys.W
                'Sets it to true so it knows that the key is pressed
                yUpArrow = True
            Case Keys.S
                'Sets it to ture so it knows that down is presed
                yDownArrow = True
            Case Keys.P
                'Checks if the game is playing the key is held
                If yInGame And yPauseHold = True Then
                    'Sets the key so it is not held
                    yPauseHold = False
                    'Stops / Starts timer
                    zMovementTimer.Enabled = Not zMovementTimer.Enabled
                    'Stops / Starts timer
                    zDifficultyChangeTimer.Enabled = Not zDifficultyChangeTimer.Enabled
                    'Checks if the movement timer is on and wether to add "Paused" to the end of the title name
                    If zMovementTimer.Enabled Then Me.Text = Application.ProductName Else Me.Text = Application.ProductName & " - Paused"
                End If
            Case Keys.Escape
                'If the form has no border, it ticks off the full screen checkbox
                If Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None Then Me.zFullScreen.Checked = False
        End Select
    End Sub

    'Sets false when the key is released
    Private Sub ScreenKeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles zMenu.KeyUp, TabControlDisplay.KeyUp, TabPageStart.KeyUp, TabPageOptions.KeyUp, zInsturction.KeyUp, zStartButton.KeyUp, zZoomTrackBar.KeyUp, zDifficultyChangeTrackBar.KeyUp, zStartingDifficultyTrackBar.KeyUp, zSpeedTrackBar.KeyUp, zAsk.KeyUp, zMusic.KeyUp, zStartingDifficultyLabel.KeyUp, zSpeedLabel.KeyUp, zDifficultyChangeLabel.KeyUp, zZoomLabel.KeyUp, TabPageHelp.KeyUp, zHelpButton.KeyUp, zKeyboardMovementTrackBar.KeyUp, zKeyboardMovementLabel.KeyUp, zKeyboard.KeyUp, zMenuButton.KeyUp, zGameGroupBox.KeyUp, zKeyboardGroupBox.KeyUp
        'Finds out which key is pressed                                                                                               
        Select Case e.KeyCode
            Case Keys.W
                'Sets it to true so it knows that the key is pressed
                yUpArrow = False
            Case Keys.S
                'Sets it to ture sp it knows that down is presed
                yDownArrow = False
            Case Keys.P
                'Says the key is held
                yPauseHold = True
        End Select
    End Sub

#End Region 'Checks if the key is pressed or not

#End Region 'Inputs that cause the form to do something

#Region "Menu"

    'Reset Button
    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        If MessageBox.Show("Would you like to reset the highscores?", "Highscores", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            'Goes through each record and sets its name to unbamed
            For Index As Integer = 0 To 2
                'Sets the name to "Unnaed"
                yHighscoreRecord(Index).Name = "Unnamed"
                yHighscoreRecord(Index).Score = 0
            Next
            'Sets the settings to the blank highscores
            SetSettings()
        End If
    End Sub

    'Shows the highscore table in a message box
    Private Sub HighscoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xHighscoresToolStripMenuItem.Click
        'Checks if the highscores are empty, if so it say first to get one else it will display the highscores
        If yHighscoreRecord(0).Score = 0 Then MessageBox.Show("There is no current highscores. Be the first!", "Highscores", MessageBoxButtons.OK, MessageBoxIcon.Information) Else MessageBox.Show("1. " & yHighscoreRecord(0).Name & " got " & yHighscoreRecord(0).Score.ToString & vbCrLf & "2. " & yHighscoreRecord(1).Name & " got " & yHighscoreRecord(1).Score.ToString & vbCrLf & "3. " & yHighscoreRecord(2).Name & " got " & yHighscoreRecord(2).Score.ToString, "Highscores", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Returns to the starting screen and sets all the values
    Private Sub ReturntoStartScreen() Handles zOptionsOk.Click, zHelpButton.Click
        'Sets the tab to the first one
        Me.TabControlDisplay.SelectedTab = Me.TabPageStart
        'Sets the zoom
        Me.yZoom = Me.zZoomTrackBar.Value * 10 + 10
        'Sets the speed
        Me.zMovementTimer.Interval = (Math.Abs((Me.zSpeedTrackBar.Value - 10))) * 10
        'Sets the difficulty change * 50 is the same as / 2 * 100 beacause 100 / 2 = 50 therefore * 50 is quicker
        Me.zDifficultyChangeTimer.Interval = 500 * (10 - Me.zDifficultyChangeTrackBar.Value)
        'Sets the starting difficulty
        Me.yStartingDifficulty = 5 * Me.zStartingDifficultyTrackBar.Value + 1
        'Sets the senitivty
        Me.ySenitivity = Me.zKeyboardMovementTrackBar.Value + 1
        'Resets the size for the segment
        ReDim ySegmentHeight(yZoom)
    End Sub

    'Goes to the instrution tab
    Private Sub InstructionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xInstructionToolStripMenuItem.Click, zInsturction.Click
        'Sets it to the third tab
        Me.TabControlDisplay.SelectedTab = Me.TabPageHelp
    End Sub

    'Text about to be changed but denised anyway
    Private Sub TextTyped() Handles zHelpText.KeyDown
        'Tells the user that text cannot be entered
        Beep()
    End Sub

    'When the about is clicked it shows a message box of who made the game. Of course it is Myles Lee
    Private Sub AboutToolStripMenuItem_Click() Handles xAboutToolStripMenuItem.Click
        'Shows the message box
        MessageBox.Show(Application.ProductName & " by " & MyName(), "About", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
    End Sub

    'Does the same as FormClosing
    Private Sub ExitToolStripMenuItem_Click() Handles xExitToolStripMenuItem.Click
        'Checks if the checkbox is ticked
        Me.Close()
    End Sub

    'Changes the tab view so that it displays the second tab
    Private Sub OptionClick() Handles xOptionsToolStripMenuItem.Click
        'Sets it to two
        Me.TabControlDisplay.SelectedTab = Me.TabPageOptions

    End Sub

#Region "Options"

    'When the music checkbox is changed it turns off or on the music
    Private Sub zMusic_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles zMusic.CheckedChanged, Me.Load
        'Checks if the music checkbox is ticked
        If zMusic.Checked Then
            'Plays the background sound for the game
            My.Computer.Audio.Play(My.Resources.MusicFile, AudioPlayMode.BackgroundLoop)
        Else
            'Stops the background music
            My.Computer.Audio.Stop()
        End If
    End Sub

    'When the keyboard checkbox is changed it turns off or on the enablity of the keyboard controls
    Private Sub zKeyboard_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles zKeyboard.Click, Me.Load, xOptionsToolStripMenuItem.Click
        'Makes the label unabled
        Me.zKeyboardMovementLabel.Enabled = zKeyboard.Checked
        'Makes the trackbar stuck
        Me.zKeyboardMovementTrackBar.Enabled = zKeyboard.Checked
    End Sub

    'Sets full screen on the form or not
    Private Sub zFullScreen_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles zFullScreen.CheckedChanged, Me.Load
        'Checks if the music checkbox is ticked
        If zFullScreen.Checked = True Then
            'Sets the state is normal so that the game is full screen ontop of the taskbar
            Me.WindowState = FormWindowState.Normal
            'No borders
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            'Sets the state so it fills the monitor
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Else
            'Sets the borders so the user can resize it again
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
            'Resize it to normal
            Me.WindowState = FormWindowState.Normal
        End If

        'Calls and resizees all controls
        Call Screen_SizeChanged()
    End Sub

#End Region

#End Region 'Menu buttons

#Region "Start, Ingame, Gameover"

    'Draws game on form
    Private Sub Draw()
        'Makes graphics so that it can draw on the form
        Dim GraphicsDrawer As Graphics = Me.CreateGraphics()
        'Makes the graphic draw quick
        GraphicsDrawer.SmoothingMode = SmoothingMode.HighSpeed
        'Clears all the graphics displayed to the backcolour. Same as  using a rectangle to fill the background
        GraphicsDrawer.Clear(Color.Black)
        'Sets the last segment to change
        ySegmentHeight(yZoom) = RandomHeight()
        'Makes size of string to draw
        Dim SJ As Integer
        'Checks if the height is more than the width and sets the size to the smaller value
        If Me.ClientSize.Height < Me.ClientSize.Width Then SJ = Me.ClientSize.Height \ 20 Else SJ = Me.ClientSize.Width \ 20

        'Makes a counter and repeats it to zZoom
        For Index As Integer = 1 To yZoom + 1
            'Draws every 
            GraphicsDrawer.FillRectangle(Brushes.White, CInt((Index - 1) * (Me.ClientSize.Width / yZoom)), CInt((ySegmentHeight(Index - 1) / Byte.MaxValue) * (Me.ClientSize.Height - (Me.ClientSize.Height / 3))), 1 + CInt(Me.ClientSize.Width / Me.yZoom), Me.ClientSize.Height \ 3)
        Next

        'Draws player
        GraphicsDrawer.FillRectangle(Brushes.Red, 0, CInt((yPlayerLocation / Byte.MaxValue) * Me.ClientSize.Height), Me.ClientSize.Width \ Me.yZoom, CInt((Me.ClientSize.Height / Byte.MaxValue) * 15))
        'Draws string
        GraphicsDrawer.DrawString(yScore.ToString("000000000"), New System.Drawing.Font("Courier New", SJ, FontStyle.Bold), Brushes.Red, 0, 0, New StringFormat)
        'Get rid of the graphics - Not needed anymore
        GraphicsDrawer.Dispose()
    End Sub

    'Starts when the start button (game button) is clicked
    Private Sub zStartButton_Click() Handles xStartToolStripMenuItem.Click, zStartButton.Click
        'Sets the difficulty
        Call zDifficultyChangeTimer_Tick()
        'Sets the highest score to 0
        Me.yHighestScore = 0
        'Resets the score
        Me.yScore = 0
        'Sets all the value for the game correctly
        Call ReturntoStartScreen()
        'Sets it to the new height
        Me.qSegmentHeightAll = RandomHeight()
        'Fouces the menu button
        Me.zMenuButton.Focus()
        'Shows the menu button
        Me.zMenuButton.Visible = True
        'Enables the menu button
        Me.zMenuButton.Enabled = True
        'Hides the menu
        Me.zMenu.Visible = False
        'Hides the tabs
        Me.TabControlDisplay.Visible = False
        'Enables the timer
        Me.zMovementTimer.Enabled = True
        'Enable the difficulty change timer
        Me.zDifficultyChangeTimer.Enabled = True
        'Sets the game runing
        Me.yInGame = True
    End Sub

    'Triggers every set amount of time
    Private Sub MovementTick() Handles zMovementTimer.Tick
        'Checks if the keyboard is used
        If zKeyboard.Checked Then
            'If the up arrow is pressed then...
            If yUpArrow And CInt(yPlayerLocation) - ySenitivity >= 0 Then
                'Move the player up one 
                yPlayerLocation = CByte(yPlayerLocation - ySenitivity)
                'if the down arrow is pressed then...
            ElseIf yDownArrow And CInt(yPlayerLocation) + ySenitivity <= Byte.MaxValue Then
                'Moves the player down
                yPlayerLocation = CByte(yPlayerLocation + ySenitivity)
            End If
        End If

        'Sets the segment's heights back one
        For Index As Integer = 1 To yZoom
            'Sets the previous segment to the current one
            ySegmentHeight(Index - 1) = ySegmentHeight(Index)

        Next

        'Sets the last segment to change
        ySegmentHeight(yZoom) = RandomHeight()
        'Makes a number to record the calucated positoin of the player location
        Dim Number As Integer = CInt((yPlayerLocation / Byte.MaxValue) * Me.ClientSize.Height)

        'Checks if the player is touching black
        If Not (Number > CInt((ySegmentHeight(0) / Byte.MaxValue) * (Me.ClientSize.Height - (Me.ClientSize.Height / 3))) And _
                Number < CInt(((ySegmentHeight(0) - 22) / Byte.MaxValue) * (Me.ClientSize.Height - (Me.ClientSize.Height / 3)) + (Me.ClientSize.Height / 3))) Then

            'Checks if the score is more than the maximum number and sets the higher number
            If yScore > yHighestScore Then yHighestScore = yScore
            'Reset the score
            yScore = 0
        ElseIf yScore < 999999999 Then
            'Increases the score depending on the difficulty and speed
            yScore += yCalculated
        Else
            yScore = 999999999
        End If
        'Draws the screen
        Call Draw()
    End Sub

    'Changes the difficulty every something secounds
    Private Sub zDifficultyChangeTimer_Tick() Handles zDifficultyChangeTimer.Tick
        'Works out the calcuated change every movement tick
        yCalculated = Math.Abs((zMovementTimer.Interval \ 10) - 10) * yStartingDifficulty
        'Increases the difficulty by 1 if the starting difficulty is less than 86
        If yStartingDifficulty < 86 Then yStartingDifficulty += 1
    End Sub

#Region "Game Over"

    'Shows a message box when the game it is exited
    Private Sub ExitGame() Handles zMenuButton.Click
        'Resizes the controls
        Call Screen_SizeChanged()
        'Sets the name to "Endless Cave"
        Me.Text = Application.ProductName
        'Clears the form with the backcolour
        Me.CreateGraphics.Clear(Me.BackColor)
        'Stops the movement timer
        Me.zMovementTimer.Enabled = False
        'Stops the game
        Me.yInGame = False
        'Stops the difficulty changing
        Me.zDifficultyChangeTimer.Enabled = False
        'Checks if the score is more than highest score
        If yScore > yHighestScore Then yHighestScore = yScore
        'Sets the score to highest score
        Me.yScore = yHighestScore
        'Makes names for positions
        Dim Place() As String = {"first", "second", "third"}
        'Sets the tab to gameover
        'Doesn't need to always have input screen
        Dim NeedInputScreen As Boolean = False

        'Checks if the current score is more than the one in the highscores
        For Counter As Integer = 0 To 2
            'Checks if the score is more than the currect highscore socre
            If yScore > yHighscoreRecord(Counter).Score Then
                'Needs to keep on gameover screen untill textbox is filled
                NeedInputScreen = True
                'Shows the messagebox
                MessageBox.Show("Your score is: " & yScore.ToString & ". You have reached " & Place(Counter) & " place.", "Game Over.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                'If the score is the maximum say the user he/she is grank master
                If yScore >= 999999999 Then MessageBox.Show("You are a grand master!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Exit so it doesn't check anymore
                Exit For
            End If
        Next

        'Checks if need to keep on gameover
        If NeedInputScreen Then
            'Hides the stuff
            Visiblity(False)
            GameOverStuff(True)

        Else
            'Goes to start
            Me.TabControlDisplay.SelectedTab = Me.TabPageStart
            'Say it didn't make it to thrid place
            MessageBox.Show("Your score is: " & yScore.ToString & ". You didn't make it to third place.", "Game Over.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
        Me.TabControlDisplay.Visible = False
    End Sub

    'Sets name for ok button
    Private Sub zGameOverOkButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles zGameOverOkButton.Click
        'Makes a boolean so that if the user beaten a highscore, it will go to the gameover screen
        Dim Retry As Boolean = False

        'Checks if the current score is more than the one in the highscores
        For Counter As Integer = 0 To 2
            'Checks if the score is more than the currect highscore socre
            If yScore > yHighscoreRecord(Counter).Score Then
                'Ask the player the question below
                Dim Name As String = Me.zGameOverTextBox.Text
                'Sets the name to unnamed
                If Name = String.Empty Then
                    'Shows message box that the text is not valid
                    MessageBox.Show("The entered text is not valid. Make sure that the name is filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    'Redo the action
                    Retry = True
                Else
                    'Checks if the place is at first place
                    If Counter = 0 Then
                        'Sets the name backwards
                        Me.yHighscoreRecord(2).Name = yHighscoreRecord(1).Name
                        Me.yHighscoreRecord(2).Score = yHighscoreRecord(1).Score
                        Me.yHighscoreRecord(1).Name = yHighscoreRecord(0).Name
                        Me.yHighscoreRecord(1).Score = yHighscoreRecord(0).Score
                        'If the score is 1...
                    ElseIf Counter = 1 Then
                        'Sets the name backwards
                        Me.yHighscoreRecord(2).Name = yHighscoreRecord(1).Name
                        Me.yHighscoreRecord(2).Score = yHighscoreRecord(1).Score
                    End If
                    'Sets the place to the user
                    Me.yHighscoreRecord(Counter).Score = yScore
                    Me.yHighscoreRecord(Counter).Name = Name
                End If
                'Doesn't goes through the other scores
                Exit For
            End If
        Next

        'Checks if need to go back the the fill in box
        If Not Retry Then
            'Sets the tab to start
            Me.TabControlDisplay.SelectedTab = Me.TabPageStart
            'Shows controls
            Call Visiblity(True)
            GameOverStuff(False)
            'Set settings
            SetSettings()
        End If
    End Sub

    'Sets name for cancel button
    Private Sub zGameOverCancelButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles zGameOverCancelButton.Click
        'Checks if the current score is more than the one in the highscores
        For Counter As Integer = 0 To 2
            'Checks if the score is more than the currect highscore socre
            If yScore > yHighscoreRecord(Counter).Score Then
                'Ask the player the question below
                'Sets the name to unnamed
                'If the score is 0...
                If Counter = 0 Then
                    'Sets the name backwards
                    yHighscoreRecord(2).Name = yHighscoreRecord(1).Name
                    yHighscoreRecord(2).Score = yHighscoreRecord(1).Score
                    yHighscoreRecord(1).Name = yHighscoreRecord(0).Name
                    yHighscoreRecord(1).Score = yHighscoreRecord(0).Score
                    'If the score is 1...
                ElseIf Counter = 1 Then
                    'Sets the name backwards
                    yHighscoreRecord(2).Name = yHighscoreRecord(1).Name
                    yHighscoreRecord(2).Score = yHighscoreRecord(1).Score
                End If
                'Sets the player's name
                yHighscoreRecord(Counter).Score = yScore
                yHighscoreRecord(Counter).Name = "Unnamed"
            End If

            'Doesn't goes through the other scores
            Exit For
        Next
        'Sets the tab so it views the start
        Me.TabControlDisplay.SelectedTab = Me.TabPageStart
        'Shows controls
        Visiblity(True)
        GameOverStuff(False)
        'Saves the data
        SetSettings()
    End Sub

    'Allows users to exit
    Private Sub zGameOverTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles zGameOverTextBox.KeyDown
        'If the enter key is pressed, the ok button is clicked
        If e.KeyCode = Keys.Enter Then Call zGameOverOkButton_Click(Nothing, Nothing)
    End Sub

#End Region

#End Region 'Main part of the application

#Region "Misc"

    'Makes a number for the height of the next segment
    Private Function RandomHeight() As Byte
        'Makes an integer so it can handle ups and downs
        Dim Temp As Integer = ySegmentHeight(yZoom)
        'Makes a line for the random number between the diffilcultys
        Dim Line As Integer = yMaker.Next(-yStartingDifficulty, yStartingDifficulty + 1)

        'Checks if the line is too big 
        If Line + Temp > Byte.MaxValue Then
            'Sets the line to negitive 10
            Line = -10
            'If that fails it checks if line is too small
        ElseIf Line + Temp < Byte.MinValue Then
            'Sets the line to 10
            Line = 10
        End If

        'Changes change by line
        yChange += Line

        'Checks if the change is too big
        If yChange > Byte.MaxValue Then
            'Sets the change by negitive difficulty
            yChange = Byte.MaxValue - yStartingDifficulty
            'If that fails and change is too small
        ElseIf yChange < Byte.MinValue Then
            'Sets change to difficulty
            yChange = Byte.MinValue + yStartingDifficulty
        End If

        'Checks if the change is too big
        If yChange > Byte.MaxValue Then
            'Sets the change by negitive difficulty
            Return Byte.MaxValue
            'If that fails and change is too small
        ElseIf yChange < Byte.MinValue Then
            'Sets change to difficulty
            Return Byte.MinValue
        Else
            'Returns the change
            Return CByte(yChange)
        End If
    End Function

    'Sets the visiblity of controls
    Private Sub Visiblity(ByVal InputBoolean As Boolean)
        'Stops click events of the menu
        Me.zMenu.Enabled = InputBoolean
        'Stops click events of the menu
        Me.xStartToolStripMenuItem.Enabled = InputBoolean
        'Stops click events of the menu
        Me.xInstructionToolStripMenuItem.Enabled = InputBoolean
        'Stops click events of the menu
        Me.xFileToolStripMenuItem.Enabled = InputBoolean
        'Stops click events of the menu
        Me.xOptionsToolStripMenuItem.Enabled = InputBoolean
        'Stops click events of the menu
        Me.xHelpToolStripMenuItem.Enabled = InputBoolean
        'Sets the view of the tabs
        If InputBoolean = False Then
            Me.TabControlDisplay.Dock = DockStyle.None
            Me.TabControlDisplay.Height = 0
        Else
            Me.TabControlDisplay.Dock = DockStyle.Fill
            Me.TabControlDisplay.Visible = True
        End If
        'Stops click events of the menu
        Me.TabControlDisplay.Enabled = InputBoolean
        Me.zMenuButton.Enabled = InputBoolean
        'Sets the view of the tabs
        Me.zMenuButton.Visible = InputBoolean
    End Sub

    Sub GameOverStuff(ByVal Show As Boolean)
        Me.zGameOverTextBox.Enabled = Show
        'Sets the view of the tabs
        Me.zGameOverTextBox.Visible = Show
        'Sets the view of the tabs
        Me.zGameOverLabel.Visible = Show
        'Stops click events of the menu
        Me.zGameOverOkButton.Enabled = Show
        'Sets the view of the tabs
        Me.zGameOverOkButton.Visible = Show
        'Stops click events of the menu
        Me.zGameOverCancelButton.Enabled = Show
        'Sets the view of the tabs
        Me.zGameOverCancelButton.Visible = Show

    End Sub

    'Returns Myles Lee
    Private Function MyName() As String
        'Stores the number code for each character
        Dim Numbers() As Integer = {77, 121, 108, 101, 115, 76, 32}
        '                          "M" "y"  "l"  "e"  "s"  "L" " "
        '                           0   1    2    3    4    5   6
        'Returns the string format of charateres by numbers
        Return Chr(Numbers(0)) & _
               Chr(Numbers(1)) & _
               Chr(Numbers(2)) & _
               Chr(Numbers(3)) & _
               Chr(Numbers(4)) & _
               Chr(Numbers(6)) & _
               Chr(Numbers(5)) & _
               Chr(Numbers(3)) & _
               Chr(Numbers(3))
    End Function

    Private Sub SetSettings()

        My.Settings.Record_0_Name = yHighscoreRecord(0).Name
        My.Settings.Record_0_Score = yHighscoreRecord(0).Score
        My.Settings.Record_1_Name = yHighscoreRecord(1).Name
        My.Settings.Record_1_Score = yHighscoreRecord(1).Score
        My.Settings.Record_2_Name = yHighscoreRecord(2).Name
        My.Settings.Record_2_Score = yHighscoreRecord(2).Score

        My.Settings.Save()

    End Sub

#End Region 'Other subs and functions

End Class