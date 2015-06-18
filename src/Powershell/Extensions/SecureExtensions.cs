﻿#region Using Statements
    using System;
    using System.Security;
#endregion



namespace Cake.Powershell
{
    /// <summary>
    /// Responsible for creating secure strings
    /// </summary>
    public static class SecureExtensions
    {
        /// <summary>
        /// Creates a secure string for storing powershell passwords
        /// </summary>
        /// <param name="password">The string to make secure.</param>
        /// <returns>The secure string.</returns>
        public static SecureString MakeSecure(this string password)
        {
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }

            var securePassword = new SecureString();

            foreach (char c in password)
            {
                securePassword.AppendChar(c);
            }

            securePassword.MakeReadOnly();

            return securePassword;
        }
    }
}
