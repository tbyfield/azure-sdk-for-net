// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.OpenAI
{
    /// <summary> A single, role-attributed message within a chat completion interaction. </summary>
    public partial class ChatMessage
    {
        /// <summary>
        /// Gets the role associated with this message.
        /// </summary>
        public ChatRole Role { get; internal set; }
        /// <summary>
        /// Gets the textual content associated with this message.
        /// </summary>
        public string Content { get; internal set; }

        /// <summary>
        /// Initializes a new instance of ChatMessage.
        /// </summary>
        /// <param name="role">The role to associate with the message.</param>
        /// <param name="content">The content to associate with the message.</param>
        public ChatMessage(ChatRole role, string content)
        {
            Role = role;
            Content = content;
        }

        internal ChatMessage()
        { }
    }
}
