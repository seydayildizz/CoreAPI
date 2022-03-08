using CoreAPI_BLL.Interfaces;
using CoreAPI_DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAPI_BLL.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyContext _myContext;

        public IAssignmentRepository AssignmentRepository { get; private set; }

        public UnitOfWork(MyContext myContext)
        {
            _myContext = myContext;
            AssignmentRepository = new AssignmentRepository(_myContext);
            
        }
        public void Dispose()
        {
            _myContext.Dispose();
        }
    }
}
