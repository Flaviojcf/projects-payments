﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expert.Domain.Entities
{
    public class UserSkill(int idUser, int idSkill) : BaseEntity
    {
        public int IdUser { get; private set; } = idUser;

        public int IdSkill { get; private set; } = idSkill;
    }
}