using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BassPlayerApp
{
    class AudioList
    {
        public static List<string> audioFilesList = new List<string>();
        public static int CurrentTrackNumber;
        public static string GetFileName(string filePath)
        {
            string[] tmp = filePath.Split('\\');
            return tmp[tmp.Length - 1];
        }
    }
}
