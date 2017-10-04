using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CodeTables.Data.Repositories
{
    public interface IRepository : IDisposable
    {
        void Add<T>(T dto) where T : class;
        void Update<T>(T dto) where T : class;
        void Detach<T>() where T : class;
        void Delete<T>(T dto) where T : class;
        void Delete<T>(Expression<Func<T, bool>> where) where T : class;
        T Get<T>(Expression<Func<T, bool>> where) where T : class;
        IQueryable<T> GetSet<T>() where T : class;
        IQueryable<T> GetSet<T>(Expression<Func<T, bool>> where) where T : class;
        //System.Data.Entity.Infrastructure.DbRawSqlQuery<T> SQLQuery<T>(string sql, params object[] parameters) where T : class;
        void Commit();
        List<int> TrackedIds { get; }
        int? UserSeq { get; set; }
    }
}