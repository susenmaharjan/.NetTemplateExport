﻿using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Susen.ResultProject.Services.DataAccess.Abstract;
using Susen.ResultProject.Services.DataAccess.Interfaces;

namespace Susen.ResultProject.Services.DataAccess.Databases
{
    public class SqlDatabase : Database
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlDatabase"/> class.
        /// </summary>
        /// <param name="nameOrConnectionString">The name or connection string.</param>
        public SqlDatabase(string nameOrConnectionString, IUserContext userContext)
            : base(nameOrConnectionString, userContext)
        {
        }

        /// <summary>
        /// Gets the name of the provider.
        /// </summary>
        /// <value>
        /// The name of the provider.
        /// </value>
        protected override string ProviderName => "System.Data.SqlClient";

        /// <summary>
        /// Creates the data adapter. Must be overriden by the derived class
        /// </summary>
        /// <param name="cmd">The command.</param>
        /// <returns></returns>
        protected override DbDataAdapter CreateDataAdapter(DbCommand cmd)
        {
            return new SqlDataAdapter(cmd as SqlCommand);
        }

        public override DbParameter CreateTVPParameter(string name, DataTable value)
        {
            var typeName = value.TableName;
            if (string.IsNullOrWhiteSpace(typeName))
                throw new System.Exception("Please specify the name of table same as your TVP type name.");

            var parameter = new SqlParameter(name, value)
            {
                SqlDbType = SqlDbType.Structured,
                TypeName = typeName
            };
            return parameter;
        }
    }
}