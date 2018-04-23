Imports Microsoft.VisualBasic
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Private _CellColorHelper As CellColorHelper
		Private Function CreateTable(ByVal RowCount As Integer) As DataTable
			Dim tbl As New DataTable()
			tbl.Columns.Add("Name", GetType(String))
			tbl.Columns.Add("ID", GetType(Integer))
			tbl.Columns.Add("Number", GetType(Integer))
			tbl.Columns.Add("Date", GetType(DateTime))
			For i As Integer = 0 To RowCount - 1
				tbl.Rows.Add(New Object() { String.Format("Name{0}", i), i, 3 - i, DateTime.Now.AddDays(i) })
			Next i
			Return tbl
		End Function

		Public Sub New()
			InitializeComponent()
			gridControl1.DataSource = CreateTable(20)
			_CellColorHelper = New CellColorHelper(gridView1)
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			_CellColorHelper.SetCellColor(Convert.ToInt32(spinEdit1.Value), gridView1.Columns(Convert.ToInt32(spinEdit2.Value)), colorEdit1.Color)
		End Sub
	End Class
End Namespace
