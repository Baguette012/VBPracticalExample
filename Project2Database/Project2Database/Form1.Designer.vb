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
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblSold = New System.Windows.Forms.Label()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.txtItemPrice = New System.Windows.Forms.TextBox()
        Me.txtSoldBy = New System.Windows.Forms.TextBox()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Location = New System.Drawing.Point(237, 131)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(61, 13)
        Me.lblItemName.TabIndex = 0
        Me.lblItemName.Text = "Item Name:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(240, 152)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(57, 13)
        Me.lblPrice.TabIndex = 1
        Me.lblPrice.Text = "Item Price:"
        '
        'lblSold
        '
        Me.lblSold.AutoSize = True
        Me.lblSold.Location = New System.Drawing.Point(251, 174)
        Me.lblSold.Name = "lblSold"
        Me.lblSold.Size = New System.Drawing.Size(46, 13)
        Me.lblSold.TabIndex = 2
        Me.lblSold.Text = "Sold By:"
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(300, 131)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(100, 20)
        Me.txtItemName.TabIndex = 3
        '
        'txtItemPrice
        '
        Me.txtItemPrice.Location = New System.Drawing.Point(300, 152)
        Me.txtItemPrice.Name = "txtItemPrice"
        Me.txtItemPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtItemPrice.TabIndex = 4
        '
        'txtSoldBy
        '
        Me.txtSoldBy.Location = New System.Drawing.Point(300, 174)
        Me.txtSoldBy.Name = "txtSoldBy"
        Me.txtSoldBy.Size = New System.Drawing.Size(100, 20)
        Me.txtSoldBy.TabIndex = 5
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(257, 218)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(75, 23)
        Me.btnAddItem.TabIndex = 6
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.txtSoldBy)
        Me.Controls.Add(Me.txtItemPrice)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.lblSold)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblItemName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblItemName As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblSold As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents txtItemPrice As TextBox
    Friend WithEvents txtSoldBy As TextBox
    Friend WithEvents btnAddItem As Button
End Class
