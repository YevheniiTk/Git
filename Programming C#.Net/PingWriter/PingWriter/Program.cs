//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Tkachenko">
//     Copyright (c) Tkachenko. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace PingWriter
{
    using System;
    using System.Threading;

    /// <summary>
    /// Class Orogram
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Method Main
        /// </summary>
        /// <param name="args">Some arguments</param>
        private static void Main(string[] args)
        {
            Client.WritePingToConsole("google.com");
            Client.WritePingToConsole("ru.wikipedia.org");

            Client.WritePingToMemory("google.com");
            Client.WritePingToMemory("ru.wikipedia.org");

            Console.ReadLine();
        }
    }
}
