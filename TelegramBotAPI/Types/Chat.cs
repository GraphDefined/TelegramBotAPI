﻿using System;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using Telegram.Bot.Types.Enums;

namespace Telegram.Bot.Types
{
    /// <summary>
    /// This object represents a chat.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Chat
    {
        /// <summary>
        /// Unique identifier for this chat, not exceeding 1e13 by absolute value
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public Int64 Id { get; set; }

        /// <summary>
        /// Type of chat
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public ChatType Type { get; set; }

        /// <summary>
        /// Optional. Title, for channels and group chats
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public String Title { get; set; }

        /// <summary>
        /// Optional. Username, for private chats and channels if available
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public String Username { get; set; }

        /// <summary>
        /// Optional. First name of the other party in a private chat
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public String FirstName { get; set; }

        /// <summary>
        /// Optional. Last name of the other party in a private chat
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public String LastName { get; set; }

        /// <summary>
        /// Optional. True if a group has 'All Members Are Admins' enabled.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Obsolete("Use Permissions field instead")]
        public Boolean AllMembersAreAdministrators { get; set; }

        /// <summary>
        /// Optional. Chat photo. Returned only in getChat.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ChatPhoto Photo { get; set; }

        /// <summary>
        /// Optional. Description, for supergroups and channel chats. Returned only in getChat.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public String Description { get; set; }

        /// <summary>
        /// Optional. Chat invite link, for supergroups and channel chats. Returned only in getChat.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public String InviteLink { get; set; }

        /// <summary>
        /// Optional. Pinned message, for supergroups. Returned only in getChat.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Message PinnedMessage { get; set; }

        /// <summary>
        /// Optional. Pinned message, for groups, supergroups and channels. Returned only in getChat.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ChatPermissions Permissions { get; set; }

        /// <summary>
        /// Optional. For supergroups, name of group sticker set. Returned only in getChat.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public String StickerSetName { get; set; }

        /// <summary>
        /// Optional. True, if the bot can change the group sticker set. Returned only in getChat.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Boolean? CanSetStickerSet { get; set; }
    }
}
