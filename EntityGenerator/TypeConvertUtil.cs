using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityGenerator
{
    public static class TypeConvertUtil
    {


        public static string DbToEntity(string entityType)
        {
            if (entityType == null)
            {
                throw new ArgumentNullException();
            }

            if (entityType == "VARCHAR")
            {
                return "String";
            }

            if (entityType == "CHAR")
            {
                return "String";
            }

            if (entityType == "INTEGER")
            {
                return "int";
            }

            if (entityType == "TIMESTAMP")
            {
                return "java.sql.Timestamp";
            }

            throw new ArgumentException();
        }

    }

}
