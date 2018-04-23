Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit()
			Me.colorEdit1 = New DevExpress.XtraEditors.ColorEdit()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.spinEdit2 = New DevExpress.XtraEditors.SpinEdit()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.SuspendLayout()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.colorEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' splitContainerControl1
			' 
			Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainerControl1.Name = "splitContainerControl1"
			Me.splitContainerControl1.Panel1.Controls.Add(Me.layoutControl1)
			Me.splitContainerControl1.Panel1.Text = "Panel1"
			Me.splitContainerControl1.Panel2.Controls.Add(Me.gridControl1)
			Me.splitContainerControl1.Panel2.Text = "Panel2"
			Me.splitContainerControl1.Size = New System.Drawing.Size(1007, 519)
			Me.splitContainerControl1.SplitterPosition = 235
			Me.splitContainerControl1.TabIndex = 0
			Me.splitContainerControl1.Text = "splitContainerControl1"
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(767, 519)
			Me.gridControl1.TabIndex = 1
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.gridView2})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' gridView2
			' 
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.simpleButton1)
			Me.layoutControl1.Controls.Add(Me.spinEdit2)
			Me.layoutControl1.Controls.Add(Me.spinEdit1)
			Me.layoutControl1.Controls.Add(Me.colorEdit1)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(235, 519)
			Me.layoutControl1.TabIndex = 0
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlGroup2})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(235, 519)
			Me.layoutControlGroup1.Text = "layoutControlGroup1"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlGroup2
			' 
			Me.layoutControlGroup2.CustomizationFormText = "Set cell color"
			Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4})
			Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup2.Name = "layoutControlGroup2"
			Me.layoutControlGroup2.Size = New System.Drawing.Size(215, 499)
			Me.layoutControlGroup2.Text = "Set cell color"
			' 
			' spinEdit1
			' 
			Me.spinEdit1.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinEdit1.Location = New System.Drawing.Point(92, 67)
			Me.spinEdit1.Name = "spinEdit1"
			Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinEdit1.Properties.MaxValue = New Decimal(New Integer() { 20, 0, 0, 0})
			Me.spinEdit1.Size = New System.Drawing.Size(119, 20)
			Me.spinEdit1.StyleController = Me.layoutControl1
			Me.spinEdit1.TabIndex = 3
			' 
			' colorEdit1
			' 
			Me.colorEdit1.EditValue = System.Drawing.Color.Empty
			Me.colorEdit1.Location = New System.Drawing.Point(92, 43)
			Me.colorEdit1.Name = "colorEdit1"
			Me.colorEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.colorEdit1.Size = New System.Drawing.Size(119, 20)
			Me.colorEdit1.StyleController = Me.layoutControl1
			Me.colorEdit1.TabIndex = 2
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.colorEdit1
			Me.layoutControlItem1.CustomizationFormText = "Color"
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(191, 24)
			Me.layoutControlItem1.Text = "Color"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(64, 13)
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.spinEdit1
			Me.layoutControlItem2.CustomizationFormText = "RowHandle"
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 24)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(191, 24)
			Me.layoutControlItem2.Text = "RowHandle"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(64, 13)
			' 
			' spinEdit2
			' 
			Me.spinEdit2.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinEdit2.Location = New System.Drawing.Point(92, 91)
			Me.spinEdit2.Name = "spinEdit2"
			Me.spinEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinEdit2.Properties.MaxValue = New Decimal(New Integer() { 3, 0, 0, 0})
			Me.spinEdit2.Size = New System.Drawing.Size(119, 20)
			Me.spinEdit2.StyleController = Me.layoutControl1
			Me.spinEdit2.TabIndex = 1
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.spinEdit2
			Me.layoutControlItem3.CustomizationFormText = "Column index"
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 48)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(191, 24)
			Me.layoutControlItem3.Text = "Column index"
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(64, 13)
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(24, 115)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(187, 22)
			Me.simpleButton1.StyleController = Me.layoutControl1
			Me.simpleButton1.TabIndex = 1
			Me.simpleButton1.Text = "Set"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.simpleButton1
			Me.layoutControlItem4.CustomizationFormText = "layoutControlItem4"
			Me.layoutControlItem4.Location = New System.Drawing.Point(0, 72)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(191, 384)
			Me.layoutControlItem4.Text = "layoutControlItem4"
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem4.TextToControlDistance = 0
			Me.layoutControlItem4.TextVisible = False
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1007, 519)
			Me.Controls.Add(Me.splitContainerControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.ResumeLayout(False)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.colorEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private spinEdit2 As DevExpress.XtraEditors.SpinEdit
		Private spinEdit1 As DevExpress.XtraEditors.SpinEdit
		Private colorEdit1 As DevExpress.XtraEditors.ColorEdit
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView

	End Class
End Namespace

