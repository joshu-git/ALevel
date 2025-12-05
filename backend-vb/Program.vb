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
        _MainMenu_ComputerScience_ComputerSystems_LanguageClassification

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
    Private Menus(,) as String = {  {"Main Menu:", "Computer Science", "Geography", "Mathematics", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                    {"Computer Science:", "Programming", "Data Structures", "Algorithms", "Computation", "Data Representation", "Computer Systems", "Organization & Architecture", "Consequence of Use", "Communication & Networking", "Databases", "Big Data", "Functional Programming", "Problem Solving"},
                                    {"Programming:", "Basics", "Selection", "Iteration", "Arrays", "Subroutines", "File & Exception Handling", "Structured Programming", "Contacts List", " ", " ", " ", " ", " "},
                                    {"Basics:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                    {"Selection:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                    {"Iteration:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                    {"Arrays:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                    {"Subroutines:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                    {"File & Exception Handling:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                    {"Structured Programming:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                    {"Contacts List:", "Main", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                    {"Data Structures:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                    {"Algorithms:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                    {"Computation:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                    {"Data Representation:", "Number Systems", "Binary Arithmetic", "Bits & Bytes", "Character Coding", "Sound Representation", "Image Representation", "Compression & Encryption", " ", " ", " ", " ", " ", " "},
                                    {"Number Systems:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                    {"Binary Arithmetic:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                    {"Bits & Bytes:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                    {"Character Coding:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                    {"Sound Representation:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                    {"Image Representation:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                    {"Compression & Encryption:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "}, 
                                    {"Computer Systems:", "Hardware & Software", "Role Of The OS", "Language Classification", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                    {"Hardware & Software:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                    {"Role Of The OS:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                    {"Language Classification:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                    {"Organization & Architecture:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                    {"Consequences Of Use:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                    {"Communication & Networking", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                    {"Databases: ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                    {"Big Data:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                    {"Functional Programming:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                    {"Problem Solving:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                    {"Geography:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
                                    {"Mathematics:", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "}}


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
                    PreviousMenu = MenuName._MainMenu

                    'Calls menu interface with ComputerScience information
                    MenuInterface(14)

                    'Skips menus if backspace was pressed
                    If Not BackspacePressed Then

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
                    PreviousMenu = MenuName._MainMenu_ComputerScience

                    'Calls menu interface with Programming information
                    MenuInterface(9)

                    'Skips menus if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
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
                    PreviousMenu = MenuName._MainMenu_ComputerScience_Programming

                    'Calls menu interface with Programming information
                    MenuInterface(1)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call program here
                        End Select
                    End If

                Case MenuName._MainMenu_ComputerScience_Programming_Selection
                    PreviousMenu = MenuName._MainMenu_ComputerScience_Programming

                    'Calls menu interface with Programming information
                    MenuInterface(1)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call program here
                        End Select
                    End If

                Case MenuName._MainMenu_ComputerScience_Programming_Iteration
                    PreviousMenu = MenuName._MainMenu_ComputerScience_Programming

                    'Calls menu interface with Programming information
                    MenuInterface(1)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call program here
                        End Select
                    End If

                Case MenuName._MainMenu_ComputerScience_Programming_Arrays
                    PreviousMenu = MenuName._MainMenu_ComputerScience_Programming

                    'Calls menu interface with Programming information
                    MenuInterface(1)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call program here
                        End Select
                    End If

                Case MenuName._MainMenu_ComputerScience_Programming_Subroutines
                    PreviousMenu = MenuName._MainMenu_ComputerScience_Programming

                    'Calls menu interface with Programming information
                    MenuInterface(1)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call program here
                        End Select
                    End If

                Case MenuName._MainMenu_ComputerScience_Programming_FileAndExceptionHandling
                    PreviousMenu = MenuName._MainMenu_ComputerScience_Programming

                    'Calls menu interface with Programming information
                    MenuInterface(1)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call program here
                        End Select
                    End If

                Case MenuName._MainMenu_ComputerScience_Programming_StructuredProgramming
                    PreviousMenu = MenuName._MainMenu_ComputerScience_Programming

                    'Calls menu interface with Programming information
                    MenuInterface(1)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call program here
                        End Select
                    End If

                Case MenuName._MainMenu_ComputerScience_Programming_ContactsList
                    PreviousMenu = MenuName._MainMenu_ComputerScience_Programming

                    'Calls menu interface with Programming information
                    MenuInterface(2)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                ContactsListMain()
                        End Select
                    End If

                Case MenuName._MainMenu_ComputerScience_DataStructures
                    PreviousMenu = MenuName._MainMenu_ComputerScience
                    
                    'Calls menu interface with DataStructures information
                    MenuInterface(1)

                    'Skips menus if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        'Decides which menu to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call menu here
                        End Select
                    End If
                
                Case MenuName._MainMenu_ComputerScience_Algorithms
                    PreviousMenu = MenuName._MainMenu_ComputerScience

                    'Calls menu interface with Algorithms information
                    MenuInterface(1)

                    'Skips menus if backspace was pressed
                    If Not BackspacePressed Then
                        'Decides which menu to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call menu here
                        End Select
                    End If
                
                Case MenuName._MainMenu_ComputerScience_Computation
                    PreviousMenu = MenuName._MainMenu_ComputerScience

                    'Calls menu interface with Computation information
                    MenuInterface(1)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call subroutine here
                        End Select
                    End If
                
                Case MenuName._MainMenu_ComputerScience_DataRepresentation
                    PreviousMenu = MenuName._MainMenu_ComputerScience

                    'Calls menu interface with Programming information
                    MenuInterface(8)

                    'Skips menus if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
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
                    PreviousMenu = MenuName._MainMenu_ComputerScience_DataRepresentation

                    'Calls menu interface with Programming information
                    MenuInterface(1)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call program here
                        End Select
                    End If

                Case MenuName._MainMenu_ComputerScience_DataRepresentation_BinaryArithmetic
                    PreviousMenu = MenuName._MainMenu_ComputerScience_DataRepresentation

                    'Calls menu interface with Programming information
                    MenuInterface(1)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call program here
                        End Select
                    End If

                Case MenuName._MainMenu_ComputerScience_DataRepresentation_BitsAndBytes
                    PreviousMenu = MenuName._MainMenu_ComputerScience_DataRepresentation

                    'Calls menu interface with Programming information
                    MenuInterface(1)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call program here
                        End Select
                    End If

                Case MenuName._MainMenu_ComputerScience_DataRepresentation_CharacterCoding
                    PreviousMenu = MenuName._MainMenu_ComputerScience_DataRepresentation

                    'Calls menu interface with Programming information
                    MenuInterface(1)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call program here
                        End Select
                    End If

                Case MenuName._MainMenu_ComputerScience_DataRepresentation_SoundRepresentation
                    PreviousMenu = MenuName._MainMenu_ComputerScience_DataRepresentation

                    'Calls menu interface with Programming information
                    MenuInterface(1)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call program here
                        End Select
                    End If

                Case MenuName._MainMenu_ComputerScience_DataRepresentation_ImageRepresentation
                    PreviousMenu = MenuName._MainMenu_ComputerScience_DataRepresentation

                    'Calls menu interface with Programming information
                    MenuInterface(1)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call program here
                        End Select
                    End If

                Case MenuName._MainMenu_ComputerScience_DataRepresentation_CompressionAndEncryption
                    PreviousMenu = MenuName._MainMenu_ComputerScience_DataRepresentation

                    'Calls menu interface with Programming information
                    MenuInterface(1)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call program here
                        End Select
                    End If

                Case MenuName._MainMenu_ComputerScience_ComputerSystems
                    PreviousMenu = MenuName._MainMenu_ComputerScience

                    'Calls menu interface with ComputerSystems information
                    MenuInterface(4)

                    'Skips menus if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        'Decides which menu to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                SelectedMenu = MenuName._MainMenu_ComputerScience_ComputerSystems_HardwareAndSoftware
                            Case 1
                                SelectedMenu = MenuName._MainMenu_ComputerScience_ComputerSystems_RoleOfTheOS
                            Case 2
                                SelectedMenu = MenuName._MainMenu_ComputerScience_ComputerSystems_LanguageClassification
                        End Select
                    End If

                Case MenuName._MainMenu_ComputerScience_ComputerSystems_HardwareAndSoftware
                    PreviousMenu = MenuName._MainMenu_ComputerScience_ComputerSystems

                    'Calls menu interface with Programming information
                    MenuInterface(1)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call program here
                        End Select
                    End If

                Case MenuName._MainMenu_ComputerScience_ComputerSystems_RoleOfTheOS
                    PreviousMenu = MenuName._MainMenu_ComputerScience_ComputerSystems

                    'Calls menu interface with Programming information
                    MenuInterface(1)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call program here
                        End Select
                    End If

                Case MenuName._MainMenu_ComputerScience_ComputerSystems_LanguageClassification
                    PreviousMenu = MenuName._MainMenu_ComputerScience_ComputerSystems

                    'Calls menu interface with Programming information
                    MenuInterface(1)

                    'Skips programs if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        'Decides which program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call program here
                        End Select
                    End If
                
                Case MenuName._MainMenu_ComputerScience_OrganizationAndArchitecture
                    PreviousMenu = MenuName._MainMenu_ComputerScience

                    'Calls menu interface with OrganizationAndArchitecture information
                    MenuInterface(1)

                    'Skips menus if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        'Decides which menu to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call menu here
                        End Select
                    End If
                
                Case MenuName._MainMenu_ComputerScience_ConsequencesOfUse
                    PreviousMenu = MenuName._MainMenu_ComputerScience

                    'Calls menu interface with ConsequencesOfUse information
                    MenuInterface(1)

                    'Skips menus if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        'Decides which menu to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call menu here
                        End Select
                    End If
                
                Case MenuName._MainMenu_ComputerScience_CommunicationAndNetworking
                    PreviousMenu = MenuName._MainMenu_ComputerScience

                    'Calls menu interface with CommunicationAndNetworking information
                    MenuInterface(1)

                    'Skips menus if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        'Decides which menu to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call menu here
                        End Select
                    End If
                
                Case MenuName._MainMenu_ComputerScience_Databases
                    PreviousMenu = MenuName._MainMenu_ComputerScience

                    'Calls menu interface with Databases information
                    MenuInterface(1)

                    'Skips menus if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        'Decides which menu to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call menu here
                        End Select
                    End If
                
                Case MenuName._MainMenu_ComputerScience_BigData
                    PreviousMenu = MenuName._MainMenu_ComputerScience

                    'Calls menu interface with BigData information
                    MenuInterface(1)

                    'Skips menus if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        'Decides menu program to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call menu here
                        End Select
                    End If
                
                Case MenuName._MainMenu_ComputerScience_FunctionalProgramming
                    PreviousMenu = MenuName._MainMenu_ComputerScience

                    'Calls menu interface with FunctionalProgramming information
                    MenuInterface(1)

                    'Skips menus if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        'Decides which menu to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call menu here
                        End Select
                    End If
                
                Case MenuName._MainMenu_ComputerScience_ProblemSolving
                    PreviousMenu = MenuName._MainMenu_ComputerScience

                    'Calls menu interface with ProblemSolving information
                    MenuInterface(1)

                    'Skips menus if backspace was pressed
                    If Not BackspacePressed And Not EscapePressed Then
                        'Decides which menu to call based on selected option
                        Select Case SelectedOption
                            Case 0
                                'Call menu here
                        End Select
                    End If
                
                Case MenuName._MainMenu_Geography
                    PreviousMenu = MenuName._MainMenu

                Case MenuName._MainMenu_Mathematics
                    PreviousMenu = MenuName._MainMenu

            End Select

            'Makes cursor visible
            Console.CursorVisible = True
        
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
            Console.WriteLine(Menus(SelectedMenu, 0).PadRight(30, " ") & "Navigate using arrows. Enter to select. Backspace to return.")

            'Displays selected menu with selected option highlighted
            For x = 1 To MenuSize - 1
                'Adds a line break every four options
                If (x - 1) Mod 3 = 0 Then
                    Console.WriteLine()
                End If
                If SelectedOption + 1 = x Then
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
                   
    Sub ContactsListMain()
        'Clears content list in case this is ran twice
        ContactsListFileContents.Clear()

        'Checks if the file exists
        If Not File.Exists(ContactsListFilePath) Then
            'If it doesn't exist it creates it
            File.Create(ContactsListFilePath)
        End If

        'Stores all lines from the csv file
        Dim Lines() as String = File.ReadAllLines(ContactsListFilePath)

        'Splits each line to structured list
        For Each Line as String in Lines

            'Checks if the Line is null
            If Not String.IsNullOrWhiteSpace(Line) Then
                Dim Parts() As String = Line.Split(",")

                'Checks for correct length
                If Parts.Length = 5 Then

                    'If length is correct is writes to Contents
                    Dim Contents As New ContactsListInformation With {
                        .ID = Parts(0),
                        .Surname = Parts(1),
                        .Forename = Parts(2),
                        .PostCode = Parts(3),
                        .DateOfBirth = Parts(4)
                    }
                    
                    'Contents is written to the list
                    ContactsListFileContents.Add(Contents)
                End If
            End If
        Next

        'Calls menu
        ContactsListMenu()

        'Stores contents in string list
        Dim NewLines as New List(Of String)

        'Converts contents from structure to list
        For Each Contents in ContactsListFileContents
            NewLines.Add($"{Contents.ID},{Contents.Surname},{Contents.Forename},{Contents.Postcode},{Contents.DateOfBirth}")
        Next

        'Wipes and writes all lines into file
        File.WriteAllLines(ContactsListFilePath, NewLines)
    End Sub

    'Stores useable menu names as enums
    Enum ContactsListMenuName
        _MainMenu

        'Read people section
        _MainMenu_ReadPeople

        'Amend person section
        _MainMenu_AppendPerson
        
        'Delete person section
        _MainMenu_DeletePerson
    End Enum

    '2D array of all available menus
    Private ContactsListMenus(,) as String = {{"Main Menu:", "Read People", "Enter Person", "Append Person", "Delete Person"},
                                              {"Read People:", "Enter ID", "Read All", " ", " "},
                                              {"Append Person:", "Enter ID", "Select Person", " ", " "},
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

                    'Calls contacts list menu interface with MainMenu information
                    ContactsListMenuInterface(5)

                    'Skips menus if backspace was pressed
                    If Not ContactsListBackspacePressed And Not ContactsListEscapePressed Then
                        'Decides which menu to call based on selected option
                        Select Case ContactsListSelectedOption
                            Case 0
                                ContactsListSelectedMenu = ContactsListMenuName._MainMenu_ReadPeople
                            Case 1
                                ContactsListEnterPerson()
                            Case 2
                                ContactsListSelectedMenu = ContactsListMenuName._MainMenu_AppendPerson
                            Case 3
                                ContactsListSelectedMenu = ContactsListMenuName._MainMenu_DeletePerson
                        End Select
                    End If

                Case ContactsListMenuName._MainMenu_ReadPeople
                    ContactsListPreviousMenu = ContactsListMenuName._MainMenu

                    'Calls contacts list menu interface with MainMenu information
                    ContactsListMenuInterface(3)

                    'Skips menus if program was pressed
                    If Not ContactsListBackspacePressed And Not ContactsListEscapePressed Then
                        'Decides which program to call based on selected option
                        Select Case ContactsListSelectedOption
                            Case 0
                                ContactsListReadPeople(0)
                            Case 1
                                ContactsListReadPeople(1)
                        End Select
                    End If

                Case ContactsListMenuName._MainMenu_AppendPerson
                    ContactsListPreviousMenu = ContactsListMenuName._MainMenu

                    'Calls contacts list menu interface with MainMenu information
                    ContactsListMenuInterface(3)

                    'Skips programs if backspace was pressed
                    If Not ContactsListBackspacePressed And Not ContactsListEscapePressed Then
                        'Decides which program to call based on selected option
                        Select Case ContactsListSelectedOption
                            Case 0
                                ContactsListAppendPerson(0)
                            Case 1
                                ContactsListAppendPerson(1)
                        End Select
                    End If

                Case ContactsListMenuName._MainMenu_DeletePerson
                    ContactsListPreviousMenu = ContactsListMenuName._MainMenu

                    'Calls contacts list menu interface with MainMenu information
                    ContactsListMenuInterface(3)

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

            'Makes cursor visible
            Console.CursorVisible = True

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
            Console.WriteLine(ContactsListMenus(ContactsListSelectedMenu, 0).PadRight(30, " ") & "Navigate using arrows. Enter to select. Backspace to return.")

            'Displays selected menu with selected option highlighted
            For x = 1 To ContactsListMenuSize - 1
                'Adds a line break every four options
                If (x - 1) Mod 3 = 0 Then
                    Console.WriteLine()
                End If
                If ContactsListSelectedOption + 1 = x Then
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
        Loop Until ContactsListMenuSelect.Key = ConsoleKey.Enter

        'Makes cursor visible
        Console.CursorVisible = True
    End Sub
    
    'Record to match file csv structure
    Private Structure ContactsListInformation
        Private ID as String
        Private Surname as String
        Private Forename as String
        Private PostCode as String
        Private DateOfBirth As String
    End Structure

    'Stores everything from file + user changes
    Private ContactsListFileContents as New List(of ContactsListInformation)

    Private ContactsListFilePath as String = "ContactsList.csv"

    'Mode 0 = Enter ID
    'Mode 2 = Read All
    Sub ContactsListReadPeople(Mode as Integer)
        Select Case Mode
            Case 0
                'Fetches contents of user's ID
                Dim Result = ContactsListEnterID()

                'Checks if the function returned anything
                If Result.HasValue Then
                    'Displays contents of selected ID
                    Console.WriteLine($"ID ~> {Contents.ID}, Surname ~> {Contents.Surname}, Forename ~> {Contents.Forename}, Postcode ~> {Contents.Postcode}, Date Of Birth ~> {Contents.DateOfBirth}")
                Else
                    'Tells user that ID not found
                    Console.WriteLine("ID not found")
                End If

            Case 1
                'Displays all file contents
                For Each Contents In ContactsListFileContents
                    'Writes content of each line
                    Console.WriteLine($"ID ~> {Contents.ID}, Surname ~> {Contents.Surname}, Forename ~> {Contents.Forename}, Postcode ~> {Contents.Postcode}, Date Of Birth ~> {Contents.DateOfBirth}")
                Next

        End Select

        'Allows user to view contents
        Console.Readline()
    End Sub
    
    'Mode 0 = Default enter
    'Mode 1 = Append enter
    Sub ContactsListEnterPerson(Mode as Integer)
        Select Case Mode
            Case 0

            Case 1

        End Select
    End Sub

    'Mode 0 = Enter ID
    'Mode 1 = Select Person
    Sub ContactsListAppendPerson(Mode as Integer)
        Select Case Mode
            Case 0
                'Fetches contents of user's ID
                Dim Result = ContactsListEnterID()
                
                'Checks if the function returned anything
                If Result.HasValue Then
                    'Displays contents of selected ID
                    Console.WriteLine($"ID ~> {Contents.ID}, Surname ~> {Contents.Surname}, Forename ~> {Contents.Forename}, Postcode ~> {Contents.Postcode}, Date Of Birth ~> {Contents.DateOfBirth}")
                Else
                    'Tells user that ID not found
                    Console.WriteLine("ID not found")
                End If

            Case 1 
                Dim Result = ContactsListSelectPerson()

        End Select
    End Sub

    'Mode 0 = Enter ID
    'Mode 1 = Select Person
    Sub ContactsListDeletePerson(Mode as Integer)
        Select Case Mode
            Case 0
                'Fetches contents of user's ID
                Dim Result = ContactsListEnterID()
                
                'Checks if the function returned anything
                If Result.HasValue Then
                    'Displays contents of selected ID
                    Console.WriteLine($"ID ~> {Contents.ID}, Surname ~> {Contents.Surname}, Forename ~> {Contents.Forename}, Postcode ~> {Contents.Postcode}, Date Of Birth ~> {Contents.DateOfBirth}")
                Else
                    'Tells user that ID not found
                    Console.WriteLine("ID not found")
                End If

            Case 1
                Dim Result = ContactsListSelectPerson()

        End Select
    End Sub

    'Returns user's selected ID location
    Function ContactsListEnterID() as Integer
        'Asks and stores the user's selected ID
        Console.Write("Please enter the person's ID: ")
        Dim ID as String = Console.Readline()

        'Clears the console
        Console.Clear()

        'Finds the matching contents for the ID
        For Each Contents In ContactsListFileContents
            If ID = Contents.ID
            Return Contents
        Next

        'If ID not found nothing is returned
        Return Nothing
    End Function

    Function ContactsListSelectPerson()
        'TODO: Use arrows to navigate person by person

        'TODO: When person enters store values in record
    End Function
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