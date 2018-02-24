using Neo.SmartContract.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NeoCollectableClasses4
{
    /// <summary>
    /// NeoStorageKey class
    /// Used to manage NeoStorageKeys (NSKs) and the serialization of NSKs into
    /// NeoStorageKey Object Notation (NSKON)
    /// </summary>
    public class NeoStorageKey
    {
        private byte[] _app;
        private int _major;
        private int _minor;
        private int _build;
        private byte[] _userScriptHash;
        private byte[] _className;
        private int _index;
        private string _fieldName;
        private NeoEntityModel.EntityState _state;

        /// <summary>
        /// Sets the name of the application.
        /// </summary>
        /// <param name="nsk">NSK</param>
        /// <param name="value">value</param>
        /// <returns>void</returns>
        public static void SetAppName(NeoStorageKey nsk, byte[] value) { nsk._app = value; nsk._state = NeoEntityModel.EntityState.SET; }
        /// <summary>
        /// Gets the application name as byte array.
        /// </summary>
        /// <param name="nsk">NSK</param>
        /// <returns>app</returns>
        public static byte[] GetAppNameAsByteArray(NeoStorageKey nsk) { return nsk._app; }
        /// <summary>
        /// Sets the name of the application.
        /// </summary>
        /// <param name="nsk">NSK</param>
        /// <param name="value">value</param>
        /// <returns>void</returns>
        public static void SetAppName(NeoStorageKey nsk, string value) { nsk._app = value.AsByteArray(); nsk._state = NeoEntityModel.EntityState.SET; }
        /// <summary>
        /// Gets the application name as string.
        /// </summary>
        /// <param name="nsk">NSK</param>
        /// <returns>string</returns>
        public static string GetAppNameAsString(NeoStorageKey nsk) { return nsk._app.AsString(); }
        /// <summary>
        /// Sets the major version number of an application.
        /// </summary>
        /// <param name="nsk">NSK</param>
        /// <param name="value">value</param>
        /// <returns>void</returns>
        public static void SetMajor(NeoStorageKey nsk, int value) { nsk._major = value; nsk._state = NeoEntityModel.EntityState.SET; }
        /// <summary>
        /// Gets the major version number of an application.
        /// </summary>
        /// <param name="nsk">NSK</param>
        /// <returns>int</returns>
        public static int GetMajor(NeoStorageKey nsk) { return nsk._major; }
        /// <summary>
        /// Sets the minor version number of an application
        /// </summary>
        /// <param name="nsk">NSK</param>
        /// <param name="value">value</param>
        /// <returns>void</returns>
        public static void SetMinor(NeoStorageKey nsk, int value) { nsk._minor = value; nsk._state = NeoEntityModel.EntityState.SET; }
        /// <summary>
        /// Gets the minor version number of an application.
        /// </summary>
        /// <param name="nsk">NSK</param>
        /// <returns>int</returns>
        public static int GetMinor(NeoStorageKey nsk) { return nsk._minor; }
        /// <summary>
        /// Sets the build number of an application
        /// </summary>
        /// <param name="nsk">NSK</param>
        /// <param name="value">value</param>
        /// <returns>void</returns>
        public static void SetBuild(NeoStorageKey nsk, int value) { nsk._build = value; nsk._state = NeoEntityModel.EntityState.SET; }
        /// <summary>
        /// Gets the build number of an application
        /// </summary>
        /// <param name="nsk">NSK</param>
        /// <returns>int</returns>
        public static int GetBuild(NeoStorageKey nsk) { return nsk._build; }
        //public static void SetRevision(NeoStorageKey nsk, int value) { nsk._revision = value; nsk._state = NeoEntityModel.EntityState.SET; }
        //public static int GetRevision(NeoStorageKey nsk) { return nsk._revision; }
        /// <summary>
        /// Sets the userScriptHash of a NEO Storage Key.
        /// </summary>
        /// <param name="nsk">NSK</param>
        /// <param name="value">value</param>
        /// <returns>void</returns>
        public static void SetUserScriptHash(NeoStorageKey nsk, byte[] value) { nsk._userScriptHash = value; nsk._state = NeoEntityModel.EntityState.SET; }
        /// <summary>
        /// Gets the userScriptHash of a NEO Storage Key.
        /// </summary>
        /// <param name="nsk">NSK</param>
        /// <returns>userScriptHash</returns>
        public static byte[] GetUserScriptHash(NeoStorageKey nsk) { return nsk._userScriptHash; }
        /// <summary>
        /// Sets the class name of a NEO Storage Key
        /// </summary>
        /// <param name="nsk">NSK</param>
        /// <param name="value">value</param>
        /// <returns>void</returns>
        public static void SetClassName(NeoStorageKey nsk, byte[] value) { nsk._className = value; nsk._state = NeoEntityModel.EntityState.SET; }
        /// <summary>
        /// Gets the class name of a NEO Storage Key as byte array.
        /// </summary>
        /// <param name="nsk">NSK</param>
        /// <returns>className</returns>
        public static byte[] GetClassNameAsByteArray(NeoStorageKey nsk) { return nsk._className; }
        /// <summary>
        /// Sets the class name of the NEO Storage Key
        /// </summary>
        /// <param name="nsk">NSK</param>
        /// <param name="value">value</param>
        /// <returns>void</returns>
        public static void SetClassName(NeoStorageKey nsk, string value) { nsk._className = value.AsByteArray(); nsk._state = NeoEntityModel.EntityState.SET; }
        /// <summary>
        /// Gets the class name of a NEO Storage Key as string.
        /// </summary>
        /// <param name="nsk">NSK</param>
        /// <returns>string</returns>
        public static string GetClassNameAsString(NeoStorageKey nsk) { return nsk._className.AsString(); }
        /// <summary>
        /// Sets the index of a NEO Storage Key
        /// </summary>
        /// <param name="nsk">NSK</param>
        /// <param name="value">value</param>
        /// <returns>void</returns>
        public static void SetIndex(NeoStorageKey nsk, int value) { nsk._index = value; nsk._state = NeoEntityModel.EntityState.SET; }
        /// <summary>
        /// Gets the index of a NEO Storage Key
        /// </summary>
        /// <param name="nsk">NSK</param>
        /// <returns>int</returns>
        public static int GetIndex(NeoStorageKey nsk) { return nsk._index; }
        /// <summary>
        /// Sets the class field name of the NEO Storage Key.
        /// </summary>
        /// <param name="nsk">NSK</param>
        /// <param name="value">value</param>
        /// <returns>void</returns>
        public static void SetFieldName(NeoStorageKey nsk, string value) { nsk._fieldName = value; nsk._state = NeoEntityModel.EntityState.SET; }
        /// <summary>
        /// Gets the field name of the NEO Storage Key.
        /// </summary>
        /// <param name="nsk">NSK</param>
        /// <returns>string</returns>
        public static string GetFieldName(NeoStorageKey nsk) { return nsk._fieldName; }
        /// <summary>
        /// Sets the specified NEO Storage Key field values.
        /// </summary>
        /// <param name="nsk">NSK</param>
        /// <param name="app">application</param>
        /// <param name="major">major</param>
        /// <param name="minor">minor</param>
        /// <param name="build">build</param>
        /// <param name="userScriptHash">userScriptHash</param>
        /// <param name="className">class name</param>
        /// <param name="index">index</param>
        /// <param name="fieldName">field name</param>
        /// <returns>void</returns>
        public static void Set(NeoStorageKey nsk, byte[] app, int major, int minor, int build, /*int revision,*/ byte[] userScriptHash, byte[] className, int index, string fieldName)
        {
            nsk._app = app; nsk._major = major; nsk._minor = minor; nsk._build = build; /*nsk._revision = revision*/;
            nsk._userScriptHash = userScriptHash; nsk._className = className; nsk._index = index; nsk._fieldName = fieldName;
            nsk._state = NeoEntityModel.EntityState.SET;
        }
        /// <summary>
        /// Sets the specified NEO Storage Key field values.
        /// </summary>
        /// <param name="nsk">NSK</param>
        /// <param name="app">application</param>
        /// <param name="major">major</param>
        /// <param name="minor">minor</param>
        /// <param name="build">build</param>
        /// <param name="userScriptHash">userScriptHash</param>
        /// <param name="className">class name</param>
        /// <param name="index">index</param>
        /// <param name="fieldName">field name</param>
        /// <returns>void</returns>
        public static void Set(NeoStorageKey nsk, string app, int major, int minor, int build, /*int revision,*/ byte[] userScriptHash, string className, int index, string fieldName)
        {
            nsk._app = app.AsByteArray(); nsk._major = major; nsk._minor = minor; nsk._build = build; /*nsk._revision = revision*/;
            nsk._userScriptHash = userScriptHash; nsk._className = className.AsByteArray(); nsk._index = index; nsk._fieldName = fieldName;
            nsk._state = NeoEntityModel.EntityState.SET;
        }
        /// <summary>
        /// Sets the specified NEO Storage Key field values.
        /// </summary>
        /// <param name="nsk">NSK</param>
        /// <param name="vau">vau</param>
        /// <param name="userScriptHash">userScriptHash</param>
        /// <param name="className">class name</param>
        /// <param name="index">index</param>
        /// <param name="fieldName">field name</param>
        /// <returns>void</returns>
        public static void Set(NeoStorageKey nsk, NeoVersionedAppUser vau, byte[] userScriptHash, byte[] className, int index, string fieldName)
        {
            nsk._major = NeoVersionedAppUser.GetMajor(vau); nsk._minor = NeoVersionedAppUser.GetMinor(vau); nsk._build = NeoVersionedAppUser.GetBuild(vau); /*nsk._revision = NeoVersionedAppUser.GetRevision(vau);*/
            nsk._userScriptHash = NeoVersionedAppUser.GetUserScriptHash(vau);
            nsk._className = className; nsk._index = index; nsk._fieldName = fieldName;
            nsk._state = NeoEntityModel.EntityState.SET;
        }
        /// <summary>
        /// Sets the specified NEO Storage Key field values.
        /// </summary>
        /// <param name="nsk">NSK</param>
        /// <param name="vau">vau</param>
        /// <param name="userScriptHash">userScriptHash</param>
        /// <param name="className">class name</param>
        /// <param name="index">index</param>
        /// <param name="fieldName">field name</param>
        /// <returns>void</returns>
        public static void Set(NeoStorageKey nsk, NeoVersionedAppUser vau, byte[] userScriptHash, string className, int index, string fieldName)
        {
            nsk._major = NeoVersionedAppUser.GetMajor(vau); nsk._minor = NeoVersionedAppUser.GetMinor(vau); nsk._build = NeoVersionedAppUser.GetBuild(vau); /*nsk._revision = NeoVersionedAppUser.GetRevision(vau);*/
            nsk._userScriptHash = NeoVersionedAppUser.GetUserScriptHash(vau);
            nsk._className = className.AsByteArray(); nsk._index = index; nsk._fieldName = fieldName;
            nsk._state = NeoEntityModel.EntityState.SET;
        }

        // Factory methods
        /// <summary>
        /// Prevents a default instance of the <see cref="NeoStorageKey"/> class from being created.
        /// </summary>
        private NeoStorageKey()
        {
        }

        /// <summary>
        /// Initializes the specified NSK.
        /// </summary>
        /// <param name="nsk">NSK</param>
        /// <returns>NeoStorageKey</returns>
        private static NeoStorageKey _Initialize(NeoStorageKey nsk)
        {
            nsk._app = NeoEntityModel.NullByteArray;
            nsk._major = 0;
            nsk._minor = 0;
            nsk._build = 0;
            //nsk._revision = 0;
            nsk._userScriptHash = NeoEntityModel.NullScriptHash;
            nsk._className = NeoEntityModel.NullByteArray;
            nsk._index = 0;
            nsk._fieldName = "";
            nsk._state = NeoEntityModel.EntityState.NULL;
            LogExt("_Initialize(nsk).nsk", nsk);
            return nsk;
        }

        /// <summary>
        /// News this instance.
        /// </summary>
        /// <returns>NeoStorageKey</returns>
        public static NeoStorageKey New()
        {
            NeoStorageKey nsk = new NeoStorageKey();
            _Initialize(nsk);
            LogExt("New().nsk", nsk);
            return nsk;
        }

        /// <summary>
        /// News the specified application.
        /// </summary>
        /// <param name="app">application</param>
        /// <param name="major">major</param>
        /// <param name="minor">minor</param>
        /// <param name="build">build</param>
        /// <param name="userScriptHash">userScriptHash</param>
        /// <param name="className">class name</param>
        /// <param name="index">index</param>
        /// <param name="fieldName">field name</param>
        /// <returns>NeoStorageKey</returns>
        public static NeoStorageKey New(byte[] app, int major, int minor, int build, /*int revision,*/ byte[] userScriptHash, byte[] className, int index, string fieldName)
        {
            NeoStorageKey nsk = new NeoStorageKey();
            nsk._app = app;
            nsk._major = major;
            nsk._minor = minor;
            nsk._build = build;
            //nsk._revision = revision;
            nsk._userScriptHash = userScriptHash;
            nsk._className = className;
            nsk._index = index;
            nsk._fieldName = fieldName;
            nsk._state = NeoEntityModel.EntityState.INIT;
            LogExt("New(ab,m,m,b,u,cb,i,f,s).nsk", nsk);
            return nsk;
        }

        /// <summary>
        /// News the specified application.
        /// </summary>
        /// <param name="app">application</param>
        /// <param name="major">major</param>
        /// <param name="minor">minor</param>
        /// <param name="build">build</param>
        /// <param name="userScriptHash">userScriptHash</param>
        /// <param name="className">class name</param>
        /// <param name="index">index</param>
        /// <param name="fieldName">field name</param>
        /// <returns>NeoStorageKey</returns>
        public static NeoStorageKey New(string app, int major, int minor, int build, /*int revision,*/ byte[] userScriptHash, string className, int index, string fieldName)
        {
            NeoStorageKey nsk = new NeoStorageKey();
            nsk._app = app.AsByteArray();
            nsk._major = major;
            nsk._minor = minor;
            nsk._build = build;
            //nsk._revision = revision;
            nsk._userScriptHash = userScriptHash;
            nsk._className = className.AsByteArray();
            nsk._index = index;
            nsk._fieldName = fieldName;
            nsk._state = NeoEntityModel.EntityState.INIT;
            LogExt("New(as,m,m,b,u,cs,i,f,s).nsk", nsk);
            return nsk;
        }

        /// <summary>
        /// News the specified vau.
        /// </summary>
        /// <param name="vau">vau</param>
        /// <param name="className">class name</param>
        /// <returns>NeoStorageKey</returns>
        public static NeoStorageKey New(NeoVersionedAppUser vau, byte[] className)
        {
            if (NeoVersionedAppUser.IsNull(vau))
            {
                return NeoStorageKey.Null();
            }

            NeoStorageKey nsk = new NeoStorageKey();
            nsk._app = NeoVersionedAppUser.GetAppNameAsByteArray(vau);
            nsk._major = NeoVersionedAppUser.GetMajor(vau);
            nsk._minor = NeoVersionedAppUser.GetMinor(vau);
            nsk._build = NeoVersionedAppUser.GetBuild(vau);
            //nsk._revision = NeoVersionedAppUser.GetRevision(vau);
            nsk._userScriptHash = NeoVersionedAppUser.GetUserScriptHash(vau);
            nsk._className = className;
            nsk._index = 0;
            nsk._fieldName = "";
            nsk._state = NeoEntityModel.EntityState.INIT;
            LogExt("New(vau,bc)", nsk);
            return nsk;
        }

        /// <summary>
        /// News the specified vau.
        /// </summary>
        /// <param name="vau">vau</param>
        /// <param name="className">class name</param>
        /// <returns>NeoStorageKey</returns>
        public static NeoStorageKey New(NeoVersionedAppUser vau, string className)
        {
            if (NeoVersionedAppUser.IsNull(vau))
            {
                return NeoStorageKey.Null();
            }

            NeoStorageKey nsk = new NeoStorageKey();
            nsk._app = NeoVersionedAppUser.GetAppNameAsByteArray(vau);
            nsk._major = NeoVersionedAppUser.GetMajor(vau);
            nsk._minor = NeoVersionedAppUser.GetMinor(vau);
            nsk._build = NeoVersionedAppUser.GetBuild(vau);
            //nsk._revision = NeoVersionedAppUser.GetRevision(vau);
            nsk._userScriptHash = NeoVersionedAppUser.GetUserScriptHash(vau);
            nsk._className = className.AsByteArray();
            nsk._index = 0;
            nsk._fieldName = "";
            nsk._state = NeoEntityModel.EntityState.INIT;
            LogExt("New(vau,sc).nsk", nsk);
            return nsk;
        }

        /// <summary>
        /// Create a new entity representing a Null entity
        /// </summary>
        /// <returns>NeoStorageKey</returns>
        public static NeoStorageKey Null()
        {
            NeoStorageKey nsk = new NeoStorageKey();
            _Initialize(nsk);
            LogExt("Null().nsk", nsk);
            return nsk;
        }

        // EntityState wrapper methods

        /// <summary>
        /// Test whether the specified NeoStorageKey is Null.
        /// </summary>
        /// <param name="nsk">NSK</param>
        /// <returns>
        ///   <c>true</c> if the specified NSK is null; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNull(NeoStorageKey nsk)
        {
            return (nsk._state == NeoEntityModel.EntityState.NULL);
        }

        // Log/trace methods

        /// <summary>
        /// Logs the specified label.
        /// </summary>
        /// <param name="label">label</param>
        /// <param name="nsk">NSK</param>
        /// <returns>void</returns>
        public static void Log(string label, NeoStorageKey nsk)
        {
            NeoTrace.Trace(label, nsk._app, nsk._major, nsk._minor, nsk._build, /*nsk._revision,*/ nsk._className, nsk._index, nsk._fieldName, nsk._userScriptHash);
        }

        /// <summary>
        /// Logs the ext.
        /// </summary>
        /// <param name="label">label</param>
        /// <param name="nsk">NSK</param>
        /// <returns>void</returns>
        public static void LogExt(string label, NeoStorageKey nsk)
        {
            NeoTrace.Trace(label, nsk._app, nsk._major, nsk._minor, nsk._build, /*nsk._revision,*/ nsk._className, nsk._index, nsk._fieldName, nsk._userScriptHash, nsk._state); // long values, state, extension last
        }

        private static readonly byte[] _bLeftBrace = "{".AsByteArray();
        private static readonly byte[] _bRightBrace = "}".AsByteArray();
        private static readonly byte[] _bColon = ":".AsByteArray();
        private static readonly byte[] _bEquals = "=".AsByteArray();
        private static readonly byte[] _bSemiColon = ";".AsByteArray();
        private static readonly byte[] _ba = "a".AsByteArray(); // App name
        private static readonly byte[] _bM = "M".AsByteArray(); // App major version
        private static readonly byte[] _bm = "m".AsByteArray(); // App minor version
        private static readonly byte[] _bb = "b".AsByteArray(); // App build number
        //private static readonly byte[] _br = "r".AsByteArray(); // App revision number
        private static readonly byte[] _bu = "u".AsByteArray(); // User script hash
        private static readonly byte[] _bc = "c".AsByteArray(); // Class name
        private static readonly byte[] _bi = "i".AsByteArray(); // Index value
        private static readonly byte[] _bf = "f".AsByteArray(); // Field name

        private static readonly byte[] _bStringType = { (byte)Neo.SmartContract.ContractParameterType.String };
        private static readonly byte[] _bBigIntegerType = { (byte)Neo.SmartContract.ContractParameterType.Integer };
        private static readonly byte[] _bUserScriptHashType = { (byte)Neo.SmartContract.ContractParameterType.ByteArray };

        /// <summary>
        /// Compute a NEO Storage Key.
        /// </summary>
        /// <param name="nsk">NSK</param>
        /// <param name="index">index</param>
        /// <param name="fieldName">field name</param>
        /// <returns>bNeoStorageKey</returns>
        public static byte[] StorageKey(NeoStorageKey nsk, int index, byte[] fieldName)
        {
            LogExt("StorageKey(nsk,i,fb).nsk", nsk);

            byte[] bkey = Helper.Concat(_bLeftBrace, _ba).Concat(_bColon).Concat(_bStringType)
                                        .Concat(_bEquals).Concat(nsk._app).Concat(_bSemiColon);
            bkey = Helper.Concat(bkey, _bM).Concat(_bColon).Concat(_bBigIntegerType)
                                        .Concat(_bEquals).Concat(((BigInteger)(nsk._major)).AsByteArray()).Concat(_bSemiColon);
            bkey = Helper.Concat(bkey, _bm).Concat(_bColon).Concat(_bBigIntegerType)
                                        .Concat(_bEquals).Concat(((BigInteger)(nsk._minor)).AsByteArray()).Concat(_bSemiColon);
            bkey = Helper.Concat(bkey, _bb).Concat(_bColon).Concat(_bBigIntegerType)
                                        .Concat(_bEquals).Concat(((BigInteger)(nsk._build)).AsByteArray()).Concat(_bSemiColon);
            //bkey = Helper.Concat(bkey, _br).Concat(_bColon).Concat(_bBigIntegerType)
            //                          .Concat(_bEquals).Concat(((BigInteger)(nsk._revision)).AsByteArray()).Concat(_bComma);
            bkey = Helper.Concat(bkey, _bu).Concat(_bColon).Concat(_bUserScriptHashType)
                                        .Concat(_bEquals).Concat(nsk._userScriptHash).Concat(_bSemiColon);
            bkey = Helper.Concat(bkey, _bc).Concat(_bColon).Concat(_bStringType)
                                        .Concat(_bEquals).Concat(nsk._className).Concat(_bSemiColon);

            bkey = Helper.Concat(bkey, _bi).Concat(_bColon).Concat(_bBigIntegerType)
                                        .Concat(_bEquals).Concat(((BigInteger)(index)).AsByteArray()).Concat(_bSemiColon);
            bkey = Helper.Concat(bkey, _bf).Concat(_bColon).Concat(_bStringType)
                                        .Concat(_bEquals).Concat(fieldName).Concat(_bSemiColon);

            bkey = Helper.Concat(bkey, _bRightBrace);

            NeoTrace.Trace("StorageKey(nsk).bkey$BSK", bkey);
            return bkey;
        }
    }
}