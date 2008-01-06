﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Indy.IL2CPU.Plugs;

namespace Indy.IL2CPU.IL.CustomImplementations.System {
	[Plug(Target = typeof(Enum))]
	public static class EnumImpl {
		[PlugMethod(Signature = "System_String___System_Enum_ToString____")]
		public static string ToString(uint aThis) {
			return UInt32Impl.ToString(aThis);
		}
	}
}