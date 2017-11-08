Public Class FilterDateQuestForm
    Protected db As New db
    Protected question_id As Integer

    Public Sub New(ByRef qid As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        question_id = qid
    End Sub
    Protected Sub LoadFilteredQuests()
        'db.sql = "SELECT q.id, question, COUNT(a.question_id) As 'quest_count' FROM questions q FULL JOIN answers a ON q.id=a.question_id GROUP BY q.id, question ORDER BY quest_count;"
        'db.fill(dgvUnansweredQuest)

        'db.sql = "SELECT * FROM questions WHERE user_login LIKE @excludeUser;"
        'db.bind("@excludeUser", excludeUser)
        'db.fill(dgvUnansweredQuest)

        db.sql = "SELECT * FROM questions WHERE created_at > @beginDate ORDER BY id DESC"
        db.bind("@beginDate", tbBegDate.Text)
        db.fill(dgvUnansweredQuest)

    End Sub

    Private Sub LoadFilteredQuestsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadFilteredQuestToolStripMenuItem.Click

        If tbBegDate.Text = Nothing Then
            MessageBox.Show("Make sure you input a beginning date!", "Requirement Not Filled", MessageBoxButtons.OK)
            Me.Close()
        End If
        LoadFilteredQuests()
    End Sub

End Class