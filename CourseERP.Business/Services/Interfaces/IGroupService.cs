using CourseERP.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseERP.Business.Services.Interfaces
{
    public interface IGroupService
    {
        void Create(Group group);
        List<Group> GetAll();
        Group GetGroup(int id);
        void Remove(int id);

    }
}
