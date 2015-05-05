using UnityEngine;
using System.Collections;

public static class SquadManager {
	public static Squad curSquad;
	public static ArrayList playerSquadList;
	public static void CreateNewSquad (Unit u, string name, int exp, int funds){
		Squad s = new Squad ();
		s.SetName (name);
		s.SetExperience (exp);
		s.SetFunds (funds);
		s.SetLeader (u);
		s.AddUnit (u);
		s.SetCurLoc ((Landmark)(MapManager.curMap.GetLandmarkList()[0]));
		playerSquadList = new ArrayList ();
		playerSquadList.Add (s);
		Debug.Log (name + " Created");

		curSquad = s;
	}
}
