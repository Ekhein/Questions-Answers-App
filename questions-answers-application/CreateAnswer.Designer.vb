<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateAnswer
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
        Me.tbCreateAnswerSubmit = New System.Windows.Forms.TextBox()
        Me.btnCreatAnswerSubmit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbQuestID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tbCreateAnswerSubmit
        '
        Me.tbCreateAnswerSubmit.Location = New System.Drawing.Point(13, 56)
        Me.tbCreateAnswerSubmit.Multiline = True
        Me.tbCreateAnswerSubmit.Name = "tbCreateAnswerSubmit"
        Me.tbCreateAnswerSubmit.Size = New System.Drawing.Size(566, 250)
        Me.tbCreateAnswerSubmit.TabIndex = 0
        '
        'btnCreatAnswerSubmit
        '
        Me.btnCreatAnswerSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreatAnswerSubmit.Location = New System.Drawing.Point(13, 312)
        Me.btnCreatAnswerSubmit.Name = "btnCreatAnswerSubmit"
        Me.btnCreatAnswerSubmit.Size = New System.Drawing.Size(566, 105)
        Me.btnCreatAnswerSubmit.TabIndex = 1
        Me.btnCreatAnswerSubmit.Text = "Submit"
        Me.btnCreatAnswerSubmit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Question ID: "
        '
        'tbQuestID
        '
        Me.tbQuestID.BackColor = System.Drawing.SystemColors.Window
        Me.tbQuestID.Location = New System.Drawing.Point(87, 21)
        Me.tbQuestID.Name = "tbQuestID"
        Me.tbQuestID.Size = New System.Drawing.Size(100, 20)
        Me.tbQuestID.TabIndex = 3
        '
        'CreateAnswer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 429)
        Me.Controls.Add(Me.tbQuestID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCreatAnswerSubmit)
        Me.Controls.Add(Me.tbCreateAnswerSubmit)
        Me.Name = "CreateAnswer"
        Me.Text = "CreateAnswer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbCreateAnswerSubmit As TextBox
    Friend WithEvents btnCreatAnswerSubmit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tbQuestID As TextBox
End Class
