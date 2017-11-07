Public Class CreateAnswer
    Protected db As db = New db
    Protected question_id As Integer

    Public Sub New(ByRef qid As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        question_id = qid

        tbQuestID.Text = question_id

    End Sub

    Private Sub btnCreatAnswerSubmit_Click(sender As Object, e As EventArgs) Handles btnCreatAnswerSubmit.Click
        db.sql = "INSERT INTO answers (question_id, answer) VALUES (@question_id, @answer)"
        db.bind("@question_id", tbQuestID.Text)
        db.bind("@answer", tbCreateAnswerSubmit.Text)
        db.execute()
        Me.Dispose()
    End Sub
End Class
