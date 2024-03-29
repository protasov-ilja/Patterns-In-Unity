﻿using Patterns.Factory.Enums;
using Patterns.Factory.NPCs;
using UnityEngine;

namespace Patterns.Factory
{
	public class NPCFactory : MonoBehaviour
	{
		public INPC GetNPC(NPCType type)
		{
			switch(type)
			{
				case NPCType.Beggar:
					INPC beggar = new Beggar();
					return beggar;
				case NPCType.Farmer:
					INPC farmer = new Farmer();
					return farmer;
				case NPCType.Shopowner:
					INPC shopowner = new Shopowner();
					return shopowner;
			}

			return null;
		}
	}
}
