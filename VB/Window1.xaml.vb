Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Documents

Namespace BindComboBoxEdit

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Dim list As List(Of TestData) = New List(Of TestData)()
            For i As Integer = 0 To 100 - 1
                list.Add(New TestData() With {.Text = "row " & i, .DetailId = i Mod 5, .DetailSource = GetDetailSource(i Mod 5)})
            Next

            Me.grid.ItemsSource = list
        End Sub

        Private Function GetDetailSource(ByVal i As Integer) As IList(Of DetailData)
            Dim detailSource As List(Of DetailData) = New List(Of DetailData)()
            For j As Integer = 0 To 10 - 1
                detailSource.Add(New DetailData() With {.Id = i + j, .Value = "value " & i + j & " kind  " & i})
            Next

            Return detailSource
        End Function
    End Class

    Public Class TestData

        Public Property Text As String

        Public Property DetailId As Integer

        Public Property DetailSource As Object
    End Class

    Public Class DetailData

        Public Property Id As Integer

        Public Property Value As String
    End Class
End Namespace
