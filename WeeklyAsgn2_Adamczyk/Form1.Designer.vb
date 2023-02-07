<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBurger
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.btn4 = New System.Windows.Forms.Button()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(239, 24)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(314, 34)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Farm Burger Specials"
        '
        'pic1
        '
        Me.pic1.Location = New System.Drawing.Point(115, 61)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(217, 195)
        Me.pic1.TabIndex = 1
        Me.pic1.TabStop = False
        '
        'pic2
        '
        Me.pic2.Location = New System.Drawing.Point(467, 61)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(197, 195)
        Me.pic2.TabIndex = 2
        Me.pic2.TabStop = False
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(150, 276)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(112, 23)
        Me.btn1.TabIndex = 3
        Me.btn1.Text = " Prime Beef"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(341, 276)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(107, 23)
        Me.btn2.TabIndex = 4
        Me.btn2.Text = "Select Meal"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(553, 272)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(88, 27)
        Me.btn3.TabIndex = 5
        Me.btn3.Text = "Veggie"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(216, 310)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(360, 18)
        Me.lbl2.TabIndex = 6
        Me.lbl2.Text = "Choose a burger and then click the Select Meal button"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(300, 343)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(172, 18)
        Me.lbl3.TabIndex = 7
        Me.lbl3.Text = "Enjoy your burger special"
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(331, 386)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(128, 27)
        Me.btn4.TabIndex = 8
        Me.btn4.Text = "Exit Window"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'frmBurger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmBurger"
        Me.Text = "Burger Specials"
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents pic1 As PictureBox
    Friend WithEvents pic2 As PictureBox
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents btn4 As Button
End Class
