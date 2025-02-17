﻿using System.Drawing;

namespace TagsCloudContainer.Interfaces;

public interface IGraphicsProvider
{
    Graphics Create();

    void Commit();
}