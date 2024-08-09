﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application.bookshelf.Core
{
    public class User
    {

        // This property represents the unique identifier for the user in the database.

        public int Id { get; set; }

        // This property is typically used as a unique identifier for login purposes.

        public string Fullname { get; set; }

        // This property stores the user's password, which should be securely hashed before storage.

        public string Password { get; set; }

        // This stores the user's email address, used for communication or password recovery.

        public string EmailAddress { get; set; }

        // This list holds the roles assigned to the user, used for authorization.

        // It is initialized as a new list of strings, meaning it starts empty but ready to be added to. Inferences

        public string Roles { get; set; }
    }
}