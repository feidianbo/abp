﻿using MongoDB.Driver;
using Volo.Abp.Data;
using Volo.Abp.IdentityServer.Clients;
using Volo.Abp.IdentityServer.Grants;
using Volo.Abp.IdentityServer.IdentityResources;
using Volo.Abp.MongoDB;
using ApiResource = Volo.Abp.IdentityServer.ApiResources.ApiResource;

namespace Volo.Abp.IdentityServer.MongoDB
{
    [ConnectionStringName("AbpIdentityServer")]
    public interface IAbpIdentityServerMongoDbContext : IAbpMongoDbContext
    {
        IMongoCollection<ApiResource> ApiResources { get; }

        IMongoCollection<Client> Clients { get; }

        IMongoCollection<IdentityResource> IdentityResources { get; }

        IMongoCollection<PersistedGrant> PersistedGrants { get; }
    }
}
