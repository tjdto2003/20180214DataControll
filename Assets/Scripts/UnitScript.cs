using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitScript : MonoBehaviour {

    public enum UNITTRIBE
    {
        NEUTRAL=0,
        PROTSS,
        ZERG,
        TERRAN
    }
    public UNITTRIBE unitTribe;//종족
    public string unitName;//유닉이름
    public int unitHP;//체력
    public int unitMp;//마나
    public int unitATK;//공격력
    public int unitDEF;//방어력
    public int unitSHD;//쉴드
    public float unitASP;//공격속도
    public float unitMSP;//이동속도
    public float unitRange;//사거리
    internal UNITTRIBE unutTribe;

    void Start ()
    {
        gameObject.name = unitName;
	}
	
	
	void Update ()
    {
		
	}
}
