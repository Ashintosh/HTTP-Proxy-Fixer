using System;
using System.IO;

namespace Aligner
{
    class Variables
    {
        public static string line;
        public static string newLine;
        public static string lineStarter = "http://";

        public static string SAVE_PATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ConvertedProxies.txt");
        public static string filePath;

        public static int lineCount = 0;
    }
}
