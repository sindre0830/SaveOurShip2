﻿using System;
using System.Collections.Generic;
using Verse;
using UnityEngine;
using System.Linq;
using RimWorld;

namespace SaveOurShip2
{
	public class SpaceNavyDef : Def
	{
		public List<FactionDef> factionDefs = new List<FactionDef>();
		public List<SpaceShipDef> spaceShipDefs = new List<SpaceShipDef>();
		public string colorPrimary;
		public string colorSecondary;
		public string colorLighting;
		public bool canOperateAfterFactionDefeated = true;
		public bool bountyHunts;
		public bool pirates;

		public PawnKindDef crewDef;
		public PawnKindDef marineDef;
		public PawnKindDef marineHeavyDef;

		public string GetUniqueLoadID()
		{
			return "SpaceNavy_" + defName;
		}
	}
}