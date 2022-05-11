using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC002_Comp : MonoBehaviour
{

	public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject ThePlayer;
	public GameObject TextBox;
	public GameObject NPCName;
	public GameObject NPCText;

	void Update()
	{
		TheDistance = PlayerCasting.DistanceFromTarget;
	}

	void OnMouseOver()
	{
		if (TheDistance <= 3)
		{
			AttackBlocker.BlockSword = 1;
			ActionText.GetComponent<Text>().text = "Talk";
			ActionDisplay.SetActive(true);
			ActionText.SetActive(true);
		}

		if (Input.GetButtonDown("Action"))
		{
			if (TheDistance <= 3)
			{
				AttackBlocker.BlockSword = 2;
				Screen.lockCursor = false;
				Cursor.visible = true;
				ActionDisplay.SetActive(false);
				ActionText.SetActive(false);
				//ThePlayer.SetActive (false);
				StartCoroutine(NPC001Active());
			}
		}
	}

	void OnMouseExit()
	{
		AttackBlocker.BlockSword = 0;
		ActionDisplay.SetActive(false);
		ActionText.SetActive(false);
	}

	IEnumerator NPC001Active()
	{
		if (QuestManager.ActiveQuestNumber == 2 && QuestManager.SubQuestNumber == 4)
        {
			TextBox.SetActive(true);
			NPCName.GetComponent<Text>().text = "Warrior";
			NPCName.SetActive(true);
			NPCText.GetComponent<Text>().text = "goddaymnnn you're strong thanks for the help much love *mwah* also go explore the cave xoxo ";
			QuestManager.ActiveQuestNumber = 3;
			QuestManager.SubQuestNumber = 1;
			NPCText.SetActive(true);
			yield return new WaitForSeconds(5.5f);
			NPCName.SetActive(false);
			NPCText.SetActive(false);
			TextBox.SetActive(false);
			ActionDisplay.SetActive(true);
			ActionText.SetActive(true);
		}
        else
        {
			TextBox.SetActive(true);
			NPCName.GetComponent<Text>().text = "Warrior";
			NPCName.SetActive(true);
			NPCText.GetComponent<Text>().text = "Come back to me once youve explored the caves :)";
			NPCText.SetActive(true);
			yield return new WaitForSeconds(5.5f);
			NPCName.SetActive(false);
			NPCText.SetActive(false);
			TextBox.SetActive(false);
			ActionDisplay.SetActive(true);
			ActionText.SetActive(true);
		}
		

	}

}