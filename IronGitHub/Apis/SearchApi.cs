﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IronGitHub.Entities;

namespace IronGitHub.Apis
{
    public class SearchApi : GitHubApiBase
    {
        public SearchApi(GitHubApiContext context) : base(context)
        {
        }

        async public Task<User.UserList> Users(string matching)
        {
            var request = CreateRequest("/legacy/user/search/" + Uri.EscapeDataString(matching));

            var response = await Complete<User.UserList>(request);

            return response.Result;
        }

        async public Task<Repository.RepositoryList> Repositories(string matching)
        {
            var request = CreateRequest("/legacy/repos/search/" + Uri.EscapeDataString(matching));

            var response = await Complete<Repository.RepositoryList>(request);

            return response.Result;
        }
    }
}