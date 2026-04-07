using System;

namespace ShowFollowerJobTitles.Common.Extensions;

/// <summary>A class containing extension methods for the <see cref="FontImageNames" /> class</summary>
public static class FontImageNamesExtensions {
  /// <summary>Get a roleIcon string based on the value of <see cref="FollowerRole" /></summary>
  /// <param name="followerRole">the Role of the follower</param>
  /// <returns>Icon for the given follower role; empty string if not found</returns>
  public static string GetIconForRole(this FollowerRole followerRole) {
    if (followerRole is FollowerRole.Worker or FollowerRole.Berries) // no icons available; TODO: use alternative/custom icons?
      return "";

    string roleIcon = FontImageNames.IconForRole(followerRole);
    if (!string.IsNullOrWhiteSpace(roleIcon))
      return roleIcon;

    return FontImageNames.IconForCommand(followerRole.FollowerRoleToCommand()) ?? "";
  }
}
