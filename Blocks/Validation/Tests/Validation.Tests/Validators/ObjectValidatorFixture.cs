﻿//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Validation Application Block
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using System;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Validation.Properties;
using Microsoft.Practices.EnterpriseLibrary.Validation.Tests.TestClasses;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.Practices.EnterpriseLibrary.Validation.Tests.Validators
{
    [TestClass]
    public class ObjectValidatorFixture
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ValidatorCreatedWithNullTypeThrows()
        {
            new ObjectValidator(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ValidatorCreatedWithNullRulesetThrows()
        {
            new ObjectValidator(typeof(string), null);
        }

        [TestMethod]
        public void ValidationOfNullLogsNoError()
        {
            Validator validator = new ObjectValidator(typeof(ObjectValidatorFixtureReferencedTestClass));

            ValidationResults validationResults = validator.Validate(null);

            Assert.IsTrue(validationResults.IsValid);
        }

        [TestMethod]
        public void ValidationOfObjectOfDifferentTypeLogsError()
        {
            object target = "a string is not a ObjectValidatorFixtureTestClass";
            Validator validator = new ObjectValidator(typeof(ObjectValidatorFixtureReferencedTestClass));

            ValidationResults validationResults = validator.Validate(target);

            Assert.IsFalse(validationResults.IsValid);
            IDictionary<string, ValidationResult> resultsMapping = ValidationTestHelper.GetResultsMapping(validationResults);
            Assert.AreEqual(1, resultsMapping.Count);
            Assert.IsTrue(resultsMapping.ContainsKey(Resources.ObjectValidatorInvalidTargetType));
            Assert.AreEqual(null, resultsMapping[Resources.ObjectValidatorInvalidTargetType].Key);
            Assert.AreEqual(null, resultsMapping[Resources.ObjectValidatorInvalidTargetType].Tag);
            Assert.AreSame(target, resultsMapping[Resources.ObjectValidatorInvalidTargetType].Target);
            Assert.AreSame(validator, resultsMapping[Resources.ObjectValidatorInvalidTargetType].Validator);
        }

        [TestMethod]
        public void ValidationOfObjectResetsCurrentTargetAndKey()
        {
            object target = new ObjectValidatorFixtureReferencedTestClass();
            Validator validator = new ObjectValidator(typeof(ObjectValidatorFixtureReferencedTestClass));

            ValidationResults validationResults = new ValidationResults();
            validator.DoValidate(target, this, "key", validationResults); // setting the currentTarget and the key

            Assert.IsFalse(validationResults.IsValid);
            IDictionary<string, ValidationResult> resultsMapping = ValidationTestHelper.GetResultsMapping(validationResults);
            Assert.AreEqual(2, resultsMapping.Count);
            Assert.IsTrue(resultsMapping.ContainsKey("ReferencedObject"));
            Assert.AreEqual(null, resultsMapping["ReferencedObject"].Key);
            Assert.AreEqual(null, resultsMapping["ReferencedObject"].Tag);
            Assert.AreSame(target, resultsMapping["ReferencedObject"].Target);
            Assert.AreSame(typeof(MockValidator<object>), resultsMapping["ReferencedObject"].Validator.GetType());
            Assert.IsTrue(resultsMapping.ContainsKey("PropertyInReferencedObject"));
            Assert.AreEqual("PropertyInReferencedObject", resultsMapping["PropertyInReferencedObject"].Key);
            Assert.AreEqual(null, resultsMapping["PropertyInReferencedObject"].Tag);
            Assert.AreSame(target, resultsMapping["PropertyInReferencedObject"].Target);
            Assert.AreSame(typeof(MockValidator<object>), resultsMapping["PropertyInReferencedObject"].Validator.GetType());
        }

        [TestMethod]
        public void TargetObjectValidatorIsCreatedWithProvidedRuleset()
        {
            object target = new ObjectValidatorFixtureReferencedTestClass();
            Validator validator = new ObjectValidator(typeof(ObjectValidatorFixtureReferencedTestClass), "RuleB");

            ValidationResults validationResults = new ValidationResults();
            validator.DoValidate(target, this, "key", validationResults); // setting the currentTarget and the key

            Assert.IsFalse(validationResults.IsValid);
            IDictionary<string, ValidationResult> resultsMapping = ValidationTestHelper.GetResultsMapping(validationResults);
            Assert.AreEqual(1, resultsMapping.Count);
            Assert.IsTrue(resultsMapping.ContainsKey("PropertyInReferencedObject-RuleB"));
            Assert.AreEqual("PropertyInReferencedObject", resultsMapping["PropertyInReferencedObject-RuleB"].Key);
            Assert.AreEqual(null, resultsMapping["PropertyInReferencedObject-RuleB"].Tag);
            Assert.AreSame(target, resultsMapping["PropertyInReferencedObject-RuleB"].Target);
            Assert.AreSame(typeof(MockValidator<object>), resultsMapping["PropertyInReferencedObject-RuleB"].Validator.GetType());
        }

        [TestMethod]
        public void ValidatorCanValidateSubclassOfTargetTypeUsingTargetTypeValidation()
        {
            object target = new ObjectValidatorFixtureReferencedTestClassSublcass();
            Validator validator = new ObjectValidator(typeof(ObjectValidatorFixtureReferencedTestClass), "RuleB");

            ValidationResults validationResults = new ValidationResults();
            validator.DoValidate(target, this, "key", validationResults); // setting the currentTarget and the key

            Assert.IsFalse(validationResults.IsValid);
            IDictionary<string, ValidationResult> resultsMapping = ValidationTestHelper.GetResultsMapping(validationResults);
            Assert.AreEqual(1, resultsMapping.Count);
            Assert.IsTrue(resultsMapping.ContainsKey("PropertyInReferencedObject-RuleB"));
            Assert.AreEqual("PropertyInReferencedObject", resultsMapping["PropertyInReferencedObject-RuleB"].Key);
            Assert.AreEqual(null, resultsMapping["PropertyInReferencedObject-RuleB"].Tag);
            Assert.AreSame(target, resultsMapping["PropertyInReferencedObject-RuleB"].Target);
            Assert.AreSame(typeof(MockValidator<object>), resultsMapping["PropertyInReferencedObject-RuleB"].Validator.GetType());
        }

        public class ObjectValidatorFixtureTestClass
        {
            public ObjectValidatorFixtureReferencedTestClass Property
            {
                get { return new ObjectValidatorFixtureReferencedTestClass(); }
            }
        }

        [MockValidator(true, MessageTemplate = "ReferencedObject")]
        public class ObjectValidatorFixtureReferencedTestClass
        {
            [MockValidator(true, MessageTemplate = "PropertyInReferencedObject")]
            [MockValidator(true, MessageTemplate = "PropertyInReferencedObject-RuleB", Ruleset = "RuleB")]
            public string PropertyInReferencedObject
            {
                get { return null; }
            }
        }

        public class ObjectValidatorFixtureReferencedTestClassSublcass : ObjectValidatorFixtureReferencedTestClass
        {
            [MockValidator(true, MessageTemplate = "PropertyInReferencedObjectSubclass", Ruleset = "RuleB")]
            public string PropertyInReferencedObjectSubclass
            {
                get { return null; }
            }
        }
    }
}
