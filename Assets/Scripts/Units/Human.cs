using UnityEngine;
using System.Collections;

public class Human : Unit{
	public Human (string name, Texture unitPortrait, Type unitType){
		strength = 4;
		dexterity = 3;
		intelligence = 4;
		endurance = 4;
	}
}