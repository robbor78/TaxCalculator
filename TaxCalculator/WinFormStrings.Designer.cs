﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaxCalculatorApp {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class WinFormStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal WinFormStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TaxCalculatorApp.WinFormStrings", typeof(WinFormStrings).Assembly);
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
        ///   Looks up a localized string similar to {0:C}.
        /// </summary>
        internal static string FrmtTaxPerAnnum {
            get {
                return ResourceManager.GetString("FrmtTaxPerAnnum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Age.
        /// </summary>
        internal static string LblAge {
            get {
                return ResourceManager.GetString("LblAge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value must be numeric and greater than zero..
        /// </summary>
        internal static string LblErrAge {
            get {
                return ResourceManager.GetString("LblErrAge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value must be numeric and greater than zero..
        /// </summary>
        internal static string LblErrSalaryPerAnnum {
            get {
                return ResourceManager.GetString("LblErrSalaryPerAnnum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Salary per Annum.
        /// </summary>
        internal static string LblSalaryPerAnnum {
            get {
                return ResourceManager.GetString("LblSalaryPerAnnum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tax per Annum.
        /// </summary>
        internal static string LblTaxPerAnnum {
            get {
                return ResourceManager.GetString("LblTaxPerAnnum", resourceCulture);
            }
        }
    }
}
