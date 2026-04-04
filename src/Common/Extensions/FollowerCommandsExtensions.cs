namespace ShowFollowerJobTitles.Common.Extensions;

/// <summary>A class containing extension methods for the <see cref="FollowerCommands" /> enum.</summary>
public static class FollowerCommandsExtensions
{
    /// <summary>Whether the <see cref="FollowerCommands" /> is a <see cref="FollowerRole" /> command.</summary>
    /// <param name="followerCommand">The follower command.</param>
    public static bool IsFollowerRoleCommand(this FollowerCommands followerCommand)
    {
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
    public static FollowerRole FollowerCommandToRole(this FollowerCommands followerCommand)
    {
        return followerCommand switch
        {
            FollowerCommands.WorshipAtShrine => FollowerRole.Worshipper, 
            FollowerCommands.CutTrees => FollowerRole.Lumberjack,
            FollowerCommands.Farmer_2 => FollowerRole.Farmer,
            FollowerCommands.Study => FollowerRole.Monk,
            FollowerCommands.ClearRubble => FollowerRole.StoneMiner,
            FollowerCommands.Build => FollowerRole.Builder,
            FollowerCommands.ForageBerries => FollowerRole.Forager,
            FollowerCommands.Cook_2 => FollowerRole.Chef,
            FollowerCommands.Janitor_2 => FollowerRole.Janitor,
            FollowerCommands.Refiner_2 => FollowerRole.Refiner,
            FollowerCommands.Undertaker => FollowerRole.Undertaker,
            FollowerCommands.Brew => FollowerRole.Bartender,
            FollowerCommands.Medic => FollowerRole.Medic,
            FollowerCommands.Rancher => FollowerRole.Rancher,
            FollowerCommands.Logistics => FollowerRole.Logistics,
            FollowerCommands.Handyman => FollowerRole.Handyman,
            FollowerCommands.TraitManipulator => FollowerRole.TraitManipulator,
            FollowerCommands.MineRotstone => FollowerRole.RotstoneMiner,
            _ => FollowerRole.Worker
        };
    }
    /// <summary>Gets a <see cref="FollowerCommands" /> based on the value of <see cref="FollowerRole" />.</summary>
    /// <param name="followerRole">The follower command.</param>
    public static FollowerCommands FollowerRoleToCommand(FollowerRole followerRole)
    {
        return followerRole switch
        {
            FollowerRole.Worshipper => FollowerCommands.WorshipAtShrine,
            FollowerRole.Lumberjack => FollowerCommands.CutTrees,
            FollowerRole.Farmer => FollowerCommands.Farmer_2,
            FollowerRole.Monk => FollowerCommands.Study,
            FollowerRole.StoneMiner => FollowerCommands.ClearRubble,
            FollowerRole.Builder => FollowerCommands.Build,
            FollowerRole.Forager => FollowerCommands.ForageBerries,
            FollowerRole.Chef => FollowerCommands.Cook_2,
            FollowerRole.Janitor => FollowerCommands.Janitor_2,
            FollowerRole.Refiner => FollowerCommands.Refiner_2,
            FollowerRole.Undertaker => FollowerCommands.Undertaker,
            FollowerRole.Bartender => FollowerCommands.Brew,
            FollowerRole.Medic => FollowerCommands.Medic,
            FollowerRole.Rancher => FollowerCommands.Rancher,
            FollowerRole.Logistics => FollowerCommands.Logistics,
            FollowerRole.Handyman => FollowerCommands.Handyman,
            FollowerRole.TraitManipulator => FollowerCommands.TraitManipulator,
            FollowerRole.RotstoneMiner => FollowerCommands.MineRotstone,
            _ => FollowerCommands.None
        };
    }
}
