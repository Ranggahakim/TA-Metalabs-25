using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class obj_DoAnimation : ObjectiveCode
{
	[Space]
	[Header("Info Variable")]
	public Animator myAnimator;
	public float float_animationTime;

	[Header("Parameter Name of Animation")]
	public string[] str_BoolAnimTrue;
	public string[] str_BoolAnimFalse;
	public string[] str_TriggerAnim;

	public override void StartObjective()
	{
		if (str_BoolAnimFalse.Length != 0)
		{
			foreach (string str in str_BoolAnimFalse)
			{
				myAnimator.SetBool(str, false);
			}
		}

		if (str_BoolAnimTrue.Length != 0)
		{
			foreach (string str in str_BoolAnimTrue)
			{
				myAnimator.SetBool(str, true);
			}
		}

		if (str_TriggerAnim.Length != 0)
		{
			foreach (string str in str_TriggerAnim)
			{
				myAnimator.SetTrigger(str);
			}
		}

		StartCoroutine(EndTheAnimation());

	}
	public override void DoingObjective()
	{

	}
	public override void EndObjective()
	{

	}

	IEnumerator EndTheAnimation()
	{
		yield return new WaitForSeconds(float_animationTime);

		objectiveMaster.NextObj();
	}

}
