using System.Data.Common;

namespace Susen.SourceProject.Services.DataAccess.Data
{
    public static class DataExtensions
    {
        public static T Get<T>(this DbDataReader reader, int column)
        {
            if (reader.IsDBNull(column)) return default(T);
            return (T)reader.GetValue(column);
        }

    }
}