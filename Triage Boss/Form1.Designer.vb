<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.txtInsurance = New System.Windows.Forms.TextBox()
        Me.cmbClient = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lvwInsurance = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwOther = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwGlobal = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwSendOut = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblInsurance = New System.Windows.Forms.Label()
        Me.lvwTCPC = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblGlobal = New System.Windows.Forms.Label()
        Me.lblOther = New System.Windows.Forms.Label()
        Me.lblTCPC = New System.Windows.Forms.Label()
        Me.lblSendOut = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(37, 12)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'txtInsurance
        '
        Me.txtInsurance.Location = New System.Drawing.Point(397, 15)
        Me.txtInsurance.Name = "txtInsurance"
        Me.txtInsurance.Size = New System.Drawing.Size(100, 20)
        Me.txtInsurance.TabIndex = 3
        '
        'cmbClient
        '
        Me.cmbClient.FormattingEnabled = True
        Me.cmbClient.Location = New System.Drawing.Point(130, 14)
        Me.cmbClient.Name = "cmbClient"
        Me.cmbClient.Size = New System.Drawing.Size(121, 21)
        Me.cmbClient.Sorted = True
        Me.cmbClient.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(37, 37)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lvwInsurance)
        Me.Panel1.Controls.Add(Me.lvwOther)
        Me.Panel1.Controls.Add(Me.lvwGlobal)
        Me.Panel1.Controls.Add(Me.lvwSendOut)
        Me.Panel1.Controls.Add(Me.lblInsurance)
        Me.Panel1.Controls.Add(Me.lvwTCPC)
        Me.Panel1.Controls.Add(Me.lblGlobal)
        Me.Panel1.Controls.Add(Me.lblOther)
        Me.Panel1.Controls.Add(Me.lblTCPC)
        Me.Panel1.Controls.Add(Me.lblSendOut)
        Me.Panel1.Location = New System.Drawing.Point(12, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(555, 439)
        Me.Panel1.TabIndex = 27
        '
        'lvwInsurance
        '
        Me.lvwInsurance.AllowDrop = True
        Me.lvwInsurance.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lvwInsurance.FullRowSelect = True
        Me.lvwInsurance.Location = New System.Drawing.Point(9, 24)
        Me.lvwInsurance.MultiSelect = False
        Me.lvwInsurance.Name = "lvwInsurance"
        Me.lvwInsurance.Size = New System.Drawing.Size(176, 406)
        Me.lvwInsurance.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvwInsurance.TabIndex = 47
        Me.lvwInsurance.TabStop = False
        Me.lvwInsurance.UseCompatibleStateImageBehavior = False
        Me.lvwInsurance.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 171
        '
        'lvwOther
        '
        Me.lvwOther.AllowDrop = True
        Me.lvwOther.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4})
        Me.lvwOther.FullRowSelect = True
        Me.lvwOther.Location = New System.Drawing.Point(373, 244)
        Me.lvwOther.MultiSelect = False
        Me.lvwOther.Name = "lvwOther"
        Me.lvwOther.Size = New System.Drawing.Size(176, 186)
        Me.lvwOther.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvwOther.TabIndex = 55
        Me.lvwOther.TabStop = False
        Me.lvwOther.UseCompatibleStateImageBehavior = False
        Me.lvwOther.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Name"
        Me.ColumnHeader4.Width = 170
        '
        'lvwGlobal
        '
        Me.lvwGlobal.AllowDrop = True
        Me.lvwGlobal.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.lvwGlobal.FullRowSelect = True
        Me.lvwGlobal.Location = New System.Drawing.Point(191, 24)
        Me.lvwGlobal.MultiSelect = False
        Me.lvwGlobal.Name = "lvwGlobal"
        Me.lvwGlobal.ShowItemToolTips = True
        Me.lvwGlobal.Size = New System.Drawing.Size(176, 186)
        Me.lvwGlobal.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvwGlobal.TabIndex = 46
        Me.lvwGlobal.TabStop = False
        Me.lvwGlobal.UseCompatibleStateImageBehavior = False
        Me.lvwGlobal.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 170
        '
        'lvwSendOut
        '
        Me.lvwSendOut.AllowDrop = True
        Me.lvwSendOut.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5})
        Me.lvwSendOut.FullRowSelect = True
        Me.lvwSendOut.Location = New System.Drawing.Point(191, 244)
        Me.lvwSendOut.MultiSelect = False
        Me.lvwSendOut.Name = "lvwSendOut"
        Me.lvwSendOut.Size = New System.Drawing.Size(176, 186)
        Me.lvwSendOut.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvwSendOut.TabIndex = 54
        Me.lvwSendOut.TabStop = False
        Me.lvwSendOut.UseCompatibleStateImageBehavior = False
        Me.lvwSendOut.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Name"
        Me.ColumnHeader5.Width = 170
        '
        'lblInsurance
        '
        Me.lblInsurance.AutoSize = True
        Me.lblInsurance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsurance.Location = New System.Drawing.Point(6, 8)
        Me.lblInsurance.Name = "lblInsurance"
        Me.lblInsurance.Size = New System.Drawing.Size(63, 13)
        Me.lblInsurance.TabIndex = 48
        Me.lblInsurance.Text = "Insurance"
        '
        'lvwTCPC
        '
        Me.lvwTCPC.AllowDrop = True
        Me.lvwTCPC.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3})
        Me.lvwTCPC.FullRowSelect = True
        Me.lvwTCPC.Location = New System.Drawing.Point(373, 24)
        Me.lvwTCPC.MultiSelect = False
        Me.lvwTCPC.Name = "lvwTCPC"
        Me.lvwTCPC.Size = New System.Drawing.Size(176, 186)
        Me.lvwTCPC.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvwTCPC.TabIndex = 53
        Me.lvwTCPC.TabStop = False
        Me.lvwTCPC.UseCompatibleStateImageBehavior = False
        Me.lvwTCPC.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Name"
        Me.ColumnHeader3.Width = 170
        '
        'lblGlobal
        '
        Me.lblGlobal.AutoSize = True
        Me.lblGlobal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGlobal.Location = New System.Drawing.Point(188, 8)
        Me.lblGlobal.Name = "lblGlobal"
        Me.lblGlobal.Size = New System.Drawing.Size(43, 13)
        Me.lblGlobal.TabIndex = 49
        Me.lblGlobal.Text = "Global"
        '
        'lblOther
        '
        Me.lblOther.AutoSize = True
        Me.lblOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOther.Location = New System.Drawing.Point(373, 229)
        Me.lblOther.Name = "lblOther"
        Me.lblOther.Size = New System.Drawing.Size(38, 13)
        Me.lblOther.TabIndex = 52
        Me.lblOther.Text = "Other"
        '
        'lblTCPC
        '
        Me.lblTCPC.AutoSize = True
        Me.lblTCPC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTCPC.Location = New System.Drawing.Point(370, 8)
        Me.lblTCPC.Name = "lblTCPC"
        Me.lblTCPC.Size = New System.Drawing.Size(39, 13)
        Me.lblTCPC.TabIndex = 50
        Me.lblTCPC.Text = "TCPC"
        '
        'lblSendOut
        '
        Me.lblSendOut.AutoSize = True
        Me.lblSendOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSendOut.Location = New System.Drawing.Point(191, 228)
        Me.lblSendOut.Name = "lblSendOut"
        Me.lblSendOut.Size = New System.Drawing.Size(60, 13)
        Me.lblSendOut.TabIndex = 51
        Me.lblSendOut.Text = "Send Out"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(37, 62)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 28
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 542)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmbClient)
        Me.Controls.Add(Me.txtInsurance)
        Me.Controls.Add(Me.btnLoad)
        Me.Name = "frmMain"
        Me.Text = "Traige Boss"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLoad As Button
    Friend WithEvents txtInsurance As TextBox
    Friend WithEvents cmbClient As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClear As Button
    Friend WithEvents lvwInsurance As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents lvwOther As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents lvwGlobal As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents lvwSendOut As ListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents lblInsurance As Label
    Friend WithEvents lvwTCPC As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents lblGlobal As Label
    Friend WithEvents lblOther As Label
    Friend WithEvents lblTCPC As Label
    Friend WithEvents lblSendOut As Label
End Class
