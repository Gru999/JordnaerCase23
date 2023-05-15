﻿using JordnærCase2023.Models;

namespace JordnærCase2023.Interfaces
{
    public interface IUserLoginService
    {
        public List<Member> GetAllUsers();

        public Member VerifyUser(string username, string password);
    }
}
