// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLMarqueeElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLMarqueeElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMarqueeElement o) =>
            new HTMLMarqueeElement(o));
      }

      public HTMLMarqueeElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMarqueeElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMarqueeElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMarqueeElement)WrappedObject; }
      }

      public HTMLMarqueeElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMarqueeElement()) {}

   }


}
