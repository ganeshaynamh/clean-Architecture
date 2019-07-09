using System;
using System.Collections.Generic;
using System.Text;

namespace Manga.Domain.ValueObjects
{
    public sealed class Password : IEquatable<Password>
    {
        private string _text;
        private Password() { }

        public Password(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new PasswordShouldNotBeEmptyException("The 'UserName' field is required");

            _text = text;
        }
        public override string ToString()
        {
            return _text;
        }
        public bool Equals(Password other)
        {
            return this._text == other._text;
        }
    }
}
