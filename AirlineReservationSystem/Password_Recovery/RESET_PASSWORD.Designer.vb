﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RESET_PASSWORD
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
        Me.Title = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Ltitle = New System.Windows.Forms.Label()
        Me.Pdesign = New System.Windows.Forms.Panel()
        Me.Lbanner = New System.Windows.Forms.Label()
        Me.MainForm = New System.Windows.Forms.Panel()
        Me.Bsubmit = New System.Windows.Forms.Button()
        Me.LMSG1 = New System.Windows.Forms.Label()
        Me.TPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TConPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.LMSG2 = New System.Windows.Forms.Label()
        Me.MenuBar = New System.Windows.Forms.Panel()
        Me.Title.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pdesign.SuspendLayout()
        Me.MainForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Title.Controls.Add(Me.PictureBox1)
        Me.Title.Controls.Add(Me.Ltitle)
        Me.Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Title.Location = New System.Drawing.Point(0, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(1366, 40)
        Me.Title.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AirlineReservationSystem.My.Resources.Resources.flight1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Ltitle
        '
        Me.Ltitle.AutoSize = True
        Me.Ltitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ltitle.Location = New System.Drawing.Point(500, 5)
        Me.Ltitle.Name = "Ltitle"
        Me.Ltitle.Size = New System.Drawing.Size(366, 31)
        Me.Ltitle.TabIndex = 0
        Me.Ltitle.Text = "Airline Reservation System"
        '
        'Pdesign
        '
        Me.Pdesign.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Pdesign.BackgroundImage = Global.AirlineReservationSystem.My.Resources.Resources._3
        Me.Pdesign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pdesign.Controls.Add(Me.Lbanner)
        Me.Pdesign.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pdesign.Location = New System.Drawing.Point(0, 105)
        Me.Pdesign.Name = "Pdesign"
        Me.Pdesign.Size = New System.Drawing.Size(1366, 358)
        Me.Pdesign.TabIndex = 0
        '
        'Lbanner
        '
        Me.Lbanner.AutoSize = True
        Me.Lbanner.BackColor = System.Drawing.Color.Transparent
        Me.Lbanner.Font = New System.Drawing.Font("Calibri", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbanner.ForeColor = System.Drawing.Color.Magenta
        Me.Lbanner.Location = New System.Drawing.Point(33, 105)
        Me.Lbanner.Name = "Lbanner"
        Me.Lbanner.Size = New System.Drawing.Size(799, 41)
        Me.Lbanner.TabIndex = 0
        Me.Lbanner.Text = "Hi User, Set Your New password and Your account access"
        '
        'MainForm
        '
        Me.MainForm.BackColor = System.Drawing.SystemColors.Menu
        Me.MainForm.Controls.Add(Me.Bsubmit)
        Me.MainForm.Controls.Add(Me.LMSG1)
        Me.MainForm.Controls.Add(Me.TPassword)
        Me.MainForm.Controls.Add(Me.TConPassword)
        Me.MainForm.Controls.Add(Me.LMSG2)
        Me.MainForm.Location = New System.Drawing.Point(201, 311)
        Me.MainForm.Name = "MainForm"
        Me.MainForm.Size = New System.Drawing.Size(964, 345)
        Me.MainForm.TabIndex = 0
        '
        'Bsubmit
        '
        Me.Bsubmit.BackgroundImage = Global.AirlineReservationSystem.My.Resources.Resources._12
        Me.Bsubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bsubmit.FlatAppearance.BorderSize = 0
        Me.Bsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bsubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bsubmit.ForeColor = System.Drawing.Color.Transparent
        Me.Bsubmit.Location = New System.Drawing.Point(645, 137)
        Me.Bsubmit.Name = "Bsubmit"
        Me.Bsubmit.Size = New System.Drawing.Size(241, 76)
        Me.Bsubmit.TabIndex = 3
        Me.Bsubmit.Text = "Submit"
        Me.Bsubmit.UseVisualStyleBackColor = True
        '
        'LMSG1
        '
        Me.LMSG1.AutoSize = True
        Me.LMSG1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMSG1.Location = New System.Drawing.Point(76, 82)
        Me.LMSG1.Name = "LMSG1"
        Me.LMSG1.Size = New System.Drawing.Size(335, 26)
        Me.LMSG1.TabIndex = 0
        Me.LMSG1.Text = "Set Your Account New Password"
        '
        'TPassword
        '
        Me.TPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TPassword.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.TPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TPassword.HintForeColor = System.Drawing.Color.Empty
        Me.TPassword.HintText = ""
        Me.TPassword.isPassword = False
        Me.TPassword.LineFocusedColor = System.Drawing.Color.Blue
        Me.TPassword.LineIdleColor = System.Drawing.Color.Gray
        Me.TPassword.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TPassword.LineThickness = 4
        Me.TPassword.Location = New System.Drawing.Point(79, 150)
        Me.TPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.TPassword.Name = "TPassword"
        Me.TPassword.Size = New System.Drawing.Size(255, 48)
        Me.TPassword.TabIndex = 2
        Me.TPassword.Text = "Enter New Password"
        Me.TPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TConPassword
        '
        Me.TConPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TConPassword.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.TConPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TConPassword.HintForeColor = System.Drawing.Color.Empty
        Me.TConPassword.HintText = ""
        Me.TConPassword.isPassword = False
        Me.TConPassword.LineFocusedColor = System.Drawing.Color.Blue
        Me.TConPassword.LineIdleColor = System.Drawing.Color.Gray
        Me.TConPassword.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TConPassword.LineThickness = 4
        Me.TConPassword.Location = New System.Drawing.Point(362, 151)
        Me.TConPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.TConPassword.Name = "TConPassword"
        Me.TConPassword.Size = New System.Drawing.Size(255, 48)
        Me.TConPassword.TabIndex = 2
        Me.TConPassword.Text = "Re-Type Password"
        Me.TConPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'LMSG2
        '
        Me.LMSG2.AutoSize = True
        Me.LMSG2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMSG2.ForeColor = System.Drawing.Color.Red
        Me.LMSG2.Location = New System.Drawing.Point(76, 247)
        Me.LMSG2.Name = "LMSG2"
        Me.LMSG2.Size = New System.Drawing.Size(0, 20)
        Me.LMSG2.TabIndex = 0
        '
        'MenuBar
        '
        Me.MenuBar.BackColor = System.Drawing.Color.DarkRed
        Me.MenuBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuBar.Location = New System.Drawing.Point(0, 40)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(1366, 65)
        Me.MenuBar.TabIndex = 1
        '
        'RESET_PASSWORD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.MainForm)
        Me.Controls.Add(Me.Pdesign)
        Me.Controls.Add(Me.MenuBar)
        Me.Controls.Add(Me.Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RESET_PASSWORD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RESET_PASSWORD"
        Me.Title.ResumeLayout(False)
        Me.Title.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pdesign.ResumeLayout(False)
        Me.Pdesign.PerformLayout()
        Me.MainForm.ResumeLayout(False)
        Me.MainForm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Title As System.Windows.Forms.Panel
    Friend WithEvents Pdesign As System.Windows.Forms.Panel
    Friend WithEvents MainForm As System.Windows.Forms.Panel
    Friend WithEvents MenuBar As System.Windows.Forms.Panel
    Friend WithEvents TConPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents LMSG2 As System.Windows.Forms.Label
    Friend WithEvents Ltitle As System.Windows.Forms.Label
    Friend WithEvents Lbanner As System.Windows.Forms.Label
    Friend WithEvents LMSG1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Bsubmit As System.Windows.Forms.Button
End Class