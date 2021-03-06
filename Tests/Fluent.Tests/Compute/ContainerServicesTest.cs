﻿// Copyright (c) Microsoft Corporation. All rights reserved. 
// Licensed under the MIT License. See License.txt in the project root for license information. 

using Xunit;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using Fluent.Tests.Common;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
using Microsoft.Azure.Management.Compute.Fluent;
using Microsoft.Azure.Management.Compute.Fluent.Models;
using Azure.Tests;

namespace Fluent.Tests.Compute
{
    public class ContainerServices
    {
        private static readonly string SshKey = "ssh-rsa AAAAB3NzaC1yc2EAAAADAQABAAABAQCfSPC2K7LZcFKEO+/t3dzmQYtrJFZNxOsbVgOVKietqHyvmYGHEC0J2wPdAqQ/63g/hhAEFRoyehM+rbeDri4txB3YFfnOK58jqdkyXzupWqXzOrlKY4Wz9SKjjN765+dqUITjKRIaAip1Ri137szRg71WnrmdP3SphTRlCx1Bk2nXqWPsclbRDCiZeF8QOTi4JqbmJyK5+0UqhqYRduun8ylAwKKQJ1NJt85sYIHn9f1Rfr6Tq2zS0wZ7DHbZL+zB5rSlAr8QyUdg/GQD+cmSs6LvPJKL78d6hMGk84ARtFo4A79ovwX/Fj01znDQkU6nJildfkaolH2rWFG/qttD azjava@javalib.Com";

        [Fact]
        public void ContainerServiceCRUDTest()
        {
            
            using (var context = FluentMockContext.Start(GetType().FullName))
            {
                var csName = TestUtilities.GenerateName("cr");
                var saName = TestUtilities.GenerateName("crsa");
                var dnsPrefix = TestUtilities.GenerateName("dns");
                var rgName = TestUtilities.GenerateName("crRg");
                IContainerService containerService = null;
                var computeManager = TestHelper.CreateComputeManager();
                var resourceManager = TestHelper.CreateResourceManager();

                try
                {
                    containerService = computeManager.ContainerServices.Define(csName)
                            .WithRegion(Region.USWest)
                            .WithNewResourceGroup(rgName)
                            .WithDcosOrchestration()
                            .WithDiagnostics()
                            .WithLinux()
                            .WithRootUsername("testusername")
                            .WithSshKey(SshKey)
                            .WithMasterNodeCount(ContainerServiceMasterProfileCount.MIN)
                            .WithMasterLeafDomainLabel("mp1" + dnsPrefix)
                            .DefineAgentPool("agentPool0" + csName)
                                .WithVMCount(1)
                                .WithVMSize(ContainerServiceVMSizeTypes.StandardA1)
                                .WithLeafDomainLabel("ap0" + dnsPrefix)
                                .Attach()
                            .WithTag("tag1", "value1")
                            .Create();
                    Assert.NotNull(containerService.Id);
                    Assert.Equal(containerService.Region, Region.USWest);
                    Assert.Equal(containerService.MasterNodeCount, (int)ContainerServiceMasterProfileCount.MIN);
                    Assert.Equal("testusername", containerService.LinuxRootUsername);
                    Assert.Equal(1, containerService.AgentPoolCount);
                    Assert.Equal(containerService.AgentPoolName, "agentPool0" + csName);
                    Assert.Equal(containerService.AgentPoolLeafDomainLabel, "ap0" + dnsPrefix);
                    Assert.Equal(containerService.AgentPoolVMSize, ContainerServiceVMSizeTypes.StandardA1);
                    Assert.Equal(ContainerServiceOrchestratorTypes.DCOS, containerService.OrchestratorType);
                    Assert.True(containerService.IsDiagnosticsEnabled);
                    Assert.True(containerService.Tags.ContainsKey("tag1"));


                    containerService = containerService.Update()
                        .WithAgentVMCount(5)
                        .WithTag("tag2", "value2")
                        .WithTag("tag3", "value3")
                        .WithoutTag("tag1")
                        .Apply();

                    Assert.True(containerService.AgentPoolCount == 5);
                    Assert.True(containerService.Tags.ContainsKey("tag2"));
                    Assert.True(!containerService.Tags.ContainsKey("tag1"));

                }
                finally
                {
                    try
                    {
                        resourceManager.ResourceGroups.BeginDeleteByName(rgName);
                    }
                    catch { }
                }

            }
        }
    }
}
