using Dapper;
using DataManagement.Entities;
using Dommel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using static System.Data.CommandType;

namespace DataManagement.Repository
{
    /*
     * This is the implementation of the generic repository with Dapper and Dommel
     */
    public class UserRepositoryDapDom : BaseRepository, IRepository<User>
    {
        public bool Add(User entity)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    var id = conn.Insert<User>(entity);
                    // or var id = conn.Insert(entity);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<User> Get()
        {
            IList<User> customerList = new List<User>();
            using (var conn = new SqlConnection(connectionString))
            {
                customerList = conn.GetAll<User>().ToList();
            }

            return customerList;
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        bool IRepository<User>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        bool IRepository<User>.Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
