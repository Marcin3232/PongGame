﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PongGame.Properties {
    using System;
    
    
    /// <summary>
    ///   Klasa zasobu wymagająca zdefiniowania typu do wyszukiwania zlokalizowanych ciągów itd.
    /// </summary>
    // Ta klasa została automatycznie wygenerowana za pomocą klasy StronglyTypedResourceBuilder
    // przez narzędzie, takie jak ResGen lub Visual Studio.
    // Aby dodać lub usunąć składową, edytuj plik ResX, a następnie ponownie uruchom narzędzie ResGen
    // z opcją /str lub ponownie utwórz projekt VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        /// Zwraca buforowane wystąpienie ResourceManager używane przez tę klasę.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PongGame.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Przesłania właściwość CurrentUICulture bieżącego wątku dla wszystkich
        ///   przypadków przeszukiwania zasobów za pomocą tej klasy zasobów wymagającej zdefiniowania typu.
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
        ///   Wyszukuje zlokalizowany zasób typu System.IO.UnmanagedMemoryStream podobny do zasobu System.IO.MemoryStream.
        /// </summary>
        internal static System.IO.UnmanagedMemoryStream Click {
            get {
                return ResourceManager.GetStream("Click", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Wyszukuje zlokalizowany zasób typu System.IO.UnmanagedMemoryStream podobny do zasobu System.IO.MemoryStream.
        /// </summary>
        internal static System.IO.UnmanagedMemoryStream GameOver {
            get {
                return ResourceManager.GetStream("GameOver", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Wyszukuje zlokalizowany zasób typu System.IO.UnmanagedMemoryStream podobny do zasobu System.IO.MemoryStream.
        /// </summary>
        internal static System.IO.UnmanagedMemoryStream hitDisc {
            get {
                return ResourceManager.GetStream("hitDisc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Wyszukuje zlokalizowany zasób typu System.IO.UnmanagedMemoryStream podobny do zasobu System.IO.MemoryStream.
        /// </summary>
        internal static System.IO.UnmanagedMemoryStream jumpToWall {
            get {
                return ResourceManager.GetStream("jumpToWall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Wyszukuje zlokalizowany zasób typu System.IO.UnmanagedMemoryStream podobny do zasobu System.IO.MemoryStream.
        /// </summary>
        internal static System.IO.UnmanagedMemoryStream loseBall {
            get {
                return ResourceManager.GetStream("loseBall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Wyszukuje zlokalizowany zasób typu System.IO.UnmanagedMemoryStream podobny do zasobu System.IO.MemoryStream.
        /// </summary>
        internal static System.IO.UnmanagedMemoryStream Win {
            get {
                return ResourceManager.GetStream("Win", resourceCulture);
            }
        }
    }
}