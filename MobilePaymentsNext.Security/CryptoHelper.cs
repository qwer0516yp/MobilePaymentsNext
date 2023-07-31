using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Text;

namespace MobilePaymentsNext.Security;

public static class CryptoHelper
{
    /// <summary>
    /// Read from the cert string, return the public key as bouncy castle AsymmetricKeyParameter 
    /// </summary>
    /// <param name="publicCert">X509 cert</param>
    /// <returns></returns>
    public static AsymmetricKeyParameter ReadPublicKey(string publicCert)
    {
        var bcPublicCert = DotNetUtilities.FromX509Certificate(ReadX509CertFrom(publicCert));
        return bcPublicCert.GetPublicKey();
    }

    public static RSA ReadRsaPublicKeyObject(string publicCert)
    {
        return ReadX509CertFrom(publicCert).GetRSAPublicKey();
    }

    /// <summary>
    /// Read from the cert string, return as X509Certificate2 object
    /// </summary>
    /// <param name="publicCert">X509 cert</param>
    /// <returns></returns>
    public static X509Certificate2 ReadX509CertFrom(string publicCert)
    {
        return new X509Certificate2(Encoding.UTF8.GetBytes(publicCert));
    }

    public static AsymmetricCipherKeyPair ReadPrivateKey(string privateKey, string password)
    {
        PemReader pemReader;

        using (StringReader srPk = new StringReader(privateKey))
        {
            if (!string.IsNullOrEmpty(password))
            {
                PasswordFinder pf = new PasswordFinder(password);
                pemReader = new PemReader(srPk, pf);
            }
            else
            {
                pemReader = new PemReader(srPk);
            }

            return (AsymmetricCipherKeyPair)pemReader?.ReadObject();
        }
    }

    public static RSA ReadRSAPrivateKeyObject(string privateKey, string password)
    {
        var KeyPair = ReadPrivateKey(privateKey, password);
        RSAParameters rsaParams = DotNetUtilities.ToRSAParameters((RsaPrivateCrtKeyParameters)KeyPair.Private);

        return RSA.Create(rsaParams);
    }
}
