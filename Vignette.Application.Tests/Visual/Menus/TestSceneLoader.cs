﻿// Copyright 2020 - 2021 Vignette Project
// Licensed under NPOSLv3. See LICENSE for details.

using Vignette.Application.Screens.Intro;

namespace Vignette.Application.Tests.Visual.Menus
{
    public class TestSceneLoader : ScreenTestScene
    {
        public TestSceneLoader()
        {
            LoadScreen(new Loader());
        }
    }
}
