using AzureCosmos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureCosmos.services
{
    public interface ICosmosDbService
    {
        Task<IEnumerable<Legend>> GetItemsAsync(string query);

    }
}
