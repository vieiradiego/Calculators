﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.DataBase
{
    public class Connection : IDbConnection
    {
        public string ConnectionString
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int ConnectionTimeout
        {
            get { throw new NotImplementedException(); }
        }

        public IDbCommand CreateCommand()
        {
            throw new NotImplementedException();
        }

        public string Database
        {
            get { throw new NotImplementedException(); }
        }
        
        public ConnectionState State
        {
            get { throw new NotImplementedException(); }
        }
        public IDbTransaction BeginTransaction(IsolationLevel il)
        {
            throw new NotImplementedException();
        }

        public IDbTransaction BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void ChangeDatabase(string databaseName)
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void Open()
        {
            throw new NotImplementedException();
        }
        
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
