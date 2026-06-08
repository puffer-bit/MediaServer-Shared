using System.Text.Json;
using Shared.Enums;
using Shared.Enums.Auth;
using Shared.Models;
using Shared.Models.DTO;
using Shared.Models.Requests.Auth;
using Xunit;

namespace Shared.Core.Tests.Models.Requests.Auth;

public class UserAuthRequestTests
{
    private readonly JsonSerializerOptions _jsonOptions;

    public UserAuthRequestTests()
    {
        _jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
    }

    [Fact]
    public void ParseAndMap_UserAuthRequest_WithoutConverter_ShouldRetainRequestId()
    {
        const string expectedRequestId = "SECURE-REQ-ID-999";
        const string expectedIdentity = "test@user.com";
        const string expectedPassword = "SuperPassword123";
        
        var jsonInput = $$"""
        {
            "Id": "msg-001",
            "UserId": null,
            "Type": {{(int)MessageType.UserAuthAction}}, 
            "Data": {
                "RequestId": "{{expectedRequestId}}",
                "UserIdentity": "{{expectedIdentity}}",
                "Password": "{{expectedPassword}}"
            }
        }
        """;

        var baseMessage = JsonSerializer.Deserialize<BaseMessage>(jsonInput, _jsonOptions);
        
        // Assert
        Assert.NotNull(baseMessage);
        Assert.NotNull(baseMessage.Data);
        
        Assert.IsType<UserAuthRequest>(baseMessage.Data);

        var authRequest = (UserAuthRequest)baseMessage.Data;
        Assert.Equal(expectedIdentity, authRequest.UserIdentity);
        Assert.Equal(expectedPassword, authRequest.Password);
        Assert.Equal(expectedRequestId, authRequest.RequestId);

        var dummyUserDto = new UserDTO { Id = 42, Username = "TestUser" };
        var userAuthResponse = authRequest.ToResponse(
            authResult: AuthResult.Success,
            userIdentity: expectedIdentity,
            userDTO: dummyUserDto,
            serverMessage: "Welcome!"
        );

        Assert.NotNull(userAuthResponse);
        Assert.Equal(expectedRequestId, userAuthResponse.RequestId);
        Assert.Equal(AuthResult.Success, userAuthResponse.AuthResult);
    }
}