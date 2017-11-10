<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FilterDateQuestForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FilterDateQuestForm))
        Me.dgvUnansweredQuest = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LoadFilteredQuestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbBegDate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvUnansweredQuest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvUnansweredQuest
        '
        Me.dgvUnansweredQuest.AllowUserToAddRows = False
        Me.dgvUnansweredQuest.AllowUserToDeleteRows = False
        Me.dgvUnansweredQuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.dgvUnansweredQuest, "dgvUnansweredQuest")
        Me.dgvUnansweredQuest.Name = "dgvUnansweredQuest"
        Me.dgvUnansweredQuest.ReadOnly = True
        Me.dgvUnansweredQuest.RowTemplate.Height = 24
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadFilteredQuestToolStripMenuItem})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'LoadFilteredQuestToolStripMenuItem
        '
        Me.LoadFilteredQuestToolStripMenuItem.Name = "LoadFilteredQuestToolStripMenuItem"
        resources.ApplyResources(Me.LoadFilteredQuestToolStripMenuItem, "LoadFilteredQuestToolStripMenuItem")
        '
        'tbBegDate
        '
        resources.ApplyResources(Me.tbBegDate, "tbBegDate")
        Me.tbBegDate.Name = "tbBegDate"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'FilterDateQuestForm
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbBegDate)
        Me.Controls.Add(Me.dgvUnansweredQuest)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FilterDateQuestForm"
        CType(Me.dgvUnansweredQuest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvUnansweredQuest As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LoadFilteredQuestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tbBegDate As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
