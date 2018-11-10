using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darkness.Model.CodeGenerator.CSharp
{
    class CSharpFile : CSharpObject
    {
        public override void Add(CSharpObject obj)
        {
            throw new NotImplementedException();
        }

        #region CodeGens
        public override string RenderCode()
        {
            var code = "";
            foreach (var child in _children) code += child.RenderCode();
            return code;
        }
        #endregion
    }
}
