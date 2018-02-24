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
    /// Point class
    /// Reference implementation of a NPC class consisting of a pair of x and y coordinates
    /// </summary>
    /// <seealso cref="NeoPersistableClass.NeoTrace" />
    public class Point : NeoTrace
    {
        /// <summary>
        /// Core fields (NPC Level all)
        /// </summary>

        /// <summary>
        /// X coordinate
        /// </summary>
        private BigInteger _x;
        /// <summary>
        /// Y coordinate
        /// </summary>
        private BigInteger _y;
        /// <summary>
        /// Entity state
        /// </summary>
        private NeoEntityModel.EntityState _state;
        /// <summary>
        /// Extension script hash
        /// </summary>
        private byte[] _extension;

        // Accessors (NPC Level all)

        /// <summary>
        /// Gets X coordinate
        /// </summary>
        /// <param name="p">p</param>
        /// <param name="value">value</param>
        /// <returns>void</returns>
        public static void SetX(Point p, BigInteger value) { p._x = value; p._state = NeoEntityModel.EntityState.SET; }
        /// <summary>
        /// Gets X coordinate
        /// </summary>
        /// <param name="p">p</param>
        /// <returns>BigInteger</returns>
        public static BigInteger GetX(Point p) { return p._x; }
        /// <summary>
        /// Sets Y coordinate
        /// </summary>
        /// <param name="p">p</param>
        /// <param name="value">value</param>
        /// <returns>void</returns>
        public static void SetY(Point p, BigInteger value) { p._y = value; p._state = NeoEntityModel.EntityState.SET; }
        /// <summary>
        /// Gets Y coordinate
        /// </summary>
        /// <param name="p">p</param>
        /// <returns>BigInteger</returns>
        public static BigInteger GetY(Point p) { return p._y; }
        /// <summary>
        /// Sets Extension script hash
        /// </summary>
        /// <param name="p">p</param>
        /// <param name="value">value</param>
        /// <returns>void</returns>
        public static void SetExtension(Point p, byte[] value) { p._extension = value; }
        /// <summary>
        /// Gets Extension script hash.
        /// </summary>
        /// <param name="p">p</param>
        /// <returns>extension</returns>
        public static byte[] GetExtension(Point p) { return p._extension; }
        /// <summary>
        /// Sets the specified Point field values
        /// </summary>
        /// <param name="p">p</param>
        /// <param name="xvalue">xvalue</param>
        /// <param name="yvalue">yvalue</param>
        /// <returns>void</returns>
        public static void Set(Point p, BigInteger xvalue, BigInteger yvalue) { p._x = xvalue; p._y = yvalue; p._state = NeoEntityModel.EntityState.SET; }

        //public int X
        //{
        //    get { return _x; }
        //    set { _x = value; }
        //}
        //public int Y
        //{
        //    get { return _y; }
        //    set { _y = value; }
        //}

        //public int X { get => _x; set => _x = value; }
        //public int Y { get => _y; set => _y = value; }

        // Metadata fields (NPC Level all)        

        private const string _className = "Point";
        private const string _sX = "X";
        private const string _sY = "Y";
        private const string _sSTA = "_STA";
        private const string _sEXT = "_EXT";
        private static readonly byte[] _bX = Helper.AsByteArray(_sX);
        private static readonly byte[] _bY = Helper.AsByteArray(_sY);
        private static readonly byte[] _bSTA = Helper.AsByteArray(_sSTA);
        private static readonly byte[] _bEXT = Helper.AsByteArray(_sEXT);

        // System fields (NPC Level all)

        private const string _classKeyTag = "/#" + _className + ".";
        private static readonly byte[] _bclassKeyTag = Helper.AsByteArray(_classKeyTag);

        // Factory methods (NPC Level all)

        /// <summary>
        /// Prevents a default instance of the <see cref="Point"/> class from being created.
        /// </summary>
        private Point()
        {
        }

        /// <summary>
        /// Initializes the specified Point field values
        /// </summary>
        /// <param name="p">p</param>
        /// <returns>Point</returns>
        private static Point _Initialize(Point p)
        {
            p._x = 0;
            p._y = 0;
            p._state = NeoEntityModel.EntityState.NULL;
            p._extension = NeoEntityModel.NullScriptHash;
            LogExt("_Initialize(p).p", p);
            return p;
        }

        /// <summary>
        /// Create a new entity initialized with "zero" values
        /// </summary>
        /// <returns>Point</returns>
        public static Point New()
        {
            Point p = new Point();
            _Initialize(p);
            LogExt("New().p", p);
            return p;
        }

        /// <summary>
        /// Create a new entity initialized with (x,y) values
        /// </summary>
        /// <param name="x">x</param>
        /// <param name="y">y</param>
        /// <returns>Point</returns>
        public static Point New(int x, int y)
        {
            Point p = new Point();
            p._x = x;
            p._y = y;
            p._state = NeoEntityModel.EntityState.INIT;
            p._extension = NeoEntityModel.NullScriptHash;
            LogExt("New(x,y).p", p);
            return p;
        }

        /// <summary>
        /// Create a new entity representing a Null entity
        /// </summary>
        /// <returns>Point</returns>
        public static Point Null()
        {
            Point p = new Point();
            _Initialize(p);
            LogExt("Null().p", p);
            return p;
        }

        // EntityState wrapper methods (NPC Level all)

        /// <summary>
        /// Test whether the specified entity is Null.
        /// </summary>
        /// <param name="p">p</param>
        /// <returns>bool</returns>
        public static bool IsNull(Point p)
        {
            return (p._state == NeoEntityModel.EntityState.NULL);
        }

        // Logging methods (NPC Level all)

        /// <summary>
        /// Log the entity's core fields
        /// </summary>
        /// <param name="label">label</param>
        /// <param name="p">p</param>
        /// <returns>void</returns>
        public static void Log(string label, Point p)
        {
            NeoTrace.Trace(label, p._x, p._y);
        }

        /// <summary>
        /// Log the entity's core and system fields
        /// </summary>
        /// <param name="label">label</param>
        /// <param name="p">p</param>
        /// <returns>void</returns>
        public static void LogExt(string label, Point p)
        {
            NeoTrace.Trace(label, p._x, p._y, p._state, p._extension); // long values, state, extension last
        }

        // Persistable methods (NPC Level 2)

        /// <summary>
        /// Test whether the specified entity is Missing.
        /// </summary>
        /// <param name="p">p</param>
        /// <returns>bool</returns>
        public static bool IsMissing(Point p)
        {
            return (p._state == NeoEntityModel.EntityState.MISSING);
        }

        /// <summary>
        /// Create a new entity representing a Missing entity
        /// </summary>
        /// <returns>Point</returns>
        public static Point Missing()
        {
            Point p = new Point();
            p._x = 0;
            p._y = 0;
            p._state = NeoEntityModel.EntityState.MISSING;
            p._extension = NeoEntityModel.NullScriptHash;
            LogExt("Missing().p", p);
            return p;
        }

        /// <summary>
        /// Put an entity into Storage based on a byte[] valued key (NPC Level 2)
        /// </summary>
        /// <param name="p">p</param>
        /// <param name="bkey">bkey</param>
        /// <returns>bool</returns>
        public static bool Put(Point p, byte[] bkey)
        {
            if (bkey.Length == 0) return false;

            Neo.SmartContract.Framework.Services.Neo.StorageContext ctx = Neo.SmartContract.Framework.Services.Neo.Storage.CurrentContext;
            byte[] _bkeyTag = Helper.Concat(bkey, _bclassKeyTag);

            p._state = NeoEntityModel.EntityState.PUTTED;
            /*STA*/
            Neo.SmartContract.Framework.Services.Neo.Storage.Put(ctx, Helper.Concat(_bkeyTag, _bSTA), p._state.AsBigInteger());
            /*EXT*/
            Neo.SmartContract.Framework.Services.Neo.Storage.Put(ctx, Helper.Concat(_bkeyTag, _bEXT), p._extension);
            /*FIELD*/
            Neo.SmartContract.Framework.Services.Neo.Storage.Put(ctx, Helper.Concat(_bkeyTag, _bX), p._x);
            /*FIELD*/
            Neo.SmartContract.Framework.Services.Neo.Storage.Put(ctx, Helper.Concat(_bkeyTag, _bY), p._y);
            LogExt("Put(bkey).p", p);
            return true;
        }

        /// <summary>
        /// Put an entity into Storage based on a string valued key (NPC Level 2)
        /// </summary>
        /// <param name="p">p</param>
        /// <param name="skey">skey</param>
        /// <returns>bool</returns>
        public static bool Put(Point p, string skey)
        {
            if (skey.Length == 0) return false;
            LogExt("Put(ks).p", p);

            Neo.SmartContract.Framework.Services.Neo.StorageContext ctx = Neo.SmartContract.Framework.Services.Neo.Storage.CurrentContext;
            string _skeyTag = skey + _classKeyTag;
            Trace("Put(ks)._skeyTag", _skeyTag);

            p._state = NeoEntityModel.EntityState.PUTTED;
            BigInteger bis = p._state.AsBigInteger();
            Trace("Put(ks).bis", bis);
            /*STA*/
            Neo.SmartContract.Framework.Services.Neo.Storage.Put(ctx, _skeyTag + _sSTA, bis);
            /*EXT*/
            Neo.SmartContract.Framework.Services.Neo.Storage.Put(ctx, _skeyTag + _sEXT, p._extension);
            /*FIELD*/
            Neo.SmartContract.Framework.Services.Neo.Storage.Put(ctx, _skeyTag + _sX, p._x);
            /*FIELD*/
            Neo.SmartContract.Framework.Services.Neo.Storage.Put(ctx, _skeyTag + _sY, p._y);
            LogExt("Put(ks).p", p);
            return true;
        }

        /// <summary>
        /// Get an entity from Storage based on a byte[] valued key (NPC Level 2)
        /// </summary>
        /// <param name="bkey">bkey</param>
        /// <returns>Point</returns>
        public static Point Get(byte[] bkey)
        {
            if (bkey.Length == 0) return Null();

            Neo.SmartContract.Framework.Services.Neo.StorageContext ctx = Neo.SmartContract.Framework.Services.Neo.Storage.CurrentContext;
            byte[] _bkeyTag = Helper.Concat(bkey, _bclassKeyTag);

            Point p;
            /*STA*/
            byte[] bsta = Neo.SmartContract.Framework.Services.Neo.Storage.Get(ctx, Helper.Concat(_bkeyTag, _bSTA));
            NeoTrace.Trace("Get(kb).bs", bsta.Length, bsta);
            if (bsta.Length == 0)
            {
                p = Point.Missing();
            }
            else // not MISSING
            {
                /*EXT*/
                byte[] bext = Neo.SmartContract.Framework.Services.Neo.Storage.Get(ctx, Helper.Concat(_bkeyTag, _bEXT));
                int ista = (int)bsta.AsBigInteger();
                NeoEntityModel.EntityState sta = (NeoEntityModel.EntityState)ista;
                if (sta == NeoEntityModel.EntityState.TOMBSTONED)
                {
                    p = Point.Tombstone();
                    p._extension = bext; // TODO: does a Tomestone bury all of its extensions?
                }
                else // not MISSING && not TOMBSTONED
                {
                    p = new Point();
                    /*FIELD*/
                    BigInteger x = Neo.SmartContract.Framework.Services.Neo.Storage.Get(ctx, Helper.Concat(_bkeyTag, _bX)).AsBigInteger();
                    /*FIELD*/
                    BigInteger y = Neo.SmartContract.Framework.Services.Neo.Storage.Get(ctx, Helper.Concat(_bkeyTag, _bY)).AsBigInteger();
                    p._x = x;
                    p._y = y;
                    p._state = sta;
                    p._state = NeoEntityModel.EntityState.GETTED; /* OVERRIDE */
                    p._extension = bext;
                }
            }
            LogExt("Get(kb).p", p);
            return p;
        }

        /// <summary>
        /// Get an entity from Storage based on a string valued key (NPC Level 2)
        /// </summary>
        /// <param name="skey">skey</param>
        /// <returns>Point</returns>
        public static Point Get(string skey)
        {
            if (skey.Length == 0) return Null();

            Neo.SmartContract.Framework.Services.Neo.StorageContext ctx = Neo.SmartContract.Framework.Services.Neo.Storage.CurrentContext;
            string _skeyTag = skey + _classKeyTag;

            Point p;
            /*STA*/
            byte[] bsta = Neo.SmartContract.Framework.Services.Neo.Storage.Get(ctx, _skeyTag + _sSTA);
            NeoTrace.Trace("Get(ks).bs", bsta.Length, bsta);
            if (bsta.Length == 0)
            {
                p = Point.Missing();
            }
            else // not MISSING
            {
                /*EXT*/
                byte[] bext = Neo.SmartContract.Framework.Services.Neo.Storage.Get(ctx, _skeyTag + _sEXT);
                int ista = (int)bsta.AsBigInteger();
                NeoEntityModel.EntityState sta = (NeoEntityModel.EntityState)ista;
                if (sta == NeoEntityModel.EntityState.TOMBSTONED)
                {
                    p = Point.Tombstone();
                    p._extension = bext; // TODO: does a Tomestone bury all of its extensions?
                }
                else // not MISSING && not TOMBSTONED
                {
                    p = new Point();
                    /*FIELD*/
                    BigInteger x = Neo.SmartContract.Framework.Services.Neo.Storage.Get(ctx, _skeyTag + _sX).AsBigInteger();
                    /*FIELD*/
                    BigInteger y = Neo.SmartContract.Framework.Services.Neo.Storage.Get(ctx, _skeyTag + _sY).AsBigInteger();
                    NeoTrace.Trace("Get(ks).x,y", x, y);
                    p._x = x;
                    p._y = y;
                    p._state = sta;
                    p._state = NeoEntityModel.EntityState.GETTED; /* OVERRIDE */
                    p._extension = bext;
                }
            }
            LogExt("Get(ks).p", p);
            return p;
        }

        // Deletable methods (NPC Level 3)

        /// <summary>
        /// Test whether the specified entity is Buried (Tombstoned)
        /// </summary>
        /// <param name="p">p</param>
        /// <returns>bool</returns>
        public static bool IsBuried(Point p)
        {
            return (p._state == NeoEntityModel.EntityState.TOMBSTONED);
        }

        /// <summary>
        /// Create a new entity representing a Tombstoned entity (NPC Level 3)
        /// </summary>
        /// <returns>Point</returns>
        public static Point Tombstone()
        {
            Point p = new Point();
            p._x = 0;
            p._y = 0;
            p._state = NeoEntityModel.EntityState.TOMBSTONED;
            p._extension = NeoEntityModel.NullScriptHash;
            LogExt("Tombstone().p", p);
            return p;
        }

        /// <summary>
        /// Bury an entity in Storage based on a byte[] valued key (NPC Level 3)
        /// </summary>
        /// <param name="bkey">bkey</param>
        /// <returns>Point</returns>
        public static Point Bury(byte[] bkey)
        {
            if (bkey.Length == 0) return Null(); // TODO - create NeoEntityModel.EntityState.BADKEY?

            Neo.SmartContract.Framework.Services.Neo.StorageContext ctx = Neo.SmartContract.Framework.Services.Neo.Storage.CurrentContext;
            byte[] _bkeyTag = Helper.Concat(bkey, _bclassKeyTag);

            Point p;
            /*STA*/
            byte[] bsta = Neo.SmartContract.Framework.Services.Neo.Storage.Get(ctx, Helper.Concat(_bkeyTag, _bSTA));
            NeoTrace.Trace("Bury(kb).bs", bsta.Length, bsta);
            if (bsta.Length == 0)
            {
                p = Point.Missing();
            }
            else // not MISSING - bury it
            {
                p = Point.Tombstone(); // TODO - should Bury() preserve the exist field values or re-initialize them? Preserve is cheaper but not as private
                /*STA*/
                Neo.SmartContract.Framework.Services.Neo.Storage.Put(ctx, Helper.Concat(_bkeyTag, _bSTA), p._state.AsBigInteger());
                /*EXT*/
                Neo.SmartContract.Framework.Services.Neo.Storage.Put(ctx, Helper.Concat(_bkeyTag, _bEXT), p._extension);
                /*FIELD*/
                Neo.SmartContract.Framework.Services.Neo.Storage.Put(ctx, Helper.Concat(_bkeyTag, _bX), p._x);
                /*FIELD*/
                Neo.SmartContract.Framework.Services.Neo.Storage.Put(ctx, Helper.Concat(_bkeyTag, _bY), p._y);
            }
            LogExt("Bury(kb).p", p);
            return p; // return Point p to signal if key is Missing or bad key
        }

        /// <summary>
        /// Bury an entity in Storage based on a string valued key (NPC Level 3)
        /// </summary>
        /// <param name="skey">skey</param>
        /// <returns>Point</returns>
        public static Point Bury(string skey)
        {
            if (skey.Length == 0) return Null(); // TODO - create NeoEntityModel.EntityState.BADKEY?

            Neo.SmartContract.Framework.Services.Neo.StorageContext ctx = Neo.SmartContract.Framework.Services.Neo.Storage.CurrentContext;
            string _skeyTag = skey + _classKeyTag;

            Point p;
            /*STA*/
            byte[] bsta = Neo.SmartContract.Framework.Services.Neo.Storage.Get(ctx, _skeyTag + _sSTA);
            NeoTrace.Trace("Bury(ks).bs", bsta.Length, bsta);
            if (bsta.Length == 0)
            {
                p = Point.Missing();
            }
            else // not MISSING - bury it
            {
                p = Point.Tombstone(); // TODO - should Bury() preserve the exist field values or re-initialize them? Preserve is cheaper but not as private
                /*STA*/
                Neo.SmartContract.Framework.Services.Neo.Storage.Put(ctx, _skeyTag + _sSTA, p._state.AsBigInteger());
                /*EXT*/
                Neo.SmartContract.Framework.Services.Neo.Storage.Put(ctx, _skeyTag + _sEXT, p._extension);
                /*FIELD*/
                Neo.SmartContract.Framework.Services.Neo.Storage.Put(ctx, _skeyTag + _sX, p._x);
                /*FIELD*/
                Neo.SmartContract.Framework.Services.Neo.Storage.Put(ctx, _skeyTag + _sY, p._y);
            }
            LogExt("Bury(ks).p", p);
            return p; // return Point p to signal if key is Missing or bad key
        }

        /// <summary>
        /// Collectible methods (NPC Level 4)
        /// </summary>
        /// <param name="p">p</param>
        /// <param name="vau">vau</param>
        /// <param name="index">index</param>
        /// <returns>bool</returns>
        public static bool PutElement(Point p, NeoVersionedAppUser vau, int index)
        {
            if (NeoVersionedAppUser.IsNull(vau)) return false;

            Neo.SmartContract.Framework.Services.Neo.StorageContext ctx = Neo.SmartContract.Framework.Services.Neo.Storage.CurrentContext;
            NeoStorageKey nsk = NeoStorageKey.New(vau, "Point");

            byte[] bkey;
            p._state = NeoEntityModel.EntityState.PUTTED;
            /*STA*/
            Neo.SmartContract.Framework.Services.Neo.Storage.Put(ctx, bkey = NeoStorageKey.StorageKey(nsk, index, _bSTA), p._state.AsBigInteger());
            /*EXT*/
            Neo.SmartContract.Framework.Services.Neo.Storage.Put(ctx, bkey = NeoStorageKey.StorageKey(nsk, index, _bEXT), p._extension);
            /*FIELD*/
            Neo.SmartContract.Framework.Services.Neo.Storage.Put(ctx, bkey = NeoStorageKey.StorageKey(nsk, index, _bX), p._x);
            /*FIELD*/
            Neo.SmartContract.Framework.Services.Neo.Storage.Put(ctx, bkey = NeoStorageKey.StorageKey(nsk, index, _bY), p._y);
            LogExt("PutElement(vau,i).p", p);
            return true;
        }

        /// <summary>
        /// Get an element of an array of entities from Storage based on a NeoStorageKey (NPC Level 4)
        /// </summary>
        /// <param name="vau">vau</param>
        /// <param name="index">index</param>
        /// <returns>Point</returns>
        public static Point GetElement(NeoVersionedAppUser vau, int index)
        {
            if (NeoVersionedAppUser.IsNull(vau)) return Null();

            Neo.SmartContract.Framework.Services.Neo.StorageContext ctx = Neo.SmartContract.Framework.Services.Neo.Storage.CurrentContext;
            NeoStorageKey nsk = NeoStorageKey.New(vau, "Point");

            Point p;
            byte[] bkey;
            /*STA*/
            byte[] bsta = Neo.SmartContract.Framework.Services.Neo.Storage.Get(ctx, bkey = NeoStorageKey.StorageKey(nsk, index, _bSTA));
            NeoTrace.Trace("Get(kb).bs", bsta.Length, bsta);
            if (bsta.Length == 0)
            {
                p = Point.Missing();
            }
            else // not MISSING
            {
                /*EXT*/
                byte[] bext = Neo.SmartContract.Framework.Services.Neo.Storage.Get(ctx, bkey = NeoStorageKey.StorageKey(nsk, index, _bEXT));
                int ista = (int)bsta.AsBigInteger();
                NeoEntityModel.EntityState sta = (NeoEntityModel.EntityState)ista;
                if (sta == NeoEntityModel.EntityState.TOMBSTONED)
                {
                    p = Point.Tombstone();
                    p._extension = bext; // TODO: does a Tomestone bury all of its extensions?
                }
                else // not MISSING && not TOMBSTONED
                {
                    p = new Point();
                    /*FIELD*/
                    BigInteger x = Neo.SmartContract.Framework.Services.Neo.Storage.Get(ctx, bkey = NeoStorageKey.StorageKey(nsk, index, _bX)).AsBigInteger();
                    /*FIELD*/
                    BigInteger y = Neo.SmartContract.Framework.Services.Neo.Storage.Get(ctx, bkey = NeoStorageKey.StorageKey(nsk, index, _bY)).AsBigInteger();
                    p._x = x;
                    p._y = y;
                    p._state = sta;
                    p._state = NeoEntityModel.EntityState.GETTED; /* OVERRIDE */
                    p._extension = bext;
                }
            }
            LogExt("Get(kb).p", p);
            return p;
        }

        /// <summary>
        /// Bury an element of an array of entities in Storage based on a NeoStorageKey (NPC Level 4)
        /// </summary>
        /// <param name="vau">vau</param>
        /// <param name="index">index</param>
        /// <returns>Point</returns>
        public static Point BuryElement(NeoVersionedAppUser vau, int index)
        {
            if (NeoVersionedAppUser.IsNull(vau)) // TODO - create NeoEntityModel.EntityState.BADKEY?
            {
                return Point.Null();
            }

            Neo.SmartContract.Framework.Services.Neo.StorageContext ctx = Neo.SmartContract.Framework.Services.Neo.Storage.CurrentContext;
            NeoStorageKey nsk = NeoStorageKey.New(vau, "Point");

            byte[] bkey;
            Point p;
            /*STA*/
            byte[] bsta = Neo.SmartContract.Framework.Services.Neo.Storage.Get(ctx, bkey = NeoStorageKey.StorageKey(nsk, index, _bSTA));
            NeoTrace.Trace("Bury(vau,index).bs", bsta.Length, bsta);
            if (bsta.Length == 0)
            {
                p = Point.Missing();
            }
            else // not MISSING - bury it
            {
                p = Point.Tombstone(); // TODO - should Bury() preserve the exist field values or re-initialize them? Preserve is cheaper but not as private
                /*STA*/
                Neo.SmartContract.Framework.Services.Neo.Storage.Put(ctx, bkey = NeoStorageKey.StorageKey(nsk, index, _bSTA), p._state.AsBigInteger());
                /*EXT*/
                Neo.SmartContract.Framework.Services.Neo.Storage.Put(ctx, bkey = NeoStorageKey.StorageKey(nsk, index, _bEXT), p._extension);
                /*FIELD*/
                Neo.SmartContract.Framework.Services.Neo.Storage.Put(ctx, bkey = NeoStorageKey.StorageKey(nsk, index, _bX), p._x);
                /*FIELD*/
                Neo.SmartContract.Framework.Services.Neo.Storage.Put(ctx, bkey = NeoStorageKey.StorageKey(nsk, index, _bY), p._y);
            }
            LogExt("Bury(vau,i).p", p);
            return p;
        }

        // Extensible methods (NPC Level 5 - Future Work)

        /// <summary>
        /// Test whether the specified entity has been Extended.
        /// </summary>
        /// <param name="p">p</param>
        /// <returns>bool</returns>
        public static bool IsExtended(Point p)
        {
            return (p._extension != NeoEntityModel.NullScriptHash);
        }
    }
}
