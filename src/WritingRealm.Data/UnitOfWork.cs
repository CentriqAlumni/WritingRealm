using BoostNetwork.Data.Repositories;
using System;
using System.Data.Entity;

namespace BoostNetwork.Data
{
    public interface IUnitOfWork : IDisposable 
    {
        void Save();
    }

    public class UnitOfWork : IUnitOfWork
    {
        DbContext context = new DataContext();

        // Example:
        /*
		private LessonRepository _lessonRepository;
        public LessonRepository LessonRepository
        {
            get
            {
                if (this._lessonRepository == null)
                {
                    this._lessonRepository = new LessonRepository(context);
                }

                return _lessonRepository;
            }
        }
        */






        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}


