Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Documents

Namespace BindComboBoxEdit

	Partial Public Class Window1
		Inherits Window

		Public Sub New()
			InitializeComponent()

			Dim list As New List(Of TestData)()
			For i As Integer = 0 To 99
				list.Add(New TestData() With {.Text = "row " & i, _
				.DetailId = i Mod 5, .DetailSource = GetDetailSource(i Mod 5)})
			Next i

			grid.ItemsSource = list
		End Sub

		Private Function GetDetailSource(ByVal i As Integer) As IList(Of DetailData)
			Dim detailSource As New List(Of DetailData)()
			For j As Integer = 0 To 9
				detailSource.Add(New DetailData() With {.Id = i + j, _
				.Value = "value " & (i + j) & " kind  " & i})
			Next j
			Return detailSource
		End Function
	End Class

	Public Class TestData
		Private privateText As String
		Public Property Text() As String
			Get
				Return privateText
			End Get
			Set(ByVal value As String)
				privateText = value
			End Set
		End Property
		Private privateDetailId As Integer
		Public Property DetailId() As Integer
			Get
				Return privateDetailId
			End Get
			Set(ByVal value As Integer)
				privateDetailId = value
			End Set
		End Property
		Private privateDetailSource As Object
		Public Property DetailSource() As Object
			Get
				Return privateDetailSource
			End Get
			Set(ByVal value As Object)
				privateDetailSource = value
			End Set
		End Property
	End Class

	Public Class DetailData
		Private privateId As Integer
		Public Property Id() As Integer
			Get
				Return privateId
			End Get
			Set(ByVal value As Integer)
				privateId = value
			End Set
		End Property
		Private privateValue As String
		Public Property Value() As String
			Get
				Return privateValue
			End Get
			Set(ByVal value As String)
				privateValue = value
			End Set
		End Property
	End Class
End Namespace
