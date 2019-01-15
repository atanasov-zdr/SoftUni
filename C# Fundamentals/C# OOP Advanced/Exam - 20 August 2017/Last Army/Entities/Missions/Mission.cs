﻿public abstract class Mission : IMission
{
    protected Mission(string name, double enduranceRequired, double scoreToComplete)
    {
        this.Name = name;
        this.EnduranceRequired = enduranceRequired;
        this.ScoreToComplete = scoreToComplete;
    }

    public string Name { get; }

    public double EnduranceRequired { get; }

    public double ScoreToComplete { get; }

    public double WearLevelDecrement { get; private set; }
}