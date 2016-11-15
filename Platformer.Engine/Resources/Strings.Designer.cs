﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Platformer.Engine.Resources {
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
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Platformer.Engine.Resources.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to Adding {0} resource &quot;{1}&quot; to preload queue....
        /// </summary>
        internal static string AddingResourceToPreloadQueue {
            get {
                return ResourceManager.GetString("AddingResourceToPreloadQueue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bitmap data invalid..
        /// </summary>
        internal static string BitmapDataInvalid {
            get {
                return ResourceManager.GetString("BitmapDataInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Entity of type &apos;{0}&apos; at position ({1},{2}) Has unknown type name and cannot be created..
        /// </summary>
        internal static string EntityBadTypeName {
            get {
                return ResourceManager.GetString("EntityBadTypeName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An entity type name must be specified..
        /// </summary>
        internal static string EntityTypeNameMustBeSpecified {
            get {
                return ResourceManager.GetString("EntityTypeNameMustBeSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A gvar with the given name already exists..
        /// </summary>
        internal static string GvarNameExists {
            get {
                return ResourceManager.GetString("GvarNameExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A Gvar name is required..
        /// </summary>
        internal static string GvarNameRequired {
            get {
                return ResourceManager.GetString("GvarNameRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number of values in enumeration must be greater than or equal to the graph size..
        /// </summary>
        internal static string LerpGraphEnumerationSizeInvalid {
            get {
                return ResourceManager.GetString("LerpGraphEnumerationSizeInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Interpolation graph size must be greater than zero..
        /// </summary>
        internal static string LerpGraphSizeMustBeGreaterThanZero {
            get {
                return ResourceManager.GetString("LerpGraphSizeMustBeGreaterThanZero", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loading {0} resource &quot;{1}&quot;....
        /// </summary>
        internal static string LoadingResource {
            get {
                return ResourceManager.GetString("LoadingResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Preloading {0} resource{1} of type &quot;{2}&quot;....
        /// </summary>
        internal static string PreloadingResources {
            get {
                return ResourceManager.GetString("PreloadingResources", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Late preload of {0} resource &quot;{1}&quot;!.
        /// </summary>
        internal static string ResourceLatePreload {
            get {
                return ResourceManager.GetString("ResourceLatePreload", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A resource name is required..
        /// </summary>
        internal static string ResourceNameRequired {
            get {
                return ResourceManager.GetString("ResourceNameRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bad number of tokens in sprite definition file {0}, line {1}..
        /// </summary>
        internal static string SpriteDefinitionBadTokenCount {
            get {
                return ResourceManager.GetString("SpriteDefinitionBadTokenCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A sprite name is required..
        /// </summary>
        internal static string SpriteNameRequired {
            get {
                return ResourceManager.GetString("SpriteNameRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tileset has no associated image!.
        /// </summary>
        internal static string TilesetHasNoImage {
            get {
                return ResourceManager.GetString("TilesetHasNoImage", resourceCulture);
            }
        }
    }
}
