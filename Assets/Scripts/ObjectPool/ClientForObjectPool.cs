using Patterns.ObjectPool.Zombies;
using UnityEngine;

namespace Patterns.ObjectPool
{
	public class ClientForObjectPool : MonoBehaviour
	{
		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.G))
			{
				var walker = ObjectPool.Instance.PullObject("Walker");
				walker.transform.Translate(Vector3.forward * Random.Range(-5.0f, 5.0f));
				walker.transform.Translate(Vector3.right * Random.Range(-5.0f, 5.0f));
			}

			if (Input.GetKeyDown(KeyCode.P))
			{
				var objs = FindObjectsOfType(typeof(GameObject));
				foreach (var o in objs)
				{
					var obj = (GameObject)o;
					if (obj.gameObject.GetComponent<Walker>() != null)
					{
						ObjectPool.Instance.PoolObject(obj);
					}
				}
			}
		}
	}
}
