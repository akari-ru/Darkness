using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Darkness.Model;

namespace Darkness.UI.ViewModel
{
    public class SessionViewModel
    {
        #region Field
        Session _session;
        #endregion

        #region Properties
        public Session Session => _session;
        #endregion

        #region Constructors
        public SessionViewModel(Session session)
        {
            _session = session ?? throw new ArgumentNullException();
        }
        #endregion
    }
}
