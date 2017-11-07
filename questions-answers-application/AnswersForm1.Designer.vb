<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnswersForm1
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
        Me.dgvAnswers = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LoadAnswersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateAnswerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateAnswerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAnswerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCreateAnswerSubmit = New System.Windows.Forms.Button()
        CType(Me.dgvAnswers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvAnswers
        '
        Me.dgvAnswers.AllowUserToAddRows = False
        Me.dgvAnswers.AllowUserToDeleteRows = False
        Me.dgvAnswers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAnswers.Location = New System.Drawing.Point(13, 41)
        Me.dgvAnswers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvAnswers.Name = "dgvAnswers"
        Me.dgvAnswers.ReadOnly = True
        Me.dgvAnswers.RowTemplate.Height = 24
        Me.dgvAnswers.Size = New System.Drawing.Size(908, 412)
        Me.dgvAnswers.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadAnswersToolStripMenuItem, Me.CreateAnswerToolStripMenuItem, Me.UpdateAnswerToolStripMenuItem, Me.DeleteAnswerToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(932, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LoadAnswersToolStripMenuItem
        '
        Me.LoadAnswersToolStripMenuItem.Name = "LoadAnswersToolStripMenuItem"
        Me.LoadAnswersToolStripMenuItem.Size = New System.Drawing.Size(112, 24)
        Me.LoadAnswersToolStripMenuItem.Text = "Load Answers"
        '
        'CreateAnswerToolStripMenuItem
        '
        Me.CreateAnswerToolStripMenuItem.Name = "CreateAnswerToolStripMenuItem"
        Me.CreateAnswerToolStripMenuItem.Size = New System.Drawing.Size(116, 24)
        Me.CreateAnswerToolStripMenuItem.Text = "Create Answer"
        '
        'UpdateAnswerToolStripMenuItem
        '
        Me.UpdateAnswerToolStripMenuItem.Name = "UpdateAnswerToolStripMenuItem"
        Me.UpdateAnswerToolStripMenuItem.Size = New System.Drawing.Size(122, 24)
        Me.UpdateAnswerToolStripMenuItem.Text = "Update Answer"
        '
        'DeleteAnswerToolStripMenuItem
        '
        Me.DeleteAnswerToolStripMenuItem.Name = "DeleteAnswerToolStripMenuItem"
        Me.DeleteAnswerToolStripMenuItem.Size = New System.Drawing.Size(117, 24)
        Me.DeleteAnswerToolStripMenuItem.Text = "Delete Answer"
        '
        'btnCreateAnswerSubmit
        '
        Me.btnCreateAnswerSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateAnswerSubmit.Location = New System.Drawing.Point(13, 471)
        Me.btnCreateAnswerSubmit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCreateAnswerSubmit.Name = "btnCreateAnswerSubmit"
        Me.btnCreateAnswerSubmit.Size = New System.Drawing.Size(908, 76)
        Me.btnCreateAnswerSubmit.TabIndex = 4
        Me.btnCreateAnswerSubmit.Text = "Submit"
        Me.btnCreateAnswerSubmit.UseVisualStyleBackColor = True
        '
        'AnswersForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 562)
        Me.Controls.Add(Me.btnCreateAnswerSubmit)
        Me.Controls.Add(Me.dgvAnswers)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AnswersForm1"
        Me.Text = "AnswersForm1"
        CType(Me.dgvAnswers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAnswers As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LoadAnswersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateAnswerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateAnswerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteAnswerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnCreateAnswerSubmit As Button
End Class
