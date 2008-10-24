﻿//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Core
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Manageability.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Manageability.Properti" +
                            "es.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected an instance of InstrumentationConfigurationSection..
        /// </summary>
        internal static string ConfigurationElementNotInstrumentationConfigurationSection {
            get {
                return ResourceManager.GetString("ConfigurationElementNotInstrumentationConfigurationSection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected and instance of &apos;{0}&apos; but got an instance of &apos;{1}&apos; instead..
        /// </summary>
        internal static string ConfigurationElementOfWrongType {
            get {
                return ResourceManager.GetString("ConfigurationElementOfWrongType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attributes.
        /// </summary>
        internal static string CustomProviderAttributesPartName {
            get {
                return ResourceManager.GetString("CustomProviderAttributesPartName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type.
        /// </summary>
        internal static string CustomProviderTypePartName {
            get {
                return ResourceManager.GetString("CustomProviderTypePartName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A started category is required to perform the operation..
        /// </summary>
        internal static string ExceptionAdmBuildingNoCurrentCategory {
            get {
                return ResourceManager.GetString("ExceptionAdmBuildingNoCurrentCategory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A started policy is required to perform the operation..
        /// </summary>
        internal static string ExceptionAdmBuildingNoCurrentPolicy {
            get {
                return ResourceManager.GetString("ExceptionAdmBuildingNoCurrentPolicy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A policy construction is in process..
        /// </summary>
        internal static string ExceptionAdmBuildingPolicyNotFinished {
            get {
                return ResourceManager.GetString("ExceptionAdmBuildingPolicyNotFinished", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The built content is requested but there are outstanding categories being built..
        /// </summary>
        internal static string ExceptionAdmBuildingProcessNotFinished {
            get {
                return ResourceManager.GetString("ExceptionAdmBuildingProcessNotFinished", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The default value is above the max value for part &apos;{0}&apos; on policy &apos;{1}&apos;: {2} vs {3}..
        /// </summary>
        internal static string ExceptionAdmDefaultValueAboveMaxValue {
            get {
                return ResourceManager.GetString("ExceptionAdmDefaultValueAboveMaxValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The default value is below the min value for part &apos;{0}&apos; on policy &apos;{1}&apos;: {2} vs {3}..
        /// </summary>
        internal static string ExceptionAdmDefaultValueBelowMinValue {
            get {
                return ResourceManager.GetString("ExceptionAdmDefaultValueBelowMinValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The default value for part &apos;{0}&apos; on policy &apos;{1}&apos; is longer than the max length {2}..
        /// </summary>
        internal static string ExceptionAdmDefaultValueLongerThanMaxlen {
            get {
                return ResourceManager.GetString("ExceptionAdmDefaultValueLongerThanMaxlen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Registry key path contains invalid characters or is missing parts: &apos;{0}&apos;.
        /// </summary>
        internal static string ExceptionAdmInvalidCharactersInRegistryKey {
            get {
                return ResourceManager.GetString("ExceptionAdmInvalidCharactersInRegistryKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The default value is invalid: &apos;{0}&apos;.
        /// </summary>
        internal static string ExceptionAdmInvalidDefaultValue {
            get {
                return ResourceManager.GetString("ExceptionAdmInvalidDefaultValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The max len of {2} is invalid on part &apos;{0}&apos; for policy &apos;{1}&apos;. The allowed values are 0-1024..
        /// </summary>
        internal static string ExceptionAdmInvalidMaxlen {
            get {
                return ResourceManager.GetString("ExceptionAdmInvalidMaxlen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to String &apos;{0}&apos; is not a valid name on an ADM template..
        /// </summary>
        internal static string ExceptionAdmInvalidName {
            get {
                return ResourceManager.GetString("ExceptionAdmInvalidName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The suggestion is invalid: &apos;{0}&apos;.
        /// </summary>
        internal static string ExceptionAdmInvalidSuggestion {
            get {
                return ResourceManager.GetString("ExceptionAdmInvalidSuggestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Min value is larger than max value for part &apos;{0}&apos; on policy &apos;{1}&apos;: {2} vs {3}..
        /// </summary>
        internal static string ExceptionAdmMinValueLargerThanMaxValue {
            get {
                return ResourceManager.GetString("ExceptionAdmMinValueLargerThanMaxValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The numeric constraint &apos;{2}&apos; for part &apos;{0}&apos; on policy &apos;{1}&apos; is outside the allowed range. The valued values are 0-999999999. .
        /// </summary>
        internal static string ExceptionAdmNumericConstraintOutsideRange {
            get {
                return ResourceManager.GetString("ExceptionAdmNumericConstraintOutsideRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path segment over 255 chars in length for registry key: &apos;{0}&apos;.
        /// </summary>
        internal static string ExceptionAdmRegistryKeyPathSegmentTooLong {
            get {
                return ResourceManager.GetString("ExceptionAdmRegistryKeyPathSegmentTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Registry value name over 255 chars in length: &apos;{0}&apos;.
        /// </summary>
        internal static string ExceptionAdmRegistryValueNameTooLong {
            get {
                return ResourceManager.GetString("ExceptionAdmRegistryValueNameTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The application name cannot be longer than 255 characters..
        /// </summary>
        internal static string ExceptionApplicationNameTooLong {
            get {
                return ResourceManager.GetString("ExceptionApplicationNameTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter is an empty string.
        /// </summary>
        internal static string ExceptionArgumentEmpty {
            get {
                return ResourceManager.GetString("ExceptionArgumentEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Group policy processing could not be locked prior to reading the registry.
        /// </summary>
        internal static string ExceptionCannotLockGroupPolicy {
            get {
                return ResourceManager.GetString("ExceptionCannotLockGroupPolicy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration file {0} could not be found..
        /// </summary>
        internal static string ExceptionConfigurationLoadFileNotFound {
            get {
                return ResourceManager.GetString("ExceptionConfigurationLoadFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception caught from callback for change on section &apos;{0}&apos; calling method &apos;{1}&apos;.
        /// </summary>
        internal static string ExceptionErrorOnCallbackForSectionUpdate {
            get {
                return ResourceManager.GetString("ExceptionErrorOnCallbackForSectionUpdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error was detected while a configuration element&apos;s properties were being overriden with policy values..
        /// </summary>
        internal static string ExceptionErrorWhileOverriding {
            get {
                return ResourceManager.GetString("ExceptionErrorWhileOverriding", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no value with name &apos;{1}&apos; on key &apos;{0}&apos;..
        /// </summary>
        internal static string ExceptionMissingRegistryValue {
            get {
                return ResourceManager.GetString("ExceptionMissingRegistryValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value for &apos;{1}&apos; on key &apos;{0}&apos; is not a valid value name for enum type &apos;{2}&apos;: &apos;{3}&apos;.
        /// </summary>
        internal static string ExceptionRegistryValueNotEnumValue {
            get {
                return ResourceManager.GetString("ExceptionRegistryValueNotEnumValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value for &apos;{1}&apos; on key &apos;{0}&apos; is not a valid assembly qualified type name: &apos;{2}&apos;.
        /// </summary>
        internal static string ExceptionRegistryValueNotTypeName {
            get {
                return ResourceManager.GetString("ExceptionRegistryValueNotTypeName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value for &apos;{1}&apos; on key &apos;{0}&apos; is not of the correct type:
        ///Expected {2} but got {3} instead..
        /// </summary>
        internal static string ExceptionRegistryValueOfWrongType {
            get {
                return ResourceManager.GetString("ExceptionRegistryValueOfWrongType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value can not be null or string or empty..
        /// </summary>
        internal static string ExceptionStringNullOrEmpty {
            get {
                return ResourceManager.GetString("ExceptionStringNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected error while processing section &apos;{0}&apos;.
        /// </summary>
        internal static string ExceptionUnexpectedErrorProcessingSection {
            get {
                return ResourceManager.GetString("ExceptionUnexpectedErrorProcessingSection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The expected type &apos;{0}&apos; was not provided..
        /// </summary>
        internal static string ExceptionUnexpectedType {
            get {
                return ResourceManager.GetString("ExceptionUnexpectedType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No WmiImplementationAttribute was found for implementation &apos;{0}&apos; on type {1}..
        /// </summary>
        internal static string ExceptionWmiImplementationAttributeNotFound {
            get {
                return ResourceManager.GetString("ExceptionWmiImplementationAttributeNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type specified in the WmiImplementationAttribute for implementation &apos;{0}&apos; on type {2} is incompatible with the requested type {1}..
        /// </summary>
        internal static string ExceptionWmiImplementationIncompatibleType {
            get {
                return ResourceManager.GetString("ExceptionWmiImplementationIncompatibleType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type specified in the WmiImplementationAttribute for implementation &apos;{0}&apos; on type {1} is invalid or cannot be found..
        /// </summary>
        internal static string ExceptionWmiImplementationInvalidTypeName {
            get {
                return ResourceManager.GetString("ExceptionWmiImplementationInvalidTypeName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Group policy notification thread.
        /// </summary>
        internal static string GroupPolicyWatcherThread {
            get {
                return ResourceManager.GetString("GroupPolicyWatcherThread", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Instrumentation.
        /// </summary>
        internal static string InstrumentationSectionCategoryName {
            get {
                return ResourceManager.GetString("InstrumentationSectionCategoryName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event logging enabled.
        /// </summary>
        internal static string InstrumentationSectionEventLoggingEnabledPartName {
            get {
                return ResourceManager.GetString("InstrumentationSectionEventLoggingEnabledPartName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Performance counters enabled.
        /// </summary>
        internal static string InstrumentationSectionPerformanceCountersEnabledPartName {
            get {
                return ResourceManager.GetString("InstrumentationSectionPerformanceCountersEnabledPartName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify settings for the instrumentation section.
        /// </summary>
        internal static string InstrumentationSectionPolicyName {
            get {
                return ResourceManager.GetString("InstrumentationSectionPolicyName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WMI enabled.
        /// </summary>
        internal static string InstrumentationSectionWmiEnabledPartName {
            get {
                return ResourceManager.GetString("InstrumentationSectionWmiEnabledPartName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Manageable Configuration Source.
        /// </summary>
        internal static string ManageableConfigurationSourceName {
            get {
                return ResourceManager.GetString("ManageableConfigurationSourceName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updates to configuration through the ManageableConfigurationSource are not supported. Use the FileConfigurationSource instead..
        /// </summary>
        internal static string ManageableConfigurationSourceUpdateNotAvailable {
            get {
                return ResourceManager.GetString("ManageableConfigurationSourceUpdateNotAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to None.
        /// </summary>
        internal static string NoneListItem {
            get {
                return ResourceManager.GetString("NoneListItem", resourceCulture);
            }
        }
    }
}
