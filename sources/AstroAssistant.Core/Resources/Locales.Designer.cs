﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.0
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AstroAssistant.Resources {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
    /// </summary>
    // Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
    // à l'aide d'un outil, tel que ResGen ou Visual Studio.
    // Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
    // avec l'option /str ou régénérez votre projet VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Locales {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Locales() {
        }
        
        /// <summary>
        ///   Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AstroAssistant.Resources.Locales", typeof(Locales).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Remplace la propriété CurrentUICulture du thread actuel pour toutes
        ///   les recherches de ressources à l'aide de cette classe de ressource fortement typée.
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
        ///   Recherche une chaîne localisée semblable à Le constructeur de contexte d&apos;application n&apos;est pas défini..
        /// </summary>
        internal static string AppContextBuilderNotDefined {
            get {
                return ResourceManager.GetString("AppContextBuilderNotDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Echec de création d&apos;un contexte d&apos;application..
        /// </summary>
        internal static string AppContextBuildFailed {
            get {
                return ResourceManager.GetString("AppContextBuildFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Calculé avec le fuseau horaire.
        /// </summary>
        internal static string DayLight_FromTimeZone_Caption {
            get {
                return ResourceManager.GetString("DayLight_FromTimeZone_Caption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Inactif.
        /// </summary>
        internal static string DayLight_Off_Caption {
            get {
                return ResourceManager.GetString("DayLight_Off_Caption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Actif.
        /// </summary>
        internal static string DayLight_On_Caption {
            get {
                return ResourceManager.GetString("DayLight_On_Caption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Femme.
        /// </summary>
        internal static string Gender_Female_Caption {
            get {
                return ResourceManager.GetString("Gender_Female_Caption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Homme.
        /// </summary>
        internal static string Gender_Male_Caption {
            get {
                return ResourceManager.GetString("Gender_Male_Caption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Voulez-vous enregistrer les modifications ?.
        /// </summary>
        internal static string SaveChangesDialogMessage {
            get {
                return ResourceManager.GetString("SaveChangesDialogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Enregistrer les modifications.
        /// </summary>
        internal static string SaveChangesDialogTitle {
            get {
                return ResourceManager.GetString("SaveChangesDialogTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Expression invalide. Doit être appelé avec une expression de type
        ///n() =&gt; PropertyName.
        /// </summary>
        internal static string WrongExpressionMessage {
            get {
                return ResourceManager.GetString("WrongExpressionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à Expression unaire invalide. Doit être appelé avec une expression de type
        ///n() =&gt; PropertyName.
        /// </summary>
        internal static string WrongUnaryExpressionMessage {
            get {
                return ResourceManager.GetString("WrongUnaryExpressionMessage", resourceCulture);
            }
        }
    }
}
