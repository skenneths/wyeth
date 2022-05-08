<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
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
        Me.signout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.studentbtn = New System.Windows.Forms.Button()
        Me.teacherbtn = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'signout
        '
        Me.signout.BackColor = System.Drawing.Color.White
        Me.signout.Font = New System.Drawing.Font("Microsoft New Tai Lue", 8.25!)
        Me.signout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.signout.Location = New System.Drawing.Point(286, 293)
        Me.signout.Name = "signout"
        Me.signout.Size = New System.Drawing.Size(75, 23)
        Me.signout.TabIndex = 1
        Me.signout.Text = "Sign Out"
        Me.signout.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(160, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please Select:"
        '
        'studentbtn
        '
        Me.studentbtn.BackColor = System.Drawing.Color.White
        Me.studentbtn.BackgroundImage = Global.Attendance.My.Resources.Resources.student
        Me.studentbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.studentbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.studentbtn.Font = New System.Drawing.Font("Microsoft New Tai Lue", 8.25!)
        Me.studentbtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.studentbtn.Location = New System.Drawing.Point(234, 122)
        Me.studentbtn.Name = "studentbtn"
        Me.studentbtn.Size = New System.Drawing.Size(127, 149)
        Me.studentbtn.TabIndex = 0
        Me.studentbtn.Text = "Students"
        Me.studentbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.studentbtn.UseVisualStyleBackColor = False
        '
        'teacherbtn
        '
        Me.teacherbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.teacherbtn.BackgroundImage = Global.Attendance.My.Resources.Resources.teacher
        Me.teacherbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.teacherbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.teacherbtn.Font = New System.Drawing.Font("Microsoft New Tai Lue", 8.25!)
        Me.teacherbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.teacherbtn.Location = New System.Drawing.Point(90, 122)
        Me.teacherbtn.Name = "teacherbtn"
        Me.teacherbtn.Size = New System.Drawing.Size(127, 149)
        Me.teacherbtn.TabIndex = 0
        Me.teacherbtn.Text = "Teachers"
        Me.teacherbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.teacherbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.teacherbtn.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(301, 337)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(60, 15)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Need Help?"
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(438, 400)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.signout)
        Me.Controls.Add(Me.studentbtn)
        Me.Controls.Add(Me.teacherbtn)
        Me.Name = "admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome Admin!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents teacherbtn As Button
    Friend WithEvents studentbtn As Button
    Friend WithEvents signout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
