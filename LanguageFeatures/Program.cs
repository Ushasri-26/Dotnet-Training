using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace LanguageFeatures

{

    internal class Program

    {

        static void Main(string[] args)

        {

            Features features = new Features();

            //features.NullableDemo();

            //features.GlobalNsDemo();

            //features.ExtensionDemo();

            //features.propertyDemo();

            //features.CollectionDemo();

            //Feature6 ob = new Feature6();
            //ob.staticdemo();
            //ob.autoinitdemo();
            //ob.dictionaryinitdemo();
            //ob.nameofdemo();
            //ob.ExceptionFilters();
            //ob.conditionalnull();
            //ob.Expressionbody();

            //TaskDemo t = new TaskDemo();
            //t.Method3();

            //Class2 ab = new Class2();
            ////ab.NamedoptionalDemo(y:50);//this is named parameter
            ////ab.NamedoptionalDemo();
            ////ab.CoVariance_Contravariance();
            //ab.dynamicDemo();
            
            TPLDemo ob = new TPLDemo();
            ob.Parellel();
            ob.TASKDEMO();
            Console.Read();


        }

    }

}

