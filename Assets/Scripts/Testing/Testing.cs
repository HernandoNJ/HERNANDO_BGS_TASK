using UnityEngine;

namespace Assets.Scripts.Testing {
	public class Testing : MonoBehaviour {

		[SerializeField] private bool testingEnabled;
		public void TestFunctionCall(string textArg)
		{
			if (testingEnabled)
				Debug.Log(textArg);
		}
	}
}