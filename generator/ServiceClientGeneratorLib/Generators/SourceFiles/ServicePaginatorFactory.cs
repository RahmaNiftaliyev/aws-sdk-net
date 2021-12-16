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
    
    #line 1 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServicePaginatorFactory.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class ServicePaginatorFactory : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServicePaginatorFactory.tt"

    AddLicenseHeader();

            
            #line default
            #line hidden
            this.Write("\r\nusing System;\r\nusing System.Collections.Generic;\r\nusing System.Text;\r\n\r\nnamespa" +
                    "ce ");
            
            #line 14 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServicePaginatorFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model\r\n{\r\n    /// <summary>\r\n    /// Paginators for the ");
            
            #line 17 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServicePaginatorFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceNameRoot));
            
            #line default
            #line hidden
            this.Write(" service\r\n    ///</summary>\r\n    public class ");
            
            #line 19 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServicePaginatorFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceNameRoot));
            
            #line default
            #line hidden
            this.Write("PaginatorFactory : I");
            
            #line 19 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServicePaginatorFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceNameRoot));
            
            #line default
            #line hidden
            this.Write("PaginatorFactory\r\n    {\r\n        private readonly IAmazon");
            
            #line 21 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServicePaginatorFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write(" client;\r\n\r\n        internal ");
            
            #line 23 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServicePaginatorFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceNameRoot));
            
            #line default
            #line hidden
            this.Write("PaginatorFactory(IAmazon");
            
            #line 23 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServicePaginatorFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write(" client) \r\n        {\r\n            this.client = client;\r\n        }\r\n");
            
            #line 27 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServicePaginatorFactory.tt"

foreach(var operation in this.Config.ServiceModel.Operations)
{
    if (operation.Paginators != null && !operation.UnsupportedPaginatorConfig)
    {

            
            #line default
            #line hidden
            this.Write("\r\n        /// <summary>\r\n        /// Paginator for ");
            
            #line 35 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServicePaginatorFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write(" operation\r\n        ///</summary>\r\n        public I");
            
            #line 37 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServicePaginatorFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Paginator ");
            
            #line 37 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServicePaginatorFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 37 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServicePaginatorFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Request request) \r\n        {\r\n            return new ");
            
            #line 39 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServicePaginatorFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Paginator(this.client, request);\r\n        }\r\n");
            
            #line 41 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServicePaginatorFactory.tt"

    }
}

            
            #line default
            #line hidden
            this.Write("    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
