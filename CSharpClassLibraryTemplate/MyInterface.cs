// The use of an interface forces the use of all methods within the interface
public interface MyInterface
{
    bool InterfaceFunction(int Inbound);
    void InterfaceSub(int Inbound);
    string MyProperty
    {
        get;
        set;
    }
}

