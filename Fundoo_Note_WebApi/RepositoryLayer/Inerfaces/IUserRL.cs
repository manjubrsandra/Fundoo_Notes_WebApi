﻿using DatabaseLayer.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Inerfaces
{
    public interface IUserRL
    {
        public void AddUser(UserPostModel userPostModel);
    }
}
