<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPoker
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
        Me.lblRank = New System.Windows.Forms.Label()
        Me.lblSuit = New System.Windows.Forms.Label()
        Me.lblC1 = New System.Windows.Forms.Label()
        Me.lblC2 = New System.Windows.Forms.Label()
        Me.lblC3 = New System.Windows.Forms.Label()
        Me.lblC4 = New System.Windows.Forms.Label()
        Me.lblC5 = New System.Windows.Forms.Label()
        Me.TxtC1 = New System.Windows.Forms.TextBox()
        Me.TxtC2 = New System.Windows.Forms.TextBox()
        Me.TxtC3 = New System.Windows.Forms.TextBox()
        Me.TxtC4 = New System.Windows.Forms.TextBox()
        Me.TxtC5 = New System.Windows.Forms.TextBox()
        Me.txtS1 = New System.Windows.Forms.TextBox()
        Me.txtS2 = New System.Windows.Forms.TextBox()
        Me.txtS3 = New System.Windows.Forms.TextBox()
        Me.txtS4 = New System.Windows.Forms.TextBox()
        Me.txtS5 = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
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
        'TxtC1
        '
        Me.TxtC1.Location = New System.Drawing.Point(97, 73)
        Me.TxtC1.Name = "TxtC1"
        Me.TxtC1.Size = New System.Drawing.Size(51, 22)
        Me.TxtC1.TabIndex = 9
        '
        'TxtC2
        '
        Me.TxtC2.Location = New System.Drawing.Point(97, 101)
        Me.TxtC2.Name = "TxtC2"
        Me.TxtC2.Size = New System.Drawing.Size(51, 22)
        Me.TxtC2.TabIndex = 12
        '
        'TxtC3
        '
        Me.TxtC3.Location = New System.Drawing.Point(97, 130)
        Me.TxtC3.Name = "TxtC3"
        Me.TxtC3.Size = New System.Drawing.Size(51, 22)
        Me.TxtC3.TabIndex = 13
        '
        'TxtC4
        '
        Me.TxtC4.Location = New System.Drawing.Point(97, 163)
        Me.TxtC4.Name = "TxtC4"
        Me.TxtC4.Size = New System.Drawing.Size(51, 22)
        Me.TxtC4.TabIndex = 14
        '
        'TxtC5
        '
        Me.TxtC5.Location = New System.Drawing.Point(97, 195)
        Me.TxtC5.Name = "TxtC5"
        Me.TxtC5.Size = New System.Drawing.Size(51, 22)
        Me.TxtC5.TabIndex = 15
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
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(165, 323)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(121, 97)
        Me.ListView1.TabIndex = 22
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'frmPoker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtS5)
        Me.Controls.Add(Me.txtS4)
        Me.Controls.Add(Me.txtS3)
        Me.Controls.Add(Me.txtS2)
        Me.Controls.Add(Me.txtS1)
        Me.Controls.Add(Me.TxtC5)
        Me.Controls.Add(Me.TxtC4)
        Me.Controls.Add(Me.TxtC3)
        Me.Controls.Add(Me.TxtC2)
        Me.Controls.Add(Me.TxtC1)
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
    Friend WithEvents TxtC1 As TextBox
    Friend WithEvents TxtC2 As TextBox
    Friend WithEvents TxtC3 As TextBox
    Friend WithEvents TxtC4 As TextBox
    Friend WithEvents TxtC5 As TextBox
    Friend WithEvents txtS1 As TextBox
    Friend WithEvents txtS2 As TextBox
    Friend WithEvents txtS3 As TextBox
    Friend WithEvents txtS4 As TextBox
    Friend WithEvents txtS5 As TextBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents ListView1 As ListView
End Class
