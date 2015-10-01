using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;
using Newtonsoft.Json;

namespace Vendor.Contract
{
    public class VendorContext 
    {
        static string endpoint = "https://devdoc.documents.azure.com:443/";
        static string authKey = "mmdubOth+HRk6VAkmILvfTIn2wKg0BwzkZvcqdNi7SJnmC/Rn7WtvX7Vfp8vyySHwVs6bl2F98yGd6/CL0H9Jw==";
        static string databaseName = "Vendor";
        static string dbCollection = "Vendor";

        static DocumentClient client;

        public async Task SaveAsync<T>(T input) where T : class
        {
            try
            {
                using (client = new DocumentClient(new Uri(endpoint), authKey))
                {
                    var docCollection = await GetDbCollectionAsync(client);
                    if (docCollection != null)
                    {
                        await client.CreateDocumentAsync(docCollection.DocumentsLink, input);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        public async Task<Vendor> GetAsync(string id)
        {
            try
            {
                using (client = new DocumentClient(new Uri(endpoint), authKey))
                {
                    var docCollection = await GetDbCollectionAsync(client);
                    if (docCollection != null)
                    {
                        var output = (from vendor in client.CreateDocumentQuery<Vendor>(docCollection.DocumentsLink)
                                      where vendor.ID == id
                                      select vendor).ToList().FirstOrDefault();
                        return output;
                    }

                }
            }
            catch (Exception ex)
            {
            }
            return null;
        }

        public async Task<IList<Vendor>> GetAsync()
        {
            try
            {
                using (client = new DocumentClient(new Uri(endpoint), authKey))
                {
                    var docCollection = await GetDbCollectionAsync(client);
                    if (docCollection != null)
                    {
                        var output = (from vendor in client.CreateDocumentQuery<Vendor>(docCollection.DocumentsLink)
                                      select vendor).ToList();
                        return output;
                    }

                }
            }
            catch (Exception ex)
            {
            }
            return null;
        }

        public async Task<IList<Vendor>> GetByNameAsync(string name) 
        {
            try
            {
                using (client = new DocumentClient(new Uri(endpoint), authKey))
                {
                    var docCollection = await GetDbCollectionAsync(client);
                    if (docCollection != null)
                    {
                        var output = (from vendor in client.CreateDocumentQuery<Vendor>(docCollection.DocumentsLink)
                                      where vendor.Name.StartsWith(name)
                                      select vendor).ToList();

                        return output;                 
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return null;
        }

        public async Task UpdateAsync(Vendor input)
        {
            try
            {
                using (client = new DocumentClient(new Uri(endpoint), authKey))
                {
                    var docCollection = await GetDbCollectionAsync(client);
                    if (docCollection != null)
                    {
                        var output = (from doc in client.CreateDocumentQuery(docCollection.DocumentsLink)
                                      where doc.Id == input.ID
                                      select doc).ToList().FirstOrDefault();

                        await client.ReplaceDocumentAsync(output.SelfLink, input);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }


        private async Task<DocumentCollection> GetDbCollectionAsync(DocumentClient client)
        {
            DocumentCollection docCollection = null;

            try
            {
                Database database = (from db in client.CreateDatabaseQuery()
                                        where db.Id == databaseName
                                        select db).AsEnumerable().FirstOrDefault();

                if (database != null)
                {
                    docCollection = (from collection in client.CreateDocumentCollectionQuery(database.SelfLink)
                                                        where collection.Id == dbCollection
                                                        select collection).AsEnumerable().FirstOrDefault();
                    if (docCollection == null)
                    {
                        docCollection = await client.CreateDocumentCollectionAsync(
                            database.SelfLink, new DocumentCollection() { Id = dbCollection });
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return docCollection;
        }

    }
}
