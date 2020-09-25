<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Question = New System.Windows.Forms.TextBox()
        Me.Answer = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Question
        '
        Me.Question.BackColor = System.Drawing.Color.White
        Me.Question.Location = New System.Drawing.Point(68, 290)
        Me.Question.Name = "Question"
        Me.Question.Size = New System.Drawing.Size(253, 20)
        Me.Question.TabIndex = 0
        Me.Question.Text = "Ask a question"
        Me.Question.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Answer
        '
        Me.Answer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Answer.BackColor = System.Drawing.Color.Transparent
        Me.Answer.ForeColor = System.Drawing.Color.White
        Me.Answer.Location = New System.Drawing.Point(120, 128)
        Me.Answer.Name = "Answer"
        Me.Answer.Size = New System.Drawing.Size(145, 25)
        Me.Answer.TabIndex = 1
        Me.Answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Font = New System.Drawing.Font("Adobe Arabic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(123, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 28)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Reveal the Unknown"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(385, 313)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Answer)
        Me.Controls.Add(Me.Question)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Question As TextBox
    Friend WithEvents Answer As Label
    Friend WithEvents Button1 As Button
End Class
