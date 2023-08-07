using System;

namespace Ky.Hbe.WorkerPortal.Infrastructure.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class ModelKey : Attribute
    {
        public int KeyIndex { get; set; }

        public ModelKey(int keyIndex)
        {
            KeyIndex = keyIndex;
        }
    }
}
