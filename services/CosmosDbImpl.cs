using AzureCosmos.Models;
using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureCosmos.services
{

    public class CosmosDbImpl : ICosmosDbService
    {
        private Container _container;

        public CosmosDbImpl(CosmosClient dbClient,
            string databaseName,
            string containerName)
        {
            this._container = dbClient.GetContainer(databaseName, containerName);

        }
        public async Task<IEnumerable<Legend>> GetItemsAsync(string queryString)
        {
            var query = this._container.GetItemQueryIterator<Legend>(new QueryDefinition(queryString));
            List<Legend> results = new List<Legend>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();

                results.AddRange(response.ToList());
            }

            return results;
        }
    }
}
