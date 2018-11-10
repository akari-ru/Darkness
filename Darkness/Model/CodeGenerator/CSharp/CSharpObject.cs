using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darkness.Model.CodeGenerator.CSharp
{
    public abstract class CSharpObject
    {
        #region Fields
        protected List<CSharpObject> _children;
        #endregion

        #region CodeGens
        public abstract string RenderCode();
        #endregion

        #region Methods
        public abstract void Add(CSharpObject obj);
        #endregion
    }
}
