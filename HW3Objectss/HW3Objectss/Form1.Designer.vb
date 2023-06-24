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
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnLoad = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblAverage = New System.Windows.Forms.Label()
        Me.LblTotalItems = New System.Windows.Forms.Label()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.TxtInput = New System.Windows.Forms.TextBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.LblName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(422, 182)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 16
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnLoad
        '
        Me.BtnLoad.Location = New System.Drawing.Point(422, 154)
        Me.BtnLoad.Name = "BtnLoad"
        Me.BtnLoad.Size = New System.Drawing.Size(75, 23)
        Me.BtnLoad.TabIndex = 15
        Me.BtnLoad.Text = "Load"
        Me.BtnLoad.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(238, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Insert Price"
        '
        'LblAverage
        '
        Me.LblAverage.AutoSize = True
        Me.LblAverage.Location = New System.Drawing.Point(434, 297)
        Me.LblAverage.Name = "LblAverage"
        Me.LblAverage.Size = New System.Drawing.Size(0, 13)
        Me.LblAverage.TabIndex = 13
        '
        'LblTotalItems
        '
        Me.LblTotalItems.AutoSize = True
        Me.LblTotalItems.Location = New System.Drawing.Point(365, 297)
        Me.LblTotalItems.Name = "LblTotalItems"
        Me.LblTotalItems.Size = New System.Drawing.Size(13, 13)
        Me.LblTotalItems.TabIndex = 12
        Me.LblTotalItems.Text = "1"
        '
        'lblTotalSales
        '
        Me.lblTotalSales.AutoSize = True
        Me.lblTotalSales.Location = New System.Drawing.Point(304, 297)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalSales.TabIndex = 11
        Me.lblTotalSales.Text = "0"
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(304, 182)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.BtnSubmit.TabIndex = 10
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'TxtInput
        '
        Me.TxtInput.Location = New System.Drawing.Point(304, 156)
        Me.TxtInput.Name = "TxtInput"
        Me.TxtInput.Size = New System.Drawing.Size(100, 20)
        Me.TxtInput.TabIndex = 9
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(307, 130)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(100, 20)
        Me.TxtName.TabIndex = 17
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Location = New System.Drawing.Point(238, 130)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(64, 13)
        Me.LblName.TabIndex = 18
        Me.LblName.Text = "Insert Name"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnLoad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblAverage)
        Me.Controls.Add(Me.LblTotalItems)
        Me.Controls.Add(Me.lblTotalSales)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.TxtInput)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnLoad As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LblAverage As Label
    Friend WithEvents LblTotalItems As Label
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents TxtInput As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents LblName As Label
End Class
