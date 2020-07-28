using System;
using System.Collections.Generic;
using System.Text;

namespace SadafStore.Core.CodeGenerator
{
    public class GeneratorCode
    {
        public static string GenerateGuidCode()
        {
            return Guid.NewGuid().ToString().Replace("-", "");
        }
    }
}
