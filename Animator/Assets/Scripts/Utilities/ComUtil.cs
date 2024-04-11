using UnityEngine;

public static class ComUtil
{
	public static bool AlmostEquals(this float standard, float target, float range = float.Epsilon)
	{
		return standard >= target - range && standard <= target + range;
	}

	public static bool AlmostEquals(this Vector2 standard, Vector2 target)
	{
		return standard.x.AlmostEquals(target.x) && standard.y.AlmostEquals(target.y);
	}
}