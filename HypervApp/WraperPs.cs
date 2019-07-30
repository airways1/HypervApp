using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading.Tasks;


namespace HypervApp
{
    static public class WraperPs
    {
        static Runspace runspace;
        static public void end_session()
        {
            runspace.Close();
        }
        static public void loadUtils()
        {
            string FileName = @".\vmmodule.ps1";
            if (System.IO.File.Exists(FileName))
            {
                WraperPs.RunScript(@". "+FileName);
            }


        }
        static public void reset_session()
        {
            runspace.ResetRunspaceState();
        }
        static public void init_session()
        {
            runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            
            loadUtils();
        }


        static public string RunScript(string scriptText)
        {
            
            // create a pipeline and feed it the script text
            Pipeline pipeline = runspace.CreatePipeline();
            pipeline.Commands.AddScript(scriptText);

            //  nicely formatted strings
            pipeline.Commands.Add("Out-String");

            // execute the script
            Collection<PSObject> results = pipeline.Invoke();

            StringBuilder list = new StringBuilder();
            foreach (PSObject obj in results)
            {
                list.AppendLine(obj.ToString());
            }

            return list.ToString();
        }


    }
}
