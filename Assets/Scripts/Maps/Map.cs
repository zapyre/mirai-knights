using UnityEngine;
using System.Collections;

public abstract class Map {
	protected ArrayList landmarkList;
	protected ArrayList connectionList;

	public ArrayList GetLandmarkList (){ return landmarkList; }
	public void SetLandmarkList (ArrayList ll) { landmarkList = ll; }
	public ArrayList GetConnectionList (){ return connectionList; }
	public void SetConnectionList (ArrayList cl) { connectionList = cl; }
}
