﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AcademiaUninove.Sistema.Queries.Insert {
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
    public class QueriesInsert {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal QueriesInsert() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AcademiaUninove.Sistema.Queries.Insert.QueriesInsert", typeof(QueriesInsert).Assembly);
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
        ///   Looks up a localized string similar to -- Inserção de Alunos
        ///
        ///
        ///INSERT INTO ALUNO (
        ///		CD_ALU,
        ///		CD_FUNC,
        ///		NOME_ALU,
        ///		CPF_ALU,
        ///		RG_ALU,
        ///		DT_NASC,
        ///		TEL_RES,
        ///		TEL_CEL,
        ///		END_ALU,
        ///		CEP_ALU,
        ///		CIDADE,
        ///		STATUS_ALU,
        ///		RESTRICAO,
        ///		OBJETIVO
        ///		)
        ///VALUES (
        ///		{0},
        ///		{1},
        ///		&apos;{2}&apos;,
        ///		&apos;{3}&apos;,
        ///		&apos;{4}&apos;,
        ///		&apos;{5}&apos;,
        ///		&apos;{6}&apos;,
        ///		&apos;{7}&apos;,
        ///		&apos;{8}&apos;,
        ///		&apos;{9}&apos;,
        ///		&apos;{10}&apos;,
        ///		&apos;{11}&apos;,
        ///		&apos;{12}&apos;,
        ///		&apos;{13}&apos;
        ///		).
        /// </summary>
        public static string qInsertAluno {
            get {
                return ResourceManager.GetString("qInsertAluno", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- Inserção de aulas
        ///
        ///INSERT INTO AULA (CD_AULA,NOME_AULA)
        ///	VALUES({0}, &apos;{1}&apos;).
        /// </summary>
        public static string qInsertAula {
            get {
                return ResourceManager.GetString("qInsertAula", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- Inserir Cargo
        ///INSERT INTO CARGO
        ///(CD_CARGO, NOME_CARGO)
        ///Values ({0}, &apos;{1}&apos;).
        /// </summary>
        public static string qInsertCargo {
            get {
                return ResourceManager.GetString("qInsertCargo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        public static string qInsertFrequencia {
            get {
                return ResourceManager.GetString("qInsertFrequencia", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- Inserção de da aula dos instrutores
        ///
        ///INSERT INTO FUNC_AULA(
        ///	CD_FUNC_AULA,
        ///	CD_FUNC,
        ///	CD_AULA) VALUES
        ///	(
        ///		{0}
        ///		,{1}
        ///		,{2}
        ///	).
        /// </summary>
        public static string qInsertFuncAula {
            get {
                return ResourceManager.GetString("qInsertFuncAula", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- Inserção de FUNCIONÁRIOS
        ///
        ///INSERT INTO FUNCIONARIO (
        ///	CD_FUNC,
        ///	CD_CARGO,
        ///	NOME_FUNC,
        ///	END_FUNC,
        ///	CEP_FUNC,
        ///	CIDADE,
        ///	TEL_RES,
        ///	TEL_CEL) VALUES
        ///	(
        ///		{0}
        ///		,{1}
        ///		,&apos;{2}&apos;
        ///		,&apos;{3}&apos;
        ///		,&apos;{4}&apos;
        ///		,&apos;{5}&apos;
        ///		,&apos;{6}&apos;
        ///		,&apos;{7}&apos;
        ///	).
        /// </summary>
        public static string qInsertFuncionario {
            get {
                return ResourceManager.GetString("qInsertFuncionario", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- Inserção de horas aulas
        ///
        ///INSERT INTO HORA_AULA(
        ///	CD_HORA_AULA,
        ///	CD_HORARIO,
        ///	CD_AULA) VALUES
        ///	(
        ///		{0}
        ///		,{1}
        ///		,{2}
        ///	).
        /// </summary>
        public static string qInsertHoraAula {
            get {
                return ResourceManager.GetString("qInsertHoraAula", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- Inserir HORARIO
        ///INSERT INTO HORARIO
        ///(CD_HORARIO, DATA_HORARIO, HORA)
        ///Values ({0}, &apos;{1}&apos;, &apos;{2}&apos;).
        /// </summary>
        public static string qInsertHorario {
            get {
                return ResourceManager.GetString("qInsertHorario", resourceCulture);
            }
        }
    }
}
