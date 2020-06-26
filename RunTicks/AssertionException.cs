﻿using System;

namespace RunTicks
{
    public class AssertionException : Exception
    {
        public AssertionException(string message)
            : base(message)
        {

        }
        public override string ToString()
        {
            return this.Message;
        }
    }
}