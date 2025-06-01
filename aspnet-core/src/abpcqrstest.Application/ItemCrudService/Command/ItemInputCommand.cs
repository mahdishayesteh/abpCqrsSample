using Abp.Domain.Repositories;
using abpcqrstest.ItemCrudService.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace abpcqrstest.ItemCrudService.Command
{
    public class ItemInputCommand : IRequest<itemOutputDto>
    {
        public string Name { get; set; }
    }


    public class Handler : IRequestHandler<ItemInputCommand, itemOutputDto>
    {
        private readonly IRepository<Items.Item> _itemRepository;
        public Handler(IRepository<Items.Item> itemRepository)
        {
            _itemRepository = itemRepository;
        }
        public async Task<itemOutputDto> Handle(ItemInputCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _itemRepository.Insert(new Items.Item
                {
                    Name = request.Name
                });

                return new itemOutputDto { Name = result.Name };
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}
