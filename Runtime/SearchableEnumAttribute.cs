﻿// ---------------------------------------------------------------------------- 
// Author: Ryan Hipple
// Date:   05/01/2018
// ----------------------------------------------------------------------------

using System;
using UnityEngine;

namespace Kogane
{
    [AttributeUsage( AttributeTargets.Field )]
    public sealed class SearchableEnumAttribute : PropertyAttribute
    {
    }
}