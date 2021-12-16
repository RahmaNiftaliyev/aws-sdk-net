﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.SourceFiles
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceConfig.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class ServiceConfig : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceConfig.tt"

    AddLicenseHeader();

            
            #line default
            #line hidden
            this.Write("\r\n\r\nusing System;\r\n\r\nusing Amazon.Runtime;\r\nusing Amazon.Util.Internal;\r\n\r\n\r\nname" +
                    "space ");
            
            #line 17 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceConfig.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    /// <summary>\r\n    /// Configuration for accessing Amazon ");
            
            #line 20 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceConfig.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write(" service\r\n    /// </summary>\r\n    public partial class Amazon");
            
            #line 22 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceConfig.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write("Config : ClientConfig\r\n    {\r\n        private static readonly string UserAgentStr" +
                    "ing =\r\n            InternalSDKUtils.BuildUserAgentString(\"");
            
            #line 25 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceConfig.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceFileVersion));
            
            #line default
            #line hidden
            this.Write("\");\r\n\r\n        private string _userAgent = UserAgentString;\r\n\r\n        /// <summa" +
                    "ry>\r\n        /// Default constructor\r\n        /// </summary>\r\n        public Ama" +
                    "zon");
            
            #line 32 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceConfig.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write("Config()\r\n        {\r\n");
            
            #line 34 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceConfig.tt"

            if(!string.IsNullOrEmpty(this.Config.AuthenticationServiceName))
            {

            
            #line default
            #line hidden
            this.Write("            this.AuthenticationServiceName = \"");
            
            #line 38 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceConfig.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.AuthenticationServiceName));
            
            #line default
            #line hidden
            this.Write("\";\r\n");
            
            #line 39 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceConfig.tt"

            }
            if(this.Config.OverrideMaxRetries.HasValue)
            {

            
            #line default
            #line hidden
            this.Write("            this.MaxErrorRetry = ");
            
            #line 44 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceConfig.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.OverrideMaxRetries));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 45 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceConfig.tt"

            }
            if(!string.IsNullOrEmpty(this.Config.DefaultRegion))
            {

            
            #line default
            #line hidden
            this.Write("            var region = FallbackRegionFactory.GetRegionEndpoint(false);\r\n       " +
                    "     this.RegionEndpoint = region ?? RegionEndpoint.");
            
            #line 51 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceConfig.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.DefaultRegion));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 52 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceConfig.tt"

            }

            
            #line default
            #line hidden
            this.Write(@"        }

        /// <summary>
        /// The constant used to lookup in the region hash the endpoint.
        /// </summary>
        public override string RegionEndpointServiceName
        {
            get
            {
                return """);
            
            #line 64 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceConfig.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.RegionLookupName));
            
            #line default
            #line hidden
            this.Write("\";\r\n            }\r\n        }\r\n\r\n        /// <summary>\r\n        /// Gets the Servi" +
                    "ceVersion property.\r\n        /// </summary>\r\n        public override string Serv" +
                    "iceVersion\r\n        {\r\n            get\r\n            {\r\n                return \"");
            
            #line 75 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceConfig.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceModel.APIVersion));
            
            #line default
            #line hidden
            this.Write(@""";
            }
        }

        /// <summary>
        /// Gets the value of UserAgent property.
        /// </summary>
        public override string UserAgent
        {
            get
            {
                return _userAgent;
            }
        }
    }
}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
