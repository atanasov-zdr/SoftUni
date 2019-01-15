﻿using Logger.Factories;
using Logger.Models.Interfaces;
using System;

namespace Logger
{
    class Engine
    {
        private ILogger logger;
        private ErrorFactory errorFactory;

        public Engine(ILogger logger, ErrorFactory errorFactory)
        {
            this.logger = logger;
            this.errorFactory = errorFactory;
        }

        public void Run()
        {
            string input;
            while((input = Console.ReadLine()) != "END")
            {
                var errorArgs = input.Split('|');
                var level = errorArgs[0];
                var dateTime = errorArgs[1];
                var message = errorArgs[2];

                IError error = this.errorFactory.CreateError(dateTime, level, message);
                this.logger.Log(error);
            }

            Console.WriteLine("Logger info");
            foreach (IAppender appender in this.logger.Appenders)
            {
                Console.WriteLine(appender);
            }
        }
    }
}
