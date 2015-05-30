﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Playerlog.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Playerlog.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to DROP TRIGGER IF EXISTS players_log_insert;
        ///DROP TRIGGER IF EXISTS playerlog_insert;
        ///DROP TRIGGER IF EXISTS plog_insert;
        ///CREATE TRIGGER playerlog_insert BEFORE INSERT ON players
        ///FOR EACH ROW
        ///	BEGIN
        ///			INSERT INTO players_log SET uid = new.uid, logtype = &apos;insert&apos;, 
        ///			cash = new.cash, bank = new.bankacc, totalcash = new.cash + new.bankacc;
        ///	END;.
        /// </summary>
        internal static string Query_01 {
            get {
                return ResourceManager.GetString("Query_01", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DROP TRIGGER IF EXISTS players_log_update;
        ///DROP TRIGGER IF EXISTS playerlog_update;
        ///DROP TRIGGER IF EXISTS plog_update;
        ///CREATE TRIGGER playerlog_update AFTER UPDATE ON players
        ///FOR EACH ROW
        ///	BEGIN
        ///		INSERT INTO players_log SET uid = old.uid, logtype = &apos;update&apos;, 
        ///		cash = new.cash, bank = new.bankacc,
        ///		totalcash = new.cash + new.bankacc;
        ///	END;.
        /// </summary>
        internal static string Query_02 {
            get {
                return ResourceManager.GetString("Query_02", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DROP TRIGGER IF EXISTS players_log_insert;
        ///DROP TRIGGER IF EXISTS playerlog_insert;
        ///DROP TRIGGER IF EXISTS plog_insert;.
        /// </summary>
        internal static string Query_03 {
            get {
                return ResourceManager.GetString("Query_03", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DROP TRIGGER IF EXISTS players_log_update;
        ///DROP TRIGGER IF EXISTS playerlog_update;
        ///DROP TRIGGER IF EXISTS plog_update;.
        /// </summary>
        internal static string Query_04 {
            get {
                return ResourceManager.GetString("Query_04", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE IF NOT EXISTS `players_log` (
        ///  `uid` int(11) NOT NULL,
        ///  `updatetime` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
        ///  `logtype` enum(&apos;update&apos;,&apos;insert&apos;) NOT NULL,
        ///  `cash` int(100) NOT NULL,
        ///  `bank` int(100) NOT NULL,
        ///  `totalcash` int(100) NOT NULL,
        ///  PRIMARY KEY (`uid`,`updatetime`)
        ///) ENGINE=InnoDB DEFAULT CHARSET=latin1;.
        /// </summary>
        internal static string Query_05 {
            get {
                return ResourceManager.GetString("Query_05", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DROP TABLE IF EXISTS players_log;.
        /// </summary>
        internal static string Query_06 {
            get {
                return ResourceManager.GetString("Query_06", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TRUNCATE TABLE players_log;.
        /// </summary>
        internal static string Query_07 {
            get {
                return ResourceManager.GetString("Query_07", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DROP TRIGGER IF EXISTS players_log_insert;
        ///DROP TRIGGER IF EXISTS playerlog_insert;
        ///DROP TRIGGER IF EXISTS plog_insert;
        ///CREATE TRIGGER playerlog_insert BEFORE INSERT ON players
        ///FOR EACH ROW
        ///	BEGIN
        ///			INSERT INTO players_log SET uid = new.uid, logtype = &apos;insert&apos;, 
        ///			cash = new.cash, bank = new.bankacc, totalcash = new.cash + new.bankacc;
        ///	END;.
        /// </summary>
        internal static string Query_11 {
            get {
                return ResourceManager.GetString("Query_11", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DROP TRIGGER IF EXISTS players_log_update;
        ///DROP TRIGGER IF EXISTS playerlog_update;
        ///DROP TRIGGER IF EXISTS plog_update;
        ///CREATE TRIGGER playerlog_update AFTER UPDATE ON players
        ///FOR EACH ROW
        ///	BEGIN
        ///		INSERT INTO players_log SET uid = old.uid, logtype = &apos;update&apos;, 
        ///		cash = new.cash, bank = new.bankacc,
        ///		totalcash = new.cash + new.bankacc;
        ///	END;.
        /// </summary>
        internal static string Query_12 {
            get {
                return ResourceManager.GetString("Query_12", resourceCulture);
            }
        }
    }
}