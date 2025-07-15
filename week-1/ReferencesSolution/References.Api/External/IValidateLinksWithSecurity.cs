using Shared;
namespace References.Api.External;

public interface IValidateLinksWithSecurity
{
    Task<LinkValidationResponse> ValidateLinkAsync(LinkValidationRequest request);
}

public record LinkValidationRequest(string Href);

