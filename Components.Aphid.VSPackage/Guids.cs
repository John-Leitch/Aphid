// Guids.cs
// MUST match guids.h
using System;

namespace Components.Aphid.VSPackage
{
    static class GuidList
    {
        public const string guidAphidPackagePkgString = "fe11c5b2-f1f0-49a9-bddc-f2c829aa4922";
        public const string guidAphidPackageCmdSetString = "ff925d28-a192-4801-ab9b-dbca5eb905b7";

        public static readonly Guid guidAphidPackageCmdSet = new Guid(guidAphidPackageCmdSetString);
    };
}