<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.TxtInput = New System.Windows.Forms.TextBox()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.LblTotalItems = New System.Windows.Forms.Label()
        Me.LblAverage = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnLoad = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtInput
        '
        Me.TxtInput.Location = New System.Drawing.Point(97, 47)
        Me.TxtInput.Name = "TxtInput"
        Me.TxtInput.Size = New System.Drawing.Size(100, 20)
        Me.TxtInput.TabIndex = 0
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(97, 73)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.BtnSubmit.TabIndex = 1
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'lblTotalSales
        '
        Me.lblTotalSales.AutoSize = True
        Me.lblTotalSales.Location = New System.Drawing.Point(97, 188)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalSales.TabIndex = 2
        Me.lblTotalSales.Text = "0"
        '
        'LblTotalItems
        '
        Me.LblTotalItems.AutoSize = True
        Me.LblTotalItems.Location = New System.Drawing.Point(158, 188)
        Me.LblTotalItems.Name = "LblTotalItems"
        Me.LblTotalItems.Size = New System.Drawing.Size(13, 13)
        Me.LblTotalItems.TabIndex = 3
        Me.LblTotalItems.Text = "1"
        '
        'LblAverage
        '
        Me.LblAverage.AutoSize = True
        Me.LblAverage.Location = New System.Drawing.Point(227, 188)
        Me.LblAverage.Name = "LblAverage"
        Me.LblAverage.Size = New System.Drawing.Size(0, 13)
        Me.LblAverage.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Insert Price"
        '
        'BtnLoad
        '
        Me.BtnLoad.Location = New System.Drawing.Point(215, 45)
        Me.BtnLoad.Name = "BtnLoad"
        Me.BtnLoad.Size = New System.Drawing.Size(75, 23)
        Me.BtnLoad.TabIndex = 7
        Me.BtnLoad.Text = "Load"
        Me.BtnLoad.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(215, 73)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 8
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 279)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnLoad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblAverage)
        Me.Controls.Add(Me.LblTotalItems)
        Me.Controls.Add(Me.lblTotalSales)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.TxtInput)
        Me.Name = "Form1"
        Me.Text = "b"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtInput As TextBox
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents LblTotalItems As Label
    Friend WithEvents LblAverage As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnLoad As Button
    Friend WithEvents BtnSave As Button
End Class
