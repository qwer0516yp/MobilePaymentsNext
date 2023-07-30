namespace MobilePaymentsNext.Visa.ClassLibrary.Models;

public class CardholderInfo
{
    [JsonProperty("profileID")]
    public string ProfileId { get; set; }
}