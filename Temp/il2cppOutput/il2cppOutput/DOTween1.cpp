﻿#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <cstring>
#include <string.h>
#include <stdio.h>
#include <cmath>
#include <limits>
#include <assert.h>
#include <stdint.h>

#include "codegen/il2cpp-codegen.h"
#include "il2cpp-object-internals.h"

template <typename R>
struct VirtFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename R, typename T1, typename T2, typename T3, typename T4, typename T5, typename T6>
struct VirtFuncInvoker6
{
	typedef R (*Func)(void*, T1, T2, T3, T4, T5, T6, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, p1, p2, p3, p4, p5, p6, invokeData.method);
	}
};
struct VirtActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
struct GenericVirtActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_virtual_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
struct InterfaceActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
struct GenericInterfaceActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_interface_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};

// DG.Tweening.Core.ABSSequentiable
struct ABSSequentiable_tDA1366907669973CC0BB553EF4159D45FC46A757;
// DG.Tweening.Core.DOGetter`1<System.String>
struct DOGetter_1_t8487F7D92634187297C55D53D69038ECF0AF1A5B;
// DG.Tweening.Core.DOGetter`1<UnityEngine.Color>
struct DOGetter_1_t1CBCAE9C5512210401294F691A3DA53221D4D519;
// DG.Tweening.Core.DOGetter`1<UnityEngine.Vector2>
struct DOGetter_1_tED4D2C955A43A16638D892A1DBA007D1098B34D1;
// DG.Tweening.Core.DOGetter`1<UnityEngine.Vector3>
struct DOGetter_1_t6A6DB6A183AD6D7F4B2F3656C4AB9326994D8CA4;
// DG.Tweening.Core.DOSetter`1<System.String>
struct DOSetter_1_t4596A2038D23C79F7EECD86309BBCD2D10AEEFA6;
// DG.Tweening.Core.DOSetter`1<UnityEngine.Color>
struct DOSetter_1_t15DB9D23118C9930751CE2A17C20F7E010D0C9D1;
// DG.Tweening.Core.DOSetter`1<UnityEngine.Vector2>
struct DOSetter_1_t6957431283D538C65C791011FE5AECB0235D641F;
// DG.Tweening.Core.DOSetter`1<UnityEngine.Vector3>
struct DOSetter_1_t528C4470268C88CABD1BFDF039B98D72E012AF46;
// DG.Tweening.Core.DOTweenComponent
struct DOTweenComponent_t48118927332C9BFAE792209EEE42AF786370B05F;
// DG.Tweening.Core.TweenerCore`3<System.String,System.String,DG.Tweening.Plugins.Options.StringOptions>
struct TweenerCore_3_t5CC4896707276A1DD128E986B753C9447C7E8FA8;
// DG.Tweening.Core.TweenerCore`3<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions>
struct TweenerCore_3_t135A028153B5C8F7030BB331039A6C1C8B41AC65;
// DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions>
struct TweenerCore_3_tEF3CF5BF3AF3C462924E66EFF3839D0D49C74066;
// DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions>
struct TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1;
// DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions>
struct TweenerCore_3_t104C232CA5A703780F416D4E8F2D71E42FE9C46B;
// DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions>
struct TweenerCore_3_t8144D2B7915783E42476714D21E639420B0EDC30;
// DG.Tweening.EaseFunction
struct EaseFunction_tAC315FE3B057AC8DA87991C785F2595F3B761691;
// DG.Tweening.Plugins.Core.ABSTweenPlugin`3<System.String,System.String,DG.Tweening.Plugins.Options.StringOptions>
struct ABSTweenPlugin_3_t9D226D0B072F9EA7690FA7A649856709CE00D725;
// DG.Tweening.Plugins.Core.ABSTweenPlugin`3<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions>
struct ABSTweenPlugin_3_tD58649751AD5C680679FE9F34E72C693082D2950;
// DG.Tweening.Plugins.Core.ABSTweenPlugin`3<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions>
struct ABSTweenPlugin_3_tF0F62B2C3E037FA76B2A6352C4C0E6C8B2D668FD;
// DG.Tweening.Plugins.Core.ABSTweenPlugin`3<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions>
struct ABSTweenPlugin_3_t4B150004C6035544DAF0205D76D11C3A5ADFE3D3;
// DG.Tweening.Plugins.Core.ABSTweenPlugin`3<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions>
struct ABSTweenPlugin_3_t50462951CA2C372D1A9BC7C38C6ECC1810944678;
// DG.Tweening.Plugins.Core.ABSTweenPlugin`3<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions>
struct ABSTweenPlugin_3_t59C22DD36F4259810DAE41F464AC73D990C88056;
// DG.Tweening.Plugins.Core.PathCore.Path
struct Path_tCE251EA0F45EA8B91CAD11018E275B451FAC6FA2;
// DG.Tweening.Sequence
struct Sequence_tA6FA099F465933113D131DDC0EECB6A19A27BCB2;
// DG.Tweening.ShortcutExtensions/<>c__DisplayClass110
struct U3CU3Ec__DisplayClass110_t721552CB7F431CCC670721B6011F9EE1C26EDADE;
// DG.Tweening.ShortcutExtensions/<>c__DisplayClass114
struct U3CU3Ec__DisplayClass114_t1485A600A38FE289BB342ABE9B33E75FDFF2700B;
// DG.Tweening.ShortcutExtensions/<>c__DisplayClass12c
struct U3CU3Ec__DisplayClass12c_t3BC7A246A89C39269E33DB9EFFF37B2EEF6C1F23;
// DG.Tweening.ShortcutExtensions/<>c__DisplayClass16
struct U3CU3Ec__DisplayClass16_t4E802A0F0A82726640C245784AF8DCB4EF296CD0;
// DG.Tweening.ShortcutExtensions/<>c__DisplayClass1e
struct U3CU3Ec__DisplayClass1e_tF8B7419EC65C518E507CBB88232CB4C8EB0D2F2D;
// DG.Tweening.ShortcutExtensions/<>c__DisplayClass22
struct U3CU3Ec__DisplayClass22_t9D675687ADAAE6B97900F09FA258BAD293F0169B;
// DG.Tweening.ShortcutExtensions/<>c__DisplayClass26
struct U3CU3Ec__DisplayClass26_tE9EF7F8D0A615A1A5C05FC64480ED086DB8BAECB;
// DG.Tweening.ShortcutExtensions/<>c__DisplayClass2a
struct U3CU3Ec__DisplayClass2a_t830E1745D71495189F605D0C0FB47F62DC405163;
// DG.Tweening.ShortcutExtensions/<>c__DisplayClass4a
struct U3CU3Ec__DisplayClass4a_t8BA738A82F498990CA8964AD18CF9EBE36997E56;
// DG.Tweening.ShortcutExtensions/<>c__DisplayClass52
struct U3CU3Ec__DisplayClass52_tAE0AB9391667396DE92813351A9D9EF7129466F9;
// DG.Tweening.ShortcutExtensions/<>c__DisplayClass71
struct U3CU3Ec__DisplayClass71_t08F78102E6BDF49AD78C3D6604C3E5357F334C3D;
// DG.Tweening.ShortcutExtensions/<>c__DisplayClass7d
struct U3CU3Ec__DisplayClass7d_tAF739539C02E5E3135C7304E0236701AB93FC5C0;
// DG.Tweening.ShortcutExtensions/<>c__DisplayClass92
struct U3CU3Ec__DisplayClass92_tA75A43DD789C96E30D590D2F545C94EC69589DA6;
// DG.Tweening.ShortcutExtensions/<>c__DisplayClass96
struct U3CU3Ec__DisplayClass96_t5EC6E6D72824408D93A7F57ECAF35DB96FCD6D67;
// DG.Tweening.ShortcutExtensions/<>c__DisplayClassa
struct U3CU3Ec__DisplayClassa_tC915AA461E4FD5AE3D48A51D677710E64F437E96;
// DG.Tweening.ShortcutExtensions/<>c__DisplayClassa2
struct U3CU3Ec__DisplayClassa2_t9AD84E358FF7A7DFD16DC2C4CDED2462E72C4C8E;
// DG.Tweening.ShortcutExtensions/<>c__DisplayClassb2
struct U3CU3Ec__DisplayClassb2_tDE677984DFFECB80EF616D9A6D4D2075C35028E6;
// DG.Tweening.ShortcutExtensions/<>c__DisplayClassb6
struct U3CU3Ec__DisplayClassb6_t2BFB12249855A8FE2A74C4B29DDA349C49573ED2;
// DG.Tweening.ShortcutExtensions/<>c__DisplayClassba
struct U3CU3Ec__DisplayClassba_t0A65EB02F44732F72DA15E4767826F7318A5558E;
// DG.Tweening.ShortcutExtensions/<>c__DisplayClassbe
struct U3CU3Ec__DisplayClassbe_t1186133747C674242AF1F941435C43C73D9B2CD2;
// DG.Tweening.ShortcutExtensions/<>c__DisplayClassd2
struct U3CU3Ec__DisplayClassd2_t2E49EDC8ED935AAE089A256C17B0F4810A868E1E;
// DG.Tweening.ShortcutExtensions/<>c__DisplayClassd6
struct U3CU3Ec__DisplayClassd6_tDD8BC433E9E2A0F72AC9DEDA1BC64AFFBEA6DC1A;
// DG.Tweening.ShortcutExtensions/<>c__DisplayClassda
struct U3CU3Ec__DisplayClassda_t1B3A1757D73FF007687F7F4EFC16AD0000C405C0;
// DG.Tweening.ShortcutExtensions/<>c__DisplayClasse
struct U3CU3Ec__DisplayClasse_tDC794AB97B18E7819CBEFA7BBA29B61CE76EBF6A;
// DG.Tweening.ShortcutExtensions/<>c__DisplayClasse2
struct U3CU3Ec__DisplayClasse2_t7B9A4AEA17B3EBAD85BDAE3DE6094EC7B673379A;
// DG.Tweening.ShortcutExtensions/<>c__DisplayClassea
struct U3CU3Ec__DisplayClassea_t93D241F4C148181D28E9E5CA8159DBA36845D6E4;
// DG.Tweening.ShortcutExtensions/<>c__DisplayClassf2
struct U3CU3Ec__DisplayClassf2_tADC804C6DFA12A25797C96316169554AE845E88F;
// DG.Tweening.Tween
struct Tween_t119487E0AB84EF563521F1043116BDBAE68AC437;
// DG.Tweening.TweenCallback
struct TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83;
// DG.Tweening.TweenCallback`1<System.Int32>
struct TweenCallback_1_t46CB97F053453C4F41F8AE6213792813E455DDE1;
// DG.Tweening.Tween[]
struct TweenU5BU5D_t59E878639D2690DEB50DB29D6D3871EB68312DD5;
// DG.Tweening.Tweener
struct Tweener_t9B2A5E94EE6D11F7607E58AE4E37186FF63587C8;
// System.AsyncCallback
struct AsyncCallback_t3F3DA3BEDAEE81DD1D24125DF8EB30E85EE14DA4;
// System.Byte[]
struct ByteU5BU5D_tD06FDBE8142446525DF1C40351D523A228373821;
// System.Char[]
struct CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2;
// System.Collections.Generic.List`1<DG.Tweening.Core.ABSSequentiable>
struct List_1_t2E181C700331B7635DE1FD6A98300CEAEFABC4ED;
// System.Collections.Generic.List`1<DG.Tweening.Tween>
struct List_1_t57BB69F1AC3759152D9E750F6120000328D367B8;
// System.Collections.Generic.List`1<DG.Tweening.TweenCallback>
struct List_1_tA91E07DF8FDCABF79352C03D79A9D29DE3BBA212;
// System.Collections.Generic.Stack`1<DG.Tweening.Tween>
struct Stack_1_t6CA58A0BB4B4756170E9E83B26CD1DDE07AFA198;
// System.Collections.IDictionary
struct IDictionary_t1BD5C1546718A374EA8122FBD6C6EE45331E8CE7;
// System.Delegate
struct Delegate_t;
// System.DelegateData
struct DelegateData_t1BF9F691B56DAE5F8C28C5E084FDE94F15F27BBE;
// System.Delegate[]
struct DelegateU5BU5D_tDFCDEE2A6322F96C0FE49AF47E9ADB8C4B294E86;
// System.Diagnostics.StackTrace[]
struct StackTraceU5BU5D_t855F09649EA34DEE7C1B6F088E0538E3CCC3F196;
// System.IAsyncResult
struct IAsyncResult_t8E194308510B375B42432981AE5E7488C458D598;
// System.IntPtr[]
struct IntPtrU5BU5D_t4DC01DCB9A6DF6C9792A6513595D7A11E637DCDD;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// System.Runtime.Serialization.SafeSerializationManager
struct SafeSerializationManager_t4A754D86B0F784B18CBC36C073BA564BED109770;
// System.Single[]
struct SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5;
// System.String
struct String_t;
// System.Type
struct Type_t;
// System.Void
struct Void_t22962CB4C05B1D89B55A6E1139F0E87A90987017;
// UnityEngine.Camera
struct Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34;
// UnityEngine.Camera/CameraCallback
struct CameraCallback_t8BBB42AA08D7498DFC11F4128117055BC7F0B9D0;
// UnityEngine.Component
struct Component_t05064EF382ABCAF4B8C94F8A350EA85184C26621;
// UnityEngine.Material
struct Material_tF7DB3BF0C24DEC2FE0CB51E5DF5053D5223C8598;
// UnityEngine.Rigidbody
struct Rigidbody_tE0A58EE5A1F7DC908EFFB4F0D795AC9552A750A5;
// UnityEngine.Transform
struct Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA;
// UnityEngine.Vector3[]
struct Vector3U5BU5D_tB9EC3346CC4A0EA5447D968E84A9AC1F6F372C28;

IL2CPP_EXTERN_C RuntimeClass* DOTween_t6BB48F76E494B12781696AF3D0733CA8DC367E8D_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Debugger_tD9D47C252FB20009C8276590D54394E430619D16_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Exception_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* StringPluginExtensions_tB7BCF7EB9633300CDD2387F467B58782AE28F06B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral349083C2E0F6FC8B25EE2DB20339807D02467792;
IL2CPP_EXTERN_C const RuntimeMethod* Nullable_1_GetValueOrDefault_m35E99BED1252A5C9E5A0D197FCF8E3C0E2A3C2A8_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Nullable_1__ctor_m49ABD148B7A7789CB005BA17CA29E1896EE35057_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Nullable_1_get_HasValue_m799FAADF5BA2C9E13220149280B2951799A26D7F_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Nullable_1_get_Value_m902B83FE050783CC1CEF6CB970A5AAB926F77D9C_RuntimeMethod_var;
IL2CPP_EXTERN_C const uint32_t TweenExtensions_Complete_m2D7930B127444FC11872F868A7B581892526DD1F_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t TweenExtensions_IsComplete_m058D78AC1B3A1E815331E06C8386AAA4CC236A0F_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t TweenExtensions_IsInitialized_m831388B524712F533A55A7D945B0501A68A144A9_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t TweenExtensions_IsPlaying_m27DD47C5CCC873CD11D4C6692F3798E3AD6E9FF9_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t TweenExtensions_Kill_mE9A3C52FEC438801BEC9CC96435FFF18C72C8C44_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t TweenExtensions_PlayBackwards_mD35BBEE7660D338C3747BB216444BF15C45A97E1_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t TweenExtensions_PlayForward_mCAE462ED14463F38AA0DB324B4607246C975DA78_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t TweenExtensions_Restart_mDC073CE9213DFB2B09E48802B85A4A05FC9638A6_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t TweenExtensions_Rewind_mC401886E7657C9525C13771792B4B7A4684C757C_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t TweenExtensions_TogglePause_mB413085220461740827A9B6515D71FFEFCF803CB_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t TweenSettingsExtensions_SetOptions_mF5B0D3F3B6EEC1C79D91E770D3F00709C9931230_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t TweenSettingsExtensions_SetPathForwardDirection_m7EA9A97A77D0EBB7542134E0D8224E06D5A56714_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t Tween_OnTweenCallback_m31509BCFB6D15BB7765CF28E7B6E0738DC88B659_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t U3CU3Ec__DisplayClass12c_U3CDOBlendableRotateByU3Eb__12b_mF5F53747ACC7AC46FA1DB317F56B0FB85674812A_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t U3CU3Ec__DisplayClassda_U3CDOPunchRotationU3Eb__d9_m568D23843369C037DF422F366359694019CABEF9_MetadataUsageId;
IL2CPP_EXTERN_C const uint32_t U3CU3Ec__DisplayClassea_U3CDOShakeRotationU3Eb__e9_m303D35A7DDE735D3DBF19EA66C5B73396306C4E1_MetadataUsageId;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;

struct CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2;
struct DelegateU5BU5D_tDFCDEE2A6322F96C0FE49AF47E9ADB8C4B294E86;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Object


// DG.Tweening.Core.Debugger
struct  Debugger_tD9D47C252FB20009C8276590D54394E430619D16  : public RuntimeObject
{
public:

public:
};

struct Debugger_tD9D47C252FB20009C8276590D54394E430619D16_StaticFields
{
public:
	// System.Int32 DG.Tweening.Core.Debugger::logPriority
	int32_t ___logPriority_0;

public:
	inline static int32_t get_offset_of_logPriority_0() { return static_cast<int32_t>(offsetof(Debugger_tD9D47C252FB20009C8276590D54394E430619D16_StaticFields, ___logPriority_0)); }
	inline int32_t get_logPriority_0() const { return ___logPriority_0; }
	inline int32_t* get_address_of_logPriority_0() { return &___logPriority_0; }
	inline void set_logPriority_0(int32_t value)
	{
		___logPriority_0 = value;
	}
};


// DG.Tweening.Core.TweenManager
struct  TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386  : public RuntimeObject
{
public:

public:
};

struct TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_StaticFields
{
public:
	// System.Int32 DG.Tweening.Core.TweenManager::maxActive
	int32_t ___maxActive_0;
	// System.Int32 DG.Tweening.Core.TweenManager::maxTweeners
	int32_t ___maxTweeners_1;
	// System.Int32 DG.Tweening.Core.TweenManager::maxSequences
	int32_t ___maxSequences_2;
	// System.Boolean DG.Tweening.Core.TweenManager::hasActiveTweens
	bool ___hasActiveTweens_3;
	// System.Boolean DG.Tweening.Core.TweenManager::hasActiveDefaultTweens
	bool ___hasActiveDefaultTweens_4;
	// System.Boolean DG.Tweening.Core.TweenManager::hasActiveLateTweens
	bool ___hasActiveLateTweens_5;
	// System.Boolean DG.Tweening.Core.TweenManager::hasActiveFixedTweens
	bool ___hasActiveFixedTweens_6;
	// System.Int32 DG.Tweening.Core.TweenManager::totActiveTweens
	int32_t ___totActiveTweens_7;
	// System.Int32 DG.Tweening.Core.TweenManager::totActiveDefaultTweens
	int32_t ___totActiveDefaultTweens_8;
	// System.Int32 DG.Tweening.Core.TweenManager::totActiveLateTweens
	int32_t ___totActiveLateTweens_9;
	// System.Int32 DG.Tweening.Core.TweenManager::totActiveFixedTweens
	int32_t ___totActiveFixedTweens_10;
	// System.Int32 DG.Tweening.Core.TweenManager::totActiveTweeners
	int32_t ___totActiveTweeners_11;
	// System.Int32 DG.Tweening.Core.TweenManager::totActiveSequences
	int32_t ___totActiveSequences_12;
	// System.Int32 DG.Tweening.Core.TweenManager::totPooledTweeners
	int32_t ___totPooledTweeners_13;
	// System.Int32 DG.Tweening.Core.TweenManager::totPooledSequences
	int32_t ___totPooledSequences_14;
	// System.Int32 DG.Tweening.Core.TweenManager::totTweeners
	int32_t ___totTweeners_15;
	// System.Int32 DG.Tweening.Core.TweenManager::totSequences
	int32_t ___totSequences_16;
	// System.Boolean DG.Tweening.Core.TweenManager::isUpdateLoop
	bool ___isUpdateLoop_17;
	// DG.Tweening.Tween[] DG.Tweening.Core.TweenManager::_activeTweens
	TweenU5BU5D_t59E878639D2690DEB50DB29D6D3871EB68312DD5* ____activeTweens_18;
	// DG.Tweening.Tween[] DG.Tweening.Core.TweenManager::_pooledTweeners
	TweenU5BU5D_t59E878639D2690DEB50DB29D6D3871EB68312DD5* ____pooledTweeners_19;
	// System.Collections.Generic.Stack`1<DG.Tweening.Tween> DG.Tweening.Core.TweenManager::_PooledSequences
	Stack_1_t6CA58A0BB4B4756170E9E83B26CD1DDE07AFA198 * ____PooledSequences_20;
	// System.Collections.Generic.List`1<DG.Tweening.Tween> DG.Tweening.Core.TweenManager::_KillList
	List_1_t57BB69F1AC3759152D9E750F6120000328D367B8 * ____KillList_21;
	// System.Int32 DG.Tweening.Core.TweenManager::_maxActiveLookupId
	int32_t ____maxActiveLookupId_22;
	// System.Boolean DG.Tweening.Core.TweenManager::_requiresActiveReorganization
	bool ____requiresActiveReorganization_23;
	// System.Int32 DG.Tweening.Core.TweenManager::_reorganizeFromId
	int32_t ____reorganizeFromId_24;
	// System.Int32 DG.Tweening.Core.TweenManager::_minPooledTweenerId
	int32_t ____minPooledTweenerId_25;
	// System.Int32 DG.Tweening.Core.TweenManager::_maxPooledTweenerId
	int32_t ____maxPooledTweenerId_26;

public:
	inline static int32_t get_offset_of_maxActive_0() { return static_cast<int32_t>(offsetof(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_StaticFields, ___maxActive_0)); }
	inline int32_t get_maxActive_0() const { return ___maxActive_0; }
	inline int32_t* get_address_of_maxActive_0() { return &___maxActive_0; }
	inline void set_maxActive_0(int32_t value)
	{
		___maxActive_0 = value;
	}

	inline static int32_t get_offset_of_maxTweeners_1() { return static_cast<int32_t>(offsetof(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_StaticFields, ___maxTweeners_1)); }
	inline int32_t get_maxTweeners_1() const { return ___maxTweeners_1; }
	inline int32_t* get_address_of_maxTweeners_1() { return &___maxTweeners_1; }
	inline void set_maxTweeners_1(int32_t value)
	{
		___maxTweeners_1 = value;
	}

	inline static int32_t get_offset_of_maxSequences_2() { return static_cast<int32_t>(offsetof(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_StaticFields, ___maxSequences_2)); }
	inline int32_t get_maxSequences_2() const { return ___maxSequences_2; }
	inline int32_t* get_address_of_maxSequences_2() { return &___maxSequences_2; }
	inline void set_maxSequences_2(int32_t value)
	{
		___maxSequences_2 = value;
	}

	inline static int32_t get_offset_of_hasActiveTweens_3() { return static_cast<int32_t>(offsetof(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_StaticFields, ___hasActiveTweens_3)); }
	inline bool get_hasActiveTweens_3() const { return ___hasActiveTweens_3; }
	inline bool* get_address_of_hasActiveTweens_3() { return &___hasActiveTweens_3; }
	inline void set_hasActiveTweens_3(bool value)
	{
		___hasActiveTweens_3 = value;
	}

	inline static int32_t get_offset_of_hasActiveDefaultTweens_4() { return static_cast<int32_t>(offsetof(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_StaticFields, ___hasActiveDefaultTweens_4)); }
	inline bool get_hasActiveDefaultTweens_4() const { return ___hasActiveDefaultTweens_4; }
	inline bool* get_address_of_hasActiveDefaultTweens_4() { return &___hasActiveDefaultTweens_4; }
	inline void set_hasActiveDefaultTweens_4(bool value)
	{
		___hasActiveDefaultTweens_4 = value;
	}

	inline static int32_t get_offset_of_hasActiveLateTweens_5() { return static_cast<int32_t>(offsetof(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_StaticFields, ___hasActiveLateTweens_5)); }
	inline bool get_hasActiveLateTweens_5() const { return ___hasActiveLateTweens_5; }
	inline bool* get_address_of_hasActiveLateTweens_5() { return &___hasActiveLateTweens_5; }
	inline void set_hasActiveLateTweens_5(bool value)
	{
		___hasActiveLateTweens_5 = value;
	}

	inline static int32_t get_offset_of_hasActiveFixedTweens_6() { return static_cast<int32_t>(offsetof(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_StaticFields, ___hasActiveFixedTweens_6)); }
	inline bool get_hasActiveFixedTweens_6() const { return ___hasActiveFixedTweens_6; }
	inline bool* get_address_of_hasActiveFixedTweens_6() { return &___hasActiveFixedTweens_6; }
	inline void set_hasActiveFixedTweens_6(bool value)
	{
		___hasActiveFixedTweens_6 = value;
	}

	inline static int32_t get_offset_of_totActiveTweens_7() { return static_cast<int32_t>(offsetof(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_StaticFields, ___totActiveTweens_7)); }
	inline int32_t get_totActiveTweens_7() const { return ___totActiveTweens_7; }
	inline int32_t* get_address_of_totActiveTweens_7() { return &___totActiveTweens_7; }
	inline void set_totActiveTweens_7(int32_t value)
	{
		___totActiveTweens_7 = value;
	}

	inline static int32_t get_offset_of_totActiveDefaultTweens_8() { return static_cast<int32_t>(offsetof(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_StaticFields, ___totActiveDefaultTweens_8)); }
	inline int32_t get_totActiveDefaultTweens_8() const { return ___totActiveDefaultTweens_8; }
	inline int32_t* get_address_of_totActiveDefaultTweens_8() { return &___totActiveDefaultTweens_8; }
	inline void set_totActiveDefaultTweens_8(int32_t value)
	{
		___totActiveDefaultTweens_8 = value;
	}

	inline static int32_t get_offset_of_totActiveLateTweens_9() { return static_cast<int32_t>(offsetof(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_StaticFields, ___totActiveLateTweens_9)); }
	inline int32_t get_totActiveLateTweens_9() const { return ___totActiveLateTweens_9; }
	inline int32_t* get_address_of_totActiveLateTweens_9() { return &___totActiveLateTweens_9; }
	inline void set_totActiveLateTweens_9(int32_t value)
	{
		___totActiveLateTweens_9 = value;
	}

	inline static int32_t get_offset_of_totActiveFixedTweens_10() { return static_cast<int32_t>(offsetof(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_StaticFields, ___totActiveFixedTweens_10)); }
	inline int32_t get_totActiveFixedTweens_10() const { return ___totActiveFixedTweens_10; }
	inline int32_t* get_address_of_totActiveFixedTweens_10() { return &___totActiveFixedTweens_10; }
	inline void set_totActiveFixedTweens_10(int32_t value)
	{
		___totActiveFixedTweens_10 = value;
	}

	inline static int32_t get_offset_of_totActiveTweeners_11() { return static_cast<int32_t>(offsetof(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_StaticFields, ___totActiveTweeners_11)); }
	inline int32_t get_totActiveTweeners_11() const { return ___totActiveTweeners_11; }
	inline int32_t* get_address_of_totActiveTweeners_11() { return &___totActiveTweeners_11; }
	inline void set_totActiveTweeners_11(int32_t value)
	{
		___totActiveTweeners_11 = value;
	}

	inline static int32_t get_offset_of_totActiveSequences_12() { return static_cast<int32_t>(offsetof(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_StaticFields, ___totActiveSequences_12)); }
	inline int32_t get_totActiveSequences_12() const { return ___totActiveSequences_12; }
	inline int32_t* get_address_of_totActiveSequences_12() { return &___totActiveSequences_12; }
	inline void set_totActiveSequences_12(int32_t value)
	{
		___totActiveSequences_12 = value;
	}

	inline static int32_t get_offset_of_totPooledTweeners_13() { return static_cast<int32_t>(offsetof(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_StaticFields, ___totPooledTweeners_13)); }
	inline int32_t get_totPooledTweeners_13() const { return ___totPooledTweeners_13; }
	inline int32_t* get_address_of_totPooledTweeners_13() { return &___totPooledTweeners_13; }
	inline void set_totPooledTweeners_13(int32_t value)
	{
		___totPooledTweeners_13 = value;
	}

	inline static int32_t get_offset_of_totPooledSequences_14() { return static_cast<int32_t>(offsetof(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_StaticFields, ___totPooledSequences_14)); }
	inline int32_t get_totPooledSequences_14() const { return ___totPooledSequences_14; }
	inline int32_t* get_address_of_totPooledSequences_14() { return &___totPooledSequences_14; }
	inline void set_totPooledSequences_14(int32_t value)
	{
		___totPooledSequences_14 = value;
	}

	inline static int32_t get_offset_of_totTweeners_15() { return static_cast<int32_t>(offsetof(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_StaticFields, ___totTweeners_15)); }
	inline int32_t get_totTweeners_15() const { return ___totTweeners_15; }
	inline int32_t* get_address_of_totTweeners_15() { return &___totTweeners_15; }
	inline void set_totTweeners_15(int32_t value)
	{
		___totTweeners_15 = value;
	}

	inline static int32_t get_offset_of_totSequences_16() { return static_cast<int32_t>(offsetof(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_StaticFields, ___totSequences_16)); }
	inline int32_t get_totSequences_16() const { return ___totSequences_16; }
	inline int32_t* get_address_of_totSequences_16() { return &___totSequences_16; }
	inline void set_totSequences_16(int32_t value)
	{
		___totSequences_16 = value;
	}

	inline static int32_t get_offset_of_isUpdateLoop_17() { return static_cast<int32_t>(offsetof(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_StaticFields, ___isUpdateLoop_17)); }
	inline bool get_isUpdateLoop_17() const { return ___isUpdateLoop_17; }
	inline bool* get_address_of_isUpdateLoop_17() { return &___isUpdateLoop_17; }
	inline void set_isUpdateLoop_17(bool value)
	{
		___isUpdateLoop_17 = value;
	}

	inline static int32_t get_offset_of__activeTweens_18() { return static_cast<int32_t>(offsetof(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_StaticFields, ____activeTweens_18)); }
	inline TweenU5BU5D_t59E878639D2690DEB50DB29D6D3871EB68312DD5* get__activeTweens_18() const { return ____activeTweens_18; }
	inline TweenU5BU5D_t59E878639D2690DEB50DB29D6D3871EB68312DD5** get_address_of__activeTweens_18() { return &____activeTweens_18; }
	inline void set__activeTweens_18(TweenU5BU5D_t59E878639D2690DEB50DB29D6D3871EB68312DD5* value)
	{
		____activeTweens_18 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____activeTweens_18), (void*)value);
	}

	inline static int32_t get_offset_of__pooledTweeners_19() { return static_cast<int32_t>(offsetof(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_StaticFields, ____pooledTweeners_19)); }
	inline TweenU5BU5D_t59E878639D2690DEB50DB29D6D3871EB68312DD5* get__pooledTweeners_19() const { return ____pooledTweeners_19; }
	inline TweenU5BU5D_t59E878639D2690DEB50DB29D6D3871EB68312DD5** get_address_of__pooledTweeners_19() { return &____pooledTweeners_19; }
	inline void set__pooledTweeners_19(TweenU5BU5D_t59E878639D2690DEB50DB29D6D3871EB68312DD5* value)
	{
		____pooledTweeners_19 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____pooledTweeners_19), (void*)value);
	}

	inline static int32_t get_offset_of__PooledSequences_20() { return static_cast<int32_t>(offsetof(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_StaticFields, ____PooledSequences_20)); }
	inline Stack_1_t6CA58A0BB4B4756170E9E83B26CD1DDE07AFA198 * get__PooledSequences_20() const { return ____PooledSequences_20; }
	inline Stack_1_t6CA58A0BB4B4756170E9E83B26CD1DDE07AFA198 ** get_address_of__PooledSequences_20() { return &____PooledSequences_20; }
	inline void set__PooledSequences_20(Stack_1_t6CA58A0BB4B4756170E9E83B26CD1DDE07AFA198 * value)
	{
		____PooledSequences_20 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____PooledSequences_20), (void*)value);
	}

	inline static int32_t get_offset_of__KillList_21() { return static_cast<int32_t>(offsetof(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_StaticFields, ____KillList_21)); }
	inline List_1_t57BB69F1AC3759152D9E750F6120000328D367B8 * get__KillList_21() const { return ____KillList_21; }
	inline List_1_t57BB69F1AC3759152D9E750F6120000328D367B8 ** get_address_of__KillList_21() { return &____KillList_21; }
	inline void set__KillList_21(List_1_t57BB69F1AC3759152D9E750F6120000328D367B8 * value)
	{
		____KillList_21 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____KillList_21), (void*)value);
	}

	inline static int32_t get_offset_of__maxActiveLookupId_22() { return static_cast<int32_t>(offsetof(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_StaticFields, ____maxActiveLookupId_22)); }
	inline int32_t get__maxActiveLookupId_22() const { return ____maxActiveLookupId_22; }
	inline int32_t* get_address_of__maxActiveLookupId_22() { return &____maxActiveLookupId_22; }
	inline void set__maxActiveLookupId_22(int32_t value)
	{
		____maxActiveLookupId_22 = value;
	}

	inline static int32_t get_offset_of__requiresActiveReorganization_23() { return static_cast<int32_t>(offsetof(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_StaticFields, ____requiresActiveReorganization_23)); }
	inline bool get__requiresActiveReorganization_23() const { return ____requiresActiveReorganization_23; }
	inline bool* get_address_of__requiresActiveReorganization_23() { return &____requiresActiveReorganization_23; }
	inline void set__requiresActiveReorganization_23(bool value)
	{
		____requiresActiveReorganization_23 = value;
	}

	inline static int32_t get_offset_of__reorganizeFromId_24() { return static_cast<int32_t>(offsetof(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_StaticFields, ____reorganizeFromId_24)); }
	inline int32_t get__reorganizeFromId_24() const { return ____reorganizeFromId_24; }
	inline int32_t* get_address_of__reorganizeFromId_24() { return &____reorganizeFromId_24; }
	inline void set__reorganizeFromId_24(int32_t value)
	{
		____reorganizeFromId_24 = value;
	}

	inline static int32_t get_offset_of__minPooledTweenerId_25() { return static_cast<int32_t>(offsetof(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_StaticFields, ____minPooledTweenerId_25)); }
	inline int32_t get__minPooledTweenerId_25() const { return ____minPooledTweenerId_25; }
	inline int32_t* get_address_of__minPooledTweenerId_25() { return &____minPooledTweenerId_25; }
	inline void set__minPooledTweenerId_25(int32_t value)
	{
		____minPooledTweenerId_25 = value;
	}

	inline static int32_t get_offset_of__maxPooledTweenerId_26() { return static_cast<int32_t>(offsetof(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_StaticFields, ____maxPooledTweenerId_26)); }
	inline int32_t get__maxPooledTweenerId_26() const { return ____maxPooledTweenerId_26; }
	inline int32_t* get_address_of__maxPooledTweenerId_26() { return &____maxPooledTweenerId_26; }
	inline void set__maxPooledTweenerId_26(int32_t value)
	{
		____maxPooledTweenerId_26 = value;
	}
};


// DG.Tweening.ShortcutExtensions_<>c__DisplayClass110
struct  U3CU3Ec__DisplayClass110_t721552CB7F431CCC670721B6011F9EE1C26EDADE  : public RuntimeObject
{
public:
	// UnityEngine.Transform DG.Tweening.ShortcutExtensions_<>c__DisplayClass110::target
	Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * ___target_0;

public:
	inline static int32_t get_offset_of_target_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass110_t721552CB7F431CCC670721B6011F9EE1C26EDADE, ___target_0)); }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * get_target_0() const { return ___target_0; }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA ** get_address_of_target_0() { return &___target_0; }
	inline void set_target_0(Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * value)
	{
		___target_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_0), (void*)value);
	}
};


// DG.Tweening.ShortcutExtensions_<>c__DisplayClass114
struct  U3CU3Ec__DisplayClass114_t1485A600A38FE289BB342ABE9B33E75FDFF2700B  : public RuntimeObject
{
public:
	// UnityEngine.Transform DG.Tweening.ShortcutExtensions_<>c__DisplayClass114::target
	Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * ___target_0;

public:
	inline static int32_t get_offset_of_target_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass114_t1485A600A38FE289BB342ABE9B33E75FDFF2700B, ___target_0)); }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * get_target_0() const { return ___target_0; }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA ** get_address_of_target_0() { return &___target_0; }
	inline void set_target_0(Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * value)
	{
		___target_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_0), (void*)value);
	}
};


// DG.Tweening.ShortcutExtensions_<>c__DisplayClass16
struct  U3CU3Ec__DisplayClass16_t4E802A0F0A82726640C245784AF8DCB4EF296CD0  : public RuntimeObject
{
public:
	// UnityEngine.Camera DG.Tweening.ShortcutExtensions_<>c__DisplayClass16::target
	Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * ___target_0;

public:
	inline static int32_t get_offset_of_target_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass16_t4E802A0F0A82726640C245784AF8DCB4EF296CD0, ___target_0)); }
	inline Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * get_target_0() const { return ___target_0; }
	inline Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 ** get_address_of_target_0() { return &___target_0; }
	inline void set_target_0(Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * value)
	{
		___target_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_0), (void*)value);
	}
};


// DG.Tweening.ShortcutExtensions_<>c__DisplayClass1e
struct  U3CU3Ec__DisplayClass1e_tF8B7419EC65C518E507CBB88232CB4C8EB0D2F2D  : public RuntimeObject
{
public:
	// UnityEngine.Camera DG.Tweening.ShortcutExtensions_<>c__DisplayClass1e::target
	Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * ___target_0;

public:
	inline static int32_t get_offset_of_target_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass1e_tF8B7419EC65C518E507CBB88232CB4C8EB0D2F2D, ___target_0)); }
	inline Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * get_target_0() const { return ___target_0; }
	inline Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 ** get_address_of_target_0() { return &___target_0; }
	inline void set_target_0(Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * value)
	{
		___target_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_0), (void*)value);
	}
};


// DG.Tweening.ShortcutExtensions_<>c__DisplayClass22
struct  U3CU3Ec__DisplayClass22_t9D675687ADAAE6B97900F09FA258BAD293F0169B  : public RuntimeObject
{
public:
	// UnityEngine.Camera DG.Tweening.ShortcutExtensions_<>c__DisplayClass22::target
	Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * ___target_0;

public:
	inline static int32_t get_offset_of_target_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass22_t9D675687ADAAE6B97900F09FA258BAD293F0169B, ___target_0)); }
	inline Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * get_target_0() const { return ___target_0; }
	inline Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 ** get_address_of_target_0() { return &___target_0; }
	inline void set_target_0(Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * value)
	{
		___target_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_0), (void*)value);
	}
};


// DG.Tweening.ShortcutExtensions_<>c__DisplayClass26
struct  U3CU3Ec__DisplayClass26_tE9EF7F8D0A615A1A5C05FC64480ED086DB8BAECB  : public RuntimeObject
{
public:
	// UnityEngine.Camera DG.Tweening.ShortcutExtensions_<>c__DisplayClass26::target
	Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * ___target_0;

public:
	inline static int32_t get_offset_of_target_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass26_tE9EF7F8D0A615A1A5C05FC64480ED086DB8BAECB, ___target_0)); }
	inline Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * get_target_0() const { return ___target_0; }
	inline Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 ** get_address_of_target_0() { return &___target_0; }
	inline void set_target_0(Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * value)
	{
		___target_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_0), (void*)value);
	}
};


// DG.Tweening.ShortcutExtensions_<>c__DisplayClass2a
struct  U3CU3Ec__DisplayClass2a_t830E1745D71495189F605D0C0FB47F62DC405163  : public RuntimeObject
{
public:
	// UnityEngine.Camera DG.Tweening.ShortcutExtensions_<>c__DisplayClass2a::target
	Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * ___target_0;

public:
	inline static int32_t get_offset_of_target_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass2a_t830E1745D71495189F605D0C0FB47F62DC405163, ___target_0)); }
	inline Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * get_target_0() const { return ___target_0; }
	inline Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 ** get_address_of_target_0() { return &___target_0; }
	inline void set_target_0(Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * value)
	{
		___target_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_0), (void*)value);
	}
};


// DG.Tweening.ShortcutExtensions_<>c__DisplayClass4a
struct  U3CU3Ec__DisplayClass4a_t8BA738A82F498990CA8964AD18CF9EBE36997E56  : public RuntimeObject
{
public:
	// UnityEngine.Material DG.Tweening.ShortcutExtensions_<>c__DisplayClass4a::target
	Material_tF7DB3BF0C24DEC2FE0CB51E5DF5053D5223C8598 * ___target_0;

public:
	inline static int32_t get_offset_of_target_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass4a_t8BA738A82F498990CA8964AD18CF9EBE36997E56, ___target_0)); }
	inline Material_tF7DB3BF0C24DEC2FE0CB51E5DF5053D5223C8598 * get_target_0() const { return ___target_0; }
	inline Material_tF7DB3BF0C24DEC2FE0CB51E5DF5053D5223C8598 ** get_address_of_target_0() { return &___target_0; }
	inline void set_target_0(Material_tF7DB3BF0C24DEC2FE0CB51E5DF5053D5223C8598 * value)
	{
		___target_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_0), (void*)value);
	}
};


// DG.Tweening.ShortcutExtensions_<>c__DisplayClass52
struct  U3CU3Ec__DisplayClass52_tAE0AB9391667396DE92813351A9D9EF7129466F9  : public RuntimeObject
{
public:
	// UnityEngine.Material DG.Tweening.ShortcutExtensions_<>c__DisplayClass52::target
	Material_tF7DB3BF0C24DEC2FE0CB51E5DF5053D5223C8598 * ___target_0;

public:
	inline static int32_t get_offset_of_target_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass52_tAE0AB9391667396DE92813351A9D9EF7129466F9, ___target_0)); }
	inline Material_tF7DB3BF0C24DEC2FE0CB51E5DF5053D5223C8598 * get_target_0() const { return ___target_0; }
	inline Material_tF7DB3BF0C24DEC2FE0CB51E5DF5053D5223C8598 ** get_address_of_target_0() { return &___target_0; }
	inline void set_target_0(Material_tF7DB3BF0C24DEC2FE0CB51E5DF5053D5223C8598 * value)
	{
		___target_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_0), (void*)value);
	}
};


// DG.Tweening.ShortcutExtensions_<>c__DisplayClass71
struct  U3CU3Ec__DisplayClass71_t08F78102E6BDF49AD78C3D6604C3E5357F334C3D  : public RuntimeObject
{
public:
	// UnityEngine.Rigidbody DG.Tweening.ShortcutExtensions_<>c__DisplayClass71::target
	Rigidbody_tE0A58EE5A1F7DC908EFFB4F0D795AC9552A750A5 * ___target_0;

public:
	inline static int32_t get_offset_of_target_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass71_t08F78102E6BDF49AD78C3D6604C3E5357F334C3D, ___target_0)); }
	inline Rigidbody_tE0A58EE5A1F7DC908EFFB4F0D795AC9552A750A5 * get_target_0() const { return ___target_0; }
	inline Rigidbody_tE0A58EE5A1F7DC908EFFB4F0D795AC9552A750A5 ** get_address_of_target_0() { return &___target_0; }
	inline void set_target_0(Rigidbody_tE0A58EE5A1F7DC908EFFB4F0D795AC9552A750A5 * value)
	{
		___target_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_0), (void*)value);
	}
};


// DG.Tweening.ShortcutExtensions_<>c__DisplayClass7d
struct  U3CU3Ec__DisplayClass7d_tAF739539C02E5E3135C7304E0236701AB93FC5C0  : public RuntimeObject
{
public:
	// UnityEngine.Rigidbody DG.Tweening.ShortcutExtensions_<>c__DisplayClass7d::target
	Rigidbody_tE0A58EE5A1F7DC908EFFB4F0D795AC9552A750A5 * ___target_0;

public:
	inline static int32_t get_offset_of_target_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass7d_tAF739539C02E5E3135C7304E0236701AB93FC5C0, ___target_0)); }
	inline Rigidbody_tE0A58EE5A1F7DC908EFFB4F0D795AC9552A750A5 * get_target_0() const { return ___target_0; }
	inline Rigidbody_tE0A58EE5A1F7DC908EFFB4F0D795AC9552A750A5 ** get_address_of_target_0() { return &___target_0; }
	inline void set_target_0(Rigidbody_tE0A58EE5A1F7DC908EFFB4F0D795AC9552A750A5 * value)
	{
		___target_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_0), (void*)value);
	}
};


// DG.Tweening.ShortcutExtensions_<>c__DisplayClass92
struct  U3CU3Ec__DisplayClass92_tA75A43DD789C96E30D590D2F545C94EC69589DA6  : public RuntimeObject
{
public:
	// UnityEngine.Transform DG.Tweening.ShortcutExtensions_<>c__DisplayClass92::target
	Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * ___target_0;

public:
	inline static int32_t get_offset_of_target_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass92_tA75A43DD789C96E30D590D2F545C94EC69589DA6, ___target_0)); }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * get_target_0() const { return ___target_0; }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA ** get_address_of_target_0() { return &___target_0; }
	inline void set_target_0(Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * value)
	{
		___target_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_0), (void*)value);
	}
};


// DG.Tweening.ShortcutExtensions_<>c__DisplayClass96
struct  U3CU3Ec__DisplayClass96_t5EC6E6D72824408D93A7F57ECAF35DB96FCD6D67  : public RuntimeObject
{
public:
	// UnityEngine.Transform DG.Tweening.ShortcutExtensions_<>c__DisplayClass96::target
	Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * ___target_0;

public:
	inline static int32_t get_offset_of_target_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass96_t5EC6E6D72824408D93A7F57ECAF35DB96FCD6D67, ___target_0)); }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * get_target_0() const { return ___target_0; }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA ** get_address_of_target_0() { return &___target_0; }
	inline void set_target_0(Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * value)
	{
		___target_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_0), (void*)value);
	}
};


// DG.Tweening.ShortcutExtensions_<>c__DisplayClassa
struct  U3CU3Ec__DisplayClassa_tC915AA461E4FD5AE3D48A51D677710E64F437E96  : public RuntimeObject
{
public:
	// UnityEngine.Camera DG.Tweening.ShortcutExtensions_<>c__DisplayClassa::target
	Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * ___target_0;

public:
	inline static int32_t get_offset_of_target_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClassa_tC915AA461E4FD5AE3D48A51D677710E64F437E96, ___target_0)); }
	inline Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * get_target_0() const { return ___target_0; }
	inline Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 ** get_address_of_target_0() { return &___target_0; }
	inline void set_target_0(Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * value)
	{
		___target_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_0), (void*)value);
	}
};


// DG.Tweening.ShortcutExtensions_<>c__DisplayClassa2
struct  U3CU3Ec__DisplayClassa2_t9AD84E358FF7A7DFD16DC2C4CDED2462E72C4C8E  : public RuntimeObject
{
public:
	// UnityEngine.Transform DG.Tweening.ShortcutExtensions_<>c__DisplayClassa2::target
	Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * ___target_0;

public:
	inline static int32_t get_offset_of_target_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClassa2_t9AD84E358FF7A7DFD16DC2C4CDED2462E72C4C8E, ___target_0)); }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * get_target_0() const { return ___target_0; }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA ** get_address_of_target_0() { return &___target_0; }
	inline void set_target_0(Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * value)
	{
		___target_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_0), (void*)value);
	}
};


// DG.Tweening.ShortcutExtensions_<>c__DisplayClassb2
struct  U3CU3Ec__DisplayClassb2_tDE677984DFFECB80EF616D9A6D4D2075C35028E6  : public RuntimeObject
{
public:
	// UnityEngine.Transform DG.Tweening.ShortcutExtensions_<>c__DisplayClassb2::target
	Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * ___target_0;

public:
	inline static int32_t get_offset_of_target_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClassb2_tDE677984DFFECB80EF616D9A6D4D2075C35028E6, ___target_0)); }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * get_target_0() const { return ___target_0; }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA ** get_address_of_target_0() { return &___target_0; }
	inline void set_target_0(Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * value)
	{
		___target_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_0), (void*)value);
	}
};


// DG.Tweening.ShortcutExtensions_<>c__DisplayClassb6
struct  U3CU3Ec__DisplayClassb6_t2BFB12249855A8FE2A74C4B29DDA349C49573ED2  : public RuntimeObject
{
public:
	// UnityEngine.Transform DG.Tweening.ShortcutExtensions_<>c__DisplayClassb6::target
	Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * ___target_0;

public:
	inline static int32_t get_offset_of_target_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClassb6_t2BFB12249855A8FE2A74C4B29DDA349C49573ED2, ___target_0)); }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * get_target_0() const { return ___target_0; }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA ** get_address_of_target_0() { return &___target_0; }
	inline void set_target_0(Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * value)
	{
		___target_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_0), (void*)value);
	}
};


// DG.Tweening.ShortcutExtensions_<>c__DisplayClassba
struct  U3CU3Ec__DisplayClassba_t0A65EB02F44732F72DA15E4767826F7318A5558E  : public RuntimeObject
{
public:
	// UnityEngine.Transform DG.Tweening.ShortcutExtensions_<>c__DisplayClassba::target
	Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * ___target_0;

public:
	inline static int32_t get_offset_of_target_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClassba_t0A65EB02F44732F72DA15E4767826F7318A5558E, ___target_0)); }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * get_target_0() const { return ___target_0; }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA ** get_address_of_target_0() { return &___target_0; }
	inline void set_target_0(Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * value)
	{
		___target_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_0), (void*)value);
	}
};


// DG.Tweening.ShortcutExtensions_<>c__DisplayClassbe
struct  U3CU3Ec__DisplayClassbe_t1186133747C674242AF1F941435C43C73D9B2CD2  : public RuntimeObject
{
public:
	// UnityEngine.Transform DG.Tweening.ShortcutExtensions_<>c__DisplayClassbe::target
	Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * ___target_0;

public:
	inline static int32_t get_offset_of_target_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClassbe_t1186133747C674242AF1F941435C43C73D9B2CD2, ___target_0)); }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * get_target_0() const { return ___target_0; }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA ** get_address_of_target_0() { return &___target_0; }
	inline void set_target_0(Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * value)
	{
		___target_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_0), (void*)value);
	}
};


// DG.Tweening.ShortcutExtensions_<>c__DisplayClassd2
struct  U3CU3Ec__DisplayClassd2_t2E49EDC8ED935AAE089A256C17B0F4810A868E1E  : public RuntimeObject
{
public:
	// UnityEngine.Transform DG.Tweening.ShortcutExtensions_<>c__DisplayClassd2::target
	Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * ___target_0;

public:
	inline static int32_t get_offset_of_target_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClassd2_t2E49EDC8ED935AAE089A256C17B0F4810A868E1E, ___target_0)); }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * get_target_0() const { return ___target_0; }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA ** get_address_of_target_0() { return &___target_0; }
	inline void set_target_0(Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * value)
	{
		___target_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_0), (void*)value);
	}
};


// DG.Tweening.ShortcutExtensions_<>c__DisplayClassd6
struct  U3CU3Ec__DisplayClassd6_tDD8BC433E9E2A0F72AC9DEDA1BC64AFFBEA6DC1A  : public RuntimeObject
{
public:
	// UnityEngine.Transform DG.Tweening.ShortcutExtensions_<>c__DisplayClassd6::target
	Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * ___target_0;

public:
	inline static int32_t get_offset_of_target_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClassd6_tDD8BC433E9E2A0F72AC9DEDA1BC64AFFBEA6DC1A, ___target_0)); }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * get_target_0() const { return ___target_0; }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA ** get_address_of_target_0() { return &___target_0; }
	inline void set_target_0(Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * value)
	{
		___target_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_0), (void*)value);
	}
};


// DG.Tweening.ShortcutExtensions_<>c__DisplayClassda
struct  U3CU3Ec__DisplayClassda_t1B3A1757D73FF007687F7F4EFC16AD0000C405C0  : public RuntimeObject
{
public:
	// UnityEngine.Transform DG.Tweening.ShortcutExtensions_<>c__DisplayClassda::target
	Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * ___target_0;

public:
	inline static int32_t get_offset_of_target_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClassda_t1B3A1757D73FF007687F7F4EFC16AD0000C405C0, ___target_0)); }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * get_target_0() const { return ___target_0; }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA ** get_address_of_target_0() { return &___target_0; }
	inline void set_target_0(Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * value)
	{
		___target_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_0), (void*)value);
	}
};


// DG.Tweening.ShortcutExtensions_<>c__DisplayClasse
struct  U3CU3Ec__DisplayClasse_tDC794AB97B18E7819CBEFA7BBA29B61CE76EBF6A  : public RuntimeObject
{
public:
	// UnityEngine.Camera DG.Tweening.ShortcutExtensions_<>c__DisplayClasse::target
	Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * ___target_0;

public:
	inline static int32_t get_offset_of_target_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClasse_tDC794AB97B18E7819CBEFA7BBA29B61CE76EBF6A, ___target_0)); }
	inline Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * get_target_0() const { return ___target_0; }
	inline Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 ** get_address_of_target_0() { return &___target_0; }
	inline void set_target_0(Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * value)
	{
		___target_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_0), (void*)value);
	}
};


// DG.Tweening.ShortcutExtensions_<>c__DisplayClasse2
struct  U3CU3Ec__DisplayClasse2_t7B9A4AEA17B3EBAD85BDAE3DE6094EC7B673379A  : public RuntimeObject
{
public:
	// UnityEngine.Transform DG.Tweening.ShortcutExtensions_<>c__DisplayClasse2::target
	Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * ___target_0;

public:
	inline static int32_t get_offset_of_target_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClasse2_t7B9A4AEA17B3EBAD85BDAE3DE6094EC7B673379A, ___target_0)); }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * get_target_0() const { return ___target_0; }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA ** get_address_of_target_0() { return &___target_0; }
	inline void set_target_0(Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * value)
	{
		___target_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_0), (void*)value);
	}
};


// DG.Tweening.ShortcutExtensions_<>c__DisplayClassea
struct  U3CU3Ec__DisplayClassea_t93D241F4C148181D28E9E5CA8159DBA36845D6E4  : public RuntimeObject
{
public:
	// UnityEngine.Transform DG.Tweening.ShortcutExtensions_<>c__DisplayClassea::target
	Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * ___target_0;

public:
	inline static int32_t get_offset_of_target_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClassea_t93D241F4C148181D28E9E5CA8159DBA36845D6E4, ___target_0)); }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * get_target_0() const { return ___target_0; }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA ** get_address_of_target_0() { return &___target_0; }
	inline void set_target_0(Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * value)
	{
		___target_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_0), (void*)value);
	}
};


// DG.Tweening.ShortcutExtensions_<>c__DisplayClassf2
struct  U3CU3Ec__DisplayClassf2_tADC804C6DFA12A25797C96316169554AE845E88F  : public RuntimeObject
{
public:
	// UnityEngine.Transform DG.Tweening.ShortcutExtensions_<>c__DisplayClassf2::target
	Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * ___target_0;

public:
	inline static int32_t get_offset_of_target_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClassf2_tADC804C6DFA12A25797C96316169554AE845E88F, ___target_0)); }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * get_target_0() const { return ___target_0; }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA ** get_address_of_target_0() { return &___target_0; }
	inline void set_target_0(Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * value)
	{
		___target_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_0), (void*)value);
	}
};


// DG.Tweening.TweenExtensions
struct  TweenExtensions_t78459AB2239BB3B0E4273A32381FAF97BF0B308D  : public RuntimeObject
{
public:

public:
};


// DG.Tweening.TweenSettingsExtensions
struct  TweenSettingsExtensions_t61A3DCA4F25E31E73F0104D8DE15B2D9AC78CCCA  : public RuntimeObject
{
public:

public:
};

struct Il2CppArrayBounds;

// System.Array


// System.String
struct  String_t  : public RuntimeObject
{
public:
	// System.Int32 System.String::m_stringLength
	int32_t ___m_stringLength_0;
	// System.Char System.String::m_firstChar
	Il2CppChar ___m_firstChar_1;

public:
	inline static int32_t get_offset_of_m_stringLength_0() { return static_cast<int32_t>(offsetof(String_t, ___m_stringLength_0)); }
	inline int32_t get_m_stringLength_0() const { return ___m_stringLength_0; }
	inline int32_t* get_address_of_m_stringLength_0() { return &___m_stringLength_0; }
	inline void set_m_stringLength_0(int32_t value)
	{
		___m_stringLength_0 = value;
	}

	inline static int32_t get_offset_of_m_firstChar_1() { return static_cast<int32_t>(offsetof(String_t, ___m_firstChar_1)); }
	inline Il2CppChar get_m_firstChar_1() const { return ___m_firstChar_1; }
	inline Il2CppChar* get_address_of_m_firstChar_1() { return &___m_firstChar_1; }
	inline void set_m_firstChar_1(Il2CppChar value)
	{
		___m_firstChar_1 = value;
	}
};

struct String_t_StaticFields
{
public:
	// System.String System.String::Empty
	String_t* ___Empty_5;

public:
	inline static int32_t get_offset_of_Empty_5() { return static_cast<int32_t>(offsetof(String_t_StaticFields, ___Empty_5)); }
	inline String_t* get_Empty_5() const { return ___Empty_5; }
	inline String_t** get_address_of_Empty_5() { return &___Empty_5; }
	inline void set_Empty_5(String_t* value)
	{
		___Empty_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Empty_5), (void*)value);
	}
};


// System.ValueType
struct  ValueType_t4D0C27076F7C36E76190FB3328E232BCB1CD1FFF  : public RuntimeObject
{
public:

public:
};

// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t4D0C27076F7C36E76190FB3328E232BCB1CD1FFF_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t4D0C27076F7C36E76190FB3328E232BCB1CD1FFF_marshaled_com
{
};

// DG.Tweening.Plugins.Options.ColorOptions
struct  ColorOptions_tD57E512D2F4329BEE7EAEE0D1B2C4A0683D288DA 
{
public:
	// System.Boolean DG.Tweening.Plugins.Options.ColorOptions::alphaOnly
	bool ___alphaOnly_0;

public:
	inline static int32_t get_offset_of_alphaOnly_0() { return static_cast<int32_t>(offsetof(ColorOptions_tD57E512D2F4329BEE7EAEE0D1B2C4A0683D288DA, ___alphaOnly_0)); }
	inline bool get_alphaOnly_0() const { return ___alphaOnly_0; }
	inline bool* get_address_of_alphaOnly_0() { return &___alphaOnly_0; }
	inline void set_alphaOnly_0(bool value)
	{
		___alphaOnly_0 = value;
	}
};

// Native definition for P/Invoke marshalling of DG.Tweening.Plugins.Options.ColorOptions
struct ColorOptions_tD57E512D2F4329BEE7EAEE0D1B2C4A0683D288DA_marshaled_pinvoke
{
	int32_t ___alphaOnly_0;
};
// Native definition for COM marshalling of DG.Tweening.Plugins.Options.ColorOptions
struct ColorOptions_tD57E512D2F4329BEE7EAEE0D1B2C4A0683D288DA_marshaled_com
{
	int32_t ___alphaOnly_0;
};

// System.Boolean
struct  Boolean_tB53F6830F670160873277339AA58F15CAED4399C 
{
public:
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Boolean_tB53F6830F670160873277339AA58F15CAED4399C, ___m_value_0)); }
	inline bool get_m_value_0() const { return ___m_value_0; }
	inline bool* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(bool value)
	{
		___m_value_0 = value;
	}
};

struct Boolean_tB53F6830F670160873277339AA58F15CAED4399C_StaticFields
{
public:
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;

public:
	inline static int32_t get_offset_of_TrueString_5() { return static_cast<int32_t>(offsetof(Boolean_tB53F6830F670160873277339AA58F15CAED4399C_StaticFields, ___TrueString_5)); }
	inline String_t* get_TrueString_5() const { return ___TrueString_5; }
	inline String_t** get_address_of_TrueString_5() { return &___TrueString_5; }
	inline void set_TrueString_5(String_t* value)
	{
		___TrueString_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___TrueString_5), (void*)value);
	}

	inline static int32_t get_offset_of_FalseString_6() { return static_cast<int32_t>(offsetof(Boolean_tB53F6830F670160873277339AA58F15CAED4399C_StaticFields, ___FalseString_6)); }
	inline String_t* get_FalseString_6() const { return ___FalseString_6; }
	inline String_t** get_address_of_FalseString_6() { return &___FalseString_6; }
	inline void set_FalseString_6(String_t* value)
	{
		___FalseString_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___FalseString_6), (void*)value);
	}
};


// System.Char
struct  Char_tBF22D9FC341BE970735250BB6FF1A4A92BBA58B9 
{
public:
	// System.Char System.Char::m_value
	Il2CppChar ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Char_tBF22D9FC341BE970735250BB6FF1A4A92BBA58B9, ___m_value_0)); }
	inline Il2CppChar get_m_value_0() const { return ___m_value_0; }
	inline Il2CppChar* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(Il2CppChar value)
	{
		___m_value_0 = value;
	}
};

struct Char_tBF22D9FC341BE970735250BB6FF1A4A92BBA58B9_StaticFields
{
public:
	// System.Byte[] System.Char::categoryForLatin1
	ByteU5BU5D_tD06FDBE8142446525DF1C40351D523A228373821* ___categoryForLatin1_3;

public:
	inline static int32_t get_offset_of_categoryForLatin1_3() { return static_cast<int32_t>(offsetof(Char_tBF22D9FC341BE970735250BB6FF1A4A92BBA58B9_StaticFields, ___categoryForLatin1_3)); }
	inline ByteU5BU5D_tD06FDBE8142446525DF1C40351D523A228373821* get_categoryForLatin1_3() const { return ___categoryForLatin1_3; }
	inline ByteU5BU5D_tD06FDBE8142446525DF1C40351D523A228373821** get_address_of_categoryForLatin1_3() { return &___categoryForLatin1_3; }
	inline void set_categoryForLatin1_3(ByteU5BU5D_tD06FDBE8142446525DF1C40351D523A228373821* value)
	{
		___categoryForLatin1_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___categoryForLatin1_3), (void*)value);
	}
};


// System.Enum
struct  Enum_t2AF27C02B8653AE29442467390005ABC74D8F521  : public ValueType_t4D0C27076F7C36E76190FB3328E232BCB1CD1FFF
{
public:

public:
};

struct Enum_t2AF27C02B8653AE29442467390005ABC74D8F521_StaticFields
{
public:
	// System.Char[] System.Enum::enumSeperatorCharArray
	CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* ___enumSeperatorCharArray_0;

public:
	inline static int32_t get_offset_of_enumSeperatorCharArray_0() { return static_cast<int32_t>(offsetof(Enum_t2AF27C02B8653AE29442467390005ABC74D8F521_StaticFields, ___enumSeperatorCharArray_0)); }
	inline CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* get_enumSeperatorCharArray_0() const { return ___enumSeperatorCharArray_0; }
	inline CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2** get_address_of_enumSeperatorCharArray_0() { return &___enumSeperatorCharArray_0; }
	inline void set_enumSeperatorCharArray_0(CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* value)
	{
		___enumSeperatorCharArray_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___enumSeperatorCharArray_0), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of System.Enum
struct Enum_t2AF27C02B8653AE29442467390005ABC74D8F521_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.Enum
struct Enum_t2AF27C02B8653AE29442467390005ABC74D8F521_marshaled_com
{
};

// System.Int32
struct  Int32_t585191389E07734F19F3156FF88FB3EF4800D102 
{
public:
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Int32_t585191389E07734F19F3156FF88FB3EF4800D102, ___m_value_0)); }
	inline int32_t get_m_value_0() const { return ___m_value_0; }
	inline int32_t* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(int32_t value)
	{
		___m_value_0 = value;
	}
};


// System.IntPtr
struct  IntPtr_t 
{
public:
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(IntPtr_t, ___m_value_0)); }
	inline void* get_m_value_0() const { return ___m_value_0; }
	inline void** get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(void* value)
	{
		___m_value_0 = value;
	}
};

struct IntPtr_t_StaticFields
{
public:
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;

public:
	inline static int32_t get_offset_of_Zero_1() { return static_cast<int32_t>(offsetof(IntPtr_t_StaticFields, ___Zero_1)); }
	inline intptr_t get_Zero_1() const { return ___Zero_1; }
	inline intptr_t* get_address_of_Zero_1() { return &___Zero_1; }
	inline void set_Zero_1(intptr_t value)
	{
		___Zero_1 = value;
	}
};


// System.Single
struct  Single_tDDDA9169C4E4E308AC6D7A824F9B28DC82204AE1 
{
public:
	// System.Single System.Single::m_value
	float ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Single_tDDDA9169C4E4E308AC6D7A824F9B28DC82204AE1, ___m_value_0)); }
	inline float get_m_value_0() const { return ___m_value_0; }
	inline float* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(float value)
	{
		___m_value_0 = value;
	}
};


// System.Void
struct  Void_t22962CB4C05B1D89B55A6E1139F0E87A90987017 
{
public:
	union
	{
		struct
		{
		};
		uint8_t Void_t22962CB4C05B1D89B55A6E1139F0E87A90987017__padding[1];
	};

public:
};


// UnityEngine.Color
struct  Color_t119BCA590009762C7223FDD3AF9706653AC84ED2 
{
public:
	// System.Single UnityEngine.Color::r
	float ___r_0;
	// System.Single UnityEngine.Color::g
	float ___g_1;
	// System.Single UnityEngine.Color::b
	float ___b_2;
	// System.Single UnityEngine.Color::a
	float ___a_3;

public:
	inline static int32_t get_offset_of_r_0() { return static_cast<int32_t>(offsetof(Color_t119BCA590009762C7223FDD3AF9706653AC84ED2, ___r_0)); }
	inline float get_r_0() const { return ___r_0; }
	inline float* get_address_of_r_0() { return &___r_0; }
	inline void set_r_0(float value)
	{
		___r_0 = value;
	}

	inline static int32_t get_offset_of_g_1() { return static_cast<int32_t>(offsetof(Color_t119BCA590009762C7223FDD3AF9706653AC84ED2, ___g_1)); }
	inline float get_g_1() const { return ___g_1; }
	inline float* get_address_of_g_1() { return &___g_1; }
	inline void set_g_1(float value)
	{
		___g_1 = value;
	}

	inline static int32_t get_offset_of_b_2() { return static_cast<int32_t>(offsetof(Color_t119BCA590009762C7223FDD3AF9706653AC84ED2, ___b_2)); }
	inline float get_b_2() const { return ___b_2; }
	inline float* get_address_of_b_2() { return &___b_2; }
	inline void set_b_2(float value)
	{
		___b_2 = value;
	}

	inline static int32_t get_offset_of_a_3() { return static_cast<int32_t>(offsetof(Color_t119BCA590009762C7223FDD3AF9706653AC84ED2, ___a_3)); }
	inline float get_a_3() const { return ___a_3; }
	inline float* get_address_of_a_3() { return &___a_3; }
	inline void set_a_3(float value)
	{
		___a_3 = value;
	}
};


// UnityEngine.Quaternion
struct  Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357 
{
public:
	// System.Single UnityEngine.Quaternion::x
	float ___x_0;
	// System.Single UnityEngine.Quaternion::y
	float ___y_1;
	// System.Single UnityEngine.Quaternion::z
	float ___z_2;
	// System.Single UnityEngine.Quaternion::w
	float ___w_3;

public:
	inline static int32_t get_offset_of_x_0() { return static_cast<int32_t>(offsetof(Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357, ___x_0)); }
	inline float get_x_0() const { return ___x_0; }
	inline float* get_address_of_x_0() { return &___x_0; }
	inline void set_x_0(float value)
	{
		___x_0 = value;
	}

	inline static int32_t get_offset_of_y_1() { return static_cast<int32_t>(offsetof(Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357, ___y_1)); }
	inline float get_y_1() const { return ___y_1; }
	inline float* get_address_of_y_1() { return &___y_1; }
	inline void set_y_1(float value)
	{
		___y_1 = value;
	}

	inline static int32_t get_offset_of_z_2() { return static_cast<int32_t>(offsetof(Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357, ___z_2)); }
	inline float get_z_2() const { return ___z_2; }
	inline float* get_address_of_z_2() { return &___z_2; }
	inline void set_z_2(float value)
	{
		___z_2 = value;
	}

	inline static int32_t get_offset_of_w_3() { return static_cast<int32_t>(offsetof(Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357, ___w_3)); }
	inline float get_w_3() const { return ___w_3; }
	inline float* get_address_of_w_3() { return &___w_3; }
	inline void set_w_3(float value)
	{
		___w_3 = value;
	}
};

struct Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357_StaticFields
{
public:
	// UnityEngine.Quaternion UnityEngine.Quaternion::identityQuaternion
	Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  ___identityQuaternion_4;

public:
	inline static int32_t get_offset_of_identityQuaternion_4() { return static_cast<int32_t>(offsetof(Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357_StaticFields, ___identityQuaternion_4)); }
	inline Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  get_identityQuaternion_4() const { return ___identityQuaternion_4; }
	inline Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357 * get_address_of_identityQuaternion_4() { return &___identityQuaternion_4; }
	inline void set_identityQuaternion_4(Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  value)
	{
		___identityQuaternion_4 = value;
	}
};


// UnityEngine.Rect
struct  Rect_t35B976DE901B5423C11705E156938EA27AB402CE 
{
public:
	// System.Single UnityEngine.Rect::m_XMin
	float ___m_XMin_0;
	// System.Single UnityEngine.Rect::m_YMin
	float ___m_YMin_1;
	// System.Single UnityEngine.Rect::m_Width
	float ___m_Width_2;
	// System.Single UnityEngine.Rect::m_Height
	float ___m_Height_3;

public:
	inline static int32_t get_offset_of_m_XMin_0() { return static_cast<int32_t>(offsetof(Rect_t35B976DE901B5423C11705E156938EA27AB402CE, ___m_XMin_0)); }
	inline float get_m_XMin_0() const { return ___m_XMin_0; }
	inline float* get_address_of_m_XMin_0() { return &___m_XMin_0; }
	inline void set_m_XMin_0(float value)
	{
		___m_XMin_0 = value;
	}

	inline static int32_t get_offset_of_m_YMin_1() { return static_cast<int32_t>(offsetof(Rect_t35B976DE901B5423C11705E156938EA27AB402CE, ___m_YMin_1)); }
	inline float get_m_YMin_1() const { return ___m_YMin_1; }
	inline float* get_address_of_m_YMin_1() { return &___m_YMin_1; }
	inline void set_m_YMin_1(float value)
	{
		___m_YMin_1 = value;
	}

	inline static int32_t get_offset_of_m_Width_2() { return static_cast<int32_t>(offsetof(Rect_t35B976DE901B5423C11705E156938EA27AB402CE, ___m_Width_2)); }
	inline float get_m_Width_2() const { return ___m_Width_2; }
	inline float* get_address_of_m_Width_2() { return &___m_Width_2; }
	inline void set_m_Width_2(float value)
	{
		___m_Width_2 = value;
	}

	inline static int32_t get_offset_of_m_Height_3() { return static_cast<int32_t>(offsetof(Rect_t35B976DE901B5423C11705E156938EA27AB402CE, ___m_Height_3)); }
	inline float get_m_Height_3() const { return ___m_Height_3; }
	inline float* get_address_of_m_Height_3() { return &___m_Height_3; }
	inline void set_m_Height_3(float value)
	{
		___m_Height_3 = value;
	}
};


// UnityEngine.Vector2
struct  Vector2_tA85D2DD88578276CA8A8796756458277E72D073D 
{
public:
	// System.Single UnityEngine.Vector2::x
	float ___x_0;
	// System.Single UnityEngine.Vector2::y
	float ___y_1;

public:
	inline static int32_t get_offset_of_x_0() { return static_cast<int32_t>(offsetof(Vector2_tA85D2DD88578276CA8A8796756458277E72D073D, ___x_0)); }
	inline float get_x_0() const { return ___x_0; }
	inline float* get_address_of_x_0() { return &___x_0; }
	inline void set_x_0(float value)
	{
		___x_0 = value;
	}

	inline static int32_t get_offset_of_y_1() { return static_cast<int32_t>(offsetof(Vector2_tA85D2DD88578276CA8A8796756458277E72D073D, ___y_1)); }
	inline float get_y_1() const { return ___y_1; }
	inline float* get_address_of_y_1() { return &___y_1; }
	inline void set_y_1(float value)
	{
		___y_1 = value;
	}
};

struct Vector2_tA85D2DD88578276CA8A8796756458277E72D073D_StaticFields
{
public:
	// UnityEngine.Vector2 UnityEngine.Vector2::zeroVector
	Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  ___zeroVector_2;
	// UnityEngine.Vector2 UnityEngine.Vector2::oneVector
	Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  ___oneVector_3;
	// UnityEngine.Vector2 UnityEngine.Vector2::upVector
	Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  ___upVector_4;
	// UnityEngine.Vector2 UnityEngine.Vector2::downVector
	Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  ___downVector_5;
	// UnityEngine.Vector2 UnityEngine.Vector2::leftVector
	Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  ___leftVector_6;
	// UnityEngine.Vector2 UnityEngine.Vector2::rightVector
	Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  ___rightVector_7;
	// UnityEngine.Vector2 UnityEngine.Vector2::positiveInfinityVector
	Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  ___positiveInfinityVector_8;
	// UnityEngine.Vector2 UnityEngine.Vector2::negativeInfinityVector
	Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  ___negativeInfinityVector_9;

public:
	inline static int32_t get_offset_of_zeroVector_2() { return static_cast<int32_t>(offsetof(Vector2_tA85D2DD88578276CA8A8796756458277E72D073D_StaticFields, ___zeroVector_2)); }
	inline Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  get_zeroVector_2() const { return ___zeroVector_2; }
	inline Vector2_tA85D2DD88578276CA8A8796756458277E72D073D * get_address_of_zeroVector_2() { return &___zeroVector_2; }
	inline void set_zeroVector_2(Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  value)
	{
		___zeroVector_2 = value;
	}

	inline static int32_t get_offset_of_oneVector_3() { return static_cast<int32_t>(offsetof(Vector2_tA85D2DD88578276CA8A8796756458277E72D073D_StaticFields, ___oneVector_3)); }
	inline Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  get_oneVector_3() const { return ___oneVector_3; }
	inline Vector2_tA85D2DD88578276CA8A8796756458277E72D073D * get_address_of_oneVector_3() { return &___oneVector_3; }
	inline void set_oneVector_3(Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  value)
	{
		___oneVector_3 = value;
	}

	inline static int32_t get_offset_of_upVector_4() { return static_cast<int32_t>(offsetof(Vector2_tA85D2DD88578276CA8A8796756458277E72D073D_StaticFields, ___upVector_4)); }
	inline Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  get_upVector_4() const { return ___upVector_4; }
	inline Vector2_tA85D2DD88578276CA8A8796756458277E72D073D * get_address_of_upVector_4() { return &___upVector_4; }
	inline void set_upVector_4(Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  value)
	{
		___upVector_4 = value;
	}

	inline static int32_t get_offset_of_downVector_5() { return static_cast<int32_t>(offsetof(Vector2_tA85D2DD88578276CA8A8796756458277E72D073D_StaticFields, ___downVector_5)); }
	inline Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  get_downVector_5() const { return ___downVector_5; }
	inline Vector2_tA85D2DD88578276CA8A8796756458277E72D073D * get_address_of_downVector_5() { return &___downVector_5; }
	inline void set_downVector_5(Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  value)
	{
		___downVector_5 = value;
	}

	inline static int32_t get_offset_of_leftVector_6() { return static_cast<int32_t>(offsetof(Vector2_tA85D2DD88578276CA8A8796756458277E72D073D_StaticFields, ___leftVector_6)); }
	inline Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  get_leftVector_6() const { return ___leftVector_6; }
	inline Vector2_tA85D2DD88578276CA8A8796756458277E72D073D * get_address_of_leftVector_6() { return &___leftVector_6; }
	inline void set_leftVector_6(Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  value)
	{
		___leftVector_6 = value;
	}

	inline static int32_t get_offset_of_rightVector_7() { return static_cast<int32_t>(offsetof(Vector2_tA85D2DD88578276CA8A8796756458277E72D073D_StaticFields, ___rightVector_7)); }
	inline Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  get_rightVector_7() const { return ___rightVector_7; }
	inline Vector2_tA85D2DD88578276CA8A8796756458277E72D073D * get_address_of_rightVector_7() { return &___rightVector_7; }
	inline void set_rightVector_7(Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  value)
	{
		___rightVector_7 = value;
	}

	inline static int32_t get_offset_of_positiveInfinityVector_8() { return static_cast<int32_t>(offsetof(Vector2_tA85D2DD88578276CA8A8796756458277E72D073D_StaticFields, ___positiveInfinityVector_8)); }
	inline Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  get_positiveInfinityVector_8() const { return ___positiveInfinityVector_8; }
	inline Vector2_tA85D2DD88578276CA8A8796756458277E72D073D * get_address_of_positiveInfinityVector_8() { return &___positiveInfinityVector_8; }
	inline void set_positiveInfinityVector_8(Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  value)
	{
		___positiveInfinityVector_8 = value;
	}

	inline static int32_t get_offset_of_negativeInfinityVector_9() { return static_cast<int32_t>(offsetof(Vector2_tA85D2DD88578276CA8A8796756458277E72D073D_StaticFields, ___negativeInfinityVector_9)); }
	inline Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  get_negativeInfinityVector_9() const { return ___negativeInfinityVector_9; }
	inline Vector2_tA85D2DD88578276CA8A8796756458277E72D073D * get_address_of_negativeInfinityVector_9() { return &___negativeInfinityVector_9; }
	inline void set_negativeInfinityVector_9(Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  value)
	{
		___negativeInfinityVector_9 = value;
	}
};


// UnityEngine.Vector3
struct  Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720 
{
public:
	// System.Single UnityEngine.Vector3::x
	float ___x_2;
	// System.Single UnityEngine.Vector3::y
	float ___y_3;
	// System.Single UnityEngine.Vector3::z
	float ___z_4;

public:
	inline static int32_t get_offset_of_x_2() { return static_cast<int32_t>(offsetof(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720, ___x_2)); }
	inline float get_x_2() const { return ___x_2; }
	inline float* get_address_of_x_2() { return &___x_2; }
	inline void set_x_2(float value)
	{
		___x_2 = value;
	}

	inline static int32_t get_offset_of_y_3() { return static_cast<int32_t>(offsetof(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720, ___y_3)); }
	inline float get_y_3() const { return ___y_3; }
	inline float* get_address_of_y_3() { return &___y_3; }
	inline void set_y_3(float value)
	{
		___y_3 = value;
	}

	inline static int32_t get_offset_of_z_4() { return static_cast<int32_t>(offsetof(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720, ___z_4)); }
	inline float get_z_4() const { return ___z_4; }
	inline float* get_address_of_z_4() { return &___z_4; }
	inline void set_z_4(float value)
	{
		___z_4 = value;
	}
};

struct Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720_StaticFields
{
public:
	// UnityEngine.Vector3 UnityEngine.Vector3::zeroVector
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___zeroVector_5;
	// UnityEngine.Vector3 UnityEngine.Vector3::oneVector
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___oneVector_6;
	// UnityEngine.Vector3 UnityEngine.Vector3::upVector
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___upVector_7;
	// UnityEngine.Vector3 UnityEngine.Vector3::downVector
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___downVector_8;
	// UnityEngine.Vector3 UnityEngine.Vector3::leftVector
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___leftVector_9;
	// UnityEngine.Vector3 UnityEngine.Vector3::rightVector
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___rightVector_10;
	// UnityEngine.Vector3 UnityEngine.Vector3::forwardVector
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___forwardVector_11;
	// UnityEngine.Vector3 UnityEngine.Vector3::backVector
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___backVector_12;
	// UnityEngine.Vector3 UnityEngine.Vector3::positiveInfinityVector
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___positiveInfinityVector_13;
	// UnityEngine.Vector3 UnityEngine.Vector3::negativeInfinityVector
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___negativeInfinityVector_14;

public:
	inline static int32_t get_offset_of_zeroVector_5() { return static_cast<int32_t>(offsetof(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720_StaticFields, ___zeroVector_5)); }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  get_zeroVector_5() const { return ___zeroVector_5; }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720 * get_address_of_zeroVector_5() { return &___zeroVector_5; }
	inline void set_zeroVector_5(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  value)
	{
		___zeroVector_5 = value;
	}

	inline static int32_t get_offset_of_oneVector_6() { return static_cast<int32_t>(offsetof(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720_StaticFields, ___oneVector_6)); }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  get_oneVector_6() const { return ___oneVector_6; }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720 * get_address_of_oneVector_6() { return &___oneVector_6; }
	inline void set_oneVector_6(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  value)
	{
		___oneVector_6 = value;
	}

	inline static int32_t get_offset_of_upVector_7() { return static_cast<int32_t>(offsetof(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720_StaticFields, ___upVector_7)); }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  get_upVector_7() const { return ___upVector_7; }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720 * get_address_of_upVector_7() { return &___upVector_7; }
	inline void set_upVector_7(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  value)
	{
		___upVector_7 = value;
	}

	inline static int32_t get_offset_of_downVector_8() { return static_cast<int32_t>(offsetof(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720_StaticFields, ___downVector_8)); }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  get_downVector_8() const { return ___downVector_8; }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720 * get_address_of_downVector_8() { return &___downVector_8; }
	inline void set_downVector_8(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  value)
	{
		___downVector_8 = value;
	}

	inline static int32_t get_offset_of_leftVector_9() { return static_cast<int32_t>(offsetof(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720_StaticFields, ___leftVector_9)); }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  get_leftVector_9() const { return ___leftVector_9; }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720 * get_address_of_leftVector_9() { return &___leftVector_9; }
	inline void set_leftVector_9(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  value)
	{
		___leftVector_9 = value;
	}

	inline static int32_t get_offset_of_rightVector_10() { return static_cast<int32_t>(offsetof(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720_StaticFields, ___rightVector_10)); }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  get_rightVector_10() const { return ___rightVector_10; }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720 * get_address_of_rightVector_10() { return &___rightVector_10; }
	inline void set_rightVector_10(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  value)
	{
		___rightVector_10 = value;
	}

	inline static int32_t get_offset_of_forwardVector_11() { return static_cast<int32_t>(offsetof(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720_StaticFields, ___forwardVector_11)); }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  get_forwardVector_11() const { return ___forwardVector_11; }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720 * get_address_of_forwardVector_11() { return &___forwardVector_11; }
	inline void set_forwardVector_11(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  value)
	{
		___forwardVector_11 = value;
	}

	inline static int32_t get_offset_of_backVector_12() { return static_cast<int32_t>(offsetof(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720_StaticFields, ___backVector_12)); }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  get_backVector_12() const { return ___backVector_12; }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720 * get_address_of_backVector_12() { return &___backVector_12; }
	inline void set_backVector_12(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  value)
	{
		___backVector_12 = value;
	}

	inline static int32_t get_offset_of_positiveInfinityVector_13() { return static_cast<int32_t>(offsetof(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720_StaticFields, ___positiveInfinityVector_13)); }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  get_positiveInfinityVector_13() const { return ___positiveInfinityVector_13; }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720 * get_address_of_positiveInfinityVector_13() { return &___positiveInfinityVector_13; }
	inline void set_positiveInfinityVector_13(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  value)
	{
		___positiveInfinityVector_13 = value;
	}

	inline static int32_t get_offset_of_negativeInfinityVector_14() { return static_cast<int32_t>(offsetof(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720_StaticFields, ___negativeInfinityVector_14)); }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  get_negativeInfinityVector_14() const { return ___negativeInfinityVector_14; }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720 * get_address_of_negativeInfinityVector_14() { return &___negativeInfinityVector_14; }
	inline void set_negativeInfinityVector_14(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  value)
	{
		___negativeInfinityVector_14 = value;
	}
};


// DG.Tweening.AutoPlay
struct  AutoPlay_t17E2BFFF87FCE2B8BAD2FD23B2B65379B515EC12 
{
public:
	// System.Int32 DG.Tweening.AutoPlay::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(AutoPlay_t17E2BFFF87FCE2B8BAD2FD23B2B65379B515EC12, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// DG.Tweening.AxisConstraint
struct  AxisConstraint_t6929580E28515C207FCC805981F73EC49354E48A 
{
public:
	// System.Int32 DG.Tweening.AxisConstraint::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(AxisConstraint_t6929580E28515C207FCC805981F73EC49354E48A, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// DG.Tweening.Core.Enums.SpecialStartupMode
struct  SpecialStartupMode_tE272D2FEC46F4A5FC68E9A99E0093494AA4E0E49 
{
public:
	// System.Int32 DG.Tweening.Core.Enums.SpecialStartupMode::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(SpecialStartupMode_tE272D2FEC46F4A5FC68E9A99E0093494AA4E0E49, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// DG.Tweening.Core.Enums.UpdateMode
struct  UpdateMode_tF271804A5FF87FE0CBFBD3FF6011D9499D5C6662 
{
public:
	// System.Int32 DG.Tweening.Core.Enums.UpdateMode::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(UpdateMode_tF271804A5FF87FE0CBFBD3FF6011D9499D5C6662, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// DG.Tweening.Core.Enums.UpdateNotice
struct  UpdateNotice_t03AF68BDDDBD2D8575BA411C06D96FC886C74D39 
{
public:
	// System.Int32 DG.Tweening.Core.Enums.UpdateNotice::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(UpdateNotice_t03AF68BDDDBD2D8575BA411C06D96FC886C74D39, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// DG.Tweening.Ease
struct  Ease_tC8B7BB21FCD1947DD4A1DD8025D4E9C6CC01DA0E 
{
public:
	// System.Int32 DG.Tweening.Ease::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(Ease_tC8B7BB21FCD1947DD4A1DD8025D4E9C6CC01DA0E, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// DG.Tweening.LogBehaviour
struct  LogBehaviour_tD1A4AACD65E9C63844373CF59B8E9A576814F813 
{
public:
	// System.Int32 DG.Tweening.LogBehaviour::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(LogBehaviour_tD1A4AACD65E9C63844373CF59B8E9A576814F813, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// DG.Tweening.LoopType
struct  LoopType_t1F864F717700724AC772E79CCF167C3C44D6EE1A 
{
public:
	// System.Int32 DG.Tweening.LoopType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(LoopType_t1F864F717700724AC772E79CCF167C3C44D6EE1A, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// DG.Tweening.PathMode
struct  PathMode_t2ACD9081A852C6AE7EBBC384C9BC14805080366B 
{
public:
	// System.Int32 DG.Tweening.PathMode::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(PathMode_t2ACD9081A852C6AE7EBBC384C9BC14805080366B, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// DG.Tweening.Plugins.Options.OrientType
struct  OrientType_tA561E2F4F794660D71F18B057A4C6488691EA237 
{
public:
	// System.Int32 DG.Tweening.Plugins.Options.OrientType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(OrientType_tA561E2F4F794660D71F18B057A4C6488691EA237, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// DG.Tweening.ScrambleMode
struct  ScrambleMode_tB2CAB82E2A9149E917AF3B1261C86133CBF83551 
{
public:
	// System.Int32 DG.Tweening.ScrambleMode::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(ScrambleMode_tB2CAB82E2A9149E917AF3B1261C86133CBF83551, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// DG.Tweening.ShortcutExtensions_<>c__DisplayClass12c
struct  U3CU3Ec__DisplayClass12c_t3BC7A246A89C39269E33DB9EFFF37B2EEF6C1F23  : public RuntimeObject
{
public:
	// UnityEngine.Quaternion DG.Tweening.ShortcutExtensions_<>c__DisplayClass12c::to
	Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  ___to_0;
	// UnityEngine.Transform DG.Tweening.ShortcutExtensions_<>c__DisplayClass12c::target
	Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * ___target_1;

public:
	inline static int32_t get_offset_of_to_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass12c_t3BC7A246A89C39269E33DB9EFFF37B2EEF6C1F23, ___to_0)); }
	inline Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  get_to_0() const { return ___to_0; }
	inline Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357 * get_address_of_to_0() { return &___to_0; }
	inline void set_to_0(Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  value)
	{
		___to_0 = value;
	}

	inline static int32_t get_offset_of_target_1() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass12c_t3BC7A246A89C39269E33DB9EFFF37B2EEF6C1F23, ___target_1)); }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * get_target_1() const { return ___target_1; }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA ** get_address_of_target_1() { return &___target_1; }
	inline void set_target_1(Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * value)
	{
		___target_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_1), (void*)value);
	}
};


// DG.Tweening.TweenType
struct  TweenType_t13FCD3DFD7DD8AE49EA4A7BA70695D3936EAF71F 
{
public:
	// System.Int32 DG.Tweening.TweenType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(TweenType_t13FCD3DFD7DD8AE49EA4A7BA70695D3936EAF71F, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// DG.Tweening.UpdateType
struct  UpdateType_t0EBAB258B7D72D4959A3835E554B7958CAFDAF63 
{
public:
	// System.Int32 DG.Tweening.UpdateType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(UpdateType_t0EBAB258B7D72D4959A3835E554B7958CAFDAF63, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.Delegate
struct  Delegate_t  : public RuntimeObject
{
public:
	// System.IntPtr System.Delegate::method_ptr
	Il2CppMethodPointer ___method_ptr_0;
	// System.IntPtr System.Delegate::invoke_impl
	intptr_t ___invoke_impl_1;
	// System.Object System.Delegate::m_target
	RuntimeObject * ___m_target_2;
	// System.IntPtr System.Delegate::method
	intptr_t ___method_3;
	// System.IntPtr System.Delegate::delegate_trampoline
	intptr_t ___delegate_trampoline_4;
	// System.IntPtr System.Delegate::extra_arg
	intptr_t ___extra_arg_5;
	// System.IntPtr System.Delegate::method_code
	intptr_t ___method_code_6;
	// System.Reflection.MethodInfo System.Delegate::method_info
	MethodInfo_t * ___method_info_7;
	// System.Reflection.MethodInfo System.Delegate::original_method_info
	MethodInfo_t * ___original_method_info_8;
	// System.DelegateData System.Delegate::data
	DelegateData_t1BF9F691B56DAE5F8C28C5E084FDE94F15F27BBE * ___data_9;
	// System.Boolean System.Delegate::method_is_virtual
	bool ___method_is_virtual_10;

public:
	inline static int32_t get_offset_of_method_ptr_0() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_ptr_0)); }
	inline Il2CppMethodPointer get_method_ptr_0() const { return ___method_ptr_0; }
	inline Il2CppMethodPointer* get_address_of_method_ptr_0() { return &___method_ptr_0; }
	inline void set_method_ptr_0(Il2CppMethodPointer value)
	{
		___method_ptr_0 = value;
	}

	inline static int32_t get_offset_of_invoke_impl_1() { return static_cast<int32_t>(offsetof(Delegate_t, ___invoke_impl_1)); }
	inline intptr_t get_invoke_impl_1() const { return ___invoke_impl_1; }
	inline intptr_t* get_address_of_invoke_impl_1() { return &___invoke_impl_1; }
	inline void set_invoke_impl_1(intptr_t value)
	{
		___invoke_impl_1 = value;
	}

	inline static int32_t get_offset_of_m_target_2() { return static_cast<int32_t>(offsetof(Delegate_t, ___m_target_2)); }
	inline RuntimeObject * get_m_target_2() const { return ___m_target_2; }
	inline RuntimeObject ** get_address_of_m_target_2() { return &___m_target_2; }
	inline void set_m_target_2(RuntimeObject * value)
	{
		___m_target_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_target_2), (void*)value);
	}

	inline static int32_t get_offset_of_method_3() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_3)); }
	inline intptr_t get_method_3() const { return ___method_3; }
	inline intptr_t* get_address_of_method_3() { return &___method_3; }
	inline void set_method_3(intptr_t value)
	{
		___method_3 = value;
	}

	inline static int32_t get_offset_of_delegate_trampoline_4() { return static_cast<int32_t>(offsetof(Delegate_t, ___delegate_trampoline_4)); }
	inline intptr_t get_delegate_trampoline_4() const { return ___delegate_trampoline_4; }
	inline intptr_t* get_address_of_delegate_trampoline_4() { return &___delegate_trampoline_4; }
	inline void set_delegate_trampoline_4(intptr_t value)
	{
		___delegate_trampoline_4 = value;
	}

	inline static int32_t get_offset_of_extra_arg_5() { return static_cast<int32_t>(offsetof(Delegate_t, ___extra_arg_5)); }
	inline intptr_t get_extra_arg_5() const { return ___extra_arg_5; }
	inline intptr_t* get_address_of_extra_arg_5() { return &___extra_arg_5; }
	inline void set_extra_arg_5(intptr_t value)
	{
		___extra_arg_5 = value;
	}

	inline static int32_t get_offset_of_method_code_6() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_code_6)); }
	inline intptr_t get_method_code_6() const { return ___method_code_6; }
	inline intptr_t* get_address_of_method_code_6() { return &___method_code_6; }
	inline void set_method_code_6(intptr_t value)
	{
		___method_code_6 = value;
	}

	inline static int32_t get_offset_of_method_info_7() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_info_7)); }
	inline MethodInfo_t * get_method_info_7() const { return ___method_info_7; }
	inline MethodInfo_t ** get_address_of_method_info_7() { return &___method_info_7; }
	inline void set_method_info_7(MethodInfo_t * value)
	{
		___method_info_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___method_info_7), (void*)value);
	}

	inline static int32_t get_offset_of_original_method_info_8() { return static_cast<int32_t>(offsetof(Delegate_t, ___original_method_info_8)); }
	inline MethodInfo_t * get_original_method_info_8() const { return ___original_method_info_8; }
	inline MethodInfo_t ** get_address_of_original_method_info_8() { return &___original_method_info_8; }
	inline void set_original_method_info_8(MethodInfo_t * value)
	{
		___original_method_info_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___original_method_info_8), (void*)value);
	}

	inline static int32_t get_offset_of_data_9() { return static_cast<int32_t>(offsetof(Delegate_t, ___data_9)); }
	inline DelegateData_t1BF9F691B56DAE5F8C28C5E084FDE94F15F27BBE * get_data_9() const { return ___data_9; }
	inline DelegateData_t1BF9F691B56DAE5F8C28C5E084FDE94F15F27BBE ** get_address_of_data_9() { return &___data_9; }
	inline void set_data_9(DelegateData_t1BF9F691B56DAE5F8C28C5E084FDE94F15F27BBE * value)
	{
		___data_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___data_9), (void*)value);
	}

	inline static int32_t get_offset_of_method_is_virtual_10() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_is_virtual_10)); }
	inline bool get_method_is_virtual_10() const { return ___method_is_virtual_10; }
	inline bool* get_address_of_method_is_virtual_10() { return &___method_is_virtual_10; }
	inline void set_method_is_virtual_10(bool value)
	{
		___method_is_virtual_10 = value;
	}
};

// Native definition for P/Invoke marshalling of System.Delegate
struct Delegate_t_marshaled_pinvoke
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	MethodInfo_t * ___method_info_7;
	MethodInfo_t * ___original_method_info_8;
	DelegateData_t1BF9F691B56DAE5F8C28C5E084FDE94F15F27BBE * ___data_9;
	int32_t ___method_is_virtual_10;
};
// Native definition for COM marshalling of System.Delegate
struct Delegate_t_marshaled_com
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	MethodInfo_t * ___method_info_7;
	MethodInfo_t * ___original_method_info_8;
	DelegateData_t1BF9F691B56DAE5F8C28C5E084FDE94F15F27BBE * ___data_9;
	int32_t ___method_is_virtual_10;
};

// System.Exception
struct  Exception_t  : public RuntimeObject
{
public:
	// System.String System.Exception::_className
	String_t* ____className_1;
	// System.String System.Exception::_message
	String_t* ____message_2;
	// System.Collections.IDictionary System.Exception::_data
	RuntimeObject* ____data_3;
	// System.Exception System.Exception::_innerException
	Exception_t * ____innerException_4;
	// System.String System.Exception::_helpURL
	String_t* ____helpURL_5;
	// System.Object System.Exception::_stackTrace
	RuntimeObject * ____stackTrace_6;
	// System.String System.Exception::_stackTraceString
	String_t* ____stackTraceString_7;
	// System.String System.Exception::_remoteStackTraceString
	String_t* ____remoteStackTraceString_8;
	// System.Int32 System.Exception::_remoteStackIndex
	int32_t ____remoteStackIndex_9;
	// System.Object System.Exception::_dynamicMethods
	RuntimeObject * ____dynamicMethods_10;
	// System.Int32 System.Exception::_HResult
	int32_t ____HResult_11;
	// System.String System.Exception::_source
	String_t* ____source_12;
	// System.Runtime.Serialization.SafeSerializationManager System.Exception::_safeSerializationManager
	SafeSerializationManager_t4A754D86B0F784B18CBC36C073BA564BED109770 * ____safeSerializationManager_13;
	// System.Diagnostics.StackTrace[] System.Exception::captured_traces
	StackTraceU5BU5D_t855F09649EA34DEE7C1B6F088E0538E3CCC3F196* ___captured_traces_14;
	// System.IntPtr[] System.Exception::native_trace_ips
	IntPtrU5BU5D_t4DC01DCB9A6DF6C9792A6513595D7A11E637DCDD* ___native_trace_ips_15;

public:
	inline static int32_t get_offset_of__className_1() { return static_cast<int32_t>(offsetof(Exception_t, ____className_1)); }
	inline String_t* get__className_1() const { return ____className_1; }
	inline String_t** get_address_of__className_1() { return &____className_1; }
	inline void set__className_1(String_t* value)
	{
		____className_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____className_1), (void*)value);
	}

	inline static int32_t get_offset_of__message_2() { return static_cast<int32_t>(offsetof(Exception_t, ____message_2)); }
	inline String_t* get__message_2() const { return ____message_2; }
	inline String_t** get_address_of__message_2() { return &____message_2; }
	inline void set__message_2(String_t* value)
	{
		____message_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____message_2), (void*)value);
	}

	inline static int32_t get_offset_of__data_3() { return static_cast<int32_t>(offsetof(Exception_t, ____data_3)); }
	inline RuntimeObject* get__data_3() const { return ____data_3; }
	inline RuntimeObject** get_address_of__data_3() { return &____data_3; }
	inline void set__data_3(RuntimeObject* value)
	{
		____data_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____data_3), (void*)value);
	}

	inline static int32_t get_offset_of__innerException_4() { return static_cast<int32_t>(offsetof(Exception_t, ____innerException_4)); }
	inline Exception_t * get__innerException_4() const { return ____innerException_4; }
	inline Exception_t ** get_address_of__innerException_4() { return &____innerException_4; }
	inline void set__innerException_4(Exception_t * value)
	{
		____innerException_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____innerException_4), (void*)value);
	}

	inline static int32_t get_offset_of__helpURL_5() { return static_cast<int32_t>(offsetof(Exception_t, ____helpURL_5)); }
	inline String_t* get__helpURL_5() const { return ____helpURL_5; }
	inline String_t** get_address_of__helpURL_5() { return &____helpURL_5; }
	inline void set__helpURL_5(String_t* value)
	{
		____helpURL_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____helpURL_5), (void*)value);
	}

	inline static int32_t get_offset_of__stackTrace_6() { return static_cast<int32_t>(offsetof(Exception_t, ____stackTrace_6)); }
	inline RuntimeObject * get__stackTrace_6() const { return ____stackTrace_6; }
	inline RuntimeObject ** get_address_of__stackTrace_6() { return &____stackTrace_6; }
	inline void set__stackTrace_6(RuntimeObject * value)
	{
		____stackTrace_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____stackTrace_6), (void*)value);
	}

	inline static int32_t get_offset_of__stackTraceString_7() { return static_cast<int32_t>(offsetof(Exception_t, ____stackTraceString_7)); }
	inline String_t* get__stackTraceString_7() const { return ____stackTraceString_7; }
	inline String_t** get_address_of__stackTraceString_7() { return &____stackTraceString_7; }
	inline void set__stackTraceString_7(String_t* value)
	{
		____stackTraceString_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____stackTraceString_7), (void*)value);
	}

	inline static int32_t get_offset_of__remoteStackTraceString_8() { return static_cast<int32_t>(offsetof(Exception_t, ____remoteStackTraceString_8)); }
	inline String_t* get__remoteStackTraceString_8() const { return ____remoteStackTraceString_8; }
	inline String_t** get_address_of__remoteStackTraceString_8() { return &____remoteStackTraceString_8; }
	inline void set__remoteStackTraceString_8(String_t* value)
	{
		____remoteStackTraceString_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____remoteStackTraceString_8), (void*)value);
	}

	inline static int32_t get_offset_of__remoteStackIndex_9() { return static_cast<int32_t>(offsetof(Exception_t, ____remoteStackIndex_9)); }
	inline int32_t get__remoteStackIndex_9() const { return ____remoteStackIndex_9; }
	inline int32_t* get_address_of__remoteStackIndex_9() { return &____remoteStackIndex_9; }
	inline void set__remoteStackIndex_9(int32_t value)
	{
		____remoteStackIndex_9 = value;
	}

	inline static int32_t get_offset_of__dynamicMethods_10() { return static_cast<int32_t>(offsetof(Exception_t, ____dynamicMethods_10)); }
	inline RuntimeObject * get__dynamicMethods_10() const { return ____dynamicMethods_10; }
	inline RuntimeObject ** get_address_of__dynamicMethods_10() { return &____dynamicMethods_10; }
	inline void set__dynamicMethods_10(RuntimeObject * value)
	{
		____dynamicMethods_10 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____dynamicMethods_10), (void*)value);
	}

	inline static int32_t get_offset_of__HResult_11() { return static_cast<int32_t>(offsetof(Exception_t, ____HResult_11)); }
	inline int32_t get__HResult_11() const { return ____HResult_11; }
	inline int32_t* get_address_of__HResult_11() { return &____HResult_11; }
	inline void set__HResult_11(int32_t value)
	{
		____HResult_11 = value;
	}

	inline static int32_t get_offset_of__source_12() { return static_cast<int32_t>(offsetof(Exception_t, ____source_12)); }
	inline String_t* get__source_12() const { return ____source_12; }
	inline String_t** get_address_of__source_12() { return &____source_12; }
	inline void set__source_12(String_t* value)
	{
		____source_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____source_12), (void*)value);
	}

	inline static int32_t get_offset_of__safeSerializationManager_13() { return static_cast<int32_t>(offsetof(Exception_t, ____safeSerializationManager_13)); }
	inline SafeSerializationManager_t4A754D86B0F784B18CBC36C073BA564BED109770 * get__safeSerializationManager_13() const { return ____safeSerializationManager_13; }
	inline SafeSerializationManager_t4A754D86B0F784B18CBC36C073BA564BED109770 ** get_address_of__safeSerializationManager_13() { return &____safeSerializationManager_13; }
	inline void set__safeSerializationManager_13(SafeSerializationManager_t4A754D86B0F784B18CBC36C073BA564BED109770 * value)
	{
		____safeSerializationManager_13 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____safeSerializationManager_13), (void*)value);
	}

	inline static int32_t get_offset_of_captured_traces_14() { return static_cast<int32_t>(offsetof(Exception_t, ___captured_traces_14)); }
	inline StackTraceU5BU5D_t855F09649EA34DEE7C1B6F088E0538E3CCC3F196* get_captured_traces_14() const { return ___captured_traces_14; }
	inline StackTraceU5BU5D_t855F09649EA34DEE7C1B6F088E0538E3CCC3F196** get_address_of_captured_traces_14() { return &___captured_traces_14; }
	inline void set_captured_traces_14(StackTraceU5BU5D_t855F09649EA34DEE7C1B6F088E0538E3CCC3F196* value)
	{
		___captured_traces_14 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___captured_traces_14), (void*)value);
	}

	inline static int32_t get_offset_of_native_trace_ips_15() { return static_cast<int32_t>(offsetof(Exception_t, ___native_trace_ips_15)); }
	inline IntPtrU5BU5D_t4DC01DCB9A6DF6C9792A6513595D7A11E637DCDD* get_native_trace_ips_15() const { return ___native_trace_ips_15; }
	inline IntPtrU5BU5D_t4DC01DCB9A6DF6C9792A6513595D7A11E637DCDD** get_address_of_native_trace_ips_15() { return &___native_trace_ips_15; }
	inline void set_native_trace_ips_15(IntPtrU5BU5D_t4DC01DCB9A6DF6C9792A6513595D7A11E637DCDD* value)
	{
		___native_trace_ips_15 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___native_trace_ips_15), (void*)value);
	}
};

struct Exception_t_StaticFields
{
public:
	// System.Object System.Exception::s_EDILock
	RuntimeObject * ___s_EDILock_0;

public:
	inline static int32_t get_offset_of_s_EDILock_0() { return static_cast<int32_t>(offsetof(Exception_t_StaticFields, ___s_EDILock_0)); }
	inline RuntimeObject * get_s_EDILock_0() const { return ___s_EDILock_0; }
	inline RuntimeObject ** get_address_of_s_EDILock_0() { return &___s_EDILock_0; }
	inline void set_s_EDILock_0(RuntimeObject * value)
	{
		___s_EDILock_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_EDILock_0), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of System.Exception
struct Exception_t_marshaled_pinvoke
{
	char* ____className_1;
	char* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_pinvoke* ____innerException_4;
	char* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	char* ____stackTraceString_7;
	char* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	char* ____source_12;
	SafeSerializationManager_t4A754D86B0F784B18CBC36C073BA564BED109770 * ____safeSerializationManager_13;
	StackTraceU5BU5D_t855F09649EA34DEE7C1B6F088E0538E3CCC3F196* ___captured_traces_14;
	Il2CppSafeArray/*NONE*/* ___native_trace_ips_15;
};
// Native definition for COM marshalling of System.Exception
struct Exception_t_marshaled_com
{
	Il2CppChar* ____className_1;
	Il2CppChar* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_com* ____innerException_4;
	Il2CppChar* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	Il2CppChar* ____stackTraceString_7;
	Il2CppChar* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	Il2CppChar* ____source_12;
	SafeSerializationManager_t4A754D86B0F784B18CBC36C073BA564BED109770 * ____safeSerializationManager_13;
	StackTraceU5BU5D_t855F09649EA34DEE7C1B6F088E0538E3CCC3F196* ___captured_traces_14;
	Il2CppSafeArray/*NONE*/* ___native_trace_ips_15;
};

// System.Nullable`1<UnityEngine.Vector3>
struct  Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE 
{
public:
	// T System.Nullable`1::value
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___value_0;
	// System.Boolean System.Nullable`1::has_value
	bool ___has_value_1;

public:
	inline static int32_t get_offset_of_value_0() { return static_cast<int32_t>(offsetof(Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE, ___value_0)); }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  get_value_0() const { return ___value_0; }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720 * get_address_of_value_0() { return &___value_0; }
	inline void set_value_0(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  value)
	{
		___value_0 = value;
	}

	inline static int32_t get_offset_of_has_value_1() { return static_cast<int32_t>(offsetof(Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE, ___has_value_1)); }
	inline bool get_has_value_1() const { return ___has_value_1; }
	inline bool* get_address_of_has_value_1() { return &___has_value_1; }
	inline void set_has_value_1(bool value)
	{
		___has_value_1 = value;
	}
};


// UnityEngine.Object
struct  Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0  : public RuntimeObject
{
public:
	// System.IntPtr UnityEngine.Object::m_CachedPtr
	intptr_t ___m_CachedPtr_0;

public:
	inline static int32_t get_offset_of_m_CachedPtr_0() { return static_cast<int32_t>(offsetof(Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0, ___m_CachedPtr_0)); }
	inline intptr_t get_m_CachedPtr_0() const { return ___m_CachedPtr_0; }
	inline intptr_t* get_address_of_m_CachedPtr_0() { return &___m_CachedPtr_0; }
	inline void set_m_CachedPtr_0(intptr_t value)
	{
		___m_CachedPtr_0 = value;
	}
};

struct Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_StaticFields
{
public:
	// System.Int32 UnityEngine.Object::OffsetOfInstanceIDInCPlusPlusObject
	int32_t ___OffsetOfInstanceIDInCPlusPlusObject_1;

public:
	inline static int32_t get_offset_of_OffsetOfInstanceIDInCPlusPlusObject_1() { return static_cast<int32_t>(offsetof(Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_StaticFields, ___OffsetOfInstanceIDInCPlusPlusObject_1)); }
	inline int32_t get_OffsetOfInstanceIDInCPlusPlusObject_1() const { return ___OffsetOfInstanceIDInCPlusPlusObject_1; }
	inline int32_t* get_address_of_OffsetOfInstanceIDInCPlusPlusObject_1() { return &___OffsetOfInstanceIDInCPlusPlusObject_1; }
	inline void set_OffsetOfInstanceIDInCPlusPlusObject_1(int32_t value)
	{
		___OffsetOfInstanceIDInCPlusPlusObject_1 = value;
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.Object
struct Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_marshaled_pinvoke
{
	intptr_t ___m_CachedPtr_0;
};
// Native definition for COM marshalling of UnityEngine.Object
struct Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_marshaled_com
{
	intptr_t ___m_CachedPtr_0;
};

// DG.Tweening.Core.ABSSequentiable
struct  ABSSequentiable_tDA1366907669973CC0BB553EF4159D45FC46A757  : public RuntimeObject
{
public:
	// DG.Tweening.TweenType DG.Tweening.Core.ABSSequentiable::tweenType
	int32_t ___tweenType_0;
	// System.Single DG.Tweening.Core.ABSSequentiable::sequencedPosition
	float ___sequencedPosition_1;
	// System.Single DG.Tweening.Core.ABSSequentiable::sequencedEndPosition
	float ___sequencedEndPosition_2;
	// DG.Tweening.TweenCallback DG.Tweening.Core.ABSSequentiable::onStart
	TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * ___onStart_3;

public:
	inline static int32_t get_offset_of_tweenType_0() { return static_cast<int32_t>(offsetof(ABSSequentiable_tDA1366907669973CC0BB553EF4159D45FC46A757, ___tweenType_0)); }
	inline int32_t get_tweenType_0() const { return ___tweenType_0; }
	inline int32_t* get_address_of_tweenType_0() { return &___tweenType_0; }
	inline void set_tweenType_0(int32_t value)
	{
		___tweenType_0 = value;
	}

	inline static int32_t get_offset_of_sequencedPosition_1() { return static_cast<int32_t>(offsetof(ABSSequentiable_tDA1366907669973CC0BB553EF4159D45FC46A757, ___sequencedPosition_1)); }
	inline float get_sequencedPosition_1() const { return ___sequencedPosition_1; }
	inline float* get_address_of_sequencedPosition_1() { return &___sequencedPosition_1; }
	inline void set_sequencedPosition_1(float value)
	{
		___sequencedPosition_1 = value;
	}

	inline static int32_t get_offset_of_sequencedEndPosition_2() { return static_cast<int32_t>(offsetof(ABSSequentiable_tDA1366907669973CC0BB553EF4159D45FC46A757, ___sequencedEndPosition_2)); }
	inline float get_sequencedEndPosition_2() const { return ___sequencedEndPosition_2; }
	inline float* get_address_of_sequencedEndPosition_2() { return &___sequencedEndPosition_2; }
	inline void set_sequencedEndPosition_2(float value)
	{
		___sequencedEndPosition_2 = value;
	}

	inline static int32_t get_offset_of_onStart_3() { return static_cast<int32_t>(offsetof(ABSSequentiable_tDA1366907669973CC0BB553EF4159D45FC46A757, ___onStart_3)); }
	inline TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * get_onStart_3() const { return ___onStart_3; }
	inline TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 ** get_address_of_onStart_3() { return &___onStart_3; }
	inline void set_onStart_3(TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * value)
	{
		___onStart_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___onStart_3), (void*)value);
	}
};


// DG.Tweening.DOTween
struct  DOTween_t6BB48F76E494B12781696AF3D0733CA8DC367E8D  : public RuntimeObject
{
public:

public:
};

struct DOTween_t6BB48F76E494B12781696AF3D0733CA8DC367E8D_StaticFields
{
public:
	// System.String DG.Tweening.DOTween::Version
	String_t* ___Version_0;
	// System.Boolean DG.Tweening.DOTween::useSafeMode
	bool ___useSafeMode_1;
	// System.Boolean DG.Tweening.DOTween::showUnityEditorReport
	bool ___showUnityEditorReport_2;
	// System.Single DG.Tweening.DOTween::timeScale
	float ___timeScale_3;
	// DG.Tweening.LogBehaviour DG.Tweening.DOTween::_logBehaviour
	int32_t ____logBehaviour_4;
	// System.Boolean DG.Tweening.DOTween::drawGizmos
	bool ___drawGizmos_5;
	// DG.Tweening.UpdateType DG.Tweening.DOTween::defaultUpdateType
	int32_t ___defaultUpdateType_6;
	// System.Boolean DG.Tweening.DOTween::defaultTimeScaleIndependent
	bool ___defaultTimeScaleIndependent_7;
	// DG.Tweening.AutoPlay DG.Tweening.DOTween::defaultAutoPlay
	int32_t ___defaultAutoPlay_8;
	// System.Boolean DG.Tweening.DOTween::defaultAutoKill
	bool ___defaultAutoKill_9;
	// DG.Tweening.LoopType DG.Tweening.DOTween::defaultLoopType
	int32_t ___defaultLoopType_10;
	// System.Boolean DG.Tweening.DOTween::defaultRecyclable
	bool ___defaultRecyclable_11;
	// DG.Tweening.Ease DG.Tweening.DOTween::defaultEaseType
	int32_t ___defaultEaseType_12;
	// System.Single DG.Tweening.DOTween::defaultEaseOvershootOrAmplitude
	float ___defaultEaseOvershootOrAmplitude_13;
	// System.Single DG.Tweening.DOTween::defaultEasePeriod
	float ___defaultEasePeriod_14;
	// DG.Tweening.Core.DOTweenComponent DG.Tweening.DOTween::instance
	DOTweenComponent_t48118927332C9BFAE792209EEE42AF786370B05F * ___instance_15;
	// System.Boolean DG.Tweening.DOTween::isUnityEditor
	bool ___isUnityEditor_16;
	// System.Int32 DG.Tweening.DOTween::maxActiveTweenersReached
	int32_t ___maxActiveTweenersReached_17;
	// System.Int32 DG.Tweening.DOTween::maxActiveSequencesReached
	int32_t ___maxActiveSequencesReached_18;
	// System.Collections.Generic.List`1<DG.Tweening.TweenCallback> DG.Tweening.DOTween::GizmosDelegates
	List_1_tA91E07DF8FDCABF79352C03D79A9D29DE3BBA212 * ___GizmosDelegates_19;
	// System.Boolean DG.Tweening.DOTween::initialized
	bool ___initialized_20;
	// System.Boolean DG.Tweening.DOTween::isQuitting
	bool ___isQuitting_21;

public:
	inline static int32_t get_offset_of_Version_0() { return static_cast<int32_t>(offsetof(DOTween_t6BB48F76E494B12781696AF3D0733CA8DC367E8D_StaticFields, ___Version_0)); }
	inline String_t* get_Version_0() const { return ___Version_0; }
	inline String_t** get_address_of_Version_0() { return &___Version_0; }
	inline void set_Version_0(String_t* value)
	{
		___Version_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Version_0), (void*)value);
	}

	inline static int32_t get_offset_of_useSafeMode_1() { return static_cast<int32_t>(offsetof(DOTween_t6BB48F76E494B12781696AF3D0733CA8DC367E8D_StaticFields, ___useSafeMode_1)); }
	inline bool get_useSafeMode_1() const { return ___useSafeMode_1; }
	inline bool* get_address_of_useSafeMode_1() { return &___useSafeMode_1; }
	inline void set_useSafeMode_1(bool value)
	{
		___useSafeMode_1 = value;
	}

	inline static int32_t get_offset_of_showUnityEditorReport_2() { return static_cast<int32_t>(offsetof(DOTween_t6BB48F76E494B12781696AF3D0733CA8DC367E8D_StaticFields, ___showUnityEditorReport_2)); }
	inline bool get_showUnityEditorReport_2() const { return ___showUnityEditorReport_2; }
	inline bool* get_address_of_showUnityEditorReport_2() { return &___showUnityEditorReport_2; }
	inline void set_showUnityEditorReport_2(bool value)
	{
		___showUnityEditorReport_2 = value;
	}

	inline static int32_t get_offset_of_timeScale_3() { return static_cast<int32_t>(offsetof(DOTween_t6BB48F76E494B12781696AF3D0733CA8DC367E8D_StaticFields, ___timeScale_3)); }
	inline float get_timeScale_3() const { return ___timeScale_3; }
	inline float* get_address_of_timeScale_3() { return &___timeScale_3; }
	inline void set_timeScale_3(float value)
	{
		___timeScale_3 = value;
	}

	inline static int32_t get_offset_of__logBehaviour_4() { return static_cast<int32_t>(offsetof(DOTween_t6BB48F76E494B12781696AF3D0733CA8DC367E8D_StaticFields, ____logBehaviour_4)); }
	inline int32_t get__logBehaviour_4() const { return ____logBehaviour_4; }
	inline int32_t* get_address_of__logBehaviour_4() { return &____logBehaviour_4; }
	inline void set__logBehaviour_4(int32_t value)
	{
		____logBehaviour_4 = value;
	}

	inline static int32_t get_offset_of_drawGizmos_5() { return static_cast<int32_t>(offsetof(DOTween_t6BB48F76E494B12781696AF3D0733CA8DC367E8D_StaticFields, ___drawGizmos_5)); }
	inline bool get_drawGizmos_5() const { return ___drawGizmos_5; }
	inline bool* get_address_of_drawGizmos_5() { return &___drawGizmos_5; }
	inline void set_drawGizmos_5(bool value)
	{
		___drawGizmos_5 = value;
	}

	inline static int32_t get_offset_of_defaultUpdateType_6() { return static_cast<int32_t>(offsetof(DOTween_t6BB48F76E494B12781696AF3D0733CA8DC367E8D_StaticFields, ___defaultUpdateType_6)); }
	inline int32_t get_defaultUpdateType_6() const { return ___defaultUpdateType_6; }
	inline int32_t* get_address_of_defaultUpdateType_6() { return &___defaultUpdateType_6; }
	inline void set_defaultUpdateType_6(int32_t value)
	{
		___defaultUpdateType_6 = value;
	}

	inline static int32_t get_offset_of_defaultTimeScaleIndependent_7() { return static_cast<int32_t>(offsetof(DOTween_t6BB48F76E494B12781696AF3D0733CA8DC367E8D_StaticFields, ___defaultTimeScaleIndependent_7)); }
	inline bool get_defaultTimeScaleIndependent_7() const { return ___defaultTimeScaleIndependent_7; }
	inline bool* get_address_of_defaultTimeScaleIndependent_7() { return &___defaultTimeScaleIndependent_7; }
	inline void set_defaultTimeScaleIndependent_7(bool value)
	{
		___defaultTimeScaleIndependent_7 = value;
	}

	inline static int32_t get_offset_of_defaultAutoPlay_8() { return static_cast<int32_t>(offsetof(DOTween_t6BB48F76E494B12781696AF3D0733CA8DC367E8D_StaticFields, ___defaultAutoPlay_8)); }
	inline int32_t get_defaultAutoPlay_8() const { return ___defaultAutoPlay_8; }
	inline int32_t* get_address_of_defaultAutoPlay_8() { return &___defaultAutoPlay_8; }
	inline void set_defaultAutoPlay_8(int32_t value)
	{
		___defaultAutoPlay_8 = value;
	}

	inline static int32_t get_offset_of_defaultAutoKill_9() { return static_cast<int32_t>(offsetof(DOTween_t6BB48F76E494B12781696AF3D0733CA8DC367E8D_StaticFields, ___defaultAutoKill_9)); }
	inline bool get_defaultAutoKill_9() const { return ___defaultAutoKill_9; }
	inline bool* get_address_of_defaultAutoKill_9() { return &___defaultAutoKill_9; }
	inline void set_defaultAutoKill_9(bool value)
	{
		___defaultAutoKill_9 = value;
	}

	inline static int32_t get_offset_of_defaultLoopType_10() { return static_cast<int32_t>(offsetof(DOTween_t6BB48F76E494B12781696AF3D0733CA8DC367E8D_StaticFields, ___defaultLoopType_10)); }
	inline int32_t get_defaultLoopType_10() const { return ___defaultLoopType_10; }
	inline int32_t* get_address_of_defaultLoopType_10() { return &___defaultLoopType_10; }
	inline void set_defaultLoopType_10(int32_t value)
	{
		___defaultLoopType_10 = value;
	}

	inline static int32_t get_offset_of_defaultRecyclable_11() { return static_cast<int32_t>(offsetof(DOTween_t6BB48F76E494B12781696AF3D0733CA8DC367E8D_StaticFields, ___defaultRecyclable_11)); }
	inline bool get_defaultRecyclable_11() const { return ___defaultRecyclable_11; }
	inline bool* get_address_of_defaultRecyclable_11() { return &___defaultRecyclable_11; }
	inline void set_defaultRecyclable_11(bool value)
	{
		___defaultRecyclable_11 = value;
	}

	inline static int32_t get_offset_of_defaultEaseType_12() { return static_cast<int32_t>(offsetof(DOTween_t6BB48F76E494B12781696AF3D0733CA8DC367E8D_StaticFields, ___defaultEaseType_12)); }
	inline int32_t get_defaultEaseType_12() const { return ___defaultEaseType_12; }
	inline int32_t* get_address_of_defaultEaseType_12() { return &___defaultEaseType_12; }
	inline void set_defaultEaseType_12(int32_t value)
	{
		___defaultEaseType_12 = value;
	}

	inline static int32_t get_offset_of_defaultEaseOvershootOrAmplitude_13() { return static_cast<int32_t>(offsetof(DOTween_t6BB48F76E494B12781696AF3D0733CA8DC367E8D_StaticFields, ___defaultEaseOvershootOrAmplitude_13)); }
	inline float get_defaultEaseOvershootOrAmplitude_13() const { return ___defaultEaseOvershootOrAmplitude_13; }
	inline float* get_address_of_defaultEaseOvershootOrAmplitude_13() { return &___defaultEaseOvershootOrAmplitude_13; }
	inline void set_defaultEaseOvershootOrAmplitude_13(float value)
	{
		___defaultEaseOvershootOrAmplitude_13 = value;
	}

	inline static int32_t get_offset_of_defaultEasePeriod_14() { return static_cast<int32_t>(offsetof(DOTween_t6BB48F76E494B12781696AF3D0733CA8DC367E8D_StaticFields, ___defaultEasePeriod_14)); }
	inline float get_defaultEasePeriod_14() const { return ___defaultEasePeriod_14; }
	inline float* get_address_of_defaultEasePeriod_14() { return &___defaultEasePeriod_14; }
	inline void set_defaultEasePeriod_14(float value)
	{
		___defaultEasePeriod_14 = value;
	}

	inline static int32_t get_offset_of_instance_15() { return static_cast<int32_t>(offsetof(DOTween_t6BB48F76E494B12781696AF3D0733CA8DC367E8D_StaticFields, ___instance_15)); }
	inline DOTweenComponent_t48118927332C9BFAE792209EEE42AF786370B05F * get_instance_15() const { return ___instance_15; }
	inline DOTweenComponent_t48118927332C9BFAE792209EEE42AF786370B05F ** get_address_of_instance_15() { return &___instance_15; }
	inline void set_instance_15(DOTweenComponent_t48118927332C9BFAE792209EEE42AF786370B05F * value)
	{
		___instance_15 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___instance_15), (void*)value);
	}

	inline static int32_t get_offset_of_isUnityEditor_16() { return static_cast<int32_t>(offsetof(DOTween_t6BB48F76E494B12781696AF3D0733CA8DC367E8D_StaticFields, ___isUnityEditor_16)); }
	inline bool get_isUnityEditor_16() const { return ___isUnityEditor_16; }
	inline bool* get_address_of_isUnityEditor_16() { return &___isUnityEditor_16; }
	inline void set_isUnityEditor_16(bool value)
	{
		___isUnityEditor_16 = value;
	}

	inline static int32_t get_offset_of_maxActiveTweenersReached_17() { return static_cast<int32_t>(offsetof(DOTween_t6BB48F76E494B12781696AF3D0733CA8DC367E8D_StaticFields, ___maxActiveTweenersReached_17)); }
	inline int32_t get_maxActiveTweenersReached_17() const { return ___maxActiveTweenersReached_17; }
	inline int32_t* get_address_of_maxActiveTweenersReached_17() { return &___maxActiveTweenersReached_17; }
	inline void set_maxActiveTweenersReached_17(int32_t value)
	{
		___maxActiveTweenersReached_17 = value;
	}

	inline static int32_t get_offset_of_maxActiveSequencesReached_18() { return static_cast<int32_t>(offsetof(DOTween_t6BB48F76E494B12781696AF3D0733CA8DC367E8D_StaticFields, ___maxActiveSequencesReached_18)); }
	inline int32_t get_maxActiveSequencesReached_18() const { return ___maxActiveSequencesReached_18; }
	inline int32_t* get_address_of_maxActiveSequencesReached_18() { return &___maxActiveSequencesReached_18; }
	inline void set_maxActiveSequencesReached_18(int32_t value)
	{
		___maxActiveSequencesReached_18 = value;
	}

	inline static int32_t get_offset_of_GizmosDelegates_19() { return static_cast<int32_t>(offsetof(DOTween_t6BB48F76E494B12781696AF3D0733CA8DC367E8D_StaticFields, ___GizmosDelegates_19)); }
	inline List_1_tA91E07DF8FDCABF79352C03D79A9D29DE3BBA212 * get_GizmosDelegates_19() const { return ___GizmosDelegates_19; }
	inline List_1_tA91E07DF8FDCABF79352C03D79A9D29DE3BBA212 ** get_address_of_GizmosDelegates_19() { return &___GizmosDelegates_19; }
	inline void set_GizmosDelegates_19(List_1_tA91E07DF8FDCABF79352C03D79A9D29DE3BBA212 * value)
	{
		___GizmosDelegates_19 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___GizmosDelegates_19), (void*)value);
	}

	inline static int32_t get_offset_of_initialized_20() { return static_cast<int32_t>(offsetof(DOTween_t6BB48F76E494B12781696AF3D0733CA8DC367E8D_StaticFields, ___initialized_20)); }
	inline bool get_initialized_20() const { return ___initialized_20; }
	inline bool* get_address_of_initialized_20() { return &___initialized_20; }
	inline void set_initialized_20(bool value)
	{
		___initialized_20 = value;
	}

	inline static int32_t get_offset_of_isQuitting_21() { return static_cast<int32_t>(offsetof(DOTween_t6BB48F76E494B12781696AF3D0733CA8DC367E8D_StaticFields, ___isQuitting_21)); }
	inline bool get_isQuitting_21() const { return ___isQuitting_21; }
	inline bool* get_address_of_isQuitting_21() { return &___isQuitting_21; }
	inline void set_isQuitting_21(bool value)
	{
		___isQuitting_21 = value;
	}
};


// DG.Tweening.Plugins.Options.PathOptions
struct  PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7 
{
public:
	// DG.Tweening.PathMode DG.Tweening.Plugins.Options.PathOptions::mode
	int32_t ___mode_0;
	// DG.Tweening.Plugins.Options.OrientType DG.Tweening.Plugins.Options.PathOptions::orientType
	int32_t ___orientType_1;
	// DG.Tweening.AxisConstraint DG.Tweening.Plugins.Options.PathOptions::lockPositionAxis
	int32_t ___lockPositionAxis_2;
	// DG.Tweening.AxisConstraint DG.Tweening.Plugins.Options.PathOptions::lockRotationAxis
	int32_t ___lockRotationAxis_3;
	// System.Boolean DG.Tweening.Plugins.Options.PathOptions::isClosedPath
	bool ___isClosedPath_4;
	// UnityEngine.Vector3 DG.Tweening.Plugins.Options.PathOptions::lookAtPosition
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___lookAtPosition_5;
	// UnityEngine.Transform DG.Tweening.Plugins.Options.PathOptions::lookAtTransform
	Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * ___lookAtTransform_6;
	// System.Single DG.Tweening.Plugins.Options.PathOptions::lookAhead
	float ___lookAhead_7;
	// System.Boolean DG.Tweening.Plugins.Options.PathOptions::hasCustomForwardDirection
	bool ___hasCustomForwardDirection_8;
	// UnityEngine.Quaternion DG.Tweening.Plugins.Options.PathOptions::forward
	Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  ___forward_9;
	// System.Boolean DG.Tweening.Plugins.Options.PathOptions::useLocalPosition
	bool ___useLocalPosition_10;
	// UnityEngine.Transform DG.Tweening.Plugins.Options.PathOptions::parent
	Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * ___parent_11;
	// UnityEngine.Quaternion DG.Tweening.Plugins.Options.PathOptions::startupRot
	Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  ___startupRot_12;
	// System.Single DG.Tweening.Plugins.Options.PathOptions::startupZRot
	float ___startupZRot_13;

public:
	inline static int32_t get_offset_of_mode_0() { return static_cast<int32_t>(offsetof(PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7, ___mode_0)); }
	inline int32_t get_mode_0() const { return ___mode_0; }
	inline int32_t* get_address_of_mode_0() { return &___mode_0; }
	inline void set_mode_0(int32_t value)
	{
		___mode_0 = value;
	}

	inline static int32_t get_offset_of_orientType_1() { return static_cast<int32_t>(offsetof(PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7, ___orientType_1)); }
	inline int32_t get_orientType_1() const { return ___orientType_1; }
	inline int32_t* get_address_of_orientType_1() { return &___orientType_1; }
	inline void set_orientType_1(int32_t value)
	{
		___orientType_1 = value;
	}

	inline static int32_t get_offset_of_lockPositionAxis_2() { return static_cast<int32_t>(offsetof(PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7, ___lockPositionAxis_2)); }
	inline int32_t get_lockPositionAxis_2() const { return ___lockPositionAxis_2; }
	inline int32_t* get_address_of_lockPositionAxis_2() { return &___lockPositionAxis_2; }
	inline void set_lockPositionAxis_2(int32_t value)
	{
		___lockPositionAxis_2 = value;
	}

	inline static int32_t get_offset_of_lockRotationAxis_3() { return static_cast<int32_t>(offsetof(PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7, ___lockRotationAxis_3)); }
	inline int32_t get_lockRotationAxis_3() const { return ___lockRotationAxis_3; }
	inline int32_t* get_address_of_lockRotationAxis_3() { return &___lockRotationAxis_3; }
	inline void set_lockRotationAxis_3(int32_t value)
	{
		___lockRotationAxis_3 = value;
	}

	inline static int32_t get_offset_of_isClosedPath_4() { return static_cast<int32_t>(offsetof(PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7, ___isClosedPath_4)); }
	inline bool get_isClosedPath_4() const { return ___isClosedPath_4; }
	inline bool* get_address_of_isClosedPath_4() { return &___isClosedPath_4; }
	inline void set_isClosedPath_4(bool value)
	{
		___isClosedPath_4 = value;
	}

	inline static int32_t get_offset_of_lookAtPosition_5() { return static_cast<int32_t>(offsetof(PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7, ___lookAtPosition_5)); }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  get_lookAtPosition_5() const { return ___lookAtPosition_5; }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720 * get_address_of_lookAtPosition_5() { return &___lookAtPosition_5; }
	inline void set_lookAtPosition_5(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  value)
	{
		___lookAtPosition_5 = value;
	}

	inline static int32_t get_offset_of_lookAtTransform_6() { return static_cast<int32_t>(offsetof(PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7, ___lookAtTransform_6)); }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * get_lookAtTransform_6() const { return ___lookAtTransform_6; }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA ** get_address_of_lookAtTransform_6() { return &___lookAtTransform_6; }
	inline void set_lookAtTransform_6(Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * value)
	{
		___lookAtTransform_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___lookAtTransform_6), (void*)value);
	}

	inline static int32_t get_offset_of_lookAhead_7() { return static_cast<int32_t>(offsetof(PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7, ___lookAhead_7)); }
	inline float get_lookAhead_7() const { return ___lookAhead_7; }
	inline float* get_address_of_lookAhead_7() { return &___lookAhead_7; }
	inline void set_lookAhead_7(float value)
	{
		___lookAhead_7 = value;
	}

	inline static int32_t get_offset_of_hasCustomForwardDirection_8() { return static_cast<int32_t>(offsetof(PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7, ___hasCustomForwardDirection_8)); }
	inline bool get_hasCustomForwardDirection_8() const { return ___hasCustomForwardDirection_8; }
	inline bool* get_address_of_hasCustomForwardDirection_8() { return &___hasCustomForwardDirection_8; }
	inline void set_hasCustomForwardDirection_8(bool value)
	{
		___hasCustomForwardDirection_8 = value;
	}

	inline static int32_t get_offset_of_forward_9() { return static_cast<int32_t>(offsetof(PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7, ___forward_9)); }
	inline Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  get_forward_9() const { return ___forward_9; }
	inline Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357 * get_address_of_forward_9() { return &___forward_9; }
	inline void set_forward_9(Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  value)
	{
		___forward_9 = value;
	}

	inline static int32_t get_offset_of_useLocalPosition_10() { return static_cast<int32_t>(offsetof(PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7, ___useLocalPosition_10)); }
	inline bool get_useLocalPosition_10() const { return ___useLocalPosition_10; }
	inline bool* get_address_of_useLocalPosition_10() { return &___useLocalPosition_10; }
	inline void set_useLocalPosition_10(bool value)
	{
		___useLocalPosition_10 = value;
	}

	inline static int32_t get_offset_of_parent_11() { return static_cast<int32_t>(offsetof(PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7, ___parent_11)); }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * get_parent_11() const { return ___parent_11; }
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA ** get_address_of_parent_11() { return &___parent_11; }
	inline void set_parent_11(Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * value)
	{
		___parent_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___parent_11), (void*)value);
	}

	inline static int32_t get_offset_of_startupRot_12() { return static_cast<int32_t>(offsetof(PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7, ___startupRot_12)); }
	inline Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  get_startupRot_12() const { return ___startupRot_12; }
	inline Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357 * get_address_of_startupRot_12() { return &___startupRot_12; }
	inline void set_startupRot_12(Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  value)
	{
		___startupRot_12 = value;
	}

	inline static int32_t get_offset_of_startupZRot_13() { return static_cast<int32_t>(offsetof(PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7, ___startupZRot_13)); }
	inline float get_startupZRot_13() const { return ___startupZRot_13; }
	inline float* get_address_of_startupZRot_13() { return &___startupZRot_13; }
	inline void set_startupZRot_13(float value)
	{
		___startupZRot_13 = value;
	}
};

// Native definition for P/Invoke marshalling of DG.Tweening.Plugins.Options.PathOptions
struct PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7_marshaled_pinvoke
{
	int32_t ___mode_0;
	int32_t ___orientType_1;
	int32_t ___lockPositionAxis_2;
	int32_t ___lockRotationAxis_3;
	int32_t ___isClosedPath_4;
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___lookAtPosition_5;
	Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * ___lookAtTransform_6;
	float ___lookAhead_7;
	int32_t ___hasCustomForwardDirection_8;
	Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  ___forward_9;
	int32_t ___useLocalPosition_10;
	Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * ___parent_11;
	Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  ___startupRot_12;
	float ___startupZRot_13;
};
// Native definition for COM marshalling of DG.Tweening.Plugins.Options.PathOptions
struct PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7_marshaled_com
{
	int32_t ___mode_0;
	int32_t ___orientType_1;
	int32_t ___lockPositionAxis_2;
	int32_t ___lockRotationAxis_3;
	int32_t ___isClosedPath_4;
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___lookAtPosition_5;
	Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * ___lookAtTransform_6;
	float ___lookAhead_7;
	int32_t ___hasCustomForwardDirection_8;
	Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  ___forward_9;
	int32_t ___useLocalPosition_10;
	Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * ___parent_11;
	Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  ___startupRot_12;
	float ___startupZRot_13;
};

// DG.Tweening.Plugins.Options.StringOptions
struct  StringOptions_t58D6011099873A39926A99C00EE24D0D80B231FC 
{
public:
	// System.Boolean DG.Tweening.Plugins.Options.StringOptions::richTextEnabled
	bool ___richTextEnabled_0;
	// DG.Tweening.ScrambleMode DG.Tweening.Plugins.Options.StringOptions::scrambleMode
	int32_t ___scrambleMode_1;
	// System.Char[] DG.Tweening.Plugins.Options.StringOptions::scrambledChars
	CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* ___scrambledChars_2;
	// System.Int32 DG.Tweening.Plugins.Options.StringOptions::startValueStrippedLength
	int32_t ___startValueStrippedLength_3;
	// System.Int32 DG.Tweening.Plugins.Options.StringOptions::changeValueStrippedLength
	int32_t ___changeValueStrippedLength_4;

public:
	inline static int32_t get_offset_of_richTextEnabled_0() { return static_cast<int32_t>(offsetof(StringOptions_t58D6011099873A39926A99C00EE24D0D80B231FC, ___richTextEnabled_0)); }
	inline bool get_richTextEnabled_0() const { return ___richTextEnabled_0; }
	inline bool* get_address_of_richTextEnabled_0() { return &___richTextEnabled_0; }
	inline void set_richTextEnabled_0(bool value)
	{
		___richTextEnabled_0 = value;
	}

	inline static int32_t get_offset_of_scrambleMode_1() { return static_cast<int32_t>(offsetof(StringOptions_t58D6011099873A39926A99C00EE24D0D80B231FC, ___scrambleMode_1)); }
	inline int32_t get_scrambleMode_1() const { return ___scrambleMode_1; }
	inline int32_t* get_address_of_scrambleMode_1() { return &___scrambleMode_1; }
	inline void set_scrambleMode_1(int32_t value)
	{
		___scrambleMode_1 = value;
	}

	inline static int32_t get_offset_of_scrambledChars_2() { return static_cast<int32_t>(offsetof(StringOptions_t58D6011099873A39926A99C00EE24D0D80B231FC, ___scrambledChars_2)); }
	inline CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* get_scrambledChars_2() const { return ___scrambledChars_2; }
	inline CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2** get_address_of_scrambledChars_2() { return &___scrambledChars_2; }
	inline void set_scrambledChars_2(CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* value)
	{
		___scrambledChars_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___scrambledChars_2), (void*)value);
	}

	inline static int32_t get_offset_of_startValueStrippedLength_3() { return static_cast<int32_t>(offsetof(StringOptions_t58D6011099873A39926A99C00EE24D0D80B231FC, ___startValueStrippedLength_3)); }
	inline int32_t get_startValueStrippedLength_3() const { return ___startValueStrippedLength_3; }
	inline int32_t* get_address_of_startValueStrippedLength_3() { return &___startValueStrippedLength_3; }
	inline void set_startValueStrippedLength_3(int32_t value)
	{
		___startValueStrippedLength_3 = value;
	}

	inline static int32_t get_offset_of_changeValueStrippedLength_4() { return static_cast<int32_t>(offsetof(StringOptions_t58D6011099873A39926A99C00EE24D0D80B231FC, ___changeValueStrippedLength_4)); }
	inline int32_t get_changeValueStrippedLength_4() const { return ___changeValueStrippedLength_4; }
	inline int32_t* get_address_of_changeValueStrippedLength_4() { return &___changeValueStrippedLength_4; }
	inline void set_changeValueStrippedLength_4(int32_t value)
	{
		___changeValueStrippedLength_4 = value;
	}
};

// Native definition for P/Invoke marshalling of DG.Tweening.Plugins.Options.StringOptions
struct StringOptions_t58D6011099873A39926A99C00EE24D0D80B231FC_marshaled_pinvoke
{
	int32_t ___richTextEnabled_0;
	int32_t ___scrambleMode_1;
	uint8_t* ___scrambledChars_2;
	int32_t ___startValueStrippedLength_3;
	int32_t ___changeValueStrippedLength_4;
};
// Native definition for COM marshalling of DG.Tweening.Plugins.Options.StringOptions
struct StringOptions_t58D6011099873A39926A99C00EE24D0D80B231FC_marshaled_com
{
	int32_t ___richTextEnabled_0;
	int32_t ___scrambleMode_1;
	uint8_t* ___scrambledChars_2;
	int32_t ___startValueStrippedLength_3;
	int32_t ___changeValueStrippedLength_4;
};

// DG.Tweening.Plugins.Options.Vector3ArrayOptions
struct  Vector3ArrayOptions_t3E84666D670017F133C32243F0709A3852F05257 
{
public:
	// DG.Tweening.AxisConstraint DG.Tweening.Plugins.Options.Vector3ArrayOptions::axisConstraint
	int32_t ___axisConstraint_0;
	// System.Boolean DG.Tweening.Plugins.Options.Vector3ArrayOptions::snapping
	bool ___snapping_1;
	// System.Single[] DG.Tweening.Plugins.Options.Vector3ArrayOptions::durations
	SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* ___durations_2;

public:
	inline static int32_t get_offset_of_axisConstraint_0() { return static_cast<int32_t>(offsetof(Vector3ArrayOptions_t3E84666D670017F133C32243F0709A3852F05257, ___axisConstraint_0)); }
	inline int32_t get_axisConstraint_0() const { return ___axisConstraint_0; }
	inline int32_t* get_address_of_axisConstraint_0() { return &___axisConstraint_0; }
	inline void set_axisConstraint_0(int32_t value)
	{
		___axisConstraint_0 = value;
	}

	inline static int32_t get_offset_of_snapping_1() { return static_cast<int32_t>(offsetof(Vector3ArrayOptions_t3E84666D670017F133C32243F0709A3852F05257, ___snapping_1)); }
	inline bool get_snapping_1() const { return ___snapping_1; }
	inline bool* get_address_of_snapping_1() { return &___snapping_1; }
	inline void set_snapping_1(bool value)
	{
		___snapping_1 = value;
	}

	inline static int32_t get_offset_of_durations_2() { return static_cast<int32_t>(offsetof(Vector3ArrayOptions_t3E84666D670017F133C32243F0709A3852F05257, ___durations_2)); }
	inline SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* get_durations_2() const { return ___durations_2; }
	inline SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5** get_address_of_durations_2() { return &___durations_2; }
	inline void set_durations_2(SingleU5BU5D_tA7139B7CAA40EAEF9178E2C386C8A5993754FDD5* value)
	{
		___durations_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___durations_2), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of DG.Tweening.Plugins.Options.Vector3ArrayOptions
struct Vector3ArrayOptions_t3E84666D670017F133C32243F0709A3852F05257_marshaled_pinvoke
{
	int32_t ___axisConstraint_0;
	int32_t ___snapping_1;
	Il2CppSafeArray/*NONE*/* ___durations_2;
};
// Native definition for COM marshalling of DG.Tweening.Plugins.Options.Vector3ArrayOptions
struct Vector3ArrayOptions_t3E84666D670017F133C32243F0709A3852F05257_marshaled_com
{
	int32_t ___axisConstraint_0;
	int32_t ___snapping_1;
	Il2CppSafeArray/*NONE*/* ___durations_2;
};

// DG.Tweening.Plugins.Options.VectorOptions
struct  VectorOptions_t385A0AFDBE150CC9F61EA0DC03FEA860BA5EA322 
{
public:
	// DG.Tweening.AxisConstraint DG.Tweening.Plugins.Options.VectorOptions::axisConstraint
	int32_t ___axisConstraint_0;
	// System.Boolean DG.Tweening.Plugins.Options.VectorOptions::snapping
	bool ___snapping_1;

public:
	inline static int32_t get_offset_of_axisConstraint_0() { return static_cast<int32_t>(offsetof(VectorOptions_t385A0AFDBE150CC9F61EA0DC03FEA860BA5EA322, ___axisConstraint_0)); }
	inline int32_t get_axisConstraint_0() const { return ___axisConstraint_0; }
	inline int32_t* get_address_of_axisConstraint_0() { return &___axisConstraint_0; }
	inline void set_axisConstraint_0(int32_t value)
	{
		___axisConstraint_0 = value;
	}

	inline static int32_t get_offset_of_snapping_1() { return static_cast<int32_t>(offsetof(VectorOptions_t385A0AFDBE150CC9F61EA0DC03FEA860BA5EA322, ___snapping_1)); }
	inline bool get_snapping_1() const { return ___snapping_1; }
	inline bool* get_address_of_snapping_1() { return &___snapping_1; }
	inline void set_snapping_1(bool value)
	{
		___snapping_1 = value;
	}
};

// Native definition for P/Invoke marshalling of DG.Tweening.Plugins.Options.VectorOptions
struct VectorOptions_t385A0AFDBE150CC9F61EA0DC03FEA860BA5EA322_marshaled_pinvoke
{
	int32_t ___axisConstraint_0;
	int32_t ___snapping_1;
};
// Native definition for COM marshalling of DG.Tweening.Plugins.Options.VectorOptions
struct VectorOptions_t385A0AFDBE150CC9F61EA0DC03FEA860BA5EA322_marshaled_com
{
	int32_t ___axisConstraint_0;
	int32_t ___snapping_1;
};

// System.MulticastDelegate
struct  MulticastDelegate_t  : public Delegate_t
{
public:
	// System.Delegate[] System.MulticastDelegate::delegates
	DelegateU5BU5D_tDFCDEE2A6322F96C0FE49AF47E9ADB8C4B294E86* ___delegates_11;

public:
	inline static int32_t get_offset_of_delegates_11() { return static_cast<int32_t>(offsetof(MulticastDelegate_t, ___delegates_11)); }
	inline DelegateU5BU5D_tDFCDEE2A6322F96C0FE49AF47E9ADB8C4B294E86* get_delegates_11() const { return ___delegates_11; }
	inline DelegateU5BU5D_tDFCDEE2A6322F96C0FE49AF47E9ADB8C4B294E86** get_address_of_delegates_11() { return &___delegates_11; }
	inline void set_delegates_11(DelegateU5BU5D_tDFCDEE2A6322F96C0FE49AF47E9ADB8C4B294E86* value)
	{
		___delegates_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___delegates_11), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_pinvoke : public Delegate_t_marshaled_pinvoke
{
	Delegate_t_marshaled_pinvoke** ___delegates_11;
};
// Native definition for COM marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_com : public Delegate_t_marshaled_com
{
	Delegate_t_marshaled_com** ___delegates_11;
};

// UnityEngine.Component
struct  Component_t05064EF382ABCAF4B8C94F8A350EA85184C26621  : public Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0
{
public:

public:
};


// UnityEngine.Material
struct  Material_tF7DB3BF0C24DEC2FE0CB51E5DF5053D5223C8598  : public Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0
{
public:

public:
};


// DG.Tweening.EaseFunction
struct  EaseFunction_tAC315FE3B057AC8DA87991C785F2595F3B761691  : public MulticastDelegate_t
{
public:

public:
};


// DG.Tweening.Tween
struct  Tween_t119487E0AB84EF563521F1043116BDBAE68AC437  : public ABSSequentiable_tDA1366907669973CC0BB553EF4159D45FC46A757
{
public:
	// System.Single DG.Tweening.Tween::timeScale
	float ___timeScale_4;
	// System.Boolean DG.Tweening.Tween::isBackwards
	bool ___isBackwards_5;
	// System.Object DG.Tweening.Tween::id
	RuntimeObject * ___id_6;
	// System.Object DG.Tweening.Tween::target
	RuntimeObject * ___target_7;
	// DG.Tweening.UpdateType DG.Tweening.Tween::updateType
	int32_t ___updateType_8;
	// System.Boolean DG.Tweening.Tween::isIndependentUpdate
	bool ___isIndependentUpdate_9;
	// DG.Tweening.TweenCallback DG.Tweening.Tween::onPlay
	TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * ___onPlay_10;
	// DG.Tweening.TweenCallback DG.Tweening.Tween::onPause
	TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * ___onPause_11;
	// DG.Tweening.TweenCallback DG.Tweening.Tween::onRewind
	TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * ___onRewind_12;
	// DG.Tweening.TweenCallback DG.Tweening.Tween::onUpdate
	TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * ___onUpdate_13;
	// DG.Tweening.TweenCallback DG.Tweening.Tween::onStepComplete
	TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * ___onStepComplete_14;
	// DG.Tweening.TweenCallback DG.Tweening.Tween::onComplete
	TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * ___onComplete_15;
	// DG.Tweening.TweenCallback DG.Tweening.Tween::onKill
	TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * ___onKill_16;
	// DG.Tweening.TweenCallback`1<System.Int32> DG.Tweening.Tween::onWaypointChange
	TweenCallback_1_t46CB97F053453C4F41F8AE6213792813E455DDE1 * ___onWaypointChange_17;
	// System.Boolean DG.Tweening.Tween::isFrom
	bool ___isFrom_18;
	// System.Boolean DG.Tweening.Tween::isBlendable
	bool ___isBlendable_19;
	// System.Boolean DG.Tweening.Tween::isRecyclable
	bool ___isRecyclable_20;
	// System.Boolean DG.Tweening.Tween::isSpeedBased
	bool ___isSpeedBased_21;
	// System.Boolean DG.Tweening.Tween::autoKill
	bool ___autoKill_22;
	// System.Single DG.Tweening.Tween::duration
	float ___duration_23;
	// System.Int32 DG.Tweening.Tween::loops
	int32_t ___loops_24;
	// DG.Tweening.LoopType DG.Tweening.Tween::loopType
	int32_t ___loopType_25;
	// System.Single DG.Tweening.Tween::delay
	float ___delay_26;
	// System.Boolean DG.Tweening.Tween::isRelative
	bool ___isRelative_27;
	// DG.Tweening.Ease DG.Tweening.Tween::easeType
	int32_t ___easeType_28;
	// DG.Tweening.EaseFunction DG.Tweening.Tween::customEase
	EaseFunction_tAC315FE3B057AC8DA87991C785F2595F3B761691 * ___customEase_29;
	// System.Single DG.Tweening.Tween::easeOvershootOrAmplitude
	float ___easeOvershootOrAmplitude_30;
	// System.Single DG.Tweening.Tween::easePeriod
	float ___easePeriod_31;
	// System.Type DG.Tweening.Tween::typeofT1
	Type_t * ___typeofT1_32;
	// System.Type DG.Tweening.Tween::typeofT2
	Type_t * ___typeofT2_33;
	// System.Type DG.Tweening.Tween::typeofTPlugOptions
	Type_t * ___typeofTPlugOptions_34;
	// System.Boolean DG.Tweening.Tween::active
	bool ___active_35;
	// System.Boolean DG.Tweening.Tween::isSequenced
	bool ___isSequenced_36;
	// DG.Tweening.Sequence DG.Tweening.Tween::sequenceParent
	Sequence_tA6FA099F465933113D131DDC0EECB6A19A27BCB2 * ___sequenceParent_37;
	// System.Int32 DG.Tweening.Tween::activeId
	int32_t ___activeId_38;
	// DG.Tweening.Core.Enums.SpecialStartupMode DG.Tweening.Tween::specialStartupMode
	int32_t ___specialStartupMode_39;
	// System.Boolean DG.Tweening.Tween::creationLocked
	bool ___creationLocked_40;
	// System.Boolean DG.Tweening.Tween::startupDone
	bool ___startupDone_41;
	// System.Boolean DG.Tweening.Tween::playedOnce
	bool ___playedOnce_42;
	// System.Single DG.Tweening.Tween::position
	float ___position_43;
	// System.Single DG.Tweening.Tween::fullDuration
	float ___fullDuration_44;
	// System.Int32 DG.Tweening.Tween::completedLoops
	int32_t ___completedLoops_45;
	// System.Boolean DG.Tweening.Tween::isPlaying
	bool ___isPlaying_46;
	// System.Boolean DG.Tweening.Tween::isComplete
	bool ___isComplete_47;
	// System.Single DG.Tweening.Tween::elapsedDelay
	float ___elapsedDelay_48;
	// System.Boolean DG.Tweening.Tween::delayComplete
	bool ___delayComplete_49;
	// System.Int32 DG.Tweening.Tween::miscInt
	int32_t ___miscInt_50;

public:
	inline static int32_t get_offset_of_timeScale_4() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___timeScale_4)); }
	inline float get_timeScale_4() const { return ___timeScale_4; }
	inline float* get_address_of_timeScale_4() { return &___timeScale_4; }
	inline void set_timeScale_4(float value)
	{
		___timeScale_4 = value;
	}

	inline static int32_t get_offset_of_isBackwards_5() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___isBackwards_5)); }
	inline bool get_isBackwards_5() const { return ___isBackwards_5; }
	inline bool* get_address_of_isBackwards_5() { return &___isBackwards_5; }
	inline void set_isBackwards_5(bool value)
	{
		___isBackwards_5 = value;
	}

	inline static int32_t get_offset_of_id_6() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___id_6)); }
	inline RuntimeObject * get_id_6() const { return ___id_6; }
	inline RuntimeObject ** get_address_of_id_6() { return &___id_6; }
	inline void set_id_6(RuntimeObject * value)
	{
		___id_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___id_6), (void*)value);
	}

	inline static int32_t get_offset_of_target_7() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___target_7)); }
	inline RuntimeObject * get_target_7() const { return ___target_7; }
	inline RuntimeObject ** get_address_of_target_7() { return &___target_7; }
	inline void set_target_7(RuntimeObject * value)
	{
		___target_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_7), (void*)value);
	}

	inline static int32_t get_offset_of_updateType_8() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___updateType_8)); }
	inline int32_t get_updateType_8() const { return ___updateType_8; }
	inline int32_t* get_address_of_updateType_8() { return &___updateType_8; }
	inline void set_updateType_8(int32_t value)
	{
		___updateType_8 = value;
	}

	inline static int32_t get_offset_of_isIndependentUpdate_9() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___isIndependentUpdate_9)); }
	inline bool get_isIndependentUpdate_9() const { return ___isIndependentUpdate_9; }
	inline bool* get_address_of_isIndependentUpdate_9() { return &___isIndependentUpdate_9; }
	inline void set_isIndependentUpdate_9(bool value)
	{
		___isIndependentUpdate_9 = value;
	}

	inline static int32_t get_offset_of_onPlay_10() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___onPlay_10)); }
	inline TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * get_onPlay_10() const { return ___onPlay_10; }
	inline TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 ** get_address_of_onPlay_10() { return &___onPlay_10; }
	inline void set_onPlay_10(TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * value)
	{
		___onPlay_10 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___onPlay_10), (void*)value);
	}

	inline static int32_t get_offset_of_onPause_11() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___onPause_11)); }
	inline TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * get_onPause_11() const { return ___onPause_11; }
	inline TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 ** get_address_of_onPause_11() { return &___onPause_11; }
	inline void set_onPause_11(TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * value)
	{
		___onPause_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___onPause_11), (void*)value);
	}

	inline static int32_t get_offset_of_onRewind_12() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___onRewind_12)); }
	inline TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * get_onRewind_12() const { return ___onRewind_12; }
	inline TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 ** get_address_of_onRewind_12() { return &___onRewind_12; }
	inline void set_onRewind_12(TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * value)
	{
		___onRewind_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___onRewind_12), (void*)value);
	}

	inline static int32_t get_offset_of_onUpdate_13() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___onUpdate_13)); }
	inline TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * get_onUpdate_13() const { return ___onUpdate_13; }
	inline TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 ** get_address_of_onUpdate_13() { return &___onUpdate_13; }
	inline void set_onUpdate_13(TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * value)
	{
		___onUpdate_13 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___onUpdate_13), (void*)value);
	}

	inline static int32_t get_offset_of_onStepComplete_14() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___onStepComplete_14)); }
	inline TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * get_onStepComplete_14() const { return ___onStepComplete_14; }
	inline TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 ** get_address_of_onStepComplete_14() { return &___onStepComplete_14; }
	inline void set_onStepComplete_14(TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * value)
	{
		___onStepComplete_14 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___onStepComplete_14), (void*)value);
	}

	inline static int32_t get_offset_of_onComplete_15() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___onComplete_15)); }
	inline TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * get_onComplete_15() const { return ___onComplete_15; }
	inline TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 ** get_address_of_onComplete_15() { return &___onComplete_15; }
	inline void set_onComplete_15(TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * value)
	{
		___onComplete_15 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___onComplete_15), (void*)value);
	}

	inline static int32_t get_offset_of_onKill_16() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___onKill_16)); }
	inline TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * get_onKill_16() const { return ___onKill_16; }
	inline TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 ** get_address_of_onKill_16() { return &___onKill_16; }
	inline void set_onKill_16(TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * value)
	{
		___onKill_16 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___onKill_16), (void*)value);
	}

	inline static int32_t get_offset_of_onWaypointChange_17() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___onWaypointChange_17)); }
	inline TweenCallback_1_t46CB97F053453C4F41F8AE6213792813E455DDE1 * get_onWaypointChange_17() const { return ___onWaypointChange_17; }
	inline TweenCallback_1_t46CB97F053453C4F41F8AE6213792813E455DDE1 ** get_address_of_onWaypointChange_17() { return &___onWaypointChange_17; }
	inline void set_onWaypointChange_17(TweenCallback_1_t46CB97F053453C4F41F8AE6213792813E455DDE1 * value)
	{
		___onWaypointChange_17 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___onWaypointChange_17), (void*)value);
	}

	inline static int32_t get_offset_of_isFrom_18() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___isFrom_18)); }
	inline bool get_isFrom_18() const { return ___isFrom_18; }
	inline bool* get_address_of_isFrom_18() { return &___isFrom_18; }
	inline void set_isFrom_18(bool value)
	{
		___isFrom_18 = value;
	}

	inline static int32_t get_offset_of_isBlendable_19() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___isBlendable_19)); }
	inline bool get_isBlendable_19() const { return ___isBlendable_19; }
	inline bool* get_address_of_isBlendable_19() { return &___isBlendable_19; }
	inline void set_isBlendable_19(bool value)
	{
		___isBlendable_19 = value;
	}

	inline static int32_t get_offset_of_isRecyclable_20() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___isRecyclable_20)); }
	inline bool get_isRecyclable_20() const { return ___isRecyclable_20; }
	inline bool* get_address_of_isRecyclable_20() { return &___isRecyclable_20; }
	inline void set_isRecyclable_20(bool value)
	{
		___isRecyclable_20 = value;
	}

	inline static int32_t get_offset_of_isSpeedBased_21() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___isSpeedBased_21)); }
	inline bool get_isSpeedBased_21() const { return ___isSpeedBased_21; }
	inline bool* get_address_of_isSpeedBased_21() { return &___isSpeedBased_21; }
	inline void set_isSpeedBased_21(bool value)
	{
		___isSpeedBased_21 = value;
	}

	inline static int32_t get_offset_of_autoKill_22() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___autoKill_22)); }
	inline bool get_autoKill_22() const { return ___autoKill_22; }
	inline bool* get_address_of_autoKill_22() { return &___autoKill_22; }
	inline void set_autoKill_22(bool value)
	{
		___autoKill_22 = value;
	}

	inline static int32_t get_offset_of_duration_23() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___duration_23)); }
	inline float get_duration_23() const { return ___duration_23; }
	inline float* get_address_of_duration_23() { return &___duration_23; }
	inline void set_duration_23(float value)
	{
		___duration_23 = value;
	}

	inline static int32_t get_offset_of_loops_24() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___loops_24)); }
	inline int32_t get_loops_24() const { return ___loops_24; }
	inline int32_t* get_address_of_loops_24() { return &___loops_24; }
	inline void set_loops_24(int32_t value)
	{
		___loops_24 = value;
	}

	inline static int32_t get_offset_of_loopType_25() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___loopType_25)); }
	inline int32_t get_loopType_25() const { return ___loopType_25; }
	inline int32_t* get_address_of_loopType_25() { return &___loopType_25; }
	inline void set_loopType_25(int32_t value)
	{
		___loopType_25 = value;
	}

	inline static int32_t get_offset_of_delay_26() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___delay_26)); }
	inline float get_delay_26() const { return ___delay_26; }
	inline float* get_address_of_delay_26() { return &___delay_26; }
	inline void set_delay_26(float value)
	{
		___delay_26 = value;
	}

	inline static int32_t get_offset_of_isRelative_27() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___isRelative_27)); }
	inline bool get_isRelative_27() const { return ___isRelative_27; }
	inline bool* get_address_of_isRelative_27() { return &___isRelative_27; }
	inline void set_isRelative_27(bool value)
	{
		___isRelative_27 = value;
	}

	inline static int32_t get_offset_of_easeType_28() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___easeType_28)); }
	inline int32_t get_easeType_28() const { return ___easeType_28; }
	inline int32_t* get_address_of_easeType_28() { return &___easeType_28; }
	inline void set_easeType_28(int32_t value)
	{
		___easeType_28 = value;
	}

	inline static int32_t get_offset_of_customEase_29() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___customEase_29)); }
	inline EaseFunction_tAC315FE3B057AC8DA87991C785F2595F3B761691 * get_customEase_29() const { return ___customEase_29; }
	inline EaseFunction_tAC315FE3B057AC8DA87991C785F2595F3B761691 ** get_address_of_customEase_29() { return &___customEase_29; }
	inline void set_customEase_29(EaseFunction_tAC315FE3B057AC8DA87991C785F2595F3B761691 * value)
	{
		___customEase_29 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___customEase_29), (void*)value);
	}

	inline static int32_t get_offset_of_easeOvershootOrAmplitude_30() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___easeOvershootOrAmplitude_30)); }
	inline float get_easeOvershootOrAmplitude_30() const { return ___easeOvershootOrAmplitude_30; }
	inline float* get_address_of_easeOvershootOrAmplitude_30() { return &___easeOvershootOrAmplitude_30; }
	inline void set_easeOvershootOrAmplitude_30(float value)
	{
		___easeOvershootOrAmplitude_30 = value;
	}

	inline static int32_t get_offset_of_easePeriod_31() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___easePeriod_31)); }
	inline float get_easePeriod_31() const { return ___easePeriod_31; }
	inline float* get_address_of_easePeriod_31() { return &___easePeriod_31; }
	inline void set_easePeriod_31(float value)
	{
		___easePeriod_31 = value;
	}

	inline static int32_t get_offset_of_typeofT1_32() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___typeofT1_32)); }
	inline Type_t * get_typeofT1_32() const { return ___typeofT1_32; }
	inline Type_t ** get_address_of_typeofT1_32() { return &___typeofT1_32; }
	inline void set_typeofT1_32(Type_t * value)
	{
		___typeofT1_32 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___typeofT1_32), (void*)value);
	}

	inline static int32_t get_offset_of_typeofT2_33() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___typeofT2_33)); }
	inline Type_t * get_typeofT2_33() const { return ___typeofT2_33; }
	inline Type_t ** get_address_of_typeofT2_33() { return &___typeofT2_33; }
	inline void set_typeofT2_33(Type_t * value)
	{
		___typeofT2_33 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___typeofT2_33), (void*)value);
	}

	inline static int32_t get_offset_of_typeofTPlugOptions_34() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___typeofTPlugOptions_34)); }
	inline Type_t * get_typeofTPlugOptions_34() const { return ___typeofTPlugOptions_34; }
	inline Type_t ** get_address_of_typeofTPlugOptions_34() { return &___typeofTPlugOptions_34; }
	inline void set_typeofTPlugOptions_34(Type_t * value)
	{
		___typeofTPlugOptions_34 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___typeofTPlugOptions_34), (void*)value);
	}

	inline static int32_t get_offset_of_active_35() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___active_35)); }
	inline bool get_active_35() const { return ___active_35; }
	inline bool* get_address_of_active_35() { return &___active_35; }
	inline void set_active_35(bool value)
	{
		___active_35 = value;
	}

	inline static int32_t get_offset_of_isSequenced_36() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___isSequenced_36)); }
	inline bool get_isSequenced_36() const { return ___isSequenced_36; }
	inline bool* get_address_of_isSequenced_36() { return &___isSequenced_36; }
	inline void set_isSequenced_36(bool value)
	{
		___isSequenced_36 = value;
	}

	inline static int32_t get_offset_of_sequenceParent_37() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___sequenceParent_37)); }
	inline Sequence_tA6FA099F465933113D131DDC0EECB6A19A27BCB2 * get_sequenceParent_37() const { return ___sequenceParent_37; }
	inline Sequence_tA6FA099F465933113D131DDC0EECB6A19A27BCB2 ** get_address_of_sequenceParent_37() { return &___sequenceParent_37; }
	inline void set_sequenceParent_37(Sequence_tA6FA099F465933113D131DDC0EECB6A19A27BCB2 * value)
	{
		___sequenceParent_37 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___sequenceParent_37), (void*)value);
	}

	inline static int32_t get_offset_of_activeId_38() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___activeId_38)); }
	inline int32_t get_activeId_38() const { return ___activeId_38; }
	inline int32_t* get_address_of_activeId_38() { return &___activeId_38; }
	inline void set_activeId_38(int32_t value)
	{
		___activeId_38 = value;
	}

	inline static int32_t get_offset_of_specialStartupMode_39() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___specialStartupMode_39)); }
	inline int32_t get_specialStartupMode_39() const { return ___specialStartupMode_39; }
	inline int32_t* get_address_of_specialStartupMode_39() { return &___specialStartupMode_39; }
	inline void set_specialStartupMode_39(int32_t value)
	{
		___specialStartupMode_39 = value;
	}

	inline static int32_t get_offset_of_creationLocked_40() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___creationLocked_40)); }
	inline bool get_creationLocked_40() const { return ___creationLocked_40; }
	inline bool* get_address_of_creationLocked_40() { return &___creationLocked_40; }
	inline void set_creationLocked_40(bool value)
	{
		___creationLocked_40 = value;
	}

	inline static int32_t get_offset_of_startupDone_41() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___startupDone_41)); }
	inline bool get_startupDone_41() const { return ___startupDone_41; }
	inline bool* get_address_of_startupDone_41() { return &___startupDone_41; }
	inline void set_startupDone_41(bool value)
	{
		___startupDone_41 = value;
	}

	inline static int32_t get_offset_of_playedOnce_42() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___playedOnce_42)); }
	inline bool get_playedOnce_42() const { return ___playedOnce_42; }
	inline bool* get_address_of_playedOnce_42() { return &___playedOnce_42; }
	inline void set_playedOnce_42(bool value)
	{
		___playedOnce_42 = value;
	}

	inline static int32_t get_offset_of_position_43() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___position_43)); }
	inline float get_position_43() const { return ___position_43; }
	inline float* get_address_of_position_43() { return &___position_43; }
	inline void set_position_43(float value)
	{
		___position_43 = value;
	}

	inline static int32_t get_offset_of_fullDuration_44() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___fullDuration_44)); }
	inline float get_fullDuration_44() const { return ___fullDuration_44; }
	inline float* get_address_of_fullDuration_44() { return &___fullDuration_44; }
	inline void set_fullDuration_44(float value)
	{
		___fullDuration_44 = value;
	}

	inline static int32_t get_offset_of_completedLoops_45() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___completedLoops_45)); }
	inline int32_t get_completedLoops_45() const { return ___completedLoops_45; }
	inline int32_t* get_address_of_completedLoops_45() { return &___completedLoops_45; }
	inline void set_completedLoops_45(int32_t value)
	{
		___completedLoops_45 = value;
	}

	inline static int32_t get_offset_of_isPlaying_46() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___isPlaying_46)); }
	inline bool get_isPlaying_46() const { return ___isPlaying_46; }
	inline bool* get_address_of_isPlaying_46() { return &___isPlaying_46; }
	inline void set_isPlaying_46(bool value)
	{
		___isPlaying_46 = value;
	}

	inline static int32_t get_offset_of_isComplete_47() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___isComplete_47)); }
	inline bool get_isComplete_47() const { return ___isComplete_47; }
	inline bool* get_address_of_isComplete_47() { return &___isComplete_47; }
	inline void set_isComplete_47(bool value)
	{
		___isComplete_47 = value;
	}

	inline static int32_t get_offset_of_elapsedDelay_48() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___elapsedDelay_48)); }
	inline float get_elapsedDelay_48() const { return ___elapsedDelay_48; }
	inline float* get_address_of_elapsedDelay_48() { return &___elapsedDelay_48; }
	inline void set_elapsedDelay_48(float value)
	{
		___elapsedDelay_48 = value;
	}

	inline static int32_t get_offset_of_delayComplete_49() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___delayComplete_49)); }
	inline bool get_delayComplete_49() const { return ___delayComplete_49; }
	inline bool* get_address_of_delayComplete_49() { return &___delayComplete_49; }
	inline void set_delayComplete_49(bool value)
	{
		___delayComplete_49 = value;
	}

	inline static int32_t get_offset_of_miscInt_50() { return static_cast<int32_t>(offsetof(Tween_t119487E0AB84EF563521F1043116BDBAE68AC437, ___miscInt_50)); }
	inline int32_t get_miscInt_50() const { return ___miscInt_50; }
	inline int32_t* get_address_of_miscInt_50() { return &___miscInt_50; }
	inline void set_miscInt_50(int32_t value)
	{
		___miscInt_50 = value;
	}
};


// DG.Tweening.TweenCallback
struct  TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83  : public MulticastDelegate_t
{
public:

public:
};


// DG.Tweening.TweenCallback`1<System.Int32>
struct  TweenCallback_1_t46CB97F053453C4F41F8AE6213792813E455DDE1  : public MulticastDelegate_t
{
public:

public:
};


// System.AsyncCallback
struct  AsyncCallback_t3F3DA3BEDAEE81DD1D24125DF8EB30E85EE14DA4  : public MulticastDelegate_t
{
public:

public:
};


// UnityEngine.Behaviour
struct  Behaviour_tBDC7E9C3C898AD8348891B82D3E345801D920CA8  : public Component_t05064EF382ABCAF4B8C94F8A350EA85184C26621
{
public:

public:
};


// UnityEngine.Rigidbody
struct  Rigidbody_tE0A58EE5A1F7DC908EFFB4F0D795AC9552A750A5  : public Component_t05064EF382ABCAF4B8C94F8A350EA85184C26621
{
public:

public:
};


// UnityEngine.Transform
struct  Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA  : public Component_t05064EF382ABCAF4B8C94F8A350EA85184C26621
{
public:

public:
};


// DG.Tweening.Sequence
struct  Sequence_tA6FA099F465933113D131DDC0EECB6A19A27BCB2  : public Tween_t119487E0AB84EF563521F1043116BDBAE68AC437
{
public:
	// System.Collections.Generic.List`1<DG.Tweening.Tween> DG.Tweening.Sequence::sequencedTweens
	List_1_t57BB69F1AC3759152D9E750F6120000328D367B8 * ___sequencedTweens_51;
	// System.Collections.Generic.List`1<DG.Tweening.Core.ABSSequentiable> DG.Tweening.Sequence::_sequencedObjs
	List_1_t2E181C700331B7635DE1FD6A98300CEAEFABC4ED * ____sequencedObjs_52;
	// System.Single DG.Tweening.Sequence::lastTweenInsertTime
	float ___lastTweenInsertTime_53;

public:
	inline static int32_t get_offset_of_sequencedTweens_51() { return static_cast<int32_t>(offsetof(Sequence_tA6FA099F465933113D131DDC0EECB6A19A27BCB2, ___sequencedTweens_51)); }
	inline List_1_t57BB69F1AC3759152D9E750F6120000328D367B8 * get_sequencedTweens_51() const { return ___sequencedTweens_51; }
	inline List_1_t57BB69F1AC3759152D9E750F6120000328D367B8 ** get_address_of_sequencedTweens_51() { return &___sequencedTweens_51; }
	inline void set_sequencedTweens_51(List_1_t57BB69F1AC3759152D9E750F6120000328D367B8 * value)
	{
		___sequencedTweens_51 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___sequencedTweens_51), (void*)value);
	}

	inline static int32_t get_offset_of__sequencedObjs_52() { return static_cast<int32_t>(offsetof(Sequence_tA6FA099F465933113D131DDC0EECB6A19A27BCB2, ____sequencedObjs_52)); }
	inline List_1_t2E181C700331B7635DE1FD6A98300CEAEFABC4ED * get__sequencedObjs_52() const { return ____sequencedObjs_52; }
	inline List_1_t2E181C700331B7635DE1FD6A98300CEAEFABC4ED ** get_address_of__sequencedObjs_52() { return &____sequencedObjs_52; }
	inline void set__sequencedObjs_52(List_1_t2E181C700331B7635DE1FD6A98300CEAEFABC4ED * value)
	{
		____sequencedObjs_52 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____sequencedObjs_52), (void*)value);
	}

	inline static int32_t get_offset_of_lastTweenInsertTime_53() { return static_cast<int32_t>(offsetof(Sequence_tA6FA099F465933113D131DDC0EECB6A19A27BCB2, ___lastTweenInsertTime_53)); }
	inline float get_lastTweenInsertTime_53() const { return ___lastTweenInsertTime_53; }
	inline float* get_address_of_lastTweenInsertTime_53() { return &___lastTweenInsertTime_53; }
	inline void set_lastTweenInsertTime_53(float value)
	{
		___lastTweenInsertTime_53 = value;
	}
};


// DG.Tweening.Tweener
struct  Tweener_t9B2A5E94EE6D11F7607E58AE4E37186FF63587C8  : public Tween_t119487E0AB84EF563521F1043116BDBAE68AC437
{
public:
	// System.Boolean DG.Tweening.Tweener::hasManuallySetStartValue
	bool ___hasManuallySetStartValue_51;
	// System.Boolean DG.Tweening.Tweener::isFromAllowed
	bool ___isFromAllowed_52;

public:
	inline static int32_t get_offset_of_hasManuallySetStartValue_51() { return static_cast<int32_t>(offsetof(Tweener_t9B2A5E94EE6D11F7607E58AE4E37186FF63587C8, ___hasManuallySetStartValue_51)); }
	inline bool get_hasManuallySetStartValue_51() const { return ___hasManuallySetStartValue_51; }
	inline bool* get_address_of_hasManuallySetStartValue_51() { return &___hasManuallySetStartValue_51; }
	inline void set_hasManuallySetStartValue_51(bool value)
	{
		___hasManuallySetStartValue_51 = value;
	}

	inline static int32_t get_offset_of_isFromAllowed_52() { return static_cast<int32_t>(offsetof(Tweener_t9B2A5E94EE6D11F7607E58AE4E37186FF63587C8, ___isFromAllowed_52)); }
	inline bool get_isFromAllowed_52() const { return ___isFromAllowed_52; }
	inline bool* get_address_of_isFromAllowed_52() { return &___isFromAllowed_52; }
	inline void set_isFromAllowed_52(bool value)
	{
		___isFromAllowed_52 = value;
	}
};


// UnityEngine.Camera
struct  Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34  : public Behaviour_tBDC7E9C3C898AD8348891B82D3E345801D920CA8
{
public:

public:
};

struct Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34_StaticFields
{
public:
	// UnityEngine.Camera_CameraCallback UnityEngine.Camera::onPreCull
	CameraCallback_t8BBB42AA08D7498DFC11F4128117055BC7F0B9D0 * ___onPreCull_4;
	// UnityEngine.Camera_CameraCallback UnityEngine.Camera::onPreRender
	CameraCallback_t8BBB42AA08D7498DFC11F4128117055BC7F0B9D0 * ___onPreRender_5;
	// UnityEngine.Camera_CameraCallback UnityEngine.Camera::onPostRender
	CameraCallback_t8BBB42AA08D7498DFC11F4128117055BC7F0B9D0 * ___onPostRender_6;

public:
	inline static int32_t get_offset_of_onPreCull_4() { return static_cast<int32_t>(offsetof(Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34_StaticFields, ___onPreCull_4)); }
	inline CameraCallback_t8BBB42AA08D7498DFC11F4128117055BC7F0B9D0 * get_onPreCull_4() const { return ___onPreCull_4; }
	inline CameraCallback_t8BBB42AA08D7498DFC11F4128117055BC7F0B9D0 ** get_address_of_onPreCull_4() { return &___onPreCull_4; }
	inline void set_onPreCull_4(CameraCallback_t8BBB42AA08D7498DFC11F4128117055BC7F0B9D0 * value)
	{
		___onPreCull_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___onPreCull_4), (void*)value);
	}

	inline static int32_t get_offset_of_onPreRender_5() { return static_cast<int32_t>(offsetof(Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34_StaticFields, ___onPreRender_5)); }
	inline CameraCallback_t8BBB42AA08D7498DFC11F4128117055BC7F0B9D0 * get_onPreRender_5() const { return ___onPreRender_5; }
	inline CameraCallback_t8BBB42AA08D7498DFC11F4128117055BC7F0B9D0 ** get_address_of_onPreRender_5() { return &___onPreRender_5; }
	inline void set_onPreRender_5(CameraCallback_t8BBB42AA08D7498DFC11F4128117055BC7F0B9D0 * value)
	{
		___onPreRender_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___onPreRender_5), (void*)value);
	}

	inline static int32_t get_offset_of_onPostRender_6() { return static_cast<int32_t>(offsetof(Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34_StaticFields, ___onPostRender_6)); }
	inline CameraCallback_t8BBB42AA08D7498DFC11F4128117055BC7F0B9D0 * get_onPostRender_6() const { return ___onPostRender_6; }
	inline CameraCallback_t8BBB42AA08D7498DFC11F4128117055BC7F0B9D0 ** get_address_of_onPostRender_6() { return &___onPostRender_6; }
	inline void set_onPostRender_6(CameraCallback_t8BBB42AA08D7498DFC11F4128117055BC7F0B9D0 * value)
	{
		___onPostRender_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___onPostRender_6), (void*)value);
	}
};


// DG.Tweening.Core.TweenerCore`3<System.String,System.String,DG.Tweening.Plugins.Options.StringOptions>
struct  TweenerCore_3_t5CC4896707276A1DD128E986B753C9447C7E8FA8  : public Tweener_t9B2A5E94EE6D11F7607E58AE4E37186FF63587C8
{
public:
	// T2 DG.Tweening.Core.TweenerCore`3::startValue
	String_t* ___startValue_53;
	// T2 DG.Tweening.Core.TweenerCore`3::endValue
	String_t* ___endValue_54;
	// T2 DG.Tweening.Core.TweenerCore`3::changeValue
	String_t* ___changeValue_55;
	// TPlugOptions DG.Tweening.Core.TweenerCore`3::plugOptions
	StringOptions_t58D6011099873A39926A99C00EE24D0D80B231FC  ___plugOptions_56;
	// DG.Tweening.Core.DOGetter`1<T1> DG.Tweening.Core.TweenerCore`3::getter
	DOGetter_1_t8487F7D92634187297C55D53D69038ECF0AF1A5B * ___getter_57;
	// DG.Tweening.Core.DOSetter`1<T1> DG.Tweening.Core.TweenerCore`3::setter
	DOSetter_1_t4596A2038D23C79F7EECD86309BBCD2D10AEEFA6 * ___setter_58;
	// DG.Tweening.Plugins.Core.ABSTweenPlugin`3<T1,T2,TPlugOptions> DG.Tweening.Core.TweenerCore`3::tweenPlugin
	ABSTweenPlugin_3_t9D226D0B072F9EA7690FA7A649856709CE00D725 * ___tweenPlugin_59;

public:
	inline static int32_t get_offset_of_startValue_53() { return static_cast<int32_t>(offsetof(TweenerCore_3_t5CC4896707276A1DD128E986B753C9447C7E8FA8, ___startValue_53)); }
	inline String_t* get_startValue_53() const { return ___startValue_53; }
	inline String_t** get_address_of_startValue_53() { return &___startValue_53; }
	inline void set_startValue_53(String_t* value)
	{
		___startValue_53 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___startValue_53), (void*)value);
	}

	inline static int32_t get_offset_of_endValue_54() { return static_cast<int32_t>(offsetof(TweenerCore_3_t5CC4896707276A1DD128E986B753C9447C7E8FA8, ___endValue_54)); }
	inline String_t* get_endValue_54() const { return ___endValue_54; }
	inline String_t** get_address_of_endValue_54() { return &___endValue_54; }
	inline void set_endValue_54(String_t* value)
	{
		___endValue_54 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___endValue_54), (void*)value);
	}

	inline static int32_t get_offset_of_changeValue_55() { return static_cast<int32_t>(offsetof(TweenerCore_3_t5CC4896707276A1DD128E986B753C9447C7E8FA8, ___changeValue_55)); }
	inline String_t* get_changeValue_55() const { return ___changeValue_55; }
	inline String_t** get_address_of_changeValue_55() { return &___changeValue_55; }
	inline void set_changeValue_55(String_t* value)
	{
		___changeValue_55 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___changeValue_55), (void*)value);
	}

	inline static int32_t get_offset_of_plugOptions_56() { return static_cast<int32_t>(offsetof(TweenerCore_3_t5CC4896707276A1DD128E986B753C9447C7E8FA8, ___plugOptions_56)); }
	inline StringOptions_t58D6011099873A39926A99C00EE24D0D80B231FC  get_plugOptions_56() const { return ___plugOptions_56; }
	inline StringOptions_t58D6011099873A39926A99C00EE24D0D80B231FC * get_address_of_plugOptions_56() { return &___plugOptions_56; }
	inline void set_plugOptions_56(StringOptions_t58D6011099873A39926A99C00EE24D0D80B231FC  value)
	{
		___plugOptions_56 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___plugOptions_56))->___scrambledChars_2), (void*)NULL);
	}

	inline static int32_t get_offset_of_getter_57() { return static_cast<int32_t>(offsetof(TweenerCore_3_t5CC4896707276A1DD128E986B753C9447C7E8FA8, ___getter_57)); }
	inline DOGetter_1_t8487F7D92634187297C55D53D69038ECF0AF1A5B * get_getter_57() const { return ___getter_57; }
	inline DOGetter_1_t8487F7D92634187297C55D53D69038ECF0AF1A5B ** get_address_of_getter_57() { return &___getter_57; }
	inline void set_getter_57(DOGetter_1_t8487F7D92634187297C55D53D69038ECF0AF1A5B * value)
	{
		___getter_57 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___getter_57), (void*)value);
	}

	inline static int32_t get_offset_of_setter_58() { return static_cast<int32_t>(offsetof(TweenerCore_3_t5CC4896707276A1DD128E986B753C9447C7E8FA8, ___setter_58)); }
	inline DOSetter_1_t4596A2038D23C79F7EECD86309BBCD2D10AEEFA6 * get_setter_58() const { return ___setter_58; }
	inline DOSetter_1_t4596A2038D23C79F7EECD86309BBCD2D10AEEFA6 ** get_address_of_setter_58() { return &___setter_58; }
	inline void set_setter_58(DOSetter_1_t4596A2038D23C79F7EECD86309BBCD2D10AEEFA6 * value)
	{
		___setter_58 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___setter_58), (void*)value);
	}

	inline static int32_t get_offset_of_tweenPlugin_59() { return static_cast<int32_t>(offsetof(TweenerCore_3_t5CC4896707276A1DD128E986B753C9447C7E8FA8, ___tweenPlugin_59)); }
	inline ABSTweenPlugin_3_t9D226D0B072F9EA7690FA7A649856709CE00D725 * get_tweenPlugin_59() const { return ___tweenPlugin_59; }
	inline ABSTweenPlugin_3_t9D226D0B072F9EA7690FA7A649856709CE00D725 ** get_address_of_tweenPlugin_59() { return &___tweenPlugin_59; }
	inline void set_tweenPlugin_59(ABSTweenPlugin_3_t9D226D0B072F9EA7690FA7A649856709CE00D725 * value)
	{
		___tweenPlugin_59 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___tweenPlugin_59), (void*)value);
	}
};


// DG.Tweening.Core.TweenerCore`3<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions>
struct  TweenerCore_3_t135A028153B5C8F7030BB331039A6C1C8B41AC65  : public Tweener_t9B2A5E94EE6D11F7607E58AE4E37186FF63587C8
{
public:
	// T2 DG.Tweening.Core.TweenerCore`3::startValue
	Color_t119BCA590009762C7223FDD3AF9706653AC84ED2  ___startValue_53;
	// T2 DG.Tweening.Core.TweenerCore`3::endValue
	Color_t119BCA590009762C7223FDD3AF9706653AC84ED2  ___endValue_54;
	// T2 DG.Tweening.Core.TweenerCore`3::changeValue
	Color_t119BCA590009762C7223FDD3AF9706653AC84ED2  ___changeValue_55;
	// TPlugOptions DG.Tweening.Core.TweenerCore`3::plugOptions
	ColorOptions_tD57E512D2F4329BEE7EAEE0D1B2C4A0683D288DA  ___plugOptions_56;
	// DG.Tweening.Core.DOGetter`1<T1> DG.Tweening.Core.TweenerCore`3::getter
	DOGetter_1_t1CBCAE9C5512210401294F691A3DA53221D4D519 * ___getter_57;
	// DG.Tweening.Core.DOSetter`1<T1> DG.Tweening.Core.TweenerCore`3::setter
	DOSetter_1_t15DB9D23118C9930751CE2A17C20F7E010D0C9D1 * ___setter_58;
	// DG.Tweening.Plugins.Core.ABSTweenPlugin`3<T1,T2,TPlugOptions> DG.Tweening.Core.TweenerCore`3::tweenPlugin
	ABSTweenPlugin_3_tD58649751AD5C680679FE9F34E72C693082D2950 * ___tweenPlugin_59;

public:
	inline static int32_t get_offset_of_startValue_53() { return static_cast<int32_t>(offsetof(TweenerCore_3_t135A028153B5C8F7030BB331039A6C1C8B41AC65, ___startValue_53)); }
	inline Color_t119BCA590009762C7223FDD3AF9706653AC84ED2  get_startValue_53() const { return ___startValue_53; }
	inline Color_t119BCA590009762C7223FDD3AF9706653AC84ED2 * get_address_of_startValue_53() { return &___startValue_53; }
	inline void set_startValue_53(Color_t119BCA590009762C7223FDD3AF9706653AC84ED2  value)
	{
		___startValue_53 = value;
	}

	inline static int32_t get_offset_of_endValue_54() { return static_cast<int32_t>(offsetof(TweenerCore_3_t135A028153B5C8F7030BB331039A6C1C8B41AC65, ___endValue_54)); }
	inline Color_t119BCA590009762C7223FDD3AF9706653AC84ED2  get_endValue_54() const { return ___endValue_54; }
	inline Color_t119BCA590009762C7223FDD3AF9706653AC84ED2 * get_address_of_endValue_54() { return &___endValue_54; }
	inline void set_endValue_54(Color_t119BCA590009762C7223FDD3AF9706653AC84ED2  value)
	{
		___endValue_54 = value;
	}

	inline static int32_t get_offset_of_changeValue_55() { return static_cast<int32_t>(offsetof(TweenerCore_3_t135A028153B5C8F7030BB331039A6C1C8B41AC65, ___changeValue_55)); }
	inline Color_t119BCA590009762C7223FDD3AF9706653AC84ED2  get_changeValue_55() const { return ___changeValue_55; }
	inline Color_t119BCA590009762C7223FDD3AF9706653AC84ED2 * get_address_of_changeValue_55() { return &___changeValue_55; }
	inline void set_changeValue_55(Color_t119BCA590009762C7223FDD3AF9706653AC84ED2  value)
	{
		___changeValue_55 = value;
	}

	inline static int32_t get_offset_of_plugOptions_56() { return static_cast<int32_t>(offsetof(TweenerCore_3_t135A028153B5C8F7030BB331039A6C1C8B41AC65, ___plugOptions_56)); }
	inline ColorOptions_tD57E512D2F4329BEE7EAEE0D1B2C4A0683D288DA  get_plugOptions_56() const { return ___plugOptions_56; }
	inline ColorOptions_tD57E512D2F4329BEE7EAEE0D1B2C4A0683D288DA * get_address_of_plugOptions_56() { return &___plugOptions_56; }
	inline void set_plugOptions_56(ColorOptions_tD57E512D2F4329BEE7EAEE0D1B2C4A0683D288DA  value)
	{
		___plugOptions_56 = value;
	}

	inline static int32_t get_offset_of_getter_57() { return static_cast<int32_t>(offsetof(TweenerCore_3_t135A028153B5C8F7030BB331039A6C1C8B41AC65, ___getter_57)); }
	inline DOGetter_1_t1CBCAE9C5512210401294F691A3DA53221D4D519 * get_getter_57() const { return ___getter_57; }
	inline DOGetter_1_t1CBCAE9C5512210401294F691A3DA53221D4D519 ** get_address_of_getter_57() { return &___getter_57; }
	inline void set_getter_57(DOGetter_1_t1CBCAE9C5512210401294F691A3DA53221D4D519 * value)
	{
		___getter_57 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___getter_57), (void*)value);
	}

	inline static int32_t get_offset_of_setter_58() { return static_cast<int32_t>(offsetof(TweenerCore_3_t135A028153B5C8F7030BB331039A6C1C8B41AC65, ___setter_58)); }
	inline DOSetter_1_t15DB9D23118C9930751CE2A17C20F7E010D0C9D1 * get_setter_58() const { return ___setter_58; }
	inline DOSetter_1_t15DB9D23118C9930751CE2A17C20F7E010D0C9D1 ** get_address_of_setter_58() { return &___setter_58; }
	inline void set_setter_58(DOSetter_1_t15DB9D23118C9930751CE2A17C20F7E010D0C9D1 * value)
	{
		___setter_58 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___setter_58), (void*)value);
	}

	inline static int32_t get_offset_of_tweenPlugin_59() { return static_cast<int32_t>(offsetof(TweenerCore_3_t135A028153B5C8F7030BB331039A6C1C8B41AC65, ___tweenPlugin_59)); }
	inline ABSTweenPlugin_3_tD58649751AD5C680679FE9F34E72C693082D2950 * get_tweenPlugin_59() const { return ___tweenPlugin_59; }
	inline ABSTweenPlugin_3_tD58649751AD5C680679FE9F34E72C693082D2950 ** get_address_of_tweenPlugin_59() { return &___tweenPlugin_59; }
	inline void set_tweenPlugin_59(ABSTweenPlugin_3_tD58649751AD5C680679FE9F34E72C693082D2950 * value)
	{
		___tweenPlugin_59 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___tweenPlugin_59), (void*)value);
	}
};


// DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions>
struct  TweenerCore_3_tEF3CF5BF3AF3C462924E66EFF3839D0D49C74066  : public Tweener_t9B2A5E94EE6D11F7607E58AE4E37186FF63587C8
{
public:
	// T2 DG.Tweening.Core.TweenerCore`3::startValue
	Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  ___startValue_53;
	// T2 DG.Tweening.Core.TweenerCore`3::endValue
	Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  ___endValue_54;
	// T2 DG.Tweening.Core.TweenerCore`3::changeValue
	Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  ___changeValue_55;
	// TPlugOptions DG.Tweening.Core.TweenerCore`3::plugOptions
	VectorOptions_t385A0AFDBE150CC9F61EA0DC03FEA860BA5EA322  ___plugOptions_56;
	// DG.Tweening.Core.DOGetter`1<T1> DG.Tweening.Core.TweenerCore`3::getter
	DOGetter_1_tED4D2C955A43A16638D892A1DBA007D1098B34D1 * ___getter_57;
	// DG.Tweening.Core.DOSetter`1<T1> DG.Tweening.Core.TweenerCore`3::setter
	DOSetter_1_t6957431283D538C65C791011FE5AECB0235D641F * ___setter_58;
	// DG.Tweening.Plugins.Core.ABSTweenPlugin`3<T1,T2,TPlugOptions> DG.Tweening.Core.TweenerCore`3::tweenPlugin
	ABSTweenPlugin_3_tF0F62B2C3E037FA76B2A6352C4C0E6C8B2D668FD * ___tweenPlugin_59;

public:
	inline static int32_t get_offset_of_startValue_53() { return static_cast<int32_t>(offsetof(TweenerCore_3_tEF3CF5BF3AF3C462924E66EFF3839D0D49C74066, ___startValue_53)); }
	inline Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  get_startValue_53() const { return ___startValue_53; }
	inline Vector2_tA85D2DD88578276CA8A8796756458277E72D073D * get_address_of_startValue_53() { return &___startValue_53; }
	inline void set_startValue_53(Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  value)
	{
		___startValue_53 = value;
	}

	inline static int32_t get_offset_of_endValue_54() { return static_cast<int32_t>(offsetof(TweenerCore_3_tEF3CF5BF3AF3C462924E66EFF3839D0D49C74066, ___endValue_54)); }
	inline Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  get_endValue_54() const { return ___endValue_54; }
	inline Vector2_tA85D2DD88578276CA8A8796756458277E72D073D * get_address_of_endValue_54() { return &___endValue_54; }
	inline void set_endValue_54(Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  value)
	{
		___endValue_54 = value;
	}

	inline static int32_t get_offset_of_changeValue_55() { return static_cast<int32_t>(offsetof(TweenerCore_3_tEF3CF5BF3AF3C462924E66EFF3839D0D49C74066, ___changeValue_55)); }
	inline Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  get_changeValue_55() const { return ___changeValue_55; }
	inline Vector2_tA85D2DD88578276CA8A8796756458277E72D073D * get_address_of_changeValue_55() { return &___changeValue_55; }
	inline void set_changeValue_55(Vector2_tA85D2DD88578276CA8A8796756458277E72D073D  value)
	{
		___changeValue_55 = value;
	}

	inline static int32_t get_offset_of_plugOptions_56() { return static_cast<int32_t>(offsetof(TweenerCore_3_tEF3CF5BF3AF3C462924E66EFF3839D0D49C74066, ___plugOptions_56)); }
	inline VectorOptions_t385A0AFDBE150CC9F61EA0DC03FEA860BA5EA322  get_plugOptions_56() const { return ___plugOptions_56; }
	inline VectorOptions_t385A0AFDBE150CC9F61EA0DC03FEA860BA5EA322 * get_address_of_plugOptions_56() { return &___plugOptions_56; }
	inline void set_plugOptions_56(VectorOptions_t385A0AFDBE150CC9F61EA0DC03FEA860BA5EA322  value)
	{
		___plugOptions_56 = value;
	}

	inline static int32_t get_offset_of_getter_57() { return static_cast<int32_t>(offsetof(TweenerCore_3_tEF3CF5BF3AF3C462924E66EFF3839D0D49C74066, ___getter_57)); }
	inline DOGetter_1_tED4D2C955A43A16638D892A1DBA007D1098B34D1 * get_getter_57() const { return ___getter_57; }
	inline DOGetter_1_tED4D2C955A43A16638D892A1DBA007D1098B34D1 ** get_address_of_getter_57() { return &___getter_57; }
	inline void set_getter_57(DOGetter_1_tED4D2C955A43A16638D892A1DBA007D1098B34D1 * value)
	{
		___getter_57 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___getter_57), (void*)value);
	}

	inline static int32_t get_offset_of_setter_58() { return static_cast<int32_t>(offsetof(TweenerCore_3_tEF3CF5BF3AF3C462924E66EFF3839D0D49C74066, ___setter_58)); }
	inline DOSetter_1_t6957431283D538C65C791011FE5AECB0235D641F * get_setter_58() const { return ___setter_58; }
	inline DOSetter_1_t6957431283D538C65C791011FE5AECB0235D641F ** get_address_of_setter_58() { return &___setter_58; }
	inline void set_setter_58(DOSetter_1_t6957431283D538C65C791011FE5AECB0235D641F * value)
	{
		___setter_58 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___setter_58), (void*)value);
	}

	inline static int32_t get_offset_of_tweenPlugin_59() { return static_cast<int32_t>(offsetof(TweenerCore_3_tEF3CF5BF3AF3C462924E66EFF3839D0D49C74066, ___tweenPlugin_59)); }
	inline ABSTweenPlugin_3_tF0F62B2C3E037FA76B2A6352C4C0E6C8B2D668FD * get_tweenPlugin_59() const { return ___tweenPlugin_59; }
	inline ABSTweenPlugin_3_tF0F62B2C3E037FA76B2A6352C4C0E6C8B2D668FD ** get_address_of_tweenPlugin_59() { return &___tweenPlugin_59; }
	inline void set_tweenPlugin_59(ABSTweenPlugin_3_tF0F62B2C3E037FA76B2A6352C4C0E6C8B2D668FD * value)
	{
		___tweenPlugin_59 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___tweenPlugin_59), (void*)value);
	}
};


// DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions>
struct  TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1  : public Tweener_t9B2A5E94EE6D11F7607E58AE4E37186FF63587C8
{
public:
	// T2 DG.Tweening.Core.TweenerCore`3::startValue
	Path_tCE251EA0F45EA8B91CAD11018E275B451FAC6FA2 * ___startValue_53;
	// T2 DG.Tweening.Core.TweenerCore`3::endValue
	Path_tCE251EA0F45EA8B91CAD11018E275B451FAC6FA2 * ___endValue_54;
	// T2 DG.Tweening.Core.TweenerCore`3::changeValue
	Path_tCE251EA0F45EA8B91CAD11018E275B451FAC6FA2 * ___changeValue_55;
	// TPlugOptions DG.Tweening.Core.TweenerCore`3::plugOptions
	PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7  ___plugOptions_56;
	// DG.Tweening.Core.DOGetter`1<T1> DG.Tweening.Core.TweenerCore`3::getter
	DOGetter_1_t6A6DB6A183AD6D7F4B2F3656C4AB9326994D8CA4 * ___getter_57;
	// DG.Tweening.Core.DOSetter`1<T1> DG.Tweening.Core.TweenerCore`3::setter
	DOSetter_1_t528C4470268C88CABD1BFDF039B98D72E012AF46 * ___setter_58;
	// DG.Tweening.Plugins.Core.ABSTweenPlugin`3<T1,T2,TPlugOptions> DG.Tweening.Core.TweenerCore`3::tweenPlugin
	ABSTweenPlugin_3_t4B150004C6035544DAF0205D76D11C3A5ADFE3D3 * ___tweenPlugin_59;

public:
	inline static int32_t get_offset_of_startValue_53() { return static_cast<int32_t>(offsetof(TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1, ___startValue_53)); }
	inline Path_tCE251EA0F45EA8B91CAD11018E275B451FAC6FA2 * get_startValue_53() const { return ___startValue_53; }
	inline Path_tCE251EA0F45EA8B91CAD11018E275B451FAC6FA2 ** get_address_of_startValue_53() { return &___startValue_53; }
	inline void set_startValue_53(Path_tCE251EA0F45EA8B91CAD11018E275B451FAC6FA2 * value)
	{
		___startValue_53 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___startValue_53), (void*)value);
	}

	inline static int32_t get_offset_of_endValue_54() { return static_cast<int32_t>(offsetof(TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1, ___endValue_54)); }
	inline Path_tCE251EA0F45EA8B91CAD11018E275B451FAC6FA2 * get_endValue_54() const { return ___endValue_54; }
	inline Path_tCE251EA0F45EA8B91CAD11018E275B451FAC6FA2 ** get_address_of_endValue_54() { return &___endValue_54; }
	inline void set_endValue_54(Path_tCE251EA0F45EA8B91CAD11018E275B451FAC6FA2 * value)
	{
		___endValue_54 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___endValue_54), (void*)value);
	}

	inline static int32_t get_offset_of_changeValue_55() { return static_cast<int32_t>(offsetof(TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1, ___changeValue_55)); }
	inline Path_tCE251EA0F45EA8B91CAD11018E275B451FAC6FA2 * get_changeValue_55() const { return ___changeValue_55; }
	inline Path_tCE251EA0F45EA8B91CAD11018E275B451FAC6FA2 ** get_address_of_changeValue_55() { return &___changeValue_55; }
	inline void set_changeValue_55(Path_tCE251EA0F45EA8B91CAD11018E275B451FAC6FA2 * value)
	{
		___changeValue_55 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___changeValue_55), (void*)value);
	}

	inline static int32_t get_offset_of_plugOptions_56() { return static_cast<int32_t>(offsetof(TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1, ___plugOptions_56)); }
	inline PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7  get_plugOptions_56() const { return ___plugOptions_56; }
	inline PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7 * get_address_of_plugOptions_56() { return &___plugOptions_56; }
	inline void set_plugOptions_56(PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7  value)
	{
		___plugOptions_56 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___plugOptions_56))->___lookAtTransform_6), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&___plugOptions_56))->___parent_11), (void*)NULL);
		#endif
	}

	inline static int32_t get_offset_of_getter_57() { return static_cast<int32_t>(offsetof(TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1, ___getter_57)); }
	inline DOGetter_1_t6A6DB6A183AD6D7F4B2F3656C4AB9326994D8CA4 * get_getter_57() const { return ___getter_57; }
	inline DOGetter_1_t6A6DB6A183AD6D7F4B2F3656C4AB9326994D8CA4 ** get_address_of_getter_57() { return &___getter_57; }
	inline void set_getter_57(DOGetter_1_t6A6DB6A183AD6D7F4B2F3656C4AB9326994D8CA4 * value)
	{
		___getter_57 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___getter_57), (void*)value);
	}

	inline static int32_t get_offset_of_setter_58() { return static_cast<int32_t>(offsetof(TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1, ___setter_58)); }
	inline DOSetter_1_t528C4470268C88CABD1BFDF039B98D72E012AF46 * get_setter_58() const { return ___setter_58; }
	inline DOSetter_1_t528C4470268C88CABD1BFDF039B98D72E012AF46 ** get_address_of_setter_58() { return &___setter_58; }
	inline void set_setter_58(DOSetter_1_t528C4470268C88CABD1BFDF039B98D72E012AF46 * value)
	{
		___setter_58 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___setter_58), (void*)value);
	}

	inline static int32_t get_offset_of_tweenPlugin_59() { return static_cast<int32_t>(offsetof(TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1, ___tweenPlugin_59)); }
	inline ABSTweenPlugin_3_t4B150004C6035544DAF0205D76D11C3A5ADFE3D3 * get_tweenPlugin_59() const { return ___tweenPlugin_59; }
	inline ABSTweenPlugin_3_t4B150004C6035544DAF0205D76D11C3A5ADFE3D3 ** get_address_of_tweenPlugin_59() { return &___tweenPlugin_59; }
	inline void set_tweenPlugin_59(ABSTweenPlugin_3_t4B150004C6035544DAF0205D76D11C3A5ADFE3D3 * value)
	{
		___tweenPlugin_59 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___tweenPlugin_59), (void*)value);
	}
};


// DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions>
struct  TweenerCore_3_t104C232CA5A703780F416D4E8F2D71E42FE9C46B  : public Tweener_t9B2A5E94EE6D11F7607E58AE4E37186FF63587C8
{
public:
	// T2 DG.Tweening.Core.TweenerCore`3::startValue
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___startValue_53;
	// T2 DG.Tweening.Core.TweenerCore`3::endValue
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___endValue_54;
	// T2 DG.Tweening.Core.TweenerCore`3::changeValue
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___changeValue_55;
	// TPlugOptions DG.Tweening.Core.TweenerCore`3::plugOptions
	VectorOptions_t385A0AFDBE150CC9F61EA0DC03FEA860BA5EA322  ___plugOptions_56;
	// DG.Tweening.Core.DOGetter`1<T1> DG.Tweening.Core.TweenerCore`3::getter
	DOGetter_1_t6A6DB6A183AD6D7F4B2F3656C4AB9326994D8CA4 * ___getter_57;
	// DG.Tweening.Core.DOSetter`1<T1> DG.Tweening.Core.TweenerCore`3::setter
	DOSetter_1_t528C4470268C88CABD1BFDF039B98D72E012AF46 * ___setter_58;
	// DG.Tweening.Plugins.Core.ABSTweenPlugin`3<T1,T2,TPlugOptions> DG.Tweening.Core.TweenerCore`3::tweenPlugin
	ABSTweenPlugin_3_t50462951CA2C372D1A9BC7C38C6ECC1810944678 * ___tweenPlugin_59;

public:
	inline static int32_t get_offset_of_startValue_53() { return static_cast<int32_t>(offsetof(TweenerCore_3_t104C232CA5A703780F416D4E8F2D71E42FE9C46B, ___startValue_53)); }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  get_startValue_53() const { return ___startValue_53; }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720 * get_address_of_startValue_53() { return &___startValue_53; }
	inline void set_startValue_53(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  value)
	{
		___startValue_53 = value;
	}

	inline static int32_t get_offset_of_endValue_54() { return static_cast<int32_t>(offsetof(TweenerCore_3_t104C232CA5A703780F416D4E8F2D71E42FE9C46B, ___endValue_54)); }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  get_endValue_54() const { return ___endValue_54; }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720 * get_address_of_endValue_54() { return &___endValue_54; }
	inline void set_endValue_54(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  value)
	{
		___endValue_54 = value;
	}

	inline static int32_t get_offset_of_changeValue_55() { return static_cast<int32_t>(offsetof(TweenerCore_3_t104C232CA5A703780F416D4E8F2D71E42FE9C46B, ___changeValue_55)); }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  get_changeValue_55() const { return ___changeValue_55; }
	inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720 * get_address_of_changeValue_55() { return &___changeValue_55; }
	inline void set_changeValue_55(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  value)
	{
		___changeValue_55 = value;
	}

	inline static int32_t get_offset_of_plugOptions_56() { return static_cast<int32_t>(offsetof(TweenerCore_3_t104C232CA5A703780F416D4E8F2D71E42FE9C46B, ___plugOptions_56)); }
	inline VectorOptions_t385A0AFDBE150CC9F61EA0DC03FEA860BA5EA322  get_plugOptions_56() const { return ___plugOptions_56; }
	inline VectorOptions_t385A0AFDBE150CC9F61EA0DC03FEA860BA5EA322 * get_address_of_plugOptions_56() { return &___plugOptions_56; }
	inline void set_plugOptions_56(VectorOptions_t385A0AFDBE150CC9F61EA0DC03FEA860BA5EA322  value)
	{
		___plugOptions_56 = value;
	}

	inline static int32_t get_offset_of_getter_57() { return static_cast<int32_t>(offsetof(TweenerCore_3_t104C232CA5A703780F416D4E8F2D71E42FE9C46B, ___getter_57)); }
	inline DOGetter_1_t6A6DB6A183AD6D7F4B2F3656C4AB9326994D8CA4 * get_getter_57() const { return ___getter_57; }
	inline DOGetter_1_t6A6DB6A183AD6D7F4B2F3656C4AB9326994D8CA4 ** get_address_of_getter_57() { return &___getter_57; }
	inline void set_getter_57(DOGetter_1_t6A6DB6A183AD6D7F4B2F3656C4AB9326994D8CA4 * value)
	{
		___getter_57 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___getter_57), (void*)value);
	}

	inline static int32_t get_offset_of_setter_58() { return static_cast<int32_t>(offsetof(TweenerCore_3_t104C232CA5A703780F416D4E8F2D71E42FE9C46B, ___setter_58)); }
	inline DOSetter_1_t528C4470268C88CABD1BFDF039B98D72E012AF46 * get_setter_58() const { return ___setter_58; }
	inline DOSetter_1_t528C4470268C88CABD1BFDF039B98D72E012AF46 ** get_address_of_setter_58() { return &___setter_58; }
	inline void set_setter_58(DOSetter_1_t528C4470268C88CABD1BFDF039B98D72E012AF46 * value)
	{
		___setter_58 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___setter_58), (void*)value);
	}

	inline static int32_t get_offset_of_tweenPlugin_59() { return static_cast<int32_t>(offsetof(TweenerCore_3_t104C232CA5A703780F416D4E8F2D71E42FE9C46B, ___tweenPlugin_59)); }
	inline ABSTweenPlugin_3_t50462951CA2C372D1A9BC7C38C6ECC1810944678 * get_tweenPlugin_59() const { return ___tweenPlugin_59; }
	inline ABSTweenPlugin_3_t50462951CA2C372D1A9BC7C38C6ECC1810944678 ** get_address_of_tweenPlugin_59() { return &___tweenPlugin_59; }
	inline void set_tweenPlugin_59(ABSTweenPlugin_3_t50462951CA2C372D1A9BC7C38C6ECC1810944678 * value)
	{
		___tweenPlugin_59 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___tweenPlugin_59), (void*)value);
	}
};


// DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions>
struct  TweenerCore_3_t8144D2B7915783E42476714D21E639420B0EDC30  : public Tweener_t9B2A5E94EE6D11F7607E58AE4E37186FF63587C8
{
public:
	// T2 DG.Tweening.Core.TweenerCore`3::startValue
	Vector3U5BU5D_tB9EC3346CC4A0EA5447D968E84A9AC1F6F372C28* ___startValue_53;
	// T2 DG.Tweening.Core.TweenerCore`3::endValue
	Vector3U5BU5D_tB9EC3346CC4A0EA5447D968E84A9AC1F6F372C28* ___endValue_54;
	// T2 DG.Tweening.Core.TweenerCore`3::changeValue
	Vector3U5BU5D_tB9EC3346CC4A0EA5447D968E84A9AC1F6F372C28* ___changeValue_55;
	// TPlugOptions DG.Tweening.Core.TweenerCore`3::plugOptions
	Vector3ArrayOptions_t3E84666D670017F133C32243F0709A3852F05257  ___plugOptions_56;
	// DG.Tweening.Core.DOGetter`1<T1> DG.Tweening.Core.TweenerCore`3::getter
	DOGetter_1_t6A6DB6A183AD6D7F4B2F3656C4AB9326994D8CA4 * ___getter_57;
	// DG.Tweening.Core.DOSetter`1<T1> DG.Tweening.Core.TweenerCore`3::setter
	DOSetter_1_t528C4470268C88CABD1BFDF039B98D72E012AF46 * ___setter_58;
	// DG.Tweening.Plugins.Core.ABSTweenPlugin`3<T1,T2,TPlugOptions> DG.Tweening.Core.TweenerCore`3::tweenPlugin
	ABSTweenPlugin_3_t59C22DD36F4259810DAE41F464AC73D990C88056 * ___tweenPlugin_59;

public:
	inline static int32_t get_offset_of_startValue_53() { return static_cast<int32_t>(offsetof(TweenerCore_3_t8144D2B7915783E42476714D21E639420B0EDC30, ___startValue_53)); }
	inline Vector3U5BU5D_tB9EC3346CC4A0EA5447D968E84A9AC1F6F372C28* get_startValue_53() const { return ___startValue_53; }
	inline Vector3U5BU5D_tB9EC3346CC4A0EA5447D968E84A9AC1F6F372C28** get_address_of_startValue_53() { return &___startValue_53; }
	inline void set_startValue_53(Vector3U5BU5D_tB9EC3346CC4A0EA5447D968E84A9AC1F6F372C28* value)
	{
		___startValue_53 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___startValue_53), (void*)value);
	}

	inline static int32_t get_offset_of_endValue_54() { return static_cast<int32_t>(offsetof(TweenerCore_3_t8144D2B7915783E42476714D21E639420B0EDC30, ___endValue_54)); }
	inline Vector3U5BU5D_tB9EC3346CC4A0EA5447D968E84A9AC1F6F372C28* get_endValue_54() const { return ___endValue_54; }
	inline Vector3U5BU5D_tB9EC3346CC4A0EA5447D968E84A9AC1F6F372C28** get_address_of_endValue_54() { return &___endValue_54; }
	inline void set_endValue_54(Vector3U5BU5D_tB9EC3346CC4A0EA5447D968E84A9AC1F6F372C28* value)
	{
		___endValue_54 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___endValue_54), (void*)value);
	}

	inline static int32_t get_offset_of_changeValue_55() { return static_cast<int32_t>(offsetof(TweenerCore_3_t8144D2B7915783E42476714D21E639420B0EDC30, ___changeValue_55)); }
	inline Vector3U5BU5D_tB9EC3346CC4A0EA5447D968E84A9AC1F6F372C28* get_changeValue_55() const { return ___changeValue_55; }
	inline Vector3U5BU5D_tB9EC3346CC4A0EA5447D968E84A9AC1F6F372C28** get_address_of_changeValue_55() { return &___changeValue_55; }
	inline void set_changeValue_55(Vector3U5BU5D_tB9EC3346CC4A0EA5447D968E84A9AC1F6F372C28* value)
	{
		___changeValue_55 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___changeValue_55), (void*)value);
	}

	inline static int32_t get_offset_of_plugOptions_56() { return static_cast<int32_t>(offsetof(TweenerCore_3_t8144D2B7915783E42476714D21E639420B0EDC30, ___plugOptions_56)); }
	inline Vector3ArrayOptions_t3E84666D670017F133C32243F0709A3852F05257  get_plugOptions_56() const { return ___plugOptions_56; }
	inline Vector3ArrayOptions_t3E84666D670017F133C32243F0709A3852F05257 * get_address_of_plugOptions_56() { return &___plugOptions_56; }
	inline void set_plugOptions_56(Vector3ArrayOptions_t3E84666D670017F133C32243F0709A3852F05257  value)
	{
		___plugOptions_56 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___plugOptions_56))->___durations_2), (void*)NULL);
	}

	inline static int32_t get_offset_of_getter_57() { return static_cast<int32_t>(offsetof(TweenerCore_3_t8144D2B7915783E42476714D21E639420B0EDC30, ___getter_57)); }
	inline DOGetter_1_t6A6DB6A183AD6D7F4B2F3656C4AB9326994D8CA4 * get_getter_57() const { return ___getter_57; }
	inline DOGetter_1_t6A6DB6A183AD6D7F4B2F3656C4AB9326994D8CA4 ** get_address_of_getter_57() { return &___getter_57; }
	inline void set_getter_57(DOGetter_1_t6A6DB6A183AD6D7F4B2F3656C4AB9326994D8CA4 * value)
	{
		___getter_57 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___getter_57), (void*)value);
	}

	inline static int32_t get_offset_of_setter_58() { return static_cast<int32_t>(offsetof(TweenerCore_3_t8144D2B7915783E42476714D21E639420B0EDC30, ___setter_58)); }
	inline DOSetter_1_t528C4470268C88CABD1BFDF039B98D72E012AF46 * get_setter_58() const { return ___setter_58; }
	inline DOSetter_1_t528C4470268C88CABD1BFDF039B98D72E012AF46 ** get_address_of_setter_58() { return &___setter_58; }
	inline void set_setter_58(DOSetter_1_t528C4470268C88CABD1BFDF039B98D72E012AF46 * value)
	{
		___setter_58 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___setter_58), (void*)value);
	}

	inline static int32_t get_offset_of_tweenPlugin_59() { return static_cast<int32_t>(offsetof(TweenerCore_3_t8144D2B7915783E42476714D21E639420B0EDC30, ___tweenPlugin_59)); }
	inline ABSTweenPlugin_3_t59C22DD36F4259810DAE41F464AC73D990C88056 * get_tweenPlugin_59() const { return ___tweenPlugin_59; }
	inline ABSTweenPlugin_3_t59C22DD36F4259810DAE41F464AC73D990C88056 ** get_address_of_tweenPlugin_59() { return &___tweenPlugin_59; }
	inline void set_tweenPlugin_59(ABSTweenPlugin_3_t59C22DD36F4259810DAE41F464AC73D990C88056 * value)
	{
		___tweenPlugin_59 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___tweenPlugin_59), (void*)value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// System.Delegate[]
struct DelegateU5BU5D_tDFCDEE2A6322F96C0FE49AF47E9ADB8C4B294E86  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) Delegate_t * m_Items[1];

public:
	inline Delegate_t * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Delegate_t ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Delegate_t * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Delegate_t * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Delegate_t ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Delegate_t * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// System.Char[]
struct CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) Il2CppChar m_Items[1];

public:
	inline Il2CppChar GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Il2CppChar* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Il2CppChar value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline Il2CppChar GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Il2CppChar* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Il2CppChar value)
	{
		m_Items[index] = value;
	}
};


// System.Boolean System.Nullable`1<UnityEngine.Vector3>::get_HasValue()
IL2CPP_EXTERN_C inline IL2CPP_METHOD_ATTR bool Nullable_1_get_HasValue_m799FAADF5BA2C9E13220149280B2951799A26D7F_gshared_inline (Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE * __this, const RuntimeMethod* method);
// !0 System.Nullable`1<UnityEngine.Vector3>::GetValueOrDefault()
IL2CPP_EXTERN_C inline IL2CPP_METHOD_ATTR Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  Nullable_1_GetValueOrDefault_m35E99BED1252A5C9E5A0D197FCF8E3C0E2A3C2A8_gshared_inline (Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE * __this, const RuntimeMethod* method);
// System.Void System.Nullable`1<UnityEngine.Vector3>::.ctor(!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Nullable_1__ctor_m49ABD148B7A7789CB005BA17CA29E1896EE35057_gshared (Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE * __this, Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___value0, const RuntimeMethod* method);
// !0 System.Nullable`1<UnityEngine.Vector3>::get_Value()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  Nullable_1_get_Value_m902B83FE050783CC1CEF6CB970A5AAB926F77D9C_gshared (Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE * __this, const RuntimeMethod* method);

// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0 (RuntimeObject * __this, const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Transform::get_position()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  Transform_get_position_mF54C3A064F7C8E24F1C56EE128728B2E4485E294 (Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Transform::set_position(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_position_mDA89E4893F14ECA5CBEEE7FB80A5BF7C1B8EA6DC (Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * __this, Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___value0, const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Transform::get_localPosition()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  Transform_get_localPosition_m812D43318E05BDCB78310EB7308785A13D85EFD8 (Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Transform::set_localPosition(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_localPosition_m275F5550DD939F83AFEB5E8D681131172E2E1728 (Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * __this, Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___value0, const RuntimeMethod* method);
// UnityEngine.Quaternion UnityEngine.Quaternion::Inverse(UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  Quaternion_Inverse_mC3A78571A826F05CE179637E675BD25F8B203E0C (Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  ___rotation0, const RuntimeMethod* method);
// UnityEngine.Quaternion UnityEngine.Quaternion::op_Multiply(UnityEngine.Quaternion,UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  Quaternion_op_Multiply_mDB9F738AA8160E3D85549F4FEDA23BC658B5A790 (Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  ___lhs0, Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  ___rhs1, const RuntimeMethod* method);
// UnityEngine.Quaternion UnityEngine.Transform::get_rotation()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  Transform_get_rotation_m3AB90A67403249AECCA5E02BC70FCE8C90FE9FB9 (Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Transform::set_rotation(UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_rotation_m429694E264117C6DC682EC6AF45C7864E5155935 (Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * __this, Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  ___value0, const RuntimeMethod* method);
// System.Single UnityEngine.Camera::get_fieldOfView()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Camera_get_fieldOfView_m065A50B70AC3661337ACA482DDEFA29CCBD249D6 (Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Camera::set_fieldOfView(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Camera_set_fieldOfView_m5006BA0D01A27619A053704D3BD6A8938F7DEDA5 (Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * __this, float ___value0, const RuntimeMethod* method);
// System.Single UnityEngine.Camera::get_orthographicSize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Camera_get_orthographicSize_m700FCD8CF48BC59A0415A624328B4A627B88D958 (Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Camera::set_orthographicSize(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Camera_set_orthographicSize_mF15F37A294A7AA2ADD9519728A495DFA0A836428 (Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * __this, float ___value0, const RuntimeMethod* method);
// UnityEngine.Rect UnityEngine.Camera::get_pixelRect()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Rect_t35B976DE901B5423C11705E156938EA27AB402CE  Camera_get_pixelRect_mBA87D6C23FD7A5E1A7F3CE0E8F9B86A9318B5317 (Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Camera::set_pixelRect(UnityEngine.Rect)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Camera_set_pixelRect_m9380482EFA5D7912988D585E9538A58988C8E0E9 (Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * __this, Rect_t35B976DE901B5423C11705E156938EA27AB402CE  ___value0, const RuntimeMethod* method);
// UnityEngine.Rect UnityEngine.Camera::get_rect()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Rect_t35B976DE901B5423C11705E156938EA27AB402CE  Camera_get_rect_m3570AA056526AB01C7733B4E7BE69F332E128A08 (Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Camera::set_rect(UnityEngine.Rect)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Camera_set_rect_m6DB9964EA6E519E2B07561C8CE6AA423980FEC11 (Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * __this, Rect_t35B976DE901B5423C11705E156938EA27AB402CE  ___value0, const RuntimeMethod* method);
// UnityEngine.Transform UnityEngine.Component::get_transform()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * Component_get_transform_m00F05BD782F920C301A7EBA480F3B7A904C07EC9 (Component_t05064EF382ABCAF4B8C94F8A350EA85184C26621 * __this, const RuntimeMethod* method);
// UnityEngine.Color UnityEngine.Material::get_color()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color_t119BCA590009762C7223FDD3AF9706653AC84ED2  Material_get_color_m7CE9C1FC0E0B4952D58DFBBA4D569F4B161B27E9 (Material_tF7DB3BF0C24DEC2FE0CB51E5DF5053D5223C8598 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Material::set_color(UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Material_set_color_m127EAC5D3CC68359E72D12A2B3CE7428EFBB81C3 (Material_tF7DB3BF0C24DEC2FE0CB51E5DF5053D5223C8598 * __this, Color_t119BCA590009762C7223FDD3AF9706653AC84ED2  ___value0, const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Rigidbody::get_position()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  Rigidbody_get_position_m478D060638E43DE3AE9C931A42593484B8310113 (Rigidbody_tE0A58EE5A1F7DC908EFFB4F0D795AC9552A750A5 * __this, const RuntimeMethod* method);
// UnityEngine.Quaternion UnityEngine.Rigidbody::get_rotation()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  Rigidbody_get_rotation_mD967DD98F16F80C0D74F8F1C25953D0609906BE5 (Rigidbody_tE0A58EE5A1F7DC908EFFB4F0D795AC9552A750A5 * __this, const RuntimeMethod* method);
// System.Single UnityEngine.Camera::get_aspect()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Camera_get_aspect_m2ADA7982754920C3B58B4DB664801D6F2416E0C6 (Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Camera::set_aspect(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Camera_set_aspect_m84BE4641686B30B8F9FFEA47BB1D7D88E27344EE (Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * __this, float ___value0, const RuntimeMethod* method);
// UnityEngine.Quaternion UnityEngine.Transform::get_localRotation()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  Transform_get_localRotation_mEDA319E1B42EF12A19A95AC0824345B6574863FE (Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Transform::set_localRotation(UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_localRotation_mE2BECB0954FFC1D93FB631600D9A9BEFF41D9C8A (Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * __this, Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  ___value0, const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Transform::get_localScale()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  Transform_get_localScale_mD8F631021C2D62B7C341B1A17FA75491F64E13DA (Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Transform::set_localScale(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_localScale_m7ED1A6E5A87CD1D483515B99D6D3121FB92B0556 (Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * __this, Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___value0, const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Transform::get_localEulerAngles()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  Transform_get_localEulerAngles_m445AD7F6706B0BDABA8A875C899EB1E1DF1A2A2B (Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * __this, const RuntimeMethod* method);
// UnityEngine.Quaternion UnityEngine.Quaternion::Euler(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  Quaternion_Euler_m55C96FCD397CC69109261572710608D12A4CBD2B (Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___euler0, const RuntimeMethod* method);
// UnityEngine.Color UnityEngine.Camera::get_backgroundColor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color_t119BCA590009762C7223FDD3AF9706653AC84ED2  Camera_get_backgroundColor_m14496C5DC24582D7227277AF71DBE96F8E9E64FF (Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Camera::set_backgroundColor(UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Camera_set_backgroundColor_mDB9CA1B37FE2D52493823914AC5BC9F8C1935D6F (Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * __this, Color_t119BCA590009762C7223FDD3AF9706653AC84ED2  ___value0, const RuntimeMethod* method);
// System.Boolean DG.Tweening.Tween::OnTweenCallback(DG.Tweening.TweenCallback)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Tween_OnTweenCallback_m31509BCFB6D15BB7765CF28E7B6E0738DC88B659 (TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * ___callback0, const RuntimeMethod* method);
// System.Void DG.Tweening.TweenCallback::Invoke()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TweenCallback_Invoke_mD2FE3DA243C1DC77043EF838081DC7BBD097DA9E (TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * __this, const RuntimeMethod* method);
// System.String System.String::Concat(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_mB78D0094592718DA6D5DB6C712A9C225631666BE (String_t* ___str00, String_t* ___str11, const RuntimeMethod* method);
// System.Void DG.Tweening.Core.Debugger::LogWarning(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debugger_LogWarning_mC3D1B9A9EE70C5914C44E44E3B189059B6E80D45 (RuntimeObject * ___message0, const RuntimeMethod* method);
// System.Void DG.Tweening.Core.ABSSequentiable::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ABSSequentiable__ctor_mC0A3D985974279B385789BC4FA4EFD616033DD31 (ABSSequentiable_tDA1366907669973CC0BB553EF4159D45FC46A757 * __this, const RuntimeMethod* method);
// System.Void DG.Tweening.Core.Debugger::LogNullTween(DG.Tweening.Tween)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debugger_LogNullTween_m95F50B0509E4BA5566BF1FA12326EE00E746B789 (Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * ___t0, const RuntimeMethod* method);
// System.Void DG.Tweening.Core.Debugger::LogInvalidTween(DG.Tweening.Tween)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debugger_LogInvalidTween_m55880CECD15EF4A1D09D98999536C602171A5B95 (Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * ___t0, const RuntimeMethod* method);
// System.Void DG.Tweening.Core.Debugger::LogNestedTween(DG.Tweening.Tween)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debugger_LogNestedTween_m6C0A9EBE74114A15FDC181BF27996C1350A02EE9 (Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * ___t0, const RuntimeMethod* method);
// System.Boolean DG.Tweening.Core.TweenManager::Complete(DG.Tweening.Tween,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TweenManager_Complete_m82613D24CDEA91AF035F04E4B12D6C4F71858D47 (Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * ___t0, bool ___modifyActiveLists1, const RuntimeMethod* method);
// System.Void DG.Tweening.Core.TweenManager::Despawn(DG.Tweening.Tween,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TweenManager_Despawn_mCBBD003E4779D54699E368376958FB6BB681E63D (Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * ___t0, bool ___modifyActiveLists1, const RuntimeMethod* method);
// System.Boolean DG.Tweening.Core.TweenManager::PlayBackwards(DG.Tweening.Tween)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TweenManager_PlayBackwards_m30A0A66D801549233E04D406718BAA299711B7CA (Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * ___t0, const RuntimeMethod* method);
// System.Boolean DG.Tweening.Core.TweenManager::PlayForward(DG.Tweening.Tween)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TweenManager_PlayForward_mF14238D7B13F5E7EA0BEF7DD672AEA65365F8BE6 (Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * ___t0, const RuntimeMethod* method);
// System.Boolean DG.Tweening.Core.TweenManager::Restart(DG.Tweening.Tween,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TweenManager_Restart_m785F15C1C7E7837E9A0EDFE3085EF443E65961EF (Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * ___t0, bool ___includeDelay1, const RuntimeMethod* method);
// System.Boolean DG.Tweening.Core.TweenManager::Rewind(DG.Tweening.Tween,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TweenManager_Rewind_mEEBAAC2FEA9A2CE7B3739002EB030D0AADD8C150 (Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * ___t0, bool ___includeDelay1, const RuntimeMethod* method);
// System.Boolean DG.Tweening.Core.TweenManager::TogglePause(DG.Tweening.Tween)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TweenManager_TogglePause_m1EDBB6356ECB219E9E59DA20605ABBA51F35036B (Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * ___t0, const RuntimeMethod* method);
// DG.Tweening.Sequence DG.Tweening.Sequence::DoInsert(DG.Tweening.Sequence,DG.Tweening.Tween,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Sequence_tA6FA099F465933113D131DDC0EECB6A19A27BCB2 * Sequence_DoInsert_m3D20EAC3DCAE54D0FE4EC70344B5DF3D2167C263 (Sequence_tA6FA099F465933113D131DDC0EECB6A19A27BCB2 * ___inSequence0, Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * ___t1, float ___atPosition2, const RuntimeMethod* method);
// System.Boolean System.String::IsNullOrEmpty(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_IsNullOrEmpty_m06A85A206AC2106D1982826C5665B9BD35324229 (String_t* ___value0, const RuntimeMethod* method);
// System.Int32 System.String::get_Length()
IL2CPP_EXTERN_C inline  IL2CPP_METHOD_ATTR int32_t String_get_Length_mD48C8A16A5CF1914F330DCE82D9BE15C3BEDD018_inline (String_t* __this, const RuntimeMethod* method);
// System.Char[] System.String::ToCharArray()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* String_ToCharArray_mFCFF32A5EC698E81075E0C72C874282B9ED197A6 (String_t* __this, const RuntimeMethod* method);
// System.Void DG.Tweening.Plugins.StringPluginExtensions::ScrambleChars(System.Char[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StringPluginExtensions_ScrambleChars_m5D48CF427E493F0CFB0C1A6D52C4E4C0F8DC54A2 (CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* ___chars0, const RuntimeMethod* method);
// System.Void DG.Tweening.TweenSettingsExtensions::SetPathForwardDirection(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions>,System.Nullable`1<UnityEngine.Vector3>,System.Nullable`1<UnityEngine.Vector3>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TweenSettingsExtensions_SetPathForwardDirection_m7EA9A97A77D0EBB7542134E0D8224E06D5A56714 (TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * ___t0, Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE  ___forwardDirection1, Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE  ___up2, const RuntimeMethod* method);
// System.Boolean System.Nullable`1<UnityEngine.Vector3>::get_HasValue()
inline bool Nullable_1_get_HasValue_m799FAADF5BA2C9E13220149280B2951799A26D7F_inline (Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE * __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE *, const RuntimeMethod*))Nullable_1_get_HasValue_m799FAADF5BA2C9E13220149280B2951799A26D7F_gshared_inline)(__this, method);
}
// UnityEngine.Vector3 UnityEngine.Vector3::get_zero()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  Vector3_get_zero_m3CDDCAE94581DF3BB16C4B40A100E28E9C6649C2 (const RuntimeMethod* method);
// !0 System.Nullable`1<UnityEngine.Vector3>::GetValueOrDefault()
inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  Nullable_1_GetValueOrDefault_m35E99BED1252A5C9E5A0D197FCF8E3C0E2A3C2A8_inline (Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE * __this, const RuntimeMethod* method)
{
	return ((  Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  (*) (Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE *, const RuntimeMethod*))Nullable_1_GetValueOrDefault_m35E99BED1252A5C9E5A0D197FCF8E3C0E2A3C2A8_gshared_inline)(__this, method);
}
// System.Boolean UnityEngine.Vector3::op_Inequality(UnityEngine.Vector3,UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Vector3_op_Inequality_mFEEAA4C4BF743FB5B8A47FF4967A5E2C73273D6E (Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___lhs0, Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___rhs1, const RuntimeMethod* method);
// System.Boolean UnityEngine.Vector3::op_Equality(UnityEngine.Vector3,UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Vector3_op_Equality_mA9E2F96E98E71AE7ACCE74766D700D41F0404806 (Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___lhs0, Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___rhs1, const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Vector3::get_forward()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  Vector3_get_forward_m3E2E192B3302130098738C308FA1EE1439449D0D (const RuntimeMethod* method);
// System.Void System.Nullable`1<UnityEngine.Vector3>::.ctor(!0)
inline void Nullable_1__ctor_m49ABD148B7A7789CB005BA17CA29E1896EE35057 (Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE * __this, Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___value0, const RuntimeMethod* method)
{
	((  void (*) (Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE *, Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720 , const RuntimeMethod*))Nullable_1__ctor_m49ABD148B7A7789CB005BA17CA29E1896EE35057_gshared)(__this, ___value0, method);
}
// !0 System.Nullable`1<UnityEngine.Vector3>::get_Value()
inline Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  Nullable_1_get_Value_m902B83FE050783CC1CEF6CB970A5AAB926F77D9C (Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE * __this, const RuntimeMethod* method)
{
	return ((  Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  (*) (Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE *, const RuntimeMethod*))Nullable_1_get_Value_m902B83FE050783CC1CEF6CB970A5AAB926F77D9C_gshared)(__this, method);
}
// UnityEngine.Vector3 UnityEngine.Vector3::get_up()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  Vector3_get_up_m6309EBC4E42D6D0B3D28056BD23D0331275306F7 (const RuntimeMethod* method);
// UnityEngine.Quaternion UnityEngine.Quaternion::LookRotation(UnityEngine.Vector3,UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  Quaternion_LookRotation_m7BED8FBB457FF073F183AC7962264E5110794672 (Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___forward0, Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___upwards1, const RuntimeMethod* method);
// System.Void DG.Tweening.Tween::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Tween__ctor_m6A636EF784F92284565ABFC0513F134BBEB27E74 (Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * __this, const RuntimeMethod* method);
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClass110::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass110__ctor_m5A80B18DEB2DA2FDC68DCF854A61450D070C17EE (U3CU3Ec__DisplayClass110_t721552CB7F431CCC670721B6011F9EE1C26EDADE * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Vector3 DG.Tweening.ShortcutExtensions_<>c__DisplayClass110::<DOPath>b__10e()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  U3CU3Ec__DisplayClass110_U3CDOPathU3Eb__10e_m6573B670482E30A5D38479050C3DEB84BE696F5E (U3CU3Ec__DisplayClass110_t721552CB7F431CCC670721B6011F9EE1C26EDADE * __this, const RuntimeMethod* method)
{
	{
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_0 = __this->get_target_0();
		NullCheck(L_0);
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_1 = Transform_get_position_mF54C3A064F7C8E24F1C56EE128728B2E4485E294(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClass110::<DOPath>b__10f(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass110_U3CDOPathU3Eb__10f_m6B9E9758D3ADD09E640AF0502C6FA142B99A838C (U3CU3Ec__DisplayClass110_t721552CB7F431CCC670721B6011F9EE1C26EDADE * __this, Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___x0, const RuntimeMethod* method)
{
	{
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_0 = __this->get_target_0();
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_1 = ___x0;
		NullCheck(L_0);
		Transform_set_position_mDA89E4893F14ECA5CBEEE7FB80A5BF7C1B8EA6DC(L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClass114::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass114__ctor_mB4F2CCA2B2EE375CFABF465D9B7A26A3E49B0E03 (U3CU3Ec__DisplayClass114_t1485A600A38FE289BB342ABE9B33E75FDFF2700B * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Vector3 DG.Tweening.ShortcutExtensions_<>c__DisplayClass114::<DOLocalPath>b__112()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  U3CU3Ec__DisplayClass114_U3CDOLocalPathU3Eb__112_mF1C2FF32C3D5DB7ECCD988690EA5612D11658AFF (U3CU3Ec__DisplayClass114_t1485A600A38FE289BB342ABE9B33E75FDFF2700B * __this, const RuntimeMethod* method)
{
	{
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_0 = __this->get_target_0();
		NullCheck(L_0);
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_1 = Transform_get_localPosition_m812D43318E05BDCB78310EB7308785A13D85EFD8(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClass114::<DOLocalPath>b__113(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass114_U3CDOLocalPathU3Eb__113_m878D11F3BC78096AA7565C77BF90A797AA820461 (U3CU3Ec__DisplayClass114_t1485A600A38FE289BB342ABE9B33E75FDFF2700B * __this, Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___x0, const RuntimeMethod* method)
{
	{
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_0 = __this->get_target_0();
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_1 = ___x0;
		NullCheck(L_0);
		Transform_set_localPosition_m275F5550DD939F83AFEB5E8D681131172E2E1728(L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClass12c::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass12c__ctor_mAD17352FB3EC1EDF8F71D540830FDE56EF183F16 (U3CU3Ec__DisplayClass12c_t3BC7A246A89C39269E33DB9EFFF37B2EEF6C1F23 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Quaternion DG.Tweening.ShortcutExtensions_<>c__DisplayClass12c::<DOBlendableRotateBy>b__12a()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  U3CU3Ec__DisplayClass12c_U3CDOBlendableRotateByU3Eb__12a_mC23B58E735EC919011E516CB7D4CE9E45C8E3BD7 (U3CU3Ec__DisplayClass12c_t3BC7A246A89C39269E33DB9EFFF37B2EEF6C1F23 * __this, const RuntimeMethod* method)
{
	{
		Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  L_0 = __this->get_to_0();
		return L_0;
	}
}
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClass12c::<DOBlendableRotateBy>b__12b(UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass12c_U3CDOBlendableRotateByU3Eb__12b_mF5F53747ACC7AC46FA1DB317F56B0FB85674812A (U3CU3Ec__DisplayClass12c_t3BC7A246A89C39269E33DB9EFFF37B2EEF6C1F23 * __this, Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  ___x0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (U3CU3Ec__DisplayClass12c_U3CDOBlendableRotateByU3Eb__12b_mF5F53747ACC7AC46FA1DB317F56B0FB85674812A_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  L_0 = ___x0;
		Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  L_1 = __this->get_to_0();
		IL2CPP_RUNTIME_CLASS_INIT(Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357_il2cpp_TypeInfo_var);
		Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  L_2 = Quaternion_Inverse_mC3A78571A826F05CE179637E675BD25F8B203E0C(L_1, /*hidden argument*/NULL);
		Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  L_3 = Quaternion_op_Multiply_mDB9F738AA8160E3D85549F4FEDA23BC658B5A790(L_0, L_2, /*hidden argument*/NULL);
		V_0 = L_3;
		Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  L_4 = ___x0;
		__this->set_to_0(L_4);
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_5 = __this->get_target_1();
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_6 = __this->get_target_1();
		NullCheck(L_6);
		Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  L_7 = Transform_get_rotation_m3AB90A67403249AECCA5E02BC70FCE8C90FE9FB9(L_6, /*hidden argument*/NULL);
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_8 = __this->get_target_1();
		NullCheck(L_8);
		Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  L_9 = Transform_get_rotation_m3AB90A67403249AECCA5E02BC70FCE8C90FE9FB9(L_8, /*hidden argument*/NULL);
		Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  L_10 = Quaternion_Inverse_mC3A78571A826F05CE179637E675BD25F8B203E0C(L_9, /*hidden argument*/NULL);
		Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  L_11 = Quaternion_op_Multiply_mDB9F738AA8160E3D85549F4FEDA23BC658B5A790(L_7, L_10, /*hidden argument*/NULL);
		Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  L_12 = V_0;
		Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  L_13 = Quaternion_op_Multiply_mDB9F738AA8160E3D85549F4FEDA23BC658B5A790(L_11, L_12, /*hidden argument*/NULL);
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_14 = __this->get_target_1();
		NullCheck(L_14);
		Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  L_15 = Transform_get_rotation_m3AB90A67403249AECCA5E02BC70FCE8C90FE9FB9(L_14, /*hidden argument*/NULL);
		Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  L_16 = Quaternion_op_Multiply_mDB9F738AA8160E3D85549F4FEDA23BC658B5A790(L_13, L_15, /*hidden argument*/NULL);
		NullCheck(L_5);
		Transform_set_rotation_m429694E264117C6DC682EC6AF45C7864E5155935(L_5, L_16, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClass16::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass16__ctor_m1B01DC7D118CDCB37108E0541D78F998E0A96E97 (U3CU3Ec__DisplayClass16_t4E802A0F0A82726640C245784AF8DCB4EF296CD0 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Single DG.Tweening.ShortcutExtensions_<>c__DisplayClass16::<DOFieldOfView>b__14()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float U3CU3Ec__DisplayClass16_U3CDOFieldOfViewU3Eb__14_m23DFEC821F4FE1E1303E153B6900AB5CD3312E03 (U3CU3Ec__DisplayClass16_t4E802A0F0A82726640C245784AF8DCB4EF296CD0 * __this, const RuntimeMethod* method)
{
	{
		Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * L_0 = __this->get_target_0();
		NullCheck(L_0);
		float L_1 = Camera_get_fieldOfView_m065A50B70AC3661337ACA482DDEFA29CCBD249D6(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClass16::<DOFieldOfView>b__15(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass16_U3CDOFieldOfViewU3Eb__15_m815BC6640F13D36CE21B813D30E167936369A500 (U3CU3Ec__DisplayClass16_t4E802A0F0A82726640C245784AF8DCB4EF296CD0 * __this, float ___x0, const RuntimeMethod* method)
{
	{
		Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * L_0 = __this->get_target_0();
		float L_1 = ___x0;
		NullCheck(L_0);
		Camera_set_fieldOfView_m5006BA0D01A27619A053704D3BD6A8938F7DEDA5(L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClass1e::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass1e__ctor_m2B12BF7B16BC75AC475540A3989DA00B3A7FDFF0 (U3CU3Ec__DisplayClass1e_tF8B7419EC65C518E507CBB88232CB4C8EB0D2F2D * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Single DG.Tweening.ShortcutExtensions_<>c__DisplayClass1e::<DOOrthoSize>b__1c()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float U3CU3Ec__DisplayClass1e_U3CDOOrthoSizeU3Eb__1c_mB405BD6899A2BFC92625683E04E7432EC969453C (U3CU3Ec__DisplayClass1e_tF8B7419EC65C518E507CBB88232CB4C8EB0D2F2D * __this, const RuntimeMethod* method)
{
	{
		Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * L_0 = __this->get_target_0();
		NullCheck(L_0);
		float L_1 = Camera_get_orthographicSize_m700FCD8CF48BC59A0415A624328B4A627B88D958(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClass1e::<DOOrthoSize>b__1d(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass1e_U3CDOOrthoSizeU3Eb__1d_m05DBB7B9D72EF5D5D602E9CB97B0CE887BCCB18D (U3CU3Ec__DisplayClass1e_tF8B7419EC65C518E507CBB88232CB4C8EB0D2F2D * __this, float ___x0, const RuntimeMethod* method)
{
	{
		Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * L_0 = __this->get_target_0();
		float L_1 = ___x0;
		NullCheck(L_0);
		Camera_set_orthographicSize_mF15F37A294A7AA2ADD9519728A495DFA0A836428(L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClass22::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass22__ctor_m1EE01D8AE26775FA27D1054AE494C620F32A5783 (U3CU3Ec__DisplayClass22_t9D675687ADAAE6B97900F09FA258BAD293F0169B * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Rect DG.Tweening.ShortcutExtensions_<>c__DisplayClass22::<DOPixelRect>b__20()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Rect_t35B976DE901B5423C11705E156938EA27AB402CE  U3CU3Ec__DisplayClass22_U3CDOPixelRectU3Eb__20_m57FA531AE7663A7788F3C3C5992C2C797D98B820 (U3CU3Ec__DisplayClass22_t9D675687ADAAE6B97900F09FA258BAD293F0169B * __this, const RuntimeMethod* method)
{
	{
		Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * L_0 = __this->get_target_0();
		NullCheck(L_0);
		Rect_t35B976DE901B5423C11705E156938EA27AB402CE  L_1 = Camera_get_pixelRect_mBA87D6C23FD7A5E1A7F3CE0E8F9B86A9318B5317(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClass22::<DOPixelRect>b__21(UnityEngine.Rect)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass22_U3CDOPixelRectU3Eb__21_mC1156C260A9EED5BBC64DB2CECC0D6770D31329D (U3CU3Ec__DisplayClass22_t9D675687ADAAE6B97900F09FA258BAD293F0169B * __this, Rect_t35B976DE901B5423C11705E156938EA27AB402CE  ___x0, const RuntimeMethod* method)
{
	{
		Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * L_0 = __this->get_target_0();
		Rect_t35B976DE901B5423C11705E156938EA27AB402CE  L_1 = ___x0;
		NullCheck(L_0);
		Camera_set_pixelRect_m9380482EFA5D7912988D585E9538A58988C8E0E9(L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClass26::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass26__ctor_m7B2EE2C3EA66B231B704A78B6BDF359DC4A7F87E (U3CU3Ec__DisplayClass26_tE9EF7F8D0A615A1A5C05FC64480ED086DB8BAECB * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Rect DG.Tweening.ShortcutExtensions_<>c__DisplayClass26::<DORect>b__24()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Rect_t35B976DE901B5423C11705E156938EA27AB402CE  U3CU3Ec__DisplayClass26_U3CDORectU3Eb__24_mFBFD50411D4F3AF9179C6C6FB3DB2319A806041F (U3CU3Ec__DisplayClass26_tE9EF7F8D0A615A1A5C05FC64480ED086DB8BAECB * __this, const RuntimeMethod* method)
{
	{
		Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * L_0 = __this->get_target_0();
		NullCheck(L_0);
		Rect_t35B976DE901B5423C11705E156938EA27AB402CE  L_1 = Camera_get_rect_m3570AA056526AB01C7733B4E7BE69F332E128A08(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClass26::<DORect>b__25(UnityEngine.Rect)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass26_U3CDORectU3Eb__25_m35371D42EBD43FE16659BF46F6019A0A59D27E4C (U3CU3Ec__DisplayClass26_tE9EF7F8D0A615A1A5C05FC64480ED086DB8BAECB * __this, Rect_t35B976DE901B5423C11705E156938EA27AB402CE  ___x0, const RuntimeMethod* method)
{
	{
		Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * L_0 = __this->get_target_0();
		Rect_t35B976DE901B5423C11705E156938EA27AB402CE  L_1 = ___x0;
		NullCheck(L_0);
		Camera_set_rect_m6DB9964EA6E519E2B07561C8CE6AA423980FEC11(L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClass2a::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass2a__ctor_m23D4E5921760D400A7630E1D5501612A9C86CACD (U3CU3Ec__DisplayClass2a_t830E1745D71495189F605D0C0FB47F62DC405163 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Vector3 DG.Tweening.ShortcutExtensions_<>c__DisplayClass2a::<DOShakePosition>b__28()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  U3CU3Ec__DisplayClass2a_U3CDOShakePositionU3Eb__28_m42EB2C54E0F749EB4C639B97CCC722E3645263E3 (U3CU3Ec__DisplayClass2a_t830E1745D71495189F605D0C0FB47F62DC405163 * __this, const RuntimeMethod* method)
{
	{
		Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * L_0 = __this->get_target_0();
		NullCheck(L_0);
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_1 = Component_get_transform_m00F05BD782F920C301A7EBA480F3B7A904C07EC9(L_0, /*hidden argument*/NULL);
		NullCheck(L_1);
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_2 = Transform_get_localPosition_m812D43318E05BDCB78310EB7308785A13D85EFD8(L_1, /*hidden argument*/NULL);
		return L_2;
	}
}
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClass2a::<DOShakePosition>b__29(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass2a_U3CDOShakePositionU3Eb__29_mA5577E08EE1658500B51B1DAA3DC7F1649C76CBE (U3CU3Ec__DisplayClass2a_t830E1745D71495189F605D0C0FB47F62DC405163 * __this, Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___x0, const RuntimeMethod* method)
{
	{
		Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * L_0 = __this->get_target_0();
		NullCheck(L_0);
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_1 = Component_get_transform_m00F05BD782F920C301A7EBA480F3B7A904C07EC9(L_0, /*hidden argument*/NULL);
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_2 = ___x0;
		NullCheck(L_1);
		Transform_set_localPosition_m275F5550DD939F83AFEB5E8D681131172E2E1728(L_1, L_2, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClass4a::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass4a__ctor_m30E49850161E99159D81298A8C1709EBA5ABE3B8 (U3CU3Ec__DisplayClass4a_t8BA738A82F498990CA8964AD18CF9EBE36997E56 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Color DG.Tweening.ShortcutExtensions_<>c__DisplayClass4a::<DOColor>b__48()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color_t119BCA590009762C7223FDD3AF9706653AC84ED2  U3CU3Ec__DisplayClass4a_U3CDOColorU3Eb__48_mDEC8EC39CFCF001060D2109D7AFC532B4344B5A7 (U3CU3Ec__DisplayClass4a_t8BA738A82F498990CA8964AD18CF9EBE36997E56 * __this, const RuntimeMethod* method)
{
	{
		Material_tF7DB3BF0C24DEC2FE0CB51E5DF5053D5223C8598 * L_0 = __this->get_target_0();
		NullCheck(L_0);
		Color_t119BCA590009762C7223FDD3AF9706653AC84ED2  L_1 = Material_get_color_m7CE9C1FC0E0B4952D58DFBBA4D569F4B161B27E9(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClass4a::<DOColor>b__49(UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass4a_U3CDOColorU3Eb__49_mD04DE9DBD48FCBA88DE77E65E6350591256626CF (U3CU3Ec__DisplayClass4a_t8BA738A82F498990CA8964AD18CF9EBE36997E56 * __this, Color_t119BCA590009762C7223FDD3AF9706653AC84ED2  ___x0, const RuntimeMethod* method)
{
	{
		Material_tF7DB3BF0C24DEC2FE0CB51E5DF5053D5223C8598 * L_0 = __this->get_target_0();
		Color_t119BCA590009762C7223FDD3AF9706653AC84ED2  L_1 = ___x0;
		NullCheck(L_0);
		Material_set_color_m127EAC5D3CC68359E72D12A2B3CE7428EFBB81C3(L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClass52::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass52__ctor_m8E616C0D0D352145162AB848D7E8EC057581FCA7 (U3CU3Ec__DisplayClass52_tAE0AB9391667396DE92813351A9D9EF7129466F9 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Color DG.Tweening.ShortcutExtensions_<>c__DisplayClass52::<DOFade>b__50()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color_t119BCA590009762C7223FDD3AF9706653AC84ED2  U3CU3Ec__DisplayClass52_U3CDOFadeU3Eb__50_m1E1251A02AE7DB2A7F511FA3CAC570B787ACF222 (U3CU3Ec__DisplayClass52_tAE0AB9391667396DE92813351A9D9EF7129466F9 * __this, const RuntimeMethod* method)
{
	{
		Material_tF7DB3BF0C24DEC2FE0CB51E5DF5053D5223C8598 * L_0 = __this->get_target_0();
		NullCheck(L_0);
		Color_t119BCA590009762C7223FDD3AF9706653AC84ED2  L_1 = Material_get_color_m7CE9C1FC0E0B4952D58DFBBA4D569F4B161B27E9(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClass52::<DOFade>b__51(UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass52_U3CDOFadeU3Eb__51_mA0472B2EF40353B4671489D326DC63841DAEDC09 (U3CU3Ec__DisplayClass52_tAE0AB9391667396DE92813351A9D9EF7129466F9 * __this, Color_t119BCA590009762C7223FDD3AF9706653AC84ED2  ___x0, const RuntimeMethod* method)
{
	{
		Material_tF7DB3BF0C24DEC2FE0CB51E5DF5053D5223C8598 * L_0 = __this->get_target_0();
		Color_t119BCA590009762C7223FDD3AF9706653AC84ED2  L_1 = ___x0;
		NullCheck(L_0);
		Material_set_color_m127EAC5D3CC68359E72D12A2B3CE7428EFBB81C3(L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClass71::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass71__ctor_mF84706575AF71EF4D5D0E868FDF84869CD55440C (U3CU3Ec__DisplayClass71_t08F78102E6BDF49AD78C3D6604C3E5357F334C3D * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Vector3 DG.Tweening.ShortcutExtensions_<>c__DisplayClass71::<DOMove>b__70()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  U3CU3Ec__DisplayClass71_U3CDOMoveU3Eb__70_m3313C8E441524BE73462FC19030DD12C3F1B0194 (U3CU3Ec__DisplayClass71_t08F78102E6BDF49AD78C3D6604C3E5357F334C3D * __this, const RuntimeMethod* method)
{
	{
		Rigidbody_tE0A58EE5A1F7DC908EFFB4F0D795AC9552A750A5 * L_0 = __this->get_target_0();
		NullCheck(L_0);
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_1 = Rigidbody_get_position_m478D060638E43DE3AE9C931A42593484B8310113(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClass7d::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass7d__ctor_m1E43E11D8142C85B3CA068B8CA58E37532DE9F29 (U3CU3Ec__DisplayClass7d_tAF739539C02E5E3135C7304E0236701AB93FC5C0 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Quaternion DG.Tweening.ShortcutExtensions_<>c__DisplayClass7d::<DORotate>b__7c()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  U3CU3Ec__DisplayClass7d_U3CDORotateU3Eb__7c_m1473F40BCB3F7E770E0E8EF43B947EE7E9A3981A (U3CU3Ec__DisplayClass7d_tAF739539C02E5E3135C7304E0236701AB93FC5C0 * __this, const RuntimeMethod* method)
{
	{
		Rigidbody_tE0A58EE5A1F7DC908EFFB4F0D795AC9552A750A5 * L_0 = __this->get_target_0();
		NullCheck(L_0);
		Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  L_1 = Rigidbody_get_rotation_mD967DD98F16F80C0D74F8F1C25953D0609906BE5(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClass92::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass92__ctor_m7760C3EC180A48E2E239A69ED85C116733CA1E09 (U3CU3Ec__DisplayClass92_tA75A43DD789C96E30D590D2F545C94EC69589DA6 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Vector3 DG.Tweening.ShortcutExtensions_<>c__DisplayClass92::<DOMove>b__90()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  U3CU3Ec__DisplayClass92_U3CDOMoveU3Eb__90_m9FAA60732843BDB190B1976C5DBE21C2B099F1C7 (U3CU3Ec__DisplayClass92_tA75A43DD789C96E30D590D2F545C94EC69589DA6 * __this, const RuntimeMethod* method)
{
	{
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_0 = __this->get_target_0();
		NullCheck(L_0);
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_1 = Transform_get_position_mF54C3A064F7C8E24F1C56EE128728B2E4485E294(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClass92::<DOMove>b__91(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass92_U3CDOMoveU3Eb__91_mD35A60DA4AEED69DB2A8744719EA70B47210E770 (U3CU3Ec__DisplayClass92_tA75A43DD789C96E30D590D2F545C94EC69589DA6 * __this, Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___x0, const RuntimeMethod* method)
{
	{
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_0 = __this->get_target_0();
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_1 = ___x0;
		NullCheck(L_0);
		Transform_set_position_mDA89E4893F14ECA5CBEEE7FB80A5BF7C1B8EA6DC(L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClass96::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass96__ctor_mD3A5EC542056A493F3FB52316127F66A845961C2 (U3CU3Ec__DisplayClass96_t5EC6E6D72824408D93A7F57ECAF35DB96FCD6D67 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Vector3 DG.Tweening.ShortcutExtensions_<>c__DisplayClass96::<DOMoveX>b__94()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  U3CU3Ec__DisplayClass96_U3CDOMoveXU3Eb__94_m9E58CB074B46BB5D7B162CC201AD82D523AF0A54 (U3CU3Ec__DisplayClass96_t5EC6E6D72824408D93A7F57ECAF35DB96FCD6D67 * __this, const RuntimeMethod* method)
{
	{
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_0 = __this->get_target_0();
		NullCheck(L_0);
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_1 = Transform_get_position_mF54C3A064F7C8E24F1C56EE128728B2E4485E294(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClass96::<DOMoveX>b__95(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass96_U3CDOMoveXU3Eb__95_m62DF81031A0772452D2F3241AF0875B0DCFFE1D8 (U3CU3Ec__DisplayClass96_t5EC6E6D72824408D93A7F57ECAF35DB96FCD6D67 * __this, Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___x0, const RuntimeMethod* method)
{
	{
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_0 = __this->get_target_0();
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_1 = ___x0;
		NullCheck(L_0);
		Transform_set_position_mDA89E4893F14ECA5CBEEE7FB80A5BF7C1B8EA6DC(L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClassa::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClassa__ctor_m72F65726A3CA315F3E36547E0F8B76289241F67F (U3CU3Ec__DisplayClassa_tC915AA461E4FD5AE3D48A51D677710E64F437E96 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Single DG.Tweening.ShortcutExtensions_<>c__DisplayClassa::<DOAspect>b__8()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float U3CU3Ec__DisplayClassa_U3CDOAspectU3Eb__8_m95CD07A62BFF5A346A9970FE27E08BE95402E122 (U3CU3Ec__DisplayClassa_tC915AA461E4FD5AE3D48A51D677710E64F437E96 * __this, const RuntimeMethod* method)
{
	{
		Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * L_0 = __this->get_target_0();
		NullCheck(L_0);
		float L_1 = Camera_get_aspect_m2ADA7982754920C3B58B4DB664801D6F2416E0C6(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClassa::<DOAspect>b__9(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClassa_U3CDOAspectU3Eb__9_m62DDCCE3CC2A3A7798F83E9674A307E3D820F163 (U3CU3Ec__DisplayClassa_tC915AA461E4FD5AE3D48A51D677710E64F437E96 * __this, float ___x0, const RuntimeMethod* method)
{
	{
		Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * L_0 = __this->get_target_0();
		float L_1 = ___x0;
		NullCheck(L_0);
		Camera_set_aspect_m84BE4641686B30B8F9FFEA47BB1D7D88E27344EE(L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClassa2::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClassa2__ctor_m32E97FE8C1DB41599AFA240F2514A44B35A65869 (U3CU3Ec__DisplayClassa2_t9AD84E358FF7A7DFD16DC2C4CDED2462E72C4C8E * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Vector3 DG.Tweening.ShortcutExtensions_<>c__DisplayClassa2::<DOLocalMove>b__a0()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  U3CU3Ec__DisplayClassa2_U3CDOLocalMoveU3Eb__a0_mCA98EB7730BC9B8B502BC41A97D4E77AC9F5D7D9 (U3CU3Ec__DisplayClassa2_t9AD84E358FF7A7DFD16DC2C4CDED2462E72C4C8E * __this, const RuntimeMethod* method)
{
	{
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_0 = __this->get_target_0();
		NullCheck(L_0);
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_1 = Transform_get_localPosition_m812D43318E05BDCB78310EB7308785A13D85EFD8(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClassa2::<DOLocalMove>b__a1(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClassa2_U3CDOLocalMoveU3Eb__a1_m89EFAFC717ACD5512B511EF4876ABCF2088897BA (U3CU3Ec__DisplayClassa2_t9AD84E358FF7A7DFD16DC2C4CDED2462E72C4C8E * __this, Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___x0, const RuntimeMethod* method)
{
	{
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_0 = __this->get_target_0();
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_1 = ___x0;
		NullCheck(L_0);
		Transform_set_localPosition_m275F5550DD939F83AFEB5E8D681131172E2E1728(L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClassb2::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClassb2__ctor_m07B9F785D790C3A7C8D341C4B4A92DE6A0F739BF (U3CU3Ec__DisplayClassb2_tDE677984DFFECB80EF616D9A6D4D2075C35028E6 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Quaternion DG.Tweening.ShortcutExtensions_<>c__DisplayClassb2::<DORotate>b__b0()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  U3CU3Ec__DisplayClassb2_U3CDORotateU3Eb__b0_m69C630B55F5E128671140F17DBC9F612476CAAB8 (U3CU3Ec__DisplayClassb2_tDE677984DFFECB80EF616D9A6D4D2075C35028E6 * __this, const RuntimeMethod* method)
{
	{
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_0 = __this->get_target_0();
		NullCheck(L_0);
		Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  L_1 = Transform_get_rotation_m3AB90A67403249AECCA5E02BC70FCE8C90FE9FB9(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClassb2::<DORotate>b__b1(UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClassb2_U3CDORotateU3Eb__b1_mBAE3502AE4B704930B2C3971FDEAE7A514D1A515 (U3CU3Ec__DisplayClassb2_tDE677984DFFECB80EF616D9A6D4D2075C35028E6 * __this, Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  ___x0, const RuntimeMethod* method)
{
	{
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_0 = __this->get_target_0();
		Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  L_1 = ___x0;
		NullCheck(L_0);
		Transform_set_rotation_m429694E264117C6DC682EC6AF45C7864E5155935(L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClassb6::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClassb6__ctor_m551E72CF153366A28D46F4DFF4F7C96F5DC91EF4 (U3CU3Ec__DisplayClassb6_t2BFB12249855A8FE2A74C4B29DDA349C49573ED2 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Quaternion DG.Tweening.ShortcutExtensions_<>c__DisplayClassb6::<DOLocalRotate>b__b4()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  U3CU3Ec__DisplayClassb6_U3CDOLocalRotateU3Eb__b4_m0C620406111D87BFB98192E14A422F2961A62155 (U3CU3Ec__DisplayClassb6_t2BFB12249855A8FE2A74C4B29DDA349C49573ED2 * __this, const RuntimeMethod* method)
{
	{
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_0 = __this->get_target_0();
		NullCheck(L_0);
		Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  L_1 = Transform_get_localRotation_mEDA319E1B42EF12A19A95AC0824345B6574863FE(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClassb6::<DOLocalRotate>b__b5(UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClassb6_U3CDOLocalRotateU3Eb__b5_m6C9F6A2161CF3085CD17DA16399DD39587B888C7 (U3CU3Ec__DisplayClassb6_t2BFB12249855A8FE2A74C4B29DDA349C49573ED2 * __this, Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  ___x0, const RuntimeMethod* method)
{
	{
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_0 = __this->get_target_0();
		Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  L_1 = ___x0;
		NullCheck(L_0);
		Transform_set_localRotation_mE2BECB0954FFC1D93FB631600D9A9BEFF41D9C8A(L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClassba::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClassba__ctor_mFA9E1981B9D7D9836CC9EE5C20B0A607A7F8E9B2 (U3CU3Ec__DisplayClassba_t0A65EB02F44732F72DA15E4767826F7318A5558E * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Vector3 DG.Tweening.ShortcutExtensions_<>c__DisplayClassba::<DOScale>b__b8()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  U3CU3Ec__DisplayClassba_U3CDOScaleU3Eb__b8_m09D5CAE93F715CF90C9B7AAED3F14549F7462302 (U3CU3Ec__DisplayClassba_t0A65EB02F44732F72DA15E4767826F7318A5558E * __this, const RuntimeMethod* method)
{
	{
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_0 = __this->get_target_0();
		NullCheck(L_0);
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_1 = Transform_get_localScale_mD8F631021C2D62B7C341B1A17FA75491F64E13DA(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClassba::<DOScale>b__b9(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClassba_U3CDOScaleU3Eb__b9_mBCBC855A31DDFE0E1E182AC01B9F623328D5C3D3 (U3CU3Ec__DisplayClassba_t0A65EB02F44732F72DA15E4767826F7318A5558E * __this, Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___x0, const RuntimeMethod* method)
{
	{
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_0 = __this->get_target_0();
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_1 = ___x0;
		NullCheck(L_0);
		Transform_set_localScale_m7ED1A6E5A87CD1D483515B99D6D3121FB92B0556(L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClassbe::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClassbe__ctor_m27E1A8B272D48B630D143ADF78486BEADABE9C89 (U3CU3Ec__DisplayClassbe_t1186133747C674242AF1F941435C43C73D9B2CD2 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Vector3 DG.Tweening.ShortcutExtensions_<>c__DisplayClassbe::<DOScale>b__bc()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  U3CU3Ec__DisplayClassbe_U3CDOScaleU3Eb__bc_m02BF6B96C5F3C0526C142AF48BCF5E08B01F3DB4 (U3CU3Ec__DisplayClassbe_t1186133747C674242AF1F941435C43C73D9B2CD2 * __this, const RuntimeMethod* method)
{
	{
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_0 = __this->get_target_0();
		NullCheck(L_0);
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_1 = Transform_get_localScale_mD8F631021C2D62B7C341B1A17FA75491F64E13DA(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClassbe::<DOScale>b__bd(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClassbe_U3CDOScaleU3Eb__bd_m5FE40DCAEB18668C1CD2361FD6340E48FBA9CFA3 (U3CU3Ec__DisplayClassbe_t1186133747C674242AF1F941435C43C73D9B2CD2 * __this, Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___x0, const RuntimeMethod* method)
{
	{
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_0 = __this->get_target_0();
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_1 = ___x0;
		NullCheck(L_0);
		Transform_set_localScale_m7ED1A6E5A87CD1D483515B99D6D3121FB92B0556(L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClassd2::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClassd2__ctor_m6A2771865156CBD6D67AB6858DB1B3DD5F0373CE (U3CU3Ec__DisplayClassd2_t2E49EDC8ED935AAE089A256C17B0F4810A868E1E * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Vector3 DG.Tweening.ShortcutExtensions_<>c__DisplayClassd2::<DOPunchPosition>b__d0()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  U3CU3Ec__DisplayClassd2_U3CDOPunchPositionU3Eb__d0_mB7318CA786CC733062B4B38A1A611439DF397956 (U3CU3Ec__DisplayClassd2_t2E49EDC8ED935AAE089A256C17B0F4810A868E1E * __this, const RuntimeMethod* method)
{
	{
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_0 = __this->get_target_0();
		NullCheck(L_0);
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_1 = Transform_get_localPosition_m812D43318E05BDCB78310EB7308785A13D85EFD8(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClassd2::<DOPunchPosition>b__d1(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClassd2_U3CDOPunchPositionU3Eb__d1_m2B07116F4531F367E03F67BA5707744FFF5E25D1 (U3CU3Ec__DisplayClassd2_t2E49EDC8ED935AAE089A256C17B0F4810A868E1E * __this, Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___x0, const RuntimeMethod* method)
{
	{
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_0 = __this->get_target_0();
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_1 = ___x0;
		NullCheck(L_0);
		Transform_set_localPosition_m275F5550DD939F83AFEB5E8D681131172E2E1728(L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClassd6::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClassd6__ctor_m02509040388A7366908BDE57D9C3844142D51B3A (U3CU3Ec__DisplayClassd6_tDD8BC433E9E2A0F72AC9DEDA1BC64AFFBEA6DC1A * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Vector3 DG.Tweening.ShortcutExtensions_<>c__DisplayClassd6::<DOPunchScale>b__d4()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  U3CU3Ec__DisplayClassd6_U3CDOPunchScaleU3Eb__d4_m8A58CB1D89A4C6642ED0102C6D7829697CCE13D7 (U3CU3Ec__DisplayClassd6_tDD8BC433E9E2A0F72AC9DEDA1BC64AFFBEA6DC1A * __this, const RuntimeMethod* method)
{
	{
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_0 = __this->get_target_0();
		NullCheck(L_0);
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_1 = Transform_get_localScale_mD8F631021C2D62B7C341B1A17FA75491F64E13DA(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClassd6::<DOPunchScale>b__d5(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClassd6_U3CDOPunchScaleU3Eb__d5_m74538C9AE3536BB8A166ADEDC7215CF1CF04A25F (U3CU3Ec__DisplayClassd6_tDD8BC433E9E2A0F72AC9DEDA1BC64AFFBEA6DC1A * __this, Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___x0, const RuntimeMethod* method)
{
	{
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_0 = __this->get_target_0();
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_1 = ___x0;
		NullCheck(L_0);
		Transform_set_localScale_m7ED1A6E5A87CD1D483515B99D6D3121FB92B0556(L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClassda::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClassda__ctor_mA631B0B3FB30D4C01168AB9BE794454007DBED97 (U3CU3Ec__DisplayClassda_t1B3A1757D73FF007687F7F4EFC16AD0000C405C0 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Vector3 DG.Tweening.ShortcutExtensions_<>c__DisplayClassda::<DOPunchRotation>b__d8()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  U3CU3Ec__DisplayClassda_U3CDOPunchRotationU3Eb__d8_m2625DF26A82F339A7DADFBA719A56D427C7F222E (U3CU3Ec__DisplayClassda_t1B3A1757D73FF007687F7F4EFC16AD0000C405C0 * __this, const RuntimeMethod* method)
{
	{
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_0 = __this->get_target_0();
		NullCheck(L_0);
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_1 = Transform_get_localEulerAngles_m445AD7F6706B0BDABA8A875C899EB1E1DF1A2A2B(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClassda::<DOPunchRotation>b__d9(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClassda_U3CDOPunchRotationU3Eb__d9_m568D23843369C037DF422F366359694019CABEF9 (U3CU3Ec__DisplayClassda_t1B3A1757D73FF007687F7F4EFC16AD0000C405C0 * __this, Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___x0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (U3CU3Ec__DisplayClassda_U3CDOPunchRotationU3Eb__d9_m568D23843369C037DF422F366359694019CABEF9_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_0 = __this->get_target_0();
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_1 = ___x0;
		IL2CPP_RUNTIME_CLASS_INIT(Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357_il2cpp_TypeInfo_var);
		Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  L_2 = Quaternion_Euler_m55C96FCD397CC69109261572710608D12A4CBD2B(L_1, /*hidden argument*/NULL);
		NullCheck(L_0);
		Transform_set_localRotation_mE2BECB0954FFC1D93FB631600D9A9BEFF41D9C8A(L_0, L_2, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClasse::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClasse__ctor_mFA7A76AC3A2EECCA6D826710E318038EC6CB85CA (U3CU3Ec__DisplayClasse_tDC794AB97B18E7819CBEFA7BBA29B61CE76EBF6A * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Color DG.Tweening.ShortcutExtensions_<>c__DisplayClasse::<DOColor>b__c()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color_t119BCA590009762C7223FDD3AF9706653AC84ED2  U3CU3Ec__DisplayClasse_U3CDOColorU3Eb__c_m1D2097564CAEB5BA2D4B5357374D880E9A5B43B1 (U3CU3Ec__DisplayClasse_tDC794AB97B18E7819CBEFA7BBA29B61CE76EBF6A * __this, const RuntimeMethod* method)
{
	{
		Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * L_0 = __this->get_target_0();
		NullCheck(L_0);
		Color_t119BCA590009762C7223FDD3AF9706653AC84ED2  L_1 = Camera_get_backgroundColor_m14496C5DC24582D7227277AF71DBE96F8E9E64FF(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClasse::<DOColor>b__d(UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClasse_U3CDOColorU3Eb__d_m7FF6518F582944FCD6F8E57FD82D919D88AD0A49 (U3CU3Ec__DisplayClasse_tDC794AB97B18E7819CBEFA7BBA29B61CE76EBF6A * __this, Color_t119BCA590009762C7223FDD3AF9706653AC84ED2  ___x0, const RuntimeMethod* method)
{
	{
		Camera_t48B2B9ECB3CE6108A98BF949A1CECF0FE3421F34 * L_0 = __this->get_target_0();
		Color_t119BCA590009762C7223FDD3AF9706653AC84ED2  L_1 = ___x0;
		NullCheck(L_0);
		Camera_set_backgroundColor_mDB9CA1B37FE2D52493823914AC5BC9F8C1935D6F(L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClasse2::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClasse2__ctor_mCF811BBB366D470D9694EFE3BF2E10C9CB3C4417 (U3CU3Ec__DisplayClasse2_t7B9A4AEA17B3EBAD85BDAE3DE6094EC7B673379A * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Vector3 DG.Tweening.ShortcutExtensions_<>c__DisplayClasse2::<DOShakePosition>b__e0()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  U3CU3Ec__DisplayClasse2_U3CDOShakePositionU3Eb__e0_m75FDD164FB2346EBD3A7EA3567CCCD0EA1EB9447 (U3CU3Ec__DisplayClasse2_t7B9A4AEA17B3EBAD85BDAE3DE6094EC7B673379A * __this, const RuntimeMethod* method)
{
	{
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_0 = __this->get_target_0();
		NullCheck(L_0);
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_1 = Transform_get_localPosition_m812D43318E05BDCB78310EB7308785A13D85EFD8(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClasse2::<DOShakePosition>b__e1(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClasse2_U3CDOShakePositionU3Eb__e1_mD9690C2E934E763B593ACAB19E9A384B6A040C47 (U3CU3Ec__DisplayClasse2_t7B9A4AEA17B3EBAD85BDAE3DE6094EC7B673379A * __this, Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___x0, const RuntimeMethod* method)
{
	{
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_0 = __this->get_target_0();
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_1 = ___x0;
		NullCheck(L_0);
		Transform_set_localPosition_m275F5550DD939F83AFEB5E8D681131172E2E1728(L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClassea::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClassea__ctor_m7DE3A24F0AF9CF52C38F949573D13DB9E4B3136B (U3CU3Ec__DisplayClassea_t93D241F4C148181D28E9E5CA8159DBA36845D6E4 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Vector3 DG.Tweening.ShortcutExtensions_<>c__DisplayClassea::<DOShakeRotation>b__e8()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  U3CU3Ec__DisplayClassea_U3CDOShakeRotationU3Eb__e8_mB6104BDC7C6E2786EA5BE369E2E0ED98C4CF4A78 (U3CU3Ec__DisplayClassea_t93D241F4C148181D28E9E5CA8159DBA36845D6E4 * __this, const RuntimeMethod* method)
{
	{
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_0 = __this->get_target_0();
		NullCheck(L_0);
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_1 = Transform_get_localEulerAngles_m445AD7F6706B0BDABA8A875C899EB1E1DF1A2A2B(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClassea::<DOShakeRotation>b__e9(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClassea_U3CDOShakeRotationU3Eb__e9_m303D35A7DDE735D3DBF19EA66C5B73396306C4E1 (U3CU3Ec__DisplayClassea_t93D241F4C148181D28E9E5CA8159DBA36845D6E4 * __this, Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___x0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (U3CU3Ec__DisplayClassea_U3CDOShakeRotationU3Eb__e9_m303D35A7DDE735D3DBF19EA66C5B73396306C4E1_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_0 = __this->get_target_0();
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_1 = ___x0;
		IL2CPP_RUNTIME_CLASS_INIT(Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357_il2cpp_TypeInfo_var);
		Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  L_2 = Quaternion_Euler_m55C96FCD397CC69109261572710608D12A4CBD2B(L_1, /*hidden argument*/NULL);
		NullCheck(L_0);
		Transform_set_localRotation_mE2BECB0954FFC1D93FB631600D9A9BEFF41D9C8A(L_0, L_2, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClassf2::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClassf2__ctor_m8195C6F802B698F3F21AE52FC0E05507AA128646 (U3CU3Ec__DisplayClassf2_tADC804C6DFA12A25797C96316169554AE845E88F * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Vector3 DG.Tweening.ShortcutExtensions_<>c__DisplayClassf2::<DOShakeScale>b__f0()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  U3CU3Ec__DisplayClassf2_U3CDOShakeScaleU3Eb__f0_mB3C57EE75CAB256BD82CF0C3E78B546DC514BAEE (U3CU3Ec__DisplayClassf2_tADC804C6DFA12A25797C96316169554AE845E88F * __this, const RuntimeMethod* method)
{
	{
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_0 = __this->get_target_0();
		NullCheck(L_0);
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_1 = Transform_get_localScale_mD8F631021C2D62B7C341B1A17FA75491F64E13DA(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Void DG.Tweening.ShortcutExtensions_<>c__DisplayClassf2::<DOShakeScale>b__f1(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClassf2_U3CDOShakeScaleU3Eb__f1_mA7D25BADF5789FD7B976D010CC6248F4A8D0C9A6 (U3CU3Ec__DisplayClassf2_tADC804C6DFA12A25797C96316169554AE845E88F * __this, Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___x0, const RuntimeMethod* method)
{
	{
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_0 = __this->get_target_0();
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_1 = ___x0;
		NullCheck(L_0);
		Transform_set_localScale_m7ED1A6E5A87CD1D483515B99D6D3121FB92B0556(L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DG.Tweening.Tween::Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Tween_Reset_m19FD86205257E86C439326E56D63778D37C9CB25 (Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * __this, const RuntimeMethod* method)
{
	TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * V_0 = NULL;
	TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * V_1 = NULL;
	TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * V_2 = NULL;
	TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * V_3 = NULL;
	TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * V_4 = NULL;
	TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * V_5 = NULL;
	bool V_6 = false;
	bool V_7 = false;
	int32_t V_8 = 0;
	float V_9 = 0.0f;
	bool V_10 = false;
	{
		__this->set_timeScale_4((1.0f));
		__this->set_isBackwards_5((bool)0);
		__this->set_id_6(NULL);
		__this->set_isIndependentUpdate_9((bool)0);
		V_0 = (TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 *)NULL;
		__this->set_onKill_16((TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 *)NULL);
		TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * L_0 = V_0;
		TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * L_1 = L_0;
		V_1 = L_1;
		__this->set_onStepComplete_14(L_1);
		TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * L_2 = V_1;
		TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * L_3 = L_2;
		V_2 = L_3;
		__this->set_onComplete_15(L_3);
		TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * L_4 = V_2;
		TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * L_5 = L_4;
		V_3 = L_5;
		__this->set_onUpdate_13(L_5);
		TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * L_6 = V_3;
		TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * L_7 = L_6;
		V_4 = L_7;
		__this->set_onRewind_12(L_7);
		TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * L_8 = V_4;
		TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * L_9 = L_8;
		V_5 = L_9;
		__this->set_onPlay_10(L_9);
		TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * L_10 = V_5;
		((ABSSequentiable_tDA1366907669973CC0BB553EF4159D45FC46A757 *)__this)->set_onStart_3(L_10);
		__this->set_onWaypointChange_17((TweenCallback_1_t46CB97F053453C4F41F8AE6213792813E455DDE1 *)NULL);
		__this->set_target_7(NULL);
		__this->set_isFrom_18((bool)0);
		__this->set_isBlendable_19((bool)0);
		__this->set_isSpeedBased_21((bool)0);
		__this->set_duration_23((0.0f));
		__this->set_loops_24(1);
		__this->set_delay_26((0.0f));
		__this->set_isRelative_27((bool)0);
		__this->set_customEase_29((EaseFunction_tAC315FE3B057AC8DA87991C785F2595F3B761691 *)NULL);
		__this->set_isSequenced_36((bool)0);
		__this->set_sequenceParent_37((Sequence_tA6FA099F465933113D131DDC0EECB6A19A27BCB2 *)NULL);
		__this->set_specialStartupMode_39(0);
		int32_t L_11 = 0;
		V_6 = (bool)L_11;
		__this->set_playedOnce_42((bool)L_11);
		bool L_12 = V_6;
		bool L_13 = L_12;
		V_7 = L_13;
		__this->set_startupDone_41(L_13);
		bool L_14 = V_7;
		__this->set_creationLocked_40(L_14);
		int32_t L_15 = 0;
		V_8 = L_15;
		__this->set_completedLoops_45(L_15);
		int32_t L_16 = V_8;
		float L_17 = (((float)((float)L_16)));
		V_9 = L_17;
		__this->set_fullDuration_44(L_17);
		float L_18 = V_9;
		__this->set_position_43(L_18);
		int32_t L_19 = 0;
		V_10 = (bool)L_19;
		__this->set_isComplete_47((bool)L_19);
		bool L_20 = V_10;
		__this->set_isPlaying_46(L_20);
		__this->set_elapsedDelay_48((0.0f));
		__this->set_delayComplete_49((bool)1);
		__this->set_miscInt_50((-1));
		return;
	}
}
// System.Single DG.Tweening.Tween::UpdateDelay(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Tween_UpdateDelay_mEA7AF731935210EF6B87485EB0F2A342C49B73F6 (Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * __this, float ___elapsed0, const RuntimeMethod* method)
{
	{
		return (0.0f);
	}
}
// System.Boolean DG.Tweening.Tween::DoGoto(DG.Tweening.Tween,System.Single,System.Int32,DG.Tweening.Core.Enums.UpdateMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Tween_DoGoto_mB1D6E7D8535744E5030B21129B9B396CEC6BBE60 (Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * ___t0, float ___toPosition1, int32_t ___toCompletedLoops2, int32_t ___updateMode3, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	int32_t V_1 = 0;
	bool V_2 = false;
	bool V_3 = false;
	int32_t V_4 = 0;
	bool V_5 = false;
	bool V_6 = false;
	int32_t V_7 = 0;
	int32_t V_8 = 0;
	int32_t G_B14_0 = 0;
	int32_t G_B24_0 = 0;
	int32_t G_B29_0 = 0;
	Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * G_B45_0 = NULL;
	Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * G_B44_0 = NULL;
	int32_t G_B46_0 = 0;
	Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * G_B46_1 = NULL;
	int32_t G_B52_0 = 0;
	int32_t G_B59_0 = 0;
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_0 = ___t0;
		NullCheck(L_0);
		bool L_1 = L_0->get_startupDone_41();
		if (L_1)
		{
			goto IL_0012;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_2 = ___t0;
		NullCheck(L_2);
		bool L_3 = VirtFuncInvoker0< bool >::Invoke(7 /* System.Boolean DG.Tweening.Tween::Startup() */, L_2);
		if (L_3)
		{
			goto IL_0012;
		}
	}
	{
		return (bool)1;
	}

IL_0012:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_4 = ___t0;
		NullCheck(L_4);
		bool L_5 = L_4->get_playedOnce_42();
		if (L_5)
		{
			goto IL_0060;
		}
	}
	{
		int32_t L_6 = ___updateMode3;
		if (L_6)
		{
			goto IL_0060;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_7 = ___t0;
		NullCheck(L_7);
		L_7->set_playedOnce_42((bool)1);
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_8 = ___t0;
		NullCheck(L_8);
		TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * L_9 = ((ABSSequentiable_tDA1366907669973CC0BB553EF4159D45FC46A757 *)L_8)->get_onStart_3();
		if (!L_9)
		{
			goto IL_0042;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_10 = ___t0;
		NullCheck(L_10);
		TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * L_11 = ((ABSSequentiable_tDA1366907669973CC0BB553EF4159D45FC46A757 *)L_10)->get_onStart_3();
		Tween_OnTweenCallback_m31509BCFB6D15BB7765CF28E7B6E0738DC88B659(L_11, /*hidden argument*/NULL);
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_12 = ___t0;
		NullCheck(L_12);
		bool L_13 = L_12->get_active_35();
		if (L_13)
		{
			goto IL_0042;
		}
	}
	{
		return (bool)1;
	}

IL_0042:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_14 = ___t0;
		NullCheck(L_14);
		TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * L_15 = L_14->get_onPlay_10();
		if (!L_15)
		{
			goto IL_0060;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_16 = ___t0;
		NullCheck(L_16);
		TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * L_17 = L_16->get_onPlay_10();
		Tween_OnTweenCallback_m31509BCFB6D15BB7765CF28E7B6E0738DC88B659(L_17, /*hidden argument*/NULL);
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_18 = ___t0;
		NullCheck(L_18);
		bool L_19 = L_18->get_active_35();
		if (L_19)
		{
			goto IL_0060;
		}
	}
	{
		return (bool)1;
	}

IL_0060:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_20 = ___t0;
		NullCheck(L_20);
		float L_21 = L_20->get_position_43();
		V_0 = L_21;
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_22 = ___t0;
		NullCheck(L_22);
		int32_t L_23 = L_22->get_completedLoops_45();
		V_1 = L_23;
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_24 = ___t0;
		int32_t L_25 = ___toCompletedLoops2;
		NullCheck(L_24);
		L_24->set_completedLoops_45(L_25);
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_26 = ___t0;
		NullCheck(L_26);
		float L_27 = L_26->get_position_43();
		if ((!(((float)L_27) <= ((float)(0.0f)))))
		{
			goto IL_008b;
		}
	}
	{
		int32_t L_28 = V_1;
		G_B14_0 = ((((int32_t)((((int32_t)L_28) > ((int32_t)0))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		goto IL_008c;
	}

IL_008b:
	{
		G_B14_0 = 0;
	}

IL_008c:
	{
		V_2 = (bool)G_B14_0;
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_29 = ___t0;
		NullCheck(L_29);
		bool L_30 = L_29->get_isComplete_47();
		V_3 = L_30;
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_31 = ___t0;
		NullCheck(L_31);
		int32_t L_32 = L_31->get_loops_24();
		if ((((int32_t)L_32) == ((int32_t)(-1))))
		{
			goto IL_00b1;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_33 = ___t0;
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_34 = ___t0;
		NullCheck(L_34);
		int32_t L_35 = L_34->get_completedLoops_45();
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_36 = ___t0;
		NullCheck(L_36);
		int32_t L_37 = L_36->get_loops_24();
		NullCheck(L_33);
		L_33->set_isComplete_47((bool)((((int32_t)L_35) == ((int32_t)L_37))? 1 : 0));
	}

IL_00b1:
	{
		V_4 = 0;
		int32_t L_38 = ___updateMode3;
		if (L_38)
		{
			goto IL_0106;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_39 = ___t0;
		NullCheck(L_39);
		bool L_40 = L_39->get_isBackwards_5();
		if (!L_40)
		{
			goto IL_00ee;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_41 = ___t0;
		NullCheck(L_41);
		int32_t L_42 = L_41->get_completedLoops_45();
		int32_t L_43 = V_1;
		if ((((int32_t)L_42) < ((int32_t)L_43)))
		{
			goto IL_00d9;
		}
	}
	{
		float L_44 = ___toPosition1;
		if ((!(((float)L_44) <= ((float)(0.0f)))))
		{
			goto IL_00d3;
		}
	}
	{
		bool L_45 = V_2;
		if (!L_45)
		{
			goto IL_00d6;
		}
	}

IL_00d3:
	{
		G_B24_0 = 0;
		goto IL_00e1;
	}

IL_00d6:
	{
		G_B24_0 = 1;
		goto IL_00e1;
	}

IL_00d9:
	{
		int32_t L_46 = V_1;
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_47 = ___t0;
		NullCheck(L_47);
		int32_t L_48 = L_47->get_completedLoops_45();
		G_B24_0 = ((int32_t)il2cpp_codegen_subtract((int32_t)L_46, (int32_t)L_48));
	}

IL_00e1:
	{
		V_4 = G_B24_0;
		bool L_49 = V_3;
		if (!L_49)
		{
			goto IL_011e;
		}
	}
	{
		int32_t L_50 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_subtract((int32_t)L_50, (int32_t)1));
		goto IL_011e;
	}

IL_00ee:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_51 = ___t0;
		NullCheck(L_51);
		int32_t L_52 = L_51->get_completedLoops_45();
		int32_t L_53 = V_1;
		if ((((int32_t)L_52) > ((int32_t)L_53)))
		{
			goto IL_00fa;
		}
	}
	{
		G_B29_0 = 0;
		goto IL_0102;
	}

IL_00fa:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_54 = ___t0;
		NullCheck(L_54);
		int32_t L_55 = L_54->get_completedLoops_45();
		int32_t L_56 = V_1;
		G_B29_0 = ((int32_t)il2cpp_codegen_subtract((int32_t)L_55, (int32_t)L_56));
	}

IL_0102:
	{
		V_4 = G_B29_0;
		goto IL_011e;
	}

IL_0106:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_57 = ___t0;
		NullCheck(L_57);
		int32_t L_58 = ((ABSSequentiable_tDA1366907669973CC0BB553EF4159D45FC46A757 *)L_57)->get_tweenType_0();
		if ((!(((uint32_t)L_58) == ((uint32_t)1))))
		{
			goto IL_011e;
		}
	}
	{
		int32_t L_59 = V_1;
		int32_t L_60 = ___toCompletedLoops2;
		V_4 = ((int32_t)il2cpp_codegen_subtract((int32_t)L_59, (int32_t)L_60));
		int32_t L_61 = V_4;
		if ((((int32_t)L_61) >= ((int32_t)0)))
		{
			goto IL_011e;
		}
	}
	{
		int32_t L_62 = V_4;
		V_4 = ((-L_62));
	}

IL_011e:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_63 = ___t0;
		float L_64 = ___toPosition1;
		NullCheck(L_63);
		L_63->set_position_43(L_64);
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_65 = ___t0;
		NullCheck(L_65);
		float L_66 = L_65->get_position_43();
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_67 = ___t0;
		NullCheck(L_67);
		float L_68 = L_67->get_duration_23();
		if ((!(((float)L_66) > ((float)L_68))))
		{
			goto IL_0141;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_69 = ___t0;
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_70 = ___t0;
		NullCheck(L_70);
		float L_71 = L_70->get_duration_23();
		NullCheck(L_69);
		L_69->set_position_43(L_71);
		goto IL_0178;
	}

IL_0141:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_72 = ___t0;
		NullCheck(L_72);
		float L_73 = L_72->get_position_43();
		if ((!(((float)L_73) <= ((float)(0.0f)))))
		{
			goto IL_0178;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_74 = ___t0;
		NullCheck(L_74);
		int32_t L_75 = L_74->get_completedLoops_45();
		if ((((int32_t)L_75) > ((int32_t)0)))
		{
			goto IL_015f;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_76 = ___t0;
		NullCheck(L_76);
		bool L_77 = L_76->get_isComplete_47();
		if (!L_77)
		{
			goto IL_016d;
		}
	}

IL_015f:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_78 = ___t0;
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_79 = ___t0;
		NullCheck(L_79);
		float L_80 = L_79->get_duration_23();
		NullCheck(L_78);
		L_78->set_position_43(L_80);
		goto IL_0178;
	}

IL_016d:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_81 = ___t0;
		NullCheck(L_81);
		L_81->set_position_43((0.0f));
	}

IL_0178:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_82 = ___t0;
		NullCheck(L_82);
		bool L_83 = L_82->get_isPlaying_46();
		V_5 = L_83;
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_84 = ___t0;
		NullCheck(L_84);
		bool L_85 = L_84->get_isPlaying_46();
		if (!L_85)
		{
			goto IL_01bf;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_86 = ___t0;
		NullCheck(L_86);
		bool L_87 = L_86->get_isBackwards_5();
		if (L_87)
		{
			goto IL_01a1;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_88 = ___t0;
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_89 = ___t0;
		NullCheck(L_89);
		bool L_90 = L_89->get_isComplete_47();
		NullCheck(L_88);
		L_88->set_isPlaying_46((bool)((((int32_t)L_90) == ((int32_t)0))? 1 : 0));
		goto IL_01bf;
	}

IL_01a1:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_91 = ___t0;
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_92 = ___t0;
		NullCheck(L_92);
		int32_t L_93 = L_92->get_completedLoops_45();
		G_B44_0 = L_91;
		if (L_93)
		{
			G_B45_0 = L_91;
			goto IL_01b9;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_94 = ___t0;
		NullCheck(L_94);
		float L_95 = L_94->get_position_43();
		G_B46_0 = ((!(((float)L_95) <= ((float)(0.0f))))? 1 : 0);
		G_B46_1 = G_B44_0;
		goto IL_01ba;
	}

IL_01b9:
	{
		G_B46_0 = 1;
		G_B46_1 = G_B45_0;
	}

IL_01ba:
	{
		NullCheck(G_B46_1);
		G_B46_1->set_isPlaying_46((bool)G_B46_0);
	}

IL_01bf:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_96 = ___t0;
		NullCheck(L_96);
		int32_t L_97 = L_96->get_loopType_25();
		if ((!(((uint32_t)L_97) == ((uint32_t)1))))
		{
			goto IL_01f3;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_98 = ___t0;
		NullCheck(L_98);
		float L_99 = L_98->get_position_43();
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_100 = ___t0;
		NullCheck(L_100);
		float L_101 = L_100->get_duration_23();
		if ((((float)L_99) < ((float)L_101)))
		{
			goto IL_01e3;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_102 = ___t0;
		NullCheck(L_102);
		int32_t L_103 = L_102->get_completedLoops_45();
		G_B52_0 = ((((int32_t)((int32_t)((int32_t)L_103%(int32_t)2))) == ((int32_t)0))? 1 : 0);
		goto IL_01f4;
	}

IL_01e3:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_104 = ___t0;
		NullCheck(L_104);
		int32_t L_105 = L_104->get_completedLoops_45();
		G_B52_0 = ((((int32_t)((((int32_t)((int32_t)((int32_t)L_105%(int32_t)2))) == ((int32_t)0))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		goto IL_01f4;
	}

IL_01f3:
	{
		G_B52_0 = 0;
	}

IL_01f4:
	{
		V_6 = (bool)G_B52_0;
		bool L_106 = V_2;
		if (L_106)
		{
			goto IL_0220;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_107 = ___t0;
		NullCheck(L_107);
		int32_t L_108 = L_107->get_loopType_25();
		if (L_108)
		{
			goto IL_020a;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_109 = ___t0;
		NullCheck(L_109);
		int32_t L_110 = L_109->get_completedLoops_45();
		int32_t L_111 = V_1;
		if ((!(((uint32_t)L_110) == ((uint32_t)L_111))))
		{
			goto IL_0223;
		}
	}

IL_020a:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_112 = ___t0;
		NullCheck(L_112);
		float L_113 = L_112->get_position_43();
		if ((!(((float)L_113) <= ((float)(0.0f)))))
		{
			goto IL_0220;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_114 = ___t0;
		NullCheck(L_114);
		int32_t L_115 = L_114->get_completedLoops_45();
		if ((((int32_t)L_115) <= ((int32_t)0)))
		{
			goto IL_0223;
		}
	}

IL_0220:
	{
		G_B59_0 = 0;
		goto IL_0224;
	}

IL_0223:
	{
		G_B59_0 = 1;
	}

IL_0224:
	{
		V_7 = G_B59_0;
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_116 = ___t0;
		float L_117 = V_0;
		int32_t L_118 = V_1;
		int32_t L_119 = V_4;
		bool L_120 = V_6;
		int32_t L_121 = ___updateMode3;
		int32_t L_122 = V_7;
		NullCheck(L_116);
		bool L_123 = VirtFuncInvoker6< bool, float, int32_t, int32_t, bool, int32_t, int32_t >::Invoke(8 /* System.Boolean DG.Tweening.Tween::ApplyTween(System.Single,System.Int32,System.Int32,System.Boolean,DG.Tweening.Core.Enums.UpdateMode,DG.Tweening.Core.Enums.UpdateNotice) */, L_116, L_117, L_118, L_119, L_120, L_121, L_122);
		if (!L_123)
		{
			goto IL_0239;
		}
	}
	{
		return (bool)1;
	}

IL_0239:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_124 = ___t0;
		NullCheck(L_124);
		TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * L_125 = L_124->get_onUpdate_13();
		if (!L_125)
		{
			goto IL_0251;
		}
	}
	{
		int32_t L_126 = ___updateMode3;
		if ((((int32_t)L_126) == ((int32_t)2)))
		{
			goto IL_0251;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_127 = ___t0;
		NullCheck(L_127);
		TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * L_128 = L_127->get_onUpdate_13();
		Tween_OnTweenCallback_m31509BCFB6D15BB7765CF28E7B6E0738DC88B659(L_128, /*hidden argument*/NULL);
	}

IL_0251:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_129 = ___t0;
		NullCheck(L_129);
		float L_130 = L_129->get_position_43();
		if ((!(((float)L_130) <= ((float)(0.0f)))))
		{
			goto IL_027e;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_131 = ___t0;
		NullCheck(L_131);
		int32_t L_132 = L_131->get_completedLoops_45();
		if ((((int32_t)L_132) > ((int32_t)0)))
		{
			goto IL_027e;
		}
	}
	{
		bool L_133 = V_2;
		if (L_133)
		{
			goto IL_027e;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_134 = ___t0;
		NullCheck(L_134);
		TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * L_135 = L_134->get_onRewind_12();
		if (!L_135)
		{
			goto IL_027e;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_136 = ___t0;
		NullCheck(L_136);
		TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * L_137 = L_136->get_onRewind_12();
		Tween_OnTweenCallback_m31509BCFB6D15BB7765CF28E7B6E0738DC88B659(L_137, /*hidden argument*/NULL);
	}

IL_027e:
	{
		int32_t L_138 = V_4;
		if ((((int32_t)L_138) <= ((int32_t)0)))
		{
			goto IL_02ab;
		}
	}
	{
		int32_t L_139 = ___updateMode3;
		if (L_139)
		{
			goto IL_02ab;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_140 = ___t0;
		NullCheck(L_140);
		TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * L_141 = L_140->get_onStepComplete_14();
		if (!L_141)
		{
			goto IL_02ab;
		}
	}
	{
		V_8 = 0;
		goto IL_02a5;
	}

IL_0293:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_142 = ___t0;
		NullCheck(L_142);
		TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * L_143 = L_142->get_onStepComplete_14();
		Tween_OnTweenCallback_m31509BCFB6D15BB7765CF28E7B6E0738DC88B659(L_143, /*hidden argument*/NULL);
		int32_t L_144 = V_8;
		V_8 = ((int32_t)il2cpp_codegen_add((int32_t)L_144, (int32_t)1));
	}

IL_02a5:
	{
		int32_t L_145 = V_8;
		int32_t L_146 = V_4;
		if ((((int32_t)L_145) < ((int32_t)L_146)))
		{
			goto IL_0293;
		}
	}

IL_02ab:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_147 = ___t0;
		NullCheck(L_147);
		bool L_148 = L_147->get_isComplete_47();
		if (!L_148)
		{
			goto IL_02ca;
		}
	}
	{
		bool L_149 = V_3;
		if (L_149)
		{
			goto IL_02ca;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_150 = ___t0;
		NullCheck(L_150);
		TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * L_151 = L_150->get_onComplete_15();
		if (!L_151)
		{
			goto IL_02ca;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_152 = ___t0;
		NullCheck(L_152);
		TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * L_153 = L_152->get_onComplete_15();
		Tween_OnTweenCallback_m31509BCFB6D15BB7765CF28E7B6E0738DC88B659(L_153, /*hidden argument*/NULL);
	}

IL_02ca:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_154 = ___t0;
		NullCheck(L_154);
		bool L_155 = L_154->get_isPlaying_46();
		if (L_155)
		{
			goto IL_02fa;
		}
	}
	{
		bool L_156 = V_5;
		if (!L_156)
		{
			goto IL_02fa;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_157 = ___t0;
		NullCheck(L_157);
		bool L_158 = L_157->get_isComplete_47();
		if (!L_158)
		{
			goto IL_02e6;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_159 = ___t0;
		NullCheck(L_159);
		bool L_160 = L_159->get_autoKill_22();
		if (L_160)
		{
			goto IL_02fa;
		}
	}

IL_02e6:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_161 = ___t0;
		NullCheck(L_161);
		TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * L_162 = L_161->get_onPause_11();
		if (!L_162)
		{
			goto IL_02fa;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_163 = ___t0;
		NullCheck(L_163);
		TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * L_164 = L_163->get_onPause_11();
		Tween_OnTweenCallback_m31509BCFB6D15BB7765CF28E7B6E0738DC88B659(L_164, /*hidden argument*/NULL);
	}

IL_02fa:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_165 = ___t0;
		NullCheck(L_165);
		bool L_166 = L_165->get_autoKill_22();
		if (!L_166)
		{
			goto IL_0309;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_167 = ___t0;
		NullCheck(L_167);
		bool L_168 = L_167->get_isComplete_47();
		return L_168;
	}

IL_0309:
	{
		return (bool)0;
	}
}
// System.Boolean DG.Tweening.Tween::OnTweenCallback(DG.Tweening.TweenCallback)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Tween_OnTweenCallback_m31509BCFB6D15BB7765CF28E7B6E0738DC88B659 (TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * ___callback0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Tween_OnTweenCallback_m31509BCFB6D15BB7765CF28E7B6E0738DC88B659_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Exception_t * V_0 = NULL;
	bool V_1 = false;
	Exception_t * __last_unhandled_exception = 0;
	NO_UNUSED_WARNING (__last_unhandled_exception);
	Exception_t * __exception_local = 0;
	NO_UNUSED_WARNING (__exception_local);
	void* __leave_targets_storage = alloca(sizeof(int32_t) * 2);
	il2cpp::utils::LeaveTargetStack __leave_targets(__leave_targets_storage);
	NO_UNUSED_WARNING (__leave_targets);
	{
		IL2CPP_RUNTIME_CLASS_INIT(DOTween_t6BB48F76E494B12781696AF3D0733CA8DC367E8D_il2cpp_TypeInfo_var);
		bool L_0 = ((DOTween_t6BB48F76E494B12781696AF3D0733CA8DC367E8D_StaticFields*)il2cpp_codegen_static_fields_for(DOTween_t6BB48F76E494B12781696AF3D0733CA8DC367E8D_il2cpp_TypeInfo_var))->get_useSafeMode_1();
		if (!L_0)
		{
			goto IL_0029;
		}
	}

IL_0007:
	try
	{ // begin try (depth: 1)
		TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * L_1 = ___callback0;
		NullCheck(L_1);
		TweenCallback_Invoke_mD2FE3DA243C1DC77043EF838081DC7BBD097DA9E(L_1, /*hidden argument*/NULL);
		goto IL_002f;
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__exception_local = (Exception_t *)e.ex;
		if(il2cpp_codegen_class_is_assignable_from (Exception_t_il2cpp_TypeInfo_var, il2cpp_codegen_object_class(e.ex)))
			goto CATCH_000f;
		throw e;
	}

CATCH_000f:
	{ // begin catch(System.Exception)
		V_0 = ((Exception_t *)__exception_local);
		Exception_t * L_2 = V_0;
		NullCheck(L_2);
		String_t* L_3 = VirtFuncInvoker0< String_t* >::Invoke(5 /* System.String System.Exception::get_Message() */, L_2);
		String_t* L_4 = String_Concat_mB78D0094592718DA6D5DB6C712A9C225631666BE(_stringLiteral349083C2E0F6FC8B25EE2DB20339807D02467792, L_3, /*hidden argument*/NULL);
		Debugger_LogWarning_mC3D1B9A9EE70C5914C44E44E3B189059B6E80D45(L_4, /*hidden argument*/NULL);
		V_1 = (bool)0;
		goto IL_0031;
	} // end catch (depth: 1)

IL_0029:
	{
		TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * L_5 = ___callback0;
		NullCheck(L_5);
		TweenCallback_Invoke_mD2FE3DA243C1DC77043EF838081DC7BBD097DA9E(L_5, /*hidden argument*/NULL);
	}

IL_002f:
	{
		return (bool)1;
	}

IL_0031:
	{
		bool L_6 = V_1;
		return L_6;
	}
}
// System.Void DG.Tweening.Tween::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Tween__ctor_m6A636EF784F92284565ABFC0513F134BBEB27E74 (Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * __this, const RuntimeMethod* method)
{
	{
		__this->set_activeId_38((-1));
		__this->set_delayComplete_49((bool)1);
		__this->set_miscInt_50((-1));
		ABSSequentiable__ctor_mC0A3D985974279B385789BC4FA4EFD616033DD31(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 (TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * __this, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)();
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(il2cpp_codegen_get_method_pointer(((RuntimeDelegate*)__this)->method));

	// Native function invocation
	il2cppPInvokeFunc();

}
// System.Void DG.Tweening.TweenCallback::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TweenCallback__ctor_m55F59E9F7AA5CC1559E7CA16B1A98A6852F1E864 (TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	__this->set_method_ptr_0(il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1));
	__this->set_method_3(___method1);
	__this->set_m_target_2(___object0);
}
// System.Void DG.Tweening.TweenCallback::Invoke()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TweenCallback_Invoke_mD2FE3DA243C1DC77043EF838081DC7BBD097DA9E (TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * __this, const RuntimeMethod* method)
{
	DelegateU5BU5D_tDFCDEE2A6322F96C0FE49AF47E9ADB8C4B294E86* delegateArrayToInvoke = __this->get_delegates_11();
	Delegate_t** delegatesToInvoke;
	il2cpp_array_size_t length;
	if (delegateArrayToInvoke != NULL)
	{
		length = delegateArrayToInvoke->max_length;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(delegateArrayToInvoke->GetAddressAtUnchecked(0));
	}
	else
	{
		length = 1;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(&__this);
	}

	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		Delegate_t* currentDelegate = delegatesToInvoke[i];
		Il2CppMethodPointer targetMethodPointer = currentDelegate->get_method_ptr_0();
		RuntimeObject* targetThis = currentDelegate->get_m_target_2();
		RuntimeMethod* targetMethod = (RuntimeMethod*)(currentDelegate->get_method_3());
		if (!il2cpp_codegen_method_is_virtual(targetMethod))
		{
			il2cpp_codegen_raise_execution_engine_exception_if_method_is_not_found(targetMethod);
		}
		bool ___methodIsStatic = MethodIsStatic(targetMethod);
		int ___parameterCount = il2cpp_codegen_method_parameter_count(targetMethod);
		if (___methodIsStatic)
		{
			if (___parameterCount == 0)
			{
				// open
				typedef void (*FunctionPointerType) (const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetMethod);
			}
			else
			{
				// closed
				typedef void (*FunctionPointerType) (void*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, targetMethod);
			}
		}
		else
		{
			// closed
			if (il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						GenericInterfaceActionInvoker0::Invoke(targetMethod, targetThis);
					else
						GenericVirtActionInvoker0::Invoke(targetMethod, targetThis);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker0::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis);
					else
						VirtActionInvoker0::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis);
				}
			}
			else
			{
				typedef void (*FunctionPointerType) (void*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, targetMethod);
			}
		}
	}
}
// System.IAsyncResult DG.Tweening.TweenCallback::BeginInvoke(System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* TweenCallback_BeginInvoke_m6971EB2B3843E5A9E4ED89FB60626B8E12A3AB65 (TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * __this, AsyncCallback_t3F3DA3BEDAEE81DD1D24125DF8EB30E85EE14DA4 * ___callback0, RuntimeObject * ___object1, const RuntimeMethod* method)
{
	void *__d_args[1] = {0};
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback0, (RuntimeObject*)___object1);
}
// System.Void DG.Tweening.TweenCallback::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TweenCallback_EndInvoke_m29A82E195EE45C05780890F98577BADE319C0F72 (TweenCallback_tD2CEE8D219857E8D988DBEC4D2DE19FA5FCB3E83 * __this, RuntimeObject* ___result0, const RuntimeMethod* method)
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DG.Tweening.TweenExtensions::Complete(DG.Tweening.Tween)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TweenExtensions_Complete_m2D7930B127444FC11872F868A7B581892526DD1F (Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * ___t0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (TweenExtensions_Complete_m2D7930B127444FC11872F868A7B581892526DD1F_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_0 = ___t0;
		if (L_0)
		{
			goto IL_0012;
		}
	}
	{
		int32_t L_1 = ((Debugger_tD9D47C252FB20009C8276590D54394E430619D16_StaticFields*)il2cpp_codegen_static_fields_for(Debugger_tD9D47C252FB20009C8276590D54394E430619D16_il2cpp_TypeInfo_var))->get_logPriority_0();
		if ((((int32_t)L_1) <= ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_2 = ___t0;
		Debugger_LogNullTween_m95F50B0509E4BA5566BF1FA12326EE00E746B789(L_2, /*hidden argument*/NULL);
	}

IL_0011:
	{
		return;
	}

IL_0012:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_3 = ___t0;
		NullCheck(L_3);
		bool L_4 = L_3->get_active_35();
		if (L_4)
		{
			goto IL_0029;
		}
	}
	{
		int32_t L_5 = ((Debugger_tD9D47C252FB20009C8276590D54394E430619D16_StaticFields*)il2cpp_codegen_static_fields_for(Debugger_tD9D47C252FB20009C8276590D54394E430619D16_il2cpp_TypeInfo_var))->get_logPriority_0();
		if ((((int32_t)L_5) <= ((int32_t)1)))
		{
			goto IL_0028;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_6 = ___t0;
		Debugger_LogInvalidTween_m55880CECD15EF4A1D09D98999536C602171A5B95(L_6, /*hidden argument*/NULL);
	}

IL_0028:
	{
		return;
	}

IL_0029:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_7 = ___t0;
		NullCheck(L_7);
		bool L_8 = L_7->get_isSequenced_36();
		if (!L_8)
		{
			goto IL_0040;
		}
	}
	{
		int32_t L_9 = ((Debugger_tD9D47C252FB20009C8276590D54394E430619D16_StaticFields*)il2cpp_codegen_static_fields_for(Debugger_tD9D47C252FB20009C8276590D54394E430619D16_il2cpp_TypeInfo_var))->get_logPriority_0();
		if ((((int32_t)L_9) <= ((int32_t)1)))
		{
			goto IL_003f;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_10 = ___t0;
		Debugger_LogNestedTween_m6C0A9EBE74114A15FDC181BF27996C1350A02EE9(L_10, /*hidden argument*/NULL);
	}

IL_003f:
	{
		return;
	}

IL_0040:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_11 = ___t0;
		IL2CPP_RUNTIME_CLASS_INIT(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_il2cpp_TypeInfo_var);
		TweenManager_Complete_m82613D24CDEA91AF035F04E4B12D6C4F71858D47(L_11, (bool)1, /*hidden argument*/NULL);
		return;
	}
}
// System.Void DG.Tweening.TweenExtensions::Kill(DG.Tweening.Tween,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TweenExtensions_Kill_mE9A3C52FEC438801BEC9CC96435FFF18C72C8C44 (Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * ___t0, bool ___complete1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (TweenExtensions_Kill_mE9A3C52FEC438801BEC9CC96435FFF18C72C8C44_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_0 = ___t0;
		if (L_0)
		{
			goto IL_0012;
		}
	}
	{
		int32_t L_1 = ((Debugger_tD9D47C252FB20009C8276590D54394E430619D16_StaticFields*)il2cpp_codegen_static_fields_for(Debugger_tD9D47C252FB20009C8276590D54394E430619D16_il2cpp_TypeInfo_var))->get_logPriority_0();
		if ((((int32_t)L_1) <= ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_2 = ___t0;
		Debugger_LogNullTween_m95F50B0509E4BA5566BF1FA12326EE00E746B789(L_2, /*hidden argument*/NULL);
	}

IL_0011:
	{
		return;
	}

IL_0012:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_3 = ___t0;
		NullCheck(L_3);
		bool L_4 = L_3->get_active_35();
		if (L_4)
		{
			goto IL_0029;
		}
	}
	{
		int32_t L_5 = ((Debugger_tD9D47C252FB20009C8276590D54394E430619D16_StaticFields*)il2cpp_codegen_static_fields_for(Debugger_tD9D47C252FB20009C8276590D54394E430619D16_il2cpp_TypeInfo_var))->get_logPriority_0();
		if ((((int32_t)L_5) <= ((int32_t)1)))
		{
			goto IL_0028;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_6 = ___t0;
		Debugger_LogInvalidTween_m55880CECD15EF4A1D09D98999536C602171A5B95(L_6, /*hidden argument*/NULL);
	}

IL_0028:
	{
		return;
	}

IL_0029:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_7 = ___t0;
		NullCheck(L_7);
		bool L_8 = L_7->get_isSequenced_36();
		if (!L_8)
		{
			goto IL_0040;
		}
	}
	{
		int32_t L_9 = ((Debugger_tD9D47C252FB20009C8276590D54394E430619D16_StaticFields*)il2cpp_codegen_static_fields_for(Debugger_tD9D47C252FB20009C8276590D54394E430619D16_il2cpp_TypeInfo_var))->get_logPriority_0();
		if ((((int32_t)L_9) <= ((int32_t)1)))
		{
			goto IL_003f;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_10 = ___t0;
		Debugger_LogNestedTween_m6C0A9EBE74114A15FDC181BF27996C1350A02EE9(L_10, /*hidden argument*/NULL);
	}

IL_003f:
	{
		return;
	}

IL_0040:
	{
		bool L_11 = ___complete1;
		if (!L_11)
		{
			goto IL_005d;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_12 = ___t0;
		IL2CPP_RUNTIME_CLASS_INIT(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_il2cpp_TypeInfo_var);
		TweenManager_Complete_m82613D24CDEA91AF035F04E4B12D6C4F71858D47(L_12, (bool)1, /*hidden argument*/NULL);
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_13 = ___t0;
		NullCheck(L_13);
		bool L_14 = L_13->get_autoKill_22();
		if (!L_14)
		{
			goto IL_005d;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_15 = ___t0;
		NullCheck(L_15);
		int32_t L_16 = L_15->get_loops_24();
		if ((((int32_t)L_16) < ((int32_t)0)))
		{
			goto IL_005d;
		}
	}
	{
		return;
	}

IL_005d:
	{
		IL2CPP_RUNTIME_CLASS_INIT(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_il2cpp_TypeInfo_var);
		bool L_17 = ((TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_StaticFields*)il2cpp_codegen_static_fields_for(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_il2cpp_TypeInfo_var))->get_isUpdateLoop_17();
		if (!L_17)
		{
			goto IL_006c;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_18 = ___t0;
		NullCheck(L_18);
		L_18->set_active_35((bool)0);
		return;
	}

IL_006c:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_19 = ___t0;
		IL2CPP_RUNTIME_CLASS_INIT(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_il2cpp_TypeInfo_var);
		TweenManager_Despawn_mCBBD003E4779D54699E368376958FB6BB681E63D(L_19, (bool)1, /*hidden argument*/NULL);
		return;
	}
}
// System.Void DG.Tweening.TweenExtensions::PlayBackwards(DG.Tweening.Tween)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TweenExtensions_PlayBackwards_mD35BBEE7660D338C3747BB216444BF15C45A97E1 (Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * ___t0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (TweenExtensions_PlayBackwards_mD35BBEE7660D338C3747BB216444BF15C45A97E1_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_0 = ___t0;
		if (L_0)
		{
			goto IL_0012;
		}
	}
	{
		int32_t L_1 = ((Debugger_tD9D47C252FB20009C8276590D54394E430619D16_StaticFields*)il2cpp_codegen_static_fields_for(Debugger_tD9D47C252FB20009C8276590D54394E430619D16_il2cpp_TypeInfo_var))->get_logPriority_0();
		if ((((int32_t)L_1) <= ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_2 = ___t0;
		Debugger_LogNullTween_m95F50B0509E4BA5566BF1FA12326EE00E746B789(L_2, /*hidden argument*/NULL);
	}

IL_0011:
	{
		return;
	}

IL_0012:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_3 = ___t0;
		NullCheck(L_3);
		bool L_4 = L_3->get_active_35();
		if (L_4)
		{
			goto IL_0029;
		}
	}
	{
		int32_t L_5 = ((Debugger_tD9D47C252FB20009C8276590D54394E430619D16_StaticFields*)il2cpp_codegen_static_fields_for(Debugger_tD9D47C252FB20009C8276590D54394E430619D16_il2cpp_TypeInfo_var))->get_logPriority_0();
		if ((((int32_t)L_5) <= ((int32_t)1)))
		{
			goto IL_0028;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_6 = ___t0;
		Debugger_LogInvalidTween_m55880CECD15EF4A1D09D98999536C602171A5B95(L_6, /*hidden argument*/NULL);
	}

IL_0028:
	{
		return;
	}

IL_0029:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_7 = ___t0;
		NullCheck(L_7);
		bool L_8 = L_7->get_isSequenced_36();
		if (!L_8)
		{
			goto IL_0040;
		}
	}
	{
		int32_t L_9 = ((Debugger_tD9D47C252FB20009C8276590D54394E430619D16_StaticFields*)il2cpp_codegen_static_fields_for(Debugger_tD9D47C252FB20009C8276590D54394E430619D16_il2cpp_TypeInfo_var))->get_logPriority_0();
		if ((((int32_t)L_9) <= ((int32_t)1)))
		{
			goto IL_003f;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_10 = ___t0;
		Debugger_LogNestedTween_m6C0A9EBE74114A15FDC181BF27996C1350A02EE9(L_10, /*hidden argument*/NULL);
	}

IL_003f:
	{
		return;
	}

IL_0040:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_11 = ___t0;
		IL2CPP_RUNTIME_CLASS_INIT(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_il2cpp_TypeInfo_var);
		TweenManager_PlayBackwards_m30A0A66D801549233E04D406718BAA299711B7CA(L_11, /*hidden argument*/NULL);
		return;
	}
}
// System.Void DG.Tweening.TweenExtensions::PlayForward(DG.Tweening.Tween)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TweenExtensions_PlayForward_mCAE462ED14463F38AA0DB324B4607246C975DA78 (Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * ___t0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (TweenExtensions_PlayForward_mCAE462ED14463F38AA0DB324B4607246C975DA78_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_0 = ___t0;
		if (L_0)
		{
			goto IL_0012;
		}
	}
	{
		int32_t L_1 = ((Debugger_tD9D47C252FB20009C8276590D54394E430619D16_StaticFields*)il2cpp_codegen_static_fields_for(Debugger_tD9D47C252FB20009C8276590D54394E430619D16_il2cpp_TypeInfo_var))->get_logPriority_0();
		if ((((int32_t)L_1) <= ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_2 = ___t0;
		Debugger_LogNullTween_m95F50B0509E4BA5566BF1FA12326EE00E746B789(L_2, /*hidden argument*/NULL);
	}

IL_0011:
	{
		return;
	}

IL_0012:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_3 = ___t0;
		NullCheck(L_3);
		bool L_4 = L_3->get_active_35();
		if (L_4)
		{
			goto IL_0029;
		}
	}
	{
		int32_t L_5 = ((Debugger_tD9D47C252FB20009C8276590D54394E430619D16_StaticFields*)il2cpp_codegen_static_fields_for(Debugger_tD9D47C252FB20009C8276590D54394E430619D16_il2cpp_TypeInfo_var))->get_logPriority_0();
		if ((((int32_t)L_5) <= ((int32_t)1)))
		{
			goto IL_0028;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_6 = ___t0;
		Debugger_LogInvalidTween_m55880CECD15EF4A1D09D98999536C602171A5B95(L_6, /*hidden argument*/NULL);
	}

IL_0028:
	{
		return;
	}

IL_0029:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_7 = ___t0;
		NullCheck(L_7);
		bool L_8 = L_7->get_isSequenced_36();
		if (!L_8)
		{
			goto IL_0040;
		}
	}
	{
		int32_t L_9 = ((Debugger_tD9D47C252FB20009C8276590D54394E430619D16_StaticFields*)il2cpp_codegen_static_fields_for(Debugger_tD9D47C252FB20009C8276590D54394E430619D16_il2cpp_TypeInfo_var))->get_logPriority_0();
		if ((((int32_t)L_9) <= ((int32_t)1)))
		{
			goto IL_003f;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_10 = ___t0;
		Debugger_LogNestedTween_m6C0A9EBE74114A15FDC181BF27996C1350A02EE9(L_10, /*hidden argument*/NULL);
	}

IL_003f:
	{
		return;
	}

IL_0040:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_11 = ___t0;
		IL2CPP_RUNTIME_CLASS_INIT(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_il2cpp_TypeInfo_var);
		TweenManager_PlayForward_mF14238D7B13F5E7EA0BEF7DD672AEA65365F8BE6(L_11, /*hidden argument*/NULL);
		return;
	}
}
// System.Void DG.Tweening.TweenExtensions::Restart(DG.Tweening.Tween,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TweenExtensions_Restart_mDC073CE9213DFB2B09E48802B85A4A05FC9638A6 (Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * ___t0, bool ___includeDelay1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (TweenExtensions_Restart_mDC073CE9213DFB2B09E48802B85A4A05FC9638A6_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_0 = ___t0;
		if (L_0)
		{
			goto IL_0012;
		}
	}
	{
		int32_t L_1 = ((Debugger_tD9D47C252FB20009C8276590D54394E430619D16_StaticFields*)il2cpp_codegen_static_fields_for(Debugger_tD9D47C252FB20009C8276590D54394E430619D16_il2cpp_TypeInfo_var))->get_logPriority_0();
		if ((((int32_t)L_1) <= ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_2 = ___t0;
		Debugger_LogNullTween_m95F50B0509E4BA5566BF1FA12326EE00E746B789(L_2, /*hidden argument*/NULL);
	}

IL_0011:
	{
		return;
	}

IL_0012:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_3 = ___t0;
		NullCheck(L_3);
		bool L_4 = L_3->get_active_35();
		if (L_4)
		{
			goto IL_0029;
		}
	}
	{
		int32_t L_5 = ((Debugger_tD9D47C252FB20009C8276590D54394E430619D16_StaticFields*)il2cpp_codegen_static_fields_for(Debugger_tD9D47C252FB20009C8276590D54394E430619D16_il2cpp_TypeInfo_var))->get_logPriority_0();
		if ((((int32_t)L_5) <= ((int32_t)1)))
		{
			goto IL_0028;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_6 = ___t0;
		Debugger_LogInvalidTween_m55880CECD15EF4A1D09D98999536C602171A5B95(L_6, /*hidden argument*/NULL);
	}

IL_0028:
	{
		return;
	}

IL_0029:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_7 = ___t0;
		NullCheck(L_7);
		bool L_8 = L_7->get_isSequenced_36();
		if (!L_8)
		{
			goto IL_0040;
		}
	}
	{
		int32_t L_9 = ((Debugger_tD9D47C252FB20009C8276590D54394E430619D16_StaticFields*)il2cpp_codegen_static_fields_for(Debugger_tD9D47C252FB20009C8276590D54394E430619D16_il2cpp_TypeInfo_var))->get_logPriority_0();
		if ((((int32_t)L_9) <= ((int32_t)1)))
		{
			goto IL_003f;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_10 = ___t0;
		Debugger_LogNestedTween_m6C0A9EBE74114A15FDC181BF27996C1350A02EE9(L_10, /*hidden argument*/NULL);
	}

IL_003f:
	{
		return;
	}

IL_0040:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_11 = ___t0;
		bool L_12 = ___includeDelay1;
		IL2CPP_RUNTIME_CLASS_INIT(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_il2cpp_TypeInfo_var);
		TweenManager_Restart_m785F15C1C7E7837E9A0EDFE3085EF443E65961EF(L_11, L_12, /*hidden argument*/NULL);
		return;
	}
}
// System.Void DG.Tweening.TweenExtensions::Rewind(DG.Tweening.Tween,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TweenExtensions_Rewind_mC401886E7657C9525C13771792B4B7A4684C757C (Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * ___t0, bool ___includeDelay1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (TweenExtensions_Rewind_mC401886E7657C9525C13771792B4B7A4684C757C_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_0 = ___t0;
		if (L_0)
		{
			goto IL_0012;
		}
	}
	{
		int32_t L_1 = ((Debugger_tD9D47C252FB20009C8276590D54394E430619D16_StaticFields*)il2cpp_codegen_static_fields_for(Debugger_tD9D47C252FB20009C8276590D54394E430619D16_il2cpp_TypeInfo_var))->get_logPriority_0();
		if ((((int32_t)L_1) <= ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_2 = ___t0;
		Debugger_LogNullTween_m95F50B0509E4BA5566BF1FA12326EE00E746B789(L_2, /*hidden argument*/NULL);
	}

IL_0011:
	{
		return;
	}

IL_0012:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_3 = ___t0;
		NullCheck(L_3);
		bool L_4 = L_3->get_active_35();
		if (L_4)
		{
			goto IL_0029;
		}
	}
	{
		int32_t L_5 = ((Debugger_tD9D47C252FB20009C8276590D54394E430619D16_StaticFields*)il2cpp_codegen_static_fields_for(Debugger_tD9D47C252FB20009C8276590D54394E430619D16_il2cpp_TypeInfo_var))->get_logPriority_0();
		if ((((int32_t)L_5) <= ((int32_t)1)))
		{
			goto IL_0028;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_6 = ___t0;
		Debugger_LogInvalidTween_m55880CECD15EF4A1D09D98999536C602171A5B95(L_6, /*hidden argument*/NULL);
	}

IL_0028:
	{
		return;
	}

IL_0029:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_7 = ___t0;
		NullCheck(L_7);
		bool L_8 = L_7->get_isSequenced_36();
		if (!L_8)
		{
			goto IL_0040;
		}
	}
	{
		int32_t L_9 = ((Debugger_tD9D47C252FB20009C8276590D54394E430619D16_StaticFields*)il2cpp_codegen_static_fields_for(Debugger_tD9D47C252FB20009C8276590D54394E430619D16_il2cpp_TypeInfo_var))->get_logPriority_0();
		if ((((int32_t)L_9) <= ((int32_t)1)))
		{
			goto IL_003f;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_10 = ___t0;
		Debugger_LogNestedTween_m6C0A9EBE74114A15FDC181BF27996C1350A02EE9(L_10, /*hidden argument*/NULL);
	}

IL_003f:
	{
		return;
	}

IL_0040:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_11 = ___t0;
		bool L_12 = ___includeDelay1;
		IL2CPP_RUNTIME_CLASS_INIT(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_il2cpp_TypeInfo_var);
		TweenManager_Rewind_mEEBAAC2FEA9A2CE7B3739002EB030D0AADD8C150(L_11, L_12, /*hidden argument*/NULL);
		return;
	}
}
// System.Void DG.Tweening.TweenExtensions::TogglePause(DG.Tweening.Tween)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TweenExtensions_TogglePause_mB413085220461740827A9B6515D71FFEFCF803CB (Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * ___t0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (TweenExtensions_TogglePause_mB413085220461740827A9B6515D71FFEFCF803CB_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_0 = ___t0;
		if (L_0)
		{
			goto IL_0012;
		}
	}
	{
		int32_t L_1 = ((Debugger_tD9D47C252FB20009C8276590D54394E430619D16_StaticFields*)il2cpp_codegen_static_fields_for(Debugger_tD9D47C252FB20009C8276590D54394E430619D16_il2cpp_TypeInfo_var))->get_logPriority_0();
		if ((((int32_t)L_1) <= ((int32_t)1)))
		{
			goto IL_0011;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_2 = ___t0;
		Debugger_LogNullTween_m95F50B0509E4BA5566BF1FA12326EE00E746B789(L_2, /*hidden argument*/NULL);
	}

IL_0011:
	{
		return;
	}

IL_0012:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_3 = ___t0;
		NullCheck(L_3);
		bool L_4 = L_3->get_active_35();
		if (L_4)
		{
			goto IL_0029;
		}
	}
	{
		int32_t L_5 = ((Debugger_tD9D47C252FB20009C8276590D54394E430619D16_StaticFields*)il2cpp_codegen_static_fields_for(Debugger_tD9D47C252FB20009C8276590D54394E430619D16_il2cpp_TypeInfo_var))->get_logPriority_0();
		if ((((int32_t)L_5) <= ((int32_t)1)))
		{
			goto IL_0028;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_6 = ___t0;
		Debugger_LogInvalidTween_m55880CECD15EF4A1D09D98999536C602171A5B95(L_6, /*hidden argument*/NULL);
	}

IL_0028:
	{
		return;
	}

IL_0029:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_7 = ___t0;
		NullCheck(L_7);
		bool L_8 = L_7->get_isSequenced_36();
		if (!L_8)
		{
			goto IL_0040;
		}
	}
	{
		int32_t L_9 = ((Debugger_tD9D47C252FB20009C8276590D54394E430619D16_StaticFields*)il2cpp_codegen_static_fields_for(Debugger_tD9D47C252FB20009C8276590D54394E430619D16_il2cpp_TypeInfo_var))->get_logPriority_0();
		if ((((int32_t)L_9) <= ((int32_t)1)))
		{
			goto IL_003f;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_10 = ___t0;
		Debugger_LogNestedTween_m6C0A9EBE74114A15FDC181BF27996C1350A02EE9(L_10, /*hidden argument*/NULL);
	}

IL_003f:
	{
		return;
	}

IL_0040:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_11 = ___t0;
		IL2CPP_RUNTIME_CLASS_INIT(TweenManager_t60E1FACD2C008A79361FCD1037D92408C1DAF386_il2cpp_TypeInfo_var);
		TweenManager_TogglePause_m1EDBB6356ECB219E9E59DA20605ABBA51F35036B(L_11, /*hidden argument*/NULL);
		return;
	}
}
// System.Boolean DG.Tweening.TweenExtensions::IsActive(DG.Tweening.Tween)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TweenExtensions_IsActive_mFCFF3122C0C3276A6093B42BAFC1258E1252110C (Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * ___t0, const RuntimeMethod* method)
{
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_0 = ___t0;
		NullCheck(L_0);
		bool L_1 = L_0->get_active_35();
		return L_1;
	}
}
// System.Boolean DG.Tweening.TweenExtensions::IsComplete(DG.Tweening.Tween)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TweenExtensions_IsComplete_m058D78AC1B3A1E815331E06C8386AAA4CC236A0F (Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * ___t0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (TweenExtensions_IsComplete_m058D78AC1B3A1E815331E06C8386AAA4CC236A0F_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_0 = ___t0;
		NullCheck(L_0);
		bool L_1 = L_0->get_active_35();
		if (L_1)
		{
			goto IL_0018;
		}
	}
	{
		int32_t L_2 = ((Debugger_tD9D47C252FB20009C8276590D54394E430619D16_StaticFields*)il2cpp_codegen_static_fields_for(Debugger_tD9D47C252FB20009C8276590D54394E430619D16_il2cpp_TypeInfo_var))->get_logPriority_0();
		if ((((int32_t)L_2) <= ((int32_t)0)))
		{
			goto IL_0016;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_3 = ___t0;
		Debugger_LogInvalidTween_m55880CECD15EF4A1D09D98999536C602171A5B95(L_3, /*hidden argument*/NULL);
	}

IL_0016:
	{
		return (bool)0;
	}

IL_0018:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_4 = ___t0;
		NullCheck(L_4);
		bool L_5 = L_4->get_isComplete_47();
		return L_5;
	}
}
// System.Boolean DG.Tweening.TweenExtensions::IsInitialized(DG.Tweening.Tween)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TweenExtensions_IsInitialized_m831388B524712F533A55A7D945B0501A68A144A9 (Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * ___t0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (TweenExtensions_IsInitialized_m831388B524712F533A55A7D945B0501A68A144A9_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_0 = ___t0;
		NullCheck(L_0);
		bool L_1 = L_0->get_active_35();
		if (L_1)
		{
			goto IL_0018;
		}
	}
	{
		int32_t L_2 = ((Debugger_tD9D47C252FB20009C8276590D54394E430619D16_StaticFields*)il2cpp_codegen_static_fields_for(Debugger_tD9D47C252FB20009C8276590D54394E430619D16_il2cpp_TypeInfo_var))->get_logPriority_0();
		if ((((int32_t)L_2) <= ((int32_t)0)))
		{
			goto IL_0016;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_3 = ___t0;
		Debugger_LogInvalidTween_m55880CECD15EF4A1D09D98999536C602171A5B95(L_3, /*hidden argument*/NULL);
	}

IL_0016:
	{
		return (bool)0;
	}

IL_0018:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_4 = ___t0;
		NullCheck(L_4);
		bool L_5 = L_4->get_startupDone_41();
		return L_5;
	}
}
// System.Boolean DG.Tweening.TweenExtensions::IsPlaying(DG.Tweening.Tween)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TweenExtensions_IsPlaying_m27DD47C5CCC873CD11D4C6692F3798E3AD6E9FF9 (Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * ___t0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (TweenExtensions_IsPlaying_m27DD47C5CCC873CD11D4C6692F3798E3AD6E9FF9_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_0 = ___t0;
		NullCheck(L_0);
		bool L_1 = L_0->get_active_35();
		if (L_1)
		{
			goto IL_0018;
		}
	}
	{
		int32_t L_2 = ((Debugger_tD9D47C252FB20009C8276590D54394E430619D16_StaticFields*)il2cpp_codegen_static_fields_for(Debugger_tD9D47C252FB20009C8276590D54394E430619D16_il2cpp_TypeInfo_var))->get_logPriority_0();
		if ((((int32_t)L_2) <= ((int32_t)0)))
		{
			goto IL_0016;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_3 = ___t0;
		Debugger_LogInvalidTween_m55880CECD15EF4A1D09D98999536C602171A5B95(L_3, /*hidden argument*/NULL);
	}

IL_0016:
	{
		return (bool)0;
	}

IL_0018:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_4 = ___t0;
		NullCheck(L_4);
		bool L_5 = L_4->get_isPlaying_46();
		return L_5;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// DG.Tweening.Sequence DG.Tweening.TweenSettingsExtensions::Append(DG.Tweening.Sequence,DG.Tweening.Tween)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Sequence_tA6FA099F465933113D131DDC0EECB6A19A27BCB2 * TweenSettingsExtensions_Append_mF9230E38E4644D205DD7BB914EEDAAF03CF6B9FE (Sequence_tA6FA099F465933113D131DDC0EECB6A19A27BCB2 * ___s0, Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * ___t1, const RuntimeMethod* method)
{
	{
		Sequence_tA6FA099F465933113D131DDC0EECB6A19A27BCB2 * L_0 = ___s0;
		if (!L_0)
		{
			goto IL_0013;
		}
	}
	{
		Sequence_tA6FA099F465933113D131DDC0EECB6A19A27BCB2 * L_1 = ___s0;
		NullCheck(L_1);
		bool L_2 = ((Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 *)L_1)->get_active_35();
		if (!L_2)
		{
			goto IL_0013;
		}
	}
	{
		Sequence_tA6FA099F465933113D131DDC0EECB6A19A27BCB2 * L_3 = ___s0;
		NullCheck(L_3);
		bool L_4 = ((Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 *)L_3)->get_creationLocked_40();
		if (!L_4)
		{
			goto IL_0015;
		}
	}

IL_0013:
	{
		Sequence_tA6FA099F465933113D131DDC0EECB6A19A27BCB2 * L_5 = ___s0;
		return L_5;
	}

IL_0015:
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_6 = ___t1;
		if (!L_6)
		{
			goto IL_0028;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_7 = ___t1;
		NullCheck(L_7);
		bool L_8 = L_7->get_active_35();
		if (!L_8)
		{
			goto IL_0028;
		}
	}
	{
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_9 = ___t1;
		NullCheck(L_9);
		bool L_10 = L_9->get_isSequenced_36();
		if (!L_10)
		{
			goto IL_002a;
		}
	}

IL_0028:
	{
		Sequence_tA6FA099F465933113D131DDC0EECB6A19A27BCB2 * L_11 = ___s0;
		return L_11;
	}

IL_002a:
	{
		Sequence_tA6FA099F465933113D131DDC0EECB6A19A27BCB2 * L_12 = ___s0;
		Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 * L_13 = ___t1;
		Sequence_tA6FA099F465933113D131DDC0EECB6A19A27BCB2 * L_14 = ___s0;
		NullCheck(L_14);
		float L_15 = ((Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 *)L_14)->get_duration_23();
		Sequence_DoInsert_m3D20EAC3DCAE54D0FE4EC70344B5DF3D2167C263(L_12, L_13, L_15, /*hidden argument*/NULL);
		Sequence_tA6FA099F465933113D131DDC0EECB6A19A27BCB2 * L_16 = ___s0;
		return L_16;
	}
}
// DG.Tweening.Tweener DG.Tweening.TweenSettingsExtensions::SetOptions(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions>,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Tweener_t9B2A5E94EE6D11F7607E58AE4E37186FF63587C8 * TweenSettingsExtensions_SetOptions_m8E426FE7E94D7B685CA5DA3DD7E636FC17B495F1 (TweenerCore_3_tEF3CF5BF3AF3C462924E66EFF3839D0D49C74066 * ___t0, bool ___snapping1, const RuntimeMethod* method)
{
	{
		TweenerCore_3_tEF3CF5BF3AF3C462924E66EFF3839D0D49C74066 * L_0 = ___t0;
		if (!L_0)
		{
			goto IL_000b;
		}
	}
	{
		TweenerCore_3_tEF3CF5BF3AF3C462924E66EFF3839D0D49C74066 * L_1 = ___t0;
		NullCheck(L_1);
		bool L_2 = ((Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 *)L_1)->get_active_35();
		if (L_2)
		{
			goto IL_000d;
		}
	}

IL_000b:
	{
		TweenerCore_3_tEF3CF5BF3AF3C462924E66EFF3839D0D49C74066 * L_3 = ___t0;
		return L_3;
	}

IL_000d:
	{
		TweenerCore_3_tEF3CF5BF3AF3C462924E66EFF3839D0D49C74066 * L_4 = ___t0;
		NullCheck(L_4);
		VectorOptions_t385A0AFDBE150CC9F61EA0DC03FEA860BA5EA322 * L_5 = L_4->get_address_of_plugOptions_56();
		bool L_6 = ___snapping1;
		L_5->set_snapping_1(L_6);
		TweenerCore_3_tEF3CF5BF3AF3C462924E66EFF3839D0D49C74066 * L_7 = ___t0;
		return L_7;
	}
}
// DG.Tweening.Tweener DG.Tweening.TweenSettingsExtensions::SetOptions(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions>,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Tweener_t9B2A5E94EE6D11F7607E58AE4E37186FF63587C8 * TweenSettingsExtensions_SetOptions_m24B2A6FDAC0B998DFA33B4B0E2BB736C65F01937 (TweenerCore_3_t104C232CA5A703780F416D4E8F2D71E42FE9C46B * ___t0, bool ___snapping1, const RuntimeMethod* method)
{
	{
		TweenerCore_3_t104C232CA5A703780F416D4E8F2D71E42FE9C46B * L_0 = ___t0;
		if (!L_0)
		{
			goto IL_000b;
		}
	}
	{
		TweenerCore_3_t104C232CA5A703780F416D4E8F2D71E42FE9C46B * L_1 = ___t0;
		NullCheck(L_1);
		bool L_2 = ((Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 *)L_1)->get_active_35();
		if (L_2)
		{
			goto IL_000d;
		}
	}

IL_000b:
	{
		TweenerCore_3_t104C232CA5A703780F416D4E8F2D71E42FE9C46B * L_3 = ___t0;
		return L_3;
	}

IL_000d:
	{
		TweenerCore_3_t104C232CA5A703780F416D4E8F2D71E42FE9C46B * L_4 = ___t0;
		NullCheck(L_4);
		VectorOptions_t385A0AFDBE150CC9F61EA0DC03FEA860BA5EA322 * L_5 = L_4->get_address_of_plugOptions_56();
		bool L_6 = ___snapping1;
		L_5->set_snapping_1(L_6);
		TweenerCore_3_t104C232CA5A703780F416D4E8F2D71E42FE9C46B * L_7 = ___t0;
		return L_7;
	}
}
// DG.Tweening.Tweener DG.Tweening.TweenSettingsExtensions::SetOptions(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions>,DG.Tweening.AxisConstraint,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Tweener_t9B2A5E94EE6D11F7607E58AE4E37186FF63587C8 * TweenSettingsExtensions_SetOptions_m355BECDFA70A8EA4F748D6C8280387C6F011C739 (TweenerCore_3_t104C232CA5A703780F416D4E8F2D71E42FE9C46B * ___t0, int32_t ___axisConstraint1, bool ___snapping2, const RuntimeMethod* method)
{
	{
		TweenerCore_3_t104C232CA5A703780F416D4E8F2D71E42FE9C46B * L_0 = ___t0;
		if (!L_0)
		{
			goto IL_000b;
		}
	}
	{
		TweenerCore_3_t104C232CA5A703780F416D4E8F2D71E42FE9C46B * L_1 = ___t0;
		NullCheck(L_1);
		bool L_2 = ((Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 *)L_1)->get_active_35();
		if (L_2)
		{
			goto IL_000d;
		}
	}

IL_000b:
	{
		TweenerCore_3_t104C232CA5A703780F416D4E8F2D71E42FE9C46B * L_3 = ___t0;
		return L_3;
	}

IL_000d:
	{
		TweenerCore_3_t104C232CA5A703780F416D4E8F2D71E42FE9C46B * L_4 = ___t0;
		NullCheck(L_4);
		VectorOptions_t385A0AFDBE150CC9F61EA0DC03FEA860BA5EA322 * L_5 = L_4->get_address_of_plugOptions_56();
		int32_t L_6 = ___axisConstraint1;
		L_5->set_axisConstraint_0(L_6);
		TweenerCore_3_t104C232CA5A703780F416D4E8F2D71E42FE9C46B * L_7 = ___t0;
		NullCheck(L_7);
		VectorOptions_t385A0AFDBE150CC9F61EA0DC03FEA860BA5EA322 * L_8 = L_7->get_address_of_plugOptions_56();
		bool L_9 = ___snapping2;
		L_8->set_snapping_1(L_9);
		TweenerCore_3_t104C232CA5A703780F416D4E8F2D71E42FE9C46B * L_10 = ___t0;
		return L_10;
	}
}
// DG.Tweening.Tweener DG.Tweening.TweenSettingsExtensions::SetOptions(DG.Tweening.Core.TweenerCore`3<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions>,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Tweener_t9B2A5E94EE6D11F7607E58AE4E37186FF63587C8 * TweenSettingsExtensions_SetOptions_m91F3015F32F080493FFBFB24F144D4112D86B6A8 (TweenerCore_3_t135A028153B5C8F7030BB331039A6C1C8B41AC65 * ___t0, bool ___alphaOnly1, const RuntimeMethod* method)
{
	{
		TweenerCore_3_t135A028153B5C8F7030BB331039A6C1C8B41AC65 * L_0 = ___t0;
		if (!L_0)
		{
			goto IL_000b;
		}
	}
	{
		TweenerCore_3_t135A028153B5C8F7030BB331039A6C1C8B41AC65 * L_1 = ___t0;
		NullCheck(L_1);
		bool L_2 = ((Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 *)L_1)->get_active_35();
		if (L_2)
		{
			goto IL_000d;
		}
	}

IL_000b:
	{
		TweenerCore_3_t135A028153B5C8F7030BB331039A6C1C8B41AC65 * L_3 = ___t0;
		return L_3;
	}

IL_000d:
	{
		TweenerCore_3_t135A028153B5C8F7030BB331039A6C1C8B41AC65 * L_4 = ___t0;
		NullCheck(L_4);
		ColorOptions_tD57E512D2F4329BEE7EAEE0D1B2C4A0683D288DA * L_5 = L_4->get_address_of_plugOptions_56();
		bool L_6 = ___alphaOnly1;
		L_5->set_alphaOnly_0(L_6);
		TweenerCore_3_t135A028153B5C8F7030BB331039A6C1C8B41AC65 * L_7 = ___t0;
		return L_7;
	}
}
// DG.Tweening.Tweener DG.Tweening.TweenSettingsExtensions::SetOptions(DG.Tweening.Core.TweenerCore`3<System.String,System.String,DG.Tweening.Plugins.Options.StringOptions>,System.Boolean,DG.Tweening.ScrambleMode,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Tweener_t9B2A5E94EE6D11F7607E58AE4E37186FF63587C8 * TweenSettingsExtensions_SetOptions_mF5B0D3F3B6EEC1C79D91E770D3F00709C9931230 (TweenerCore_3_t5CC4896707276A1DD128E986B753C9447C7E8FA8 * ___t0, bool ___richTextEnabled1, int32_t ___scrambleMode2, String_t* ___scrambleChars3, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (TweenSettingsExtensions_SetOptions_mF5B0D3F3B6EEC1C79D91E770D3F00709C9931230_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		TweenerCore_3_t5CC4896707276A1DD128E986B753C9447C7E8FA8 * L_0 = ___t0;
		if (!L_0)
		{
			goto IL_000b;
		}
	}
	{
		TweenerCore_3_t5CC4896707276A1DD128E986B753C9447C7E8FA8 * L_1 = ___t0;
		NullCheck(L_1);
		bool L_2 = ((Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 *)L_1)->get_active_35();
		if (L_2)
		{
			goto IL_000d;
		}
	}

IL_000b:
	{
		TweenerCore_3_t5CC4896707276A1DD128E986B753C9447C7E8FA8 * L_3 = ___t0;
		return L_3;
	}

IL_000d:
	{
		TweenerCore_3_t5CC4896707276A1DD128E986B753C9447C7E8FA8 * L_4 = ___t0;
		NullCheck(L_4);
		StringOptions_t58D6011099873A39926A99C00EE24D0D80B231FC * L_5 = L_4->get_address_of_plugOptions_56();
		bool L_6 = ___richTextEnabled1;
		L_5->set_richTextEnabled_0(L_6);
		TweenerCore_3_t5CC4896707276A1DD128E986B753C9447C7E8FA8 * L_7 = ___t0;
		NullCheck(L_7);
		StringOptions_t58D6011099873A39926A99C00EE24D0D80B231FC * L_8 = L_7->get_address_of_plugOptions_56();
		int32_t L_9 = ___scrambleMode2;
		L_8->set_scrambleMode_1(L_9);
		String_t* L_10 = ___scrambleChars3;
		bool L_11 = String_IsNullOrEmpty_m06A85A206AC2106D1982826C5665B9BD35324229(L_10, /*hidden argument*/NULL);
		if (L_11)
		{
			goto IL_0060;
		}
	}
	{
		String_t* L_12 = ___scrambleChars3;
		NullCheck(L_12);
		int32_t L_13 = String_get_Length_mD48C8A16A5CF1914F330DCE82D9BE15C3BEDD018_inline(L_12, /*hidden argument*/NULL);
		if ((((int32_t)L_13) > ((int32_t)1)))
		{
			goto IL_003f;
		}
	}
	{
		String_t* L_14 = ___scrambleChars3;
		String_t* L_15 = ___scrambleChars3;
		String_t* L_16 = String_Concat_mB78D0094592718DA6D5DB6C712A9C225631666BE(L_14, L_15, /*hidden argument*/NULL);
		___scrambleChars3 = L_16;
	}

IL_003f:
	{
		TweenerCore_3_t5CC4896707276A1DD128E986B753C9447C7E8FA8 * L_17 = ___t0;
		NullCheck(L_17);
		StringOptions_t58D6011099873A39926A99C00EE24D0D80B231FC * L_18 = L_17->get_address_of_plugOptions_56();
		String_t* L_19 = ___scrambleChars3;
		NullCheck(L_19);
		CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* L_20 = String_ToCharArray_mFCFF32A5EC698E81075E0C72C874282B9ED197A6(L_19, /*hidden argument*/NULL);
		L_18->set_scrambledChars_2(L_20);
		TweenerCore_3_t5CC4896707276A1DD128E986B753C9447C7E8FA8 * L_21 = ___t0;
		NullCheck(L_21);
		StringOptions_t58D6011099873A39926A99C00EE24D0D80B231FC * L_22 = L_21->get_address_of_plugOptions_56();
		CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* L_23 = L_22->get_scrambledChars_2();
		IL2CPP_RUNTIME_CLASS_INIT(StringPluginExtensions_tB7BCF7EB9633300CDD2387F467B58782AE28F06B_il2cpp_TypeInfo_var);
		StringPluginExtensions_ScrambleChars_m5D48CF427E493F0CFB0C1A6D52C4E4C0F8DC54A2(L_23, /*hidden argument*/NULL);
	}

IL_0060:
	{
		TweenerCore_3_t5CC4896707276A1DD128E986B753C9447C7E8FA8 * L_24 = ___t0;
		return L_24;
	}
}
// DG.Tweening.Tweener DG.Tweening.TweenSettingsExtensions::SetOptions(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions>,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Tweener_t9B2A5E94EE6D11F7607E58AE4E37186FF63587C8 * TweenSettingsExtensions_SetOptions_m4C4BFBC96D45F95BE811A330299AEE2B98898CA6 (TweenerCore_3_t8144D2B7915783E42476714D21E639420B0EDC30 * ___t0, bool ___snapping1, const RuntimeMethod* method)
{
	{
		TweenerCore_3_t8144D2B7915783E42476714D21E639420B0EDC30 * L_0 = ___t0;
		if (!L_0)
		{
			goto IL_000b;
		}
	}
	{
		TweenerCore_3_t8144D2B7915783E42476714D21E639420B0EDC30 * L_1 = ___t0;
		NullCheck(L_1);
		bool L_2 = ((Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 *)L_1)->get_active_35();
		if (L_2)
		{
			goto IL_000d;
		}
	}

IL_000b:
	{
		TweenerCore_3_t8144D2B7915783E42476714D21E639420B0EDC30 * L_3 = ___t0;
		return L_3;
	}

IL_000d:
	{
		TweenerCore_3_t8144D2B7915783E42476714D21E639420B0EDC30 * L_4 = ___t0;
		NullCheck(L_4);
		Vector3ArrayOptions_t3E84666D670017F133C32243F0709A3852F05257 * L_5 = L_4->get_address_of_plugOptions_56();
		bool L_6 = ___snapping1;
		L_5->set_snapping_1(L_6);
		TweenerCore_3_t8144D2B7915783E42476714D21E639420B0EDC30 * L_7 = ___t0;
		return L_7;
	}
}
// DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> DG.Tweening.TweenSettingsExtensions::SetOptions(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions>,System.Boolean,DG.Tweening.AxisConstraint,DG.Tweening.AxisConstraint)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * TweenSettingsExtensions_SetOptions_mD4DDAD5C05009CC8EE99277336157B59C2B95B1C (TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * ___t0, bool ___closePath1, int32_t ___lockPosition2, int32_t ___lockRotation3, const RuntimeMethod* method)
{
	{
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_0 = ___t0;
		if (!L_0)
		{
			goto IL_000b;
		}
	}
	{
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_1 = ___t0;
		NullCheck(L_1);
		bool L_2 = ((Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 *)L_1)->get_active_35();
		if (L_2)
		{
			goto IL_000d;
		}
	}

IL_000b:
	{
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_3 = ___t0;
		return L_3;
	}

IL_000d:
	{
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_4 = ___t0;
		NullCheck(L_4);
		PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7 * L_5 = L_4->get_address_of_plugOptions_56();
		bool L_6 = ___closePath1;
		L_5->set_isClosedPath_4(L_6);
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_7 = ___t0;
		NullCheck(L_7);
		PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7 * L_8 = L_7->get_address_of_plugOptions_56();
		int32_t L_9 = ___lockPosition2;
		L_8->set_lockPositionAxis_2(L_9);
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_10 = ___t0;
		NullCheck(L_10);
		PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7 * L_11 = L_10->get_address_of_plugOptions_56();
		int32_t L_12 = ___lockRotation3;
		L_11->set_lockRotationAxis_3(L_12);
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_13 = ___t0;
		return L_13;
	}
}
// DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> DG.Tweening.TweenSettingsExtensions::SetLookAt(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions>,UnityEngine.Vector3,System.Nullable`1<UnityEngine.Vector3>,System.Nullable`1<UnityEngine.Vector3>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * TweenSettingsExtensions_SetLookAt_m348051EC126511533EDE2AD6A5CD0752F062C71D (TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * ___t0, Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  ___lookAtPosition1, Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE  ___forwardDirection2, Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE  ___up3, const RuntimeMethod* method)
{
	{
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_0 = ___t0;
		if (!L_0)
		{
			goto IL_000b;
		}
	}
	{
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_1 = ___t0;
		NullCheck(L_1);
		bool L_2 = ((Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 *)L_1)->get_active_35();
		if (L_2)
		{
			goto IL_000d;
		}
	}

IL_000b:
	{
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_3 = ___t0;
		return L_3;
	}

IL_000d:
	{
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_4 = ___t0;
		NullCheck(L_4);
		PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7 * L_5 = L_4->get_address_of_plugOptions_56();
		L_5->set_orientType_1(3);
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_6 = ___t0;
		NullCheck(L_6);
		PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7 * L_7 = L_6->get_address_of_plugOptions_56();
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_8 = ___lookAtPosition1;
		L_7->set_lookAtPosition_5(L_8);
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_9 = ___t0;
		Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE  L_10 = ___forwardDirection2;
		Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE  L_11 = ___up3;
		TweenSettingsExtensions_SetPathForwardDirection_m7EA9A97A77D0EBB7542134E0D8224E06D5A56714(L_9, L_10, L_11, /*hidden argument*/NULL);
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_12 = ___t0;
		return L_12;
	}
}
// DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> DG.Tweening.TweenSettingsExtensions::SetLookAt(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions>,UnityEngine.Transform,System.Nullable`1<UnityEngine.Vector3>,System.Nullable`1<UnityEngine.Vector3>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * TweenSettingsExtensions_SetLookAt_mA4ACE4FF207B9433A30A75392A9CB7CC89AABBE5 (TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * ___t0, Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * ___lookAtTransform1, Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE  ___forwardDirection2, Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE  ___up3, const RuntimeMethod* method)
{
	{
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_0 = ___t0;
		if (!L_0)
		{
			goto IL_000b;
		}
	}
	{
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_1 = ___t0;
		NullCheck(L_1);
		bool L_2 = ((Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 *)L_1)->get_active_35();
		if (L_2)
		{
			goto IL_000d;
		}
	}

IL_000b:
	{
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_3 = ___t0;
		return L_3;
	}

IL_000d:
	{
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_4 = ___t0;
		NullCheck(L_4);
		PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7 * L_5 = L_4->get_address_of_plugOptions_56();
		L_5->set_orientType_1(2);
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_6 = ___t0;
		NullCheck(L_6);
		PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7 * L_7 = L_6->get_address_of_plugOptions_56();
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_8 = ___lookAtTransform1;
		L_7->set_lookAtTransform_6(L_8);
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_9 = ___t0;
		Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE  L_10 = ___forwardDirection2;
		Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE  L_11 = ___up3;
		TweenSettingsExtensions_SetPathForwardDirection_m7EA9A97A77D0EBB7542134E0D8224E06D5A56714(L_9, L_10, L_11, /*hidden argument*/NULL);
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_12 = ___t0;
		return L_12;
	}
}
// DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> DG.Tweening.TweenSettingsExtensions::SetLookAt(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions>,System.Single,System.Nullable`1<UnityEngine.Vector3>,System.Nullable`1<UnityEngine.Vector3>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * TweenSettingsExtensions_SetLookAt_m1BBF90CFDEF4EFB5F84AF0756715D109B789EF76 (TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * ___t0, float ___lookAhead1, Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE  ___forwardDirection2, Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE  ___up3, const RuntimeMethod* method)
{
	{
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_0 = ___t0;
		if (!L_0)
		{
			goto IL_000b;
		}
	}
	{
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_1 = ___t0;
		NullCheck(L_1);
		bool L_2 = ((Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 *)L_1)->get_active_35();
		if (L_2)
		{
			goto IL_000d;
		}
	}

IL_000b:
	{
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_3 = ___t0;
		return L_3;
	}

IL_000d:
	{
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_4 = ___t0;
		NullCheck(L_4);
		PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7 * L_5 = L_4->get_address_of_plugOptions_56();
		L_5->set_orientType_1(1);
		float L_6 = ___lookAhead1;
		if ((!(((float)L_6) < ((float)(0.0001f)))))
		{
			goto IL_0028;
		}
	}
	{
		___lookAhead1 = (0.0001f);
	}

IL_0028:
	{
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_7 = ___t0;
		NullCheck(L_7);
		PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7 * L_8 = L_7->get_address_of_plugOptions_56();
		float L_9 = ___lookAhead1;
		L_8->set_lookAhead_7(L_9);
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_10 = ___t0;
		Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE  L_11 = ___forwardDirection2;
		Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE  L_12 = ___up3;
		TweenSettingsExtensions_SetPathForwardDirection_m7EA9A97A77D0EBB7542134E0D8224E06D5A56714(L_10, L_11, L_12, /*hidden argument*/NULL);
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_13 = ___t0;
		return L_13;
	}
}
// System.Void DG.Tweening.TweenSettingsExtensions::SetPathForwardDirection(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions>,System.Nullable`1<UnityEngine.Vector3>,System.Nullable`1<UnityEngine.Vector3>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TweenSettingsExtensions_SetPathForwardDirection_m7EA9A97A77D0EBB7542134E0D8224E06D5A56714 (TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * ___t0, Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE  ___forwardDirection1, Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE  ___up2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (TweenSettingsExtensions_SetPathForwardDirection_m7EA9A97A77D0EBB7542134E0D8224E06D5A56714_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE  V_0;
	memset((&V_0), 0, sizeof(V_0));
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  V_1;
	memset((&V_1), 0, sizeof(V_1));
	Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE  V_2;
	memset((&V_2), 0, sizeof(V_2));
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  V_3;
	memset((&V_3), 0, sizeof(V_3));
	Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE  V_4;
	memset((&V_4), 0, sizeof(V_4));
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  V_5;
	memset((&V_5), 0, sizeof(V_5));
	PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7 * G_B8_0 = NULL;
	PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7 * G_B4_0 = NULL;
	PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7 * G_B6_0 = NULL;
	PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7 * G_B5_0 = NULL;
	int32_t G_B7_0 = 0;
	PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7 * G_B7_1 = NULL;
	PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7 * G_B13_0 = NULL;
	PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7 * G_B12_0 = NULL;
	PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7 * G_B9_0 = NULL;
	PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7 * G_B11_0 = NULL;
	PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7 * G_B10_0 = NULL;
	int32_t G_B14_0 = 0;
	PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7 * G_B14_1 = NULL;
	int32_t G_B18_0 = 0;
	PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7 * G_B22_0 = NULL;
	PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7 * G_B21_0 = NULL;
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  G_B23_0;
	memset((&G_B23_0), 0, sizeof(G_B23_0));
	PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7 * G_B23_1 = NULL;
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  G_B25_0;
	memset((&G_B25_0), 0, sizeof(G_B25_0));
	PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7 * G_B25_1 = NULL;
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  G_B24_0;
	memset((&G_B24_0), 0, sizeof(G_B24_0));
	PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7 * G_B24_1 = NULL;
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  G_B26_0;
	memset((&G_B26_0), 0, sizeof(G_B26_0));
	Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  G_B26_1;
	memset((&G_B26_1), 0, sizeof(G_B26_1));
	PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7 * G_B26_2 = NULL;
	{
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_0 = ___t0;
		if (!L_0)
		{
			goto IL_000b;
		}
	}
	{
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_1 = ___t0;
		NullCheck(L_1);
		bool L_2 = ((Tween_t119487E0AB84EF563521F1043116BDBAE68AC437 *)L_1)->get_active_35();
		if (L_2)
		{
			goto IL_000c;
		}
	}

IL_000b:
	{
		return;
	}

IL_000c:
	{
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_3 = ___t0;
		NullCheck(L_3);
		PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7 * L_4 = L_3->get_address_of_plugOptions_56();
		bool L_5 = Nullable_1_get_HasValue_m799FAADF5BA2C9E13220149280B2951799A26D7F_inline((Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE *)(&___forwardDirection1), /*hidden argument*/Nullable_1_get_HasValue_m799FAADF5BA2C9E13220149280B2951799A26D7F_RuntimeMethod_var);
		G_B4_0 = L_4;
		if (!L_5)
		{
			G_B8_0 = L_4;
			goto IL_003e;
		}
	}
	{
		Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE  L_6 = ___forwardDirection1;
		V_0 = L_6;
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720_il2cpp_TypeInfo_var);
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_7 = Vector3_get_zero_m3CDDCAE94581DF3BB16C4B40A100E28E9C6649C2(/*hidden argument*/NULL);
		V_1 = L_7;
		bool L_8 = Nullable_1_get_HasValue_m799FAADF5BA2C9E13220149280B2951799A26D7F_inline((Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE *)(&V_0), /*hidden argument*/Nullable_1_get_HasValue_m799FAADF5BA2C9E13220149280B2951799A26D7F_RuntimeMethod_var);
		G_B5_0 = G_B4_0;
		if (!L_8)
		{
			G_B6_0 = G_B4_0;
			goto IL_003b;
		}
	}
	{
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_9 = Nullable_1_GetValueOrDefault_m35E99BED1252A5C9E5A0D197FCF8E3C0E2A3C2A8_inline((Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE *)(&V_0), /*hidden argument*/Nullable_1_GetValueOrDefault_m35E99BED1252A5C9E5A0D197FCF8E3C0E2A3C2A8_RuntimeMethod_var);
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_10 = V_1;
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720_il2cpp_TypeInfo_var);
		bool L_11 = Vector3_op_Inequality_mFEEAA4C4BF743FB5B8A47FF4967A5E2C73273D6E(L_9, L_10, /*hidden argument*/NULL);
		G_B7_0 = ((int32_t)(L_11));
		G_B7_1 = G_B5_0;
		goto IL_003c;
	}

IL_003b:
	{
		G_B7_0 = 1;
		G_B7_1 = G_B6_0;
	}

IL_003c:
	{
		G_B8_0 = G_B7_1;
		if (G_B7_0)
		{
			G_B13_0 = G_B7_1;
			goto IL_006d;
		}
	}

IL_003e:
	{
		bool L_12 = Nullable_1_get_HasValue_m799FAADF5BA2C9E13220149280B2951799A26D7F_inline((Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE *)(&___up2), /*hidden argument*/Nullable_1_get_HasValue_m799FAADF5BA2C9E13220149280B2951799A26D7F_RuntimeMethod_var);
		G_B9_0 = G_B8_0;
		if (!L_12)
		{
			G_B12_0 = G_B8_0;
			goto IL_006a;
		}
	}
	{
		Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE  L_13 = ___up2;
		V_2 = L_13;
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720_il2cpp_TypeInfo_var);
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_14 = Vector3_get_zero_m3CDDCAE94581DF3BB16C4B40A100E28E9C6649C2(/*hidden argument*/NULL);
		V_3 = L_14;
		bool L_15 = Nullable_1_get_HasValue_m799FAADF5BA2C9E13220149280B2951799A26D7F_inline((Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE *)(&V_2), /*hidden argument*/Nullable_1_get_HasValue_m799FAADF5BA2C9E13220149280B2951799A26D7F_RuntimeMethod_var);
		G_B10_0 = G_B9_0;
		if (!L_15)
		{
			G_B11_0 = G_B9_0;
			goto IL_0067;
		}
	}
	{
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_16 = Nullable_1_GetValueOrDefault_m35E99BED1252A5C9E5A0D197FCF8E3C0E2A3C2A8_inline((Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE *)(&V_2), /*hidden argument*/Nullable_1_GetValueOrDefault_m35E99BED1252A5C9E5A0D197FCF8E3C0E2A3C2A8_RuntimeMethod_var);
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_17 = V_3;
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720_il2cpp_TypeInfo_var);
		bool L_18 = Vector3_op_Inequality_mFEEAA4C4BF743FB5B8A47FF4967A5E2C73273D6E(L_16, L_17, /*hidden argument*/NULL);
		G_B14_0 = ((int32_t)(L_18));
		G_B14_1 = G_B10_0;
		goto IL_006e;
	}

IL_0067:
	{
		G_B14_0 = 1;
		G_B14_1 = G_B11_0;
		goto IL_006e;
	}

IL_006a:
	{
		G_B14_0 = 0;
		G_B14_1 = G_B12_0;
		goto IL_006e;
	}

IL_006d:
	{
		G_B14_0 = 1;
		G_B14_1 = G_B13_0;
	}

IL_006e:
	{
		G_B14_1->set_hasCustomForwardDirection_8((bool)G_B14_0);
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_19 = ___t0;
		NullCheck(L_19);
		PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7 * L_20 = L_19->get_address_of_plugOptions_56();
		bool L_21 = L_20->get_hasCustomForwardDirection_8();
		if (!L_21)
		{
			goto IL_00f0;
		}
	}
	{
		Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE  L_22 = ___forwardDirection1;
		V_4 = L_22;
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720_il2cpp_TypeInfo_var);
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_23 = Vector3_get_zero_m3CDDCAE94581DF3BB16C4B40A100E28E9C6649C2(/*hidden argument*/NULL);
		V_5 = L_23;
		bool L_24 = Nullable_1_get_HasValue_m799FAADF5BA2C9E13220149280B2951799A26D7F_inline((Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE *)(&V_4), /*hidden argument*/Nullable_1_get_HasValue_m799FAADF5BA2C9E13220149280B2951799A26D7F_RuntimeMethod_var);
		if (!L_24)
		{
			goto IL_00a3;
		}
	}
	{
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_25 = Nullable_1_GetValueOrDefault_m35E99BED1252A5C9E5A0D197FCF8E3C0E2A3C2A8_inline((Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE *)(&V_4), /*hidden argument*/Nullable_1_GetValueOrDefault_m35E99BED1252A5C9E5A0D197FCF8E3C0E2A3C2A8_RuntimeMethod_var);
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_26 = V_5;
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720_il2cpp_TypeInfo_var);
		bool L_27 = Vector3_op_Equality_mA9E2F96E98E71AE7ACCE74766D700D41F0404806(L_25, L_26, /*hidden argument*/NULL);
		G_B18_0 = ((int32_t)(L_27));
		goto IL_00a4;
	}

IL_00a3:
	{
		G_B18_0 = 0;
	}

IL_00a4:
	{
		if (!G_B18_0)
		{
			goto IL_00b2;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720_il2cpp_TypeInfo_var);
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_28 = Vector3_get_forward_m3E2E192B3302130098738C308FA1EE1439449D0D(/*hidden argument*/NULL);
		Nullable_1__ctor_m49ABD148B7A7789CB005BA17CA29E1896EE35057((Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE *)(&___forwardDirection1), L_28, /*hidden argument*/Nullable_1__ctor_m49ABD148B7A7789CB005BA17CA29E1896EE35057_RuntimeMethod_var);
	}

IL_00b2:
	{
		TweenerCore_3_tB8E672121CDE6F3B5895C573FE30EF8B42170AB1 * L_29 = ___t0;
		NullCheck(L_29);
		PathOptions_tE44D7F93669AF298F0376DB1276BFAF8902F65A7 * L_30 = L_29->get_address_of_plugOptions_56();
		bool L_31 = Nullable_1_get_HasValue_m799FAADF5BA2C9E13220149280B2951799A26D7F_inline((Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE *)(&___forwardDirection1), /*hidden argument*/Nullable_1_get_HasValue_m799FAADF5BA2C9E13220149280B2951799A26D7F_RuntimeMethod_var);
		G_B21_0 = L_30;
		if (!L_31)
		{
			G_B22_0 = L_30;
			goto IL_00ca;
		}
	}
	{
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_32 = Nullable_1_get_Value_m902B83FE050783CC1CEF6CB970A5AAB926F77D9C((Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE *)(&___forwardDirection1), /*hidden argument*/Nullable_1_get_Value_m902B83FE050783CC1CEF6CB970A5AAB926F77D9C_RuntimeMethod_var);
		G_B23_0 = L_32;
		G_B23_1 = G_B21_0;
		goto IL_00cf;
	}

IL_00ca:
	{
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720_il2cpp_TypeInfo_var);
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_33 = Vector3_get_forward_m3E2E192B3302130098738C308FA1EE1439449D0D(/*hidden argument*/NULL);
		G_B23_0 = L_33;
		G_B23_1 = G_B22_0;
	}

IL_00cf:
	{
		bool L_34 = Nullable_1_get_HasValue_m799FAADF5BA2C9E13220149280B2951799A26D7F_inline((Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE *)(&___up2), /*hidden argument*/Nullable_1_get_HasValue_m799FAADF5BA2C9E13220149280B2951799A26D7F_RuntimeMethod_var);
		G_B24_0 = G_B23_0;
		G_B24_1 = G_B23_1;
		if (!L_34)
		{
			G_B25_0 = G_B23_0;
			G_B25_1 = G_B23_1;
			goto IL_00e1;
		}
	}
	{
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_35 = Nullable_1_get_Value_m902B83FE050783CC1CEF6CB970A5AAB926F77D9C((Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE *)(&___up2), /*hidden argument*/Nullable_1_get_Value_m902B83FE050783CC1CEF6CB970A5AAB926F77D9C_RuntimeMethod_var);
		G_B26_0 = L_35;
		G_B26_1 = G_B24_0;
		G_B26_2 = G_B24_1;
		goto IL_00e6;
	}

IL_00e1:
	{
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720_il2cpp_TypeInfo_var);
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_36 = Vector3_get_up_m6309EBC4E42D6D0B3D28056BD23D0331275306F7(/*hidden argument*/NULL);
		G_B26_0 = L_36;
		G_B26_1 = G_B25_0;
		G_B26_2 = G_B25_1;
	}

IL_00e6:
	{
		IL2CPP_RUNTIME_CLASS_INIT(Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357_il2cpp_TypeInfo_var);
		Quaternion_t319F3319A7D43FFA5D819AD6C0A98851F0095357  L_37 = Quaternion_LookRotation_m7BED8FBB457FF073F183AC7962264E5110794672(G_B26_1, G_B26_0, /*hidden argument*/NULL);
		G_B26_2->set_forward_9(L_37);
	}

IL_00f0:
	{
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DG.Tweening.Tweener::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Tweener__ctor_mA00C2693990531C2636134E4443E6E515EEE33FC (Tweener_t9B2A5E94EE6D11F7607E58AE4E37186FF63587C8 * __this, const RuntimeMethod* method)
{
	{
		__this->set_isFromAllowed_52((bool)1);
		Tween__ctor_m6A636EF784F92284565ABFC0513F134BBEB27E74(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_EXTERN_C inline  IL2CPP_METHOD_ATTR int32_t String_get_Length_mD48C8A16A5CF1914F330DCE82D9BE15C3BEDD018_inline (String_t* __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = __this->get_m_stringLength_0();
		return L_0;
	}
}
IL2CPP_EXTERN_C inline IL2CPP_METHOD_ATTR bool Nullable_1_get_HasValue_m799FAADF5BA2C9E13220149280B2951799A26D7F_gshared_inline (Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE * __this, const RuntimeMethod* method)
{
	{
		bool L_0 = (bool)__this->get_has_value_1();
		return L_0;
	}
}
IL2CPP_EXTERN_C inline IL2CPP_METHOD_ATTR Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  Nullable_1_GetValueOrDefault_m35E99BED1252A5C9E5A0D197FCF8E3C0E2A3C2A8_gshared_inline (Nullable_1_tCE53BD40AA999E709C1D2369B2A531373CDD89EE * __this, const RuntimeMethod* method)
{
	{
		Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720  L_0 = (Vector3_tDCF05E21F632FE2BA260C06E0D10CA81513E6720 )__this->get_value_0();
		return L_0;
	}
}
