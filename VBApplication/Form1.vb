Imports VBClassLibrary
Imports VBClassLibraryTemplate.Enumeration

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim NewClass As New VBClassLibrary.VBClass

        NewClass.NonTemplateProperty = "Hello World"
        NewClass.MyProperty = "Hello World"

        Dim Result As Boolean = NewClass.PublicFunction("Any String")
        Dim LocalVariable As MyEnum

        LocalVariable = MyEnum.MyInteger

        LocalVariable += 1

    End Sub
End Class
