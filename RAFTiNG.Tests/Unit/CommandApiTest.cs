﻿//  --------------------------------------------------------------------------------------------------------------------
// <copyright file="CommandApiTest.cs" company="Cyrille DUPUYDAUBY">
//   Copyright 2013 Cyrille DUPUYDAUBY
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//  --------------------------------------------------------------------------------------------------------------------

namespace RAFTiNG.Tests.Unit
{
    using Michonne.Implementation;

    using NUnit.Framework;

    using RAFTiNG.Tests.Services;

    [TestFixture]
    public class CommandApiTest
    {
        [Test]
        public void SendCommandToASingleNode()
        {
            var middleware = new Middleware();
            
            // have a cluster of one
            var settings = Helpers.BuildNodeSettings("1", new[] { "1" });
            settings.TimeoutInMs = 10;
            
            // create a cluster of one node, so there is no ambiguity about who is the leader
            var leader = new Node<string>(TestHelpers.GetPool().BuildSequencer(), settings, middleware, new StateMachine());
        }
    }
}
