﻿using System;
using GenericScale;

namespace GenericScale
{
    public class EqualityScale<T>
    {
        private T left;
        private T rigth;
        public EqualityScale(T left,T rigth)
        {
            this.left = left;
            this.rigth = rigth;
        }
         public bool AreEqual()
        {
            return left.Equals(rigth);
        }
    }
}
