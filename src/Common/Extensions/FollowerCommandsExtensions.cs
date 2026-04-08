using System;

namespace ShowFollowerJobTitles.Common.Extensions;

/// <summary>A class containing extension methods for the <see cref="FollowerCommands" /> enum.</summary>
public static class FollowerCommandsExtensions {
  /// <summary>Whether the <see cref="FollowerCommands" /> is a <see cref="FollowerRole" /> command.</summary>
  /// <param name="followerCommand">The follower command.</param>
  /// <returns><c>true</c> if <paramref name="followerCommand"/> results in a valid <see cref="FollowerRole"/>, otherwise <c>false</c></returns>
  public static bool IsFollowerRoleCommand(this FollowerCommands followerCommand) {
    return followerCommand
      is FollowerCommands.WorshipAtShrine
      or FollowerCommands.CutTrees
      or FollowerCommands.Farmer_2
      or FollowerCommands.Study
      or FollowerCommands.ClearRubble
      or FollowerCommands.Build
      or FollowerCommands.ForageBerries
      or FollowerCommands.Cook_2
      or FollowerCommands.Janitor_2
      or FollowerCommands.Refiner_2
      or FollowerCommands.Undertaker
      or FollowerCommands.Brew
      or FollowerCommands.Medic
      or FollowerCommands.Rancher
      or FollowerCommands.Logistics
      or FollowerCommands.Handyman
      or FollowerCommands.TraitManipulator
      or FollowerCommands.MineRotstone;
  }

  /// <summary>Gets a <see cref="FollowerRole" /> based on the value of <see cref="FollowerCommands" />.</summary>
  /// <param name="followerCommand">The follower command.</param>
  /// <exception cref="ArgumentOutOfRangeException"><paramref name="followerCommand"/> of type <see cref="FollowerCommands"/> does not result in a valid <see cref="FollowerRole"/></exception>
  public static FollowerRole FollowerCommandToRole(this FollowerCommands followerCommand) {
    return followerCommand switch {
      FollowerCommands.WorshipAtShrine => FollowerRole.Worshipper,
      // => FollowerRole.Worker,
      FollowerCommands.CutTrees => FollowerRole.Lumberjack,
      FollowerCommands.Farmer_2 => FollowerRole.Farmer,
      FollowerCommands.Study => FollowerRole.Monk,
      FollowerCommands.ClearRubble => FollowerRole.StoneMiner,
      FollowerCommands.Build => FollowerRole.Builder,
      FollowerCommands.ForageBerries => FollowerRole.Forager,
      FollowerCommands.Cook_2 => FollowerRole.Chef,
      FollowerCommands.Janitor_2 => FollowerRole.Janitor,
      FollowerCommands.Refiner_2 => FollowerRole.Refiner,
      // => FollowerRole.Berries,
      FollowerCommands.Undertaker => FollowerRole.Undertaker,
      FollowerCommands.Brew => FollowerRole.Bartender,
      FollowerCommands.Medic => FollowerRole.Medic,
      FollowerCommands.Rancher => FollowerRole.Rancher,
      FollowerCommands.Logistics => FollowerRole.Logistics,
      FollowerCommands.Handyman => FollowerRole.Handyman,
      FollowerCommands.TraitManipulator => FollowerRole.TraitManipulator,
      FollowerCommands.MineRotstone => FollowerRole.RotstoneMiner,
      // var _ => FollowerRole.Worker
      var _ => throw new ArgumentOutOfRangeException(nameof(followerCommand), followerCommand, "Given follower command does not return a valid FollowerRole")
    };
  }
}
