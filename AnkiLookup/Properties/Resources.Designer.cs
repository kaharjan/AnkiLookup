﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnkiLookup.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AnkiLookup.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;div class=&quot;blocks&quot;&gt;
        ///	{{Blocks}}
        ///&lt;/div&gt;.
        /// </summary>
        internal static string BlocksFormat {
            get {
                return ResourceManager.GetString("BlocksFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {{ActualWord}}
        ///&lt;div class=&quot;block&quot;&gt;
        ///	&lt;p class=&quot;label&quot;&gt;[{{Label}}]&lt;/p&gt;
        ///	&lt;ul class=&quot;scope-container&quot;&gt;{{Scope}}&lt;/ul&gt;
        ///&lt;/div&gt;.
        /// </summary>
        internal static string EntryFormat {
            get {
                return ResourceManager.GetString("EntryFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;div class=&quot;example-group&quot;&gt;
        ///	&lt;div&gt;-&gt;&lt;/div&gt;&lt;p class=&quot;example&quot;&gt;&quot;{{Example}}&quot;&lt;/p&gt;
        ///&lt;/div&gt;.
        /// </summary>
        internal static string ExampleFormat {
            get {
                return ResourceManager.GetString("ExampleFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;li class=&quot;scope&quot;&gt;
        ///	&lt;div class=&quot;definition-container&quot;&gt;
        ///		&lt;div class=&quot;definition&quot;&gt;{{Definition}}&lt;/div&gt;
        ///	&lt;/div&gt;
        ///	&lt;div class=&quot;examples&quot;&gt;{{Examples}}&lt;/div&gt;
        ///&lt;/li&gt;.
        /// </summary>
        internal static string ScopeFormat {
            get {
                return ResourceManager.GetString("ScopeFormat", resourceCulture);
            }
        }
    }
}
