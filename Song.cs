using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BassPlayerApp
{
    public class Song
    {
        public int Id { get; set; }
        public string FileLink { get; set; }
        // private string FileLink { get; set; }

        // public string fileLink
        // {
        //     get { return FileLink; }
        //     set { FileLink = value; }
        // }

        public Song() { }

        public Song(string fileLink)
        {
            this.FileLink = fileLink;
        }
    }
}
