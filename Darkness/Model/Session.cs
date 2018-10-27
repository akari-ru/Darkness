using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darkness.Model
{
    public class Session
    {
        #region Singleton
        /// <summary>
        /// There can only be one Session active per application
        /// </summary>
        static Session _singleton;
        #endregion

        #region Session Meta Fields
        string _sessionID;
        DateTime _startDateTime;
        DateTime _endDateTime;    // Draft - does this make sense ? maybe if we inspect previous sessions ..
        object _user;           // Draft
        #endregion

        #region Fields
        object _project;        // Draft
        #endregion

        #region Constructors
        /// <summary>
        /// Making the default constructor private to ensure Singleton.
        /// </summary>
        private Session()
        {
            _startDateTime = DateTime.Now;
        }
        #endregion

        #region Singlton
        public static Session Instance
        {
            get
            {
                if (_singleton == null)
                    _singleton = new Session();
                return _singleton;
            }
        }

        public Session GetInstance() { return Instance; }
        #endregion

        #region Session Methods
        public void RestorePreviousSession(string identifier)
        {
            throw new NotImplementedException();
        }

        public void SaveSession(string identifier)
        {
            throw new NotImplementedException();
        }

        public void LoadSession(string identifier)
        {
            throw new NotImplementedException();
        }

        // Draft
        public void SwitchSesion()
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
