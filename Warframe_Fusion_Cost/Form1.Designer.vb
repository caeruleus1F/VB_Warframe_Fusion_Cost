<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radRare = New System.Windows.Forms.RadioButton()
        Me.radUncommon = New System.Windows.Forms.RadioButton()
        Me.radCommon = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radCore = New System.Windows.Forms.RadioButton()
        Me.radDuplicate = New System.Windows.Forms.RadioButton()
        Me.radSamePolarity = New System.Windows.Forms.RadioButton()
        Me.radDiffPolarity = New System.Windows.Forms.RadioButton()
        Me.tbToRank = New System.Windows.Forms.TrackBar()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txbUnits = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.txbFusion = New System.Windows.Forms.TextBox()
        Me.txbCredits = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.radFuseRare = New System.Windows.Forms.RadioButton()
        Me.radFuseUncommon = New System.Windows.Forms.RadioButton()
        Me.radFuseCommon = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbFromRank = New System.Windows.Forms.TrackBar()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.tbToRank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.tbFromRank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radRare)
        Me.GroupBox1.Controls.Add(Me.radUncommon)
        Me.GroupBox1.Controls.Add(Me.radCommon)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mod Rarity"
        '
        'radRare
        '
        Me.radRare.AutoSize = True
        Me.radRare.Location = New System.Drawing.Point(6, 73)
        Me.radRare.Name = "radRare"
        Me.radRare.Size = New System.Drawing.Size(60, 21)
        Me.radRare.TabIndex = 2
        Me.radRare.Text = "Rare"
        Me.radRare.UseVisualStyleBackColor = True
        '
        'radUncommon
        '
        Me.radUncommon.AutoSize = True
        Me.radUncommon.Location = New System.Drawing.Point(6, 46)
        Me.radUncommon.Name = "radUncommon"
        Me.radUncommon.Size = New System.Drawing.Size(100, 21)
        Me.radUncommon.TabIndex = 1
        Me.radUncommon.Text = "Uncommon"
        Me.radUncommon.UseVisualStyleBackColor = True
        '
        'radCommon
        '
        Me.radCommon.AutoSize = True
        Me.radCommon.Checked = True
        Me.radCommon.Location = New System.Drawing.Point(6, 21)
        Me.radCommon.Name = "radCommon"
        Me.radCommon.Size = New System.Drawing.Size(84, 21)
        Me.radCommon.TabIndex = 0
        Me.radCommon.TabStop = True
        Me.radCommon.Text = "Common"
        Me.radCommon.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radCore)
        Me.GroupBox2.Controls.Add(Me.radDuplicate)
        Me.GroupBox2.Controls.Add(Me.radSamePolarity)
        Me.GroupBox2.Controls.Add(Me.radDiffPolarity)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 125)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fuse with"
        '
        'radCore
        '
        Me.radCore.AutoSize = True
        Me.radCore.Location = New System.Drawing.Point(6, 100)
        Me.radCore.Name = "radCore"
        Me.radCore.Size = New System.Drawing.Size(59, 21)
        Me.radCore.TabIndex = 3
        Me.radCore.TabStop = True
        Me.radCore.Text = "Core"
        Me.radCore.UseVisualStyleBackColor = True
        '
        'radDuplicate
        '
        Me.radDuplicate.AutoSize = True
        Me.radDuplicate.Location = New System.Drawing.Point(6, 73)
        Me.radDuplicate.Name = "radDuplicate"
        Me.radDuplicate.Size = New System.Drawing.Size(88, 21)
        Me.radDuplicate.TabIndex = 2
        Me.radDuplicate.Text = "Duplicate"
        Me.radDuplicate.UseVisualStyleBackColor = True
        '
        'radSamePolarity
        '
        Me.radSamePolarity.AutoSize = True
        Me.radSamePolarity.Location = New System.Drawing.Point(6, 46)
        Me.radSamePolarity.Name = "radSamePolarity"
        Me.radSamePolarity.Size = New System.Drawing.Size(116, 21)
        Me.radSamePolarity.TabIndex = 1
        Me.radSamePolarity.Text = "Same Polarity"
        Me.radSamePolarity.UseVisualStyleBackColor = True
        '
        'radDiffPolarity
        '
        Me.radDiffPolarity.AutoSize = True
        Me.radDiffPolarity.Checked = True
        Me.radDiffPolarity.Location = New System.Drawing.Point(6, 19)
        Me.radDiffPolarity.Name = "radDiffPolarity"
        Me.radDiffPolarity.Size = New System.Drawing.Size(134, 21)
        Me.radDiffPolarity.TabIndex = 0
        Me.radDiffPolarity.TabStop = True
        Me.radDiffPolarity.Text = "Different Polarity"
        Me.radDiffPolarity.UseVisualStyleBackColor = True
        '
        'tbToRank
        '
        Me.tbToRank.Location = New System.Drawing.Point(6, 21)
        Me.tbToRank.Maximum = 9
        Me.tbToRank.Name = "tbToRank"
        Me.tbToRank.Size = New System.Drawing.Size(295, 56)
        Me.tbToRank.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.tbToRank)
        Me.GroupBox3.Location = New System.Drawing.Point(218, 127)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(308, 100)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "to Rank..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(147, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "5"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(277, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "10"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txbUnits)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.btnCalc)
        Me.GroupBox4.Controls.Add(Me.txbFusion)
        Me.GroupBox4.Controls.Add(Me.txbCredits)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(218, 249)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(308, 100)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cost"
        '
        'txbUnits
        '
        Me.txbUnits.Location = New System.Drawing.Point(63, 71)
        Me.txbUnits.Name = "txbUnits"
        Me.txbUnits.Size = New System.Drawing.Size(151, 22)
        Me.txbUnits.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 17)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Units:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(227, 71)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "Calc"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'txbFusion
        '
        Me.txbFusion.Location = New System.Drawing.Point(63, 45)
        Me.txbFusion.Name = "txbFusion"
        Me.txbFusion.Size = New System.Drawing.Size(151, 22)
        Me.txbFusion.TabIndex = 3
        '
        'txbCredits
        '
        Me.txbCredits.Location = New System.Drawing.Point(63, 18)
        Me.txbCredits.Name = "txbCredits"
        Me.txbCredits.Size = New System.Drawing.Size(151, 22)
        Me.txbCredits.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fusion:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Credits:"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.radFuseRare)
        Me.GroupBox5.Controls.Add(Me.radFuseUncommon)
        Me.GroupBox5.Controls.Add(Me.radFuseCommon)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 249)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "of Rarity..."
        '
        'radFuseRare
        '
        Me.radFuseRare.AutoSize = True
        Me.radFuseRare.Location = New System.Drawing.Point(6, 73)
        Me.radFuseRare.Name = "radFuseRare"
        Me.radFuseRare.Size = New System.Drawing.Size(60, 21)
        Me.radFuseRare.TabIndex = 2
        Me.radFuseRare.Text = "Rare"
        Me.radFuseRare.UseVisualStyleBackColor = True
        '
        'radFuseUncommon
        '
        Me.radFuseUncommon.AutoSize = True
        Me.radFuseUncommon.Location = New System.Drawing.Point(6, 46)
        Me.radFuseUncommon.Name = "radFuseUncommon"
        Me.radFuseUncommon.Size = New System.Drawing.Size(100, 21)
        Me.radFuseUncommon.TabIndex = 1
        Me.radFuseUncommon.Text = "Uncommon"
        Me.radFuseUncommon.UseVisualStyleBackColor = True
        '
        'radFuseCommon
        '
        Me.radFuseCommon.AutoSize = True
        Me.radFuseCommon.Checked = True
        Me.radFuseCommon.Location = New System.Drawing.Point(6, 21)
        Me.radFuseCommon.Name = "radFuseCommon"
        Me.radFuseCommon.Size = New System.Drawing.Size(84, 21)
        Me.radFuseCommon.TabIndex = 0
        Me.radFuseCommon.TabStop = True
        Me.radFuseCommon.Text = "Common"
        Me.radFuseCommon.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.tbFromRank)
        Me.GroupBox6.Location = New System.Drawing.Point(218, 21)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(308, 100)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "From Rank..."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(147, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "5"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(277, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 17)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "9"
        '
        'tbFromRank
        '
        Me.tbFromRank.Location = New System.Drawing.Point(6, 21)
        Me.tbFromRank.Maximum = 9
        Me.tbFromRank.Name = "tbFromRank"
        Me.tbFromRank.Size = New System.Drawing.Size(295, 56)
        Me.tbFromRank.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 439)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Fusion Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.tbToRank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.tbFromRank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radRare As System.Windows.Forms.RadioButton
    Friend WithEvents radUncommon As System.Windows.Forms.RadioButton
    Friend WithEvents radCommon As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radDuplicate As System.Windows.Forms.RadioButton
    Friend WithEvents radSamePolarity As System.Windows.Forms.RadioButton
    Friend WithEvents radDiffPolarity As System.Windows.Forms.RadioButton
    Friend WithEvents tbToRank As System.Windows.Forms.TrackBar
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txbFusion As System.Windows.Forms.TextBox
    Friend WithEvents txbCredits As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents radCore As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents radFuseRare As System.Windows.Forms.RadioButton
    Friend WithEvents radFuseUncommon As System.Windows.Forms.RadioButton
    Friend WithEvents radFuseCommon As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbFromRank As System.Windows.Forms.TrackBar
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents txbUnits As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
