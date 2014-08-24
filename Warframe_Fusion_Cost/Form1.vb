Public Class Form1

    Dim requiredFusionPoints As Integer
    Dim modRarity As Integer
    Dim modFromRank, modToRank As Integer
    Dim creditsRequired As Integer
    Dim fusionPerUnit As Single
    Dim basePrice As Integer

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Calculate()
    End Sub

    Public Sub Calculate()
        DetermineModRarity()
        DetermineFusionPerUnit()
        DetermineBasePrice()

        requiredFusionPoints = CalcTotalFusion()

        creditsRequired = Math.Ceiling(requiredFusionPoints / fusionPerUnit) * (basePrice)

        txbUnits.Text = Math.Ceiling(requiredFusionPoints / fusionPerUnit)
        txbCredits.Text = creditsRequired.ToString()
        txbFusion.Text = requiredFusionPoints.ToString()
    End Sub

    Public Sub DetermineFusionPerUnit()
        Dim currentRank As Integer = 0

        If radCore.Checked = True Then
            If radFuseCommon.Checked = True Then
                fusionPerUnit = 11.8
            ElseIf radFuseUncommon.Checked = True Then
                fusionPerUnit = 38
            ElseIf radFuseRare.Checked = True Then
                fusionPerUnit = 62
            End If

            fusionPerUnit /= 2

        Else
            If radDiffPolarity.Checked = True Then
                fusionPerUnit = 4 * modRarity * 0.25
            ElseIf radSamePolarity.Checked = True Then
                fusionPerUnit = 4 * modRarity * 0.5
            ElseIf radDuplicate.Checked = True Then
                fusionPerUnit = 4 * modRarity
            End If
        End If
    End Sub

    Public Sub DetermineBasePrice()
        If radCore.Checked = True Then
            If radFuseCommon.Checked = True Then
                basePrice = 750
            ElseIf radFuseUncommon.Checked = True Then
                basePrice = 2100
            ElseIf radFuseRare.Checked = True Then
                basePrice = 3150
            End If
        Else
            If radFuseCommon.Checked = True Then
                basePrice = 300
            ElseIf radFuseUncommon.Checked = True Then
                basePrice = 600
            ElseIf radFuseRare.Checked = True Then
                basePrice = 900
            End If
        End If
    End Sub

    Public Sub DetermineModRarity()
        If radCommon.Checked = True Then
            modRarity = 1
        ElseIf radUncommon.Checked = True Then
            modRarity = 2
        ElseIf radRare.Checked = True Then
            modRarity = 3
        End If
    End Sub

    Private Sub tbFromRank_Scroll(sender As Object, e As EventArgs) Handles tbFromRank.Scroll
        modFromRank = tbFromRank.Value
        Calculate()
    End Sub

    Private Sub tbToRank_Scroll(sender As Object, e As EventArgs) Handles tbToRank.Scroll
        modToRank = tbToRank.Value
        Calculate()
    End Sub

    Public Function CalcTotalFusion() As Integer
        Dim fusion As Integer

        For counter As Integer = modFromRank To modToRank
            fusion += 4 * modRarity * Math.Pow(2, counter)
        Next

        Return fusion
    End Function

    Private Sub radDuplicate_CheckedChanged(sender As Object, e As EventArgs) Handles radDuplicate.CheckedChanged
        If radDuplicate.Checked = True Then
            If radCommon.Checked = True Then
                radFuseCommon.Checked = True
            ElseIf radUncommon.Checked = True Then
                radFuseUncommon.Checked = True
            ElseIf radRare.Checked = True Then
                radFuseRare.Checked = True
            End If
            Calculate()
        End If
    End Sub

    'Private Sub radCommon_CheckedChanged(sender As Object, e As EventArgs) Handles radCommon.CheckedChanged
    '    If radCommon.Checked = True Then
    '        Calculate()
    '    End If
    'End Sub
    '
    'Private Sub radUncommon_CheckedChanged(sender As Object, e As EventArgs) Handles radUncommon.CheckedChanged
    '    If radUncommon.Checked = True Then
    '        Calculate()
    '    End If
    'End Sub
    '
    'Private Sub radRare_CheckedChanged(sender As Object, e As EventArgs) Handles radRare.CheckedChanged
    '    If radRare.Checked = True Then
    '        Calculate()
    '    End If
    'End Sub
    '
    'Private Sub radDiffPolarity_CheckedChanged(sender As Object, e As EventArgs) Handles radDiffPolarity.CheckedChanged
    '    If radDiffPolarity.Checked = True Then
    '        Calculate()
    '    End If
    'End Sub
    '
    'Private Sub radSamePolarity_CheckedChanged(sender As Object, e As EventArgs) Handles radSamePolarity.CheckedChanged
    '    If radSamePolarity.Checked = True Then
    '        Calculate()
    '    End If
    'End Sub
    '
    'Private Sub radCore_CheckedChanged(sender As Object, e As EventArgs) Handles radCore.CheckedChanged
    '    If radCore.Checked = True Then
    '        Calculate()
    '    End If
    'End Sub
    '
    'Private Sub radFuseCommon_CheckedChanged(sender As Object, e As EventArgs) Handles radFuseCommon.CheckedChanged
    '    If radFuseCommon.Checked = True Then
    '        Calculate()
    '    End If
    'End Sub
    '
    'Private Sub radFuseUncommon_CheckedChanged(sender As Object, e As EventArgs) Handles radFuseUncommon.CheckedChanged
    '    If radFuseCommon.Checked = True Then
    '        Calculate()
    '    End If
    'End Sub
    '
    'Private Sub radFuseRare_CheckedChanged(sender As Object, e As EventArgs) Handles radFuseRare.CheckedChanged
    '    If radFuseRare.Checked = True Then
    '        Calculate()
    '    End If
    'End Sub
End Class
