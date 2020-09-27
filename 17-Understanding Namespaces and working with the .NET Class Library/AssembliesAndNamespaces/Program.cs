using System;
using System.IO;
using System.Net;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString("https://docs.microsoft.com/en-us/dotnet/api/system.net.webclient.downloadstring?view=netcore-3.1");
            File.WriteAllText(@"C:\Users\Admin\source\repos\bobtabor_C-fundamentals\17-Understanding Namespaces and working with the .NET Class Library\WriteText.txt", reply);

        }
    }
}
