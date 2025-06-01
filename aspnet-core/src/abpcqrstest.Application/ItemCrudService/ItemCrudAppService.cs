using abpcqrstest.ItemCrudService.Command;
using abpcqrstest.ItemCrudService.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abpcqrstest.ItemCrudService
{
    public class ItemCrudAppService : IItemCrudAppService
    {
        private readonly IMediator _mediator;
        public ItemCrudAppService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task<itemOutputDto> Insert(Dto.itemInputDto itemInput)
        {
            var result = _mediator.Send(new ItemInputCommand { Name = itemInput.Name});

            return result;
        }
    }
}
