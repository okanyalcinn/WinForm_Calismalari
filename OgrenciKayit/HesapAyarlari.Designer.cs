﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OgrenciKayit {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class HesapAyarlari : global::System.Configuration.ApplicationSettingsBase {
        
        private static HesapAyarlari defaultInstance = ((HesapAyarlari)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new HesapAyarlari())));
        
        public static HesapAyarlari Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string KullaniciAdi {
            get {
                return ((string)(this["KullaniciAdi"]));
            }
            set {
                this["KullaniciAdi"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Sifre {
            get {
                return ((string)(this["Sifre"]));
            }
            set {
                this["Sifre"] = value;
            }
        }
    }
}
