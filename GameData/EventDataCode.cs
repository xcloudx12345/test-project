﻿using System;

namespace GGD_Hack.GameData
{
	// Token: 0x02000028 RID: 40
	public enum EventDataCode
	{
		// Token: 0x04000033 RID: 51
		PLUGIN_MESSAGE,
		// Token: 0x04000034 RID: 52
		COMPLETE_TASK,
		// Token: 0x04000035 RID: 53
		EMERGENCY,
		// Token: 0x04000036 RID: 54
		RECEIVE_KILL,
		// Token: 0x04000037 RID: 55
		REPORT,
		// Token: 0x04000038 RID: 56
		VOTE,
		// Token: 0x04000039 RID: 57
		SABOTAGE,
		// Token: 0x0400003A RID: 58
		VENT,
		// Token: 0x0400003B RID: 59
		EXIT_VENT,
		// Token: 0x0400003C RID: 60
		CONNECT_TO_TASK,
		// Token: 0x0400003D RID: 61
		ASSIGN_TASK,
		// Token: 0x0400003E RID: 62
		LOOK_AT_CAMERAS,
		// Token: 0x0400003F RID: 63
		SPECIAL_KILL,
		// Token: 0x04000040 RID: 64
		EVALUATE_IMAGES,
		// Token: 0x04000041 RID: 65
		UNASSIGN_TASK,
		// Token: 0x04000042 RID: 66
		BROADCAST,
		// Token: 0x04000043 RID: 67
		FART,
		// Token: 0x04000044 RID: 68
		KICK_PLAYER,
		// Token: 0x04000045 RID: 69
		DECREASE_TIMER,
		// Token: 0x04000046 RID: 70
		EAT,
		// Token: 0x04000047 RID: 71
		SEND_KILL,
		// Token: 0x04000048 RID: 72
		MORPH,
		// Token: 0x04000049 RID: 73
		GAME_ENDED,
		// Token: 0x0400004A RID: 74
		IS_CHATTING,
		// Token: 0x0400004B RID: 75
		SILENCE,
		// Token: 0x0400004C RID: 76
		LOVER_SUICIDE,
		// Token: 0x0400004D RID: 77
		VOTE_STATE_CHANGE,
		// Token: 0x0400004E RID: 78
		NOTIFY_BEHAVIOR_VOICE_BAN,
		// Token: 0x0400004F RID: 79
		TELEPORT,
		// Token: 0x04000050 RID: 80
		DECON,
		// Token: 0x04000051 RID: 81
		MOVE_SHUTTLE,
		// Token: 0x04000052 RID: 82
		DAMAGE_TELEPORTER,
		// Token: 0x04000053 RID: 83
		INFECT,
		// Token: 0x04000054 RID: 84
		RECEIVE_VOTE,
		// Token: 0x04000055 RID: 85
		ASSASSINATE,
		// Token: 0x04000056 RID: 86
		PROCEEDING_VOTE_STATE,
		// Token: 0x04000057 RID: 87
		SPAWN_KEYS,
		// Token: 0x04000058 RID: 88
		PICK_UP_KEY,
		// Token: 0x04000059 RID: 89
		KNOCK_DOOR,
		// Token: 0x0400005A RID: 90
		EXIT_DOOR,
		// Token: 0x0400005B RID: 91
		SPECTATOR_INFO,
		// Token: 0x0400005C RID: 92
		SPECTATOR_STATE,
		// Token: 0x0400005D RID: 93
		SYNC_LOUNGE_MUSIC,
		// Token: 0x0400005E RID: 94
		OPEN_DOOR,
		// Token: 0x0400005F RID: 95
		CLOSE_DOOR,
		// Token: 0x04000060 RID: 96
		TOGGLE_DND,
		// Token: 0x04000061 RID: 97
		HELIUM,
		// Token: 0x04000062 RID: 98
		WHISTLEBLOW_BOMB,
		// Token: 0x04000063 RID: 99
		THROW_BOMB,
		// Token: 0x04000064 RID: 100
		EXPLODE_BOMB,
		// Token: 0x04000065 RID: 101
		SETTINGS_UPDATE,
		// Token: 0x04000066 RID: 102
		FEED_GOD,
		// Token: 0x04000067 RID: 103
		PLAYER_PROPERTIES_UPDATE,
		// Token: 0x04000068 RID: 104
		LIGHT_TORCH,
		// Token: 0x04000069 RID: 105
		SET_GOD,
		// Token: 0x0400006A RID: 106
		DROP_BRIDGE,
		// Token: 0x0400006B RID: 107
		CREATE_FOOD,
		// Token: 0x0400006C RID: 108
		PICK_UP_FOOD,
		// Token: 0x0400006D RID: 109
		TASK_COMPLETED,
		// Token: 0x0400006E RID: 110
		GRAB_BODY,
		// Token: 0x0400006F RID: 111
		UPDATE_TASKBAR,
		// Token: 0x04000070 RID: 112
		DROP_BODY,
		// Token: 0x04000071 RID: 113
		GENERATE_BOMB,
		// Token: 0x04000072 RID: 114
		REQUEST_SYNC_LOUNGE_MUSIC,
		// Token: 0x04000073 RID: 115
		INVESTIGATE,
		// Token: 0x04000074 RID: 116
		REVEAL_ROLE,
		// Token: 0x04000075 RID: 117
		CHAT_MESSAGE,
		// Token: 0x04000076 RID: 118
		USED_ROLE_SPECIAL,
		// Token: 0x04000077 RID: 119
		MORTICIAN_ABILITY,
		// Token: 0x04000078 RID: 120
		ENABLE_BOUNTY_ICON,
		// Token: 0x04000079 RID: 121
		LAST_PEASANT,
		// Token: 0x0400007A RID: 122
		DUELING_DODO_REVEAL,
		// Token: 0x0400007B RID: 123
		ENABLE_ROLE_BUTTON,
		// Token: 0x0400007C RID: 124
		CELEBRITY_DIED,
		// Token: 0x0400007D RID: 125
		SPAWN_SACRIFICE_BELL,
		// Token: 0x0400007E RID: 126
		PICK_UP_SACRIFICE_BELL,
		// Token: 0x0400007F RID: 127
		BASEMENT_TELEPORT_EFFECT,
		// Token: 0x04000080 RID: 128
		TURN_INVISIBLE,
		// Token: 0x04000081 RID: 129
		PELICAN_EAT,
		// Token: 0x04000082 RID: 130
		PELICAN_KILL,
		// Token: 0x04000083 RID: 131
		PELICAN_RELEASE,
		// Token: 0x04000084 RID: 132
		MEETING_TURN_THRALL,
		// Token: 0x04000085 RID: 133
		MORPH_INTO_MUMMY,
		// Token: 0x04000086 RID: 134
		LATCH_ONTO_VILLAGER,
		// Token: 0x04000087 RID: 135
		SEND_MONSTER,
		// Token: 0x04000088 RID: 136
		SERIAL_KILLER_TARGET,
		// Token: 0x04000089 RID: 137
		SERIAL_KILLER_SUCCESS,
		// Token: 0x0400008A RID: 138
		DRAFT_SEND_ORDER,
		// Token: 0x0400008B RID: 139
		DRAFT_CHOOSE,
		// Token: 0x0400008C RID: 140
		DRAFT_TURN,
		// Token: 0x0400008D RID: 141
		DRAFT_DISCONNECT,
		// Token: 0x0400008E RID: 142
		DRAFT_FAIL,
		// Token: 0x0400008F RID: 143
		DRAFT_DATA,
		// Token: 0x04000090 RID: 144
		GGD_LOBBY_GAME_EVENT,
		// Token: 0x04000091 RID: 145
		GGD_LOBBY_GAME_LIST,
		// Token: 0x04000092 RID: 146
		GGD_LOBBY_GAME_CREATE,
		// Token: 0x04000093 RID: 147
		GGD_LOBBY_GAME_DESTROY,
		// Token: 0x04000094 RID: 148
		GGD_LOBBY_GAME_JOIN,
		// Token: 0x04000095 RID: 149
		GGD_LOBBY_GAME_LEAVE,
		// Token: 0x04000096 RID: 150
		SERVER_SEND_ROLE,
		// Token: 0x04000097 RID: 151
		CLIENT_RECEIVE_ROLE,
		// Token: 0x04000098 RID: 152
		KICK_PLAYER_AFK,
		// Token: 0x04000099 RID: 153
		START_GAME,
		// Token: 0x0400009A RID: 154
		SERVER_ABORT_GAME,
		// Token: 0x0400009B RID: 155
		SEND_DEBUG_SETTINGS,
		// Token: 0x0400009C RID: 156
		TASK_ACHIEVEMENT,
		// Token: 0x0400009D RID: 157
		GAINED_ACHIEVEMENT,
		// Token: 0x0400009E RID: 158
		GAME_SETTINGS,
		// Token: 0x0400009F RID: 159
		CHANGE_MAP,
		// Token: 0x040000A0 RID: 160
		LOUNGE_JSON_VALIDATE,
		// Token: 0x040000A1 RID: 161
		LOUNGE_JSON_PROCESS,
		// Token: 0x040000A2 RID: 162
		TRANSFER_MASTER_RECIEVE,
		// Token: 0x040000A3 RID: 163
		TRANSFER_MASTER_RESPONSE,
		// Token: 0x040000A4 RID: 164
		REGISTER_ACK,
		// Token: 0x040000A5 RID: 165
		GENERATE_RANDOM_SPAWN,
		// Token: 0x040000A6 RID: 166
		SET_IDENTITY,
		// Token: 0x040000A7 RID: 167
		SET_TARGET,
		// Token: 0x040000A8 RID: 168
		WRONG_KILL,
		// Token: 0x040000A9 RID: 169
		SET_VIP,
		// Token: 0x040000AA RID: 170
		DUELING_TO_DODO,
		// Token: 0x040000AB RID: 171
		FORCE_EXIT_VENT,
		// Token: 0x040000AC RID: 172
		MAKE_ADMIN,
		// Token: 0x040000AD RID: 173
		ADMIN_VOICE_BAN,
		// Token: 0x040000AE RID: 174
		ADMIN_SUPER_BAN,
		// Token: 0x040000AF RID: 175
		SET_IN_ENDING_SCREEN,
		// Token: 0x040000B0 RID: 176
		RESET_MID_SPECTATORS,
		// Token: 0x040000B1 RID: 177
		RESEND_RECONNECTION_DATA,
		// Token: 0x040000B2 RID: 178
		ASSIGN_TASK_TIMER,
		// Token: 0x040000B3 RID: 179
		NOTIFY_MOD_VOICE_BAN,
		// Token: 0x040000B4 RID: 180
		SET_SANDSTORM_ACTIVE,
		// Token: 0x040000B5 RID: 181
		SPAWN_MUMMY,
		// Token: 0x040000B6 RID: 182
		MUMMY_MOVEMENT,
		// Token: 0x040000B7 RID: 183
		LOCUST_START,
		// Token: 0x040000B8 RID: 184
		TESTING_MIC,
		// Token: 0x040000B9 RID: 185
		DRAFT_RECONNECT,
		// Token: 0x040000BA RID: 186
		SYNC_DESERT_BOAT,
		// Token: 0x040000BB RID: 187
		UPDATE_FIRE_INFO,
		// Token: 0x040000BC RID: 188
		GACHA_DATA,
		// Token: 0x040000BD RID: 189
		GACHA_PLAY,
		// Token: 0x040000BE RID: 190
		REJECT_VOTE,
		// Token: 0x040000BF RID: 191
		STALKER_CHOOSE_TARGET,
		// Token: 0x040000C0 RID: 192
		ESPER_SPECTATE,
		// Token: 0x040000C1 RID: 193
		ESPER_BUTTON_CHANGE,
		// Token: 0x040000C2 RID: 194
		CHANGE_MAP_SKIN,
		// Token: 0x040000C3 RID: 195
		SEND_KILL_SWITCH_DATA,
		// Token: 0x040000C4 RID: 196
		PRECURSOR,
		// Token: 0x040000C5 RID: 197
		GAMESUMMARYDATA,
		// Token: 0x040000C6 RID: 198
		Rpc = 200,
		// Token: 0x040000C7 RID: 199
		UnreliableRead,
		// Token: 0x040000C8 RID: 200
		Instantiate,
		// Token: 0x040000C9 RID: 201
		CloseConnection,
		// Token: 0x040000CA RID: 202
		Destroy,
		// Token: 0x040000CB RID: 203
		RemoveCachedRPCs,
		// Token: 0x040000CC RID: 204
		ReliableRead,
		// Token: 0x040000CD RID: 205
		DestroyPlayer,
		// Token: 0x040000CE RID: 206
		SetMasterClient,
		// Token: 0x040000CF RID: 207
		OwnershipRequest,
		// Token: 0x040000D0 RID: 208
		OwnershipTransfer,
		// Token: 0x040000D1 RID: 209
		VacantViewIds,
		// Token: 0x040000D2 RID: 210
		OwnershipUpdate,
		// Token: 0x040000D3 RID: 211
		Recall = 214,
		// Token: 0x040000D4 RID: 212
		Debugger = 217,
		// Token: 0x040000D5 RID: 213
		AntiCheat,
		// Token: 0x040000D6 RID: 214
		Admin,
		// Token: 0x040000D7 RID: 215
		AuthEvent = 223,
		// Token: 0x040000D8 RID: 216
		LobbyStats,
		// Token: 0x040000D9 RID: 217
		AppStats = 226,
		// Token: 0x040000DA RID: 218
		Match,
		// Token: 0x040000DB RID: 219
		QueueState,
		// Token: 0x040000DC RID: 220
		GameListUpdate,
		// Token: 0x040000DD RID: 221
		GameList,
		// Token: 0x040000DE RID: 222
		CacheSliceChanged = 250,
		// Token: 0x040000DF RID: 223
		ErrorInfo,
		// Token: 0x040000E0 RID: 224
		PropertiesChanged = 253,
		// Token: 0x040000E1 RID: 225
		Leave,
		// Token: 0x040000E2 RID: 226
		Join
	}
}
