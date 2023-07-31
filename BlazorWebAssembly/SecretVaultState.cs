using System.Security.Cryptography;

namespace BlazorWebAssembly;

public class SecretVaultState
{
    public string? JwePublicCert { get; set; }
	public string? JwsPrivatePem { get; set; }
    public string? JweHeaderKid { get; set; }
    public string? JwsHeaderKid { get; set; }
	public RSA? JweEncryptionPublicKey { get; set; }
	public RSA? JwsSigningPrivateKey { get; set; }

	public bool LoadRSAKeys()
	{
		throw new NotImplementedException("To load rsa keys from .Cer or Pem");
	}
}

