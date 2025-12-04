Imports System

Module Menu
    'Calls Menu
    Sub Main()
        Menu()
    End Sub

    'Stores useable menu names as enums
    Enum MenuName
        _MainMenu
        
        'ComputerScience section
        _MainMenu_ComputerScience

        'Programming category
        _MainMenu_ComputerScience_Programming
        _MainMenu_ComputerScience_Programming_Basics
        _MainMenu_ComputerScience_Programming_Selection
        _MainMenu_ComputerScience_Programming_Iteration
        _MainMenu_ComputerScience_Programming_Arrays
        _MainMenu_ComputerScience_Programming_Subroutines
        _MainMenu_ComputerScience_Programming_FileAndExceptionHandling
        _MainMenu_ComputerScience_Programming_StructuredProgramming
        _MainMenu_ComputerScience_Programming_ContactsList

        'DataStructures category
        _MainMenu_ComputerScience_DataStructures

        'Algorithms category
        _MainMenu_ComputerScience_Algorithms

        'Computation category
        _MainMenu_ComputerScience_Computation

        'DataRepresentation category
        _MainMenu_ComputerScience_DataRepresentation
        _MainMenu_ComputerScience_DataRepresentation_NumberSystems
        _MainMenu_ComputerScience_DataRepresentation_BinaryArithmetic
        _MainMenu_ComputerScience_DataRepresentation_BitsAndBytes
        _MainMenu_ComputerScience_DataRepresentation_CharacterCoding
        _MainMenu_ComputerScience_DataRepresentation_SoundRepresentation
        _MainMenu_ComputerScience_DataRepresentation_ImageRepresentation
        _MainMenu_ComputerScience_DataRepresentation_CompressionAndEncryption

        'ComputerSystems category
        _MainMenu_ComputerScience_ComputerSystems
        _MainMenu_ComputerScience_ComputerSystems_HardwareAndSoftware
        _MainMenu_ComputerScience_ComputerSystems_RoleOfTheOS

        'OrganizationAndArchitecture category
        _MainMenu_ComputerScience_OrganizationAndArchitecture

        'ConsequencesOfUse category
        _MainMenu_ComputerScience_ConsequencesOfUse

        'CommunicationAndNetworking category
        _MainMenu_ComputerScience_CommunicationAndNetworking

        'Databases category
        _MainMenu_ComputerScience_Databases

        'BigData category
        _MainMenu_ComputerScience_BigData

        'FunctionalProgramming category
        _MainMenu_ComputerScience_FunctionalProgramming

        'ProblemSolving category
        _MainMenu_ComputerScience_ProblemSolving

        'Geography section
        _MainMenu_Geography

        'Mathematics section
        _MainMenu_Mathematics

    End Enum

    '2D array of all available menus
    Private Const Menus(,) as String = {{"Main Menu:", "Computer Science", "Geography", "Mathematics", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                        
                                        'ComputerScience section
                                        {"Computer Science:", "Programming", "Data Structures", "Algorithms", "Computation", "Data Representation", "Computer Systems", "Organization & Architecture", "Consequence of Use", "Communication & Networking", "Databases", "Big Data", "Functional Programming", "Problem Solving"},

                                        'Programming category
                                        {"Programming:", "Basics", "Selection", "Iteration", "Arrays", "Subroutines", "File & Exception Handling", "Structured Programming", "Contacts List", " ", " ", " ", " ", " "},
                                        {"Basics:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                        {"Selection:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                        {"Iteration:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                        {"Arrays:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                        {"Subroutines:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                        {"File & Exception Handling:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                        {"Structured Programming:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                        {"Contacts List:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},

                                        'DataStructures category
                                        {"Data Structures:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},

                                        'Algorithms category
                                        {"Algorithms:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},

                                        'Computation category
                                        {"Computation:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},

                                        'DataRepresentation category
                                        {"Data Representation:", "Number Systems", "Binary Arithmetic", "Bits & Bytes", "Character Coding", "Sound Representation", "Image Representation", "Compression & Encryption", " ", " ", " ", " ", " ", " "},
                                        {"Number Systems:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                        {"Binary Arithmetic:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                        {"Bits & Bytes:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                        {"Character Coding:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                        {"Sound Representation:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                        {"Image Representation:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                        {"Compression & Encryption:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                        
                                        'ComputerSystems category
                                        {"Computer Systems:", "Hardware & Software", "Role Of The OS", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                        {"Hardware & Software:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                        {"Role Of The OS:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                        
                                        'OrganizationAndArchitecture category
                                        {"Organization & Architecture:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                        
                                        'ConsequencesOfUse category
                                        {"Consequences Of Use:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                        
                                        'CommunicationAndNetworking category
                                        {"Communication & Networking", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                        
                                        'Databases category
                                        {"Databases: ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                        
                                        'BigData category
                                        {"Big Data:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                        
                                        'FunctionalProgramming category
                                        {"Functional Programming:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                        
                                        'ProblemSolving category
                                        {"Problem Solving:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                        
                                        'Geography category
                                        {"Geography:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                        
                                        'Mathematics category
                                        {"Mathematics:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "}}


    'Stores the menu the user is currently in
    Private SelectedMenu as MenuName = MenuName._MainMenu

    'Stores the menu the user was previously in
    Private PreviousMenu as MenuName

    'Declares user's selected option in each menu
    Private SelectedOption as Integer = 0

    'Ensures user can go back to previous menus
    Private BackspacePressed as Boolean = False

    'Ensures user can back out of the program
    Private EscapePressed as Boolean = False

    Sub Menu()
        'Loops menu until program is closed
        Do
            'Makes the cursor invisible and clears the console
            Console.CursorVisible = False
            Console.Clear()


            'If BackspacePressed is true it's set to false
            If BackspacePressed Then
                BackspacePressed = False
            End If

            'If EscapePressed is true it's set to false
            If EscapePressed Then
                EscapePressed = False
            End If

            'Select which menu to display
            Select Case SelectedMenu
                Case MenuName._MainMenu
                    PreviousMenu = MenuName._MainMenu

                    'Calls menu interface with MainMenu information
                    MenuInterface(4)

                    'Skips menus if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        'Decides which menu to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                SelectedMenu = MenuName._MainMenu_ComputerScience
                            Case 1
                                SelectedMenu = MenuName._MainMenu_Geography
                            Case 2
                                SelectedMenu = MenuName._MainMenu_Mathematics
                        End Select
                    End If
                
                Case MenuName._MainMenu_ComputerScience
                    'Calls menu interface with ComputerScience information
                    MenuInterface(14)

                    'Skips menus if backspace was pressed
                    If Not BackspacePressed Then
                        PreviousMenu = MenuName._MainMenu_ComputerScience

                        'Decides which menu to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                SelectedMenu = MenuName._MainMenu_ComputerScience_Programming
                            Case 1
                                SelectedMenu = MenuName._MainMenu_ComputerScience_DataStructures
                            Case 2
                                SelectedMenu = MenuName._MainMenu_ComputerScience_Algorithms
                            Case 3
                                SelectedMenu = MenuName._MainMenu_ComputerScience_Computation
                            Case 4
                                SelectedMenu = MenuName._MainMenu_ComputerScience_DataRepresentation
                            Case 5
                                SelectedMenu = MenuName._MainMenu_ComputerScience_ComputerSystems
                            Case 6
                                SelectedMenu = MenuName._MainMenu_ComputerScience_OrganizationAndArchitecture
                            Case 7
                                SelectedMenu = MenuName._MainMenu_ComputerScience_ConsequencesOfUse
                            Case 8
                                SelectedMenu = MenuName._MainMenu_ComputerScience_CommunicationAndNetworking
                            Case 9
                                SelectedMenu = MenuName._MainMenu_ComputerScience_Databases
                            Case 10
                                SelectedMenu = MenuName._MainMenu_ComputerScience_BigData
                            Case 11
                                SelectedMenu = MenuName._MainMenu_ComputerScience_FunctionalProgramming
                            Case 12
                                SelectedMenu = MenuName._MainMenu_ComputerScience_ProblemSolving
                        End Select
                    End If

                Case MenuName._MainMenu_ComputerScience_Programming
                    'Calls menu interface with Programming information
                    MenuInterface(9)

                    'Skips menus if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        PreviousMenu = MenuName._MainMenu_ComputerScience_Programming

                        'Decides which menu to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                SelectedMenu = MenuName._MainMenu_ComputerScience_Programming_Basics
                            Case 1
                                SelectedMenu = MenuName._MainMenu_ComputerScience_Programming_Selection
                            Case 2
                                SelectedMenu = MenuName._MainMenu_ComputerScience_Programming_Iteration
                            Case 3
                                SelectedMenu = MenuName._MainMenu_ComputerScience_Programming_Arrays
                            Case 4
                                SelectedMenu = MenuName._MainMenu_ComputerScience_Programming_Subroutines
                            Case 5
                                SelectedMenu = MenuName._MainMenu_ComputerScience_Programming_FileAndExceptionHandling
                            Case 6
                                SelectedMenu = MenuName._MainMenu_ComputerScience_Programming_StructuredProgramming
                            Case 7
                                SelectedMenu = MenuName._MainMenu_ComputerScience_Programming_ContactsList
                        End Select
                    End If
                
                Case MenuName._MainMenu_ComputerScience_Programming_Basics

                Case MenuName._MainMenu_ComputerScience_Programming_Selection

                Case MenuName._MainMenu_ComputerScience_Programming_Iteration

                Case MenuName._MainMenu_ComputerScience_Programming_Arrays

                Case MenuName._MainMenu_ComputerScience_Programming_Subroutines

                Case MenuName._MainMenu_ComputerScience_Programming_FileAndExceptionHandling

                Case MenuName._MainMenu_ComputerScience_Programming_StructuredProgramming

                Case MenuName._MainMenu_ComputerScience_Programming_ContactsList

                Case MenuName._MainMenu_ComputerScience_DataStructures
                    'Calls menu interface with DataStructures information
                    MenuInterface(1)

                    'Skips menus if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        PreviousMenu = MenuName._MainMenu_ComputerScience_DataStructures

                        'Decides which menu to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call menu here
                        End Select
                    End If
                
                Case MenuName._MainMenu_ComputerScience_Algorithms
                    'Calls menu interface with Algorithms information
                    MenuInterface(1)

                    'Skips menus if backspace was pressed
                    If Not BackspacePressed Then
                        PreviousMenu = MenuName._MainMenu_ComputerScience_Algorithms

                        'Decides which menu to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call menu here
                        End Select
                    End If
                
                Case MenuName._MainMenu_ComputerScience_Computation
                    'Calls menu interface with Computation information
                    MenuInterface(1)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        PreviousMenu = MenuName._MainMenu_ComputerScience_Computation

                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call subroutine here
                        End Select
                    End If
                
                Case MenuName._MainMenu_ComputerScience_DataRepresentation
                    'Calls menu interface with Programming information
                    MenuInterface(8)

                    'Skips menus if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        PreviousMenu = MenuName._MainMenu_ComputerScience_DataRepresentation

                        'Decides which menu to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                SelectedMenu = MenuName._MainMenu_ComputerScience_DataRepresentation_NumberSystems
                            Case 1
                                SelectedMenu = MenuName._MainMenu_ComputerScience_DataRepresentation_BinaryArithmetic
                            Case 2
                                SelectedMenu = MenuName._MainMenu_ComputerScience_DataRepresentation_BitsAndBytes
                            Case 3
                                SelectedMenu = MenuName._MainMenu_ComputerScience_DataRepresentation_CharacterCoding
                            Case 4
                                SelectedMenu = MenuName._MainMenu_ComputerScience_DataRepresentation_SoundRepresentation
                            Case 5
                                SelectedMenu = MenuName._MainMenu_ComputerScience_DataRepresentation_ImageRepresentation
                            Case 6
                                SelectedMenu = MenuName._MainMenu_ComputerScience_DataRepresentation_CompressionAndEncryption
                        End Select
                    End If
                
                Case MenuName._MainMenu_ComputerScience_DataRepresentation_NumberSystems

                Case MenuName._MainMenu_ComputerScience_DataRepresentation_BinaryArithmetic

                Case MenuName._MainMenu_ComputerScience_DataRepresentation_BitsAndBytes

                Case MenuName._MainMenu_ComputerScience_DataRepresentation_CharacterCoding

                Case MenuName._MainMenu_ComputerScience_DataRepresentation_SoundRepresentation

                Case MenuName._MainMenu_ComputerScience_DataRepresentation_ImageRepresentation

                Case MenuName._MainMenu_ComputerScience_DataRepresentation_CompressionAndEncryption

                Case MenuName._MainMenu_ComputerScience_ComputerSystems
                    'Calls menu interface with ComputerSystems information
                    MenuInterface(3)

                    'Skips menus if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        PreviousMenu = MenuName._MainMenu_ComputerScience_ComputerSystems

                        'Decides which menu to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                SelectedMenu = MenuName._MainMenu_ComputerScience_ComputerSystems_HardwareAndSoftware
                            Case 1
                                SelectedMenu = MenuName._MainMenu_ComputerScience_ComputerSystems_RoleOfTheOS
                        End Select
                    End If

                Case MenuName._MainMenu_ComputerScience_ComputerSystems_HardwareAndSoftware

                Case MenuName._MainMenu_ComputerScience_ComputerSystems_RoleOfTheOS
                
                Case MenuName._MainMenu_ComputerScience_OrganizationAndArchitecture
                    'Calls menu interface with OrganizationAndArchitecture information
                    MenuInterface(1)

                    'Skips menus if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        PreviousMenu = MenuName._MainMenu_ComputerScience_OrganizationAndArchitecture

                        'Decides which menu to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call menu here
                        End Select
                    End If
                
                Case MenuName._MainMenu_ComputerScience_ConsequencesOfUse
                    'Calls menu interface with ConsequencesOfUse information
                    MenuInterface(1)

                    'Skips menus if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        PreviousMenu = MenuName._MainMenu_ComputerScience_ConsequencesOfUse

                        'Decides which menu to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call menu here
                        End Select
                    End If
                
                Case MenuName._MainMenu_ComputerScience_CommunicationAndNetworking
                    'Calls menu interface with CommunicationAndNetworking information
                    MenuInterface(1)

                    'Skips menus if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        'Decides which menu to call based on selected option
                        Select Case SelectedOption
                            PreviousMenu = MenuName._MainMenu_ComputerScience_CommunicationAndNetworking

                            Case 0
                                'Call menu here
                        End Select
                    End If
                
                Case MenuName._MainMenu_ComputerScience_Databases
                    'Calls menu interface with Databases information
                    MenuInterface(1)

                    'Skips menus if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        PreviousMenu = MenuName._MainMenu_ComputerScience_Databases

                        'Decides which menu to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call menu here
                        End Select
                    End If
                
                Case MenuName._MainMenu_ComputerScience_BigData
                    'Calls menu interface with BigData information
                    MenuInterface(1)

                    'Skips menus if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        PreviousMenu = MenuName._MainMenu_ComputerScience_BigData

                        'Decides menu program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call menu here
                        End Select
                    End If
                
                Case MenuName._MainMenu_ComputerScience_FunctionalProgramming
                    'Calls menu interface with FunctionalProgramming information
                    MenuInterface(1)

                    'Skips menus if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        PreviousMenu = MenuName._MainMenu_ComputerScience_FunctionalProgramming

                        'Decides which menu to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call menu here
                        End Select
                    End If
                
                Case MenuName._MainMenu_ComputerScience_ProblemSolving
                    'Calls menu interface with ProblemSolving information
                    MenuInterface(1)

                    'Skips menus if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        PreviousMenu = MenuName._MainMenu_ComputerScience_ProblemSolving

                        'Decides which menu to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call menu here
                        End Select
                    End If
                
            End Select
        Loop Until EscapePressed
    End Sub

    Sub MenuInterface(MenuSize as Integer)
        'Stores information from Console.ReadKey()
        Dim MenuSelect as ConsoleKeyInfo

        'Reset select option to 0
        SelectedOption = 0

        'Loops menu interface until enter is pressed
        Do
            'Displays selected menu information
            Console.WriteLine(Menus(SelectedMenu, 0).PadRight(60, " ") & "Navigate using arrows. Enter to select. Backspace to return.")

            'Displays selected menu with selected option highlighted
            For x = 1 To MenuSize - 1
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
                    'Takes user back to the previous menu
                    SelectedMenu = PreviousMenu
                    BackspacePressed = True
                    Console.Clear()
                    Return
                Case ConsoleKey.Escape
                    'Takes user out of the entire program
                    EscapePressed = True
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
                    If SelectedOption + 1 < MenuSize - 1 Then
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
                    If SelectedOption + 3 < MenuSize - 1 Then
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
                   
    'Calls menu
    Sub ContactsListMain()
        ContactsListMenu()
    End Sub

    'Stores useable menu names as enums
    Enum ContactsListMenuName
        _MainMenu

        'Read people section
        _MainMenu_ReadPeople

        'Amend person section
        _MainMenu_AmendPerson
        
        'Delete person section
        _MainMenu_DeletePerson
    End Enum

    '2D array of all available menus
    Private Const ContactsListMenus(,) as String = {{"Main Menu:", "Read People", "Enter Person", "Amend Person", "Delete Person"},
                                                    {"Read People:", "Enter ID", "Read All", " ", " "},
                                                    {"Amend Person:", "Enter ID", "Select Person", " ", " "},
                                                    {"Delete Person:", "Enter ID", "Select Person", " ", " "}}

    'Stores the menu the user is currently in
    Private ContactsListSelectedMenu as ContactsListMenuName = ContactsListMenuName._MainMenu

    'Stores the menu the user was previously in
    Private ContactsListPreviousMenu as ContactsListMenuName

    'Declares user's selected option in each menu
    Private ContactsListSelectedOption as Integer = 0

    'Ensures user can go back to previous menu
    Private ContactsListBackspacePressed as Boolean = False

    'Ensures user can back out of the program
    Private ContactsListEscapePressed as Boolean = False

    Sub ContactsListMenu()
        'Loops menu until program is closed
        Do
            'Makes the cursor invisible and clears the console
            Console.CursorVisible = False
            Console.Clear()


            'If ContactsListBackspacePressed is true it's set to false
            If ContactsListBackspacePressed Then
                ContactsListBackspacePressed = False
            End If

            'If ContactsListEscapePressed is true it's set to false
            If ContactsListEscapePressed Then
                ContactsListEscapePressed = False
            End If

            'Select which menu to display
            Select Case ContactsListSelectedMenu
                Case ContactsListMenuName._MainMenu
                    ContactsListPreviousMenu = ContactsListMenuName._MainMenu

                    'Calls menu interface with MainMenu information
                    MenuInterface(5)

                    'Skips menus if backspace was pressed
                    If Not ContactsListBackspacePressed And Not ContactsListEscapePressed Then
                        'Decides which menu to call based on selected option
                        Select Case ContactsListSelectedOption
                            Case 0
                                ContactsListSelectedMenu = ContactsListMenuName._MainMenu_ReadPeople
                            Case 1
                                ContactsListEnterPerson()
                            Case 2
                                ContactsListSelectedMenu = ContactsListMenuName._MainMenu_AmendPerson
                            Case 3
                                ContactsListSelectedMenu = ContactsListMenuName._MainMenu_DeletePerson
                        End Select
                    End If

                Case ContactsListMenuName._MainMenu_ReadPeople
                    'Calls menu interface with ReadPeople information
                    MenuInterface(3)

                    'Skips menus if program was pressed
                    If Not ContactsListBackspacePressed And Not ContactsListEscapePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                ContactsListReadPeople(0)
                            Case 1
                                ContactsListReadPeople(1)
                        End Select
                    End If

                Case ContactsListMenuName._MainMenu_AmendPerson
                    'Calls menu interface with MainMenu information
                    MenuInterface(3)

                    'Skips programs if backspace was pressed
                    If Not ContactsListBackspacePressed And Not ContactsListEscapePressed Then
                        'Decides which program to call based on selected option
                        Select Case ContactsListSelectedOption
                            Case 0
                                ContactsListAmendPerson(0)
                            Case 1
                                ContactsListAmendPerson(1)
                        End Select
                    End If

                Case ContactsListMenuName._MainMenu_DeletePerson
                    'Calls menu interface with MainMenu information
                    MenuInterface(3)

                    'Skips menus if backspace was pressed
                    If Not ContactsListBackspacePressed And Not ContactsListEscapePressed Then
                        'Decides which menu to call based on selected option
                        Select Case ContactsListSelectedOption
                            Case 0
                                ContactsListDeletePerson(0)
                            Case 1
                                ContactsListDeletePerson(1)
                        End Select
                    End If

            End Select
        Loop Until ContactsListEscapePressed
    End Sub

    Sub ContactsListMenuInterface(ContactsListMenuSize as Integer)
        'Stores information from Console.ReadKey()
        Dim ContactsListMenuSelect as ConsoleKeyInfo

        'Reset select option to 0
        ContactsListSelectedOption = 0

        'Loops menu interface until enter is pressed
        Do
            'Displays selected menu information
            Console.WriteLine(ContactsListMenus(ContactsListSelectedMenu, 0).PadRight(60, " ") & "Navigate using arrows. Enter to select. Backspace to return.")

            'Displays selected menu with selected option highlighted
            For x = 1 To ContactsListMenuSize - 1
                'Adds a line break every four options
                If x Mod 3 = 0 Then
                    Console.WriteLine()
                End If
                If ContactsListSelectedOption = x Then
                    'Displays user's selected item in magenta
                    Console.ForegroundColor = ConsoleColor.Magenta
                    Console.Write(ContactsListMenus(ContactsListSelectedMenu, x).PadRight(30, " "))

                    'Sets the color back to white
                    Console.ForegroundColor = ConsoleColor.White
                Else
                    'Displays unselected items
                    Console.Write(ContactsListMenus(ContactsListSelectedMenu, x).PadRight(30, " "))
                End If
            Next

            'Changes user's selected option in menu based on key press
            ContactsListMenuSelect = Console.ReadKey()
            Select Case ContactsListMenuSelect.Key
                Case ConsoleKey.Backspace
                    'Takes user back to the previous menu
                    ContactsListSelectedMenu = ContactsListPreviousMenu
                    ContactsListBackspacePressed = True
                    Console.Clear()
                    Return
                Case ConsoleKey.Escape
                    'Takes user out of the contacts list program
                    ContactsListEscapePressed = True
                    Console.Clear()
                    Return
                Case ConsoleKey.LeftArrow
                    'Checks if it can move selected option left
                    If ContactsListSelectedOption - 1 > -1 Then
                        'Moves selected option left
                        ContactsListSelectedOption = ContactsListSelectedOption - 1
                    End If
                Case ConsoleKey.RightArrow
                    'Checks if it can move selected option right
                    If ContactsListSelectedOption + 1 < ContactsListMenuSize - 1 Then
                        'Moves selected option right
                        ContactsListSelectedOption = ContactsListSelectedOption + 1
                    End If
                Case ConsoleKey.UpArrow
                    'Checks if it can move selected option up
                    If ContactsListSelectedOption - 3 > -1 Then
                        'Moves selected option up
                        ContactsListSelectedOption = ContactsListSelectedOption - 3
                    End If
                Case ConsoleKey.DownArrow
                    'Checks if it can move selected option down
                    If ContactsListSelectedOption + 3 < ContactsListMenuSize - 1 Then
                        'Moves selected option down
                        ContactsListSelectedOption = ContactsListSelectedOption + 3
                    End If
            End Select
            Console.Clear()
        Loop Until MenuSelect.Key = ConsoleKey.Enter

        'Makes cursor visible
        Console.CursorVisible = True
    End Sub
    
    'Record to match file csv structure
    Type ContactsListInformation
        ID as String
        Age as String
        Surname as String
        Forename as String
        PostCode as String
        DateOfBirth As String
    End Type

    Private ContactsListSingleRecord as ContactsListInformation
    Private ContactsListMultipleRecords() as ContactsListInformation

    'Mode 0 = Enter ID
    'Mode 2 = Read All
    Sub ContactsListReadPeople(Mode as Integer)
        Select Case Mode
            Case 0
                ContactsListEnterID()

                'TODO: Displays contents of ContactsListSingleRecord
            Case 1
                'TODO: Get all content from file and display
        End Select
        Dim 
    End Sub
    
    'Mode 0 = Default
    Sub ContactsListEnterPerson(Mode as Integer)
        Select Case Mode
            Case 0

        End Select
    End Sub

    'Mode 0 = Enter ID
    'Mode 1 = Select Person
    Sub ContactsListAmendPerson(Mode as Integer)
        Select Case Mode
            Case 0
                ContactsListEnterID()
            Case 1 
                ContactsListSelectPerson()
        End Select
    End Sub

    'Mode 0 = Enter ID
    'Mode 1 = Select Person
    Sub ContactsListDeletePerson(Mode as Integer)
        Select Case Mode
            Case 0
                ContactsListEnterID()
            Case 1
                ContactsListSelectPerson()
        End Select
    End Sub

    Sub ContactsListEnterID(Mode As Integer)
        Dim NotValid as Boolean = True

        While NotValid
            Console.Write("Please enter the person's ID: ")
            Dim ID as String = Console.Readline()

            'TODO: Iterate through file to check for ID
        End While
    End Sub

    Sub ContactsListSelectPerson()
        'TODO: Use arrows to navigate person by person

        'TODO: When person enters store values in record
    End Sub
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