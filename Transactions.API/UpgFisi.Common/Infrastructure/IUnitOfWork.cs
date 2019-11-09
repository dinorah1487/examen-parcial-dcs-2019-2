using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace UpgFisi.Common.Infrastructure
{
    interface IUnitOfWork
    {
        public interface IUnitOfWork
        {
            bool BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted);
            void Commit(bool commit);
            void Rollback(bool rollback);
        }
    }
}
