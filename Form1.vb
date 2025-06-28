Imports System.Runtime.CompilerServices

Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        MessageBox.Show("This is another message")

    End Sub

    Private Sub btnVariables_Click(sender As Object, e As EventArgs) Handles btnVariables.Click

        Dim stFirstName As String
        Dim stLastName As String

        stFirstName = "Jesse"
        stLastName = "Boateng"

        MessageBox.Show("hello and welcome " & stFirstName & " " & stLastName & " I hope you are well")

    End Sub

    Private Sub btnDataTypes_Click(sender As Object, e As EventArgs) Handles btnDataTypes.Click
        Dim stMake As String
        Dim stModel As String
        Dim isDoors As Integer
        Dim stColour As String
        Dim bTaxed As Boolean
        Dim iEngineSize As Integer
        Dim decPrice As Decimal
        Dim dtDateRegistered As Date

        stMake = "Ford"
        stModel = "Benz"
        isDoors = 15
        stColour = "black"
        bTaxed = True
        iEngineSize = 1200
        decPrice = 999.99
        dtDateRegistered = #11/2/2020#

        MessageBox.Show("These cars are " & stMake & " and " & stModel & "." & vbNewLine &
                        isDoors & " doors. ")

    End Sub
End Class
