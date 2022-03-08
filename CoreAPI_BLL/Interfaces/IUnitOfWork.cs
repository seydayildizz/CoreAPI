using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAPI_BLL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //UNİTOFWORK içerisinde kaç tane tablo varsa o kadar property eklenir
        IAssignmentRepository AssignmentRepository { get; }
    }
}
