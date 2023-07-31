using MobilePaymentsNext.Security;
using System.Security.Cryptography;

namespace BlazorWebAssembly;

public class SecretVaultState
{
    public string? JwePublicCert { get; set; }
	public string? JwsPrivatePem { get; set; }
    public string? JwsPrivatePemPass { get; set; }
    public string? JweHeaderKid { get; set; }
    public string? JwsHeaderKid { get; set; }
	public RSA? JweEncryptionPublicKey { get; private set; }
	public RSA? JwsSigningPrivateKey { get; private set; }

	public bool LoadRSAKeys()
	{
		try
		{
			JweEncryptionPublicKey = CryptoHelper.ReadRsaPublicKeyObject(JwePublicCert);
			JwsSigningPrivateKey = CryptoHelper.ReadRSAPrivateKeyObject(JwsPrivatePem, JwsPrivatePemPass);
			return true;
        }
		catch (Exception ex)
		{
			return false;
		}
	}
}

