﻿using System.ComponentModel;

namespace PycApi.Base
{
    public class Role
    {
        public const string Admin = "admin";
        public const string Viewer = "viewer";
    }

    public enum RoleEnum
    {
        [Description(Role.Admin)]
        Admin = 1,

        [Description(Role.Viewer)]
        Viewer = 2
    }
}
