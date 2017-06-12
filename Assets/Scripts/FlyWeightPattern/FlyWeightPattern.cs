using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyWeightPattern : MonoBehaviour {
	private float startTime;
	private float flyWeightPatternTime = 0f;
	private float usuallyTime = 0f;

	void Start () {
		startTime = Time.realtimeSinceStartup;
		for(int i = 0; i < 10000; i++){
			new HevyObject();
		}
		usuallyTime = Time.realtimeSinceStartup - startTime;
		startTime = Time.realtimeSinceStartup;
		for(int i = 0; i < 10000; i++){
			new LightObject();
		}
		flyWeightPatternTime = Time.realtimeSinceStartup - startTime;

		Debug.Log("Not use flyweight : " + usuallyTime);
		Debug.Log("Use flyweight     : " + flyWeightPatternTime);
	}

	public class DataStore{
		int[] initData = new int[1000];
	}

	public class LightObject{
		static DataStore dataStore;
		static LightObject(){
			if(dataStore == null){
				dataStore = new DataStore();
			}
		}
	}

	public class HevyObject{
		int[] initData = new int[1000];
	}
}
