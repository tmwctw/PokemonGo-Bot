﻿using System;
using System.Reflection;

namespace PokemonGo.RocketAPI
{
    public class Resources
    {
        /*******************************************************************************************************************
         * URLs
         * ****************************************************************************************************************/

        public const string LoginUserAgent = "Niactic App";
        public const string RpcUrl = @"https://pgorelease.nianticlabs.com/plfe/rpc";
        public const string NumberedRpcUrl = @"https://pgorelease.nianticlabs.com/plfe/{0}/rpc";
        public const string GetRpcVersionUrl = @"https://pgorelease.nianticlabs.com/plfe/version";

        public const string PtcLoginUrl =
            "https://sso.pokemon.com/sso/login?service=https%3A%2F%2Fsso.pokemon.com%2Fsso%2Foauth2.0%2FcallbackAuthorize";

        public const string PtcLoginOauth = "https://sso.pokemon.com/sso/oauth2.0/accessToken";
        public const string GoogleGrantRefreshAccessUrl = "https://android.clients.google.com/auth";

        // 0.45 hash
        //public static string currentGameHash = "54b359c97e46900f87211ef6e6dd0b7f2a3ea1f5";

        /*******************************************************************************************************************
         * Bot Supported Version
         ******************************************************************************************************************/
        public static Version BotVersion = new Version(Assembly.GetEntryAssembly().GetName().Version.ToString());
        public static Version BotApiSupportedVersion = new Version(Api.ClientVersion);

        private static APIVars Apiv53 = new APIVars(-76506539888958491,
                                                "e40c3e64817d9c96d99d28f6488a2efc40b11046",
                                                "0.53.0");

        private static APIVars Apiv55 = new APIVars(-9156899491064153954,
                                                "90f6a704505bccac73cec99b07794993e6fd5a12",
                                                "0.55.0");

        private static APIVars Apiv572ios = new APIVars(-816976800928766045,
                                                "",
                                                "0.57.2");
        public static APIVars Api = Apiv55;
        
    }
}