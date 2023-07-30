namespace MobilePaymentsNext.Visa.ClassLibrary.Models;

public class EncryptedData
{
    [JsonProperty("cardholderInfo")]
    public CardholderInfo CardholderInfo { get; set; }
}
