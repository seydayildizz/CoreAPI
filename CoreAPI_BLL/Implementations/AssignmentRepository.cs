using CoreAPI_BLL.Interfaces;
using CoreAPI_DAL;
using CoreAPI_EL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAPI_BLL.Implementations
{
    public class AssignmentRepository:Repository<Assignment>,IAssignmentRepository
    {
        public AssignmentRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
