using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class04_OCP.Services
{
    public interface IFileManager
    {
        void ReadFile();
        void WriteFile();
    }
}
