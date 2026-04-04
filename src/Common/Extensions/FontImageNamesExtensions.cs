using System;

namespace ShowFollowerJobTitles.Common.Extensions
{
    /// <summary>A class containing extension methods for the <see cref="FontImageNames" /> class</summary>
    public static class FontImageNamesExtensions
    {
        /// <summary>
        /// Get a roleIcon string based on on the value of <see cref="FollowerRole"/>.  
        /// Will return empty string if no icons are found
        /// </summary>
        /// <param name="followerRole">the Role of the follower</param>
        /// <returns></returns>
        public static string GetIconForRole(FollowerRole followerRole)
        {
            string roleIcon = FontImageNames.IconForRole(followerRole);
            if (string.IsNullOrWhiteSpace(roleIcon))
                try
                {
                    roleIcon = FontImageNames.IconForCommand(FollowerCommandsExtensions.FollowerRoleToCommand(followerRole));
                }
                catch (ArgumentOutOfRangeException)
                {
                    // Fallback also failed so keep empty,
                    // I'll maybe try later to add support for custom role here if possible
                }
            return roleIcon;
        }
    }
}
