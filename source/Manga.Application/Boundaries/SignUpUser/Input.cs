using Manga.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manga.Application.Boundaries.SignUpUser
{
    public sealed class Input
    {
        public UserName UserName { get;}
        public Password Password { get; }
        public Input(UserName userName, Password password)
        {
            UserName = userName;
            Password = password;
        }
    }
}
