using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace WebApp.Services
{
    public class HangFireService
    {
        public void Recurring(string url, string cronExpression, string jobName)
        {
            RecurringJob.AddOrUpdate(jobName, () => CallRecurringUrl(url), cronExpression);
        }

        public string scheduleRecurring(string url, string cronExpression, string jobName)
        {
            var result = string.Empty;
            if (string.IsNullOrEmpty(url))
                result = "Please provide Url";

            else if (string.IsNullOrEmpty(cronExpression))
                result = "Please provide cronExpression";

            else if (string.IsNullOrEmpty(jobName))
                result = "Please provide jobName";

            else
            {
                RecurringJob.AddOrUpdate(jobName, () => CallRecurringUrl(url), cronExpression);
                result = "Recurring job scheduled successfully.";
            }

            return result;
        }

        public string Enqueue(string url)
        {
            var result = string.Empty;
            if (string.IsNullOrEmpty(url))
                result = "Please provide Url";

            else
            {
                BackgroundJob.Enqueue(() => CallUrl(url));
                result = "Job Enqueued successfully.";
            }
            
            return result;
        }

        public string Schedule(string url, DateTime? scheduleDate)
        {
            var result = string.Empty;
            if (string.IsNullOrEmpty(url))
                result = "Please provide Url";

            else if (!scheduleDate.HasValue)
                result = "Please provide scheduleDate";

            else
            {
                BackgroundJob.Schedule(() => CallScheduleUrl(url), scheduleDate.Value);
                result = "Single job scheduled successfully.";
            }
            
            return result;
        }

        [Queue("default")]
        //[CustomAutomaticRetry(Attempts = 15, OnAttemptsExceeded = AttemptsExceededAction.Fail)]
        public void CallRecurringUrl(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Credentials = CredentialCache.DefaultCredentials;
            var response = request.GetResponse();
            response.Close();
        }

        [Queue("default")]
        //[CustomAutomaticRetry(Attempts = 15, OnAttemptsExceeded = AttemptsExceededAction.Fail)]
        public void CallScheduleUrl(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Credentials = CredentialCache.DefaultCredentials;
            var response = request.GetResponse();
            response.Close();
        }


        //[Queue("default")]
        [Queue("critical")]
        public void CallUrl(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Credentials = CredentialCache.DefaultCredentials;
            var response = request.GetResponse();
            response.Close();
        }
    }
}