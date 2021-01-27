using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticleSystemEmissionType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ParticleSystemEmissionType");
		addMember(l,0,"Time");
		addMember(l,1,"Distance");
		LuaDLL.lua_pop(l, 1);
	}
}
