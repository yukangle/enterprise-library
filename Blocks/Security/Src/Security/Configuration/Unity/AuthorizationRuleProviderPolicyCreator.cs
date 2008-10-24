﻿//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Security Application Block
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using System.Collections.Generic;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Unity;
using Microsoft.Practices.ObjectBuilder2;

namespace Microsoft.Practices.EnterpriseLibrary.Security.Configuration.Unity
{
	/// <summary>
	/// This type supports the Enterprise Library infrastructure and is not intended to be used directly from your code.
	/// Represents the process to create the container policies required to create a <see cref="AuthorizationRuleProvider"/>.
	/// </summary>
	public class AuthorizationRuleProviderPolicyCreator : IContainerPolicyCreator
	{
		void IContainerPolicyCreator.CreatePolicies(
			IPolicyList policyList,
			string instanceName,
			ConfigurationElement configurationObject,
			IConfigurationSource configurationSource)
		{
			AuthorizationRuleProviderData castConfigurationObject = (AuthorizationRuleProviderData)configurationObject;

			new PolicyBuilder<AuthorizationRuleProvider, AuthorizationRuleProviderData>(
					instanceName,
					castConfigurationObject,
					c => new AuthorizationRuleProvider(CreateRulesDictionary(c.Rules)))
				.AddPoliciesToPolicyList(policyList);
		}

		private static IDictionary<string, IAuthorizationRule> CreateRulesDictionary(
			IEnumerable<AuthorizationRuleData> rulesCollection)
		{
			IDictionary<string, IAuthorizationRule> authorizationRules = new Dictionary<string, IAuthorizationRule>();

			foreach (AuthorizationRuleData ruleData in rulesCollection)
			{
				authorizationRules.Add(ruleData.Name, ruleData);
			}

			return authorizationRules;
		}
	}
}
