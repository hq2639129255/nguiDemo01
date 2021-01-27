using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_ShaderHardwareTier : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.ShaderHardwareTier");
		addMember(l,0,"Tier1");
		addMember(l,1,"Tier2");
		addMember(l,2,"Tier3");
		LuaDLL.lua_pop(l, 1);
	}
}
