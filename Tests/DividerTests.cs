﻿using Xunit;

namespace Tests
{
    public class DividerTests
    {
        [Fact]
        public void Should_render_spacer()
        {
            var source = @"<mj-divider />";

            var result = TestHelper.Render(source);

            AssertHelpers.HtmlAssert(TestHelper.GetContent("Divider.html"), result);
        }
    }
}