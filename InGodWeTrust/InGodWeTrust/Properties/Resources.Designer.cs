﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InGodWeTrust.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("InGodWeTrust.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Эта программа позволит вам создавать людей..
        /// </summary>
        internal static string About {
            get {
                return ResourceManager.GetString("About", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Нажмите enter для выхода.
        /// </summary>
        internal static string Exit {
            get {
                return ResourceManager.GetString("Exit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to овна.
        /// </summary>
        internal static string FemalePatronymic {
            get {
                return ResourceManager.GetString("FemalePatronymic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Введите пожалуйста количество создаваемых людей.
        /// </summary>
        internal static string HumansAmountInput {
            get {
                return ResourceManager.GetString("HumansAmountInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ошибка, количество людей должно быть &gt; 1, попробуйте ещё раз.
        /// </summary>
        internal static string IncorrectHumansAmount {
            get {
                return ResourceManager.GetString("IncorrectHumansAmount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ович.
        /// </summary>
        internal static string MalePatronymic {
            get {
                return ResourceManager.GetString("MalePatronymic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0:C}.
        /// </summary>
        internal static string MoneyFormat {
            get {
                return ResourceManager.GetString("MoneyFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 4.
        /// </summary>
        internal static string PatronymicSize {
            get {
                return ResourceManager.GetString("PatronymicSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Добрый день! К сожалению в воскресенье эта программа не может работать..
        /// </summary>
        internal static string SundayGreeting {
            get {
                return ResourceManager.GetString("SundayGreeting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Добрый день! Вы можете приступить к созданию людей..
        /// </summary>
        internal static string WorkDayGreeting {
            get {
                return ResourceManager.GetString("WorkDayGreeting", resourceCulture);
            }
        }
    }
}