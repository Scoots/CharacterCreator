using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Enumerations
{
	public enum TraitType
	{
		Combat,
		Faith,
		Magic,
		Social,
		Campaign,
		Race,
		Regional,
		Religion
	}

	public enum CampaignNames
	{
		Null,
		CampaignName1,
		CampaignName2
	}

	public enum RegionNames
	{
		Null,
		FiveKingsMountains,
		RegionName2
	}

	public enum ReligionNames
	{
		Null,
		Gorum,
		Torag
	}

	public enum RaceNames
	{
		Null,
		Dwarf,
		Orc,
		HalfOrc,
		Elf
	}
}