using BusinessLayer.Interface;
using DatabaseLayer.User;
using RepositoryLayer.Inerfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    public class UserBL : IUserBL
    {
        IUserRL userRL;
        public UserBL(IUserRL userRL)
        {
            this.userRL=userRL;
        }

        public void AddUser(UserPostModel userPostModel)
        {
            try
            {
                userRL.AddUser(userPostModel);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
