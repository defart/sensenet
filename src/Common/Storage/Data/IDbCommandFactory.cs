﻿using System.Data.Common;

namespace SenseNet.Common.Storage.Data
{
    public interface IDbCommandFactory
    {
        DbConnection CreateConnection();
        DbCommand CreateCommand();
        DbParameter CreateParameter();
    }
}