﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ImageGlass.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ImageGlass.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;!DOCTYPE html&gt;
        ///&lt;html lang=&quot;en&quot;&gt;
        ///&lt;head&gt;
        ///  &lt;meta charset=&quot;UTF-8&quot;&gt;
        ///  &lt;meta http-equiv=&quot;X-UA-Compatible&quot; content=&quot;IE=edge&quot;&gt;
        ///  &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1.0&quot;&gt;
        ///
        ///  &lt;style&gt;{{styles.css}}&lt;/style&gt;
        ///&lt;/head&gt;
        ///
        ///&lt;body id=&quot;app&quot;&gt;
        ///  {{body.html}}
        ///&lt;/body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        internal static string Layout {
            get {
                return ResourceManager.GetString("Layout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] MsStoreBadge {
            get {
                object obj = ResourceManager.GetObject("MsStoreBadge", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;style&gt;
        ///  #app {
        ///    display: grid;
        ///    grid-template-areas: &quot;main&quot; &quot;footer&quot;;
        ///    grid-template-columns: 1fr;
        ///    grid-template-rows: 1fr min-content;
        ///  }
        ///
        ///  #top {
        ///    grid-area: main;
        ///    display: flex;
        ///    padding: 1rem;
        ///    background-color: rgb(var(--AppBg) / 0.85);
        ///    max-height: fit-content;
        ///    overflow: auto;
        ///  }
        ///
        ///  #top&gt;aside {
        ///    position: sticky;
        ///    top: 0;
        ///  }
        ///
        ///  #app&gt;footer {
        ///    grid-area: footer;
        ///    padding: 0 1rem 0 0;
        ///  }
        ///
        ///  #BtnImageGlassStore {
        ///    display [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Page_About {
            get {
                return ResourceManager.GetString("Page_About", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to *,
        ///*::before,
        ///*::after {
        ///    box-sizing: border-box;
        ///    user-drag: none;
        ///    -webkit-user-drag: none;
        ///    user-select: none;
        ///}
        ///
        ///:root {
        ///    color-scheme: dark light;
        ///
        ///    /* theme colors (dark is default) */
        ///    --InvertColor: 255 255 255;
        ///    --AppBg: 20 25 28;
        ///    --AppText: 210 210 210;
        ///    --AppTextDisabled: 140 140 140;
        ///    --Accent: 0 99 177;
        ///    --ControlBg: 69 73 74;
        ///    --ControlBgHover: 95 101 102;
        ///    --ControlBgPressed: 43 43 43;
        ///    --ControlBgPressed2: 49 51 53;
        ///    --Co [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Styles {
            get {
                return ResourceManager.GetString("Styles", resourceCulture);
            }
        }
    }
}
