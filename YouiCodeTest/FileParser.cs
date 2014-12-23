using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouiCodeTest
{
    /// <summary>
    /// Class to process the file, Template pattern assumed to suit better 
    /// for the solution on 23/12/2014, can be changed later
    /// </summary>
    public abstract class FileParser : IFileBasicValidator
    {
        private string _filePath;
        private bool isPassedBasicValidation = false;

        public FileParser(string filePath)
        {
            _filePath = filePath;
        }

        public bool IsFileExists()
        {
            if (File.Exists(_filePath))
           {
               isPassedBasicValidation = true;
           }
           return isPassedBasicValidation;
        }

        public bool HasEmptyContent()
        {
            if(isPassedBasicValidation)
            {
                var content = File.ReadAllBytes(_filePath);

                if (content == null || content.Length == 0)
                    return true;
                else 
                    return false;
            }
            else
            {
                throw new Exception("Unable to process file, please check corretness of the file and existance");

            }
           
        }

        public bool HasInvalidTypes()
        {
            //logic goes here for no of colums and its type
            //configure the data type in XML
            //best to use XML schema defination
            throw new NotImplementedException();
        }

        ///Parse content using LinQ if the data set is small other wise 
        ///better go for looping to avoid performance issue
        ///appy some template methid here
        public void ProcessFile()
        {
            this.IsFileExists();
            this.HasEmptyContent();
            this.HasInvalidTypes();

        }
        /// <summary>
        /// do some archive
        /// </summary>
        public abstract void PostProcessFile();

    }
}
