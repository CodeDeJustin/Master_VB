Public Class Form2
    Private Sub CmdFermer_Click(sender As Object, e As EventArgs) Handles CmdFermer.Click
        'Application.Exit()
        'Application.Exit() ferme tout les formulaires ouverts
        'End ferme tout

        Me.Close() 'Permet de fermer le formulaire courant
    End Sub
End Class