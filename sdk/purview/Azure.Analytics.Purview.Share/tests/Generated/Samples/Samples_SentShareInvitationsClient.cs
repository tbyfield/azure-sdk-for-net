// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Analytics.Purview.Share.Samples
{
    public class Samples_SentShareInvitationsClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSentShareInvitation()
        {
            var credential = new DefaultAzureCredential();
            var client = new SentShareInvitationsClient("<https://my-service.azure.com>", credential);

            Response response = client.GetSentShareInvitation("<sentShareName>", "<sentShareInvitationName>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("invitationKind").ToString());
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSentShareInvitation_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new SentShareInvitationsClient("<https://my-service.azure.com>", credential);

            Response response = client.GetSentShareInvitation("<sentShareName>", "<sentShareInvitationName>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("invitationKind").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSentShareInvitation_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new SentShareInvitationsClient("<https://my-service.azure.com>", credential);

            Response response = await client.GetSentShareInvitationAsync("<sentShareName>", "<sentShareInvitationName>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("invitationKind").ToString());
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSentShareInvitation_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new SentShareInvitationsClient("<https://my-service.azure.com>", credential);

            Response response = await client.GetSentShareInvitationAsync("<sentShareName>", "<sentShareInvitationName>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("invitationKind").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate()
        {
            var credential = new DefaultAzureCredential();
            var client = new SentShareInvitationsClient("<https://my-service.azure.com>", credential);

            var data = new
            {
                properties = new
                {
                    targetActiveDirectoryId = "<targetActiveDirectoryId>",
                    targetObjectId = "<targetObjectId>",
                },
                invitationKind = "Application",
            };

            Response response = client.CreateOrUpdate("<sentShareName>", "<sentShareInvitationName>", RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("invitationKind").ToString());
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new SentShareInvitationsClient("<https://my-service.azure.com>", credential);

            var data = new
            {
                properties = new
                {
                    expirationDate = "2022-05-10T18:57:31.2311892Z",
                    shareKind = "InPlace",
                    targetActiveDirectoryId = "<targetActiveDirectoryId>",
                    targetObjectId = "<targetObjectId>",
                },
                invitationKind = "Application",
            };

            Response response = client.CreateOrUpdate("<sentShareName>", "<sentShareInvitationName>", RequestContent.Create(data), new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("invitationKind").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new SentShareInvitationsClient("<https://my-service.azure.com>", credential);

            var data = new
            {
                properties = new
                {
                    targetActiveDirectoryId = "<targetActiveDirectoryId>",
                    targetObjectId = "<targetObjectId>",
                },
                invitationKind = "Application",
            };

            Response response = await client.CreateOrUpdateAsync("<sentShareName>", "<sentShareInvitationName>", RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("invitationKind").ToString());
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new SentShareInvitationsClient("<https://my-service.azure.com>", credential);

            var data = new
            {
                properties = new
                {
                    expirationDate = "2022-05-10T18:57:31.2311892Z",
                    shareKind = "InPlace",
                    targetActiveDirectoryId = "<targetActiveDirectoryId>",
                    targetObjectId = "<targetObjectId>",
                },
                invitationKind = "Application",
            };

            Response response = await client.CreateOrUpdateAsync("<sentShareName>", "<sentShareInvitationName>", RequestContent.Create(data), new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("invitationKind").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete()
        {
            var credential = new DefaultAzureCredential();
            var client = new SentShareInvitationsClient("<https://my-service.azure.com>", credential);

            Response response = client.Delete("<sentShareName>", "<sentShareInvitationName>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new SentShareInvitationsClient("<https://my-service.azure.com>", credential);

            Response response = client.Delete("<sentShareName>", "<sentShareInvitationName>", new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new SentShareInvitationsClient("<https://my-service.azure.com>", credential);

            Response response = await client.DeleteAsync("<sentShareName>", "<sentShareInvitationName>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new SentShareInvitationsClient("<https://my-service.azure.com>", credential);

            Response response = await client.DeleteAsync("<sentShareName>", "<sentShareInvitationName>", new RequestContext());
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSentShareInvitations()
        {
            var credential = new DefaultAzureCredential();
            var client = new SentShareInvitationsClient("<https://my-service.azure.com>", credential);

            foreach (var item in client.GetSentShareInvitations("<sentShareName>"))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("invitationKind").ToString());
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetSentShareInvitations_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new SentShareInvitationsClient("<https://my-service.azure.com>", credential);

            foreach (var item in client.GetSentShareInvitations("<sentShareName>", "<skipToken>", "<filter>", "<orderby>", new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("invitationKind").ToString());
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("type").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSentShareInvitations_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new SentShareInvitationsClient("<https://my-service.azure.com>", credential);

            await foreach (var item in client.GetSentShareInvitationsAsync("<sentShareName>"))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("invitationKind").ToString());
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetSentShareInvitations_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new SentShareInvitationsClient("<https://my-service.azure.com>", credential);

            await foreach (var item in client.GetSentShareInvitationsAsync("<sentShareName>", "<skipToken>", "<filter>", "<orderby>", new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("invitationKind").ToString());
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("type").ToString());
            }
        }
    }
}
