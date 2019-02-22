﻿	using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePlayerI_Script : MonoBehaviour
{
	public static string BluePlayerI_ColName;

	void OnTriggerEnter2D(Collider2D col)
	{
	
		if (col.gameObject.tag == "blocks") 
		{
		
			BluePlayerI_ColName = col.gameObject.name;

			if (col.gameObject.name.Contains ("Safe House")) 
			{
			
				print ("Entered PlayerI BlueI in safe house");
			
			}
		}
	}
	// Use this for initialization
	void Start () 
	{
		
		BluePlayerI_ColName = "none";
	
	}
	
	// Update is called once per frame

}