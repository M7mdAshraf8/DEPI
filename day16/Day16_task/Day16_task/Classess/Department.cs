using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_task.Classess
{
    internal class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }

        public override string ToString()
        {
            return $"{DeptId} - {DeptName}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Department other)
            {
                return this.DeptId == other.DeptId &&
                       this.DeptName == other.DeptName;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(DeptId, DeptName);
        }
    }
}
