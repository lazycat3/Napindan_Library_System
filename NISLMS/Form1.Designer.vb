<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Panel1 = New Panel()
        btnshow = New CheckBox()
        cancel = New Button()
        login = New Button()
        password = New TextBox()
        username = New TextBox()
        Label1 = New Label()
        Panel3 = New Panel()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoSize = True
        Panel1.BackColor = Color.Yellow
        Panel1.Controls.Add(btnshow)
        Panel1.Controls.Add(cancel)
        Panel1.Controls.Add(login)
        Panel1.Controls.Add(password)
        Panel1.Controls.Add(username)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(27, 30)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(580, 300)
        Panel1.TabIndex = 0
        ' 
        ' btnshow
        ' 
        btnshow.Appearance = Appearance.Button
        btnshow.AutoSize = True
        btnshow.BackColor = Color.White
        btnshow.BackgroundImage = My.Resources.Resources.pass_hide
        btnshow.BackgroundImageLayout = ImageLayout.Zoom
        btnshow.FlatAppearance.BorderSize = 0
        btnshow.FlatStyle = FlatStyle.Flat
        btnshow.Location = New Point(383, 180)
        btnshow.Name = "btnshow"
        btnshow.Size = New Size(23, 25)
        btnshow.TabIndex = 7
        btnshow.Text = "  "
        btnshow.UseVisualStyleBackColor = False
        ' 
        ' cancel
        ' 
        cancel.BackColor = Color.FromArgb(CByte(33), CByte(158), CByte(188))
        cancel.FlatAppearance.BorderSize = 0
        cancel.FlatStyle = FlatStyle.Flat
        cancel.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cancel.Location = New Point(293, 227)
        cancel.Name = "cancel"
        cancel.Size = New Size(118, 28)
        cancel.TabIndex = 6
        cancel.Text = "Cancel"
        cancel.UseVisualStyleBackColor = False
        ' 
        ' login
        ' 
        login.BackColor = Color.FromArgb(CByte(33), CByte(158), CByte(188))
        login.FlatAppearance.BorderSize = 0
        login.FlatStyle = FlatStyle.Flat
        login.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        login.Location = New Point(158, 227)
        login.Name = "login"
        login.Size = New Size(118, 28)
        login.TabIndex = 5
        login.Text = "Login"
        login.UseVisualStyleBackColor = False
        ' 
        ' password
        ' 
        password.Font = New Font("Arial Narrow", 12F)
        password.Location = New Point(158, 176)
        password.Multiline = True
        password.Name = "password"
        password.PasswordChar = "*"c
        password.PlaceholderText = "Password"
        password.Size = New Size(253, 33)
        password.TabIndex = 4
        ' 
        ' username
        ' 
        username.Font = New Font("Arial Narrow", 12F)
        username.Location = New Point(158, 137)
        username.Multiline = True
        username.Name = "username"
        username.PlaceholderText = "Username"
        username.Size = New Size(253, 33)
        username.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(134, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(319, 109)
        Label1.TabIndex = 2
        Label1.Text = "Napindan Integrated School Library Management System"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel3
        ' 
        Panel3.BackgroundImage = My.Resources.Resources.deped1
        Panel3.BackgroundImageLayout = ImageLayout.Zoom
        Panel3.Location = New Point(464, 10)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(100, 100)
        Panel3.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = My.Resources.Resources.Napindan_logo
        Panel2.BackgroundImageLayout = ImageLayout.Zoom
        Panel2.Location = New Point(18, 10)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(100, 100)
        Panel2.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Green
        ClientSize = New Size(634, 361)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form1"
        Text = "  "
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cancel As Button
    Friend WithEvents login As Button
    Friend WithEvents password As TextBox
    Friend WithEvents username As TextBox
    Friend WithEvents btnshow As CheckBox

End Class
