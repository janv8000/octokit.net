﻿using System;
using System.Diagnostics;

namespace Octokit
{
    /// <summary>
    /// Collection of feeds including both url and type
    /// </summary>
    public class FeedLinks
    {
        /// <summary>
        /// The GitHub global public timeline
        /// </summary>
        public FeedLink Timeline { get; protected set; }

        /// <summary>
        /// The public timeline for any user, using URI template
        /// </summary>
        public FeedLink User { get; protected set; }

        /// <summary>
        /// The public timeline for the authenticated user
        /// </summary>
        public FeedLink CurrentUserPublic { get; protected set; }

        /// <summary>
        /// The private timeline for the authenticated user
        /// </summary>
        public FeedLink CurrentUser { get; protected set; }

        /// <summary>
        /// The private timeline for activity created by the authenticated user
        /// </summary>
        public FeedLink CurrentUserActor { get; protected set; }

        /// <summary>
        /// The private timeline for the authenticated user for a given organization, using URI template
        /// </summary>  
        public FeedLink CurrentUserOrganization { get; protected set; }
    }

    /// <summary>
    /// Feed information including feed url and feed type
    /// </summary>
    public class FeedLink
    {
        /// <summary>
        /// Link to feed
        /// </summary>
        public string Href { get; protected set; }

        /// <summary>
        /// Feed type, e.g. application/atom+xml
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
        public string Type { get; protected set; }
    }
}