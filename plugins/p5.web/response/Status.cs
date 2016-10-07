
/*
 * Phosphorus Five, copyright 2014 - 2016, Thomas Hansen, phosphorusfive@gmail.com
 * Phosphorus Five is licensed under the terms of the MIT license, see the enclosed LICENSE file for details.
 */

using System.Web;
using p5.exp;
using p5.core;

namespace p5.web.ui.response
{
    /// <summary>
    ///     Helper class to manipulate the HTTP status
    /// </summary>
    public static class Status
    {
        /// <summary>
        ///     Changes the HTTP status code for the current response
        /// </summary>
        /// <param name="context">Application Context</param>
        /// <param name="e">Parameters passed into Active Event</param>
        [ActiveEvent (Name = "set-http-status-code")]
        public static void set_http_status_code (ApplicationContext context, ActiveEventArgs e)
        {
            HttpContext.Current.Response.StatusCode = e.Args.GetExValue<int> (context);
        }

        /// <summary>
        ///     Changes the HTTP status description for the current response
        /// </summary>
        /// <param name="context">Application Context</param>
        /// <param name="e">Parameters passed into Active Event</param>
        [ActiveEvent (Name = "set-http-status")]
        public static void set_http_status (ApplicationContext context, ActiveEventArgs e)
        {
            HttpContext.Current.Response.Status = e.Args.GetExValue<string> (context);
        }
    }
}