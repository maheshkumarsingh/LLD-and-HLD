using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot.Models
{
    public class BaseModel
    {
        private int _id;
        private DateTime _createdDateTime;
        private DateTime? _updatedDateTime;

        //public BaseModel(int id)
        //{
        //    _id = id;
        //    _createdDateTime = DateTime.Now;
        //}

        public int Id { get => _id; set => _id = value; }
        public DateTime CreatedDateTime { get => _createdDateTime; set => _createdDateTime = value; }
        public DateTime? UpdatedDateTime { get => _updatedDateTime; set => _updatedDateTime = value; }

    }
}
