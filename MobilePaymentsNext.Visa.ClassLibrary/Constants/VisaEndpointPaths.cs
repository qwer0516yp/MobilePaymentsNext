namespace MobilePaymentsNext.Visa.ClassLibrary.Constants;

/// <summary>
/// Inbound API Specifications (To Visa)
/// </summary>
public static class VisaEndpointPaths
{
    public const string PAN_LIFECYCLE = "vtis/v1/pan/lifecycle";
    public const string TOKEN_INQUIRY = "vtis/v1/tokenRequestors/{0}/tokens/{1}/details";
    public const string TOKEN_INQUIRY_BY_PAN = "vtis/v1/pan/retrieveTokenInfo";
    public const string TOKEN_LIFECYCLE = "vtis/v1/tokenRequestors/{0}/tokens/{1}/lifecycle";
    public const string UPDATE_CARD_METADATA = "vtis/v1/updateCardMetadata";
    public const string RETRIEVE_NHPP_PARTICIPANTS = "vtis/v1/retrieveNHPPParticipants";
}
