﻿using Neo.SmartContract.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NeoPesistenceClasses4
{
    public static class NeoEntityModel /* Level 4 Collectible */
    {
        public enum EntityState
        {
            NULL,
            INIT,
            SET,
            PUTTED,
            GETTED,
            MISSING,
            TOMBSTONED,
            NOTAUTHORIZED /* Future */
        }

        public static BigInteger AsBigInteger(this EntityState state)
        {
            int istate = (int)state;
            BigInteger bis = istate;
            return bis;
        }

        public static EntityState BytesToEntityState(byte[] bsta)
        {
            int ista = (int)bsta.AsBigInteger();
            NeoEntityModel.EntityState sta = (NeoEntityModel.EntityState)ista;
            return sta;
        }
    }
}
