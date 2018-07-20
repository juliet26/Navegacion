using System;
using System.Collections.Generic;
using System.Text;

namespace Navegacion.Services
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string fileName);
    }
}
