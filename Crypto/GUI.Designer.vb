<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxStringToEncrypt = New System.Windows.Forms.TextBox()
        Me.TextBoxPassPhrase = New System.Windows.Forms.TextBox()
        Me.TextBoxSalt = New System.Windows.Forms.TextBox()
        Me.TextBoxInitVector = New System.Windows.Forms.TextBox()
        Me.TextBoxIterations = New System.Windows.Forms.TextBox()
        Me.TextBoxEncrypted = New System.Windows.Forms.TextBox()
        Me.TextBoxDecrypted = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonCryption = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "String to Encrypt"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pass Phrase"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Salt"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Init Vector"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Iterations"
        '
        'TextBoxStringToEncrypt
        '
        Me.TextBoxStringToEncrypt.Location = New System.Drawing.Point(112, 142)
        Me.TextBoxStringToEncrypt.Name = "TextBoxStringToEncrypt"
        Me.TextBoxStringToEncrypt.Size = New System.Drawing.Size(134, 20)
        Me.TextBoxStringToEncrypt.TabIndex = 4
        '
        'TextBoxPassPhrase
        '
        Me.TextBoxPassPhrase.Location = New System.Drawing.Point(112, 12)
        Me.TextBoxPassPhrase.Name = "TextBoxPassPhrase"
        Me.TextBoxPassPhrase.Size = New System.Drawing.Size(134, 20)
        Me.TextBoxPassPhrase.TabIndex = 0
        '
        'TextBoxSalt
        '
        Me.TextBoxSalt.Location = New System.Drawing.Point(112, 38)
        Me.TextBoxSalt.Name = "TextBoxSalt"
        Me.TextBoxSalt.Size = New System.Drawing.Size(134, 20)
        Me.TextBoxSalt.TabIndex = 1
        '
        'TextBoxInitVector
        '
        Me.TextBoxInitVector.Location = New System.Drawing.Point(112, 64)
        Me.TextBoxInitVector.Name = "TextBoxInitVector"
        Me.TextBoxInitVector.Size = New System.Drawing.Size(134, 20)
        Me.TextBoxInitVector.TabIndex = 2
        '
        'TextBoxIterations
        '
        Me.TextBoxIterations.Location = New System.Drawing.Point(112, 90)
        Me.TextBoxIterations.Name = "TextBoxIterations"
        Me.TextBoxIterations.Size = New System.Drawing.Size(134, 20)
        Me.TextBoxIterations.TabIndex = 3
        '
        'TextBoxEncrypted
        '
        Me.TextBoxEncrypted.Location = New System.Drawing.Point(112, 197)
        Me.TextBoxEncrypted.Name = "TextBoxEncrypted"
        Me.TextBoxEncrypted.Size = New System.Drawing.Size(230, 20)
        Me.TextBoxEncrypted.TabIndex = 6
        '
        'TextBoxDecrypted
        '
        Me.TextBoxDecrypted.Location = New System.Drawing.Point(112, 223)
        Me.TextBoxDecrypted.Name = "TextBoxDecrypted"
        Me.TextBoxDecrypted.Size = New System.Drawing.Size(134, 20)
        Me.TextBoxDecrypted.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Encrypted"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Decrypted"
        '
        'ButtonCryption
        '
        Me.ButtonCryption.Location = New System.Drawing.Point(112, 168)
        Me.ButtonCryption.Name = "ButtonCryption"
        Me.ButtonCryption.Size = New System.Drawing.Size(134, 23)
        Me.ButtonCryption.TabIndex = 5
        Me.ButtonCryption.Text = "Cryption"
        Me.ButtonCryption.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(250, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "(Min. 8 characters)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(250, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "(16 Characters)"
        '
        'GUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 256)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ButtonCryption)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxDecrypted)
        Me.Controls.Add(Me.TextBoxEncrypted)
        Me.Controls.Add(Me.TextBoxIterations)
        Me.Controls.Add(Me.TextBoxInitVector)
        Me.Controls.Add(Me.TextBoxSalt)
        Me.Controls.Add(Me.TextBoxPassPhrase)
        Me.Controls.Add(Me.TextBoxStringToEncrypt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "GUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crypto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxStringToEncrypt As TextBox
    Friend WithEvents TextBoxPassPhrase As TextBox
    Friend WithEvents TextBoxSalt As TextBox
    Friend WithEvents TextBoxInitVector As TextBox
    Friend WithEvents TextBoxIterations As TextBox
    Friend WithEvents TextBoxEncrypted As TextBox
    Friend WithEvents TextBoxDecrypted As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ButtonCryption As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
