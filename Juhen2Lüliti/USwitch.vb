Public Class USwitch
    ' Klassisisene meetod pildi määramiseks
    Private Sub selectSwitch(ByVal intSwitch As Integer)
        pbSwitch.Image = imLoend.Images(intSwitch)
    End Sub

    ' Avalik liidesmeetod
    Public Sub setSwitch(ByVal strSwitch As String)
        Select Case strSwitch
            Case "Off"
                Me.selectSwitch(0)
            Case "On"
                Me.selectSwitch(1)
            Case Else
                Me.selectSwitch(0)
        End Select

    End Sub

End Class
