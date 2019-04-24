using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Hangfire;
using Hangfire.Dashboard;
using Hangfire.Common;
using Hangfire.States;
using Hangfire.Storage;

[assembly: OwinStartup(typeof(WebApp.Startup))]

namespace WebApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalConfiguration.Configuration.UseSqlServerStorage("TestingEntities"); //<name or connection string>
            //app.UseHangfireDashboard();

            //allows remote access to hangfire dashboard.
            var filter = new BasicAuthAuthorizationFilter(
                new BasicAuthAuthorizationFilterOptions
                {
                    // Require secure connection for dashboard
                    RequireSsl = false,
                    SslRedirect = false,
                    // Case sensitive login checking
                    LoginCaseSensitive = true,
                    // Users
                    Users = new[]
                    {
                        new BasicAuthAuthorizationUser
                        {
                            Login = "admin",
                            // Password as plain text
                            PasswordClear = "josh"
                        },
                        new BasicAuthAuthorizationUser
                        {
                            Login = "Administrator-2",
                            // Password as SHA1 hash
                            Password = new byte[]{0xa9,
                                0x4a, 0x8f, 0xe5, 0xcc, 0xb1, 0x9b,
                                0xa6, 0x1c, 0x4c, 0x08, 0x73, 0xd3,
                                0x91, 0xe9, 0x87, 0x98, 0x2f, 0xbb,
                                0xd3}
                        }
                    }
                });

            var options = new DashboardOptions
            {
                 AuthorizationFilters = new[] { filter }
            };

            app.UseHangfireDashboard("/hangfire", options);

            app.UseHangfireServer(new BackgroundJobServerOptions { Queues = new string[]{"DEFAULT","CRITICAL" } });

            // to extend job history retention time to 1 week
            GlobalJobFilters.Filters.Add(new ProlongExpirationTimeAttribute());
        }
    }

    public class ProlongExpirationTimeAttribute : JobFilterAttribute, IApplyStateFilter
    {
        public void OnStateApplied(ApplyStateContext filterContext, IWriteOnlyTransaction transaction)
        {
            filterContext.JobExpirationTimeout = TimeSpan.FromDays(7);
        }

        public void OnStateUnapplied(ApplyStateContext context, IWriteOnlyTransaction transaction)
        {
            context.JobExpirationTimeout = TimeSpan.FromDays(7);
        }
    }
}
