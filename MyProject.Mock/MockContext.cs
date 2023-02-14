using System;
using System.Collections.Generic;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;

namespace MyProject.Mock
{
    public class MockContext //: IContext
    {
        public List<Child> Children { get; set; }
        public List<User> Users { get ; set ; }
        public MockContext()
        {
            //Users = new List<User>();

            //Users.Add(new Role() { Id = 1, Name = "admin", Description = "Manages the website" });
            //Users.Add(new Role() { Id = 2, Name = "client", Description = "user of the website" });
            //Users.Add(new Role() { Id = 3, Name = "developer", Description = "Develops the website" });

            //Permissions = new List<Permission>();

            //Permissions.Add(new Permission() { Id = 1, Name = "VIEW_ALL", Description = "Can see all lists" });
            //Permissions.Add(new Permission() { Id = 2, Name = "ADD_ROLE", Description = "Can add role to the roles' list" });
            //Permissions.Add(new Permission() { Id = 3, Name = "DELETE_PERMISSION", Description = "Can delete permission from the permissions' list" });

            //Claims = new List<Claim>();

            /*Claims.Add(new Claim() { Id = 1, IdRole = 2, IdPermission = 2, Policy = ePolicy.Deny });
            Claims.Add(new Claim() { Id = 2, IdRole = 1, IdPermission = 1, Policy = ePolicy.Allow });
            Claims.Add(new Claim() { Id = 3, IdRole = 3, IdPermission = 3, Policy = ePolicy.Allow });*/
        }
    }
}
