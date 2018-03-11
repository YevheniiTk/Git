//-----------------------------------------------------------------------
// <copyright file="Client.cs" company="Tkachenko">
//     Copyright (c) Tkachenko. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace PingWriter
{
    using System;
    using System.Net.Http;

    /// <summary>
    /// Вelegate writing a message somewhere
    /// </summary>
    /// <param name="message">Some message for writer.</param>
    public delegate void Writer(string message);

    /// <summary>
    /// Client API
    /// </summary>
    public static class Client
    {
        /// <summary>
        /// Load data from steakovercooked.com
        /// </summary>
        /// <param name="website">Website that want to ping.</param>
        /// <param name="writer">How to record the result.</param>
        public static async void LoadData(string website, Writer writer)
        {
            string page = "https://steakovercooked.com/api/ping/?host=" + website;

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(page))
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            writer(data);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Write ping to console
        /// </summary>
        /// <param name="website">Website that want to ping.</param>
        public static void WritePingToConsole(string website)
        {
            LoadData(website, Console.WriteLine);
        }

        /// <summary>
        /// Write ping ro memory
        /// </summary>
        /// <param name="website">Website that want to ping.</param>
        public static void WritePingToMemory(string website)
        {
            var memoryWriter = new MemoryWriter();
            Writer handler = memoryWriter.WriteToMemory;
            LoadData(website, handler);
        }
    }
}
