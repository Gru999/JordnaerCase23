﻿using JordnærCase2023.Models;

namespace JordnærCase2023.Interfaces
{
    public interface IMemberService
    {
        Task<List<Member>> GetAllMembersAsync();
        Task<bool> CreateMemberAsync(Member member);
        Task<bool> UpdateMemberAsync(Member member, int memberID);
        Task<bool> DeleteMemberAsync(int memberID);
        Task<List<Member>> GetMembersByName(string memberName);
    }
}
