// Source: Aigei, Tropic Environment Pack [online] Available at:< https://www.aigei.com/item/unity3d_da_hai.html > [Accessed 17 Apr. 2021].

using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(WaterBase))]

public class Displace : MonoBehaviour 
{		
	private WaterBase waterBase = null;
		
	public void Start() 
	{
		if(!waterBase)
			waterBase = (WaterBase) gameObject.GetComponent(typeof(WaterBase));
	}
	
	public void OnEnable() 
	{
		Shader.EnableKeyword("WATER_VERTEX_DISPLACEMENT_ON");
		Shader.DisableKeyword("WATER_VERTEX_DISPLACEMENT_OFF");		
	}	

	public void OnDisable() 
	{
		Shader.EnableKeyword("WATER_VERTEX_DISPLACEMENT_OFF");
		Shader.DisableKeyword("WATER_VERTEX_DISPLACEMENT_ON");		
	}
	
	/*
	public float GetOffsetAt(Vector3 pos, int displacementMapAmounts = 3)
	{
		return 0.0f;	
	}
	
	public Vector3 GetNormalAt(Vector3 pos, float scale = 1.0F) 
	{
		return Vector3.one;
	}		
	*/
}