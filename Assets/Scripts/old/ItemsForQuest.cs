using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemsForQuest : MonoBehaviour
{
	[SerializeField] private Image[] Items;

	private void Awake()
	{
		
		GlobalVars.i.QuestItems = Items;
		GlobalVars.i.HideItems();
	}
}
