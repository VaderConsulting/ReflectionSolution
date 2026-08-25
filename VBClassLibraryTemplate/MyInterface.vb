' The use of an interface forces the use of all methods within the interface
Public Interface MyInterface

    Function InterfaceFunction(ByVal Inbound As Integer) As Boolean
    Sub InterfaceSub(ByVal Inbound As Integer)
    Property MyProperty() As String

End Interface
