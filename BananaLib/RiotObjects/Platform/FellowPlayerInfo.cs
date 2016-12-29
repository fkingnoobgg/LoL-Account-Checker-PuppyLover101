﻿
using RtmpSharp.IO;
using System;

namespace BananaLib.RiotObjects.Platform
{
  [SerializedName("com.riotgames.platform.statistics.FellowPlayerInfo")]
  [Serializable]
  public class FellowPlayerInfo
  {
    [SerializedName("championId")]
    public double ChampionId { get; set; }

    [SerializedName("teamId")]
    public int TeamId { get; set; }

    [SerializedName("summonerId")]
    public double SummonerId { get; set; }
  }
}
