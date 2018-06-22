// Copyright (c) Xenko contributors (https://xenko.com) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.

using System.Linq;

using Xunit;

using Xenko.Games;

namespace Xenko.Graphics.Regression
{
    public class TestGraphicsDeviceManager : GraphicsDeviceManager
    {
        public TestGraphicsDeviceManager(GameBase game)
            : base(game)
        {
        }

        protected override bool IsPreferredProfileAvailable(GraphicsProfile[] preferredProfiles, out GraphicsProfile availableProfile)
        {
            Assert.True(base.IsPreferredProfileAvailable(preferredProfiles, out availableProfile), $"This test requires the '{preferredProfiles.Min()}' graphic profile. It has been ignored");
            return true;
        }
    }
}
