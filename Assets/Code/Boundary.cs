using UnityEngine;

[System.Serializable]
public class Boundary : MonoBehaviour
{
	public static float xMin = -24.0f, xMax = 22.0f, zMin = -3.0f, zMax = -1.0f;

	public static float XMin {
		get{ return xMin;}
		set{ xMin = value;}
	}
	public static float XMax {
		get{ return xMax;}
		set{ xMax = value;}
	}
	public static float ZMin {
		get{ return zMin;}
		set{ zMin = value;}
	}
	public static float ZMax {
		get{ return zMax;}
		set{zMax = value;}
	}
}
