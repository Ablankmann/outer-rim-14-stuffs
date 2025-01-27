﻿using Content.Shared.CharacterAppearance;
using Content.Shared.Markings;
using Content.Shared.Species;

namespace Content.Shared.IoC
{
    public static class SharedContentIoC
    {
        public static void Register()
        {
            IoCManager.Register<SpriteAccessoryManager, SpriteAccessoryManager>();
            IoCManager.Register<MarkingManager, MarkingManager>();
            IoCManager.Register<SpeciesManager>();
        }
    }
}
