using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Aspose.Cells;
namespace Kiosk.App;
using Newtonsoft.Json;

public class Report {
    public void Run() {
        var dummyJson = new {
            title="question 1", answer_1= "YES", answer_2= "NO"
        };

        string jsondata=JsonConvert.SerializeObject(dummyJson);
        Console.WriteLine("Dotnet worksdsddddd!");
        // var workbook = new Workbook(jsondata);
        // workbook.Save("s.html");
    }
}