﻿using DbConnector.Adapter;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FinanceProject.Services
{
    public abstract class BaseService
    {
        public DbAdapter Adapter
        {
            get
            {
                return new DbAdapter(new SqlCommand(), new SqlConnection("Server = ERIKDIZON504C\\SQLEXPRESS; Database = FinanceProject; Trusted_Connection = True;"));
            }
        }
    }
}