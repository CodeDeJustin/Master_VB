<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Grp_Formulaire2_Cours2 = New System.Windows.Forms.GroupBox()
        Me.CmdFermer = New System.Windows.Forms.Button()
        Me.Grp_Formulaire2_Cours2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grp_Formulaire2_Cours2
        '
        Me.Grp_Formulaire2_Cours2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Grp_Formulaire2_Cours2.Controls.Add(Me.CmdFermer)
        Me.Grp_Formulaire2_Cours2.Location = New System.Drawing.Point(24, 23)
        Me.Grp_Formulaire2_Cours2.Name = "Grp_Formulaire2_Cours2"
        Me.Grp_Formulaire2_Cours2.Size = New System.Drawing.Size(343, 60)
        Me.Grp_Formulaire2_Cours2.TabIndex = 7
        Me.Grp_Formulaire2_Cours2.TabStop = False
        Me.Grp_Formulaire2_Cours2.Text = "Formulaire2_Cours2 (lien avec formulaire 1)"
        '
        'CmdFermer
        '
        Me.CmdFermer.Location = New System.Drawing.Point(98, 24)
        Me.CmdFermer.Name = "CmdFermer"
        Me.CmdFermer.Size = New System.Drawing.Size(120, 24)
        Me.CmdFermer.TabIndex = 1
        Me.CmdFermer.Text = "Fermer"
        Me.CmdFermer.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(404, 113)
        Me.Controls.Add(Me.Grp_Formulaire2_Cours2)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Grp_Formulaire2_Cours2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Grp_Formulaire2_Cours2 As GroupBox
    Friend WithEvents CmdFermer As Button
End Class
