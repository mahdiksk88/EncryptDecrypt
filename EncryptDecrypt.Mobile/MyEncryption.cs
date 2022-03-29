using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace EncryptDecrypt.Android
{
    public class MyEncryption
    {
        // Internal value of the phrase used to generate the secret key
        private string _Phrase = "";
        //contains input file path and name
        private string _inputFile = "";
        //contains output file path and name
        private string _outputFile = "";
        private enum TransformType
        {
            ENCRYPT = 0,
            DECRYPT = 1
        }
        internal MyEncryption(string SecretPhrase)
        {
            this.Phrase = SecretPhrase;
        }

        /// <value>Set the phrase used to generate the secret key.</value>
        public string Phrase
        {
            set
            {
                this._Phrase = value;
                this.GenerateKey(this._Phrase);
            }
        }

        // Internal initialization vector value to 
        // encrypt/decrypt the first block
        private byte[] _IV;

        // Internal secret key value
        private byte[] _Key;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="SecretPhrase">Secret phrase to generate key</param>
        public void MyEncryptor(string SecretPhrase)
        {
            this.Phrase = SecretPhrase;
        }

        /// <summary>
        /// Encrypt the given value with the Rijndael algorithm.
        /// </summary>
        /// <param name="EncryptValue">Value to encrypt</param>
        /// <returns>Encrypted value. </returns>
        public string Encrypt(string EncryptValue)
        {
            try
            {
                if (EncryptValue.Length > 0)
                {
                    // Write the encrypted value into memory
                    byte[] input = Encoding.UTF8.GetBytes(EncryptValue);

                    // Retrieve the encrypted value and return it
                    return (Convert.ToBase64String(Transform(input, TransformType.ENCRYPT)));

                }
                else
                {
                    return "";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Decrypt the given value with the Rijndael algorithm.
        /// </summary>
        /// <param name="DecryptValue">Value to decrypt</param>
        /// <returns>Decrypted value. </returns>
        public string Decrypt(string DecryptValue)
        {

            try
            {
                if (DecryptValue.Length > 0)
                {
                    // Write the encrypted value into memory                    
                    byte[] input = Convert.FromBase64String(DecryptValue);

                    // Retrieve the decrypted value and return it
                    return (Encoding.UTF8.GetString(Transform(input, TransformType.DECRYPT)));

                }
                else
                {
                    return "";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Encrypt the given value with the Rijndael algorithm.
        /// </summary>
        /// <param name="EncryptValue">Value to encrypt</param>
        /// <returns>Encrypted value. </returns>
        public void Encrypt(string InputFile, string OutputFile)
        {

            try
            {
                if ((InputFile != null) && (InputFile.Length > 0))
                {
                    _inputFile = InputFile;
                }
                if ((OutputFile != null) && (OutputFile.Length > 0))
                {
                    _outputFile = OutputFile;
                }
                Transform(null, TransformType.ENCRYPT);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Decrypt the given value with the Rijndael algorithm.
        /// </summary>
        /// <param name="DecryptValue">Value to decrypt</param>
        /// <returns>Decrypted value. </returns>
        public void Decrypt(string InputFile, string OutputFile)
        {

            try
            {
                if ((InputFile != null) && (InputFile.Length > 0))
                {
                    _inputFile = InputFile;
                }
                if ((OutputFile != null) && (OutputFile.Length > 0))
                {
                    _outputFile = OutputFile;
                }
                Transform(null, TransformType.DECRYPT);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        ///        ***************************************************************
        ///         * Generate an encryption key based on the given phrase.  The 
        ///         * phrase is hashed to create a unique 32 character (256-bit) 
        ///         * value, of which 24 characters (192 bit) are used for the
        ///         * key and the remaining 8 are used for the initialization 
        ///         * vector (IV).
        ///         * 
        ///         * Parameters:  SecretPhrase - phrase to generate the key and 
        ///         * IV from.
        ///         * 
        ///         * Return Val:  None  
        ///         **************************************************************
        private void GenerateKey(string SecretPhrase)
        {
            // Initialize internal values
            this._Key = new byte[24];
            this._IV = new byte[16];

            // Perform a hash operation using the phrase.  This will 
            // generate a unique 32 character value to be used as the key.
            byte[] bytePhrase = Encoding.ASCII.GetBytes(SecretPhrase);
            SHA384Managed sha384 = new SHA384Managed();
            sha384.ComputeHash(bytePhrase);
            byte[] result = sha384.Hash;

            // Transfer the first 24 characters of the hashed value to the key
            // and the remaining 8 characters to the intialization vector.
            for (int loop = 0; loop <= 23; loop++)
            {
                this._Key[loop] = result[loop];
            }
            for (int loop = 24; loop <= 39; loop++)
            {
                this._IV[loop - 24] = result[loop];
            }
        }

        ///        ***************************************************************
        ///         * Transform one form to anoter based on CryptoTransform
        ///         * It is used to encrypt to decrypt as well as decrypt to encrypt
        ///         * Parameters:  input [byte array] - which needs to be transform 
        ///         *              transformType - encrypt/decrypt transform
        ///         * 
        ///         * Return Val:  byte array - transformed value.
        ///         **************************************************************
        private byte[] Transform(byte[] input, TransformType transformType)
        {
            CryptoStream cryptoStream = null; // Stream used to encrypt
            RijndaelManaged rijndael = null; // Rijndael provider
            ICryptoTransform rijndaelTransform = null; // Encrypting object
            FileStream fsIn = null; //input file
            FileStream fsOut = null; //output file
            MemoryStream memStream = null; // Stream to contain data
            try
            {
                // Create the crypto objects
                rijndael = new RijndaelManaged();
                rijndael.Key = this._Key;
                rijndael.IV = this._IV;
                if (transformType == MyEncryption.TransformType.ENCRYPT)
                {
                    rijndaelTransform = rijndael.CreateEncryptor();
                }
                else
                {
                    rijndaelTransform = rijndael.CreateDecryptor();
                }

                if ((input != null) && (input.Length > 0))
                {
                    memStream = new MemoryStream();
                    cryptoStream = new CryptoStream(memStream, rijndaelTransform, CryptoStreamMode.Write);

                    cryptoStream.Write(input, 0, input.Length);

                    cryptoStream.FlushFinalBlock();

                    return memStream.ToArray();

                }
                else if ((_inputFile.Length > 0) && (_outputFile.Length > 0))
                {
                    // First we are going to open the file streams 
                    fsIn = new FileStream(_inputFile, FileMode.Open, FileAccess.Read);
                    fsOut = new FileStream(_outputFile, FileMode.OpenOrCreate, FileAccess.Write);

                    cryptoStream = new CryptoStream(fsOut, rijndaelTransform, CryptoStreamMode.Write);

                    // Now will will initialize a buffer and will be 
                    // processing the input file in chunks. 
                    // This is done to avoid reading the whole file (which can be
                    // huge) into memory. 
                    int bufferLen = 4096;
                    byte[] buffer = new byte[bufferLen];
                    int bytesRead = 0;
                    do
                    {
                        // read a chunk of data from the input file 
                        bytesRead = fsIn.Read(buffer, 0, bufferLen);
                        // Encrypt it 
                        cryptoStream.Write(buffer, 0, bytesRead);

                    } while (bytesRead != 0);

                    cryptoStream.FlushFinalBlock();
                }
                return null;

            }
            catch (CryptographicException)
            {
                throw new CryptographicException("Password is invalid. Please verify once again.");
            }
            finally
            {
                if (rijndael != null)
                {
                    rijndael.Clear();
                }
                if (rijndaelTransform != null)
                {
                    rijndaelTransform.Dispose();
                }
                if (cryptoStream != null)
                {
                    cryptoStream.Close();
                }
                if (memStream != null)
                {
                    memStream.Close();
                }
                if (fsOut != null)
                {
                    fsOut.Close();
                }
                if (fsIn != null)
                {
                    fsIn.Close();
                }
            }
        }
    }
}