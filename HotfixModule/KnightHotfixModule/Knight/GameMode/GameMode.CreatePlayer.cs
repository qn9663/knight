﻿//======================================================================
//        Copyright (C) 2015-2020 Winddy He. All rights reserved
//        Email: hgplan@126.com
//======================================================================
using Core;
using System;
using System.Collections.Generic;
using WindHotfix.GameStage;

namespace Game.Knight
{
    public partial class GameMode_CreatePlayer : GameMode
    {
        public StageConfig  StageConfig;

        protected override void OnBuildStages()
        {
            this.AddGameStage(0, new StageTask_LoadAssets(this));
            this.AddGameStage(1, new StageTask_InitData(this));
        }
    }
}
