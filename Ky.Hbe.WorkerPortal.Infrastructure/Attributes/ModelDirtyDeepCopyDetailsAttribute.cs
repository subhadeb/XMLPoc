using System;

namespace Ky.Hbe.WorkerPortal.Infrastructure.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class ModelDirtyDeepCopyDetails : Attribute
    {
        public bool CopyByReference { get; set; }
        public int CopyOrder { get; set; }

        public ModelDirtyDeepCopyDetails(int copyOrder = 999, bool copyByReference = false)
        {
            this.CopyByReference = copyByReference;
            this.CopyOrder = copyOrder;
        }
    }
}
