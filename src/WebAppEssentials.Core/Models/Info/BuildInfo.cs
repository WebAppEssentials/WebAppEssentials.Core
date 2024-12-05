namespace WebAppEssentials.Models.Info;

/// <summary>
/// Represents build information such as version and build date.
/// </summary>
public class BuildInfo
{
    /// <summary>
    /// Gets or sets the version of the build.
    /// </summary>
    /// <value>
    /// A string representing the version of the build.
    /// </value>
    public required string Version { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the build was created.
    /// </summary>
    /// <value>
    /// A DateTime object representing the build date and time.
    /// </value>
    public DateTime BuildDate { get; set; }
}