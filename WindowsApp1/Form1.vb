Public Class frmPoker
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim hand(3, 12), suits(3), denoms(12) As Integer
        InputCard(hand, suits, denoms, txtC1.Text, txtS1.Text)
        InputCard(hand, suits, denoms, txtC2.Text, txtS2.Text)
        InputCard(hand, suits, denoms, txtC3.Text, txtS3.Text)
        InputCard(hand, suits, denoms, txtC4.Text, txtS4.Text)
        InputCard(hand, suits, denoms, txtC5.Text, txtS5.Text)
        txtResult.Text = "The hand is a " & GetScore(hand, suits, denoms)

    End Sub
    Private Function GetScore(hand(,) As Integer, suits() As Integer, denoms() As Integer) As String
        If IsFlush(suits) And IsStraight(hand) Then
            Return "Straight Flush"
        End If
        If IsFlush(suits) Then
            Return "Flush"
        End If
        If IsFullHouse(denoms) Then
            Return "Full House"
        End If
        If IsFourofKind(denoms) Then
            Return "Four of a Kind"
        End If
        If IsStraight(hand) Then
            Return "Straight"
        End If
        If IsThreeofKind(denoms) Then
            Return "Three of a Kind"
        End If
        If IsTwoPair(denoms) Then
            Return "Two Pair"
        End If
        If IsOnePair(denoms) Then
            Return "One Pair"
        End If
        Return "No Hand"
    End Function

    Function IsFlush(suits() As Integer) As Boolean
        'suits will equal 5 when suit adds up to 5 from the select case in InputCard which will give you either true or false

        For suit As Integer = 0 To 3
            If suits(suit) = 5 Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Function IsFullHouse(denoms() As Integer) As Boolean
        For denom As Integer = 0 To 12
            If (denoms(denom) = 1) Or (denoms(denom) > 3) Then 'if any denom is 1,4,5 then it isnt a full house
                Return False
            End If
        Next            'all denom are either 0,2,3
        Return True
    End Function
    Private Function IsFourofKind(denoms() As Integer) As Boolean
        'determines if hand is a four of a kind or not
        For denom As Integer = 0 To 12

            If denoms(denom) = 4 Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Function IsThreeofKind(denoms() As Integer) As Boolean
        'determines if there is a three of a kind
        For denom As Integer = 0 To 12
            If denoms(denom) = 3 Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Function IsTwoPair(denoms() As Integer) As Boolean
        'determines if there are 2 pairs in a hand
        Dim counter As Integer = 0
        For denom As Integer = 0 To 12
            If denoms(denom) = 2 Then
                counter += 1
            End If
        Next
        If counter = 2 Then
            Return True
        End If
        Return False
    End Function
    Private Function IsOnePair(denoms() As Integer) As Boolean
        'determines if there is a pair
        For denom As Integer = 0 To 12
            If denoms(denom) = 2 Then
                Return True
            End If
        Next


        Return False
    End Function
    Private Function IsStraight(hand(,) As Integer) As Boolean
        'determines if there is a straight
        Dim denom As Integer = 13
        Do
            denom = denom - 1
        Loop Until IsAnySuit(hand, denom)

        If denom < 4 Then
            Return False

        End If
        For i As Integer = 1 To 3
            If Not IsAnySuit(hand, denom - 1) Then
                Return False
            End If
        Next
        If (denom = 12 And IsAnySuit(hand, 0) Or (denom = 12 And IsAnySuit(hand, 8))) Then
            Return True
        ElseIf denom = 4 And IsAnySuit(hand, 0) Then
            Return True
        ElseIf IsAnySuit(hand, denom - 4) Then
            Return True
        End If
        Return False
    End Function
    Private Function IsAnySuit(hand(,) As Integer, denom As Integer) As Boolean

        For suit As Integer = 0 To 3
            If hand(suit, denom) = 1 Then
                Return True
            End If

        Next
        Return False
    End Function
    Private Sub InputCard(ByRef hand(,) As Integer, ByRef suits() As Integer, ByRef denoms() As Integer, denomStr As String, suitStr As String)

        Dim denom As Integer = CInt(denomStr) - 1
        Dim suit As Integer
        Select Case suitStr.ToUpper()
            Case "C" 'this is clubs
                suit = 0
            Case "D" 'this is diamonds
                suit = 1
            Case "H" 'this is hearts
                suit = 2
            Case Else 'this is spades
                suit = 3
        End Select

        hand(suit, denom) = 1 'suit chooses the row and denom chooses the column of the array
        suits(suit) += 1 'this is the counter for suits
        denoms(denom) += 1 'this is the counter for denom
    End Sub
End Class
