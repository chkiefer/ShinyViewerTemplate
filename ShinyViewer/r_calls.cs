using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RDotNet;
using RDotNet.Devices;
using RDotNet.Dynamic;
using RDotNet.Internals;
using RDotNet.NativeLibrary;






namespace ShinyViewer
{
    class r_calls
    {
        REngine engine;

        public void initREngine()
        {
            //REngine.SetEnvironmentVariables("R-Portable/App/R-Portable/bin/i386", "R-Portable/App/R-Portable");
            engine = REngine.GetInstance();
            engine.Initialize();
        }


        public void initShinyApp()
        {
            engine.Evaluate("options(shiny.port = 5050)");
            engine.Evaluate("library(shinyApp)");
            engine.Evaluate("shinyAppGUI(launch.browser = FALSE)");  
        }

    }
}
