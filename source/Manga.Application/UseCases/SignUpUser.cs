using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Manga.Application.Boundaries.SignUpUser;
using Manga.Domain;

namespace Manga.Application.UseCases
{
    public sealed class SignUpUser : IUseCase
    {
        private readonly IEntitiesFactory _entityFactory;
        private readonly IOutputHandler _outputHandler;

        public SignUpUser(IEntitiesFactory entityFactory,IOutputHandler outputHandler)
        {
            _entityFactory = entityFactory;
            _outputHandler = outputHandler;
        }
        public Task Execute(Input input)
        {
            if (input == null)
            {
                _outputHandler.Error("Input is null.");
                return;
            }
          
            //throw new NotImplementedException();
        }
    }
}
