using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class obj_InfoCode : ObjectiveCode
{
	[Space]
	[Header("Info Variable")]
	public Text subTxt;

	public string str_subtitleText;

	public float float_timeOfSubtitle;
	public override void StartObjective()
	{
		subTxt = objectiveMaster.subTxt;

		subTxt.text = str_subtitleText;
		subTxt.gameObject.SetActive(true);

		StartCoroutine(TimeForSubtitle());
	}
	public override void DoingObjective()
	{

	}
	public override void EndObjective()
	{
		subTxt.gameObject.SetActive(false);
	}

	IEnumerator TimeForSubtitle()
	{

		yield return new WaitForSeconds(float_timeOfSubtitle);

		objectiveMaster.NextObj();
	}

}
