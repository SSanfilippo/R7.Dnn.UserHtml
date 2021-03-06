﻿//
// UserHtmlTokenReplace.cs
//
// Author:
//       Roman M. Yagodin <roman.yagodin@gmail.com>
//
// Copyright (c) 2018 Roman M. Yagodin
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System.Collections;
using System.Globalization;
using DotNetNuke.Entities.Portals;
using DotNetNuke.Entities.Users;
using DotNetNuke.Services.Tokens;

namespace R7.Dnn.UserHtml.Components
{
    public class UserHtmlTokenReplace: TokenReplace
    {
        public UserHtmlTokenReplace (PortalSettings portalSettings, UserInfo user, int moduleId):
            base (Scope.DefaultSettings, CultureInfo.CurrentCulture.IetfLanguageTag, portalSettings, user, moduleId)
        {
            #if DEBUG

            DebugMessages = true;

            #endif
        }

        public string ReplaceCKEditorTemplateTokens (string sourceText, IDictionary templateTokens, int times = 1, bool final = true)
        {
            var text = sourceText;

            if (final) {
                text = text.Replace ("[Final]", "[");
                text = text.Replace ("[/Final]", "]");
            }

            for (var i = 0; i < times; i++) {
                text = ReplaceEnvironmentTokens (text, templateTokens, "CKEditor");
            }

            return text;
        }
    }
}
