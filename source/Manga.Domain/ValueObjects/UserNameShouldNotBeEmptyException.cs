using System;
using System.Runtime.Serialization;

namespace Manga.Domain.ValueObjects
{
   
    public sealed class UserNameShouldNotBeEmptyException : DomainException
    {

        internal UserNameShouldNotBeEmptyException(string message) : base(message)
        {
        }
    }
}