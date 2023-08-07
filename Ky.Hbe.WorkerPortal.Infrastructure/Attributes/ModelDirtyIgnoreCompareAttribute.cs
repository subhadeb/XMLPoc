using System;

namespace Ky.Hbe.WorkerPortal.Infrastructure.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class ModelDirtyIgnoreCompare : Attribute
    {
    }
}
