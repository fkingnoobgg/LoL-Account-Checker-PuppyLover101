﻿
// Type: BananaLib.RiotObjects.Platform.TalentRow



using RtmpSharp.IO;
using System;
using System.Collections.Generic;

namespace BananaLib.RiotObjects.Platform
{
  [SerializedName("com.riotgames.platform.summoner.TalentRow")]
  [Serializable]
  public class TalentRow
  {
    [SerializedName("index")]
    public int Index { get; set; }

    [SerializedName("talents")]
    public List<Talent> Talents { get; set; }

    [SerializedName("tltGroupId")]
    public int TltGroupId { get; set; }

    [SerializedName("pointsToActivate")]
    public int PointsToActivate { get; set; }

    [SerializedName("tltRowId")]
    public int TltRowId { get; set; }
  }
}
