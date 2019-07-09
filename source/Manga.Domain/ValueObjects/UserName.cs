using System;
using System.Collections.Generic;
using System.Text;

namespace Manga.Domain.ValueObjects
{
    public sealed class UserName : IEquatable<UserName>
    {
        private string _text;
        private UserName() { }

        public UserName(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new UserNameShouldNotBeEmptyException("The 'UserName' field is required");

            _text = text;
        }
        public override string ToString()
        {
            return _text;
        }
        public bool Equals(UserName other)
        {
            return this._text == other._text;
        }
    }
}
