using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.FastCrud;

namespace Zandeross.Domain
{
    public abstract class BaseDataServices<T> where T : BaseDataEntities
    {
        readonly string connectionString = "Data Source=.;Initial Catalog=zanderossMimari;Integrated Security=True";
        protected IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }
        protected T GetData(string query, object param = null)
        {
            return Connection.QuerySingleOrDefault<T>(query, param);
        }
        protected T GetPersonalById(string query, object param = null)
        {
            return Connection.QuerySingleOrDefault<T>(query, param);
        }
        protected List<T> GetDataList(string query, object param = null)
        {
            return Connection.Query<T>(query, param).ToList();
        }
        protected int ExecuteCommandText(string query, object param = null)
        {
            return Connection.Execute(query, param, commandType: CommandType.Text); // CRUD
        }
        protected int ExecuteCommandScalar(string query, object param = null)  
        {
            return Connection.ExecuteScalar<int>(query, param, commandType: CommandType.Text);
        }
        protected List<T> ExecuteCommandProcedure(string query, object param = null)   // For stored procedures
        {
            return Connection.Query<T>(query, param, commandType: CommandType.Text).ToList();
        }
        //FastCRUD 
        protected int Insert(T item)
        {
            Connection.Insert<T>(item);
            return item.Id;
        }
        protected bool Update(T item)
        {
            return Connection.Update<T>(item);
        }
        protected bool Delete(T item)
        {
            return Connection.Delete<T>(item);
        }
    }
}
