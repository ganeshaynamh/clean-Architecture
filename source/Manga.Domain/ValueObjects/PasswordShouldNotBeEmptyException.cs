using System;
using System.Runtime.Serialization;

namespace Manga.Domain.ValueObjects
{
  
    public sealed class PasswordShouldNotBeEmptyException : DomainException
    {
        internal PasswordShouldNotBeEmptyException(string message) : base(message)
        {
        }

    }
}