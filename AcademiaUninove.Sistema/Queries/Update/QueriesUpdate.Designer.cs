﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AcademiaUninove.Sistema.Queries.Update {
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
    public class QueriesUpdate {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal QueriesUpdate() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AcademiaUninove.Sistema.Queries.Update.QueriesUpdate", typeof(QueriesUpdate).Assembly);
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
        ///   Looks up a localized string similar to -- Consulta de aulas para edição
        ///
        ///SELECT CD_AULA, NOME_AULA 
        ///	FROM AULA
        ///WHERE CD_AULA = {0}.
        /// </summary>
        public static string qConsultaAulaEdit {
            get {
                return ResourceManager.GetString("qConsultaAulaEdit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- Consulta Cargo para Edição
        ///SELECT CD_CARGO as &apos;Código&apos;, NOME_CARGO as &apos;Cargo&apos;
        ///FROM CARGO
        ///
        ///where CD_CARGO = {0}
        ///
        ///.
        /// </summary>
        public static string qConsultaCargoEdit {
            get {
                return ResourceManager.GetString("qConsultaCargoEdit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- Consulta de aulas para edição
        ///
        ///SELECT CD_AULA, NOME_AULA 
        ///	FROM AULA
        ///WHERE CD_AULA = {0}.
        /// </summary>
        public static string qConsultaFuncionarioEdit {
            get {
                return ResourceManager.GetString("qConsultaFuncionarioEdit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- Comando de update aula
        ///
        ///UPDATE AULA SET NOME_AULA = &apos;{0}&apos;
        ///WHERE CD_AULA = {1}.
        /// </summary>
        public static string qUpdateAula {
            get {
                return ResourceManager.GetString("qUpdateAula", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- Atualizando cargo
        ///
        ///UPDATE CARGO SET NOME_CARGO = &apos;{0}&apos;
        ///WHERE CD_CARGO = {1}.
        /// </summary>
        public static string qUpdateCargo {
            get {
                return ResourceManager.GetString("qUpdateCargo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- Comando de update aula
        ///
        ///UPDATE AULA SET NOME_AULA = &apos;{0}&apos;
        ///WHERE CD_AULA = {1}.
        /// </summary>
        public static string qUpdateFuncionario {
            get {
                return ResourceManager.GetString("qUpdateFuncionario", resourceCulture);
            }
        }
    }
}
