//-----------------------------------------------------------------------
// <copyright file="MemoryWriter.cs" company="Tkachenko">
//     Copyright (c) Tkachenko. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace PingWriter
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Writer some string to list
    /// </summary>
    public class MemoryWriter
    {
        /// <summary>
        /// List with messages
        /// </summary>
        private IList<string> messages = new List<string>();

        /// <summary>
        /// Adding message to list
        /// </summary>
        /// <param name="message">Message for writing </param>
        public void WriteToMemory(string message)
        {
            this.messages.Add(message);
            Console.WriteLine($"Wrote to memory");
        }
    }
}
