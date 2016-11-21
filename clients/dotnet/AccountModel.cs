using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Avalara.AvaTax.RestClient
{
    /// <summary>
    /// An AvaTax account.
    /// </summary>
    public class AccountModel
    {
        /// <summary>
        /// The unique ID number assigned to this account.
        /// </summary>
        public Int32 id { get; set; }

        /// <summary>
        /// The name of this account.
        /// </summary>
        public String name { get; set; }

        /// <summary>
        /// The earliest date on which this account may be used.
        /// </summary>
        public DateTime? effectiveDate { get; set; }

        /// <summary>
        /// If this account has been closed, this is the last date the account was open.
        /// </summary>
        public DateTime? endDate { get; set; }

        /// <summary>
        /// The current status of this account.
        /// </summary>
        public String accountStatusId { get; set; }

        /// <summary>
        /// The date when this record was created.
        /// </summary>
        public DateTime? createdDate { get; set; }

        /// <summary>
        /// The User ID of the user who created this record.
        /// </summary>
        public Int32? createdUserId { get; set; }

        /// <summary>
        /// The date/time when this record was last modified.
        /// </summary>
        public DateTime? modifiedDate { get; set; }

        /// <summary>
        /// The user ID of the user who last modified this record.
        /// </summary>
        public Int32? modifiedUserId { get; set; }

        /// <summary>
        /// Optional: A list of subscriptions granted to this account.  To fetch this list, add the query string "?$include=Subscriptions" to your URL.
        /// </summary>
        public SubscriptionModel[] subscriptions { get; set; }

        /// <summary>
        /// Optional: A list of all the users belonging to this account.  To fetch this list, add the query string "?$include=Users" to your URL.
        /// </summary>
        public UserModel[] users { get; set; }


    }
}
