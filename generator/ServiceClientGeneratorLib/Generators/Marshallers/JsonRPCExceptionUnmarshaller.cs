﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.Marshallers
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCExceptionUnmarshaller.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class JsonRPCExceptionUnmarshaller : BaseResponseUnmarshaller
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCExceptionUnmarshaller.tt"

    AddLicenseHeader();

    AddCommonUsingStatements();

            
            #line default
            #line hidden
            this.Write("using ThirdParty.Json.LitJson;\r\n\r\nnamespace ");
            
            #line 13 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCExceptionUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model.Internal.MarshallTransformations\r\n{\r\n    /// <summary>\r\n    /// Response U" +
                    "nmarshaller for ");
            
            #line 16 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCExceptionUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(" Object\r\n    /// </summary>  \r\n    public class ");
            
            #line 18 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCExceptionUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write("Unmarshaller : IErrorResponseUnmarshaller<");
            
            #line 18 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCExceptionUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(", JsonUnmarshallerContext>\r\n    {\r\n        /// <summary>\r\n        /// Unmarshalle" +
                    "r the response from the service to the response class.\r\n        /// </summary>  " +
                    "\r\n        /// <param name=\"context\"></param>\r\n        /// <returns></returns>\r\n " +
                    "       public ");
            
            #line 25 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCExceptionUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(@" Unmarshall(JsonUnmarshallerContext context)
        {
            return this.Unmarshall(context, new Amazon.Runtime.Internal.ErrorResponse());
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name=""context""></param>
        /// <param name=""errorResponse""></param>
        /// <returns></returns>
        public ");
            
            #line 36 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCExceptionUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(" Unmarshall(JsonUnmarshallerContext context, Amazon.Runtime.Internal.ErrorRespons" +
                    "e errorResponse)\r\n        {\r\n            context.Read();\r\n\r\n            ");
            
            #line 40 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCExceptionUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(" unmarshalledObject = new ");
            
            #line 40 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCExceptionUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(@"(errorResponse.Message, errorResponse.InnerException,
                errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
");
            
            #line 46 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCExceptionUnmarshaller.tt"

    if(this.Structure != null)
    {
        foreach (var member in this.Structure.Members)
        {

            
            #line default
            #line hidden
            this.Write("                if (context.TestExpression(\"");
            
            #line 52 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCExceptionUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallName));
            
            #line default
            #line hidden
            this.Write("\", targetDepth))\r\n                {\r\n                    var unmarshaller = ");
            
            #line 54 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCExceptionUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.DetermineTypeUnmarshallerInstantiate()));
            
            #line default
            #line hidden
            this.Write(";\r\n                    unmarshalledObject.");
            
            #line 55 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCExceptionUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write(" = unmarshaller.Unmarshall(context);\r\n                    continue;\r\n            " +
                    "    }\r\n");
            
            #line 58 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCExceptionUnmarshaller.tt"

        }
    }

            
            #line default
            #line hidden
            this.Write("            }\r\n          \r\n            return unmarshalledObject;\r\n        }\r\n\r\n");
            
            #line 67 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCExceptionUnmarshaller.tt"

    this.AddStructureSingletonMethod();

            
            #line default
            #line hidden
            this.Write("    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
