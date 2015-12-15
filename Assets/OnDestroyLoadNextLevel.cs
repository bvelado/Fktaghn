using UnityEngine;
using System.Collections;

public class OnDestroyLoadNextLevel : MonoBehaviour {

	void OnDestroy () {
		GameController.Instance.Next();
	}
}
