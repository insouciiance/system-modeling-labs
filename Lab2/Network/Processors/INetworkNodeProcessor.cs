﻿namespace Lab2.Network.Processors;

public interface INetworkNodeProcessor
{
    float CompletionTime { get; }

    bool TryEnter();

    bool TryExit();

    void CurrentTimeUpdated(float currentTime);
}
