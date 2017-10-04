using CodeTables.Data.Context;
using CodeTables.Data.Entities;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace CodeTables.Data.Repositories
{
    public class CodeTablesRepository : IRepository
    {
        //private readonly CodeTablesContext db = new CodeTablesContext();
        private readonly CodeTablesContext db;
        private IEnumerable<object> trackedEntities = new List<object>();

        // Since the data layer makes use of DTOs, the DTOs do not automatically get updated with the primary key
        // value when saving a new record to the database. For cases where the primary key value is needed following
        // a save we are using the ITrackable interface and saving the Id value(s) in TrackedIds.
        public List<int> TrackedIds { get; set; }

        // UserSeq is used when saving UserSeqEnteredBy, UserSeqModifiedBy, etc. It should be set after the repository
        // is injected.
        public int? UserSeq { get; set; }

        public CodeTablesRepository()
        {
            db = new CodeTablesContext();
            TrackedIds = new List<int>();
        }

        public CodeTablesRepository(int? userSeq)
        {
            TrackedIds = new List<int>();
            UserSeq = userSeq;
        }

        public virtual void Add<T>(T entity) where T : class
        {
            db.Set<T>().Add(entity);
        }

        public void Add<T>(IEnumerable<T> entities) where T : class
        {
            db.Set<T>().AddRange(entities);
        }

        public virtual void Update<T>(T entity) where T : class
        {
            db.Set<T>().Attach(entity);
            db.Entry(entity).State = EntityState.Modified;
        }

        public void Detach<T>() where T : class
        {
            var locals = db.Set<T>();
            foreach (var local in locals)
            {
                db.Entry(local).State = EntityState.Detached;
            }
        }

        public virtual void Delete<T>(T entity) where T : class
        {
            db.Entry(entity).State = EntityState.Deleted;
            db.Set<T>().Remove(entity);
        }

        public virtual void Delete<T>(Expression<Func<T, bool>> where) where T : class
        {
            var entities = GetSet(where).ToList();
            foreach (var obj in entities)
            {
                db.Entry(obj).State = EntityState.Deleted;
                db.Set<T>().Remove(obj);
            }
        }

        public virtual T Get<T>(Expression<Func<T, bool>> where) where T : class
        {
            return db.Set<T>().Where(where).FirstOrDefault();
        }

        //public System.Data.Entity.Infrastructure.DbRawSqlQuery<T> SQLQuery<T>(string sql, params object[] parameters) where T : class
        //{
        //    return db.Database.SqlQuery<T>(sql, parameters);
        //}

        public virtual IQueryable<T> GetSet<T>() where T : class
        {
            return db.Set<T>().AsQueryable();
        }

        public virtual IQueryable<T> GetSet<T>(Expression<Func<T, bool>> where) where T : class
        {
            return db.Set<T>().Where(where);
        }

        public void Commit()
        {
            TrackAddedEntities();
            //SetLogValues();
            db.SaveChanges();
            //SaveTrackableIds();
        }

        //// Automatically handle date and user entered/changed. Entities that require this functionality must
        //// implement the ITrackable interface.
        //private void SetLogValues()
        //{
        //    var addedTrackableEntities = db.ChangeTracker.Entries<ITrackable>()
        //                                                 .Where(x => x.State == EntityState.Added)
        //                                                 .Select(x => x.Entity);
        //    var modifiedTrackableEntities = db.ChangeTracker.Entries<ITrackable>()
        //                                                    .Where(x => x.State == EntityState.Modified)
        //                                                    .Select(x => x.Entity);
        //    var addedAuditableEntities = db.ChangeTracker.Entries<IAuditable>()
        //                                                 .Where(x => x.State == EntityState.Added)
        //                                                 .Select(x => x.Entity);

        //    var user = UserSeq;
        //    var now = DateTime.Now;

        //    foreach (var addedEntity in addedTrackableEntities)
        //    {
        //        addedEntity.DateEntered = now;
        //        addedEntity.UserSeqEnteredBy = user;
        //    }

        //    foreach (var modifiedEntity in modifiedTrackableEntities)
        //    {
        //        modifiedEntity.DateChanged = now;
        //        modifiedEntity.UserSeqChangedBy = user;
        //    }

        //    foreach (var addedEntity in addedAuditableEntities)
        //    {
        //        addedEntity.Timestamp = now;
        //    }
        //}

        private void TrackAddedEntities()
        {
            TrackedIds.Clear();
            trackedEntities = db.ChangeTracker.Entries()
                                              .Where(e => e.State == EntityState.Added)
                                              .Select(x => x.Entity).ToList();
        }

        //private void SaveTrackableIds()
        //{
        //    foreach (var trackedEntity in trackedEntities)
        //    {
        //        var entity = trackedEntity as ITrackable;
        //        if (entity != null)
        //        {
        //            TrackedIds.Add(entity.Id);
        //        }
        //    }
        //}


        #region IDisposable

        public void Dispose()
        {
            this.Dispose(true);
        }
        bool _isDisposed = false;

        protected virtual void Dispose(bool isDisposing)
        {
            if (!_isDisposed)
            {
                if (isDisposing)
                {
                    // Clear down managed resources.

                    if (db != null)
                        db.Dispose();
                }

                _isDisposed = true;
            }
        }

        #endregion
    }
}
