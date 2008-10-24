﻿//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Cryptography Application Block
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using System;
using System.Security.Cryptography;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.Practices.EnterpriseLibrary.Security.Cryptography.Tests
{
    [TestClass]
    public class DpapiSymmetricCryptoProviderFixture
    {
        byte[] CreateEntropy()
        {
            byte[] entropy = new byte[16];
            CryptographyUtility.GetRandomBytes(entropy);
            return entropy;
        }

        SymmetricProviderHelper CreateHelper(DataProtectionScope mode,
                                             byte[] entropy)
        {
            DpapiSymmetricCryptoProvider provider = new DpapiSymmetricCryptoProvider(mode, entropy);
            return new SymmetricProviderHelper(provider);
        }

        [TestMethod]
        public void EncryptAndDecryptUserModeWithEntropy()
        {
            SymmetricProviderHelper helper = CreateHelper(DataProtectionScope.CurrentUser, CreateEntropy());
            helper.EncryptAndDecrypt();
            ;
        }

        [TestMethod]
        public void EncryptAndDecryptUserModeWithoutEntropy()
        {
            SymmetricProviderHelper helper = CreateHelper(DataProtectionScope.CurrentUser, null);
            helper.EncryptAndDecrypt();
            ;
        }

        [TestMethod]
        public void EncryptAndDecryptMachineModeWithEntropy()
        {
            SymmetricProviderHelper helper = CreateHelper(DataProtectionScope.LocalMachine, CreateEntropy());
            helper.EncryptAndDecrypt();
            ;
        }

        [TestMethod]
        public void EncryptAndDecryptOneByteUserModeWithoutEntropy()
        {
            SymmetricProviderHelper helper = CreateHelper(DataProtectionScope.CurrentUser, null);
            helper.EncryptAndDecryptOneByte();
        }

        [TestMethod]
        public void EncryptAndDecryptOneByteUserModeWithEntropy()
        {
            SymmetricProviderHelper helper = CreateHelper(DataProtectionScope.CurrentUser, CreateEntropy());
            helper.EncryptAndDecryptOneByte();
        }

        [TestMethod]
        public void EncryptAndDecryptOneByteMachineModeWithEntropy()
        {
            SymmetricProviderHelper helper = CreateHelper(DataProtectionScope.LocalMachine, CreateEntropy());
            helper.EncryptAndDecryptOneByte();
        }

        [TestMethod]
        public void EncryptAndDecryptOneKilobyte()
        {
            SymmetricProviderHelper helper = CreateHelper(DataProtectionScope.CurrentUser, null);
            helper.EncryptAndDecryptOneKilobyte();
        }

        [TestMethod]
        public void EncryptAndDecryptOneMegabyteUserModeWithoutEntropy()
        {
            SymmetricProviderHelper helper = CreateHelper(DataProtectionScope.CurrentUser, null);
            helper.EncryptAndDecryptOneMegabyte();
        }

        [TestMethod]
        public void EncryptAndDecryptOneMegabyteUserModeWithEntropy()
        {
            SymmetricProviderHelper helper = CreateHelper(DataProtectionScope.LocalMachine, CreateEntropy());
            helper.EncryptAndDecryptOneMegabyte();
        }

        [TestMethod]
        public void EncryptAndDecryptOneMegabyteMachineModeWithEntropy()
        {
            SymmetricProviderHelper helper = CreateHelper(DataProtectionScope.LocalMachine, CreateEntropy());
            helper.EncryptAndDecryptOneMegabyte();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EncryptNullThrows()
        {
            SymmetricProviderHelper helper = CreateHelper(DataProtectionScope.CurrentUser, null);
            helper.EncryptNull();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EncryptZeroLengthThrows()
        {
            SymmetricProviderHelper helper = CreateHelper(DataProtectionScope.CurrentUser, null);
            helper.EncryptZeroLength();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DecryptNullThrows()
        {
            SymmetricProviderHelper helper = CreateHelper(DataProtectionScope.CurrentUser, null);
            helper.DecryptNull();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DecryptZeroLengthThrows()
        {
            SymmetricProviderHelper helper = CreateHelper(DataProtectionScope.CurrentUser, null);
            helper.DecryptZeroLength();
        }
    }
}
