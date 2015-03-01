/*
 * phosphorus five, copyright 2014 - Mother Earth, Jannah, Gaia
 * phosphorus five is licensed as mitx11, see the enclosed LICENSE file for details
 */

using System;
using System.Security.Cryptography;
using System.Text;
using phosphorus.core;
using phosphorus.expressions;

// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedMember.Global

namespace phosphorus.crypto
{
    /// <summary>
    ///     helper wrapping some cryptographic Active Events
    /// </summary>
    public static class Hash
    {
        /// <summary>
        ///     creates a hash out of the value from [pf.crypto.hash-string] and returns the hash value as the value of
        ///     the first child of [pf.crypto.hash-string] named [value]
        /// </summary>
        /// <param name="context">Application context</param>
        /// <param name="e">Parameters passed into Active Event</param>
        [ActiveEvent (Name = "pf.crypto.hash-string")]
        private static void pf_crypto_hash_string (ApplicationContext context, ActiveEventArgs e)
        {
            var whatToHash = XUtil.Single<string> (e.Args, context);
            if (whatToHash == null)
                return; // nothing to hash here ...

            using (var md5 = MD5.Create ()) {
                var hashValue = Convert.ToBase64String (md5.ComputeHash (Encoding.UTF8.GetBytes (whatToHash)));
                e.Args.Add (new Node ("value", hashValue));
            }
        }
    }
}