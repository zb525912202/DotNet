﻿/// <summary>
/// 类说明：Assistant
/// 编 码 人：Alger
/// 联系方式：525912202  
/// 更新网站：http://www.shopnum1.com
/// </summary>


namespace Alger.Utils
{
    /// <summary>
    /// This class contains a string representation of Pop3 commands
    /// that can be executed.
    /// </summary>
    internal static class Pop3Commands
    {
        /// <summary>
        /// The USER command followed by a space.
        /// </summary>
        public const string User = "USER ";

        /// <summary>
        /// The CRLF escape sequence.
        /// </summary>
        public const string Crlf = "\r\n";

        /// <summary>
        /// The QUIT command followed by a CRLF.
        /// </summary>
        public const string Quit = "QUIT\r\n";

        /// <summary>
        /// The STAT command followed by a CRLF.
        /// </summary>
        public const string Stat = "STAT\r\n";

        /// <summary>
        /// The LIST command followed by a space.
        /// </summary>
        public const string List = "LIST ";

        /// <summary>
        /// The RETR command followed by a space.
        /// </summary>
        public const string Retr = "RETR ";

        /// <summary>
        /// The NOOP command followed by a CRLF.
        /// </summary>
        public const string Noop = "NOOP\r\n";

        /// <summary>
        /// The DELE command followed by a space.
        /// </summary>
        public const string Dele = "DELE ";

        /// <summary>
        /// The RSET command followed by a CRLF.
        /// </summary>
        public const string Rset = "RSET\r\n";

        /// <summary>
        /// The PASS command followed by a space.
        /// </summary>
        public const string Pass = "PASS ";

        /// <summary>
        /// The TOP command followed by a space.
        /// </summary>
        public const string Top = "TOP ";
    }
}
