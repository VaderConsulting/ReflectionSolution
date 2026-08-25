Public MustInherit Class Template ' Note the use of 'MustInherit'

    ' Local variable
    Private mstrMyProperty As String

    Public MustOverride Property MyProperty() As String
    Public MustOverride Function PublicFunction(ByVal MyString As String) As Boolean
    Public MustOverride Sub PublicSub(ByVal MyString As String)

End Class
