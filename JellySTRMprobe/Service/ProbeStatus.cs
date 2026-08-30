namespace JellySTRMprobe.Service;

/// <summary>
/// Status of a probe attempt.
/// </summary>
internal enum ProbeStatus
{
    /// <summary>
    /// The item was probed successfully.
    /// </summary>
    Succeeded,

    /// <summary>
    /// The probe failed.
    /// </summary>
    Failed,

    /// <summary>
    /// The item was skipped (most likely due to being removed).
    /// </summary>
    Skipped,
}
