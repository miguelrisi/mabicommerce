﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MabiCommerce.Network
{
	static class Sig
	{
		public const int Connect = 100;
		public const int Disconnect = 101;
		public const int Send = 0x10101011;
		public const int Recv = 0x10101012;
	}
}
