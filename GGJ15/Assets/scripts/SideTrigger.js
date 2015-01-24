public var faceValue = 0;

function OnTriggerEnter( other : Collider ) {

dieGameObject = GameObject.Find("SixSidedDie");

dieValueComponent = dieGameObject.GetComponent("DieValue");

dieValueComponent.currentValue = faceValue;

Debug.Log(faceValue);

}