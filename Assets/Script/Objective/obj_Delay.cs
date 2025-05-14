using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class obj_Delay : ObjectiveCode
{
	[Space]
	[Header("Info Variable")]
	public float float_delayTime;
	public override void StartObjective()
	{
		StartCoroutine(StartDelay());
	}
	public override void DoingObjective()
	{

	}
	public override void EndObjective()
	{

	}

	IEnumerator StartDelay()
	{
		yield return new WaitForSeconds(float_delayTime);

		objectiveMaster.NextObj();
	}

}
