using System.ComponentModel.DataAnnotations;

namespace MobilePaymentsNext.Visa.ClassLibrary;

public class TokenLifecycleRequest
{
    [JsonProperty("operatorID")]
    public string OperatorID { get; set; }
    [Required]
    [JsonProperty("operationType")]
    public string OperationType { get; set; }
    [Required]
    [JsonProperty("operationReason")]
    public string OperationReason { get; set; }
    [JsonProperty("activationCode")]
    public string ActivationCode { get; set; }
}
