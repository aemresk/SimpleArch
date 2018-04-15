using System.Collections.Generic;

namespace Zandeross.Domain
{
    public sealed class PersonalDataService  :BaseDataServices<Personal>
    {
        public Personal PersonalGetData()
        {
            string query = " SELECT * FROM Personal where id=1";
            return GetData(query);
        }
        public List<Personal> PersonalGetDataList()
        {
            string query = "select * from Personal";
            return GetDataList(query);
        }

        public Personal GetPersonalByIdTest(Personal p)
        {
            string query = "select * from Personal where id =@Id";
            return GetPersonalById(query);

        }
        public int InsertCommand(Personal p)
        {
            string query = "INSERT INTO Personal VALUES (@Name,@Lastname)";
            return ExecuteCommandText(query, p);
        }
        public int InsertCommandScalar(Personal p)
        {
            // return inserted row id
            string query = "INSERT INTO Personal VALUES (@Name,@Lastname) Select Cast (scope_identity() as int)";
            return ExecuteCommandScalar(query, p);
        }

        public int FastInsert(Personal p)
        {
            return Insert(p);
        }

    }
}
