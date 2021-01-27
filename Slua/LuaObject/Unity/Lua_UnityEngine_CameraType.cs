using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_CameraType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.CameraType");
		addMember(l,1,"Game");
		addMember(l,2,"SceneView");
		addMember(l,4,"Preview");
		LuaDLL.lua_pop(l, 1);
	}
}
