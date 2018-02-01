using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LitJson;
using JsonForLabWorldProducts;


namespace Example
{
    class UnitTestsForLibrary
    {
        ModuleDescriptionDouble moduleDescriptionA;
        ModuleDescriptionDouble moduleDescriptionB;
        ModuleDescriptionText moduleDescriptionC;
        ModuleDescriptionPushButton moduleDescriptionD;
        ServerAnswerAsData serverAnswerOnServer;
        ServerAnswerAsData serverAnswerOnClient;
        JsonTranslator translator;
        String jsonString;


        /*
         * Initializer - [One Time Initializing Objects]
         */
        [OneTimeSetUp()]
        public void Initializing_Modules_Object()
        {   
            moduleDescriptionA = new ModuleDescriptionDouble();
            moduleDescriptionB = new ModuleDescriptionDouble();
            moduleDescriptionC = new ModuleDescriptionText();
            moduleDescriptionD = new ModuleDescriptionPushButton();
            serverAnswerOnServer = new ServerAnswerAsData();
            serverAnswerOnClient = new ServerAnswerAsData();
            translator = new JsonTranslator();
            jsonString = null;
        }

        /*
         * Test - [Test with the valid/invalid input data that library provides an valid
         * Object-Type "ServerAnswerAsData" successfully.]
         */
        [Test()]
        public void Test_01()
        {
            
            moduleDescriptionA.ModuleName = "Module A";
            moduleDescriptionA.ModuleId = 1234;
            moduleDescriptionA.ModuleShownUnit = "kg/m";

            moduleDescriptionB.ModuleName = "Module B";
            moduleDescriptionB.ModuleId = 1234768682;
            moduleDescriptionB.ModuleShownUnit = "V";
            moduleDescriptionB.ModuleShownValue = 123;
            moduleDescriptionB.PreferedVisualisation = PreferedVisualisation.graph;

            moduleDescriptionC.ModuleName = "Module \\C";
            moduleDescriptionC.ModuleId = 12343;
            moduleDescriptionC.Value = "ExampleText,ExampleText, ExampleText.";
            moduleDescriptionC.PreferedVisualisation = PreferedVisualisation.text;

            moduleDescriptionD.ModuleName = "Module D";
            moduleDescriptionD.ModuleId = 12344;
            moduleDescriptionD.PreferedVisualisation = PreferedVisualisation.pushButton;

            serverAnswerOnServer.ModulesDouble.Add(moduleDescriptionA);
            serverAnswerOnServer.ModulesDouble.Add(moduleDescriptionB);
            serverAnswerOnServer.ModulesText.Add(moduleDescriptionC);
            serverAnswerOnServer.ModulesPushButton.Add(moduleDescriptionD);

            
            
            Assert.IsTrue(serverAnswerOnServer is ServerAnswerAsData);
            
        }

        /*
        * Test - [Test that librry translates a "ServerAnswerAsData"-Object into a valid JSON-string
        * successfully.]
        */
        [Test()]
        public void Test_02()
        {
            
           jsonString = translator.CreateServerAnswer(serverAnswerOnServer.combinedListOfAllModules());
            Assert.IsTrue(jsonString is String);
        }


        /*
        * Test - [Test that library translates the JSON-string back into a "ServerAnswerAsData"-Object successfully.]
        */
        [Test()]
        public void Test_03()
        {
            serverAnswerOnClient = translator.ServerAnswerToData(jsonString);
            Assert.IsTrue(serverAnswerOnClient is ServerAnswerAsData);
        }


        /*
         *  - [Resetting All Objects]
         */
        [OneTimeTearDown()]
        public void take_screenshot_on_failure()
        {
            moduleDescriptionA = null;
            moduleDescriptionB = null;
            moduleDescriptionC = null;
            moduleDescriptionD = null;
            serverAnswerOnClient = null;
            serverAnswerOnServer = null;
            translator = null;
            jsonString = null;

        }
    }
}
