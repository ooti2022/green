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

// call Results.get_data
        var re = new Results();
        re.Run();
        //string jsondata = JsonConvert.SerializeObject(dummyJson);

        // ELham
        var workbook = new Workbook("path.json");
        workbook.Save("Output.html");

        
    }
}