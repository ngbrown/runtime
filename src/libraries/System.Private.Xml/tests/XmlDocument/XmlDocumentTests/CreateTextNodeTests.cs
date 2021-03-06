// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Xunit;

namespace System.Xml.Tests
{
    public class CreateTextNodeTests
    {
        [Fact]
        public static void NodeTypeTest()
        {
            var xmlDocument = new XmlDocument();
            var newNode = xmlDocument.CreateTextNode(string.Empty);

            Assert.Equal(XmlNodeType.Text, newNode.NodeType);
        }
    }
}
