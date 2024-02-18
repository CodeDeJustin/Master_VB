'-----------------------------------------------------------------------------------------------------------------------------
'-----------------------------------------------------------------------------------------------------------------------------
'----------------------------------------- EXEMPLES VB COURS 2 - PARTIE 1 de 2------------------------------------------------
'-----------------------------------------------------------------------------------------------------------------------------
'-----------------------------------------------------------------------------------------------------------------------------
' LA GESTION DES OPTIONS DOIT ÊTRE AU DESSUS DES IMPORTS ET DES CLASS. C'EST POUR CETTE RAISON QUE CETTE PARTIE 1 DE 2 DE
' CET EXEMPLE SE RETROUVE ICI, EN HAUT DES IMPORTS SYSTEMS.

' Option
Option Explicit On
' Option Explicit à On : Force les programmeurs à définir
'                        leurs variables avant de les utiliser

Option Strict Off
' Option Strict On : Il agit comme le langage C#
' Va vous demander des conversions

Option Compare Binary
' Pour la comparaison des chaines de caractères
' Binary : Sensible à la CASSE (différence entre les majuscules et les minuscules)
' Text : pas sensible à la CASSE (Pas de différence entre les majuscules et les minuscules)

Option Infer On
' Option Infer ON : Inférence prend des choses par défaut

Imports System.Windows
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1

    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '----------------------------------------- PREMIER PROGRAMME COURS 1 ---------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' 3 apostrophes 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CmdBonjour_Click(sender As Object, e As EventArgs) Handles CmdBonjour.Click
        MessageBox.Show("Bonjour")
        'Commentaire
        REM autre commentaire
        'MessageBox.Show : Appartient au Framework de .NET
        'Fonction VB qui affiche un message
        MsgBox("Bonjour")
    End Sub

    Private Sub CmdAfficher_Click(sender As Object, e As EventArgs) Handles CmdAfficher.Click
        MessageBox.Show("Bienvenue " & TxtPrenom.Text & " " & TxtNom.Text)
    End Sub

    Private Sub CmdVider_Click(sender As Object, e As EventArgs) Handles CmdVider.Click
        TxtPrenom.Text = "" ' On peut utiliser la propriété texte pour assigner une valeur à une zone de texte
        TxtNom.Clear()
        MskTel.Clear()
        'Utilisation de la méthode Clear pour vider le contenu de la zone de texte
        TxtPrenom.Focus() 'Focus permet de donner le curseur au contrôle
    End Sub

    Private Sub CmdCacher_Click(sender As Object, e As EventArgs) Handles CmdCacher.Click
        LblNom.Visible = False
        TxtNom.Visible = False
        'Propriété Visible qui permet de cacher
        LblPrenom.Hide()
        TxtPrenom.Hide()
        'Méthode Hide permet de cacher un contrôle
    End Sub

    Private Sub CmdMontrer_Click(sender As Object, e As EventArgs) Handles CmdMontrer.Click
        LblNom.Visible = True
        TxtNom.Visible = True
        'Propriété Visible qui permet de montrer
        LblPrenom.Show()
        TxtPrenom.Show()
        'Méthode Show permet de montrer un contrôle
    End Sub

    Private Sub CmdCacherMontrer_Click(sender As Object, e As EventArgs) Handles CmdCacherMontrer.Click
        LblNom.Visible = Not LblNom.Visible
        LblPrenom.Visible = Not LblPrenom.Visible
        TxtNom.Visible = Not TxtNom.Visible
        TxtPrenom.Visible = Not TxtPrenom.Visible
    End Sub

    Private Sub CmdQuitter_Click(sender As Object, e As EventArgs) Handles CmdQuitter.Click
        'Quitter
        'Appartient à .NET (VB, C#)
        'Application.Exit()

        'Fermer la fenêtre courante...
        'Me.Close() ' En C#, ME c'est THIS : This.close();

        'Fonction VB qui permet d'arrêter l'exécution d'un programme
        End

    End Sub

    Private Sub CmdBarrer_Click(sender As Object, e As EventArgs) Handles CmdBarrer.Click
        TxtPrenom.Enabled = False
        TxtNom.Enabled = False
        GroupBox1.Enabled = False
    End Sub

    Private Sub CmdDebarrer_Click(sender As Object, e As EventArgs) Handles CmdDebarrer.Click
        TxtPrenom.Enabled = True
        TxtNom.Enabled = True
        GroupBox1.Enabled = True
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '----------------------------------------- EXERCICE 2 COURS 1 ----------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    'Définition d'un compteur pour le nombre d'essais
    Dim Nombre_Essai As Integer = 0

    Private Sub CmdAnnuler_Click(sender As Object, e As EventArgs) Handles CmdAnnuler.Click
        End
    End Sub

    Private Sub CmdOk_Click(sender As Object, e As EventArgs) Handles CmdOk.Click
        'MessageBox.Show(TxtCodeUsager.Text & " " & TxtMotDePasse.Text)

        If TxtCodeUsager.Text = "" Or TxtMotDePasse.Text = "" Then
            MessageBox.Show("Code d'usager et mot de passe obligatoire")
            TxtCodeUsager.Focus()
        Else
            If TxtCodeUsager.Text = "1234567" And TxtMotDePasse.Text = "MULTIHEXA" Then
                MessageBox.Show("Bravo...")
            Else
                Nombre_Essai = Nombre_Essai + 1
                MessageBox.Show("Code d'usager ou mot de passe invalide : Essai =>" & Nombre_Essai)
                TxtCodeUsager.Clear()
                TxtMotDePasse.Clear()
                TxtCodeUsager.Focus()

                If Nombre_Essai = 3 Then
                    MessageBox.Show("Nombre d'essais dépassé, au revoir!")
                    'End
                    Application.Exit()
                End If
            End If
        End If
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '------------------------------------------------- EXERCICE 3 COURS 1 --------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    Private Sub CmdAddition_Click(sender As Object, e As EventArgs) Handles CmdAddition.Click
        LblTotal.Text = Val(TxtNombre1.Text) + Val(TxtNombre2.Text)
    End Sub

    Private Sub CmdMultiplication_Click(sender As Object, e As EventArgs) Handles CmdMultiplication.Click
        LblTotal.Text = Val(TxtNombre1.Text) * Val(TxtNombre2.Text)
    End Sub

    Private Sub CmdPuissance_Click(sender As Object, e As EventArgs) Handles CmdPuissance.Click
        LblTotal.Text = Val(TxtNombre1.Text) ^ Val(TxtNombre2.Text)
    End Sub

    Private Sub CmdSoustraction_Click(sender As Object, e As EventArgs) Handles CmdSoustraction.Click
        LblTotal.Text = Val(TxtNombre1.Text) - Val(TxtNombre2.Text)
    End Sub

    Private Sub CmdConcatene_Click(sender As Object, e As EventArgs) Handles CmdConcatene.Click
        LblTotal.Text = TxtNombre1.Text & TxtNombre2.Text
    End Sub

    Private Sub CmdModulo_Click(sender As Object, e As EventArgs) Handles CmdModulo.Click
        LblTotal.Text = Val(TxtNombre1.Text) Mod Val(TxtNombre2.Text)
    End Sub

    Private Sub CmdDivision_Click(sender As Object, e As EventArgs) Handles CmdDivision.Click
        LblTotal.Text = Val(TxtNombre1.Text) / Val(TxtNombre2.Text)
    End Sub

    Private Sub CmdDivisionEntiere_Click(sender As Object, e As EventArgs) Handles CmdDivisionEntiere.Click
        LblTotal.Text = Val(TxtNombre1.Text) \ Val(TxtNombre2.Text)
    End Sub

    Private Sub ValiderNombre(sender As Object, e As KeyPressEventArgs) Handles TxtNombre2.KeyPress, TxtNombre1.KeyPress
        ' MsgBox(e.KeyChar)
        If e.KeyChar = vbBack Then Exit Sub
        If Char.IsDigit(e.KeyChar) = False Then
            e.KeyChar = ""
        End If
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '----------------------------------------- EXERCICE 4 COURS 1 ----------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    Dim total As Integer = 0

    Private Sub CmdCalculer_Click(sender As Object, e As EventArgs) Handles CmdCalculer.Click
        Dim Montant As Single 'Single est équivalent de FLOAT en C#
        Dim Tps As Single
        Dim Tvq As Single
        Dim total As Single

        Montant = Val(TxtMontant.Text)

        Tps = Montant * 0.05
        Tvq = Montant * 0.0975
        total = (Montant + Tps + Tvq)
        TxtTPS.Text = Tps.ToString("C")
        TxtTVQ.Text = Tvq.ToString("C")
        TxtTotal.Text = total.ToString("C")
    End Sub

    Private Sub TxtTPS_TextChanged(sender As Object, e As EventArgs) Handles TxtTPS.TextChanged
        Dim Montant As Single 'Single est équivalent de FLOAT en C#
        Dim Tps As Single
        Dim Tvq As Single
        Dim total As Single

        Montant = Val(TxtMontant.Text)

        Tps = Montant * 0.05
        Tvq = Montant * 0.0975
        total = (Montant + Tps + Tvq)
        TxtTPS.Text = Tps.ToString("C")
        TxtTVQ.Text = Tvq.ToString("C")
        TxtTotal.Text = total.ToString("C")
    End Sub

    Private Sub TxtTVQ_TextChanged(sender As Object, e As EventArgs) Handles TxtTVQ.TextChanged
        Dim Montant As Single 'Single est équivalent de FLOAT en C#
        Dim Tps As Single
        Dim Tvq As Single
        Dim total As Single

        Montant = Val(TxtMontant.Text)

        Tps = Montant * 0.05
        Tvq = Montant * 0.0975
        total = (Montant + Tps + Tvq)
        TxtTPS.Text = Tps.ToString("C")
        TxtTVQ.Text = Tvq.ToString("C")
        TxtTotal.Text = total.ToString("C")
    End Sub

    Private Sub TxtTotal_TextChanged(sender As Object, e As EventArgs) Handles TxtTotal.TextChanged
        Dim Montant As Single 'Single est équivalent de FLOAT en C#
        Dim Tps As Single
        Dim Tvq As Single
        Dim total As Single

        Montant = Val(TxtMontant.Text)

        Tps = Montant * 0.05
        Tvq = Montant * 0.0975
        total = (Montant + Tps + Tvq)
        TxtTPS.Text = Tps.ToString("C")
        TxtTVQ.Text = Tvq.ToString("C")
        TxtTotal.Text = total.ToString("C")
    End Sub

    Private Sub TxtMontant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMontant.KeyPress
        ' MsgBox(e.KeyChar)
        If e.KeyChar = vbBack Then Exit Sub
        If Char.IsDigit(e.KeyChar) = False Then 'IsLetter pour des lettres seulement
            e.KeyChar = ""
        End If
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '----------------------------------------- EXERCICE 4c COURS 1 ---------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    Public Const CanUS = 0.7327
    Public Const CanEuro = 0.66999
    Public Const USCan = 1.3649
    Public Const USEuro = 0.9552
    Public Const EuroCan = 1.4288
    Public Const EuroUS = 1.0469

    Private Sub OptCan_CheckedChanged(sender As Object, e As EventArgs) Handles OptCan.CheckedChanged
        If OptCan.Checked Then
            TxtDollarCanadien.ReadOnly = False
            TxtDollarUS.ReadOnly = True
            TxtEuro.ReadOnly = True
            TxtDollarCanadien.Focus()
            TxtEuro.Text = Format((Val(TxtDollarCanadien.Text) * 0.736), "0.00")
            TxtEuro.Text = Format((Val(TxtDollarCanadien.Text) * 0.7013), "0.00")
        End If
        TxtDollarCanadien.Clear()
        TxtDollarUS.Clear()
        TxtEuro.Clear()
    End Sub

    Private Sub OptUS_CheckedChanged(sender As Object, e As EventArgs) Handles OptUS.CheckedChanged
        If OptUS.Checked Then
            TxtDollarCanadien.ReadOnly = True
            TxtDollarUS.ReadOnly = False
            TxtEuro.ReadOnly = True
            TxtDollarUS.Focus()
            TxtDollarCanadien.Text = Format((Val(TxtDollarCanadien.Text) * 1.37), "0.00")
            TxtEuro.Text = Format((Val(TxtDollarCanadien.Text) * 0.96), "0.00")
        End If
        TxtDollarCanadien.Clear()
        TxtDollarUS.Clear()
        TxtEuro.Clear()
    End Sub

    Private Sub OptEuro_CheckedChanged(sender As Object, e As EventArgs) Handles OptEuro.CheckedChanged
        If OptEuro.Checked Then
            TxtDollarCanadien.ReadOnly = True
            TxtDollarUS.ReadOnly = True
            TxtEuro.ReadOnly = False
            TxtEuro.Focus()
            TxtDollarUS.Text = Format((Val(TxtDollarCanadien.Text) * 1.05), "0.00")
            TxtDollarCanadien.Text = Format((Val(TxtDollarCanadien.Text) * 1.43), "0.00")
        End If
        TxtDollarCanadien.Clear()
        TxtDollarUS.Clear()
        TxtEuro.Clear()
    End Sub

    Private Sub CmdConvertir_Click(sender As Object, e As EventArgs) Handles CmdConvertir.Click
        Dim montant As Single
        If OptCan.Checked Then
            montant = Val(TxtDollarCanadien.Text)
            TxtDollarUS.Text = montant * CanUS
            TxtEuro.Text = montant * CanEuro

        ElseIf OptUS.Checked Then
            montant = Val(TxtDollarUS.Text)
            TxtDollarCanadien.Text = montant * USCan
            TxtEuro.Text = montant * USEuro

        ElseIf OptEuro.Checked Then
            montant = Val(TxtEuro.Text)
            TxtDollarCanadien.Text = montant * EuroCan
            TxtDollarUS.Text = montant * EuroUS
        End If
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '----------------------------------------- EXEMPLES VB COURS 2 - PARTIE 2 de 2------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    ' LA GESTION DES OPTIONS (partie 1 de 2) EST AU TOUT DÉBUT, AU DESSUS DES IMPORTS ET DES CLASS.

    Public Const TVQ = 0.9
    'Dim Nbr1 As Integer
    'Dim Nbr2 As Integer
    Dim nbr1, nbr2 As Integer 'Option Infer On permet de les mettre sur une seule ligne
    Dim x 'C'est quoi son type? OBJECT
    Dim _telephone = "(418) 555-5555"
    Dim str_addresse

    Private Sub CmdVariable_Click(sender As Object, e As EventArgs) Handles CmdVariable.Click
        Dim Nom As String     ' → pas nécessaire si Option Explicit Off. Sinon
        'Ici la variable Nom est une variable LOCALE, visible seulement dans ce bloc de code
        Nom = "Laberge"
        MsgBox(Nom)
        MsgBox(_telephone)
    End Sub

    Private Sub CmdAffichervb2_Click(sender As Object, e As EventArgs) Handles CmdAffichervb2.Click
        MsgBox(_telephone)
    End Sub


    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '----------------------------------------- EXEMPLES FORMULAIRES COURS 2 ------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    Private Sub CmdForm2_Click(sender As Object, e As EventArgs) Handles CmdForm2.Click
        'Form2.Show()

        'on peut se créer un instance du formulaire 2 et on le montre
        Dim frm As New Form2
        frm.ShowDialog() 'On doit refermer le formulaire jaune pour accéder à nouveau au formulaire violet

        'formulaire MODALE (méthode ShowDialog)
        'Formulaire qui ne permettra pas la navigation entre les formulaires de l'application

        'Formulaire NON-MODALE (méthode Show)
        'Formulaire qui permettra la navigation entre les formulaires de l'application
    End Sub

    Private Sub FrmApropos_Click(sender As Object, e As EventArgs) Handles FrmApropos.Click
        Dim frm As New FrmApropos
        frm.ShowDialog()
    End Sub


    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '----------------------------------------- EXEMPLES VARIABLES VB COURS 2 -----------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    ' Variable Globale pour le formulaire
    Dim Cpt1 As Integer = 0
    Private Cpt3 As Integer

    Private Sub CmdCompter_Click(sender As Object, e As EventArgs) Handles CmdCompter.Click
        'Variable locale
        Dim Cpt2 As Integer
        ' Variable locale qui conserve sa valeur... (Static différent entre VB et C#)
        Static cpt4 As Integer 'static reviens au même que de mettre dans le public class

        MsgBox(College)

        Cpt1 = Cpt1 + 1
        Cpt2 = Cpt2 + 1
        Cpt3 = Cpt3 + 1
        cpt4 += 1
        Cpt5 += 1
        MsgBox("Cpt1 : " & Cpt1 & vbCrLf & "Cpt2 : " & Cpt2 _
               & Environment.NewLine & "Cpt3 : " & Cpt3 _
                       & Environment.NewLine & "Cpt4 : " & cpt4 _
                       & Environment.NewLine & "Cpt5 : " & Cpt5)
    End Sub

    Private Sub CmdCompter2_Click(sender As Object, e As EventArgs) Handles CmdCompter2.Click
        'Variable locale
        Dim Cpt2 As Integer
        ' Variable locale qui conserve sa valeur... (Static différent entre VB et C#)
        Static cpt4 As Integer 'static reviens au même que de mettre dans le public class
        MsgBox(College)
        Cpt1 = Cpt1 + 1
        Cpt3 = Cpt3 + 1

        Cpt5 += 1
        MsgBox("Cpt1 : " & Cpt1 & vbCrLf _
               & Environment.NewLine & "Cpt3 : " & Cpt3 _
                       & Environment.NewLine & "Cpt5 : " & Cpt5)

    End Sub

    Private Sub CmdNomreAleatoire_Click(sender As Object, e As EventArgs) Handles CmdNomreAleatoire.Click
        Dim Hasard As New Random()
        Dim nbr As Integer
        nbr = Hasard.Next(1, 100) 'Hasard.Next est un objet
        MessageBox.Show("Nombre généré :" & nbr)
        MessageBox.Show($"Nombre généré : {nbr}")
        If nbr Mod 2 = 0 Then
            MsgBox("Nombre pair")
        Else
            MsgBox("Nombre impair")
        End If

        'Vérifier s le nombre est entre 50 et 60
        If nbr >= 50 And nbr <= 60 Then
            MsgBox("Nombre compris entre 50 et 60 : " & nbr)
        End If
    End Sub

    Private Sub CmdFumeur_Click(sender As Object, e As EventArgs) Handles CmdFumeur.Click

        If ChkFumeur.Checked = True Then
            MsgBox("Personne fumeur")
        Else
            MsgBox("Personne non-fumeur")
        End If

        If OptFeminin.Checked Then
            MsgBox("Féminin")
        ElseIf OptMasculin.Checked Then
            MsgBox("Masculin")
        ElseIf OptAutre.Checked Then
            MsgBox("Autre")
        Else
            MsgBox("Aucune sélection")
        End If

        ' Ci haut et ci bas donne le même résultat, c'est une façon différente de l'inscrire

        If OptFeminin.Checked = True Then
            MsgBox("Féminin")
        Else
            If OptMasculin.Checked = True Then
                MsgBox("Masculin")
            Else
                If OptAutre.Checked = True Then
                    MsgBox("Autre")
                Else
                    MsgBox("Aucune sélection")
                End If
            End If
        End If
    End Sub

    Private Sub CmdEtat_Click(sender As Object, e As EventArgs) Handles CmdEtat.Click
        Select Case TxtEtat.Text
            Case "M" : MsgBox("Marié(e)")
            Case "C" : MsgBox("Célibataire")
            Case "D" : MsgBox("Divorcé(e)")
            Case "V" : MsgBox("Veuf(ve)")
            Case MsgBox("autre état")
        End Select
    End Sub

    Private Sub OptFeminin_CheckedChanged(sender As Object, e As EventArgs) Handles OptFeminin.CheckedChanged
        If OptFeminin.Checked Then
            LblValidationSexe.Text = "Selon votre sélection, votre genre est : ".ToLower() & vbNewLine & "FEMME"
        End If
    End Sub

    Private Sub OptMasculin_CheckedChanged(sender As Object, e As EventArgs) Handles OptMasculin.CheckedChanged
        If OptMasculin.Checked Then
            LblValidationSexe.Text = "Selon votre sélection, votre genre est : ".ToLower() & vbNewLine & "HOMME"
        End If
    End Sub

    Private Sub OptAutre_CheckedChanged(sender As Object, e As EventArgs) Handles OptAutre.CheckedChanged
        If OptAutre.Checked Then
            LblValidationSexe.Text = "Selon votre sélection, votre genre est : ".ToLower() & vbNewLine & "AUTRE ou NON-DÉTERMINÉ"
        End If
    End Sub

    Private Sub CmdViderValidationSexe_Click(sender As Object, e As EventArgs) Handles CmdViderValidationSexe.Click
        LblValidationSexe.Clear()
        OptMasculin.Checked = False
        OptFeminin.Checked = False
        OptAutre.Checked = False
    End Sub


    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '----------------------------------------- EXEMPLES BOUCLES COURS 3 ----------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    Private Sub CmdBoucle_Click(sender As Object, e As EventArgs) Handles CmdBoucle.Click
        'Tant QUE : Condition placée au début, 
        ' A besoin d'initialisation pas certain de se faire
        ' Se fait lorsque la condition est VRAIE, quitte lorsque FAUX

        'Tant que
        Dim cpt As Integer = 1 ' Par défaut c'est à 0
        Do While cpt < 11
            MsgBox("Compteur : " & cpt)
            cpt += 1
            If cpt = 6 Then Exit Do ' Exit Do c'est un Break de C#
        Loop

        ' Tant que
        Dim Nom As String
        Dim StrAge As String
        Do While Nom = ""
            Nom = InputBox("Entrez votre nom : ", "Saisir nom", "Allard")
            StrAge = InputBox("Entrez votre âge :", "Age", 20)
        Loop

        ' Jusqu'à : Condition placée au début
        ' Pas certain de se faire, a besoin d'une initialisation
        ' Se fait lorsque la condition est fausse quitte lorsque vrai
        cpt = 1
        Do Until cpt >= 11
            MsgBox("Compteur : " & cpt)
            cpt += 1
            If cpt = 6 Then Exit Do ' Exit Do c'est un Break de C#
        Loop

        ' Répète tant que
        cpt = 1
        Do
            MsgBox("Compteur : " & cpt)
            cpt += 1
            If cpt = 6 Then Exit Do ' Exit Do c'est un Break de C#
        Loop While cpt < 11

        ' Répète Jusqu'à
        cpt = 1
        Do
            MsgBox("Compteur : " & cpt)
            cpt += 1
            If cpt = 6 Then Exit Do ' Exit Do c'est un Break de C#
        Loop Until cpt >= 11
    End Sub

    Private Sub CmdBouclePour_Click(sender As Object, e As EventArgs) Handles CmdBouclePour.Click
        ' Boucle Pour : On l'utilise lorsqu'on connait le nombre d'itérations
        ' Exemple : Afficher les nombres de 1 à 10
        Dim cpt As Integer
        For cpt = 1 To 10
            MsgBox("Cpt: " & cpt)
            'If cpt = 5 Then Exit for
        Next

        ' Afficher les nombres de 10 à 1
        ' For 
        For cpt = 10 To 1 Step -1 ' En C# ça équivaut à For(initialisation; condition; incrémentation
            MsgBox("Cpt: " & cpt)
        Next

        'Définir un tableau
        Dim combine() As Integer = {10, 15, 22, 28, 33, 44}
        'Afficher les valeurs que contient le tableau
        Dim i As Integer
        ' For i = 0 To 5
        For i = combine.GetLowerBound(0) To combine.GetUpperBound(0)
            MsgBox(combine(i))
        Next

        Dim ListeEleves() As String = {"Éric", "Pierre", "Nicole", "Sonia", "Martine"}
        Array.Sort(ListeEleves)

        'For i = 0 To ListeEleves.GetUpperBound(0)
        '  MsgBox(ListeEleves(i))
        'Next
        For Each ch As String In ListeEleves
            MsgBox(ch)
        Next

        ' C'est quoi un TABLEAU : Regroupement d'éléments de même type sous un nom donné
        '                         Tableau de taille fixe (statique)(dynamique)
        '                         Le 1er indice du tableau est zéro...
        '                         Un tableau peut posséder plusieurs dimensions...
        Dim message As String = "Bonjour comment ça va? "
        For i = 0 To message.Length - 1
            MsgBox(message(i))
        Next

        Dim mots() As String = message.Split(" ") ' Split existe das C#
        For Each mot As String In mots
            MsgBox(mot)
        Next
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '----------------------------------------- PROCÉDURES ET FONCTIONS COURS 3 ---------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    ' En VB le SUB indique une procédure (SubRoutine)
    Private Sub CmdProcedure_Click(sender As Object, e As EventArgs) Handles CmdProcedure.Click
        Bonjour() ' Appel de la procédure...
        Bonjour("Pierre")
        Afficher_Grandeur(5, 8)
        Afficher_Grandeur(1.75)
        Aurevoir()
    End Sub

    Private Sub Afficher_Grandeur(pieds As Integer, pouces As Integer)
        MsgBox($"Vous mesurez {pieds} pieds et {pouces} pouces")
    End Sub

    Private Sub Afficher_Grandeur(Grandeur As Single)
        MsgBox($"Vous mesurez {Grandeur} mètres.")
    End Sub

    ''' <summary>
    ''' Procédure permettant de saluer une personne
    ''' </summary>
    Private Sub Bonjour()
        MsgBox("Bonjour")
    End Sub

    ' C'est quoi une SURCHAGE : Procédure ou fonction portant le même nom, mais ayant des signatures différentes.
    ''' <summary>
    ''' Procédure permettant de saluer une personne
    ''' </summary>
    ''' <param name="Nom">Nom de la personne à saluer</param>
    Private Sub Bonjour(Nom As String)
        MsgBox("Bonjour " & Nom)
    End Sub

    Private Sub CmdFonction_Click(sender As Object, e As EventArgs) Handles CmdFonction.Click
        Dim nbr As Integer
        Dim hasard As New Random()
        nbr = hasard.Next(501)
        If Pair(nbr) Then
            MsgBox("Pair " & nbr)
        Else
            MsgBox("Impair " & nbr)
        End If

        MsgBox("Cube au nombre " & nbr & " est " & Cube(nbr))

        Dim chaine As String
        chaine = InputBox("Entrez le texte désiré : ", "Texte")
        Dim nbrLettres As Integer
        nbrLettres = DenombrerLettre(chaine)
        ' Écrivez la fonction DénombrerLettre qui vous retournera le nombre de lettres 
        ' comprises dans la chaine que vous lui passerez
        MsgBox($"Nombre de lettres dans la chaine {nbrLettres}")
    End Sub

    Private Function DenombrerLettre(ch As String) As Integer
        Dim i, cpt As Integer
        For i = 0 To ch.Length - 1
            If Char.IsLetter(ch(i)) = True Then
                cpt += 1
            End If
        Next
        Return cpt
    End Function

    ' En VB, nous avons 2 manières de retourner la valeur de RETOUR
    ' 1 - La commande RETURN
    ' 2 - En ASSIGNANT LA VALEUR À RETOURNER DANS LE NOM DE LA FONCTION
    Private Function Cube(nbr As Integer) As Integer
        'Return nbr ^ 3
        Cube = nbr ^ 3
    End Function

    Private Function Pair(nbr As Integer) As Boolean
        If nbr Mod 2 = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub CmdParametre_Click(sender As Object, e As EventArgs) Handles CmdParametre.Click
        ' Paramètre : Information que l'on passe à une procédure ou fonction
        ' pour que celle-ci s'exécute de manière adéquate

        ' Par RÉFÉRENCE : C'est l'original
        ' Par VALEUR    : Copie de la case mémoire

        Dim nbr As Integer = 4
        MsgBox("Avant l'appel Proc1: " & nbr)
        Proc1(nbr)
        MsgBox("Après l'appel Proc1: " & nbr)

        MsgBox("Avant l'appel Proc2: " & nbr)
        Proc1(nbr)
        MsgBox("Après l'appel Proc2: " & nbr)
        Changer_Couleur(CmdParametre)
    End Sub

    Private Sub Changer_Couleur(ByVal b As Button)
        b.BackColor = Color.Yellow
        ' b.Enabled = False Pour barrer le boutton
    End Sub

    Private Sub Proc1(ByVal n) '
        n = n + 2
        MsgBox("n: " & n)
    End Sub

    Private Sub Proc2(ByRef n)
        n = n + 2
        MsgBox("n: " & n)
    End Sub
    'Un objet est TOUJOURS passé par RÉFÉRENCE

    Private Sub CmdParametreOptionnel_Click(sender As Object, e As EventArgs) Handles CmdParametreOptionnel.Click
        Saluer()
        Saluer("Martin")
        Saluer(, "Manon")
        Saluer("Nicole", "Suzanne")
    End Sub

    ' Avant l'utilisation des surcharges, nous utilisions les paramètres optionnels.
    ' Optionnal : Devait toujours être les derniers paramètres...
    Private Sub Saluer(Optional Nom1 As String = "Jean", Optional Nom2 As String = "Jacques")
        MsgBox("Salut " & Nom1 & " et " & Nom2)
    End Sub

    Private Sub CmdParametreNomme_Click(sender As Object, e As EventArgs) Handles CmdParametreNomme.Click
        ' Paramètre Nommé : Me permet de changer l'ordre des paramètres lors
        ' de l'appel de la procédure ou de la fonction (En le nommant)
        MsgBox("Bonjour", MsgBoxStyle.OkOnly, "Titre")
        MsgBox(Title:="Titre", Prompt:="Bonjour", Buttons:=MsgBoxStyle.OkOnly)
    End Sub

    Private Sub CmdParametreArray_Click(sender As Object, e As EventArgs) Handles CmdParametreArray.Click
        ' ParamArray: Permet de passer un nombre variable de paramètres
        ' et construira un tableau avec l'ensemble des paramètres.
        Dim moy As Single

        moy = Calculer_Moyenne(80, 70, 75, 89, 55)
        MsgBox("Moyenne: " & moy)

        moy = Calculer_Moyenne(80, 70, 75, 89, 55, 70, 69, 100, 83, 33, 78)
        MsgBox("Moyenne: " & moy)

    End Sub

    Private Function Calculer_Moyenne(ParamArray Notes() As Single) As Single
        Return Notes.Average()
    End Function

    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '------------------------------------------------ TABLEAUX COURS 3 -----------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    'Variable globale pour le formulaire
    Dim Notes(4, 4) As Integer ' (4, 4) c'est un tableau de 5 lignes par 5 colonnes, donc 25 cases de 4 octets (0, 1, 2, 3, 4)

    Private Sub CmdInitialiser_Click(sender As Object, e As EventArgs) Handles CmdInitialiser.Click
        Dim L, C As Integer
        Dim Hasard As New Random()
        For L = 0 To Notes.GetUpperBound(0)
            For C = 0 To Notes.GetUpperBound(1)
                Notes(L, C) = Hasard.Next(0, 101)
            Next
        Next
        ' Un feedback à l'utilisateur...
        MessageBox.Show("Tableau initialisé...")
    End Sub

    Private Sub CmdAfficherTableauCours3_Click(sender As Object, e As EventArgs) Handles CmdAfficherTableauCours3.Click
        Dim Chaine As String = "Contenu Tableau" & vbCrLf ' Permet de Changer de ligne
        Dim L, C As Integer
        For L = 0 To Notes.GetUpperBound(0)
            For C = 0 To Notes.GetUpperBound(1)
                Chaine = Chaine & Notes(L, C).ToString() & " "
            Next
            Chaine = Chaine & Environment.NewLine ' vbCrLf fait la même chose que ça
        Next
        MsgBox(Chaine)
    End Sub

    Private Sub CmdDouble_Click(sender As Object, e As EventArgs) Handles CmdDouble.Click
        ' 1re manière pour ne pas avoir de nombres en double
        Dim vecteur() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
        Dim temp As Integer
        Dim pos1, pos2 As Integer
        Dim hasard As New Random()
        For cpt = 1 To 1000
            pos1 = hasard.Next(10)
            pos2 = hasard.Next(10)
            temp = vecteur(pos1)
            vecteur(pos1) = vecteur(pos2)
            vecteur(pos2) = temp
        Next

        For cpt = 0 To 9
            MsgBox(vecteur(cpt))
        Next

        Dim vecteur2(9) As Integer
        Dim Valide() As Boolean = {False, False, False, False, False, False, False, False, False, False}
        Dim nbr As Integer
        For cpt = 0 To 9
            Do
                nbr = hasard.Next(1, 10)
            Loop While (Valide(nbr - 1) = True)
            vecteur2(cpt) = nbr
            Valide(nbr - 1) = True
        Next

        For cpt = 0 To 9
            MsgBox(vecteur2(cpt))
        Next
    End Sub


    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '------------------------------------------------ EXERCICE #5 (VU AU COURS 3) -------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    ' Variable globale pour le formulaire
    Dim Tableau(99) As Integer

    Private Sub CmdInitialiserEx5_Click(sender As Object, e As EventArgs) Handles CmdInitialiserEx5.Click
        ' Initialiser le tableau avec des nombres aléatoires entre 0 et 100
        Dim i As Integer
        Dim hasard As New Random
        For i = 0 To Tableau.GetUpperBound(0)
            Tableau(i) = hasard.Next(101)
        Next
        MsgBox("** Tableau Initialisé **")
    End Sub

    Private Sub CmdAfficherTableau_Click(sender As Object, e As EventArgs) Handles CmdAfficherTableau.Click
        Dim chaine As String = "Contenu du tableau: " & Environment.NewLine
        Dim i As Integer
        For i = 0 To Tableau.GetUpperBound(0)
            chaine = chaine & Tableau(i).ToString("000") & " "
        Next
        MsgBox(chaine)
    End Sub

    Private Sub CmdViderTableau_Click(sender As Object, e As EventArgs) Handles CmdViderTableau.Click
        Array.Clear(Tableau, 0, Tableau.Length)
        MsgBox("Tableau vidé")
    End Sub

    Private Sub CmdTrierTableau_Click(sender As Object, e As EventArgs) Handles CmdTrierTableau.Click
        'Array.Sort(Tableau)
        'MsgBox("*** Tableau Trié ***")
        Dim i, j, temp As Integer
        For i = 0 To Tableau.GetUpperBound(0) - 1
            For j = i + 1 To Tableau.GetUpperBound(0)
                If Tableau(i) < Tableau(j) Then
                    temp = Tableau(i)
                    Tableau(i) = Tableau(j)
                    Tableau(j) = temp
                End If
            Next
        Next
    End Sub

    Private Sub CmdMoyenne_Click(sender As Object, e As EventArgs) Handles CmdMoyenne.Click
        MsgBox("La moyenne est : " & Tableau.Average())
        MsgBox("La moyenne est : " & Tableau.Sum() / Tableau.Length)

        Dim total As Integer
        Dim moy As Single
        Dim i As Integer
        For i = 0 To Tableau.GetUpperBound(0)
            total += Tableau(i)
        Next
        moy = total / Tableau.Length
        MsgBox("La moyenne est : " & moy)
    End Sub

    Private Sub CmdPairImpair_Click(sender As Object, e As EventArgs) Handles CmdPairImpair.Click
        Dim i As Integer
        Dim Pair, impair As Integer
        For i = 0 To Tableau.GetUpperBound(0)
            If Tableau(i) Mod 2 = 0 Then
                Pair += 1
            Else
                impair += 1
            End If
        Next
        MsgBox($"Nombre de chiffres pairs {Pair}    Nombre de chiffres impairs {impair}")
    End Sub


    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '------------------------------------------------ VB FONCTIONS COURS 4 -------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    Private Sub CmdFonctionMsgBox_Click(sender As Object, e As EventArgs) Handles CmdFonctionMsgBox.Click
        MsgBox("Bonjour")
        Dim rep As MsgBoxResult
        rep = MsgBox("Êtes vous fumeur?", MsgBoxStyle.YesNo)
        If rep = MsgBoxResult.Yes Then
            MsgBox("Vous êtes fumeur...")
        Else
            MsgBox("Vous êtes non fumeur...")
        End If

        Dim rep2 As DialogResult
        rep2 = MessageBox.Show("Aimez-vous le cours?", "Titre", MessageBoxButtons.YesNo)
        If rep2 - DialogResult.Yes Then
            MsgBox("Tant mieux!")
        Else
            MsgBox("Désolé...")
        End If
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '--------------------------------- GESTION D'ERREURS STRUCTURÉES ET NON STRUCTURÉES COURS 4 ----------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    Private Sub CmdGestionStructuree_Click(sender As Object, e As EventArgs) Handles CmdGestionStructuree.Click
        Try
            'Try → L'emplacement du code à tester...
            Dim nbr As Integer
            nbr = InputBox("Entrez un nombre de 1 à 10", "Titre", 1)
        Catch ex As InvalidCastException
            MsgBox("Problème de conversion")
        Catch ex As Exception ' Exception toujours en dernier
            'Catch → Ce qu'on fera en cas d'erreur
            MsgBox(ex.Message)
        Finally ' Section qui sera toujours exécuté Erreur ou pas
            MsgBox("Au revoir!")
        End Try
    End Sub

    Private Sub CmdGestionErreurStructuree2_Click(sender As Object, e As EventArgs) Handles CmdGestionErreurStructuree2.Click
        Try
            'Appel dun bloc de code
            P1()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub P1()
        'ici on plante...
        'Dim tab(4) As Integer
        'TAB(5) = 8

        'On peut lancer des exceptions
        Throw New Exception("Problème avec la validation")
    End Sub

    Private Sub CmdGestionErreurNonStructuree_Click(sender As Object, e As EventArgs) Handles CmdGestionErreurNonStructuree.Click
        'On Error Goto 0 → ' Désactive la gestion d'erreurs.
        'On Error Resume Next → très dangereux, éviter d'utiliser... Car il passe par dessus l'erreur!
        On Error GoTo Erreur
        'Ici on place le code à tester...
        Dim tab(4) As Integer
        tab(5) = 8 ' Erreur provoquée!
        Err.Raise(9999, , "Problème avec le code")

        Exit Sub
Erreur:
        MsgBox(Err.Number & " " & Err.Description)
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '------------------------------------------------ TABLEAUX DYNAMIQUES COURS 4 ------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    'Variable globale au formulaire
    Dim Panier() As String
    Dim CptFruits As Integer = -1

    Dim TabEtu As New ArrayList


    Private Sub CmdAjouter_Click(sender As Object, e As EventArgs) Handles CmdAjouter.Click
        If TxtFruit.Text.Trim() = "" Then
            MsgBox("Fruit obligatoire")
        Else
            'ici on l'ajoute au panier
            CptFruits += 1
            ReDim Preserve Panier(CptFruits)
            Panier(CptFruits) = TxtFruit.Text.Trim()
            TxtFruit.Clear()
            TxtFruit.Focus()
        End If
    End Sub

    Private Sub CmdAfficherContenu_Click(sender As Object, e As EventArgs) Handles CmdAfficherContenu.Click
        If IsArray(Panier) = False Then
            MsgBox("Panier vide")
            Exit Sub
        End If
        Dim i As Integer
        Dim chaine As String = "Contenu du panier: " & Environment.NewLine
        For i = 0 To Panier.GetUpperBound(0)
            chaine = chaine & Panier(i) & vbCrLf
        Next
        MsgBox(chaine)
    End Sub

    Private Sub CmdTrier_Click(sender As Object, e As EventArgs) Handles CmdTrier.Click
        If IsArray(Panier) = True Then
            Array.Sort(Panier)
            MsgBox("Liste des fruits triée")
        End If
        Array.Sort(Panier)
    End Sub

    Private Sub CmdViderTableauCours4_Click(sender As Object, e As EventArgs) Handles CmdViderTableauCours4.Click
        'Erase : ça enlève tout le contenu du tableau
        Erase Panier
        CptFruits = -1
        MsgBox("Le panier est vide")

        'Array.Clear() ne vide pas un tableau, il initialise un tableau
    End Sub

    Private Sub CmdEnlever_Click(sender As Object, e As EventArgs) Handles CmdEnlever.Click
        If CptFruits >= 0 Then
            CptFruits -= 1
            ReDim Preserve Panier(CptFruits)
            MsgBox("Fruit enlevé du panier")
        End If

    End Sub

    Private Sub CmdAjouterEtu_Click(sender As Object, e As EventArgs) Handles CmdAjouterEtu.Click
        If TxtEtu.Text = "" Then
            MsgBox("Nom de l'étudiant obligatoire")
        Else
            If TabEtu.Contains(TxtEtu.Text) = True Then
                MsgBox("Étudiant déjà dans la liste")
            Else
                TabEtu.Add(TxtEtu.Text)
                TxtEtu.Clear()
                TxtEtu.Focus()
            End If
        End If

        'Afficher la liste des étudiants dans l'étiquette LblListeEtudiants
        Dim strListeEtudiants As String = ""
        For i As Integer = 0 To TabEtu.Count - 1
            strListeEtudiants &= TabEtu(i) & vbCrLf 'concaténer chaque étudiant avec un saut de ligne
        Next
        LblListeEtudiants.Text = strListeEtudiants
    End Sub

    Private Sub CmdListerEleve_Click(sender As Object, e As EventArgs) Handles CmdListerEleve.Click
        Dim i As Integer
        For i = 0 To TabEtu.Count - 1
            MsgBox(TabEtu(i))
        Next
        'TabEdu.sort() ' Permet de trier mon tableau dynamique (SORT)
        'For Each nom As String In TabEtu
        'MsgBox(nom)
        'Next
    End Sub

    Private Sub CmdViderListeEtudiants_Click(sender As Object, e As EventArgs) Handles CmdViderListeEtudiants.Click
        LblListeEtudiants.Clear()
        'Array.Clear() ne vide pas un tableau, il initialise un tableau
    End Sub


    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '------------------------------------------------ FONCTIONS VB #1 COURS 5 ----------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    Private Sub Valider_chaine(sender As Object, e As KeyPressEventArgs) Handles TxtPrenom_cours5.KeyPress, TxtNom_cours5.KeyPress
        'MsgBox(e.KeyChar & " " & Asc(e.KeyChar))
        If e.KeyChar = " " Or e.KeyChar = "-" Or e.KeyChar = Chr(39) Or e.KeyChar = Chr(8) Then Exit Sub
        If Char.IsLetter(e.KeyChar) = False Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub CmdMajuscule_cours5_Click(sender As Object, e As EventArgs) Handles CmdMajuscule_cours5.Click
        ' Utilisation de la FONCTION VB Ucase(fonction → retourne la valeur) pour convertir en majuscule
        TxtPrenom_cours5.Text = UCase(TxtPrenom_cours5.Text)
        ' En .NET on utilise la méthode ToUpper()
        TxtNom_cours5.Text = TxtNom_cours5.Text.ToUpper()
    End Sub

    Private Sub CmdMinuscule_cours5_Click(sender As Object, e As EventArgs) Handles CmdMinuscule_cours5.Click
        ' Utilisation de la FONCTION VB Ucase(fonction → retourne la valeur) pour convertir en minuscule
        TxtPrenom_cours5.Text = LCase(TxtPrenom_cours5.Text)
        ' En .NET on utilise la méthode ToLower()
        TxtNom_cours5.Text = TxtNom_cours5.Text.ToLower()
    End Sub

    Private Sub CmdMajMin_cours5_Click(sender As Object, e As EventArgs) Handles CmdMajMin_cours5.Click
        Dim i As Integer
        Dim chaine As String = ""
        ' Une chaine de caractère c'est aussi un TABLEAU de caractères...
        For i = 0 To TxtPrenom_cours5.Text.Length - 1
            If i Mod 2 = 0 Then
                chaine = chaine & UCase(TxtPrenom_cours5.Text(i))
                chaine = chaine & UCase(TxtNom_cours5.Text(i))
            Else
                chaine = chaine & LCase(TxtPrenom_cours5.Text(i))
                chaine = chaine & LCase(TxtNom_cours5.Text(i))
            End If
        Next
        TxtPrenom_cours5.Text = chaine
    End Sub

    Private Sub CmdEnleverBlancDebut_cours5_Click(sender As Object, e As EventArgs) Handles CmdEnleverBlancDebut_cours5.Click
        ' Fonction VB Ltrim (Left Trim)
        TxtPrenom_cours5.Text = LTrim(TxtPrenom_cours5.Text)
        ' Fonction .net TrimStart
        TxtNom_cours5.Text = TxtNom_cours5.Text.TrimStart()
    End Sub

    Private Sub CmdEnleverBlancFin_cours5_Click(sender As Object, e As EventArgs) Handles CmdEnleverBlancFin_cours5.Click
        ' Fonction VB Rtrim (Right Trim)
        TxtPrenom_cours5.Text = RTrim(TxtPrenom_cours5.Text)
        ' Fonction .net TrimEnd
        TxtNom_cours5.Text = TxtNom_cours5.Text.TrimEnd()
    End Sub

    Private Sub CmdEnleverBlancDebutFin_cours5_Click(sender As Object, e As EventArgs) Handles CmdEnleverBlancDebutFin_cours5.Click
        ' Fonction VB Trim (Enlève les espaces au début et à la fin de la chaine)
        TxtPrenom_cours5.Text = Trim(TxtPrenom_cours5.Text)
        ' Fonction .net Trim
        TxtNom_cours5.Text = TxtNom_cours5.Text.Trim()
    End Sub

    Private Sub CmdEnleverTousLesBlancs_cours5_Click(sender As Object, e As EventArgs) Handles CmdEnleverTousLesBlancs_cours5.Click
        ' Fonction VB REPLACE
        TxtPrenom_cours5.Text = Replace(TxtPrenom_cours5.Text, " ", "")
        ' Fonction .NET
        TxtNom_cours5.Text = TxtNom_cours5.Text.Replace(" ", "")
    End Sub

    Private Sub CmdNombreCaracteres_cours5_Click(sender As Object, e As EventArgs) Handles CmdNombreCaracteres_cours5.Click
        ' Fonction VB pour obtenir le nombre de caractères d'une chaine LEN
        MsgBox("Nombre de caractères dans le prénom: " & Len(TxtPrenom_cours5.Text))
        ' Fonction .NET propriété LENGTH
        MsgBox("Nombre de caractères dans le nom: " & TxtNom_cours5.Text.Length)
    End Sub

    Private Sub CmdCompterA_cours5_Click(sender As Object, e As EventArgs) Handles CmdCompterA_cours5.Click
        Dim a As Integer
        Dim cptA As Integer = 0
        For i = 0 To TxtPrenom_cours5.Text.Length - 1
            If TxtPrenom_cours5.Text(i) = "A" Or TxtPrenom_cours5.Text(i) = "a" Then
                cptA += 1
            End If
        Next
        MsgBox("Nombre de A: " & cptA)
    End Sub

    Private Sub Cmd3Premiers_cours5_Click(sender As Object, e As EventArgs) Handles Cmd3Premiers_cours5.Click
        ' Fonction VB LEFT me permet d'obtenir les premiers caractères d'une chaine
        MsgBox(Microsoft.VisualBasic.Left(TxtPrenom_cours5.Text, 3))
        ' Fonction .NET (SubString
        MsgBox(TxtNom_cours5.Text.Substring(0, 3))
    End Sub

    Private Sub Cmd3Derniers_cours5_Click(sender As Object, e As EventArgs) Handles Cmd3Derniers_cours5.Click
        ' Fonction VB RIGHT me permet d'obtenir les derniers caractères d'une chaine
        MsgBox(Microsoft.VisualBasic.Right(TxtPrenom_cours5.Text, 3))
        ' Fonction .NET (SubString
        MsgBox(TxtNom_cours5.Text.Substring(TxtNom_cours5.Text.Length - 3, 3))
    End Sub

    Private Sub CmdObtenirSousChaine_cours5_Click(sender As Object, e As EventArgs) Handles CmdObtenirSousChaine_cours5.Click
        ' Fonction VB MID me permet d'obtenir les derniers caractères d'une chaine
        MsgBox(Microsoft.VisualBasic.Mid(TxtPrenom_cours5.Text, 3, 3))
        ' Fonction .NET (SubString
        MsgBox(TxtNom_cours5.Text.Substring(3, 2))
    End Sub

    Private Sub CmdTableauMots_Click(sender As Object, e As EventArgs) Handles CmdTableauMots.Click
        ' Dim mots() As String = Split(TxtTexte_cours5.Text, " ")
        ' For Each mot As String In mots
        ' MsgBox(mot)
        ' Next

        Dim delimiteur() As String = {" ", ".", ",", ";", Chr(13)}
        Dim mots() As String = TxtTexte_cours5.Text.Split(delimiteur.ToString())
        For Each mot As String In mots
            MsgBox(mot)
        Next
    End Sub

    Private Sub CmdDenombrerLettre_Click(sender As Object, e As EventArgs) Handles CmdDenombrerLettre.Click
        Dim Lettres(26)
        Dim texte As String = TxtTexte_cours5.Text.ToUpper()
        Dim i As Integer
        For i = 0 To texte.Length - 1
            If Asc(texte(i)) - 64 > 0 And Asc(texte(i)) - 64 < 27 Then
                Lettres(Asc(texte(i)) - 64) += 1
            End If
        Next
        For i = 0 To Lettres.GetUpperBound(0)
            MsgBox(Chr(i + 64) & " -->" & Lettres(i))
        Next
    End Sub


    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '------------------------------------------------ FONCTIONS VB #2 COURS 5 ----------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------
    Private Sub CmdDateJour_cours5_Click(sender As Object, e As EventArgs) Handles CmdDateJour_cours5.Click
        ' Fonction VB Today
        MsgBox(Today)
        ' .NET DateTime
        MsgBox(DateTime.Now.ToShortDateString)
        MsgBox(DateTime.Now)
    End Sub

    Private Sub CmdAnneeCourante_cours5_Click(sender As Object, e As EventArgs) Handles CmdAnneeCourante_cours5.Click
        Dim d1 As Date
        d1 = Today
        ' Fonction VB
        MsgBox(Year(Today))

        Dim d2 As Date
        d2 = DateTime.Now
        MsgBox(d2.Year)
    End Sub

    Private Sub CmdNoel_cours5_Click(sender As Object, e As EventArgs) Handles CmdNoel_cours5.Click
        Dim d1 As Date = Today
        MsgBox(DateDiff(DateInterval.Day, d1, #2023-12-25#))
        MsgBox(DateDiff(DateInterval.Hour, d1, #2023-12-25#))
        MsgBox(DateDiff(DateInterval.Second, d1, #2023-12-25#))
    End Sub

    Private Sub CmdDateDemain_cours5_Click(sender As Object, e As EventArgs) Handles CmdDateDemain_cours5.Click
        Dim d1 As Date = Today
        Dim d2 As Date
        d1 = (DateAdd(DateInterval.Day, 1, d1))
        MsgBox(d1)

        d2 = DateTime.Now
        d2 = d2.AddDays(1)
        MsgBox(d2)
    End Sub

    Private Sub CmdDateMois_cours5_Click(sender As Object, e As EventArgs) Handles CmdDateMois_cours5.Click
        Dim d1 As Date = Today
        MsgBox(Month(d1))
        MsgBox(MonthName(Month(d1)))

        'Fonction Format (très très très puissant selon Bruno!!!)
        ' Format()
    End Sub

    Private Sub CmdHeureJour_cours5_Click(sender As Object, e As EventArgs) Handles CmdHeureJour_cours5.Click
        ' VB
        MsgBox(TimeOfDay)

        ' .NET
        MsgBox(DateTime.Now.ToShortTimeString)
    End Sub

    Dim hasard As New Random()

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Me.BackColor = Color.FromArgb(hasard.Next(256), hasard.Next(256), hasard.Next(256))
        LblHeure.Text = TimeOfDay
        Dim dateNow As Date = Date.Now
        Dim dateFrench As String = dateNow.ToString("dddd, dd MMMM yyyy HH:mm:ss")
        LblHeure.Text = dateFrench
    End Sub

End Class
