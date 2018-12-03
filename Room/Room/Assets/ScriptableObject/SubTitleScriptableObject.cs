using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu( menuName = "MyGame/Create ParameterTable", fileName = "SubTitleTable" )]
public class SubTitleScriptableObject : ScriptableObject{
	[SerializeField]
    public List<SubTitleModel> SubTitleModels = new List<SubTitleModel>();

}