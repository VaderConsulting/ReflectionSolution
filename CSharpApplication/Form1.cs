using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CSharpClassLibraryTemplate;

namespace CSharpApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CSharpClassLibrary.CSharpClass NewClass = new CSharpClassLibrary.CSharpClass();
            
            NewClass.NonTemplateProperty = "Hello World";
            NewClass.MyProperty = "Hello World";

            bool Result = NewClass.PublicFunction("Any string");
            
            CSharpClassLibraryTemplate.Enumeration.MyEnum LocalVariable;

            LocalVariable = CSharpClassLibraryTemplate.Enumeration.MyEnum.MyInteger;

            LocalVariable++;

            // Assembly - Reflections

            string sAssemblyName = GetValidAssembly(args);
            Assembly assem = Assembly.LoadFrom(sAssemblyName);

            Type[] types = assem.GetTypes();

            foreach (Type t in types)
            {
                try
                {
                    Console.WriteLine("Type information for:" + t.FullName);
                    Console.WriteLine("\tBase class = " + t.BaseType.FullName);
                    Console.WriteLine("\tIs Class = " + t.IsClass);
                    Console.WriteLine("\tIs Enum = " + t.IsEnum);
                    Console.WriteLine("\tAttributes = " + t.Attributes);
                }
                catch (System.NullReferenceException)
                {
                    Console.WriteLine("Error msg");
                }
            }

        }

        private static string GetValidAssembly(string[] strAssembly)
        {
            string strAssemblyName;

            if (0 == strAssembly.Length)
            {
                Process pr = Process.GetCurrentProcess();
                strAssemblyName = pr.ProcessName + ".exe";
            }
            else
            {
                strAssemblyName = sAssem[0];
            }
            return strAssemblyName;
        }


    }
}
