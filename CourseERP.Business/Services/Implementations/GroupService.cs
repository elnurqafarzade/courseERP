using CourseERP.Business.Services.Interfaces;
using CourseERP.Core.Models;
using CourseERP.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseERP.Business.Services.Implementations
{
    public class GroupService : IGroupService
    {
        public void Create(Group group)
        {
            CourseERPDatabase.Groups.Add(group);

        }

        public Group GetGroup(int id)
        {
            var data = CourseERPDatabase.Groups.Find(x => x.Id == id);
            if (data is null)
            {
                throw new NullReferenceException("Group not found!");
            }
            return data;
        }

        public List<Group> GetAll()
        {
            return CourseERPDatabase.Groups;
        }

        public void Remove(int id)
        {
            var data = CourseERPDatabase.Groups.Find(x => x.Id == id);
            if (data is null)
            {
                throw new NullReferenceException("Group not found");


            }
            CourseERPDatabase.Groups.Remove(data);
        }
    }
}

