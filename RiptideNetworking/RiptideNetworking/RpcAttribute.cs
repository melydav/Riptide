// This file isn't provided under The MIT License as a part of RiptideNetworking, rather an extension of it.
// Copyright (c) Dávid "Davee" M.
// For additional information on Riptide's licensing, please see the included LICENSE.md file or view it on GitHub:
// https://github.com/RiptideNetworking/Riptide/blob/main/LICENSE.md

using System;
using System.Collections.Generic;

namespace Riptide
{
    /// <summary>Specifies a method as an Rpc method that can be called over the network.</summary>
    /// <remarks>To get parameters from an RPC call, use <see cref="Message"/>'s GetObjects() method with an array of types, so the right amount of bits can be retrieved.</remarks>
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public class RpcAttribute : Attribute
    {
        /// <summary>Initializes an Rpc.</summary>
        public RpcAttribute() { }
    }
}
