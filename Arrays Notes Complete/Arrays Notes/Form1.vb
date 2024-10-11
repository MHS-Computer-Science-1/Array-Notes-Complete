Public Class Form1
    'ARRAY NOTES

    'Learning Goals
    '---------------
    'I can create and use arrays to solve problems in Visual BASIC
    'I can use loops to process all the elements of an array
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'What is an array?
        ListBox1.Items.Add("An ARRAY is a variable that can hold a list of information")

        ListBox1.Items.Add("Examples:")
        ListBox1.Items.Add(" - Grocery List")
        ListBox1.Items.Add(" - Your grades in a class")
        ListBox1.Items.Add(" - A list of the states and capitals for a trivia game")

        'How do I make an array that holds 5 elements?
        Dim testScores(4) As Integer

        'testScores = [0, 0, 0, 0, 0]
        '      index:  0  1  2  3  4

        'The INDEX number identifies the location in the array
        'We can use this index number to access/change array elements

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Accessing Array Elements
        Dim testScores(4) As Integer
        'testScores = [95, 78, 0, 0, 0]
        '      index:  0    1  2  3  4

        'Assign elements
        testScores(0) = 95

        'Try it: assign the 2nd score to 78
        testScores(1) = 78

        'Try it: assign the last score to a number entered
        'in an input box
        testScores(4) = InputBox("Enter a score")


        'Display all the scores in the Listbox (Long Way)
        ListBox1.Items.Add("Test Scores")

        ListBox1.Items.Add(testScores(0))
        ListBox1.Items.Add(testScores(1))
        ListBox1.Items.Add(testScores(2))
        ListBox1.Items.Add(testScores(3))
        ListBox1.Items.Add(testScores(4))

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Looping through an array
        Dim testScores(29) As Integer

        Dim r As New Random
        Dim i As Integer

        For i = 0 To 29
            testScores(i) = r.Next(75, 101)
        Next

        'Display all scores with a loop
        ListBox1.Items.Add("All Scores")
        For i = 0 To 29
            ListBox1.Items.Add(testScores(i))
        Next


        'Display As
        ListBox1.Items.Add("The As")
        For i = 0 To 29
            If testScores(i) >= 90 Then
                ListBox1.Items.Add(testScores(i))
            End If
        Next


        'Try it: Display the Bs
        ListBox1.Items.Add("The Bs")
        For i = 0 To 29
            If testScores(i) >= 80 And testScores(i) < 90 Then
                ListBox1.Items.Add(testScores(i))
            End If
        Next


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Linear Search
        Dim numbers(99) As Integer

        'Fill the array with random numbers
        Dim r As New Random
        Dim i As Integer
        For i = 0 To 99
            numbers(i) = r.Next(0, 125)
        Next

        'Define what we are searching for
        Dim toFind As Integer
        toFind = 50
        Dim found As Boolean = False

        'See if toFind exists in the array
        For i = 0 To 99
            If numbers(i) = toFind Then
                MsgBox(toFind & " was found at index " & i)
                found = True
            End If
        Next

        'How can we know if toFind wasn't found?
        If found = False Then
            MsgBox(toFind & " was not found")
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim y, x, temp As Integer

        Dim numbers(7) As Integer
        numbers(0) = 6
        numbers(1) = 5
        numbers(2) = 3
        numbers(3) = 1
        numbers(4) = 8
        numbers(5) = 7
        numbers(6) = 2
        numbers(7) = -4

        'Bubble Sort
        '************
        For y = 0 To numbers.Length - 2 'Repeat this process over and over
            For x = 0 To numbers.Length - 2 'Loop through the elements
                'Is element x bigger than element x+1?
                If numbers(x) > numbers(x + 1) Then
                    'Flip-flop element x and x+1
                    temp = numbers(x)
                    numbers(x) = numbers(x + 1)
                    numbers(x + 1) = temp
                End If
            Next
        Next


        ListBox1.Items.Add("After Bubble Sort:")
        For i = 0 To numbers.Length - 1
            ListBox1.Items.Add(numbers(i))
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Create a 2-d array
        Dim myArray(2, 3) As Integer '3 rows, 4 cols
        'myArray:  0 0 0 0
        '          0 0 0 0

        'Access the elements using a row # and col #
        myArray(0, 0) = 5
        myArray(1, 3) = 1

        'myArray:  5 0 0 0
        '          0 0 0 1

        'Try it: Set the top-right corner and bottom left
        'corner to 3 and 7 respectively
        myArray(0, 3) = 3
        myArray(1, 0) = 7


        'Set all the elements to 10 (The loop way)
        Dim row, col As Integer
        For row = 0 To 1
            For col = 1 To 3
                myArray(row, col) = 10
            Next
        Next

        'myArray:  10 10 10 10
        '          10 10 10 10

    End Sub







    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox1.Image = My.Resources.Bubble_sort_example_300px
    End Sub


End Class
