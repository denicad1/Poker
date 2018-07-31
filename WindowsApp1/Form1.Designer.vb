<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPoker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblRank = New System.Windows.Forms.Label()
        Me.lblSuit = New System.Windows.Forms.Label()
        Me.lblC1 = New System.Windows.Forms.Label()
        Me.lblC2 = New System.Windows.Forms.Label()
        Me.lblC3 = New System.Windows.Forms.Label()
        Me.lblC4 = New System.Windows.Forms.Label()
        Me.lblC5 = New System.Windows.Forms.Label()
        Me.txtC1 = New System.Windows.Forms.TextBox()
        Me.txtC2 = New System.Windows.Forms.TextBox()
        Me.txtC3 = New System.Windows.Forms.TextBox()
        Me.txtC4 = New System.Windows.Forms.TextBox()
        Me.txtC5 = New System.Windows.Forms.TextBox()
        Me.txtS1 = New System.Windows.Forms.TextBox()
        Me.txtS2 = New System.Windows.Forms.TextBox()
        Me.txtS3 = New System.Windows.Forms.TextBox()
        Me.txtS4 = New System.Windows.Forms.TextBox()
        Me.txtS5 = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblRank
        '
        Me.lblRank.AutoSize = True
        Me.lblRank.Location = New System.Drawing.Point(13, 12)
        Me.lblRank.Name = "lblRank"
        Me.lblRank.Size = New System.Drawing.Size(135, 51)
        Me.lblRank.TabIndex = 2
        Me.lblRank.Text = "Rank: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ace=1, Jack=11," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Queen=12, King=13"
        '
        'lblSuit
        '
        Me.lblSuit.AutoSize = True
        Me.lblSuit.Location = New System.Drawing.Point(155, 12)
        Me.lblSuit.Name = "lblSuit"
        Me.lblSuit.Size = New System.Drawing.Size(132, 51)
        Me.lblSuit.TabIndex = 3
        Me.lblSuit.Text = "Suit: Diamonds=D," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hearts=H, Clubs=C," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Spades=S"
        '
        'lblC1
        '
        Me.lblC1.AutoSize = True
        Me.lblC1.Location = New System.Drawing.Point(33, 73)
        Me.lblC1.Name = "lblC1"
        Me.lblC1.Size = New System.Drawing.Size(58, 17)
        Me.lblC1.TabIndex = 4
        Me.lblC1.Text = "Card #1"
        '
        'lblC2
        '
        Me.lblC2.AutoSize = True
        Me.lblC2.Location = New System.Drawing.Point(33, 103)
        Me.lblC2.Name = "lblC2"
        Me.lblC2.Size = New System.Drawing.Size(58, 17)
        Me.lblC2.TabIndex = 5
        Me.lblC2.Text = "Card #2"
        '
        'lblC3
        '
        Me.lblC3.AutoSize = True
        Me.lblC3.Location = New System.Drawing.Point(33, 133)
        Me.lblC3.Name = "lblC3"
        Me.lblC3.Size = New System.Drawing.Size(58, 17)
        Me.lblC3.TabIndex = 6
        Me.lblC3.Text = "Card #3"
        '
        'lblC4
        '
        Me.lblC4.AutoSize = True
        Me.lblC4.Location = New System.Drawing.Point(34, 166)
        Me.lblC4.Name = "lblC4"
        Me.lblC4.Size = New System.Drawing.Size(58, 17)
        Me.lblC4.TabIndex = 7
        Me.lblC4.Text = "Card #4"
        '
        'lblC5
        '
        Me.lblC5.AutoSize = True
        Me.lblC5.Location = New System.Drawing.Point(34, 198)
        Me.lblC5.Name = "lblC5"
        Me.lblC5.Size = New System.Drawing.Size(58, 17)
        Me.lblC5.TabIndex = 8
        Me.lblC5.Text = "Card #5"
        '
        'txtC1
        '
        Me.txtC1.Location = New System.Drawing.Point(97, 73)
        Me.txtC1.Name = "txtC1"
        Me.txtC1.Size = New System.Drawing.Size(51, 22)
        Me.txtC1.TabIndex = 9
        '
        'txtC2
        '
        Me.txtC2.Location = New System.Drawing.Point(97, 101)
        Me.txtC2.Name = "txtC2"
        Me.txtC2.Size = New System.Drawing.Size(51, 22)
        Me.txtC2.TabIndex = 12
        '
        'txtC3
        '
        Me.txtC3.Location = New System.Drawing.Point(97, 130)
        Me.txtC3.Name = "txtC3"
        Me.txtC3.Size = New System.Drawing.Size(51, 22)
        Me.txtC3.TabIndex = 13
        '
        'txtC4
        '
        Me.txtC4.Location = New System.Drawing.Point(97, 163)
        Me.txtC4.Name = "txtC4"
        Me.txtC4.Size = New System.Drawing.Size(51, 22)
        Me.txtC4.TabIndex = 14
        '
        'txtC5
        '
        Me.txtC5.Location = New System.Drawing.Point(97, 195)
        Me.txtC5.Name = "txtC5"
        Me.txtC5.Size = New System.Drawing.Size(51, 22)
        Me.txtC5.TabIndex = 15
        '
        'txtS1
        '
        Me.txtS1.Location = New System.Drawing.Point(209, 72)
        Me.txtS1.Name = "txtS1"
        Me.txtS1.Size = New System.Drawing.Size(34, 22)
        Me.txtS1.TabIndex = 16
        '
        'txtS2
        '
        Me.txtS2.Location = New System.Drawing.Point(209, 101)
        Me.txtS2.Name = "txtS2"
        Me.txtS2.Size = New System.Drawing.Size(34, 22)
        Me.txtS2.TabIndex = 17
        '
        'txtS3
        '
        Me.txtS3.Location = New System.Drawing.Point(209, 130)
        Me.txtS3.Name = "txtS3"
        Me.txtS3.Size = New System.Drawing.Size(34, 22)
        Me.txtS3.TabIndex = 18
        '
        'txtS4
        '
        Me.txtS4.Location = New System.Drawing.Point(209, 163)
        Me.txtS4.Name = "txtS4"
        Me.txtS4.Size = New System.Drawing.Size(34, 22)
        Me.txtS4.TabIndex = 19
        '
        'txtS5
        '
        Me.txtS5.Location = New System.Drawing.Point(209, 195)
        Me.txtS5.Name = "txtS5"
        Me.txtS5.Size = New System.Drawing.Size(34, 22)
        Me.txtS5.TabIndex = 20
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(50, 223)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(221, 41)
        Me.btnDisplay.TabIndex = 21
        Me.btnDisplay.Text = "Display Type of Hand"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(50, 294)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(220, 22)
        Me.txtResult.TabIndex = 22
        '
        'frmPoker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtS5)
        Me.Controls.Add(Me.txtS4)
        Me.Controls.Add(Me.txtS3)
        Me.Controls.Add(Me.txtS2)
        Me.Controls.Add(Me.txtS1)
        Me.Controls.Add(Me.txtC5)
        Me.Controls.Add(Me.txtC4)
        Me.Controls.Add(Me.txtC3)
        Me.Controls.Add(Me.txtC2)
        Me.Controls.Add(Me.txtC1)
        Me.Controls.Add(Me.lblC5)
        Me.Controls.Add(Me.lblC4)
        Me.Controls.Add(Me.lblC3)
        Me.Controls.Add(Me.lblC2)
        Me.Controls.Add(Me.lblC1)
        Me.Controls.Add(Me.lblSuit)
        Me.Controls.Add(Me.lblRank)
        Me.Name = "frmPoker"
        Me.Text = "Poker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRank As Label
    Friend WithEvents lblSuit As Label
    Friend WithEvents lblC1 As Label
    Friend WithEvents lblC2 As Label
    Friend WithEvents lblC3 As Label
    Friend WithEvents lblC4 As Label
    Friend WithEvents lblC5 As Label
    Friend WithEvents txtC1 As TextBox
    Friend WithEvents txtC2 As TextBox
    Friend WithEvents txtC3 As TextBox
    Friend WithEvents txtC4 As TextBox
    Friend WithEvents txtC5 As TextBox
    Friend WithEvents txtS1 As TextBox
    Friend WithEvents txtS2 As TextBox
    Friend WithEvents txtS3 As TextBox
    Friend WithEvents txtS4 As TextBox
    Friend WithEvents txtS5 As TextBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents txtResult As TextBox
End Class
