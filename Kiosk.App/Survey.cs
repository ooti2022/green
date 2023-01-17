using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Kiosk.App;

class Survey {
    public void Run() {

        Read readobj = new Read();

        // Get question from Read object
        Dictionary<string, string[]> questionnaire = readobj.GetQuestion();
        Console.WriteLine("Survey");
        int questions = 1;
        int people = 1;

        Console.WriteLine("Number of people");
        people = Convert.ToInt32(Console.ReadLine());

        // for(nb of ppl)
            // for(nb of quest)
                // display question
                // diplay answers
                // get user interaction
                // store it in dictionary

        for(int p = 0; p < people; p++)
        {
            for(int q = 0; q < questions; q++)
            {
                Console.WriteLine(q);
            }
        }

        
    }
}