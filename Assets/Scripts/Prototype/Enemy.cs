using UnityEngine;

namespace Patterns.Prototype
{
	public class Enemy : MonoBehaviour, ICopyable
	{
		public ICopyable Copy()
		{
			return Instantiate(this);
		}
	}
}
