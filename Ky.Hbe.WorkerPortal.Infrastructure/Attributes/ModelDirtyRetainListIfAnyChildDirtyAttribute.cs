using System;
using System.Net;

namespace Ky.Hbe.WorkerPortal.Infrastructure.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class ModelDirtyRetainListIfAnyChildDirty : Attribute
    {

    }
}
