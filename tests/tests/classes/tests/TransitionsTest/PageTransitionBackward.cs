using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CocosSharp;

namespace tests
{
    public class PageTransitionBackward : CCTransitionPageTurn
    {
        public PageTransitionBackward (float t, CCScene s) : base (t, s, true)
        {
            Scene.Window.IsUseDepthTesting = true;
        }

        public override void OnExit()
        {
            Scene.Window.IsUseDepthTesting = true;

            base.OnExit();
        }
    }
}
