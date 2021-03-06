using Nancy;
using Nancy.TinyIoc;
using Nancy.Conventions;
using Nancy.Diagnostics;
using Nancy.Bootstrapper;
using System.Configuration;
using System.Linq;

namespace SharpPaste
{
	public class Bootstrapper : DefaultNancyBootstrapper
	{
        protected override DiagnosticsConfiguration DiagnosticsConfiguration
        {
            get { return new DiagnosticsConfiguration { Password = "CHANGEME" }; }
        }
        protected override void ConfigureConventions(NancyConventions nancyConventions)
		{
                        nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddFile("/css/bootstrap.css", @"packages\bootstrap.3.3.7\content\Content\bootstrap.min.css"));
	                nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddFile("/css/bootstrap.min.css.map", @"packages\bootstrap.3.3.7\content\Content\bootstrap.min.css.map"));
                        nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddFile("/css/bootstrap-flat.css", @"packages\Bootstrap.Flat.3.3.4\Content\Content\bootstrap-flat.min.css")); 
                        nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddFile("/js/lib/bootstrap.js", @"packages\bootstrap.3.3.7\content\Scripts\bootstrap.min.js")); 
                        nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddFile("/js/lib/jquery.js", @"packages\jQuery.3.2.1\Content\Scripts\jquery-3.2.1.min.js")); 
                        nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("/js", @"Static\js")); 
			nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("/css", @"Static\css")); 
			nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("/fonts", @"packages\bootstrap.3.3.7\content\fonts")); 
			base.ConfigureConventions(nancyConventions);
		}
	}
}
