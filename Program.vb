Imports System

Module Menu
    'Declares useable menu names as enum
    Enum MenuName
        _MainMenu
        _Programming
    End Enum

    'Calls main menu in Menu
    Sub Main()
        Menu(MenuName._MainMenu)
    End Sub

    Sub Menu()
        'Declare 2D array of all available menus
        Dim Menus(,) as String = {{"Programming"},{" "}}

        'Declares user's selected option as an integer
        Dim SelectedOption as Integer = 0
        
        'Ensures user can go back to previous menus
        Dim BackspacePressed as Boolean = False

        'Loops menu until program is closed
        Do
            'Makes the cursor invisible and clears the console
            Console.CursorVisible = False
            Console.Clear()

            'Select which menu to display
            Select Case SelectedMenu
                Case MenuName._MainMenu
                    If BackspacePressed Then
                        BackspacePressed = True
                    End If


            End Select
        Loop
    End Sub()

    Sub MenuInterface(ByRef SelectedMenu as MenuName, ByRef SelectedOption as Integer, ByRef BackspacePressed as Boolean, Menus(,) as String, MenuSize as Integer)
        'Stores information from Console.ReadKey()
        Dim MenuSelect as ConsoleKeyInfo

        'Reset select option to 0
        SelectedOption = 0

        'Loops menu interface until enter is pressed
        Do
            'Displays selected menu information
            Select Case SelectedMenu
                Case MenuName._MainMenu
                    Console.WriteLine("Main Menu:               Navigate using arrows. Enter to select. Backspace to return.")
                Case MenuName._ModerationTasks
                    Console.WriteLine("Moderation Tasks:        Navigate using arrows. Enter to select. Backspace to return.")
                Case MenuName._ProgrammingTasks
                    Console.WriteLine("Programming Tasks:       Navigate using arrows. Enter to select. Backspace to return.")
                Case MenuName._ExtensionTasks
                    Console.WriteLine("Extension Tasks:         Navigate using arrows. Enter to select. Backspace to return.")
            End Select

                       'Displays selected menu with selected option highlighted
            For x = 0 To MenuSize - 1
                'Adds a line break every four options
                If x Mod 3 = 0 Then
                    Console.WriteLine()
                End If
                If SelectedOption = x Then
                    'Displays user's selected item in magenta
                    Console.ForegroundColor = ConsoleColor.Magenta
                    Console.Write(Menus(SelectedMenu, x).PadRight(30, " "))
                    'Sets the color back to white
                    Console.ForegroundColor = ConsoleColor.White
                Else
                    'Displays unselected items
                    Console.Write(Menus(SelectedMenu, x).PadRight(30, " "))
                End If
            Next

            'Changes user's selected option in menu based on keypress
            MenuSelect = Console.ReadKey()
            Select Case MenuSelect.Key
                Case ConsoleKey.Backspace
                    'Takes user back to the main menu
                    SelectedMenu = MenuName._MainMenu
                    BackspacePressed = True
                    Console.Clear()
                    Return
                Case ConsoleKey.LeftArrow
                    'Checks if it can move selected option left
                    If SelectedOption - 1 > -1 Then
                        'Moves selected option left
                        SelectedOption = SelectedOption - 1
                    End If
                Case ConsoleKey.RightArrow
                    'Checks if it can move selected option right
                    If SelectedOption + 1 < MenuSize Then
                        'Moves selected option right
                        SelectedOption = SelectedOption + 1
                    End If
                Case ConsoleKey.UpArrow
                    'Checks if it can move selected option up
                    If SelectedOption - 3 > -1 Then
                        'Moves selected option up
                        SelectedOption = SelectedOption - 3
                    End If
                Case ConsoleKey.DownArrow
                    'Checks if it can move selected option down
                    If SelectedOption + 3 < MenuSize Then
                        'Moves selected option down
                        SelectedOption = SelectedOption + 3
                    End If
            End Select
            Console.Clear()
        Loop Until MenuSelect.Key = ConsoleKey.Enter
        
        'Makes cursor visible
        Console.CursorVisible = True
        Loop
    End Sub()
End Module
