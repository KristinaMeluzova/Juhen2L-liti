Imports System.ComponentModel

Public Class USwitch
    ' Klassisisene meetod pildi määramiseks
    Private Sub selectSwitch(ByVal intSwitch As Integer)
        pbSwitch.Image = imLoend.Images(intSwitch)
    End Sub


    ' Avalik liidesmeetod
    Public Sub setSwitch(ByVal strSwitch As String)
        Select Case strSwitch
            Case "switch off"
                Me.selectSwitch(0)
            Case "switch on"
                Me.selectSwitch(1)
        End Select
    End Sub

    Public Sub pbSwitch_Load(sender As Object, e As EventArgs) Handles pbSwitch.LoadCompleted
        setSwitch("switch off")
    End Sub
End Class


