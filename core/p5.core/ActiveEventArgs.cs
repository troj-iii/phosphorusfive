/*
 * Phosphorus Five, copyright 2014 - 2016, Thomas Hansen, mr.gaia@gaiasoul.com
 * 
 * This file is part of Phosphorus Five.
 *
 * Phosphorus Five is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * Phosphorus Five is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with Phosphorus Five.  If not, see <http://www.gnu.org/licenses/>.
 * 
 * If you cannot for some reasons use the GPL license, Phosphorus
 * Five is also commercially available under Quid Pro Quo terms. Check 
 * out our website at http://gaiasoul.com for more details.
 */

using System;

namespace p5.core
{
    /// <summary>
    ///     Active Event arguments
    /// </summary>
    public class ActiveEventArgs : EventArgs
    {
        /*
         * initializes a new instance of this class
         */
        internal ActiveEventArgs (string name, Node args)
        {
            Args = args;
            Name = name;
        }

        /// <summary>
        ///     Arguments passed in and returned from Active Events
        /// </summary>
        /// <value>the arguments</value>
        public Node Args
        {
            get;
            private set;
        }

        /// <summary>
        ///     Name of the Active Event raised
        /// </summary>
        /// <value>the name</value>
        public string Name
        {
            get;
            private set;
        }
    }
}
