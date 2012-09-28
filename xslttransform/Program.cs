using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.Xml;

namespace xslttransform
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(@"
-
XSLT transformer
Author: sre
Date: 28th Sept 2012
-
");
                var xml = "scratch.xml";
                var xsl = "scratch.xsl";
                var html = "scratch.html";

                if (args.Length == 1)
                {
                    xml = args[0] + ".xml";
                    xsl = args[0] + ".xsl";
                    html = args[0] + ".html";

                }
                if (args.Length == 2)
                {
                    xml = args[0];
                    xsl = args[1];

                }
                if (args.Length == 2)
                {
                    xml = args[0];
                    xsl = args[1];
                    html = args[2];
                }

                var myXslTrans = new XslCompiledTransform();
                myXslTrans.Load(xsl);
                myXslTrans.Transform(xml, html);
                Console.WriteLine("Success");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.StackTrace);
                
            }
            Console.WriteLine(@"
-
");
        }
    }
}
