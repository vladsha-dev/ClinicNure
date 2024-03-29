﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp.AppConstant
{
    public class Constants
    {
		public static string AppName = "OAuthNativeFlow";

		// OAuth
		// For Google login, configure at https://console.developers.google.com/
		public static string AndroidClientId = "38212247633-pfftidqt6in8vu7u32582ekl2t5pbsp7.apps.googleusercontent.com";

		// These values do not need changing
		public static string Scope = "https://www.googleapis.com/auth/userinfo.profile email";
		public static string AuthorizeUrl = "https://accounts.google.com/o/oauth2/auth";
		public static string AccessTokenUrl = "https://www.googleapis.com/oauth2/v4/token";
		public static string UserInfoUrl = "https://www.googleapis.com/oauth2/v2/userinfo";

		// Set these to reversed iOS/Android client ids, with :/oauth2redirect appended
		public static string AndroidRedirectUrl = "com.googleusercontent.apps.38212247633-pfftidqt6in8vu7u32582ekl2t5pbsp7:/oauth2redirect";
	}
}
