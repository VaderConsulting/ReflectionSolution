namespace CSharpClassLibraryTemplate 
{
    public abstract class Template
    {
        
        // Local variable
        private string mstrMyProperty = "";

        public abstract string MyProperty
        {
            get;
            set;
        }
        public abstract bool PublicFunction(string MyString);
        public abstract void PublicSub(string MyString);
        
    }        
}

