// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using AdaptiveCardsBot;

namespace PeoplePicker.Models
{
    public static class TaskModuleUIConstants
    {
        public static UISettings YouTube { get; set; } =
            new UISettings(1000, 700, "Check Holidays", TaskModuleIds.YouTube, "Check Holidays");
        public static UISettings CustomForm { get; set; } =
            new UISettings(510, 450, "Custom Form", TaskModuleIds.CustomForm, "Custom Form");
        public static UISettings AdaptiveCard { get; set; } =
            new UISettings(400, 200, "Adaptive Card: Inputs", TaskModuleIds.AdaptiveCard, "Adaptive Card");
    }
}
