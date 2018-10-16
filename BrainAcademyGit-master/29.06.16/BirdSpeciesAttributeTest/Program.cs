using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

using BirdSpeciesLibrary;

namespace BirdSpeciesAttributeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BirdSpeciesLibrary");
            Console.WriteLine();
            ReflectAttr_late();
            ReflectAttr_early();
            
            Console.WriteLine("Press any key ...");
            Console.ReadLine();
        }

    private static void ReflectAttr_late()
    {
    try
    {
        Assembly asm = Assembly.Load("BirdSpeciesLibrary");

        ReflectAssmbly(asm);

        Type BirdSpecies = asm.GetType("BirdSpeciesLibrary.BirdSpeciesAttribute");
        PropertyInfo Prop_cl = BirdSpecies.GetProperty("Classification");
        Type[] types = asm.GetTypes();

        Console.WriteLine();
        Console.WriteLine("Late Binding");

            foreach (Type t in types)
            {
                object[] objs = t.GetCustomAttributes(BirdSpecies, false);
                foreach (object ob in objs)
                {
                Console.WriteLine("- {0}: {1}\n",
                    t.Name, Prop_cl.GetValue(ob, null));
                }
            }
    }
    catch (Exception ex)
    {
    Console.WriteLine(ex.Message);
    }
    }


        private static void ReflectAttr_early()
        {

            Console.WriteLine();
            Console.WriteLine("Early Binding");

            System.Reflection.MemberInfo info = typeof(Crow);
            object[] attributes = info.GetCustomAttributes(true);
            for (int i = 0; i < attributes.Length; i++)
            {
                System.Console.WriteLine(attributes[i]);
            }

            Console.WriteLine();
            Type tat = typeof(Crow);
            if (Attribute.IsDefined(tat, typeof(BirdSpeciesAttribute))) 
             {
                 var attributeValue = Attribute.GetCustomAttribute(tat, typeof(BirdSpeciesAttribute)) as BirdSpeciesAttribute;
                 Console.WriteLine("BirdSpeciesAttribute - {0}\n", attributeValue.Classification);
             }

             if (Attribute.IsDefined(tat, typeof(System.SerializableAttribute))) 
             {
                 var attributeValue = Attribute.GetCustomAttribute(tat, typeof(System.SerializableAttribute)) as System.SerializableAttribute;
                 Console.WriteLine("Serializable - {0}\n", attributeValue.TypeId);
             }

        }

        static void ReflectAssmbly(Assembly asm)
        {

            Console.WriteLine("Assembly:");
            Console.WriteLine("GAC: {0}", asm.GlobalAssemblyCache);
            Console.WriteLine("Name: {0}", asm.GetName().Name);
            Console.WriteLine("Version: {0}", asm.GetName().Version);
            Console.WriteLine("Culture: {0}",
              asm.GetName().CultureInfo.DisplayName);

            Type[] types = asm.GetTypes();
            Console.WriteLine();
            Console.WriteLine("Types:");
            foreach (var itm in types)
            {
                Console.WriteLine("Type: {0}", itm);
                ListMethod(itm);
            }
            Console.WriteLine();


        }

        #region ListMethods
        static void ListMethod(Type t)
        {
            Console.WriteLine();
            Console.WriteLine("Methods:");
            MethodInfo[] meth = t.GetMethods();
            foreach (MethodInfo me in meth)
            {
                string retVal = me.ReturnType.FullName;
                string prm = "( ";

                foreach (ParameterInfo pi in me.GetParameters())
                {
                    prm += string.Format("type "+ pi.ParameterType +" "+ pi.Name);
                }
                prm += " )";

                Console.WriteLine(" Full name "+ retVal+"."+ me.Name+ prm);
            }
            Console.WriteLine();
        }
        #endregion
    }
}
