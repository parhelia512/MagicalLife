﻿using MagicalLifeGUIWindows.Input.Specialized_Handlers;

namespace MagicalLifeGUIWindows.Input
{
    /// <summary>
    /// Holds all of the specialized input handlers.
    /// </summary>
    public static class InputHandlers
    {
        public static LivingMoveOrderInputHandler LivingMove { get; set; }

        public static LogoSkip LogoSkipper { get; set; }

        public static MiningActionHandler MiningAction { get; set; }

        public static ChopActionHandler ChopAction { get; set; }

        public static StrafeHandler StrafingHandler { get; set; }

        public static TillingActionHandler TillingAction { get; set; }

        public static EscapeHandler EscHandler { get; set; }

        public static LivingMenuHandler LivingMenuHandler { get; set; }

        public static ContainerDragHandler DragHandler { get; set; }

        public static ActionMenuHandler ActionMenu { get; set; }

        public static void GameLoadInitialize()
        {
            LogoSkipper = new LogoSkip();
            EscHandler = new EscapeHandler();
            DragHandler = new ContainerDragHandler();
        }

        public static void MapLoadInitialize()
        {
            LivingMove = new LivingMoveOrderInputHandler();
            MiningAction = new MiningActionHandler();
            TillingAction = new TillingActionHandler();
            StrafingHandler = new StrafeHandler();
            ChopAction = new ChopActionHandler();
            LivingMenuHandler = new LivingMenuHandler();
            ActionMenu = new ActionMenuHandler();
        }
    }
}