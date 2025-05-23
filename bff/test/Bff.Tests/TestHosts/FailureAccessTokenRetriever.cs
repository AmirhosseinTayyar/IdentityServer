// Copyright (c) Duende Software. All rights reserved.
// See LICENSE in the project root for license information.

namespace Duende.Bff.Tests.TestHosts;

public class FailureAccessTokenRetriever : IAccessTokenRetriever
{
    public Task<AccessTokenResult> GetAccessToken(AccessTokenRetrievalContext context)
    {
        return Task.FromResult<AccessTokenResult>(new NoAccessTokenReturnedError("Test"));
    }
}
