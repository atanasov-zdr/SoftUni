﻿namespace FestivalManager
{
	using Core;
	using Core.Contracts;
	using Core.Controllers;
	using Core.Controllers.Contracts;
	using Entities;
	using Entities.Contracts;
    using FestivalManager.Core.IO.Contracts;
    using FestivalManager.Core.Repository;
    using System.IO;

    public static class StartUp
	{
		public static void Main(string[] args)
        {
            IStage stage = new Stage();
            IFestivalController festivalController = new FestivalController(stage);
            ISetController setController = new SetController(stage);

            IEngine engine = new Engine(festivalController, setController);

            engine.Run();
        }
	}
}