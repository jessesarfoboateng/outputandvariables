<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        btnGo = New Button()
        btnVariables = New Button()
        btnDataTypes = New Button()
        SuspendLayout()
        ' 
        ' btnGo
        ' 
        btnGo.Location = New Point(74, 66)
        btnGo.Name = "btnGo"
        btnGo.Size = New Size(275, 158)
        btnGo.TabIndex = 0
        btnGo.Text = "Go"
        btnGo.UseVisualStyleBackColor = True
        ' 
        ' btnVariables
        ' 
        btnVariables.Location = New Point(427, 76)
        btnVariables.Name = "btnVariables"
        btnVariables.Size = New Size(269, 138)
        btnVariables.TabIndex = 1
        btnVariables.Text = "Variable Demonstration"
        btnVariables.UseVisualStyleBackColor = True
        ' 
        ' btnDataTypes
        ' 
        btnDataTypes.Location = New Point(74, 271)
        btnDataTypes.Name = "btnDataTypes"
        btnDataTypes.Size = New Size(275, 153)
        btnDataTypes.TabIndex = 2
        btnDataTypes.Text = "Data Types"
        btnDataTypes.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnDataTypes)
        Controls.Add(btnVariables)
        Controls.Add(btnGo)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnGo As Button
    Friend WithEvents btnVariables As Button
    Friend WithEvents btnDataTypes As Button

End Class
