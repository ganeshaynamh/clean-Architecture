using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manga.Application.Boundaries.SignUpUser;
using Microsoft.AspNetCore.Mvc;

namespace Manga.WebApi.UseCases.SignUpUser
{
    public sealed class Presenter : IOutputHandler
    {
        public IActionResult ViewModel { get; private set; }
        public void Error(string message)
        {
            throw new NotImplementedException();
        }

        public void Handle(Output output)
        {
            throw new NotImplementedException();
        }
    }
}
