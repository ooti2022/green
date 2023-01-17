using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
namespace Kiosk.App;
using Newtonsoft.Json;

class Results {
    public void Run() {
            var dummyJson = new {
            title="question 1", answer_1= "YES", number_1= 2, answer_2= "NO", number_2= 2, 
            };
            string jsondata=JsonConvert.SerializeObject(dummyJson);
            File.WriteAllText(@"path.txt", jsondata);
        }
        
    public void getResults(){
        
    }
}