using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouiCodeTest
{
    public class YouiFileProcessor : FileParser, IComparer 
    {
        private string _filePath = "";
        public string filePath { get; set; }

        public YouiFileProcessor(string filePath)
            : base(filePath)    
        {
            _filePath = filePath;
        }
        /// <summary>
        /// check for the file name here, 
        /// to compare whether the file is already proccessed or not
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Archive the file here
        /// </summary>
        public override void PostProcessFile()
        {
            throw new NotImplementedException();
        }
    }
}
