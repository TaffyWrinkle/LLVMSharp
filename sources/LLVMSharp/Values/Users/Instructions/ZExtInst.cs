// Copyright (c) Microsoft and Contributors. All rights reserved. Licensed under the University of Illinois/NCSA Open Source License. See LICENSE.txt in the project root for license information.

using LLVMSharp.Interop;

namespace LLVMSharp
{
    public sealed class ZExtInst : CastInst
    {
        internal ZExtInst(LLVMValueRef handle) : base(handle.IsAZExtInst)
        {
        }
    }
}
