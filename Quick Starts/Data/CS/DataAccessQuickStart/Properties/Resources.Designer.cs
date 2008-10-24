﻿//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Data Access Application Block QuickStart
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

namespace DataAccessQuickStart.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DataAccessQuickStart.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to {0} rows were affected.
        /// </summary>
        internal static string AffectedRowsMessage {
            get {
                return ResourceManager.GetString("AffectedRowsMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Application Error.
        /// </summary>
        internal static string ApplicationErrorMessage {
            get {
                return ResourceManager.GetString("ApplicationErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This test requires database modifications. Please make sure the database has been initialized using the SetUpQuickStartsDB.bat database script, or from the Install Quickstart option on the Start menu..
        /// </summary>
        internal static string DbRequirementsMessage {
            get {
                return ResourceManager.GetString("DbRequirementsMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to open {0} : {1}.
        /// </summary>
        internal static string FileOpenError {
            get {
                return ResourceManager.GetString("FileOpenError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are some problems while trying to use the Data Access Quick Start, please check the following error messages: 
        ///{0}
        ///.
        /// </summary>
        internal static string GeneralExceptionMessage {
            get {
                return ResourceManager.GetString("GeneralExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Completed {0} iterations..
        /// </summary>
        internal static string ProgressMessage {
            get {
                return ResourceManager.GetString("ProgressMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transfer Completed.
        /// </summary>
        internal static string TransferCompletedMessage {
            get {
                return ResourceManager.GetString("TransferCompletedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transfer Failed.
        /// </summary>
        internal static string TransferFailedMessage {
            get {
                return ResourceManager.GetString("TransferFailedMessage", resourceCulture);
            }
        }
    }
}
