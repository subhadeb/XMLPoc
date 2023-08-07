using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ky.Hbe.WorkerPortal.Infrastructure.Model
{
    public class SignatureNavigationModel
    {
        public List<int> IndividualIds { get; set; }

        public Dictionary<int, string> IndividualIdsWithName { get; set; }

        public string SignatureReasonCode { get; set; }
    }
}
