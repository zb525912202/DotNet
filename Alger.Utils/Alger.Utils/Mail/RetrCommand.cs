﻿/// <summary>
/// 类说明：Assistant
/// 编 码 人：Alger
/// 联系方式：525912202  
/// 更新网站：http://www.shopnum1.com
/// </summary>
using System;
using System.IO;
namespace Alger.Utils
{
    /// <summary>
    /// This class represents the Pop3 RETR command.
    /// </summary>
    internal sealed class RetrCommand : Pop3Command<RetrResponse>
    {
        int _message;

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrCommand"/> class.
        /// </summary>
        /// <param name="stream">The stream.</param>
        /// <param name="message">The message.</param>
        public RetrCommand(Stream stream, int message)
            : base(stream, true, Pop3State.Transaction)
        {
            if (message < 0)
            {
                throw new ArgumentOutOfRangeException("message");
            }

            _message = message;
        }

        /// <summary>
        /// Creates the RETR request message.
        /// </summary>
        /// <returns>
        /// The byte[] containing the RETR request message.
        /// </returns>
        protected override byte[] CreateRequestMessage()
        {
            return GetRequestMessage(Pop3Commands.Retr, _message.ToString(), Pop3Commands.Crlf);
        }

        /// <summary>
        /// Creates the response.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <returns>
        /// The <c>Pop3Response</c> containing the results of the
        /// Pop3 command execution.
        /// </returns>
        protected override RetrResponse CreateResponse(byte[] buffer)
        {
            Pop3Response response = Pop3Response.CreateResponse(buffer);

            string[] messageLines = GetResponseLines(StripPop3HostMessage(buffer, response.HostMessage));

            return new RetrResponse(response, messageLines);
        }
    }
}
