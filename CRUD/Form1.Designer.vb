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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        Panel4 = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        BtnInsert = New Button()
        BtnUpdate = New Button()
        BtnDelete = New Button()
        TxtId = New TextBox()
        LabelWarrentyType = New Label()
        LabelID = New Label()
        LabelInsertDate = New Label()
        LabelItemName = New Label()
        LabelColor = New Label()
        LabelDesign = New Label()
        TxtItemName = New TextBox()
        TxtDesign = New TextBox()
        TableLayoutPanel2 = New TableLayoutPanel()
        RadioNotAllowed = New RadioButton()
        RadioAllowed = New RadioButton()
        btnRefresh = New Button()
        TxtColor = New ComboBox()
        DateTimesPicker = New DateTimePicker()
        btnSearch = New Button()
        Panel3 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        TableLayoutPanel4 = New TableLayoutPanel()
        DataGridView1 = New DataGridView()
        DataGridView = New DataGridView()
        Label2 = New Label()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Dock = DockStyle.Top
        Panel1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(978, 440)
        Panel1.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(TableLayoutPanel1)
        Panel4.Dock = DockStyle.Fill
        Panel4.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Panel4.Location = New Point(0, 57)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(978, 383)
        Panel4.TabIndex = 3
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.02559F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15.26971F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 34.60581F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.025589F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel3, 2, 8)
        TableLayoutPanel1.Controls.Add(TxtId, 2, 1)
        TableLayoutPanel1.Controls.Add(LabelWarrentyType, 1, 6)
        TableLayoutPanel1.Controls.Add(LabelID, 1, 1)
        TableLayoutPanel1.Controls.Add(LabelInsertDate, 1, 5)
        TableLayoutPanel1.Controls.Add(LabelItemName, 1, 2)
        TableLayoutPanel1.Controls.Add(LabelColor, 1, 4)
        TableLayoutPanel1.Controls.Add(LabelDesign, 1, 3)
        TableLayoutPanel1.Controls.Add(TxtItemName, 2, 2)
        TableLayoutPanel1.Controls.Add(TxtDesign, 2, 3)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 2, 6)
        TableLayoutPanel1.Controls.Add(btnRefresh, 3, 8)
        TableLayoutPanel1.Controls.Add(TxtColor, 2, 4)
        TableLayoutPanel1.Controls.Add(DateTimesPicker, 2, 5)
        TableLayoutPanel1.Controls.Add(btnSearch, 3, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 9
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 7.832898F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.2715406F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5326366F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5326366F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5326366F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 13.3159266F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.0104437F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 2.08877277F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.3603134F))
        TableLayoutPanel1.Size = New Size(978, 383)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 3
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel3.Controls.Add(BtnInsert, 0, 0)
        TableLayoutPanel3.Controls.Add(BtnUpdate, 1, 0)
        TableLayoutPanel3.Controls.Add(BtnDelete, 2, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(396, 329)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.Size = New Size(332, 51)
        TableLayoutPanel3.TabIndex = 2
        ' 
        ' BtnInsert
        ' 
        BtnInsert.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point)
        BtnInsert.Location = New Point(3, 3)
        BtnInsert.Name = "BtnInsert"
        BtnInsert.Size = New Size(81, 45)
        BtnInsert.TabIndex = 2
        BtnInsert.Text = "Insert"
        BtnInsert.UseVisualStyleBackColor = True
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point)
        BtnUpdate.Location = New Point(113, 3)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(81, 45)
        BtnUpdate.TabIndex = 2
        BtnUpdate.Text = "Update"
        BtnUpdate.UseVisualStyleBackColor = True
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point)
        BtnDelete.Location = New Point(223, 3)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(83, 45)
        BtnDelete.TabIndex = 2
        BtnDelete.Text = "Delete"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' TxtId
        ' 
        TxtId.Anchor = AnchorStyles.Top
        TxtId.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        TxtId.Location = New Point(430, 33)
        TxtId.Name = "TxtId"
        TxtId.PlaceholderText = "**1"
        TxtId.Size = New Size(263, 45)
        TxtId.TabIndex = 1
        TxtId.TextAlign = HorizontalAlignment.Center
        ' 
        ' LabelWarrentyType
        ' 
        LabelWarrentyType.AutoSize = True
        LabelWarrentyType.Dock = DockStyle.Fill
        LabelWarrentyType.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        LabelWarrentyType.Location = New Point(247, 272)
        LabelWarrentyType.Name = "LabelWarrentyType"
        LabelWarrentyType.Size = New Size(143, 46)
        LabelWarrentyType.TabIndex = 0
        LabelWarrentyType.Text = "Warrenty Type"
        ' 
        ' LabelID
        ' 
        LabelID.AutoSize = True
        LabelID.Dock = DockStyle.Fill
        LabelID.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        LabelID.Location = New Point(247, 30)
        LabelID.Name = "LabelID"
        LabelID.Size = New Size(143, 47)
        LabelID.TabIndex = 0
        LabelID.Text = "ID"
        ' 
        ' LabelInsertDate
        ' 
        LabelInsertDate.AutoSize = True
        LabelInsertDate.Dock = DockStyle.Fill
        LabelInsertDate.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        LabelInsertDate.Location = New Point(247, 221)
        LabelInsertDate.Name = "LabelInsertDate"
        LabelInsertDate.Size = New Size(143, 51)
        LabelInsertDate.TabIndex = 0
        LabelInsertDate.Text = "Insert Date"
        ' 
        ' LabelItemName
        ' 
        LabelItemName.AutoSize = True
        LabelItemName.Dock = DockStyle.Fill
        LabelItemName.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        LabelItemName.Location = New Point(247, 77)
        LabelItemName.Name = "LabelItemName"
        LabelItemName.Size = New Size(143, 48)
        LabelItemName.TabIndex = 0
        LabelItemName.Text = "Item Name"
        ' 
        ' LabelColor
        ' 
        LabelColor.AutoSize = True
        LabelColor.Dock = DockStyle.Fill
        LabelColor.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        LabelColor.Location = New Point(247, 173)
        LabelColor.Name = "LabelColor"
        LabelColor.Size = New Size(143, 48)
        LabelColor.TabIndex = 0
        LabelColor.Text = "Color"
        ' 
        ' LabelDesign
        ' 
        LabelDesign.AutoSize = True
        LabelDesign.Dock = DockStyle.Fill
        LabelDesign.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        LabelDesign.Location = New Point(247, 125)
        LabelDesign.Name = "LabelDesign"
        LabelDesign.Size = New Size(143, 48)
        LabelDesign.TabIndex = 0
        LabelDesign.Text = "Design"
        ' 
        ' TxtItemName
        ' 
        TxtItemName.Anchor = AnchorStyles.Top
        TxtItemName.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        TxtItemName.Location = New Point(430, 80)
        TxtItemName.Name = "TxtItemName"
        TxtItemName.PlaceholderText = "Mouse"
        TxtItemName.Size = New Size(263, 45)
        TxtItemName.TabIndex = 1
        TxtItemName.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtDesign
        ' 
        TxtDesign.Anchor = AnchorStyles.Top
        TxtDesign.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        TxtDesign.Location = New Point(430, 128)
        TxtDesign.Name = "TxtDesign"
        TxtDesign.PlaceholderText = "Apple"
        TxtDesign.Size = New Size(263, 45)
        TxtDesign.TabIndex = 1
        TxtDesign.TextAlign = HorizontalAlignment.Center
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 49.2268028F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.7731972F))
        TableLayoutPanel2.Controls.Add(RadioNotAllowed, 0, 0)
        TableLayoutPanel2.Controls.Add(RadioAllowed, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        TableLayoutPanel2.Location = New Point(396, 275)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(332, 40)
        TableLayoutPanel2.TabIndex = 2
        ' 
        ' RadioNotAllowed
        ' 
        RadioNotAllowed.AutoSize = True
        RadioNotAllowed.Dock = DockStyle.Left
        RadioNotAllowed.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        RadioNotAllowed.Location = New Point(166, 3)
        RadioNotAllowed.Name = "RadioNotAllowed"
        RadioNotAllowed.Size = New Size(163, 34)
        RadioNotAllowed.TabIndex = 3
        RadioNotAllowed.TabStop = True
        RadioNotAllowed.Text = "Not Allowed"
        RadioNotAllowed.UseVisualStyleBackColor = True
        ' 
        ' RadioAllowed
        ' 
        RadioAllowed.AutoSize = True
        RadioAllowed.Dock = DockStyle.Left
        RadioAllowed.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        RadioAllowed.Location = New Point(3, 3)
        RadioAllowed.Name = "RadioAllowed"
        RadioAllowed.Size = New Size(132, 34)
        RadioAllowed.TabIndex = 2
        RadioAllowed.TabStop = True
        RadioAllowed.Text = "Allowed"
        RadioAllowed.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackgroundImage = CType(resources.GetObject("btnRefresh.BackgroundImage"), Image)
        btnRefresh.BackgroundImageLayout = ImageLayout.Zoom
        btnRefresh.Dock = DockStyle.Right
        btnRefresh.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        btnRefresh.Location = New Point(894, 329)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(81, 51)
        btnRefresh.TabIndex = 2
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' TxtColor
        ' 
        TxtColor.AllowDrop = True
        TxtColor.Anchor = AnchorStyles.Top
        TxtColor.FormattingEnabled = True
        TxtColor.Items.AddRange(New Object() {"Black", "Blue", "Red", "White"})
        TxtColor.Location = New Point(430, 176)
        TxtColor.Name = "TxtColor"
        TxtColor.Size = New Size(263, 46)
        TxtColor.Sorted = True
        TxtColor.TabIndex = 3
        ' 
        ' DateTimesPicker
        ' 
        DateTimesPicker.Anchor = AnchorStyles.Top
        DateTimesPicker.Format = DateTimePickerFormat.Short
        DateTimesPicker.Location = New Point(430, 224)
        DateTimesPicker.Name = "DateTimesPicker"
        DateTimesPicker.Size = New Size(263, 45)
        DateTimesPicker.TabIndex = 4
        ' 
        ' btnSearch
        ' 
        btnSearch.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point)
        btnSearch.Location = New Point(734, 33)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(83, 41)
        btnSearch.TabIndex = 5
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label1)
        Panel3.Dock = DockStyle.Top
        Panel3.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(978, 57)
        Panel3.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 20F, FontStyle.Underline, GraphicsUnit.Point)
        Label1.Location = New Point(310, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(544, 54)
        Label1.TabIndex = 1
        Label1.Text = "CRUD operation in VB.NET"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(TableLayoutPanel4)
        Panel2.Controls.Add(Label2)
        Panel2.Dock = DockStyle.Fill
        Panel2.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Panel2.Location = New Point(0, 440)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(978, 304)
        Panel2.TabIndex = 1
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 3
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 10F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 10F))
        TableLayoutPanel4.Controls.Add(DataGridView1, 0, 0)
        TableLayoutPanel4.Controls.Add(DataGridView, 1, 1)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(0, 0)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 3
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 10F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 10F))
        TableLayoutPanel4.Size = New Size(978, 304)
        TableLayoutPanel4.TabIndex = 2
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(3, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(4, 4)
        DataGridView1.TabIndex = 2
        ' 
        ' DataGridView
        ' 
        DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView.Dock = DockStyle.Fill
        DataGridView.GridColor = SystemColors.ActiveCaption
        DataGridView.Location = New Point(13, 13)
        DataGridView.Name = "DataGridView"
        DataGridView.RowHeadersWidth = 62
        DataGridView.RowTemplate.Height = 33
        DataGridView.Size = New Size(952, 278)
        DataGridView.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(258, -150)
        Label2.Name = "Label2"
        Label2.Size = New Size(163, 38)
        Label2.TabIndex = 0
        Label2.Text = "Insert Date"
        ' 
        ' Form1
        ' 
        AllowDrop = True
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.DarkCyan
        ClientSize = New Size(978, 744)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MaximumSize = New Size(1000, 800)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Chitwan Computers Pvt. Ltd"
        Panel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LabelWarrentyType As Label
    Friend WithEvents LabelInsertDate As Label
    Friend WithEvents LabelColor As Label
    Friend WithEvents LabelDesign As Label
    Friend WithEvents LabelItemName As Label
    Friend WithEvents LabelID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents TxtItemName As TextBox
    Friend WithEvents TxtDesign As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents RadioAllowed As RadioButton
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BtnInsert As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents TxtColor As ComboBox
    Friend WithEvents DateTimesPicker As DateTimePicker
    Friend WithEvents RadioNotAllowed As RadioButton
    Friend WithEvents btnSearch As Button
End Class
