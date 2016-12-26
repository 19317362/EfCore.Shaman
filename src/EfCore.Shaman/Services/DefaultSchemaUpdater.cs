﻿#region using

using System;
using System.Reflection;
using EfCore.Shaman.ModelScanner;

#endregion

namespace EfCore.Shaman.Services
{
    internal static class DefaultSchemaUpdater 
    {
        #region Static Methods

        public static string GetDefaultSchema(Type type)
        {
            var att = type.GetCustomAttribute<DefaultSchemaAttribute>();
            return att?.Schema;
        }

        #endregion

        
    }
}