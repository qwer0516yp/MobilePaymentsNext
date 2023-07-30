using MobilePaymentsNext.Visa.ClassLibrary.Models;

namespace MobilePaymentsNext.Visa.ClassLibrary;

public interface IVisaJsonApiRequestorService
{
    Task<HttpResponseMessage> TokenInquiryGetAsync(string tokenRequestorID, string tokenReferenceID, IDictionary<string, string> optionalQueryParams);
    Task<HttpResponseMessage> TokenInquiryByPanPostAsync(TokenInquiryByPanRequest request);
    Task<HttpResponseMessage> UpdateCardMetadataPostAsync(UpdateCardMetadataFromIssuerRequest request);
    Task<HttpResponseMessage> TokenLifecyclePostAsync(string tokenRequestorID, string tokenReferenceID, TokenLifecycleRequest request);
}