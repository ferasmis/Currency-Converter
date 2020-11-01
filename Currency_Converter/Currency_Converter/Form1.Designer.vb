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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAmountDollar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.picPounds = New System.Windows.Forms.PictureBox()
        Me.picEuros = New System.Windows.Forms.PictureBox()
        Me.picYen = New System.Windows.Forms.PictureBox()
        Me.lblPounds = New System.Windows.Forms.Label()
        Me.lblEuros = New System.Windows.Forms.Label()
        Me.lblYen = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picPounds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEuros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picYen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(386, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Converting U.S dollar amounts to pounds, euros, and yen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dollar:"
        '
        'txtAmountDollar
        '
        Me.txtAmountDollar.Location = New System.Drawing.Point(173, 79)
        Me.txtAmountDollar.Name = "txtAmountDollar"
        Me.txtAmountDollar.Size = New System.Drawing.Size(154, 26)
        Me.txtAmountDollar.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Pounds:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(182, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Euros:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(323, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Yen:"
        '
        'picPounds
        '
        Me.picPounds.Image = Global.Currency_Converter.My.Resources.Resources.pound_symbol
        Me.picPounds.Location = New System.Drawing.Point(26, 142)
        Me.picPounds.Name = "picPounds"
        Me.picPounds.Size = New System.Drawing.Size(100, 106)
        Me.picPounds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPounds.TabIndex = 6
        Me.picPounds.TabStop = False
        '
        'picEuros
        '
        Me.picEuros.Image = Global.Currency_Converter.My.Resources.Resources.euro_symbol
        Me.picEuros.Location = New System.Drawing.Point(162, 142)
        Me.picEuros.Name = "picEuros"
        Me.picEuros.Size = New System.Drawing.Size(100, 106)
        Me.picEuros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picEuros.TabIndex = 7
        Me.picEuros.TabStop = False
        '
        'picYen
        '
        Me.picYen.Image = Global.Currency_Converter.My.Resources.Resources.yen_symbol
        Me.picYen.Location = New System.Drawing.Point(292, 142)
        Me.picYen.Name = "picYen"
        Me.picYen.Size = New System.Drawing.Size(100, 106)
        Me.picYen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picYen.TabIndex = 8
        Me.picYen.TabStop = False
        '
        'lblPounds
        '
        Me.lblPounds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPounds.Location = New System.Drawing.Point(27, 264)
        Me.lblPounds.Name = "lblPounds"
        Me.lblPounds.Size = New System.Drawing.Size(99, 33)
        Me.lblPounds.TabIndex = 9
        Me.lblPounds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEuros
        '
        Me.lblEuros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEuros.Location = New System.Drawing.Point(162, 264)
        Me.lblEuros.Name = "lblEuros"
        Me.lblEuros.Size = New System.Drawing.Size(99, 33)
        Me.lblEuros.TabIndex = 10
        Me.lblEuros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblYen
        '
        Me.lblYen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYen.Location = New System.Drawing.Point(293, 264)
        Me.lblYen.Name = "lblYen"
        Me.lblYen.Size = New System.Drawing.Size(99, 33)
        Me.lblYen.TabIndex = 11
        Me.lblYen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(22, 319)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(112, 27)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "Calculate All"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(162, 319)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 27)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(292, 319)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 27)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 383)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblYen)
        Me.Controls.Add(Me.lblEuros)
        Me.Controls.Add(Me.lblPounds)
        Me.Controls.Add(Me.picYen)
        Me.Controls.Add(Me.picEuros)
        Me.Controls.Add(Me.picPounds)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAmountDollar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Currency Converter"
        CType(Me.picPounds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEuros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picYen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAmountDollar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents picPounds As PictureBox
    Friend WithEvents picEuros As PictureBox
    Friend WithEvents picYen As PictureBox
    Friend WithEvents lblPounds As Label
    Friend WithEvents lblEuros As Label
    Friend WithEvents lblYen As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
