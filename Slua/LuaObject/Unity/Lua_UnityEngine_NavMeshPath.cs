﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_NavMeshPath : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.NavMeshPath o;
			o=new UnityEngine.NavMeshPath();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetCornersNonAlloc(IntPtr l) {
		try {
			UnityEngine.NavMeshPath self=(UnityEngine.NavMeshPath)checkSelf(l);
			UnityEngine.Vector3[] a1;
			checkArray(l,2,out a1);
			var ret=self.GetCornersNonAlloc(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ClearCorners(IntPtr l) {
		try {
			UnityEngine.NavMeshPath self=(UnityEngine.NavMeshPath)checkSelf(l);
			self.ClearCorners();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_corners(IntPtr l) {
		try {
			UnityEngine.NavMeshPath self=(UnityEngine.NavMeshPath)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.corners);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_status(IntPtr l) {
		try {
			UnityEngine.NavMeshPath self=(UnityEngine.NavMeshPath)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.status);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.NavMeshPath");
		addMember(l,GetCornersNonAlloc);
		addMember(l,ClearCorners);
		addMember(l,"corners",get_corners,null,true);
		addMember(l,"status",get_status,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.NavMeshPath));
	}
}
