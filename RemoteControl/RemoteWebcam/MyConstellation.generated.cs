﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Constellation SDK Code Generator.
//     Generator Version: 1.8.0.16088
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Constellation;
using Constellation.Package;
using System.Threading;
using System.Threading.Tasks;

namespace RemoteWebcam
{
    /// <summary>
    /// Represents your Constellation
    /// </summary>
	public static class MyConstellation
	{
		/// <summary>
		/// Specifies the sentinels in your Constellation
		/// </summary>
		public enum Sentinels
		{
			/// <summary>
            /// Sentinel 'MSI-FLO_UI'
            /// </summary>
			[RealName("MSI-FLO_UI")]
			MSI_FLO_UI,
		}

		/// <summary>
		/// Specifies the package's instances in your Constellation
		/// </summary>
		public enum PackageInstances
		{
			/// <summary>
            /// Package 'Pushbullet' on 'MSI-FLO_UI'
            /// </summary>
			[RealName("MSI-FLO_UI/Pushbullet")]
			MSI_FLO_UI_Pushbullet,
		}
		
		/// <summary>
		/// Specifies the packages in your Constellation
		/// </summary>
		public enum Packages
		{
			/// <summary>
            /// Package 'Pushbullet'
            /// </summary>
			[RealName("Pushbullet")]
			Pushbullet,
		}
    
		/// <summary>
        /// Creates the message scope to the specified sentinel.
        /// </summary>
        /// <param name="sentinel">The sentinel.</param>
        /// <returns>MessageScope</returns>
		public static MessageScope CreateScope(this Sentinels sentinel)
		{
		    return MessageScope.Create(MessageScope.ScopeType.Sentinel, sentinel.GetRealName());
		}    
		
		/// <summary>
        /// Creates the message scope to the specified package's instance.
        /// </summary>
        /// <param name="package">The package's instance.</param>
        /// <returns>MessageScope</returns>
		public static MessageScope CreateScope(this PackageInstances package)
		{
		    return MessageScope.Create(MessageScope.ScopeType.Package, package.GetRealName());      
		} 
		
		/// <summary>
        /// Creates the message scope to the specified package.
        /// </summary>
        /// <param name="package">The package.</param>
        /// <returns>MessageScope</returns>
		public static MessageScope CreateScope(this Packages package)
		{
		    return MessageScope.Create(MessageScope.ScopeType.Package, package.GetRealName());        
		}
	}
	
	/// <summary>
    /// Specifies the real name of an enum value.
    /// </summary>
    /// <seealso cref="System.Attribute" />
	[System.AttributeUsage(System.AttributeTargets.Field)]
	public class RealNameAttribute : System.Attribute
	{
	    /// <summary>
        /// Gets or sets the real name.
        /// </summary>
        /// <value>
        /// The real name.
        /// </value>
		public System.String RealName { get; set; }

		/// <summary>
        /// Initializes a new instance of the <see cref="RealNameAttribute"/> class.
        /// </summary>
        /// <param name="realname">The real name.</param>
		public RealNameAttribute(System.String realname)
		{
			this.RealName = realname;
		}
		
	    /// <summary>
        /// Gets the real name of an enum value.
        /// </summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <param name="value">The enum value.</param>
        /// <returns>The real name.</returns>
		public static string GetRealName<TEnum>(TEnum value)
		{
			var memInfo = typeof(TEnum).GetMember(value.ToString());
			var attributes = memInfo[0].GetCustomAttributes(typeof(RealNameAttribute), false);
			return (attributes != null && attributes.Length > 0) ? ((RealNameAttribute)attributes[0]).RealName : value.ToString();
		}
	}

	/// <summary>
    /// Provides extension methods to get the real name of a Sentinel, Package or PackageInstance.
    /// </summary>
	public static class RealNameExtension
	{
		public static string GetRealName(this MyConstellation.Sentinels sentinel)
		{
			return RealNameAttribute.GetRealName<MyConstellation.Sentinels>(sentinel);
		}

		public static string GetRealName(this MyConstellation.Packages package)
		{
			return RealNameAttribute.GetRealName<MyConstellation.Packages>(package);
		}

		public static string GetRealName(this MyConstellation.PackageInstances package)
		{
			return RealNameAttribute.GetRealName<MyConstellation.PackageInstances>(package);
		}
	}
}


namespace RemoteWebcam.PushBullet.MessageCallbacks
{
	/// <summary>
	/// Represent a PushBullet's devices list 
	/// </summary>
	public class DevicesList 
	{
		/// <summary>
		/// Gets or sets the devices. 
		/// </summary>
		public Device[] Devices { get; set; }

	}

	/// <summary>
	/// Represent a PushBullet's device 
	/// </summary>
	public class Device 
	{
		/// <summary>
		/// Gets or sets the Icon to use for this device, can be an arbitrary string.
///            Commonly used values are: "desktop", "browser", "website", "laptop", "tablet", "phone", "watch", "system". 
		/// </summary>
		public System.String Icon { get; set; }

		/// <summary>
		/// Gets or sets the Name to use when displaying the device. 
		/// </summary>
		public System.String Nickname { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the nickname was automatically generated from the manufacturer and model fields. 
		/// </summary>
		public System.Boolean IsGeneratedNickname { get; set; }

		/// <summary>
		/// Gets or sets the Manufacturer of the device. 
		/// </summary>
		public System.String Manufacturer { get; set; }

		/// <summary>
		/// Gets or sets the Model of the device. 
		/// </summary>
		public System.String Model { get; set; }

		/// <summary>
		/// Gets or sets the Version of the Pushbullet application installed on the device. 
		/// </summary>
		public System.Int32 AppVersion { get; set; }

		/// <summary>
		/// Gets or sets the fingerprint for the device, used by apps to avoid duplicate devices.
///            Value is platform-specific. 
		/// </summary>
		public System.String Fingerprint { get; set; }

		/// <summary>
		/// Gets or sets the Fingerprint for the device's end-to-end encryption key, used to determine which devices the current device (based on its own key fingerprint) will be able to talk to. 
		/// </summary>
		public System.String FingerprintKey { get; set; }

		/// <summary>
		/// Gets or sets Platform-specific push token. 
		/// </summary>
		public System.String PushToken { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the devices has SMS capability (currently only true for type="android" devices) 
		/// </summary>
		public System.Boolean HasSMS { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this item is active (not delete). 
		/// </summary>
		public System.Boolean IsActive { get; set; }

		/// <summary>
		/// Gets or sets the unique identifier for this item. 
		/// </summary>
		public System.String Id { get; set; }

		/// <summary>
		/// Gets or sets the creation time in floating point seconds (unix timestamp). 
		/// </summary>
		public System.Single Created { get; set; }

		/// <summary>
		/// Gets the creation date. 
		/// </summary>
		public System.DateTime CreatedDate { get; set; }

		/// <summary>
		/// Gets or sets the last modified time in floating point seconds (unix timestamp). 
		/// </summary>
		public System.Single Modified { get; set; }

		/// <summary>
		/// Gets the last modified date. 
		/// </summary>
		public System.DateTime ModifiedDate { get; set; }

	}

	/// <summary>
	/// Represent a PushBullet's chats list 
	/// </summary>
	public class ChatsList 
	{
		/// <summary>
		/// Gets or sets the pushes. 
		/// </summary>
		public Chat[] Chats { get; set; }

	}

	/// <summary>
	/// Represent a PushBullet's chat 
	/// </summary>
	public class Chat 
	{
		/// <summary>
		/// Gets or sets a value indicating whether this chat is muted. 
		/// </summary>
		public System.Boolean IsMuted { get; set; }

		/// <summary>
		/// Gets or sets the participant that the chat is with. 
		/// </summary>
		public ChatParticipant Participant { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this item is active (not delete). 
		/// </summary>
		public System.Boolean IsActive { get; set; }

		/// <summary>
		/// Gets or sets the unique identifier for this item. 
		/// </summary>
		public System.String Id { get; set; }

		/// <summary>
		/// Gets or sets the creation time in floating point seconds (unix timestamp). 
		/// </summary>
		public System.Single Created { get; set; }

		/// <summary>
		/// Gets the creation date. 
		/// </summary>
		public System.DateTime CreatedDate { get; set; }

		/// <summary>
		/// Gets or sets the last modified time in floating point seconds (unix timestamp). 
		/// </summary>
		public System.Single Modified { get; set; }

		/// <summary>
		/// Gets the last modified date. 
		/// </summary>
		public System.DateTime ModifiedDate { get; set; }

	}

	/// <summary>
	/// Represent a chat participant. 
	/// </summary>
	public class ChatParticipant 
	{
		/// <summary>
		/// Gets or sets the email address of the person. 
		/// </summary>
		public System.String Email { get; set; }

		/// <summary>
		/// Gets or sets the canonical email address of the person. 
		/// </summary>
		public System.String EmailNormalized { get; set; }

		/// <summary>
		/// Gets or sets the name of the person. 
		/// </summary>
		public System.String Name { get; set; }

		/// <summary>
		/// Gets or sets the image to display for the person. 
		/// </summary>
		public System.String ImageUrl { get; set; }

		/// <summary>
		/// Gets or sets the user identifier if this is a user. 
		/// </summary>
		public System.String UserId { get; set; }

		/// <summary>
		/// Gets or sets the type of the participant (user or email). 
		/// </summary>
		public ChatParticpantType Type { get; set; }

	}

	/// <summary>
	/// Represent a PushBullet's pushes list 
	/// </summary>
	public class PushesList 
	{
		/// <summary>
		/// Gets or sets the pushes. 
		/// </summary>
		public Push[] Pushes { get; set; }

	}

	/// <summary>
	/// Represent a PushBullet deletable base object 
	/// </summary>
	public class Push 
	{
		/// <summary>
		/// Gets or sets the type of the push. 
		/// </summary>
		public PushType Type { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this push is dismissed. 
		/// </summary>
		public System.Boolean IsDismissed { get; set; }

		/// <summary>
		/// Gets or sets the unique identifier set by the client, used to identify a push in case you receive it from /v2/everything before the call to /v2/pushes has completed. 
		/// </summary>
		public System.String UniqueId { get; set; }

		/// <summary>
		/// Gets or sets the direction the push was sent in. 
		/// </summary>
		public PushDirection Direction { get; set; }

		/// <summary>
		/// Gets or sets the user iden of the sender. 
		/// </summary>
		public System.String SenderUserId { get; set; }

		/// <summary>
		/// Gets or sets the email address of the sender. 
		/// </summary>
		public System.String SenderEmail { get; set; }

		/// <summary>
		/// Gets or sets the canonical email address of the sender. 
		/// </summary>
		public System.String SenderEmailNormalized { get; set; }

		/// <summary>
		/// Gets or sets the name of the sender. 
		/// </summary>
		public System.String SenderName { get; set; }

		/// <summary>
		/// Gets or sets the user iden of the receiver. 
		/// </summary>
		public System.String ReceiverUserId { get; set; }

		/// <summary>
		/// Gets or sets the email address of the receiver. 
		/// </summary>
		public System.String ReceiverEmail { get; set; }

		/// <summary>
		/// Gets or sets the canonical email address of the receiver. 
		/// </summary>
		public System.String ReceiverEmailNormalized { get; set; }

		/// <summary>
		/// Gets or sets the device iden of the target device, if sending to a single device. 
		/// </summary>
		public System.String TargetDeviceId { get; set; }

		/// <summary>
		/// Gets or sets the device iden of the sending device. Optionally set by the sender when creating a push. 
		/// </summary>
		public System.String SourcetDeviceId { get; set; }

		/// <summary>
		/// Gets or sets the iden of the client if the push was created by a client. 
		/// </summary>
		public System.String ClientId { get; set; }

		/// <summary>
		/// Gets or sets the iden of that channelr if the push was created by a channel. 
		/// </summary>
		public System.String ChannelId { get; set; }

		/// <summary>
		/// Gets or sets the list of guids (client side identifiers, not the guid field on pushes) for awake apps at the time the push was sent. If the length of this list is &gt; 0, dismissed will be set to true and the awake app(s) must decide what to do with the notification. 
		/// </summary>
		public System.String[] AwakeAppGuids { get; set; }

		/// <summary>
		/// Gets or sets the title of the push, used for all types of pushes 
		/// </summary>
		public System.String Title { get; set; }

		/// <summary>
		/// Gets or sets the body, used for all types of pushes 
		/// </summary>
		public System.String Body { get; set; }

		/// <summary>
		/// Gets or sets the URL, used for type="link" pushes 
		/// </summary>
		public System.String URL { get; set; }

		/// <summary>
		/// Gets or sets the name of the file, used for type="file" pushes 
		/// </summary>
		public System.String FileName { get; set; }

		/// <summary>
		/// Gets or sets the mime type of the file, used for type="file" pushes 
		/// </summary>
		public System.String FileType { get; set; }

		/// <summary>
		/// Gets or sets the file URL, used for type="file" pushes 
		/// </summary>
		public System.String FileURL { get; set; }

		/// <summary>
		/// Gets or sets the image URL, used for type="file" pushes 
		/// </summary>
		public System.String ImageURL { get; set; }

		/// <summary>
		/// Gets or sets the width of image in pixels, only present if ImageURL is set. 
		/// </summary>
		public System.Int32 ImageWidth { get; set; }

		/// <summary>
		/// Gets or sets the height of image in pixels, only present if ImageURL is set. 
		/// </summary>
		public System.Int32 ImageHeight { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this item is active (not delete). 
		/// </summary>
		public System.Boolean IsActive { get; set; }

		/// <summary>
		/// Gets or sets the unique identifier for this item. 
		/// </summary>
		public System.String Id { get; set; }

		/// <summary>
		/// Gets or sets the creation time in floating point seconds (unix timestamp). 
		/// </summary>
		public System.Single Created { get; set; }

		/// <summary>
		/// Gets the creation date. 
		/// </summary>
		public System.DateTime CreatedDate { get; set; }

		/// <summary>
		/// Gets or sets the last modified time in floating point seconds (unix timestamp). 
		/// </summary>
		public System.Single Modified { get; set; }

		/// <summary>
		/// Gets the last modified date. 
		/// </summary>
		public System.DateTime ModifiedDate { get; set; }

	}

	/// <summary>
	/// Represent a PushBullet's user 
	/// </summary>
	public class User 
	{
		/// <summary>
		/// Gets or sets the Email address. 
		/// </summary>
		public System.String Email { get; set; }

		/// <summary>
		/// Gets or sets the Canonical email address. 
		/// </summary>
		public System.String EmailNormalized { get; set; }

		/// <summary>
		/// Gets or sets the Full name if available. 
		/// </summary>
		public System.String Name { get; set; }

		/// <summary>
		/// Gets or sets the URL for image of user or placeholder imageL. 
		/// </summary>
		public System.String ImageUrl { get; set; }

		/// <summary>
		/// Gets or sets the Maximum upload size in bytes. 
		/// </summary>
		public System.Int32 MaxUploadSize { get; set; }

		/// <summary>
		/// Gets or sets the Number of users referred by this user. 
		/// </summary>
		public System.Int32 ReferredCount { get; set; }

		/// <summary>
		/// Gets or sets the User iden for the user that referred the current user, if set. 
		/// </summary>
		public System.String ReferrerId { get; set; }

		/// <summary>
		/// Gets or sets the unique identifier for this item. 
		/// </summary>
		public System.String Id { get; set; }

		/// <summary>
		/// Gets or sets the creation time in floating point seconds (unix timestamp). 
		/// </summary>
		public System.Single Created { get; set; }

		/// <summary>
		/// Gets the creation date. 
		/// </summary>
		public System.DateTime CreatedDate { get; set; }

		/// <summary>
		/// Gets or sets the last modified time in floating point seconds (unix timestamp). 
		/// </summary>
		public System.Single Modified { get; set; }

		/// <summary>
		/// Gets the last modified date. 
		/// </summary>
		public System.DateTime ModifiedDate { get; set; }

	}

	/// <summary>
	/// Represent the type of chat participant "email" or "user" 
	public enum ChatParticpantType
	{
		/// <summary>
		/// PushBullet user 
		/// </summary>
		User,
		/// <summary>
		/// Non PushBullet user (email) 
		/// </summary>
		Email,
	}

	/// <summary>
	/// Represent the type of a push 
	public enum PushType
	{
		/// <summary>
		/// Simple push with message 
		/// </summary>
		Note,
		/// <summary>
		/// Push attached to file 
		/// </summary>
		File,
		/// <summary>
		/// Push that contains link 
		/// </summary>
		Link,
	}

	/// <summary>
	/// Represent the direction the push was sent in 
	public enum PushDirection
	{
		/// <summary>
		/// The push was sent from myself 
		/// </summary>
		Self,
		/// <summary>
		/// The push was sent from Outgoing 
		/// </summary>
		Outgoing,
		/// <summary>
		/// The push was sent from Incoming 
		/// </summary>
		Incoming,
	}

	/// <summary>
	/// Represent the target the push was sent to 
	public enum PushTargetType
	{
		/// <summary>
		/// Send the push to a specific device. 
		/// </summary>
		Device,
		/// <summary>
		/// Send the push to this email address. If that email address is associated with a Pushbullet user, we will send it directly to that user, otherwise we will fallback to sending an email to the email address. 
		/// </summary>
		Email,
		/// <summary>
		/// Send the push to all subscribers to your channel that has this tag. 
		/// </summary>
		Channel,
		/// <summary>
		/// Send the push to all users who have granted access to your OAuth client that has this iden. 
		/// </summary>
		Client,
	}


	/// <summary>
	/// Provides extension methods for the MessageScope to PushBullet
	/// </summary>
	public static class PushBulletExtensions
	{
		/// <summary>
		/// Create a PushBulletScope
		/// </summary>
		/// <param name="scope">The Constellation MessageScope</param>
		public static PushBulletScope ToPushBulletScope(this MessageScope scope)
		{
			return new PushBulletScope(scope);
		}

		/// <summary>
		/// Create a PushBulletScope to all packages of the specified sentinel
		/// </summary>
		/// <param name="sentinel">The sentinel</param>
		public static PushBulletScope CreatePushBulletScope(this RemoteWebcam.MyConstellation.Sentinels sentinel)
		{
		    return MessageScope.Create(MessageScope.ScopeType.Sentinel, sentinel.GetRealName()).ToPushBulletScope();        
		}
		
		/// <summary>
		/// Create a PushBulletScope to a specific package
		/// </summary>
		/// <param name="package">The package</param>
		public static PushBulletScope CreatePushBulletScope(this RemoteWebcam.MyConstellation.PackageInstances package)
		{
		    return MessageScope.Create(MessageScope.ScopeType.Package, package.GetRealName()).ToPushBulletScope();        
		}
		
		/// <summary>
		/// Create a PushBulletScope to a specific package
		/// </summary>
		/// <param name="package">The package</param>
		public static PushBulletScope CreatePushBulletScope(this RemoteWebcam.MyConstellation.Packages package)
		{
		    return MessageScope.Create(MessageScope.ScopeType.Package, package.GetRealName()).ToPushBulletScope();  
		}
	}

	/// <summary>
    /// Represent a message scope to PushBullet
    /// </summary>
	public class PushBulletScope
	{
        /// <summary>
        /// The current scope
        /// </summary>
		private MessageScope currentScope = null;

		/// <summary>
        /// Initializes a new instance of the <see cref="PushBulletScope"/> class.
        /// </summary>
        /// <param name="scope">The scope.</param>
		public PushBulletScope(MessageScope scope)
		{
			this.currentScope = scope;
		}

		/// <summary>
		/// Get a list of devices belonging to the current user.
		/// </summary>
		/// <returns>Task of DevicesList</returns>
		/// <param name="cancellationToken">The CancellationToken that this task will observe.</param>		
		/// <param name="context">The MessageContext of the received message.</param>
		public Task<DevicesList> GetDevices( CancellationToken cancellationToken, out MessageContext context)
		{
			Task<dynamic> result = this.currentScope.GetProxy().GetDevices<DevicesList>( cancellationToken, out context);
            return result.ContinueWith<DevicesList>(task => (DevicesList)task.Result);
		}

		/// <summary>
		/// Get a list of devices belonging to the current user.
		/// </summary>
		/// <returns>Task of DevicesList</returns>
		/// <param name="context">The MessageContext of the received message.</param>
		public Task<DevicesList> GetDevices( out MessageContext context)
		{
			Task<dynamic> result = this.currentScope.GetProxy().GetDevices<DevicesList>( out context);
            return result.ContinueWith<DevicesList>(task => (DevicesList)task.Result);
		}

		/// <summary>
		/// Get a list of devices belonging to the current user.
		/// </summary>
		/// <returns>Task of DevicesList</returns>
		/// <param name="cancellationToken">The CancellationToken that this task will observe.</param>
		public Task<DevicesList> GetDevices( CancellationToken cancellationToken)
		{
			Task<dynamic> result = this.currentScope.GetProxy().GetDevices<DevicesList>( cancellationToken);
            return result.ContinueWith<DevicesList>(task => (DevicesList)task.Result);
		}

		/// <summary>
		/// Get a list of devices belonging to the current user.
		/// </summary>
		/// <returns>Task of DevicesList</returns>
		public Task<DevicesList> GetDevices()
		{
			Task<dynamic> result = this.currentScope.GetProxy().GetDevices<DevicesList>();
            return result.ContinueWith<DevicesList>(task => (DevicesList)task.Result);
		}


		/// <summary>
		/// Get a list of chats belonging to the current user.
		/// </summary>
		/// <returns>Task of ChatsList</returns>
		/// <param name="cancellationToken">The CancellationToken that this task will observe.</param>		
		/// <param name="context">The MessageContext of the received message.</param>
		public Task<ChatsList> GetChats( CancellationToken cancellationToken, out MessageContext context)
		{
			Task<dynamic> result = this.currentScope.GetProxy().GetChats<ChatsList>( cancellationToken, out context);
            return result.ContinueWith<ChatsList>(task => (ChatsList)task.Result);
		}

		/// <summary>
		/// Get a list of chats belonging to the current user.
		/// </summary>
		/// <returns>Task of ChatsList</returns>
		/// <param name="context">The MessageContext of the received message.</param>
		public Task<ChatsList> GetChats( out MessageContext context)
		{
			Task<dynamic> result = this.currentScope.GetProxy().GetChats<ChatsList>( out context);
            return result.ContinueWith<ChatsList>(task => (ChatsList)task.Result);
		}

		/// <summary>
		/// Get a list of chats belonging to the current user.
		/// </summary>
		/// <returns>Task of ChatsList</returns>
		/// <param name="cancellationToken">The CancellationToken that this task will observe.</param>
		public Task<ChatsList> GetChats( CancellationToken cancellationToken)
		{
			Task<dynamic> result = this.currentScope.GetProxy().GetChats<ChatsList>( cancellationToken);
            return result.ContinueWith<ChatsList>(task => (ChatsList)task.Result);
		}

		/// <summary>
		/// Get a list of chats belonging to the current user.
		/// </summary>
		/// <returns>Task of ChatsList</returns>
		public Task<ChatsList> GetChats()
		{
			Task<dynamic> result = this.currentScope.GetProxy().GetChats<ChatsList>();
            return result.ContinueWith<ChatsList>(task => (ChatsList)task.Result);
		}


		/// <summary>
		/// Request push history.
		/// </summary>
		/// <param name="modifiedAfter">Request pushes modified after this timestamp.</param>
		/// <returns>Task of PushesList</returns>
		/// <param name="cancellationToken">The CancellationToken that this task will observe.</param>		
		/// <param name="context">The MessageContext of the received message.</param>
		public Task<PushesList> GetPushes(System.Nullable<System.DateTime> modifiedAfter, CancellationToken cancellationToken, out MessageContext context)
		{
			Task<dynamic> result = this.currentScope.GetProxy().GetPushes<PushesList>(modifiedAfter, cancellationToken, out context);
            return result.ContinueWith<PushesList>(task => (PushesList)task.Result);
		}

		/// <summary>
		/// Request push history.
		/// </summary>
		/// <param name="modifiedAfter">Request pushes modified after this timestamp.</param>
		/// <returns>Task of PushesList</returns>
		/// <param name="context">The MessageContext of the received message.</param>
		public Task<PushesList> GetPushes(System.Nullable<System.DateTime> modifiedAfter, out MessageContext context)
		{
			Task<dynamic> result = this.currentScope.GetProxy().GetPushes<PushesList>(modifiedAfter, out context);
            return result.ContinueWith<PushesList>(task => (PushesList)task.Result);
		}

		/// <summary>
		/// Request push history.
		/// </summary>
		/// <param name="modifiedAfter">Request pushes modified after this timestamp.</param>
		/// <returns>Task of PushesList</returns>
		/// <param name="cancellationToken">The CancellationToken that this task will observe.</param>
		public Task<PushesList> GetPushes(System.Nullable<System.DateTime> modifiedAfter, CancellationToken cancellationToken)
		{
			Task<dynamic> result = this.currentScope.GetProxy().GetPushes<PushesList>(modifiedAfter, cancellationToken);
            return result.ContinueWith<PushesList>(task => (PushesList)task.Result);
		}

		/// <summary>
		/// Request push history.
		/// </summary>
		/// <param name="modifiedAfter">Request pushes modified after this timestamp.</param>
		/// <returns>Task of PushesList</returns>
		public Task<PushesList> GetPushes(System.Nullable<System.DateTime> modifiedAfter)
		{
			Task<dynamic> result = this.currentScope.GetProxy().GetPushes<PushesList>(modifiedAfter);
            return result.ContinueWith<PushesList>(task => (PushesList)task.Result);
		}


		/// <summary>
		/// Gets the currently logged in user.
		/// </summary>
		/// <returns>Task of User</returns>
		/// <param name="cancellationToken">The CancellationToken that this task will observe.</param>		
		/// <param name="context">The MessageContext of the received message.</param>
		public Task<User> GetCurrentUser( CancellationToken cancellationToken, out MessageContext context)
		{
			Task<dynamic> result = this.currentScope.GetProxy().GetCurrentUser<User>( cancellationToken, out context);
            return result.ContinueWith<User>(task => (User)task.Result);
		}

		/// <summary>
		/// Gets the currently logged in user.
		/// </summary>
		/// <returns>Task of User</returns>
		/// <param name="context">The MessageContext of the received message.</param>
		public Task<User> GetCurrentUser( out MessageContext context)
		{
			Task<dynamic> result = this.currentScope.GetProxy().GetCurrentUser<User>( out context);
            return result.ContinueWith<User>(task => (User)task.Result);
		}

		/// <summary>
		/// Gets the currently logged in user.
		/// </summary>
		/// <returns>Task of User</returns>
		/// <param name="cancellationToken">The CancellationToken that this task will observe.</param>
		public Task<User> GetCurrentUser( CancellationToken cancellationToken)
		{
			Task<dynamic> result = this.currentScope.GetProxy().GetCurrentUser<User>( cancellationToken);
            return result.ContinueWith<User>(task => (User)task.Result);
		}

		/// <summary>
		/// Gets the currently logged in user.
		/// </summary>
		/// <returns>Task of User</returns>
		public Task<User> GetCurrentUser()
		{
			Task<dynamic> result = this.currentScope.GetProxy().GetCurrentUser<User>();
            return result.ContinueWith<User>(task => (User)task.Result);
		}


		/// <summary>
		/// Sends the SMS from your phone (for Android devices only).
		/// </summary>
		/// <param name="userId">The identifier of the user sending this message.</param>
		/// <param name="deviceId">The identifier of the device corresponding to the phone that should send the SMS.</param>
		/// <param name="to">Phone number to send the SMS to.</param>
		/// <param name="message">The SMS message to send.</param>
		public void SendSMS(System.String userId, System.String deviceId, System.String to, System.String message)
		{
			this.currentScope.GetProxy().SendSMS(userId, deviceId, to, message);
		}

		/// <summary>
		/// Copy a String to the Device's Clipboard (PushBullet premium feature).
		/// </summary>
		/// <param name="userId">The identifier of the user sending this message.</param>
		/// <param name="deviceId">The identifier of the device corresponding to the phone that should send the SMS.</param>
		/// <param name="body">The text to copy to the clipboard.</param>
		public void CopyToClipboard(System.String userId, System.String deviceId, System.String body)
		{
			this.currentScope.GetProxy().CopyToClipboard(userId, deviceId, body);
		}

		/// <summary>
		/// Push a note to a device or another person.
		/// </summary>
		/// <param name="title">The note's title.</param>
		/// <param name="body">The text to copy to the clipboard.</param>
		/// <param name="target">The target type to send the push.</param>
		/// <param name="targetArgument">The target argument to send the push.</param>
		public void PushNote(System.String title, System.String body, PushTargetType target, System.String targetArgument)
		{
			this.currentScope.GetProxy().PushNote(title, body, target, targetArgument);
		}

		/// <summary>
		/// Push a Link to a device or another person.
		/// </summary>
		/// <param name="title">The note's title.</param>
		/// <param name="body">The text to copy to the clipboard.</param>
		/// <param name="url">The url to open.</param>
		/// <param name="target">The target type to send the push.</param>
		/// <param name="targetArgument">The target argument to send the push.</param>
		public void PushLink(System.String title, System.String body, System.String url, PushTargetType target, System.String targetArgument)
		{
			this.currentScope.GetProxy().PushLink(title, body, url, target, targetArgument);
		}

		/// <summary>
		/// Upload and Push a file to a device or another person.
		/// </summary>
		/// <param name="fileUri">The URI of the file you want to send.</param>
		/// <param name="body">The text to copy to the clipboard.</param>
		/// <param name="target">The target type to send the push.</param>
		/// <param name="targetArgument">The target argument to send the push.</param>
		public void PushFile(System.String fileUri, System.String body, PushTargetType target, System.String targetArgument)
		{
			this.currentScope.GetProxy().PushFile(fileUri, body, target, targetArgument);
		}
	}
}