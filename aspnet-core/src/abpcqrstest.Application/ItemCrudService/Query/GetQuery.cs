using Abp.Domain.Repositories;
using abpcqrstest.ItemCrudService.Dto;
using abpcqrstest.Items;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace abpcqrstest.ItemCrudService.Query
{
    public class GetQuery : IRequest<Dto.itemOutputDto>
    {
        public int Id { get; set; }
    }

    public class Handler : IRequestHandler<GetQuery, Dto.itemOutputDto>
    {
        private readonly IRepository<Item> _repository;

        public Handler(IRepository<Item> repository)
        {
            _repository=repository;
        }

        public async Task<itemOutputDto> Handle(GetQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var response = _repository.Get(request.Id);
                return new itemOutputDto { Name = response.Name };
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
