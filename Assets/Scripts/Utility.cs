using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utility
{
	public static bool IsEqual(float a, float b)
	{
		//1/256�����l�ȉ��͌덷�Ƃ��Đ؂�̂�
		return MathF.Abs(a - b) <= 0.004f;
	}

}
