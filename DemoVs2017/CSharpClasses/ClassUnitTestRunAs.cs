namespace DemoVs2017.CSharpClasses
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.System;
    using ApexSharpApi.ApexApi;
    using SObjects;

    public class ClassUnitTestRunAs
    {
        static void RunAsExample()
        {
            User newUser = Soql.query<User>("SELECT Id FROM User LIMIT 1");
            using (System.runAs(newUser))
            {
            }
        }
    }
}
