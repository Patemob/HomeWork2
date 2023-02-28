<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPayRoll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayRoll))
        Me.picPayroll = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblPayCheck = New System.Windows.Forms.Label()
        Me.lblGross = New System.Windows.Forms.Label()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblIncome = New System.Windows.Forms.Label()
        Me.lblIncomeTotal = New System.Windows.Forms.Label()
        Me.lblFica = New System.Windows.Forms.Label()
        Me.lblFederal = New System.Windows.Forms.Label()
        Me.lblStateTax = New System.Windows.Forms.Label()
        Me.lblFicaTotal = New System.Windows.Forms.Label()
        Me.lblFedTotal = New System.Windows.Forms.Label()
        Me.lblStateTotal = New System.Windows.Forms.Label()
        CType(Me.picPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPayroll
        '
        Me.picPayroll.Image = CType(resources.GetObject("picPayroll.Image"), System.Drawing.Image)
        Me.picPayroll.Location = New System.Drawing.Point(0, 0)
        Me.picPayroll.Name = "picPayroll"
        Me.picPayroll.Size = New System.Drawing.Size(365, 277)
        Me.picPayroll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPayroll.TabIndex = 0
        Me.picPayroll.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Cooper Black", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(379, 34)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(332, 39)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Payroll Calculator"
        '
        'lblPayCheck
        '
        Me.lblPayCheck.AutoSize = True
        Me.lblPayCheck.Font = New System.Drawing.Font("Cooper Black", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayCheck.Location = New System.Drawing.Point(454, 119)
        Me.lblPayCheck.Name = "lblPayCheck"
        Me.lblPayCheck.Size = New System.Drawing.Size(180, 96)
        Me.lblPayCheck.TabIndex = 2
        Me.lblPayCheck.Text = "Paycheck " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calculation"
        Me.lblPayCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGross
        '
        Me.lblGross.AutoSize = True
        Me.lblGross.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGross.Location = New System.Drawing.Point(174, 295)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(245, 32)
        Me.lblGross.TabIndex = 3
        Me.lblGross.Text = "Enter Gross Pay:"
        '
        'txtGrossPay
        '
        Me.txtGrossPay.Location = New System.Drawing.Point(448, 305)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.Size = New System.Drawing.Size(100, 22)
        Me.txtGrossPay.TabIndex = 4
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCompute.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.ForeColor = System.Drawing.Color.White
        Me.btnCompute.Location = New System.Drawing.Point(59, 357)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(152, 50)
        Me.btnCompute.TabIndex = 5
        Me.btnCompute.Text = "Compute Taxes"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(289, 357)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(152, 50)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(512, 357)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(152, 50)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblIncome
        '
        Me.lblIncome.AutoSize = True
        Me.lblIncome.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncome.Location = New System.Drawing.Point(112, 511)
        Me.lblIncome.Name = "lblIncome"
        Me.lblIncome.Size = New System.Drawing.Size(270, 28)
        Me.lblIncome.TabIndex = 8
        Me.lblIncome.Text = "Net Paycheck Income:"
        '
        'lblIncomeTotal
        '
        Me.lblIncomeTotal.AutoSize = True
        Me.lblIncomeTotal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncomeTotal.Location = New System.Drawing.Point(479, 511)
        Me.lblIncomeTotal.Name = "lblIncomeTotal"
        Me.lblIncomeTotal.Size = New System.Drawing.Size(132, 28)
        Me.lblIncomeTotal.TabIndex = 9
        Me.lblIncomeTotal.Text = "$12345.67"
        '
        'lblFica
        '
        Me.lblFica.AutoSize = True
        Me.lblFica.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFica.Location = New System.Drawing.Point(27, 444)
        Me.lblFica.Name = "lblFica"
        Me.lblFica.Size = New System.Drawing.Size(62, 23)
        Me.lblFica.TabIndex = 10
        Me.lblFica.Text = "Fica: "
        '
        'lblFederal
        '
        Me.lblFederal.AutoSize = True
        Me.lblFederal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederal.Location = New System.Drawing.Point(220, 444)
        Me.lblFederal.Name = "lblFederal"
        Me.lblFederal.Size = New System.Drawing.Size(136, 23)
        Me.lblFederal.TabIndex = 11
        Me.lblFederal.Text = "Federal Tax: "
        '
        'lblStateTax
        '
        Me.lblStateTax.AutoSize = True
        Me.lblStateTax.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateTax.Location = New System.Drawing.Point(488, 444)
        Me.lblStateTax.Name = "lblStateTax"
        Me.lblStateTax.Size = New System.Drawing.Size(112, 23)
        Me.lblStateTax.TabIndex = 12
        Me.lblStateTax.Text = "State Tax: "
        '
        'lblFicaTotal
        '
        Me.lblFicaTotal.AutoSize = True
        Me.lblFicaTotal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFicaTotal.Location = New System.Drawing.Point(90, 444)
        Me.lblFicaTotal.Name = "lblFicaTotal"
        Me.lblFicaTotal.Size = New System.Drawing.Size(46, 23)
        Me.lblFicaTotal.TabIndex = 13
        Me.lblFicaTotal.Text = "123"
        '
        'lblFedTotal
        '
        Me.lblFedTotal.AutoSize = True
        Me.lblFedTotal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFedTotal.Location = New System.Drawing.Point(358, 444)
        Me.lblFedTotal.Name = "lblFedTotal"
        Me.lblFedTotal.Size = New System.Drawing.Size(46, 23)
        Me.lblFedTotal.TabIndex = 14
        Me.lblFedTotal.Text = "123"
        '
        'lblStateTotal
        '
        Me.lblStateTotal.AutoSize = True
        Me.lblStateTotal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateTotal.Location = New System.Drawing.Point(605, 444)
        Me.lblStateTotal.Name = "lblStateTotal"
        Me.lblStateTotal.Size = New System.Drawing.Size(46, 23)
        Me.lblStateTotal.TabIndex = 15
        Me.lblStateTotal.Text = "123"
        '
        'frmPayRoll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 589)
        Me.Controls.Add(Me.lblStateTotal)
        Me.Controls.Add(Me.lblFedTotal)
        Me.Controls.Add(Me.lblFicaTotal)
        Me.Controls.Add(Me.lblStateTax)
        Me.Controls.Add(Me.lblFederal)
        Me.Controls.Add(Me.lblFica)
        Me.Controls.Add(Me.lblIncomeTotal)
        Me.Controls.Add(Me.lblIncome)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtGrossPay)
        Me.Controls.Add(Me.lblGross)
        Me.Controls.Add(Me.lblPayCheck)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picPayroll)
        Me.Name = "frmPayRoll"
        Me.Text = "Payroll Every Two Weeks"
        CType(Me.picPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPayroll As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblPayCheck As Label
    Friend WithEvents lblGross As Label
    Friend WithEvents txtGrossPay As TextBox
    Friend WithEvents btnCompute As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblIncome As Label
    Friend WithEvents lblIncomeTotal As Label
    Friend WithEvents lblFica As Label
    Friend WithEvents lblFederal As Label
    Friend WithEvents lblStateTax As Label
    Friend WithEvents lblFicaTotal As Label
    Friend WithEvents lblFedTotal As Label
    Friend WithEvents lblStateTotal As Label
End Class
