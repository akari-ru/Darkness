using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Linq;

namespace Darkness.Model.TreeGraphZone
{
    class TreeModel
    {
        XDocument _xdocument;

        public TreeModel(string uri)
        {
            _xdocument = XDocument.Load(uri);
        }
    }
}
