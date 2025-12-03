Imports System

Module Menu
    'Declares useable menu names as enum
    Enum MenuName
        _MainMenu
        __ComputerScience
        ___Programming
        ____Basics
        ____Selection
        ____Iteration
        ____Arrays
        ____Subroutines
        ____FileAndExceptionHandling
        ____StructuredProgramming
        ____ContactsList
        ___DataStructures
        ___Algorithms
        ___Computation
        ___DataRepresentation
        ____NumberSystems
        ____BinaryArithmetic
        ____BitsAndBytes
        ____CharacterCoding
        ____SoundRepresentation
        ____ImageRepresentation
        ____CompressionAndEncryption
        ___ComputerSystems
        ____HardwareAndSoftware
        ____RoleOfTheOS
        ___OrganizationAndArchitecture
        ___ConsequencesOfUse
        ___CommunicationAndNetworking
        ___Databases
        ___BigData
        ___FunctionalProgramming
        ___ProblemSolving
        __Geography
        __Mathematics
    End Enum

    'Calls main menu in Menu
    Sub Main()
        Menu(MenuName._MainMenu)
    End Sub

    Private PreviousMenu as MenuName

    Sub Menu(SelectedMenu as MenuName)
        'Declare 2D array of all available menus
        Dim Menus(,) as String = {{"Programming", "Data Structures", "Algorithms", "Computation", "Data Representation", "Computer Systems", "Organization & Architecture", "Consequence of Use", "Communication & Networking", "Databases", "Big Data", "Functional Programming", "Problem Solving"},
                                  {"Basics", "Selection", "Iteration", "Arrays", "Subroutines", "File & Exception Handling", "Structured Programming", "Contacts List", " ", " ", " ", " ", " "},
                                  {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                  {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                  {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                  {"Number Systems", "Binary Arithmetic", "Bits & Bytes", "Character Coding", "Sound Representation", "Image Representation", "Compression & Encryption", " ", " ", " ", " ", " ", " "},
                                  {"Hardware & Software", "Role Of The OS", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                  {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                  {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                  {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                  {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                  {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                  {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                  {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "}}

        'Declares user's selected option as an integer
        Dim SelectedOption as Integer = 0

        'Ensures user can go back to previous menus
        Dim BackspacePressed as Boolean = False

        'Loops menu until program is closed
        Do
            'Makes the cursor invisible and clears the console
            Console.CursorVisible = False
            Console.Clear()


            'If BackspacePressed is true it's set to false
            If BackspacePressed Then
                BackspacePressed = False
            End If

            'Select which menu to display
            Select Case SelectedMenu
                Case MenuName._MainMenu
                    'Calls menu interface with MainMenu information
                    MenuInterface(SelectedMenu, SelectedOption, BackspacePressed, Menus, 13)

                    'Skips menus if backspace was pressed
                    If Not BackspacePressed Then
                    'Decides which menu to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                SelectedMenu = MenuName.__ComputerScience
                            Case 1
                                SelectedMenu = MenuName.__Geography
                            Case 2
                                SelectedMenu = MenuName.__Mathematics
                        End Select
                    End If
                
                Case MenuName.__ComputerScience
                    'Calls menu interface with ComputerScience information
                    MenuInterface(SelectedMenu, SelectedOption, BackspacePressed, Menus, 13)

                    'Skips menus if backspace was pressed
                    If Not BackspacePressed Then
                        'Decides which menu to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                SelectedMenu = MenuName.___Programming
                            Case 1
                                SelectedMenu = MenuName.___DataStructures
                            Case 2
                                SelectedMenu = MenuName.___Algorithms
                            Case 3
                                SelectedMenu = MenuName.___Computation
                            Case 4
                                SelectedMenu = MenuName.___DataRepresentation
                            Case 5
                                SelectedMenu = MenuName.___ComputerSystems
                            Case 6
                                SelectedMenu = MenuName.___OrganizationAndArchitecture
                            Case 7
                                SelectedMenu = MenuName.___ConsequencesOfUse
                            Case 8
                                SelectedMenu = MenuName.___CommunicationAndNetworking
                            Case 9
                                SelectedMenu = MenuName.___Databases
                            Case 10
                                SelectedMenu = MenuName.___BigData
                            Case 11
                                SelectedMenu = MenuName.___FunctionalProgramming
                            Case 12
                                SelectedMenu = MenuName.___ProblemSolving
                        End Select
                    End If

                Case MenuName.___Programming
                    'Calls menu interface with Programming information
                    MenuInterface(SelectedMenu, SelectedOption, BackspacePressed, Menus, 8)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                SelectedMenu = MenuName.____Basics
                            Case 1
                                SelectedMenu = MenuName.____Selection
                            Case 2
                                SelectedMenu = MenuName.____Iteration
                            Case 3
                                SelectedMenu = MenuName.____Arrays
                            Case 4
                                SelectedMenu = MenuName.____Subroutines
                            Case 5
                                SelectedMenu = MenuName.____FileAndExceptionHandling
                            Case 6
                                SelectedMenu = MenuName.____StructuredProgramming
                            Case 7
                                SelectedMenu = MenuName.____ContactsList
                        End Select
                    End If
                
                Case MenuName.____Basics

                Case MenuName.____Selection

                Case MenuName.____Iteration

                Case MenuName.____Arrays

                Case MenuName.____Subroutines

                Case MenuName.____FileAndExceptionHandling

                Case MenuName.____StructuredProgramming

                Case MenuName.____ContactsList

                Case MenuName._DataStructures
                    'Calls menu interface with DataStructures information
                    MenuInterface(SelectedMenu, SelectedOption, BackspacePressed, Menus, 0)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call subroutine here
                        End Select
                    End If
                
                Case MenuName._Algorithms
                    'Calls menu interface with Algorithms information
                    MenuInterface(SelectedMenu, SelectedOption, BackspacePressed, Menus, 0)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call subroutine here
                        End Select
                    End If
                
                Case MenuName._Computation
                    'Calls menu interface with Computation information
                    MenuInterface(SelectedMenu, SelectedOption, BackspacePressed, Menus, 0)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call subroutine here
                        End Select
                    End If
                
                Case MenuName._DataRepresentation
                    'Calls menu interface with Programming information
                    MenuInterface(SelectedMenu, SelectedOption, BackspacePressed, Menus, 7)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                NumberSystems()
                            Case 1
                                BinaryArithmetic()
                            Case 2
                                BitsAndBytes()
                            Case 3
                                CharacterCoding()
                            Case 4
                                SoundRepresentation()
                            Case 5
                                ImageRepresentation()
                            Case 6
                                CompressionAndEncryption()
                        End Select
                    End If
                
                Case MenuName._ComputerSystems
                    'Calls menu interface with ComputerSystems information
                    MenuInterface(SelectedMenu, SelectedOption, BackspacePressed, Menus, 2)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                HardwareAndSoftware()
                            Case 1
                                RoleOfTheOS()
                        End Select
                    End If
                
                Case MenuName._OrganizationAndArchitecture
                    'Calls menu interface with OrganizationAndArchitecture information
                    MenuInterface(SelectedMenu, SelectedOption, BackspacePressed, Menus, 0)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call subroutine here
                        End Select
                    End If
                
                Case MenuName._ConsequencesOfUse
                    'Calls menu interface with ConsequencesOfUse information
                    MenuInterface(SelectedMenu, SelectedOption, BackspacePressed, Menus, 0)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call subroutine here
                        End Select
                    End If
                
                Case MenuName._CommunicationAndNetworking
                    'Calls menu interface with CommunicationAndNetworking information
                    MenuInterface(SelectedMenu, SelectedOption, BackspacePressed, Menus, 0)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call subroutine here
                        End Select
                    End If
                
                Case MenuName._Databases
                    'Calls menu interface with Databases information
                    MenuInterface(SelectedMenu, SelectedOption, BackspacePressed, Menus, 0)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call subroutine here
                        End Select
                    End If
                
                Case MenuName._BigData
                    'Calls menu interface with BigData information
                    MenuInterface(SelectedMenu, SelectedOption, BackspacePressed, Menus, 0)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call subroutine here
                        End Select
                    End If
                
                Case MenuName._FunctionalProgramming
                    'Calls menu interface with FunctionalProgramming information
                    MenuInterface(SelectedMenu, SelectedOption, BackspacePressed, Menus, 0)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call subroutine here
                        End Select
                    End If
                
                Case MenuName._ProblemSolving
                    'Calls menu interface with ProblemSolving information
                    MenuInterface(SelectedMenu, SelectedOption, BackspacePressed, Menus, 0)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call subroutine here
                        End Select
                    End If
                
            End Select
        Loop
    End Sub

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
                    Console.WriteLine("Main Menu:                           Navigate using arrows. Enter to select. Backspace to return.")
                Case MenuName._Programming
                    Console.WriteLine("Programming:                         Navigate using arrows. Enter to select. Backspace to return.")
                Case MenuName._DataStructures
                    Console.WriteLine("Data Structures:                     Navigate using arrows. Enter to select. Backspace to return.")
                Case MenuName._Algorithms
                    Console.WriteLine("Algorithms:                          Navigate using arrows. Enter to select. Backspace to return.")
                Case MenuName._Computation
                    Console.WriteLine("Computation:                         Navigate using arrows. Enter to select. Backspace to return.")
                Case MenuName._DataRepresentation
                    Console.WriteLine("Data Representation:                 Navigate using arrows. Enter to select. Backspace to return.")
                Case MenuName._ComputerSystems
                    Console.WriteLine("Computer Systems:                    Navigate using arrows. Enter to select. Backspace to return.")
                Case MenuName._OrganizationAndArchitecture
                    Console.WriteLine("Organization & Architecture:         Navigate using arrows. Enter to select. Backspace to return.")
                Case MenuName._ConsequencesOfUse
                    Console.WriteLine("Consequences Of Use:                 Navigate using arrows. Enter to select. Backspace to return.")
                Case MenuName._CommunicationAndNetworking
                    Console.WriteLine("Communication & Networking:          Navigate using arrows. Enter to select. Backspace to return.")
                Case MenuName._Databases
                    Console.WriteLine("Databases:                           Navigate using arrows. Enter to select. Backspace to return.")
                Case MenuName._BigData
                    Console.WriteLine("Big Data:                            Navigate using arrows. Enter to select. Backspace to return.")
                Case MenuName._FunctionalProgramming
                    Console.WriteLine("Functional Programming:              Navigate using arrows. Enter to select. Backspace to return.")
                Case MenuName._ProblemSolving
                    Console.WriteLine("Problem Solving:                     Navigate using arrows. Enter to select. Backspace to return.")
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

            'Changes user's selected option in menu based on key press
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
    End Sub
End Module

Module Programming
    Sub Basics()

    End Sub

    Sub Selection()

    End Sub

    Sub Iteration()

    End Sub

    Sub Arrays()

    End Sub

    Sub Subroutines()

    End Sub

    Sub FileAndExceptionHandling()

    End Sub

    Sub StructuredProgramming()

    End Sub

    Enum ContactsListMenuName
        _MainMenu
    End Enum

    Sub ContactsList()

    End Sub
End Module

Module DataStructures

End Module

Module Algorithms

End Module

Module Computation

End Module

Module DataRepresentation
    Sub NumberSystems()

    End Sub

    Sub BinaryArithmetic()

    End Sub

    Sub BitsAndBytes()

    End Sub

    Sub CharacterCoding()

    End Sub

    Sub SoundRepresentation()

    End Sub

    Sub ImageRepresentation()

    End Sub

    Sub CompressionAndEncryption()

    End Sub
End Module

Module ComputerSystems
    Sub HardwareAndSoftware()

    End Sub

    Sub RoleOfTheOS()

    End Sub
End Module

Module OrganizationAndArchitecture

End Module

Module Databases

End Module

Module BigData

End Module

Module FunctionalProgramming

End Module

Module ProblemSolving

End Module