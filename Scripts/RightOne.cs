using UnityEngine;
using System.Collections;

public class RightOne : MonoBehaviour
{

	private GameObject mainCube;
	private GameObject pLost;

	void Start()
	{
		mainCube = GameObject.Find("Main Cube");
	}

	void OnMouseDown()
	{
		if (GetComponent<Renderer>().material.color == mainCube.GetComponent<Renderer>().material.color)
		{
			mainCube.GetComponent<GameCntrl>().next = true;
		}
		else
			mainCube.GetComponent<GameCntrl>().lose = true;
	}
}
