Imports VBClassLibraryTemplate

Public Class VBClass
    Inherits Template ' Inherits the template

    Public NonTemplateProperty As String

    Private mstrMyProperty As String ' Local variable to hold the property value

    Public Overrides Property MyProperty() As String
        Get
            Return mstrMyProperty
        End Get
        Set(ByVal value As String)
            mstrMyProperty = value
        End Set
    End Property

    Public Overrides Function PublicFunction(ByVal MyString As String) As Boolean
        Return True
    End Function

    Public Overrides Sub PublicSub(ByVal MyString As String)

    End Sub
End Class
