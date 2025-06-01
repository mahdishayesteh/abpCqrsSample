using Abp.Application.Services;
using abpcqrstest.ItemCrudService.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abpcqrstest.ItemCrudService
{
    public interface IItemCrudAppService : IApplicationService
    {
        Task<Dto.itemOutputDto> Insert(Dto.itemInputDto itemInput);
    }
}
