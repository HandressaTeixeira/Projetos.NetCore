using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.TagHelpers
{

    //email é o nome da tag. NormalOrSelfClosing = determina que deve ser fechada dessa forma </email>  
    [HtmlTargetElement("email", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class EmailVoidTagHelper : TagHelper
    {

        public string MailTo { get; set; } // no html deve ser chamado como mail-to, como MailTo não funciona

        public string MailInfo { get; set; }// no html deve ser chamado como mail-info

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context">Pegar dados do request</param>
        /// <param name="output">Saida, é a tag que vai virar depois de ser a tag email</param>
        /// <returns></returns>
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var content = await output.GetChildContentAsync();
            output.Attributes.SetAttribute("href", "mailto:" + MailTo);
            output.Content.SetContent(MailInfo);
        }

    }
}
