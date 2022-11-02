﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Utils
{
    public class Session
    {
        private Dictionary<string, object> _lstSessions = new Dictionary<string, object>();

        private void Add(string strKey, object value)
        {
            if (_lstSessions.ContainsKey(strKey))
            {
                _lstSessions[strKey] = value;
            }
            else
            {
                _lstSessions.Add(strKey, value);
            }
        }

        private object Get(string strKey)
        {
            if (_lstSessions.ContainsKey(strKey))
            {
                return _lstSessions[strKey];
            }
            else
            {
                return null;
            }
        }

        public object this[string strKey]
        {
            get { return Get(strKey); }
            set { Add(strKey, value); }
        }

        public void Clear()
        {
            _lstSessions.Clear(); // Delete Session
        }
    }
}
