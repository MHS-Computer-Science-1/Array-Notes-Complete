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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        PictureBox1 = New PictureBox()
        Button4 = New Button()
        ListBox1 = New ListBox()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(14, 14)
        Button1.Margin = New Padding(4, 3, 4, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(177, 27)
        Button1.TabIndex = 0
        Button1.Text = "What is an Array?"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Black
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(14, 182)
        Button2.Margin = New Padding(4, 3, 4, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(177, 27)
        Button2.TabIndex = 2
        Button2.Text = "2D Arrays"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Black
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(14, 148)
        Button3.Margin = New Padding(4, 3, 4, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(177, 27)
        Button3.TabIndex = 4
        Button3.Text = "Bubble Sort"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(676, 49)
        PictureBox1.Margin = New Padding(4, 3, 4, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(348, 126)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(679, 180)
        Button4.Margin = New Padding(4, 3, 4, 3)
        Button4.Name = "Button4"
        Button4.Size = New Size(88, 27)
        Button4.TabIndex = 6
        Button4.Text = "Restart"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.BackColor = Color.Black
        ListBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ListBox1.ForeColor = Color.White
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 21
        ListBox1.Location = New Point(212, 14)
        ListBox1.Margin = New Padding(4, 3, 4, 3)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(430, 214)
        ListBox1.TabIndex = 7
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Black
        Button5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.ForeColor = Color.White
        Button5.Location = New Point(14, 47)
        Button5.Margin = New Padding(4, 3, 4, 3)
        Button5.Name = "Button5"
        Button5.Size = New Size(177, 27)
        Button5.TabIndex = 8
        Button5.Text = "Access Array Elements"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Black
        Button6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.ForeColor = Color.White
        Button6.Location = New Point(14, 81)
        Button6.Margin = New Padding(4, 3, 4, 3)
        Button6.Name = "Button6"
        Button6.Size = New Size(177, 27)
        Button6.TabIndex = 9
        Button6.Text = "Looping through the Array"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Black
        Button7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button7.ForeColor = Color.White
        Button7.Location = New Point(13, 114)
        Button7.Margin = New Padding(4, 3, 4, 3)
        Button7.Name = "Button7"
        Button7.Size = New Size(177, 27)
        Button7.TabIndex = 10
        Button7.Text = "Linear Search"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkTurquoise
        ClientSize = New Size(655, 263)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(ListBox1)
        Controls.Add(Button4)
        Controls.Add(PictureBox1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        Text = "Array Notes"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class
