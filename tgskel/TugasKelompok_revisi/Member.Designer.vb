<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Member
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
        Me.components = New System.ComponentModel.Container()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.submit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fntxtbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lntxtbox = New System.Windows.Forms.TextBox()
        Me.passtxtbox = New System.Windows.Forms.TextBox()
        Me.pass1txtbox = New System.Windows.Forms.TextBox()
        Me.pctxtbox = New System.Windows.Forms.TextBox()
        Me.citycbbox = New System.Windows.Forms.ComboBox()
        Me.pntxtbox = New System.Windows.Forms.TextBox()
        Me.emailtxtbox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 10
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'submit
        '
        Me.submit.BackColor = System.Drawing.Color.PeachPuff
        Me.submit.FlatAppearance.BorderSize = 0
        Me.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.submit.Location = New System.Drawing.Point(836, 559)
        Me.submit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(116, 41)
        Me.submit.TabIndex = 0
        Me.submit.Text = "Submit"
        Me.submit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(518, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Register Member"
        '
        'fntxtbox
        '
        Me.fntxtbox.BackColor = System.Drawing.Color.White
        Me.fntxtbox.Location = New System.Drawing.Point(579, 95)
        Me.fntxtbox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fntxtbox.Multiline = True
        Me.fntxtbox.Name = "fntxtbox"
        Me.fntxtbox.Size = New System.Drawing.Size(173, 34)
        Me.fntxtbox.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(428, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 29)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Full Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(432, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 29)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Password :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(342, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 29)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Confrim Password :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(450, 319)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 29)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Address :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(575, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 21)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "First Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(777, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 21)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Last Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(376, 395)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(188, 29)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Phone Number :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(478, 472)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 29)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Email :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(576, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 21)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Street Address"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(576, 351)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 21)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "City"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(576, 431)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(132, 21)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Phone Number"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(777, 355)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 21)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "PostCode"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PeachPuff
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(12, 18)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 28)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lntxtbox
        '
        Me.lntxtbox.BackColor = System.Drawing.Color.White
        Me.lntxtbox.Location = New System.Drawing.Point(779, 95)
        Me.lntxtbox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lntxtbox.Multiline = True
        Me.lntxtbox.Name = "lntxtbox"
        Me.lntxtbox.Size = New System.Drawing.Size(173, 34)
        Me.lntxtbox.TabIndex = 44
        '
        'passtxtbox
        '
        Me.passtxtbox.BackColor = System.Drawing.Color.White
        Me.passtxtbox.Location = New System.Drawing.Point(579, 169)
        Me.passtxtbox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.passtxtbox.Multiline = True
        Me.passtxtbox.Name = "passtxtbox"
        Me.passtxtbox.Size = New System.Drawing.Size(373, 34)
        Me.passtxtbox.TabIndex = 45
        '
        'pass1txtbox
        '
        Me.pass1txtbox.BackColor = System.Drawing.Color.White
        Me.pass1txtbox.Location = New System.Drawing.Point(579, 234)
        Me.pass1txtbox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pass1txtbox.Multiline = True
        Me.pass1txtbox.Name = "pass1txtbox"
        Me.pass1txtbox.Size = New System.Drawing.Size(373, 34)
        Me.pass1txtbox.TabIndex = 46
        '
        'pctxtbox
        '
        Me.pctxtbox.BackColor = System.Drawing.Color.White
        Me.pctxtbox.Location = New System.Drawing.Point(779, 319)
        Me.pctxtbox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pctxtbox.Multiline = True
        Me.pctxtbox.Name = "pctxtbox"
        Me.pctxtbox.Size = New System.Drawing.Size(173, 34)
        Me.pctxtbox.TabIndex = 47
        '
        'citycbbox
        '
        Me.citycbbox.FormattingEnabled = True
        Me.citycbbox.Location = New System.Drawing.Point(580, 324)
        Me.citycbbox.Name = "citycbbox"
        Me.citycbbox.Size = New System.Drawing.Size(172, 24)
        Me.citycbbox.TabIndex = 48
        '
        'pntxtbox
        '
        Me.pntxtbox.BackColor = System.Drawing.Color.White
        Me.pntxtbox.Location = New System.Drawing.Point(580, 395)
        Me.pntxtbox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pntxtbox.Multiline = True
        Me.pntxtbox.Name = "pntxtbox"
        Me.pntxtbox.Size = New System.Drawing.Size(373, 34)
        Me.pntxtbox.TabIndex = 49
        '
        'emailtxtbox
        '
        Me.emailtxtbox.BackColor = System.Drawing.Color.White
        Me.emailtxtbox.Location = New System.Drawing.Point(580, 472)
        Me.emailtxtbox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.emailtxtbox.Multiline = True
        Me.emailtxtbox.Name = "emailtxtbox"
        Me.emailtxtbox.Size = New System.Drawing.Size(373, 34)
        Me.emailtxtbox.TabIndex = 50
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TugasKelompok.My.Resources.Resources.m5
        Me.PictureBox1.Location = New System.Drawing.Point(978, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(324, 639)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.TugasKelompok.My.Resources.Resources.m3
        Me.PictureBox2.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(324, 639)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 43
        Me.PictureBox2.TabStop = False
        '
        'Member
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(1303, 641)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.emailtxtbox)
        Me.Controls.Add(Me.pntxtbox)
        Me.Controls.Add(Me.citycbbox)
        Me.Controls.Add(Me.pctxtbox)
        Me.Controls.Add(Me.pass1txtbox)
        Me.Controls.Add(Me.passtxtbox)
        Me.Controls.Add(Me.lntxtbox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.fntxtbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Member"
        Me.Text = "Member"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents submit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents fntxtbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lntxtbox As TextBox
    Friend WithEvents passtxtbox As TextBox
    Friend WithEvents pass1txtbox As TextBox
    Friend WithEvents pctxtbox As TextBox
    Friend WithEvents citycbbox As ComboBox
    Friend WithEvents pntxtbox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents emailtxtbox As TextBox
End Class
