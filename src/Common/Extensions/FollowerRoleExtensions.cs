using System;

namespace ShowFollowerJobTitles.Common.Extensions;

public static class FollowerRoleExtensions {
  /// <summary>Gets a <see cref="FollowerCommands" /> based on the value of <see cref="FollowerRole" />.</summary>
  /// <param name="followerRole">The follower command.</param>
  /// <exception cref="ArgumentOutOfRangeException"><paramref name="followerRole"/> is not a valid <see cref="FollowerRole" />.</exception>
  public static FollowerCommands FollowerRoleToCommand(this FollowerRole followerRole) {
    return followerRole switch {
      FollowerRole.Worshipper => FollowerCommands.WorshipAtShrine,
      // FollowerRole.Worker =>
      FollowerRole.Lumberjack => FollowerCommands.CutTrees,
      FollowerRole.Farmer => FollowerCommands.Farmer_2,
      FollowerRole.Monk => FollowerCommands.Study,
      FollowerRole.StoneMiner => FollowerCommands.ClearRubble,
      FollowerRole.Builder => FollowerCommands.Build,
      FollowerRole.Forager => FollowerCommands.ForageBerries,
      FollowerRole.Chef => FollowerCommands.Cook_2,
      FollowerRole.Janitor => FollowerCommands.Janitor_2,
      FollowerRole.Refiner => FollowerCommands.Refiner_2,
      // FollowerRole.Berries =>
      FollowerRole.Undertaker => FollowerCommands.Undertaker,
      FollowerRole.Bartender => FollowerCommands.Brew,
      FollowerRole.Medic => FollowerCommands.Medic,
      FollowerRole.Rancher => FollowerCommands.Rancher,
      FollowerRole.Logistics => FollowerCommands.Logistics,
      FollowerRole.Handyman => FollowerCommands.Handyman,
      FollowerRole.TraitManipulator => FollowerCommands.TraitManipulator,
      FollowerRole.RotstoneMiner => FollowerCommands.MineRotstone,
      // var _ => FollowerCommands.None
      var _ => throw new ArgumentOutOfRangeException(nameof(followerRole), followerRole, "Given follower role does not return a valid FollowerCommands")
    };
  }
}
