using System;
using Cinemachine;
using GGD_Hack.Utils;
using Handlers.GameHandlers.PlayerHandlers;
using Handlers.LobbyHandlers;
using HarmonyLib;
using MelonLoader;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace GGD_Hack.Features
{
	// Token: 0x02000053 RID: 83
	public class ZoomSlider
	{
		// Token: 0x06000157 RID: 343 RVA: 0x0005C1E0 File Offset: 0x000597E0
		public static void CreateSlider()
		{
			uint num = 455946887U;
			for (;;)
			{
				Component masterVolume = LobbySceneHandler.Instance.clientSettings.masterVolume;
				num = 1219521513U % num;
				GameObject gameObject = masterVolume.gameObject;
				num = 1270112632U + num;
				GameObject gameObject2 = gameObject;
				num = 2113411790U % num;
				Object @object = gameObject2;
				num = 761070787U << (int)num;
				bool flag = @object == null;
				num = 1786005418U << (int)num;
				if (flag)
				{
					break;
				}
				GameObject gamePanel = LobbySceneHandler.Instance.gamePanel;
				num >>= 26;
				Transform transform = gamePanel.transform;
				num &= 1222250704U;
				Transform transform2 = transform.Find("RoleIcon");
				num = 862410416U << (int)num;
				GameObject gameObject3 = gameObject2;
				num %= 902314308U;
				GameObject gameObject4 = Object.Instantiate<GameObject>(gameObject3, transform2);
				string name = "ZoomSlider";
				num = (1283933029U | num);
				gameObject4.name = name;
				num -= 221792844U;
				Transform transform3 = gameObject4.transform;
				float num2 = 300f;
				num ^= 942438194U;
				float num3 = 40f;
				num = 1186662848U - num;
				Vector3 localPosition = new Vector3(num2, num3, 0f);
				num |= 1719478622U;
				transform3.localPosition = localPosition;
				num = 1636378007U * num;
				Transform transform4 = gameObject4.transform;
				num %= 1367023738U;
				float num4 = 0.5f;
				num %= 1546911869U;
				float num5 = 0.5f;
				float num6 = 1f;
				num = 1175393717U << (int)num;
				Vector3 localScale = new Vector3(num4, num5, num6);
				num >>= 4;
				transform4.localScale = localScale;
				num >>= 3;
				num *= 1811956782U;
				Transform transform5 = gameObject4.transform;
				num *= 2097546003U;
				string text = "Label";
				num = 1768825750U % num;
				Component component = transform5.Find(text);
				num >>= 14;
				GameObject gameObject5 = component.gameObject;
				num %= 641670629U;
				TextMeshProUGUI component2 = gameObject5.GetComponent<TextMeshProUGUI>();
				num |= 1055869915U;
				bool flag2 = Utils.IsChineseSystem();
				num = 1569085689U % num;
				string text2;
				if (!flag2)
				{
					text2 = "Zoom Size";
				}
				else
				{
					num = 415040284U + num;
					text2 = "视野缩放";
					num ^= 700777700U;
				}
				num ^= 760642873U;
				component2.text = text2;
				num = 1293313768U % num;
				bool flag3 = (num ^ 425087265U) != 0U;
				num = 1844734578U * num;
				component2.ForceMeshUpdate(flag3, (num ^ 1719388850U) != 0U);
				num = 1054306787U + num;
				num -= 1932414743U;
				Object.Destroy(gameObject4.transform.Find("Value").gameObject);
				num ^= 2048554281U;
				num /= 1130697599U;
				Object component3 = gameObject4.GetComponent<GamepadButtonSelector>();
				num %= 2076983365U;
				Object.Destroy(component3);
				num *= 2025683377U;
				num /= 751400591U;
				Object.Destroy(gameObject4.GetComponent<SliderGamepadHandler>());
				num -= 1464467964U;
				Slider component4 = gameObject4.GetComponent<Slider>();
				num = 1914204661U << (int)num;
				ZoomSlider.zoomSlider = component4;
				num = 475144315U % num;
				Slider slider = ZoomSlider.zoomSlider;
				num += 703482416U;
				UnityEventBase onValueChanged = slider.onValueChanged;
				num &= 1385386142U;
				onValueChanged.RemoveAllListeners();
				if (num >> 20 != 0U)
				{
					goto Block_3;
				}
			}
			string text3 = "masterVolumeGameObject为空！";
			num = 1964407818U << (int)num;
			MelonLogger.Warning(text3);
			return;
			Block_3:
			Slider slider2 = ZoomSlider.zoomSlider;
			float minValue = 4f;
			num = 451415471U + num;
			slider2.minValue = minValue;
			Slider slider3 = ZoomSlider.zoomSlider;
			num = (513948228U ^ num);
			slider3.maxValue = 40f;
			Slider slider4 = ZoomSlider.zoomSlider;
			float value = 4f;
			num = (1268213286U & num);
			slider4.value = value;
			UnityEvent<float> onValueChanged2 = ZoomSlider.zoomSlider.onValueChanged;
			Action<float> action;
			if ((action = ZoomSlider.<>c.<>9__1_0) == null)
			{
				num -= 1166747889U;
				object <> = ZoomSlider.<>c.<>9;
				IntPtr method = ldftn(<CreateSlider>b__1_0);
				num %= 22358327U;
				action = (ZoomSlider.<>c.<>9__1_0 = new Action<float>(<>, method));
				num += 1097504396U;
			}
			UnityAction<float> unityAction = action;
			num /= 793642191U;
			onValueChanged2.AddListener(unityAction);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0005C554 File Offset: 0x00059B54
		private static void ChangeOrthographicSize(float newValue)
		{
			CinemachineStateDrivenCamera ammpoafilkj = LocalPlayer.Instance.AMMPOAFILKJ;
			CinemachineVirtualCamera ecabmkjbgjj = LocalPlayer.Instance.ECABMKJBGJJ;
			Object animatedTarget = ammpoafilkj.m_AnimatedTarget;
			uint num = 550386372U;
			if (animatedTarget != null)
			{
				CinemachineStateDrivenCamera cinemachineStateDrivenCamera = ammpoafilkj;
				num = 1344692654U + num;
				Animator animatedTarget2 = null;
				num += 1500725338U;
				cinemachineStateDrivenCamera.m_AnimatedTarget = animatedTarget2;
				num += 1449549304U;
			}
			LensSettings lens = ecabmkjbgjj.m_Lens;
			num *= 1917851909U;
			float orthographicSize = newValue;
			num >>= 4;
			lens.OrthographicSize = orthographicSize;
			num = (774143698U ^ num);
			LensSettings lens2 = lens;
			num ^= 1739142535U;
			ecabmkjbgjj.m_Lens = lens2;
			num = 609840844U + num;
			ConsoleColor consoleColor = (ConsoleColor)(num ^ 1941339806U);
			string str = "新的视野缩放数值";
			num = 1771396770U << (int)num;
			num = (250176828U | num);
			string text = str + newValue.ToString();
			num &= 144530945U;
			MelonLogger.Msg(consoleColor, text);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0005C624 File Offset: 0x00059C24
		public ZoomSlider()
		{
			uint num = 982716288U;
			do
			{
				base..ctor();
			}
			while (2053379090U < num);
		}

		// Token: 0x0400019B RID: 411
		public static Slider zoomSlider;

		// Token: 0x020000B1 RID: 177
		[HarmonyPatch(typeof(LobbySceneHandler), "Start")]
		private class InitSlider
		{
			// Token: 0x0600024D RID: 589 RVA: 0x00067384 File Offset: 0x00064984
			private static void Postfix()
			{
				uint num = 1814301596U;
				if (num != 1087191316U)
				{
					ZoomSlider.CreateSlider();
				}
			}

			// Token: 0x0600024E RID: 590 RVA: 0x000673A8 File Offset: 0x000649A8
			public InitSlider()
			{
				uint num = 25362500U;
				if (num != 1700944907U)
				{
					do
					{
						base..ctor();
					}
					while (706364018U < num);
				}
			}
		}

		// Token: 0x020000B2 RID: 178
		[HarmonyPatch(typeof(LobbySceneHandler), "Update")]
		private class UpdateSliderName
		{
			// Token: 0x0600024F RID: 591 RVA: 0x000673D8 File Offset: 0x000649D8
			private static void Postfix()
			{
				GameObject gameObject = ZoomSlider.zoomSlider.gameObject;
				uint num = 1372607127U;
				Transform transform = gameObject.transform;
				num %= 1680562145U;
				GameObject gameObject2 = transform.Find("Label").gameObject;
				num <<= 8;
				TMP_Text component = gameObject2.GetComponent<TextMeshProUGUI>();
				num /= 1216222331U;
				bool flag = Utils.IsChineseSystem();
				num = 970735154U - num;
				string text;
				if (!flag)
				{
					num = (365259549U ^ num);
					text = "Zoom Size";
				}
				else
				{
					text = "视野缩放";
					num ^= 365259549U;
				}
				num += 1310085830U;
				component.text = text;
			}

			// Token: 0x06000250 RID: 592 RVA: 0x00067464 File Offset: 0x00064A64
			public UpdateSliderName()
			{
				uint num = 749485647U;
				if (54491840U < num)
				{
					do
					{
						num += 776889902U;
						base..ctor();
					}
					while (num * 149782521U == 0U);
				}
			}
		}
	}
}
