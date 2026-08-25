using System;
using System.Collections.Generic;
using System.Text;
using CSharpClassLibraryTemplate;

namespace CSharpClassLibrary
{
    public class CSharpClass : Template // Inherits the template
    {
        public string NonTemplateProperty;

        string mstrMyProperty; // Local variable to hold the property value

        public override string MyProperty
        {
            get
            {
                return mstrMyProperty;
            }
            set
            {
                mstrMyProperty = value;
            }
        }

        public override bool PublicFunction(string MyString)
        {
            return true;
        }

        public override void PublicSub(string MyString)
        {
            
        }
    }
}
