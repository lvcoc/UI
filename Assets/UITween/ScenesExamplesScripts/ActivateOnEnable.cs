using UnityEngine;
using System.Collections;

public class ActivateOnEnable : MonoBehaviour {

	public EasyTween EasyTweenStart;

    private void OnEnable()
    {
        //yield return new WaitForEndOfFrame();
        EasyTweenStart.OpenCloseObjectAnimation();
        //Debug.Log("now");
    }

}
