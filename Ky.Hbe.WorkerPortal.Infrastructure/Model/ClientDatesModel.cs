using System;
using System.Net;


namespace Ky.Hbe.WorkerPortal.Infrastructure.Model
{
    public class ClientDatesModel
    {

        public ClientDatesModel()
        {
            IsValidate = true;
        }

        /// <summary>
        /// The client became aware date
        /// </summary>
        private DateTime? clientBecameAwareDate;

        /// <summary>
        /// The client reported date
        /// </summary>
        private DateTime? clientReportedDate;

        public bool IsValidate { get; set; }

        /// <summary>
        /// Gets or sets the client became aware date.
        /// </summary>
        /// <value>
        /// The client became aware date.
        /// </value>        
        public DateTime? ClientBecameAwareDate
        {
            get { return clientBecameAwareDate; }
            set
            {
                clientBecameAwareDate = value;
            }
        }

        /// <summary>
        /// Gets or sets the client reported date.
        /// </summary>
        /// <value>
        /// The client reported date.
        /// </value>
        public DateTime? ClientReportedDate
        {
            get { return clientReportedDate; }
            set { clientReportedDate = value; }
        }

    }
}
