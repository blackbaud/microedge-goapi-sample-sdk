using System;
using System.Threading.Tasks;
using CommandLine;
using MicroEdge.GoApi.SDK.Organizations;
using MicroEdge.GoApi.SDK.Organizations.Models;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool argumentsParsed = false;
            var options = new Options();
            var result = Parser.Default.ParseArguments<Options>(args)
                .WithParsed(o =>
                {
                    options = o;
                    argumentsParsed = true;
                });

            // Stop execution if the arguments were not parsed.
            if (!argumentsParsed) return;

            // Create an organization client object with authorization information.
            var client = new OrganizationClient(options.User, options.Key);

            // Create a request to fetch an organization.
            var getOrganizationRequest = new GetOrganizationRequest()
            {
                Id = options.OrganizationId
            };

            // Run the get organization request and write the organization name to the console.
            var organization = Task.Run(async () => await client.GetOrganization(getOrganizationRequest)).GetAwaiter().GetResult();
            Console.WriteLine(organization?.Organization?.Name);
        }

        private class Options
        {
            [Option('u', "user", Required = true, HelpText = "API user ID.")]
            public string User { get; set; }

            [Option('k', "key", Required = true, HelpText = "API key")]
            public string Key { get; set; }

            [Option('i', "organizationId", Required = true, HelpText = "ID of the Organization to fetch a name for.")]
            public string OrganizationId { get; set; }
        }
    }
}
