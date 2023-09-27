Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    'Declare an array of games 
    Dim gameArray(99) As Game

    'Declare a boolean that will be used as the indicator for unsaved changes (possibly change later, no idea how to do this any other way)
    Private unsavedChanges As Boolean = False

    'DISABLE BUTTONS AT THE START, WE WILL ENABLE THEM LATER
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Disable the buttons initially
        btnClear.Enabled = False
        btnUpdate.Enabled = False
        btnAdd.Enabled = False
        btnDelete.Enabled = False
    End Sub



    'BUTTONS CLICKED FROM HERE DOWN
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


        'VALIDATION WILL BE AT THE FORM LEVEL, USE AN ERROR MESSAGE.
        'Validate all fields
        'trim inputs
        Dim name As String = txtName.Text.Trim()
        If String.IsNullOrWhiteSpace(name) Then
            MessageBox.Show("Please enter a valid name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim publisher As String = txtPublisher.Text.Trim()
        If String.IsNullOrWhiteSpace(publisher) Then
            MessageBox.Show("Please enter a valid publisher.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim intYear As Integer
        If Not Integer.TryParse(txtYear.Text, intYear) Then
            MessageBox.Show("Please enter a valid year.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If intYear < 2000 Or intYear > 2013 Then
            MessageBox.Show("Year must be between 2000 and 2013.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not rdoNTSC.Checked And Not rdoPAL.Checked Then
            MessageBox.Show("Please select a region.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'declare 
        Dim strRegion As String = ""

        If rdoNTSC.Checked Then
            strRegion = "NTSC"
        ElseIf rdoPAL.Checked Then
            strRegion = "PAL"
        End If

        'create a new game entry based on the entered text
        'Use the Game class, and base the data passed into the new game using the trimmed textboxes
        Dim newGame As New Game(name, publisher, intYear, chkSealed.Checked, strRegion)

        'Add the new game to the gamesList array
        AddGame(newGame)

        'update lstGames
        lstBoxGames.Items.Add(newGame.ToString())

        'Set the flag indicating unsaved changes
        unsavedChanges = True


    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear out all form inputs
        txtName.Clear()
        txtPublisher.Clear()
        txtYear.Clear()

        'clear all buttons 
        chkSealed.Checked = False
        rdoNTSC.Checked = False
        rdoPAL.Checked = False

        'disable buttons
        btnClear.Enabled = False
        btnUpdate.Enabled = False
        btnAdd.Enabled = False
        btnDelete.Enabled = False

        'clear out the list
        lstBoxGames.Items.Clear()
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'update the value of a selected item within lstGames

        'VALIDATION WILL BE AT THE FORM LEVEL, USE AN ERROR MESSAGE.
        'Validate all fields
        Dim name As String = txtName.Text.Trim()
        If String.IsNullOrWhiteSpace(name) Then
            MessageBox.Show("Please enter a valid name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim publisher As String = txtPublisher.Text.Trim()
        If String.IsNullOrWhiteSpace(publisher) Then
            MessageBox.Show("Please enter a valid publisher.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim intYear As Integer
        If Not Integer.TryParse(txtYear.Text, intYear) Then
            MessageBox.Show("Please enter a valid year.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If intYear < 2000 Or intYear > 2013 Then
            MessageBox.Show("Year must be between 2000 and 2013.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not rdoNTSC.Checked And Not rdoPAL.Checked Then
            MessageBox.Show("Please select a region.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'declare 
        Dim strRegion As String = ""

        If rdoNTSC.Checked Then
            strRegion = "NTSC"
        ElseIf rdoPAL.Checked Then
            strRegion = "PAL"
        End If

        'get the selected game index from lstBoxGames
        Dim selectedIndex As Integer = lstBoxGames.SelectedIndex

        'check if a game is selected
        If selectedIndex <> -1 Then
            'get the game object from the gameArray based on the selected index
            Dim selectedGame As Game = gameArray(selectedIndex)

            'update the game object with the new values
            selectedGame.Name = name
            selectedGame.Publisher = publisher
            selectedGame.Year = intYear
            selectedGame.Sealed = chkSealed.Checked
            selectedGame.Region = strRegion

            'update the item in lstBoxGames
            lstBoxGames.Items(selectedIndex) = selectedGame.ToString()

            'Set the flag indicating unsaved changes
            unsavedChanges = True
        Else
            MessageBox.Show("Please select a game to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Get the selected game
        Dim selectedGameIndex As Integer = lstBoxGames.SelectedIndex

        ' Ensure a valid selection
        If selectedGameIndex >= 0 AndAlso selectedGameIndex < gameArray.Length AndAlso gameArray(selectedGameIndex) IsNot Nothing Then
            ' Display a confirmation dialog box
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this game?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Remove the game from the gameArray
                gameArray(selectedGameIndex) = Nothing

                ' Remove the item from the list box
                lstBoxGames.Items.RemoveAt(selectedGameIndex)

                ' Clear the form inputs
                txtName.Clear()
                txtPublisher.Clear()
                txtYear.Clear()
                chkSealed.Checked = False
                rdoNTSC.Checked = False
                rdoPAL.Checked = False

                'Set the flag indicating unsaved changes
                unsavedChanges = True

            End If
        End If



    End Sub



    'SAVE/OPEN MENU ITEMS FROM HERE DOWN
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

        'Check if the list already has items
        If lstBoxGames.Items.Count > 0 Then
            MessageBox.Show("File is already open! Please close before opening another file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ReadGameDataFromFile()
        DisplayGames()

        'Enable the buttons
        btnClear.Enabled = True
        btnUpdate.Enabled = True
        btnAdd.Enabled = True
        btnDelete.Enabled = True

    End Sub


    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click

        'check if the list box contains any items
        If lstBoxGames.Items.Count = 0 Then
            MessageBox.Show("The list already contains items. Please clear the list before opening a new file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'save from the array to the text file
        Using outFile As New IO.StreamWriter("Games.txt")

            'write each game's information to a separate line, each bit of info per game separted by "|"
            For Each game As Game In gameArray
                If game IsNot Nothing Then

                    outFile.WriteLine(game.Name & "|" & game.Publisher & "|" & game.Year & "|" & game.Sealed & "|" & game.Region)
                End If
            Next
        End Using

        'Reset the flag indicating unsaved changes
        unsavedChanges = False

    End Sub



    'PRIVATE SUBS TO BE CALLED UPON THAT HELP WITH CODING FROM HERE DOWN
    Private Sub AddGame(newGame As Game)
        'Find the first empty slot in the gamesList array
        Dim i As Integer = 0
        While i < gameArray.Length AndAlso gameArray(i) IsNot Nothing
            i += 1
        End While

        'If the array is full, display an error message and exit
        If i = gameArray.Length Then
            MessageBox.Show("Game list is full.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Add the new game to the gamesList array
        gameArray(i) = newGame
    End Sub


    Private Sub DisplayGames()
        'Add each game in the gamesList array to the lstbox control
        For Each game As Game In gameArray
            'Skip null elements
            If game IsNot Nothing Then
                lstBoxGames.Items.Add(game.ToString())
            End If
        Next
    End Sub


    Private Sub ReadGameDataFromFile()
        'Clear the existing gameArray
        Array.Clear(gameArray, 0, gameArray.Length)

        'Read game data from the file
        Using reader As New IO.StreamReader("Games.txt")
            Dim line As String
            Dim index As Integer = 0

            'Read each line from the file
            While (reader.Peek() <> -1)
                line = reader.ReadLine()

                'Split the line into fields using the '|' delimiter
                Dim fields() As String = line.Split("|"c)

                'Ensure that the line has the expected number of fields
                If fields.Length = 5 Then
                    'Extract the values from the fields
                    Dim name As String = fields(0)
                    Dim publisher As String = fields(1)
                    Dim year As Integer
                    Integer.TryParse(fields(2), year)
                    Dim sealed As Boolean
                    Boolean.TryParse(fields(3), sealed)
                    Dim region As String = fields(4)

                    'Create a new Game instance with the extracted values
                    Dim game As New Game(name, publisher, year, sealed, region)

                    'Add the game to the gameArray
                    gameArray(index) = game
                    index += 1

                    'Exit the loop if the gameArray is full
                    If index >= gameArray.Length Then
                        Exit While
                    End If
                End If
            End While
        End Using
    End Sub


    'PUT THE LISTBOX ITEMS INTO THE TEXTBOXES WHEN SELECTED
    Private Sub lstBoxGames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBoxGames.SelectedIndexChanged
        'Get the selected game
        Dim selectedGameIndex As Integer = lstBoxGames.SelectedIndex

        'Ensure a valid selection
        If selectedGameIndex >= 0 AndAlso selectedGameIndex < gameArray.Length AndAlso gameArray(selectedGameIndex) IsNot Nothing Then
            'Load the game information into the form fields
            Dim selectedGame As Game = gameArray(selectedGameIndex)
            txtName.Text = selectedGame.Name
            txtPublisher.Text = selectedGame.Publisher
            txtYear.Text = selectedGame.Year.ToString()
            chkSealed.Checked = selectedGame.Sealed

            If selectedGame.Region = "NTSC" Then
                rdoNTSC.Checked = True
            ElseIf selectedGame.Region = "PAL" Then
                rdoPAL.Checked = True
            End If
        End If
    End Sub


    'KEYPRESS VALIDATION, ONLY NUMBERS
    Private Sub txtYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtYear.KeyPress
        'Check if the pressed key is a digit (0-9)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            'If the pressed key is not a digit and not a control key (e.g., Backspace), ignore it
            e.Handled = True
        End If
    End Sub


    'EXIT THE FORM
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'AS THE FORM CLOSES, MAKE SURE USER WANTS TO ACTUALLY LEAVE IF THEY DIDNT SAVE
    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If unsavedChanges = True Then
            ' Display a warning message if there are unsaved changes
            Dim result As DialogResult = MessageBox.Show("You have unsaved changes. Are you sure you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.No Then
                'Cancel the form closing event to prevent the form from closing
                e.Cancel = True
            End If
        End If
    End Sub

End Class


