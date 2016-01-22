## OpenMessage - Open Source XMPP Client ##

### Other OpenSource Projects used ###

- S22.XMPP
- OTRLib
- MonoFlat theme by HazelDev
- FreePik for Icon(s)

### Notes Before Use ###

To use OpenMessage as a xmpp client, when logging in, the <server_name> and <Jid_domain> must be the same:

Example: Server_name = "xmpp.example.com"    jid_domain = "example.com" WILL NOT WORK.

Working Example: server_name = "example.com"     jid_domain = "example.com" WILL WORK.

Please keep that in mind.


### Features (Current) ###

- Private Messaging 
- Save username for a later session
- Custom server setup
- Easy to use interface
- Basic roster (Basic add and Delete now available)
- TLS Support
- Basic Notification Support (Flashing taskbar icon and MP3/Wav sound)

### Planned features ###

- OTR Encryption
- Group Messaging
- PGP Encryption
- Audio/Video Chat
- UPnP/ICE/STUN 
- Maybe more?

### Installation of pre-built binaries ###

Just unzip and run OpenMessage.exe, Login and go.


### Compiling OpenMessage from Source ###

	Install Visual Studio 2015 or later with .NET 4.5+
	
	Download, or clone the Git Repo.
	
	Open in VS and click "Build" -> "Build Solution"