using Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.VideoCard;

public class VideoCard
{
    public VideoCard(Height videoCardHeight, Width videoCardWidth, Frequency chipFrequency, Watt videoCardPowerConsumption)
    {
        VideoCardHeight = videoCardHeight;
        VideoCardWidth = videoCardWidth;
        ChipFrequency = chipFrequency;
        VideoCardPowerConsumption = videoCardPowerConsumption;
    }

    public Height VideoCardHeight { get; private set; }
    public Width VideoCardWidth { get; private set; }
    public Frequency ChipFrequency { get; private set; }
    public Watt VideoCardPowerConsumption { get; private set; }
}