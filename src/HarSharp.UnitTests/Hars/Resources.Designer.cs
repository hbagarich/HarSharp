﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HarSharp.UnitTests.Hars {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HarSharp.UnitTests.Hars.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to {
        ///  &quot;log&quot;: {
        ///    &quot;version&quot;: &quot;1.2&quot;,
        ///    &quot;creator&quot;: {
        ///      &quot;name&quot;: &quot;WebInspector&quot;,
        ///      &quot;version&quot;: &quot;537.36&quot;
        ///    },
        ///    &quot;pages&quot;: [
        ///      {
        ///        &quot;startedDateTime&quot;: &quot;2014-09-24T18:39:52.160Z&quot;,
        ///        &quot;id&quot;: &quot;page_2&quot;,
        ///        &quot;title&quot;: &quot;https://www.google.com/&quot;,
        ///        &quot;pageTimings&quot;: {
        ///          &quot;onContentLoad&quot;: 2423.999786376953,
        ///          &quot;onLoad&quot;: 2423.999786376953
        ///        }
        ///      },
        ///      {
        ///        &quot;startedDateTime&quot;: &quot;2014-09-24T18:40:00.095Z&quot;,
        ///        &quot;id&quot;: &quot;page_3&quot;,
        ///        &quot;title&quot;: [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Sample {
            get {
                return ResourceManager.GetString("Sample", resourceCulture);
            }
        }
    }
}
