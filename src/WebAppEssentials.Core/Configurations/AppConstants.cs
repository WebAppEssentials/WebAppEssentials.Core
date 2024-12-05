namespace WebAppEssentials.Core.Configurations;

/// <summary>
/// Contains various constants used throughout the application.
/// </summary>
public static class AppConstants
{
    /// <summary>
    /// Contains constants related to authentication.
    /// </summary>
    public static class Auth
    {
        /// <summary>
        /// Contains constants related to claim types.
        /// </summary>
        public static class ClaimTypes
        {
            /// <summary>
            /// Represents the claim type for user identifier.
            /// </summary>
            public const string ClaimTypeUid = "uid";
        }

        /// <summary>
        /// Contains constants related to roles.
        /// </summary>
        public static class Roles
        {
            /// <summary>
            /// Represents the role of an administrator.
            /// </summary>
            public const string Administrator = "Administrator";

            /// <summary>
            /// Represents the role of a regular user.
            /// </summary>
            public const string User = "User";
        }
    }
    
    /// <summary>
    /// Contains constants related to messages.
    /// </summary>
    public static class Messages
    {
        /// <summary>
        /// Represents the error message for a 500 internal server error.
        /// </summary>
        public const string Error500Message = "There was an error completing your request. Please try again later.";
    }
}