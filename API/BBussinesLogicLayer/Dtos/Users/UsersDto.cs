using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBussinesLogicLayer.Dtos.Users
{
    public record UsersDto
    {
        public int Id { get; init; }
        public string Name { get; init; }
    }
}
