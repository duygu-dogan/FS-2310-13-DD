﻿namespace MiniShop.Shared.ViewModels.IdentityModels
{
    public class DeleteUserViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public List<AssignRoleViewModel> Roles { get; set; }
    }
}
