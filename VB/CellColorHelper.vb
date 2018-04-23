Imports Microsoft.VisualBasic
Imports DevExpress.XtraGrid.Columns
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
	Public Class CellColorHelper
		Private colors As New Dictionary(Of MyGridCell, Color)()
		Private ReadOnly _View As GridView
		''' <summary>
		''' Initializes a new instance of the CellColorHelper class.
		''' </summary>
		Public Sub New(ByVal view As GridView)
			_View = view
			AddHandler _View.RowCellStyle, AddressOf _View_RowCellStyle
		End Sub

		Private Sub _View_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs)
			Dim color As Color = GetCellColor(New MyGridCell(e.RowHandle, e.Column))
			If color.IsEmpty Then
				Return
			End If
			e.Appearance.BackColor = color
		End Sub

		Public Function GetCellColor(ByVal cell As MyGridCell) As Color
			Dim c As Color = Color.Empty
			If colors.TryGetValue(cell, c) Then
				Return c
			End If
			Return Color.Empty
		End Function

		Public Sub SetCellColor(ByVal rowHandle As Integer, ByVal column As GridColumn, ByVal value As Color)
			SetCellColor(New MyGridCell(rowHandle, column), value)
		End Sub

		Public Sub SetCellColor(ByVal cell As MyGridCell, ByVal value As Color)
			colors(cell) = value
			_View.RefreshRowCell(cell.RowHandle, cell.Column)
		End Sub

	End Class

	Public Class MyGridCell
		Inherits GridCell
		Public Sub New(ByVal rowHandle As Integer, ByVal column As GridColumn)
			MyBase.New(rowHandle, column)

		End Sub

		Public Overrides Function GetHashCode() As Integer
			Return Column.GetHashCode() + RowHandle.GetHashCode()
		End Function

		Public Overrides Overloads Function Equals(ByVal obj As Object) As Boolean
			Return Equals(TryCast(obj, GridCell))
		End Function
	End Class
End Namespace
