using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess.Repositories.AdoNet
{
    //public class AdoNetGenericRepository<TEntity> : IGenericRepository<TEntity>
    //{
    //    public List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate = null)
    //    {
    //        using (SqlConnection conn = new SqlConnection("server=LAB13-OGRETMEN\\SQLEXPRESS; Database=Northwnd; Trusted_Connection = true;"))
    //        {
    //            conn.Open();
    //            SqlCommand cmd = conn.CreateCommand();
    //            cmd.CommandText = "Select ProductId, p.CategoryId, ProductName, UnitPrice, UnitsInStock from Products p left join Categories c on p.CategoryID = c.CategoryID";
    //            var dr = cmd.ExecuteReader();
    //            var list = DataReaderMapToList<TEntity>(dr);
    //            return list;
    //        }
    //    }

    //    private static List<TEntity> DataReaderMapToList<TEntity>(IDataReader dr)
    //    {
    //        List<TEntity> list = new List<TEntity>();
    //        TEntity obj = default(TEntity);
    //        while (dr.Read())
    //        {
    //            obj = Activator.CreateInstance<TEntity>();
    //            foreach (PropertyInfo prop in obj.GetType().GetProperties())
    //            {
    //                if (!object.Equals(dr[prop.Name], DBNull.Value))
    //                {
    //                    prop.SetValue(obj, dr[prop.Name], null);
    //                }
    //            }
    //            list.Add(obj);
    //        }
    //        return list;
    //    }

    //}
}
