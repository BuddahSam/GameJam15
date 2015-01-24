public var faceValue = 0;

function OnTriggerEnter( other : Collider ) {

dieGameObject = GameObject.Find("SixSidedDie2");

dieValueComponent = dieGameObject.GetComponent("DieValue2");

dieValueComponent.currentValue = faceValue;

Debug.Log(faceValue);

}