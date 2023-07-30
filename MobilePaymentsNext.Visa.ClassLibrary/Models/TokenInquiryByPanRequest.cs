namespace MobilePaymentsNext.Visa.ClassLibrary.Models;

public class TokenInquiryByPanRequest
{
    [JsonProperty("panReferenceID")]
    public string PanReferenceID { get; set; }
    [JsonProperty("encryptedData")]
    public string EncryptedData { get; set; }
}
