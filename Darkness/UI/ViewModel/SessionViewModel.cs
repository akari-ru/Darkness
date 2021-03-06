﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Darkness.Model;

namespace Darkness.UI.ViewModel
{
    public class SessionViewModel : ViewModel
    {
        #region Field
        Session _session;
        #endregion

        #region Remove
        public CommonTableViewModel DataViewModel { get; } = new CommonTableViewModel();
        #endregion

        #region Bindable Properties
        public Session Session => _session;
        public string SessionID => _session.SessionID;
        #endregion

        #region Constructors
        public SessionViewModel(Session session)
        {
            _session = session ?? throw new ArgumentNullException();
        }
        #endregion
    }
}
