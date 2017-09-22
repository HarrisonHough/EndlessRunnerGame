using UnityEngine;

public class LevelBlock : MonoBehaviour {

    public AttachPoint attachPoint;

	// Use this for initialization
	void Start () {
        attachPoint = GetComponentInChildren<AttachPoint>();	
	}

    public AttachPoint GetAttachPoint()
    {
        attachPoint = GetComponentInChildren<AttachPoint>();
        return attachPoint;
    }

}
