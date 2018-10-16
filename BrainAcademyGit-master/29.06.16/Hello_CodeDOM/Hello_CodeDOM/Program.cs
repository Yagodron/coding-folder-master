using System;

using System.CodeDom;
using System.CodeDom.Compiler;
using System.Reflection;
using Microsoft.CSharp;
using Microsoft.VisualBasic;
using System.IO;

public class CodeDomSample
{
    CodeCompileUnit GenerateCSharpCode()
    {
        CodeCompileUnit compileUnit = new CodeCompileUnit();

        // Create a NameSpace - "namespace CodeDomSampleNS"
        //
        CodeNamespace codedomsamplenamespace = new CodeNamespace("CodeDomSampleNS");

        // Create using statement - "using System;"
        //
        CodeNamespaceImport firstimport = new CodeNamespaceImport("System");

        // Add the using statement to the namespace -
        // namespace CodeDomSampleNS {
        //      using System;
        //
        codedomsamplenamespace.Imports.Add(firstimport);

        // Create a type inside the namespace - public class CodeDomSample
        //
        CodeTypeDeclaration newType = new CodeTypeDeclaration("CodeDomSample");
        newType.Attributes = MemberAttributes.Public;

        // Create a Main method which will be entry point for the class
        // public static void Main
        //
        CodeEntryPointMethod mainmethod = new CodeEntryPointMethod();

        // Add an expression inside Main -
        //  Console.WriteLine("Inside Main ...");
        CodeMethodInvokeExpression mainexp1 = new CodeMethodInvokeExpression(
            new CodeTypeReferenceExpression("System.Console"),
            "WriteLine", new CodePrimitiveExpression("Inside Main ..."));
        mainmethod.Statements.Add(mainexp1);

        // Add another expression inside Main
        //  CodeDomSample cs = new CodeDomSample()
        //
        CodeStatement cs = new CodeVariableDeclarationStatement(typeof(CodeDomSample), "cs", new CodeObjectCreateExpression(new CodeTypeReference(typeof(CodeDomSample))));
        mainmethod.Statements.Add(cs);

        // At the end of the CodeStatements we should have constructed the following
        // public static void Main() {
        //      Console.WriteLine("Inside Main ...");
        //      CodeDomSample cs = new CodeDomSample();
        // }

        // Create a constructor for the CodeDomSample class
        // public CodeDomSample() { }
        //
        CodeConstructor constructor = new CodeConstructor();
        constructor.Attributes = MemberAttributes.Public;

        // Add an expression to the constructor
        // public CodeDomSample() { Comsole.WriteLine("Inside CodeDomSample Constructor ...");
        //
        CodeMethodInvokeExpression constructorexp = new CodeMethodInvokeExpression(new CodeTypeReferenceExpression("System.Console"), "WriteLine", new CodePrimitiveExpression("Inside CodeDomSample Constructor ..."));
        constructor.Statements.Add(constructorexp);

        // Add constructor and mainmethod to type
        //
        newType.Members.Add(constructor);
        newType.Members.Add(mainmethod);

        // Add the type to the namespace
        //
        codedomsamplenamespace.Types.Add(newType);

        // Add the NameSpace to the CodeCompileUnit
        //
        compileUnit.Namespaces.Add(codedomsamplenamespace);

        // Return the CompileUnit
        //
        return compileUnit;
    }

    // Generate code for a particular provider and compile it
    //
    void GenerateCode(CodeCompileUnit ccu, String codeprovider)
    {
        CompilerParameters cp = new CompilerParameters();
        String sourceFile;
        CompilerResults cr;

        switch (codeprovider)
        {
            case "CSHARP":
                // Generate Code from Compile Unit using CSharp code provider
                //
                CSharpCodeProvider csharpcodeprovider = new CSharpCodeProvider();

                if (csharpcodeprovider.FileExtension[0] == '.')
                {
                    sourceFile = "CSharpSample" + csharpcodeprovider.FileExtension;
                }
                else
                {
                    sourceFile = "CSharpSample." + csharpcodeprovider.FileExtension;
                }
                IndentedTextWriter tw1 = new IndentedTextWriter(new StreamWriter(sourceFile, false), "    ");
                csharpcodeprovider.GenerateCodeFromCompileUnit(ccu, tw1, new CodeGeneratorOptions());
                tw1.Close();
                cp.GenerateExecutable = true;
                cp.OutputAssembly = "CSharpSample.exe";
                cp.GenerateInMemory = false;
                cr = csharpcodeprovider.CompileAssemblyFromDom(cp, ccu);
                break;
            case "VBASIC":
                // Generate Code from Compile Unit using VB code provider
                //
                VBCodeProvider vbcodeprovider = new VBCodeProvider();
                if (vbcodeprovider.FileExtension[0] == '.')
                {
                    sourceFile = "VBSample" + vbcodeprovider.FileExtension;
                }
                else
                {
                    sourceFile = "VBSample." + vbcodeprovider.FileExtension;
                }
                IndentedTextWriter tw2 = new IndentedTextWriter(new StreamWriter(sourceFile, false), "    ");
                vbcodeprovider.GenerateCodeFromCompileUnit(ccu, tw2, new CodeGeneratorOptions());
                tw2.Close();
                cp.GenerateExecutable = true;
                cp.OutputAssembly = "VBSample.exe";
                cp.GenerateInMemory = false;
                cr = vbcodeprovider.CompileAssemblyFromDom(cp, ccu);
                break;
        }
        return;
    }

    // Another sample of hardcoding the code in a string and compiling it using the CSharpCodeProvider
    //
    public void CSharpCodeExample()
    {
        String sourcecode = "\nusing System;\npublic class Sample \n{\n    static void Main()\n    {\n        Console.WriteLine(\"This is a test\");\n    }\n}";
        CSharpCodeProvider provider = new CSharpCodeProvider();
        CompilerParameters cp = new CompilerParameters();
        cp.GenerateExecutable = true;
        cp.OutputAssembly = "Result.exe";
        cp.GenerateInMemory = false;
        CompilerResults cr = provider.CompileAssemblyFromSource(cp, sourcecode);
        if (cr.Errors.Count > 0)
        {
            Console.WriteLine("Errors building {0} into {1}", sourcecode, cr.PathToAssembly);
            foreach (CompilerError ce in cr.Errors)
            {
                Console.WriteLine("  {0}", ce.ToString());
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Source \n \n {0} \n \n \n built into {1} successfully.", sourcecode, cr.PathToAssembly);
        }
        return;
    }

    static public void Main()
    {
        CodeDomSample cds = new CodeDomSample();
        cds.CSharpCodeExample();
        CodeCompileUnit ccu = cds.GenerateCSharpCode();
        cds.GenerateCode(ccu, "CSHARP");
        cds.GenerateCode(ccu, "VBASIC");
    }
}
