using System.Collections.Generic;
namespace Ky.Hbe.WorkerPortal.Infrastructure.Model
{
    /// <summary>
    /// Represents a user of this system.
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// The user name
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// A list of claims used for authorization.
        /// </summary>
        public string[] Claims { get; set; }

        /// <summary>
        /// Indicates whether or not this user is authenticated.
        /// </summary>
        public bool IsAuthenticated { get; set; }

        /// <summary>
        /// UserModel's last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Email ID
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Primary phone number
        /// </summary>
        public string PrimaryPhoneNumber { get; set; }

        /// <summary>
        /// KOG user status code. 1 - active, 0 - disabled/inactive
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// KOG id. It is GUID
        /// </summary>
        public string KogGuid { get; set; }

        /// <summary>
        /// KOG login user name
        /// </summary>
        public string KogLoginUserName { get; set; }

        /// <summary>
        /// Errors encountered during STS login
        /// </summary>
        public string[] LoginErrors { get; set; }

        /// <summary>
        /// [ManageOfficeResource].[User].[UserId]
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// [ManageOfficeResource].[OfficeEmployee].[EmployeeId]
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// [ManageOfficeResource].[OfficeEmployee].[PrimaryOfficeId]
        /// </summary>
        public int? PrimaryOfficeId { get; set; }

        /// <summary>
        /// UPN
        /// </summary>
        public string Upn { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is SSN masking required.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is SSN masking required; otherwise, <c>false</c>.
        /// </value>
        public bool IsSSNMaskingRequired { get; set; }
    }
}