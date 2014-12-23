using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouiCodeTest
{
    public interface IFileBasicValidator
    {
        bool IsFileExists();
        bool HasEmptyContent();
        bool HasInvalidTypes();
    }
}
