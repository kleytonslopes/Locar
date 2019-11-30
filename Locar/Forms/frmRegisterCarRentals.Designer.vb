<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegisterCarRentals
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
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Teste")
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Teste 2")
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpDue = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLicensePlate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMake = New System.Windows.Forms.TextBox()
        Me.lstCars = New System.Windows.Forms.ListView()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dtpDue)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtpStart)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtLicensePlate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtYear)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtColor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtModel)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtMake)
        Me.GroupBox1.Location = New System.Drawing.Point(206, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(462, 170)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informações"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(156, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Entrega:"
        '
        'dtpDue
        '
        Me.dtpDue.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDue.Location = New System.Drawing.Point(159, 113)
        Me.dtpDue.Name = "dtpDue"
        Me.dtpDue.Size = New System.Drawing.Size(139, 20)
        Me.dtpDue.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Retirada:"
        '
        'dtpStart
        '
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStart.Location = New System.Drawing.Point(14, 113)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(139, 20)
        Me.dtpStart.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(156, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Placa:"
        '
        'txtLicensePlate
        '
        Me.txtLicensePlate.Enabled = False
        Me.txtLicensePlate.Location = New System.Drawing.Point(159, 74)
        Me.txtLicensePlate.MaxLength = 150
        Me.txtLicensePlate.Name = "txtLicensePlate"
        Me.txtLicensePlate.Size = New System.Drawing.Size(139, 20)
        Me.txtLicensePlate.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Ano:"
        '
        'txtYear
        '
        Me.txtYear.Enabled = False
        Me.txtYear.Location = New System.Drawing.Point(14, 74)
        Me.txtYear.MaxLength = 150
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(139, 20)
        Me.txtYear.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(301, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Cor:"
        '
        'txtColor
        '
        Me.txtColor.Enabled = False
        Me.txtColor.Location = New System.Drawing.Point(304, 35)
        Me.txtColor.MaxLength = 150
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(139, 20)
        Me.txtColor.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(156, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Modelo:"
        '
        'txtModel
        '
        Me.txtModel.Enabled = False
        Me.txtModel.Location = New System.Drawing.Point(159, 35)
        Me.txtModel.MaxLength = 150
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(139, 20)
        Me.txtModel.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Marca:"
        '
        'txtMake
        '
        Me.txtMake.Enabled = False
        Me.txtMake.Location = New System.Drawing.Point(14, 35)
        Me.txtMake.MaxLength = 150
        Me.txtMake.Name = "txtMake"
        Me.txtMake.Size = New System.Drawing.Size(139, 20)
        Me.txtMake.TabIndex = 4
        '
        'lstCars
        '
        Me.lstCars.HideSelection = False
        Me.lstCars.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem5, ListViewItem6})
        Me.lstCars.Location = New System.Drawing.Point(12, 12)
        Me.lstCars.MultiSelect = False
        Me.lstCars.Name = "lstCars"
        Me.lstCars.Size = New System.Drawing.Size(188, 199)
        Me.lstCars.TabIndex = 2
        Me.lstCars.UseCompatibleStateImageBehavior = False
        Me.lstCars.View = System.Windows.Forms.View.List
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(220, 188)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Salvar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmRegisterCarRentals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(687, 232)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lstCars)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmRegisterCarRentals"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Locação"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstCars As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMake As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtModel As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLicensePlate As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtYear As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtColor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpDue As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents btnSave As Button
End Class
