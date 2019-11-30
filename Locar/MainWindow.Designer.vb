<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Me.mnuMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuRegisters = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRegisterCars = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRegisterCarRentals = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMenu
        '
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRegisters})
        Me.mnuMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(800, 24)
        Me.mnuMenu.TabIndex = 1
        Me.mnuMenu.Text = "MenuStrip1"
        '
        'mnuRegisters
        '
        Me.mnuRegisters.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRegisterCars, Me.mnuRegisterCarRentals})
        Me.mnuRegisters.Name = "mnuRegisters"
        Me.mnuRegisters.Size = New System.Drawing.Size(66, 20)
        Me.mnuRegisters.Text = "Cadastro"
        '
        'mnuRegisterCars
        '
        Me.mnuRegisterCars.Name = "mnuRegisterCars"
        Me.mnuRegisterCars.Size = New System.Drawing.Size(180, 22)
        Me.mnuRegisterCars.Text = "Carros"
        '
        'mnuRegisterCarRentals
        '
        Me.mnuRegisterCarRentals.Name = "mnuRegisterCarRentals"
        Me.mnuRegisterCarRentals.Size = New System.Drawing.Size(180, 22)
        Me.mnuRegisterCarRentals.Text = "Locações"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.mnuMenu)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuMenu
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Locar - Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuMenu.ResumeLayout(False)
        Me.mnuMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMenu As MenuStrip
    Friend WithEvents mnuRegisters As ToolStripMenuItem
    Friend WithEvents mnuRegisterCars As ToolStripMenuItem
    Friend WithEvents mnuRegisterCarRentals As ToolStripMenuItem
End Class
