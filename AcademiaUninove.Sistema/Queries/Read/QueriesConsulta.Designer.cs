﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AcademiaUninove.Sistema.Queries.Read {
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
    public class QueriesConsulta {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal QueriesConsulta() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AcademiaUninove.Sistema.Queries.Read.QueriesConsulta", typeof(QueriesConsulta).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        public static string qConsultaAula {
            get {
                return ResourceManager.GetString("qConsultaAula", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- Consulta Cargo
        ///SELECT CD_CARGO as &apos;Código&apos;, NOME_CARGO as &apos;Cargo&apos;
        ///FROM CARGO
        ///
        ///.
        /// </summary>
        public static string qConsultaCargo {
            get {
                return ResourceManager.GetString("qConsultaCargo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- Consultar usuário e senha
        ///SELECT Usuario, Senha
        ///	From Login
        ///Where Usuario = &apos;{0}&apos;
        ///And Senha = &apos;{1}&apos;.
        /// </summary>
        public static string qLogin {
            get {
                return ResourceManager.GetString("qLogin", resourceCulture);
            }
        }
    }
}
