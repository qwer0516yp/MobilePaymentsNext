namespace MobilePaymentsNext.Visa.ClassLibrary;

public interface IVisaJsonRequestManager
{
    string GetXPayToken(string resourcePath, string queryString, string requestBody);
    string GetApiKey();
}