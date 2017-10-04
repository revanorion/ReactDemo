using AutoMapper;
using InventoryManager.Data.Configuration;
using InventoryManager.Data.Context;
using InventoryManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace InventoryManager.Data.Repositories
{
    public class InventoryManagerRepository : IRepository
    {
        //private readonly InventoryManagerContext db = new InventoryManagerContext();
        private readonly InventoryManagerContext db = new InventoryManagerContext();
        private readonly IMapper mapper;
        private IEnumerable<object> trackedEntities = new List<object>();

        // Since the data layer makes use of DTOs, the DTOs do not automatically get updated with the primary key
        // value when saving a new record to the database. For cases where the primary key value is needed following
        // a save we are using the ITrackable interface and saving the Id value(s) in TrackedIds.
        public List<int> TrackedIds { get; set; }

        // UserSeq is used when saving UserSeqEnteredBy, UserSeqModifiedBy, etc. It should be set after the repository
        // is injected.
        public int? UserSeq { get; set; }

        public InventoryManagerRepository()
        {
            AutoMapperConfiguration.Configure();
            mapper = AutoMapperConfiguration.Mapper;
            TrackedIds = new List<int>();
        }

        public InventoryManagerRepository(int? userSeq)
        {
            AutoMapperConfiguration.Configure();
            mapper = AutoMapperConfiguration.Mapper;
            TrackedIds = new List<int>();
            UserSeq = userSeq;
        }

        public virtual void Add<T>(T dto) where T : class
        {
            var entityType = GetMappedType<T>();
            var entry = mapper.Map(dto, typeof(T), entityType);
            db.Set(entityType).Add(entry);
        }

        public void Add<T>(IEnumerable<T> dtos) where T : class
        {
            var entityType = GetMappedType<T>();
            var entities = dtos.Select(dto => mapper.Map(dto, typeof(T), entityType));
            db.Set(entityType).AddRange(entities);
        }

        public virtual void Update<T>(T dto) where T : class
        {
            var entityType = GetMappedType<T>();
            var entry = mapper.Map(dto, typeof(T), entityType);


            var trackedEntity = entry as ITrackable;
            var ienum = db.Set(entityType).Local.Cast<ITrackable>();
            if (trackedEntity == null || ienum.Count(x => trackedEntity != null && x.Id == trackedEntity.Id) == 0)
            {
                db.Set(entityType).Attach(entry);
                db.Entry(entry).State = EntityState.Modified;
            }
            else
            {
                var contextEntity = ienum.SingleOrDefault(x => x.GetType() == entry.GetType() && x.Id == trackedEntity.Id);
                if (contextEntity != null && contextEntity as Request != null && entry as Request != null)
                {
                    var request = db.Set<Request>().Local.First(x => x.RequestSeq == (entry as Request).RequestSeq);
                    mapper.Map((entry as Request), request);
                }
                else {
                    db.Set(entityType).Attach(entry);
                    db.Entry(entry).State = EntityState.Modified;
                }
            }
        }

        public void Detach<T>() where T : class
        {
            var entityType = GetMappedType<T>();

            var locals = db.Set(entityType);

            foreach (var local in locals)
            {
                db.Entry(local).State = EntityState.Detached;
            }
        }

        public virtual void Delete<T>(T dto) where T : class
        {
            var entityType = GetMappedType<T>();
            var entry = mapper.Map(dto, typeof(T), entityType);
            db.Entry(entry).State = EntityState.Deleted;
            db.Set(entityType).Remove(entry);
        }

        public virtual void Delete<T>(Expression<Func<T, bool>> where) where T : class
        {
            var entityType = GetMappedType<T>();
            var dtos = GetSet(where).ToList();
            var entities = dtos.Select(dto => mapper.Map(dto, typeof(T), entityType));
            foreach (var obj in entities)
            {
                db.Entry(obj).State = EntityState.Deleted;
                db.Set(entityType).Remove(obj);
            }
        }

        public virtual T Get<T>(Expression<Func<T, bool>> where) where T : class
        {
            var entityType = GetMappedType<T>();
            return db.Set(entityType).ProjectToQueryable<T>(AutoMapperConfiguration.Provider).Where(where).FirstOrDefault();
        }

        public System.Data.Entity.Infrastructure.DbRawSqlQuery<T> SQLQuery<T>(string sql, params object[] parameters) where T : class
        {
            return db.Database.SqlQuery<T>(sql, parameters);
        }

        public virtual IQueryable<T> GetSet<T>() where T : class
        {
            var entityType = GetMappedType<T>();
            return db.Set(entityType).ProjectToQueryable<T>(AutoMapperConfiguration.Provider);
        }

        public virtual IQueryable<T> GetSet<T>(Expression<Func<T, bool>> where) where T : class
        {
            var entityType = GetMappedType<T>();
            return db.Set(entityType).ProjectToQueryable<T>(AutoMapperConfiguration.Provider).Where(where);
        }

        public void Commit()
        {
            TrackAddedEntities();
            SetLogValues();
            db.SaveChanges();
            SaveTrackableIds();
        }

        // Automatically handle date and user entered/changed. Entities that require this functionality must
        // implement the ITrackable interface.
        private void SetLogValues()
        {
            var addedTrackableEntities = db.ChangeTracker.Entries<ITrackable>()
                                                         .Where(x => x.State == EntityState.Added)
                                                         .Select(x => x.Entity);
            var modifiedTrackableEntities = db.ChangeTracker.Entries<ITrackable>()
                                                            .Where(x => x.State == EntityState.Modified)
                                                            .Select(x => x.Entity);
            var addedAuditableEntities = db.ChangeTracker.Entries<IAuditable>()
                                                         .Where(x => x.State == EntityState.Added)
                                                         .Select(x => x.Entity);

            var user = UserSeq;
            var now = DateTime.Now;

            foreach (var addedEntity in addedTrackableEntities)
            {
                addedEntity.DateEntered = now;
                addedEntity.UserSeqEnteredBy = user;
            }

            foreach (var modifiedEntity in modifiedTrackableEntities)
            {
                modifiedEntity.DateChanged = now;
                modifiedEntity.UserSeqChangedBy = user;
            }

            foreach (var addedEntity in addedAuditableEntities)
            {
                addedEntity.Timestamp = now;
            }
        }

        private void TrackAddedEntities()
        {
            TrackedIds.Clear();
            trackedEntities = db.ChangeTracker.Entries<ITrackable>()
                                              .Where(e => e.State == EntityState.Added)
                                              .Select(x => x.Entity).ToList();
        }

        private void SaveTrackableIds()
        {
            foreach (var trackedEntity in trackedEntities)
            {
                var entity = trackedEntity as ITrackable;
                if (entity != null)
                {
                    TrackedIds.Add(entity.Id);
                }
            }
        }

        private Type GetMappedType<T>()
        {
            var destination = AutoMapperConfiguration.Mapper.ConfigurationProvider.GetAllTypeMaps().First(m => m.SourceType == typeof(T) | m.DestinationType == typeof(T));
            //return destination.DestinationType;
            return destination.SourceType;
        }

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
