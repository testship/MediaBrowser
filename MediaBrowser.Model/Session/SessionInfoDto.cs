﻿using MediaBrowser.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MediaBrowser.Model.Session
{
    public class SessionInfoDto : INotifyPropertyChanged
    {
        /// <summary>
        /// Gets or sets a value indicating whether this instance can seek.
        /// </summary>
        /// <value><c>true</c> if this instance can seek; otherwise, <c>false</c>.</value>
        public bool CanSeek { get; set; }

        /// <summary>
        /// Gets or sets the queueable media types.
        /// </summary>
        /// <value>The queueable media types.</value>
        public List<string> QueueableMediaTypes { get; set; }
        
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>The id.</value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        /// <value>The user id.</value>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>The name of the user.</value>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the application version.
        /// </summary>
        /// <value>The application version.</value>
        public string ApplicationVersion { get; set; }
        
        /// <summary>
        /// Gets or sets the type of the client.
        /// </summary>
        /// <value>The type of the client.</value>
        public string Client { get; set; }

        /// <summary>
        /// Gets or sets the last activity date.
        /// </summary>
        /// <value>The last activity date.</value>
        public DateTime LastActivityDate { get; set; }

        /// <summary>
        /// Gets or sets the now viewing context.
        /// </summary>
        /// <value>The now viewing context.</value>
        public string NowViewingContext { get; set; }

        /// <summary>
        /// Gets or sets the type of the now viewing item.
        /// </summary>
        /// <value>The type of the now viewing item.</value>
        public string NowViewingItemType { get; set; }

        /// <summary>
        /// Gets or sets the now viewing item identifier.
        /// </summary>
        /// <value>The now viewing item identifier.</value>
        public string NowViewingItemId { get; set; }

        /// <summary>
        /// Gets or sets the name of the now viewing item.
        /// </summary>
        /// <value>The name of the now viewing item.</value>
        public string NowViewingItemName { get; set; }
        
        /// <summary>
        /// Gets or sets the name of the device.
        /// </summary>
        /// <value>The name of the device.</value>
        public string DeviceName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is paused.
        /// </summary>
        /// <value><c>true</c> if this instance is paused; otherwise, <c>false</c>.</value>
        public bool IsPaused { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is muted.
        /// </summary>
        /// <value><c>true</c> if this instance is muted; otherwise, <c>false</c>.</value>
        public bool IsMuted { get; set; }
        
        /// <summary>
        /// Gets or sets the now playing item.
        /// </summary>
        /// <value>The now playing item.</value>
        public BaseItemInfo NowPlayingItem { get; set; }

        /// <summary>
        /// Gets or sets the now playing position ticks.
        /// </summary>
        /// <value>The now playing position ticks.</value>
        public long? NowPlayingPositionTicks { get; set; }

        /// <summary>
        /// Gets or sets the device id.
        /// </summary>
        /// <value>The device id.</value>
        public string DeviceId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [supports remote control].
        /// </summary>
        /// <value><c>true</c> if [supports remote control]; otherwise, <c>false</c>.</value>
        public bool SupportsRemoteControl { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
