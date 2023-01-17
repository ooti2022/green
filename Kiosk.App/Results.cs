using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
namespace Kiosk.App;
using Newtonsoft.Json;
class Results {
    public void Run() {
        //var q = new JsonSerializer();
         var dummyJson = new {
            title="question 1", answer_1= "YES", answer_2= "NO"
        };

        string jsondata=JsonConvert.SerializeObject(dummyJson);
        Console.WriteLine("Dotnet worksdsddddd!");
        Console.WriteLine("Results");
    }
}