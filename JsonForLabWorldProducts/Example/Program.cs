using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JsonForLabWorldProducts;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is what the server should do within it's own code:

            ServerAnswerAsData serverAnswerOnServer = CreateAServerAnswerWithSomeContent();

          


            // this is what the function of the libary that would be called by the server to translate the "ServerAnswerAsData" into an json-string:
            JsonTranslator translator = new JsonTranslator();
            string jsonString = translator.CreateServerAnswer(serverAnswerOnServer.combinedListOfAllModules());

            // Now the json-string would be sent to the client.
            Console.WriteLine(jsonString);

            Console.ReadKey();
           // Console.Clear();
            // This is what the client would call:
            ServerAnswerAsData serverAnswerOnClient = translator.ServerAnswerToData(jsonString);

            // Question is: 
            //          Is the serverAnswerOnClient always the same as the serverAnswerOnServer? 
            //          And: are there ways to break the Library?
            //Console.WriteLine(serverAnswerOnServer);
            //Console.WriteLine(serverAnswerOnClient);
           // Console.WriteLine(serverAnswerOnServer == serverAnswerOnClient);
           // Console.WriteLine(serverAnswerOnServer.Equals(serverAnswerOnClient));
            //Console.WriteLine(Object.ReferenceEquals(serverAnswerOnServer, serverAnswerOnClient));
           // Console.WriteLine(Object.Equals(serverAnswerOnServer, serverAnswerOnClient));


           
           // Console.ReadKey();
           // Console.Clear();
          //  string jsonString2 = translator.CreateServerAnswer(serverAnswerOnClient.combinedListOfAllModules());
           // Console.WriteLine(jsonString2==jsonString);
          //  Console.WriteLine(jsonString2.Equals(jsonString));
           // Console.ReadKey();
        }


        /// <summary>
        /// This function creates a ServerAnswerAsData-Object. 
        /// Usually, the server would do this part 
        /// (Creating a ServerAnswerAsData-Object and filling it with the server's Modules).
        /// </summary>
        /// <returns></returns>
        static public ServerAnswerAsData CreateAServerAnswerWithSomeContent()
        {      
            ModuleDescriptionDouble moduleDescriptionA = new ModuleDescriptionDouble();
            ModuleDescriptionDouble moduleDescriptionz = new ModuleDescriptionDouble();
            ModuleDescriptionDouble moduleDescriptionB = new ModuleDescriptionDouble();
            ModuleDescriptionText moduleDescriptionC = new ModuleDescriptionText();
            ModuleDescriptionPushButton moduleDescriptionD = new ModuleDescriptionPushButton();
            object moduleWithoutDescription = new object();
            String tempString = null;
            int tempInt = 123;
            moduleDescriptionA.ModuleName = "Module A";
            moduleDescriptionA.ModuleId = 1234;
            moduleDescriptionA.ModuleShownUnit = "kg/m";
           

            moduleDescriptionz.ModuleName = "Module A";
            moduleDescriptionz.ModuleId = 1234;
            moduleDescriptionz.ModuleShownUnit = "kg/m";

            moduleDescriptionB.ModuleName = "Module B";
            moduleDescriptionB.ModuleId = 1234768682;
            moduleDescriptionB.ModuleShownUnit = "V";
            moduleDescriptionB.ModuleShownValue = 123;
            moduleDescriptionB.PreferedVisualisation = PreferedVisualisation.graph;

            moduleDescriptionC.ModuleName = "Module C";
            moduleDescriptionC.ModuleId = 12343; 
            moduleDescriptionC.Value = "ExampleText,ExampleText, ExampleText.";
            moduleDescriptionC.PreferedVisualisation = PreferedVisualisation.text;

            moduleDescriptionD.ModuleName = "Module D";
            moduleDescriptionD.ModuleId = 12344;
            moduleDescriptionD.PreferedVisualisation = PreferedVisualisation.pushButton;
            

            ServerAnswerAsData serverAnswer = new ServerAnswerAsData();
            serverAnswer.ModulesDouble.Add(moduleDescriptionA);
            serverAnswer.ModulesDouble.Add(moduleDescriptionz);
            serverAnswer.ModulesDouble.Add(moduleDescriptionB);
            serverAnswer.ModulesText.Add(moduleDescriptionC);
            serverAnswer.ModulesPushButton.Add(moduleDescriptionD);

            return serverAnswer;


        }

    }
}
