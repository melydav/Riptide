// This file isn't provided under The MIT License as a part of RiptideNetworking, rather an extension of it.
// Copyright (c) Dávid "Davee" M.
// For additional information on Riptide's licensing, please see the included LICENSE.md file or view it on GitHub:
// https://github.com/RiptideNetworking/Riptide/blob/main/LICENSE.md

using System;

namespace Riptide
{
    /// <summary>Specifies a method as an Rpc method that can be called over the network.</summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class Rpc : Attribute
    {
        /// <summary>Initializes an Rpc.</summary>
        public Rpc() { }
    }
}
