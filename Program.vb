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

    Sub MenuInterface(ByRef SelectedMenu as MenuName)
    End Sub()
End Module
