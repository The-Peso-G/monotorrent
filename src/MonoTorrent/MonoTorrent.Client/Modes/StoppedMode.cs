﻿using System;
using System.Collections.Generic;
using System.Text;
using MonoTorrent.Common;

namespace MonoTorrent.Client
{
	class StoppedMode : Mode
	{
		public override bool CanAcceptConnections
		{
			get { return false; }
		}

		public override TorrentState State
		{
			get { return TorrentState.Stopped; }
		}

		public StoppedMode(TorrentManager manager)
			: base(manager)
		{
			
		}

		public override void HandlePeerConnected(PeerId id, MonoTorrent.Common.Direction direction)
		{
			id.CloseConnection();
		}


		public override void Tick(int counter)
		{
			// When stopped, do nothing
		}
	}
}