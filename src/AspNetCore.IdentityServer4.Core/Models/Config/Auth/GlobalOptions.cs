﻿namespace AspNetCore.IdentityServer4.Core.Models.Config.Auth
{
    /// <summary>
    /// Global options
    /// </summary>
    public class GlobalOptions
    {
        /// <summary>
        /// Signing Credential options
        /// </summary>
        public SigningCredentialOptions SigningCredential { get; set; }

        /// <summary>
        /// Access token options
        /// </summary>
        public AccessTokenOptions AccessToken { get; set; }

        /// <summary>
        /// Refresh token options
        /// </summary>
        public RefreshTokenOptions RefreshToken { get; set; }

        /// <summary>
        /// Open ID options
        /// </summary>
        public  OpenIdOptions OpenId { get; set; }

        /// <summary>
        /// Open ID options for JS client
        /// </summary>
        public  OpenIdOptions OpenIdJs { get; set; }
    }
}
