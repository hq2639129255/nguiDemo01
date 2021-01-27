using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_VR_VRNode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.VR.VRNode");
		addMember(l,0,"LeftEye");
		addMember(l,1,"RightEye");
		addMember(l,2,"CenterEye");
		addMember(l,3,"Head");
		LuaDLL.lua_pop(l, 1);
	}
}
