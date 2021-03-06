namespace DSTV.Contracts
{
    /// <summary>
    ///     Interface describing the model of the parsed DSTV structure
    /// </summary>
    public interface IDstv
    {
        /// <summary>
        ///     The header of the DSTV structure
        /// </summary>
        IDstvHeader? Header { get; }
    }
}