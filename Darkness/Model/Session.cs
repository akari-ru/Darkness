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
        private static Session _singleton;
        #endregion

        #region Session Meta Fields
        private string _sessionID = "defaultSession";
        private DateTime _startDateTime;
        private DateTime _endDateTime = DateTime.MinValue;      // Draft - does this make sense ? maybe if we inspect previous sessions .. session persistance ..
        private object _user = null;                            // Draft
        #endregion

        #region Fields
        private object _project = null;                         // Draft
        #endregion

        #region Properties
        public string SessionID => _sessionID;
        #endregion

        #region Constructors
        /// <summary>
        /// Making the default constructor private to ensure Singleton.
        /// </summary>
        private Session()
        {
            _startDateTime = DateTime.Now;
            Console.WriteLine(ToString());
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

        #region object Overrides
        public override string ToString()
        {
            string ret = _sessionID + "{\n";
            ret += "\tstart:\t" + _startDateTime.ToLongDateString() + " - " + _startDateTime.ToLongTimeString() + "\n";
            ret += "\tend:\t" + _endDateTime.ToLongDateString() + " - " + _endDateTime.ToLongTimeString() + "\n";
            ret += "\tuser:\t" + _user?.ToString() + "\n";
            ret += "\tproject:\t" + _project?.ToString() + "\n";
            ret += "}\n";
            return ret;
        }
        #endregion
    }
}
